using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace EasyPOS.Controllers
{
    class SysLoginController
    {


        public static String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Settings/SysCurrent.json");

        // ====================
        // Get Current Settings 
        // ====================
        public static Entities.SysCurrentEntity GetCurrentSettings()
        {
            String json;
            using (StreamReader trmRead = new StreamReader(path)) { json = trmRead.ReadToEnd(); }

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            Entities.SysCurrentEntity sysCurrentEntity = javaScriptSerializer.Deserialize<Entities.SysCurrentEntity>(json);

            return sysCurrentEntity;
        }

        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        // =====
        // Login
        // =====
        public String[] Login(String userCardNumber, String username, String password, String loginDate, Boolean isLoginDate, Boolean isOverride)
        {
            try
            {
                var currentUser = from d in db.MstUsers
                                  where d.UserName.Equals(username)
                                  && d.Password.Equals(password)
                                  || d.UserCardNumber.Equals(userCardNumber)
                                  select d;
               
                if (currentUser.Any())
                {

                    if (isOverride == false)
                    {
                        Modules.SysCurrentModule.UpdateCurrentSettingsLogin(currentUser.FirstOrDefault().Id, currentUser.FirstOrDefault().UserName, loginDate, isLoginDate);

                    }
                    else
                    {
                        var currentSettings = GetCurrentSettings();

                        Entities.SysCurrentEntity newSysCurrentEntities = new Entities.SysCurrentEntity()
                        {
                            CompanyName = currentSettings.CompanyName,
                            Address = currentSettings.Address,
                            ContactNo = currentSettings.ContactNo,
                            TIN = currentSettings.TIN,
                            AccreditationNo = currentSettings.AccreditationNo,
                            SerialNo = currentSettings.SerialNo,
                            PermitNo = currentSettings.PermitNo,
                            MachineNo = currentSettings.MachineNo,
                            DeclareRate = currentSettings.DeclareRate,
                            ReceiptFooter = currentSettings.ReceiptFooter,
                            InvoiceFooter = currentSettings.InvoiceFooter,
                            LicenseCode = currentSettings.LicenseCode,
                            TenantOf = currentSettings.TenantOf,
                            CurrentUserId = currentUser.FirstOrDefault().Id,
                            CurrentUserName = currentUser.FirstOrDefault().UserName,
                            CurrentVersion = currentSettings.CurrentVersion,
                            CurrentDeveloper = currentSettings.CurrentDeveloper,
                            CurrentSupport = currentSettings.CurrentSupport,
                            CurrentPeriodId = currentSettings.CurrentPeriodId,
                            CurrentDate = currentSettings.CurrentDate,
                            TerminalId = currentSettings.TerminalId,
                            WalkinCustomerId = currentSettings.WalkinCustomerId,
                            DefaultDiscountId = currentSettings.DefaultDiscountId,
                            ReturnSupplierId = currentSettings.ReturnSupplierId,
                            ORPrintTitle = currentSettings.ORPrintTitle,
                            IsTenderPrint = currentSettings.IsTenderPrint,
                            IsBarcodeQuantityAlwaysOne = currentSettings.IsBarcodeQuantityAlwaysOne,
                            WithCustomerDisplay = currentSettings.WithCustomerDisplay,
                            CustomerDisplayPort = currentSettings.CustomerDisplayPort,
                            CustomerDisplayBaudRate = currentSettings.CustomerDisplayBaudRate,
                            CustomerDisplayFirstLineMessage = currentSettings.CustomerDisplayFirstLineMessage,
                            CustomerDisplayIfCounterClosedMessage = currentSettings.CustomerDisplayIfCounterClosedMessage,
                            CollectionReport = currentSettings.CollectionReport,
                            ZReadingFooter = currentSettings.ZReadingFooter,
                            EasypayAPIURL = currentSettings.EasypayAPIURL,
                            EasypayDefaultUsername = currentSettings.EasypayDefaultUsername,
                            EasypayDefaultPassword = currentSettings.EasypayDefaultPassword,
                            EasypayMotherCardNumber = currentSettings.EasypayMotherCardNumber,
                            ActivateAuditTrail = currentSettings.ActivateAuditTrail,
                            FacepayImagePath = currentSettings.FacepayImagePath,
                            POSType = currentSettings.POSType,
                            AllowNegativeInventory = currentSettings.AllowNegativeInventory,
                            IsLoginDate = currentSettings.IsLoginDate,
                            EnableEasyShopIntegration = currentSettings.EnableEasyShopIntegration,
                            PromptLoginSales = currentSettings.PromptLoginSales,
                            PrinterType = currentSettings.PrinterType,
                            SwipeLogin = currentSettings.SwipeLogin,
                            WithdrawalFooter = currentSettings.WithdrawalFooter,
                            WithdrawalPrintTitle = currentSettings.WithdrawalPrintTitle,
                            DateLogin = currentSettings.DateLogin,
                            HideSalesAmount = currentSettings.HideSalesAmount,
                            HideStockInPriceAndCost = currentSettings.HideStockInPriceAndCost,
                            HideSalesItemDetail = currentSettings.HideSalesItemDetail,
                            HideItemListBarcode = currentSettings.HideItemListBarcode,
                            HideItemListItemCode = currentSettings.HideItemListItemCode,
                            //AllowCancelPreviousSales = currentSettings.AllowCancelPreviousSales,
                            LockAutoSales = currentSettings.LockAutoSales,
                            ShowCustomerInfo = currentSettings.ShowCustomerInfo,
                            ChoosePrinter = currentSettings.ChoosePrinter,
                            IsTriggeredQuantity = currentSettings.IsTriggeredQuantity,
                            EnableEditPrice = currentSettings.EnableEditPrice,
                            SalesOrderPrinterType = currentSettings.SalesOrderPrinterType,
                            TenantName = currentSettings.TenantName,
                            TenantCode = currentSettings.TenantCode,
                            SalesType = currentSettings.SalesType,
                            IPAddress = currentSettings.IPAddress,
                            ServerIP = currentSettings.ServerIP,
                            TenantID = currentSettings.TenantID,
                            FlashNotes = currentSettings.FlashNotes,
                            LastUserId = currentSettings.LastUserId,
                            IsOverRide = true,
                            PrinterReady = currentSettings.PrinterReady,
                            EODPerformedDate = currentSettings.EODPerformedDate,
                            RLCServerIP= currentSettings.RLCServerIP,
                            ShowServiceCharge = currentSettings.ShowServiceCharge
                        };
                        String newJson = new JavaScriptSerializer().Serialize(newSysCurrentEntities);
                        File.WriteAllText(path, newJson);
                    }
                    return new String[] { "", currentUser.FirstOrDefault().Id.ToString() };
                }
                else
                {
                    return new String[] { "Username or password is incorrect.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }
    }
}
