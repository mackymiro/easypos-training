using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace EasyPOS.LiteclerkIntegration.Controllers
{
     class LiteclerkTrnStockOutController
    {
        // ====
        // Data
        // ====
        private Data.easyposdbDataContext posdb = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        public Forms.Software.SysSettings.SysSettingsForm sysSettingsForm;
        public String activityDate;

        // ===========
        // Constructor
        // ===========
        public LiteclerkTrnStockOutController(Forms.Software.SysSettings.SysSettingsForm form, String actDate)
        {
            sysSettingsForm = form;
            activityDate = actDate;
        }

        // ===================
        // Fill Leading Zeroes
        // ===================
        public String FillLeadingZeroes(Int32 number, Int32 length)
        {
            var result = number.ToString();
            var pad = length - result.Length;
            while (pad > 0)
            {
                result = '0' + result;
                pad--;
            }

            return result;
        }
        // =============
        // Sync Stock In
        // =============
        public async void SyncStockOut(String apiUrlHost, String branchCode)
        {
            await GetStockOut(apiUrlHost, branchCode);
        }
        // ============
        // Get Stock In
        // ============
        public Task GetStockOut(String apiUrlHost, String branchCode)
        {
            try
            {
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                DateTime dateTimeToday = DateTime.Now;
                String stockOutDate = Convert.ToDateTime(activityDate).ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);

                // ============
                // Http Request
                // ============
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://" + apiUrlHost + "/api/EasyPOSTrnStockOutAPI/list/byOTDate/" + stockOutDate + "/byBranch/" + branchCode);
                httpWebRequest.Method = "GET";
                httpWebRequest.Accept = "application/json";

                // ================
                // Process Response
                // ================
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    List<Entities.LiteclerkTrnStockOut> stockOutLists = (List<Entities.LiteclerkTrnStockOut>)js.Deserialize(result, typeof(List<Entities.LiteclerkTrnStockOut>));

                    if (stockOutLists.Any())
                    {
                        foreach (var stockOut in stockOutLists)
                        {
                            var currentStockOut = from d in posdb.TrnStockOuts
                                                  where d.Remarks == "OT-" + stockOut.Branch.ManualCode + "-" + stockOut.OTNumber
                                                  && d.IsLocked == true
                                                  select d;

                            if (!currentStockOut.Any())
                            {
                                sysSettingsForm.logMessages("Saving Stock-Out...\r\n\n");
                                sysSettingsForm.logMessages("OT Number: OT-" + stockOut.Branch.ManualCode + "-" + stockOut.OTNumber + "\r\n\n");

                                var defaultPeriod = from d in posdb.MstPeriods select d;
                                var defaultSettings = from d in posdb.IntCloudSettings select d;
                                var defaultAccount = from d in posdb.MstAccounts select d;

                                String stockOutNumber = "0000000001";
                                var lastStockOut = from d in posdb.TrnStockOuts.OrderByDescending(d => d.Id) select d;
                                if (lastStockOut.Any())
                                {
                                    Int32 newStockInNumber = Convert.ToInt32(lastStockOut.FirstOrDefault().StockOutNumber) + 1;
                                    stockOutNumber = FillLeadingZeroes(newStockInNumber, 10);
                                }

                                Data.TrnStockOut newStockOut = new Data.TrnStockOut
                                {
                                    PeriodId = defaultPeriod.FirstOrDefault().Id,
                                    StockOutDate = Convert.ToDateTime(stockOut.OTDate),
                                    StockOutNumber = stockOutNumber,
                                    AccountId = defaultAccount.FirstOrDefault().Id,
                                    //ManualStockInNumber = null,
                                    //SupplierId = defaultSettings.FirstOrDefault().PostSupplierId,
                                    Remarks = "OT-" + stockOut.Branch.ManualCode + "-" + stockOut.OTNumber,
                                    //IsReturn = false,
                                    //CollectionId = null,
                                    PreparedBy = defaultSettings.FirstOrDefault().PostUserId,
                                    CheckedBy = defaultSettings.FirstOrDefault().PostUserId,
                                    ApprovedBy = defaultSettings.FirstOrDefault().PostUserId,
                                    //SalesId = null,
                                    IsLocked = true,
                                    EntryUserId = defaultSettings.FirstOrDefault().PostUserId,
                                    EntryDateTime = DateTime.Now,
                                    UpdateUserId = defaultSettings.FirstOrDefault().PostUserId,
                                    UpdateDateTime = DateTime.Now
                                };

                                posdb.TrnStockOuts.InsertOnSubmit(newStockOut);
                                posdb.SubmitChanges();

                                if (stockOut.StockOutItems.Any())
                                {
                                    foreach (var item in stockOut.StockOutItems.ToList())
                                    {
                                        var currentItem = from d in posdb.MstItems
                                                          where d.BarCode == item.Item.BarCode
                                                          && d.MstUnit.Unit == item.Unit.Unit
                                                          select d;
                                        if (currentItem.Any())
                                        {
                                            Data.TrnStockOutLine newStockOutLine = new Data.TrnStockOutLine
                                            {
                                                StockOutId = newStockOut.Id,
                                                ItemId = currentItem.FirstOrDefault().Id,
                                                UnitId = currentItem.FirstOrDefault().UnitId,
                                                Quantity = item.Quantity,
                                                Cost = item.Cost,
                                                Amount = item.Amount,
                                                //ExpiryDate = currentItem.FirstOrDefault().ExpiryDate,
                                                //LotNumber = currentItem.FirstOrDefault().LotNumber,
                                                AssetAccountId = currentItem.FirstOrDefault().AssetAccountId,
                                                //Price = currentItem.FirstOrDefault().Price,
                                            };

                                            posdb.TrnStockOutLines.InsertOnSubmit(newStockOutLine);

                                            var updateItem = currentItem.FirstOrDefault();
                                            updateItem.OnhandQuantity = currentItem.FirstOrDefault().OnhandQuantity - Convert.ToDecimal(item.Quantity);

                                            posdb.SubmitChanges();

                                            sysSettingsForm.logMessages(" > " + currentItem.FirstOrDefault().ItemDescription + " * " + item.Quantity.ToString("#,##0.00") + "\r\n\n");
                                        }
                                        else
                                        {
                                            sysSettingsForm.logMessages("No Item Available!\r\n\n");
                                        }
                                    }
                                }

                                sysSettingsForm.logMessages("Save Successful!\r\n\n");
                                sysSettingsForm.logMessages("Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n");
                                sysSettingsForm.logMessages("\r\n\n");
                            }
                        }
                    }
                }

                return Task.FromResult("");
            }
            catch (Exception e)
            {
                sysSettingsForm.logMessages("Stock-Out Integration Failed!\r\n\n");
                sysSettingsForm.logMessages("Error: " + e.Message + "\r\n\n");
                sysSettingsForm.logMessages("Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n");
                sysSettingsForm.logMessages("\r\n\n");

                return Task.FromResult("");
            }
        }

    }
}
