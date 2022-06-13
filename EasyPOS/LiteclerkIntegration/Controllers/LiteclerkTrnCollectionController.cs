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
     class LiteclerkTrnCollectionController
    {
        // ====
        // Data
        // ====
        private Data.easyposdbDataContext posdb = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());
        public Forms.Software.SysSettings.SysSettingsForm sysSettingsForm;

        // ===========
        // Constructor
        // ===========
        public LiteclerkTrnCollectionController(Forms.Software.SysSettings.SysSettingsForm form)
        {
            sysSettingsForm = form;
        }

        // ===============
        // Sync Collection
        // ===============
        public async void SyncCollection(String apiUrlHost, String branchCode, String userCode)
        {
            await GetCollection(apiUrlHost, branchCode, userCode);
        }
        // =========
        // Get Sales
        // =========
        public Task GetCollection(String apiUrlHost, String branchCode, String userCode)
        {
            try
            {
                var collection = from d in posdb.TrnCollections
                            where d.IsLocked == true
                            && d.IsCancelled == false
                            && d.SalesBalanceAmount > 0
                            && d.PostCode == null
                            select d;

                if (collection.Any())
                {
                    List<Entities.LiteclerkTrnPointOfSale> listPOSSales = new List<Entities.LiteclerkTrnPointOfSale>();
                    foreach (var collectionLine in collection.FirstOrDefault().TrnCollectionLines)
                    {
                        listPOSSales.Add(new Entities.LiteclerkTrnPointOfSale()
                        {
                            BranchCode = branchCode,
                            TerminalCode = collectionLine.TrnCollection.TrnSale.MstTerminal.Terminal,
                            POSDate = collectionLine.TrnCollection.TrnSale.SalesDate.ToShortDateString(),
                            POSNumber = collectionLine.TrnCollection.CollectionNumber,
                            OrderNumber = collectionLine.TrnCollection.TrnSale.SalesNumber,
                            CustomerCode = collectionLine.TrnCollection.TrnSale.MstCustomer.CustomerCode,
                            ItemCode = collectionLine.TrnCollection.TrnSale.TrnSalesLines.FirstOrDefault().MstItem.BarCode,
                            Particulars = collectionLine.TrnCollection.TrnSale.Remarks,
                            Quantity = collectionLine.TrnCollection.TrnSale.TrnSalesLines.FirstOrDefault().Quantity,
                            Price = collectionLine.TrnCollection.TrnSale.TrnSalesLines.FirstOrDefault().Price,
                            Discount = collectionLine.TrnCollection.TrnSale.TrnSalesLines.FirstOrDefault().DiscountAmount,
                            NetPrice = collectionLine.TrnCollection.TrnSale.TrnSalesLines.FirstOrDefault().NetPrice,
                            Amount = collectionLine.Amount,
                            TaxCode = collectionLine.TrnCollection.TrnSale.TrnSalesLines.FirstOrDefault().MstTax.Code,
                            TaxAmount = collectionLine.TrnCollection.TrnSale.TrnSalesLines.FirstOrDefault().TaxAmount,
                            CashierUserCode = collectionLine.TrnCollection.TrnSale.MstUser5.UserName,
                            TimeStamp = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt"),
                            PostCode = "",
                        });
                    }

                    String json = new JavaScriptSerializer().Serialize(listPOSSales);

                    sysSettingsForm.logMessages("Sending Partial Colelction...\r\n\n");
                    sysSettingsForm.logMessages("Sales Number: " + collection.FirstOrDefault().TrnSale.SalesNumber + "\r\n\n");
                    sysSettingsForm.logMessages("Sales Date: " + collection.FirstOrDefault().TrnSale.SalesDate.ToShortDateString() + "\r\n\n");
                    sysSettingsForm.logMessages("OR Number: " + collection.FirstOrDefault().TrnSale.CollectionNumber + "\r\n\n");
                    sysSettingsForm.logMessages("Amount: " + collection.FirstOrDefault().TrnCollectionLines.FirstOrDefault().Amount.ToString("#,##0.00") + "\r\n\n");

                    SendCollection(apiUrlHost, json, collection.FirstOrDefault().SalesId);
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

        // ===============
        // Send Collection
        // ===============
        public void SendCollection(String apiUrlHost, String json, Int32? salesId)
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
                        var collections = from d in posdb.TrnCollections
                                    where d.SalesId == salesId
                                    select d;

                        if (collections.Any())
                        {
                            var updateCollection = collections.FirstOrDefault();
                            updateCollection.PostCode = result.Replace("\"", "");
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
