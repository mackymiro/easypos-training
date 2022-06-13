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
     class LiteclerkTrnSalesReturnExchangeController
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
        public LiteclerkTrnSalesReturnExchangeController(Forms.Software.SysSettings.SysSettingsForm form, String actDate)
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
        // Sync Sales
        // =============
        public async void SyncSalesReturn(String apiUrlHost, String branchCode, String userCode)
        {
            await GetSalesReturn(apiUrlHost, branchCode, userCode);
        }

        public Task GetSalesReturn(String apiUrlHost, String branchCode, String userCode)
        {
            try
            {
                var sales = from d in posdb.TrnSales
                            where d.IsLocked == true
                            && d.IsTendered == true
                            && d.IsCancelled == false
                            && d.IsReturned == true
                            && d.PostCode == null
                            select d;



                if (sales.Any())
                {
                    String collectionNumber = "0000000001";
                    var lastCollectionNumber = from d in posdb.TrnSales.OrderByDescending(d => d.Id)
                                               where d.CollectionNumber != null
                                               select d;
                    if (lastCollectionNumber.Any())
                    {
                        Int32 newCollectionNumber = Convert.ToInt32(lastCollectionNumber.FirstOrDefault().CollectionNumber) + 1;
                        collectionNumber = FillLeadingZeroes(newCollectionNumber, 10);
                    }

                    List<Entities.LiteclerkTrnPointOfSale> listPOSSales = new List<Entities.LiteclerkTrnPointOfSale>();
                    foreach (var salesLine in sales.FirstOrDefault().TrnSalesLines)
                    {
                        listPOSSales.Add(new Entities.LiteclerkTrnPointOfSale()
                        {
                            BranchCode = branchCode,
                            TerminalCode = salesLine.TrnSale.MstTerminal.Terminal,
                            POSDate = salesLine.TrnSale.SalesDate.ToShortDateString(),
                            POSNumber = collectionNumber,
                            OrderNumber = salesLine.TrnSale.SalesNumber,
                            CustomerCode = salesLine.TrnSale.MstCustomer.CustomerCode,
                            ItemCode = salesLine.MstItem.BarCode,
                            Particulars = salesLine.TrnSale.Remarks,
                            Quantity = salesLine.Quantity,
                            Price = salesLine.Price,
                            Discount = salesLine.DiscountAmount,
                            NetPrice = salesLine.NetPrice,
                            Amount = salesLine.Amount,
                            TaxCode = salesLine.MstTax.Code,
                            TaxAmount = salesLine.TaxAmount,
                            CashierUserCode = salesLine.TrnSale.MstUser5.UserName,
                            TimeStamp = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt"),
                            PostCode = ""
                        });
                    }

                    String json = new JavaScriptSerializer().Serialize(listPOSSales);

                    sysSettingsForm.logMessages("Sending Sales...\r\n\n");
                    sysSettingsForm.logMessages("Sales Number: " + sales.FirstOrDefault().SalesNumber + "\r\n\n");
                    sysSettingsForm.logMessages("Sales Date: " + sales.FirstOrDefault().SalesDate.ToShortDateString() + "\r\n\n");
                    sysSettingsForm.logMessages("OR Number: " + sales.FirstOrDefault().CollectionNumber + "\r\n\n");
                    sysSettingsForm.logMessages("Amount: " + sales.FirstOrDefault().Amount.ToString("#,##0.00") + "\r\n\n");

                    SendSales(apiUrlHost, json, sales.FirstOrDefault().Id);
                }
                return Task.FromResult("");
            }
            catch (Exception e)
            {
                sysSettingsForm.logMessages("Sales Error: " + e.Message + "\r\n\n");
                sysSettingsForm.logMessages("Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n");
                sysSettingsForm.logMessages("\r\n\n");

                return Task.FromResult("");
            }
        }

        // ==========
        // Send Sales
        // ==========
        public void SendSales(String apiUrlHost, String json, Int32 salesId)
        {
            try
            {
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                // ============
                // Http Request
                // ============
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://" + apiUrlHost + "/api/EasyPOSTrnPointOfSaleAPI/add");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.Accept = "*/*";

                // ====
                // Data
                // ====
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    List<Entities.LiteclerkTrnPointOfSale> POSSales = new JavaScriptSerializer().Deserialize<List<Entities.LiteclerkTrnPointOfSale>>(json);
                    streamWriter.Write(new JavaScriptSerializer().Serialize(POSSales));
                }

                // ================
                // Process Response
                // ================
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    if (result != null)
                    {
                        var sales = from d in posdb.TrnSales
                                    where d.Id == salesId
                                    select d;

                        if (sales.Any())
                        {
                            String collectionNumber = "0000000001";
                            var lastCollectionNumber = from d in posdb.TrnSales.OrderByDescending(d => d.Id)
                                                       where d.CollectionNumber != null
                                                       select d;
                            if (lastCollectionNumber.Any())
                            {
                                Int32 newCollectionNumber = Convert.ToInt32(lastCollectionNumber.FirstOrDefault().CollectionNumber) + 1;
                                collectionNumber = FillLeadingZeroes(newCollectionNumber, 10);
                            }

                            var updateSales = sales.FirstOrDefault();
                            updateSales.PostCode = result.Replace("\"", "");
                            updateSales.CollectionNumber = collectionNumber;
                            posdb.SubmitChanges();
                        }

                        sysSettingsForm.logMessages("Send Succesful!" + "\r\n\n");
                        sysSettingsForm.logMessages("Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n");
                        sysSettingsForm.logMessages("\r\n\n");
                    }
                }
            }
            catch (WebException we)
            {
                var resp = new StreamReader(we.Response.GetResponseStream()).ReadToEnd();

                sysSettingsForm.logMessages(resp.Replace("\"", "") + "\r\n\n");
                sysSettingsForm.logMessages("Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n");
                sysSettingsForm.logMessages("\r\n\n");
            }
        }
    }
}
