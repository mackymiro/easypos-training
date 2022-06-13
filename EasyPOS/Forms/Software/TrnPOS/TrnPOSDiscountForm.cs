using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.TrnPOS
{
    public partial class TrnPOSDiscountForm : Form
    {
        public TrnPOSBarcodeDetailForm trnPOSBarcodeDetailForm;
        public TrnPOSTouchDetailForm trnPOSTouchDetailForm;
        public TrnPOSQuickServiceDetailForm trnPOSQuickServiceDetailForm;
        public Decimal salesAmount = 0;
        List<Entities.TrnSalesLineEntity> listSalesLines = new List<Entities.TrnSalesLineEntity>();
        public static String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Settings/SysCurrent.json");

        public TrnPOSDiscountForm(TrnPOSBarcodeDetailForm salesDetailForm, TrnPOSTouchDetailForm POSTouchDetailForm, TrnPOSQuickServiceDetailForm POSQuickServiceDetailForm, Decimal amount, List<Entities.TrnSalesLineEntity> salesLines)
        {
            InitializeComponent();

            trnPOSBarcodeDetailForm = salesDetailForm;
            trnPOSTouchDetailForm = POSTouchDetailForm;
            trnPOSQuickServiceDetailForm = POSQuickServiceDetailForm;
            salesAmount = amount;
            listSalesLines = salesLines;

            textBoxTotalSalesAmount.Text = salesAmount.ToString("#,##0.00");
            textBoxDiscountRate.Text = "0";
            textBoxDiscountAmount.Text = "0.00";
            textBoxPax.Text = "1";
            textBoxDiscountedPax.Text = "1";


            GetSalesLine();
        }

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

        public void GetSalesLine()
        {
            if (listSalesLines.Any())
            {
                comboBoxItem.DataSource = listSalesLines;
                comboBoxItem.ValueMember = "ItemId";
                comboBoxItem.DisplayMember = "ItemDescription";
            }

            comboBoxItem.SelectedItem = null;
            comboBoxItem.SelectedIndex = -1;
            if (comboBoxItem.SelectedIndex == -1)
            {
                textBoxTotalSalesAmount.Text = salesAmount.ToString("#,##0.00");
            }

            GetDiscount();
        }

        public void GetDiscount()
        {
            Controllers.TrnSalesController trnSalesController = new Controllers.TrnSalesController();
            if (trnSalesController.DropdownListDiscount().Any())
            {
                comboBoxDiscount.DataSource = trnSalesController.DropdownListDiscount();
                comboBoxDiscount.ValueMember = "Id";
                comboBoxDiscount.DisplayMember = "Discount";

                comboBoxDiscount.SelectedValue = Modules.SysCurrentModule.GetCurrentSettings().DefaultDiscountId;

                GetSalesDiscountInformation();
            }
        }

        public void GetSalesDiscountInformation()
        {
            Controllers.TrnSalesController trnSalesController = new Controllers.TrnSalesController();

            Int32? discountId = null;
            String seniorCitizenID = "";
            String seniorCitizenName = "";
            String seniorCitizenAge = "";

            if (trnPOSBarcodeDetailForm != null)
            {
                discountId = trnSalesController.DiscountDetailSales(trnPOSBarcodeDetailForm.trnSalesEntity.Id).DiscountId;
                seniorCitizenID = trnSalesController.DiscountDetailSales(trnPOSBarcodeDetailForm.trnSalesEntity.Id).SeniorCitizenId;
                seniorCitizenName = trnSalesController.DiscountDetailSales(trnPOSBarcodeDetailForm.trnSalesEntity.Id).SeniorCitizenName;
                seniorCitizenAge = trnSalesController.DiscountDetailSales(trnPOSBarcodeDetailForm.trnSalesEntity.Id).SeniorCitizenAge.ToString();
            }

            if (trnPOSTouchDetailForm != null)
            {
                discountId = trnSalesController.DiscountDetailSales(trnPOSTouchDetailForm.trnSalesEntity.Id).DiscountId;
                seniorCitizenID = trnSalesController.DiscountDetailSales(trnPOSTouchDetailForm.trnSalesEntity.Id).SeniorCitizenId;
                seniorCitizenName = trnSalesController.DiscountDetailSales(trnPOSTouchDetailForm.trnSalesEntity.Id).SeniorCitizenName;
                seniorCitizenAge = trnSalesController.DiscountDetailSales(trnPOSTouchDetailForm.trnSalesEntity.Id).SeniorCitizenAge.ToString();
            }

            if (trnPOSQuickServiceDetailForm != null)
            {
                discountId = trnSalesController.DiscountDetailSales(trnPOSQuickServiceDetailForm.trnSalesEntity.Id).DiscountId;
                seniorCitizenID = trnSalesController.DiscountDetailSales(trnPOSQuickServiceDetailForm.trnSalesEntity.Id).SeniorCitizenId;
                seniorCitizenName = trnSalesController.DiscountDetailSales(trnPOSQuickServiceDetailForm.trnSalesEntity.Id).SeniorCitizenName;
                seniorCitizenAge = trnSalesController.DiscountDetailSales(trnPOSQuickServiceDetailForm.trnSalesEntity.Id).SeniorCitizenAge.ToString();
            }

            if (discountId != null)
            {
                comboBoxDiscount.SelectedValue = discountId;
                textBoxSeniorCitizenID.Text = seniorCitizenID;
                textBoxSeniorCitizenName.Text = seniorCitizenName;
                textBoxSeniorCitizenAge.Text = seniorCitizenAge;
            }
            else
            {
                textBoxSeniorCitizenAge.Text = "0";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Int32 discountId = Convert.ToInt32(comboBoxDiscount.SelectedValue);
            Decimal discountRate = Convert.ToDecimal(textBoxDiscountRate.Text);
            Decimal discountAmount = Convert.ToDecimal(textBoxDiscountAmount.Text);
            String seniorCitizenID = textBoxSeniorCitizenID.Text;
            String seniorCitizenName = textBoxSeniorCitizenName.Text;
            Int32 seniorCitizenAge = Convert.ToInt32(textBoxSeniorCitizenAge.Text);
            Int32 pax = Convert.ToInt32(textBoxPax.Text);
            Int32 discountedPax = Convert.ToInt32(textBoxDiscountedPax.Text);

            Entities.TrnSalesEntity salesEntity = new Entities.TrnSalesEntity()
            {
                DiscountId = discountId,
                DiscountRate = discountRate,
                DiscountAmount = discountAmount,
                SeniorCitizenId = seniorCitizenID,
                SeniorCitizenName = seniorCitizenName,
                SeniorCitizenAge = seniorCitizenAge,
                Pax = pax,
                DiscountedPax = discountedPax,
            };

            Controllers.TrnSalesController trnSalesController = new Controllers.TrnSalesController();

            String[] discountSales = new String[2];

            Int32? itemId = null;
            if (comboBoxItem.SelectedIndex > -1)
            {
                itemId = Convert.ToInt32(comboBoxItem.SelectedValue);
            }

            if (trnPOSBarcodeDetailForm != null)
            {
                discountSales = trnSalesController.DiscountSales(trnPOSBarcodeDetailForm.trnSalesEntity.Id, salesEntity, itemId);
            }

            if (trnPOSTouchDetailForm != null)
            {
                discountSales = trnSalesController.DiscountSales(trnPOSTouchDetailForm.trnSalesEntity.Id, salesEntity, itemId);
            }
            if (trnPOSQuickServiceDetailForm != null)
            {
                discountSales = trnSalesController.DiscountSales(trnPOSQuickServiceDetailForm.trnSalesEntity.Id, salesEntity, itemId);

            }

            if (discountSales[1].Equals("0") == false)
            {
                if (trnPOSBarcodeDetailForm != null)
                {
                    trnPOSBarcodeDetailForm.trnSalesEntity.DiscountId = discountId;
                    trnPOSBarcodeDetailForm.GetSalesLineList();
                }

                if (trnPOSTouchDetailForm != null)
                {
                    trnPOSTouchDetailForm.trnSalesEntity.DiscountId = discountId;
                    trnPOSTouchDetailForm.GetSalesLineList();
                }
                if (trnPOSQuickServiceDetailForm != null)
                {
                    trnPOSQuickServiceDetailForm.trnSalesEntity.DiscountId = discountId;
                    trnPOSQuickServiceDetailForm.GetSalesLineList();
                }

                Close();
            }
            else
            {
                MessageBox.Show(discountSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (trnPOSBarcodeDetailForm != null)
            {
                Int32 lastUserId = Modules.SysCurrentModule.GetCurrentSettings().LastUserId;
                Boolean isOverRide = Modules.SysCurrentModule.GetCurrentSettings().IsOverRide;
                if(isOverRide == true)
                {
                    trnPOSBarcodeDetailForm.OverrideSales(lastUserId, isOverRide);

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
                        CurrentUserId = currentSettings.CurrentUserId,
                        CurrentUserName = currentSettings.CurrentUserName,
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
                        IsOverRide = false,
                        PrinterReady = currentSettings.PrinterReady,
                        RLCServerIP = currentSettings.RLCServerIP,
                        EODPerformedDate = currentSettings.EODPerformedDate,
                        ShowServiceCharge = currentSettings.ShowServiceCharge
                    };
                    String newJson = new JavaScriptSerializer().Serialize(newSysCurrentEntities);
                    File.WriteAllText(path, newJson);
                }
            }
            if (trnPOSTouchDetailForm != null)
            {
                Int32 lastUserId = Modules.SysCurrentModule.GetCurrentSettings().LastUserId;
                Boolean isOverRide = Modules.SysCurrentModule.GetCurrentSettings().IsOverRide;
                if (isOverRide == true)
                {
                    trnPOSTouchDetailForm.OverrideSales(lastUserId, isOverRide);

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
                        CurrentUserId = currentSettings.CurrentUserId,
                        CurrentUserName = currentSettings.CurrentUserName,
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
                        IsOverRide = false,
                        PrinterReady = currentSettings.PrinterReady,
                        RLCServerIP = currentSettings.RLCServerIP,
                        EODPerformedDate = currentSettings.EODPerformedDate,
                        ShowServiceCharge = currentSettings.ShowServiceCharge
                    };
                    String newJson = new JavaScriptSerializer().Serialize(newSysCurrentEntities);
                    File.WriteAllText(path, newJson);
                }
            }
            if (trnPOSQuickServiceDetailForm != null)
            {
                Int32 lastUserId = Modules.SysCurrentModule.GetCurrentSettings().LastUserId;
                Boolean isOverRide = Modules.SysCurrentModule.GetCurrentSettings().IsOverRide;
                if (isOverRide == true)
                {
                    trnPOSQuickServiceDetailForm.OverrideSales(lastUserId, isOverRide);

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
                        CurrentUserId = currentSettings.CurrentUserId,
                        CurrentUserName = currentSettings.CurrentUserName,
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
                        IsOverRide = false,
                        PrinterReady = currentSettings.PrinterReady,
                        RLCServerIP = currentSettings.RLCServerIP,
                        EODPerformedDate = currentSettings.EODPerformedDate,
                        ShowServiceCharge = currentSettings.ShowServiceCharge
                    };
                    String newJson = new JavaScriptSerializer().Serialize(newSysCurrentEntities);
                    File.WriteAllText(path, newJson);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxSeniorCitizenAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDiscount.SelectedItem == null)
            {
                return;
            }

            var selectedItemDiscount = (Entities.MstDiscountEntity)comboBoxDiscount.SelectedItem;
            if (selectedItemDiscount != null)
            {
                if (selectedItemDiscount.DiscountRate == 0)
                {
                    textBoxDiscountAmount.Text = selectedItemDiscount.DiscountAmount.ToString("#,##0.00");
                    textBoxDiscountRate.Enabled = false;
                    textBoxDiscountAmount.Enabled = false;
                }

                if (selectedItemDiscount.DiscountAmount == 0)
                {
                    textBoxDiscountRate.Text = selectedItemDiscount.DiscountRate.ToString("#,##0.00");
                }

                if (selectedItemDiscount.Id == 3)
                {
                    textBoxDiscountRate.Enabled = true;
                    textBoxDiscountAmount.Enabled = true;

                }
                else
                {
                    textBoxDiscountRate.Enabled = false;
                    textBoxDiscountAmount.Enabled = false;
                }

                if (selectedItemDiscount.Id == 7 || selectedItemDiscount.Id == 16)
                {
                    textBoxSeniorCitizenID.Enabled = true;
                    textBoxSeniorCitizenName.Enabled = true;
                    textBoxSeniorCitizenAge.Enabled = true;
                }
                else
                {
                    textBoxSeniorCitizenID.Enabled = false;
                    textBoxSeniorCitizenName.Enabled = false;
                    textBoxSeniorCitizenAge.Enabled = false;

                    textBoxSeniorCitizenID.Text = String.Empty;
                    textBoxSeniorCitizenName.Text = String.Empty;
                    textBoxSeniorCitizenAge.Text = "0";
                }

                if (selectedItemDiscount.DiscountRate == 0)
                {
                    textBoxDiscountAmount.Text = selectedItemDiscount.DiscountAmount.ToString("#,##0.00");
                    ComputeDiscountRate();
                }

                if (selectedItemDiscount.DiscountAmount == 0)
                {
                    textBoxDiscountRate.Text = selectedItemDiscount.DiscountRate.ToString("#,##0.00");
                    ComputeDiscountAmount();
                }
            }
        }

        private void textBoxSeniorCitizenAge_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSeniorCitizenAge.Text))
            {
                textBoxSeniorCitizenAge.Text = "0";
            }
            else
            {
                textBoxSeniorCitizenAge.Text = Convert.ToDecimal(textBoxSeniorCitizenAge.Text).ToString("#,##0");
            }
        }

        private void textBoxDiscountRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxDiscountRate_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDiscountRate.Text))
            {
                textBoxDiscountRate.Text = "0.00";
            }
            else
            {
                ComputeDiscountAmount();
                textBoxDiscountRate.Text = Convert.ToDecimal(textBoxDiscountRate.Text).ToString();
            }
        }

        private void textBoxDiscountAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxDiscountAmount_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDiscountRate.Text))
            {
                textBoxDiscountAmount.Text = "0.00";
            }
            else
            {
                ComputeDiscountRate();
                textBoxDiscountAmount.Text = Convert.ToDecimal(textBoxDiscountAmount.Text).ToString("#,##0.00");
            }
        }

        public void ComputeDiscountRate()
        {
            Decimal discountAmount = Convert.ToDecimal(textBoxDiscountAmount.Text);
            Decimal discountRate = (discountAmount / Convert.ToDecimal(textBoxTotalSalesAmount.Text)) * 100;
            textBoxDiscountRate.Text = discountRate.ToString("#,##0.00");
        }

        public void ComputeDiscountAmount()
        {
            Decimal discountRate = Convert.ToDecimal(textBoxDiscountRate.Text);
            Decimal discountAmount = Convert.ToDecimal(textBoxTotalSalesAmount.Text) * (discountRate / 100);
            textBoxDiscountAmount.Text = discountAmount.ToString("#,##0.00");
        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxItem.SelectedItem == null)
            {
                return;
            }

            var selectedItem = (Entities.TrnSalesLineEntity)comboBoxItem.SelectedItem;
            if (selectedItem != null)
            {
                Decimal amount = selectedItem.Amount;
                textBoxTotalSalesAmount.Text = amount.ToString("#,##0.00");

                ComputeDiscountAmount();
            }
            else
            {
                textBoxTotalSalesAmount.Text = salesAmount.ToString("#,##0.00");
                ComputeDiscountAmount();
            }

            if (comboBoxItem.SelectedIndex == -1)
            {
                textBoxTotalSalesAmount.Text = salesAmount.ToString("#,##0.00");
                ComputeDiscountAmount();
            }
        }

        private void comboBoxItem_Leave(object sender, EventArgs e)
        {
            if (comboBoxItem.SelectedIndex == -1)
            {
                textBoxTotalSalesAmount.Text = salesAmount.ToString("#,##0.00");
                ComputeDiscountAmount();
            }
        }

        private void comboBoxItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxItem.SelectedIndex == -1)
            {
                textBoxTotalSalesAmount.Text = salesAmount.ToString("#,##0.00");
                ComputeDiscountAmount();
            }
        }

        private void comboBoxItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (comboBoxItem.SelectedIndex == -1)
            {
                textBoxTotalSalesAmount.Text = salesAmount.ToString("#,##0.00");
                ComputeDiscountAmount();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F2:
                    {
                        textBoxPax.Focus();

                        if (buttonSave.Enabled == true)
                        {
                            buttonSave.PerformClick();
                            Focus();
                        }

                        break;
                    }
                case Keys.Escape:
                    {
                        if (buttonClose.Enabled == true)
                        {
                            buttonClose.PerformClick();
                            Focus();
                        }

                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBoxPax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxPax_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPax.Text))
            {
                textBoxPax.Text = "0";
            }
            else
            {
                textBoxPax.Text = Convert.ToDecimal(textBoxPax.Text).ToString("#,##0");
            }
        }

        private void textBoxDiscountedPax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxDiscountedPax_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDiscountedPax.Text))
            {
                textBoxDiscountedPax.Text = "0";
            }
            else
            {
                textBoxDiscountedPax.Text = Convert.ToDecimal(textBoxDiscountedPax.Text).ToString("#,##0");
            }
        }

        private void textBoxDiscountRate_KeyDown(object sender, KeyEventArgs e)
        {
            //ComputeDiscountAmount();
        }

        private void textBoxDiscountAmount_KeyDown(object sender, KeyEventArgs e)
        {
            //ComputeDiscountRate();
        }

        private void pictureBoxNumpadRate_Click(object sender, EventArgs e)
        {
            if (textBoxDiscountRate.Enabled == true)
            {
                SysKeyboard.SysNumberForm sysKeyboardNumpadForm = new SysKeyboard.SysNumberForm(null, null, this,null, "DiscountRate");
                sysKeyboardNumpadForm.ShowDialog();
            }
        }

        private void pictureBoxSysNumpadAmount_Click(object sender, EventArgs e)
        {
            if (textBoxDiscountAmount.Enabled == true)
            {
                SysKeyboard.SysNumberForm sysKeyboardNumpadForm = new SysKeyboard.SysNumberForm(null, null, this, null, "DiscountAmount");
                sysKeyboardNumpadForm.ShowDialog();
            }
        }

        private void pictureBoxSysKeyboardId_Click(object sender, EventArgs e)
        {
            if (textBoxSeniorCitizenID.Enabled == true)
            {
                SysKeyboard.SysKeyboardForm sysKeyboardForm = new SysKeyboard.SysKeyboardForm(null, null, null, null, null, this,null,null,null, "Id");
                sysKeyboardForm.ShowDialog();
            }
        }

        private void pictureBoxKeyboardName_Click(object sender, EventArgs e)
        {
            if (textBoxSeniorCitizenName.Enabled == true)
            {
                SysKeyboard.SysKeyboardForm sysKeyboardForm = new SysKeyboard.SysKeyboardForm(null, null, null, null, null, this,null,null,null, "Name");
                sysKeyboardForm.ShowDialog();
            }
       
        }

        private void pictureBoxSysNumpadAge_Click(object sender, EventArgs e)
        {
            if (textBoxSeniorCitizenAge.Enabled == true)
            {
                SysKeyboard.SysNumberForm sysKeyboardNumpadForm = new SysKeyboard.SysNumberForm(null, null, this, null, "Age");
                sysKeyboardNumpadForm.ShowDialog();
            }
        }

        private void pictureBoxSysNumpadPax_Click(object sender, EventArgs e)
        {
            if (textBoxPax.Enabled == true)
            {
                SysKeyboard.SysNumberForm sysKeyboardNumpadForm = new SysKeyboard.SysNumberForm(null, null, this, null, "Pax");
                sysKeyboardNumpadForm.ShowDialog();
            }
        }

        private void pictureBoxDiscountedPax_Click(object sender, EventArgs e)
        {
            if (textBoxDiscountedPax.Enabled ==true)
            {
                SysKeyboard.SysNumberForm sysKeyboardNumpadForm = new SysKeyboard.SysNumberForm(null, null, this, null, "DiscountedPax");
                sysKeyboardNumpadForm.ShowDialog();
            }
            
        }

        public void getSysNumpadRate(Int32 number)
        {
            textBoxDiscountRate.Text = Convert.ToString(number);
        }
        public void getSysNumpadAmount(Int32 number)
        {
            textBoxDiscountAmount.Text = Convert.ToString(number);

        }
        public void getSysKeybordId(String text)
        {
            textBoxSeniorCitizenID.Text = text;
        }
        public void getSysKeybordName(String text)
        {
            textBoxSeniorCitizenName.Text = text;

        }
        public void getSysNumpadAge(Int32 number)
        {
            textBoxSeniorCitizenAge.Text = Convert.ToString(number);

        }
        public void getSysNumpadPax(Int32 number)
        {
            textBoxPax.Text = Convert.ToString(number);

        }
        public void getSysNumpadDPax(Int32 number)
        {
            textBoxDiscountedPax.Text = Convert.ToString(number);

        }
    }
}
