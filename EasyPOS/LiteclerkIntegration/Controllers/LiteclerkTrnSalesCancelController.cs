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
     class LiteclerkTrnSalesCancelController
    { // ====
        // Data
        // ====
        private Data.easyposdbDataContext posdb = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        public Forms.Software.SysSettings.SysSettingsForm sysSettingsForm;
        public String activityDate;

        // ===========
        // Constructor
        // ===========
        public LiteclerkTrnSalesCancelController(Forms.Software.SysSettings.SysSettingsForm form, String actDate)
        {
            sysSettingsForm = form;
            activityDate = actDate;
        }

        // ===========
        // Sync Sales
        // ===========
        public async void SyncSalesCancelled(String apiUrlHost, String branchCode)
        {
            await GetSalesCancelled(apiUrlHost, branchCode);
        }

        public Task GetSalesCancelled(String apiUrlHost, String branchCode)
        {
            try
            {
                var unpostedSales = from d in posdb.TrnSales
                                    where d.IsLocked == true
                                    && d.IsCancelled == true
                                    && d.PostCode != null
                                    && d.CancelPostCode == null
                                    select d;

                if (unpostedSales.Any())
                {
                    Int32 salesId = unpostedSales.FirstOrDefault().Id;


                    sysSettingsForm.logMessages("Sending Sales...\r\n\n");
                    sysSettingsForm.logMessages("Sales Number: " + unpostedSales.FirstOrDefault().SalesNumber + "\r\n\n");
                    sysSettingsForm.logMessages("Sales Date: " + unpostedSales.FirstOrDefault().SalesDate.ToShortDateString() + "\r\n\n");
                    sysSettingsForm.logMessages("OR Number: " + unpostedSales.FirstOrDefault().TrnCollections.FirstOrDefault().CollectionNumber + "\r\n\n");

                    ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                    var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://" + apiUrlHost + "/api/EasyPOSTrnSalesCancelAPI/update/" + unpostedSales.FirstOrDefault().SalesNumber + "/" + branchCode);
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Method = "PUT";
                    httpWebRequest.Accept = "*/*";

                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        streamWriter.Write(new JavaScriptSerializer().Serialize(""));
                    }

                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        if (result == "Success")
                        {
                            var sales = from d in posdb.TrnSales
                                        where d.Id == salesId
                                        select d;

                            if (sales.Any())
                            {
                                var updateSales = sales.FirstOrDefault();
                                updateSales.CancelPostCode = true;
                                posdb.SubmitChanges();
                            }

                            sysSettingsForm.logMessages("Send Succesful!" + "\r\n\n");
                            sysSettingsForm.logMessages("Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n");
                            sysSettingsForm.logMessages("\r\n\n");
                        }
                    }
                }

                return Task.FromResult("");
            }
            catch (WebException we)
            {
                var resp = new StreamReader(we.Response.GetResponseStream()).ReadToEnd();

                sysSettingsForm.logMessages(resp.Replace("\"", "") + "\r\n\n");
                sysSettingsForm.logMessages("Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n");
                sysSettingsForm.logMessages("\r\n\n");

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
    }
}
