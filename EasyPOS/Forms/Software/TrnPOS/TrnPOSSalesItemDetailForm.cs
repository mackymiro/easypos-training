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
    public partial class TrnPOSSalesItemDetailForm : Form
    {
        public TrnPOSBarcodeDetailForm trnSalesDetailForm;
        public TrnPOSTouchDetailForm trnPOSTouchDetailForm;
        public TrnPOSQuickServiceDetailForm trnPOSQuickServiceDetailForm;
        public Entities.TrnSalesLineEntity trnSalesLineEntity;
        public Entities.TrnSalesEntity trnSalesEntity;
        public TrnPOSSearchItemForm trnPOSSearchItemForm;
        public Entities.MstItemEntity itemDetail;
        private Modules.SysUserRightsModule sysUserRights;

        public List<Entities.MstItemPriceEntity> itemPriceList;
        public static String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Settings/SysCurrent.json");

        public TrnPOSSalesItemDetailForm(TrnPOSBarcodeDetailForm salesDetailForm, TrnPOSTouchDetailForm POSTouchDetailForm, TrnPOSQuickServiceDetailForm POSQuickServiceDetailForm, Entities.TrnSalesLineEntity salesLineEntity, TrnPOSSearchItemForm posSearchItemForm)
        {
            InitializeComponent();

            trnSalesDetailForm = salesDetailForm;
            trnPOSTouchDetailForm = POSTouchDetailForm;
            trnPOSSearchItemForm = posSearchItemForm;
            trnSalesLineEntity = salesLineEntity;
            trnPOSQuickServiceDetailForm = POSQuickServiceDetailForm;

            sysUserRights = new Modules.SysUserRightsModule("TrnSalesDetail");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (sysUserRights.GetUserRights().CanDiscount == true)
                {
                    comboBoxSalesLineDiscount.Enabled = true;
                }
                else
                {
                    comboBoxSalesLineDiscount.Enabled = false;
                    pictureBoxDiscount.Enabled = false;
                    pictureBoxRate.Enabled = false;
                }

            }

            if (Modules.SysCurrentModule.GetCurrentSettings().EnableEditPrice == false)
            {
                textBoxSalesLinePrice.ReadOnly = true;
                pictureBoxPrice.Enabled = false;
            }
            else
            {
                textBoxSalesLinePrice.ReadOnly = false;
            }


            GetItemPriceList(trnSalesLineEntity.ItemId);
            GetItemDetail(trnSalesLineEntity.ItemId);
            GetDiscountList();

            textBoxSalesLineQuantity.Focus();
            textBoxSalesLineQuantity.SelectAll();
            if (Modules.SysCurrentModule.GetCurrentSettings().IsOverRide == true)
            {
                Int32 userId = Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId;
                OverrideSales(userId);
            }
            else
            {
                Int32 userId = Modules.SysCurrentModule.GetCurrentSettings().LastUserId;
                OverrideSales(userId);
            }
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

        public void OverrideSales(Int32 overrideUserId)
        {
            sysUserRights.OverrideUserRights(overrideUserId, "TrnSalesDetail");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (sysUserRights.GetUserRights().CanDiscount == true)
                {
                    comboBoxSalesLineDiscount.Enabled = true;
                }
                else
                {
                    comboBoxSalesLineDiscount.Enabled = false;
                }

                GetItemPriceList(trnSalesLineEntity.ItemId);
                GetItemDetail(trnSalesLineEntity.ItemId);
                GetDiscountList();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void GetDiscountList()
        {
            Controllers.TrnSalesLineController trnPOSSalesLineController = new Controllers.TrnSalesLineController();
            if (trnPOSSalesLineController.DropdownListDiscount().Any())
            {
                Int32? discountId = null;

                if (trnSalesDetailForm != null)
                {
                    discountId = trnSalesDetailForm.trnSalesEntity.DiscountId;
                }

                if (trnPOSTouchDetailForm != null)
                {
                    discountId = trnPOSTouchDetailForm.trnSalesEntity.DiscountId;
                }
                if (trnPOSQuickServiceDetailForm != null)
                {
                    discountId = trnPOSQuickServiceDetailForm.trnSalesEntity.DiscountId;
                }

                if (discountId != null)
                {
                    if (trnPOSSalesLineController.IsVATExempt(Convert.ToInt32(discountId)) == true)
                    {
                        var discounts = from d in trnPOSSalesLineController.DropdownListDiscount()
                                        select d;

                        comboBoxSalesLineDiscount.DataSource = discounts.ToList();
                        comboBoxSalesLineDiscount.ValueMember = "Id";
                        comboBoxSalesLineDiscount.DisplayMember = "Discount";

                    }
                    else
                    {
                        var discounts = from d in trnPOSSalesLineController.DropdownListDiscount()
                                        where d.Id != 7
                                        && d.Id != 16
                                        select d;

                        comboBoxSalesLineDiscount.DataSource = discounts.ToList();
                        comboBoxSalesLineDiscount.ValueMember = "Id";
                        comboBoxSalesLineDiscount.DisplayMember = "Discount";
                    }
                }
                else
                {
                    var discounts = from d in trnPOSSalesLineController.DropdownListDiscount()
                                    where d.Id != 7
                                    && d.Id != 16
                                    select d;

                    comboBoxSalesLineDiscount.DataSource = discounts.ToList();
                    comboBoxSalesLineDiscount.ValueMember = "Id";
                    comboBoxSalesLineDiscount.DisplayMember = "Discount";
                }

                GetSalesLineItemDetail();
            }
        }

        private void GetSalesLineItemDetail()
        {
            textBoxItemDescription.Text = trnSalesLineEntity.ItemDescription;
            textBoxSalesLineQuantity.Text = trnSalesLineEntity.Quantity.ToString("#,##0.00");
            textBoxSalesLineUnit.Text = trnSalesLineEntity.Unit;
            textBoxSalesLinePrice.Text = trnSalesLineEntity.Price.ToString("#,##0.00");
            comboBoxSalesLineDiscount.SelectedValue = trnSalesLineEntity.DiscountId;
            textBoxSalesLineDiscountRate.Text = trnSalesLineEntity.DiscountRate.ToString("#,##0.00");
            textBoxSalesLineDiscountAmount.Text = trnSalesLineEntity.DiscountAmount.ToString("#,##0.00");
            textBoxSalesLineNetPrice.Text = trnSalesLineEntity.NetPrice.ToString("#,##0.00");
            textBoxSalesLineAmount.Text = trnSalesLineEntity.Amount.ToString("#,##0.00");
            textBoxSalesLineVAT.Text = trnSalesLineEntity.Tax;
            textBoxSalesLineVATRate.Text = trnSalesLineEntity.TaxRate.ToString("#,##0.00");
            textBoxSalesLineVATAmount.Text = trnSalesLineEntity.TaxAmount.ToString("#,##0.00");
            textBoxSalesLineRemarks.Text = trnSalesLineEntity.Preparation;

            Int32? discountId = null;

            if (trnSalesDetailForm != null)
            {
                discountId = trnSalesDetailForm.trnSalesEntity.DiscountId;
            }

            if (trnPOSTouchDetailForm != null)
            {
                discountId = trnPOSTouchDetailForm.trnSalesEntity.DiscountId;
            }
            if (trnPOSQuickServiceDetailForm != null)
            {
                discountId = trnPOSQuickServiceDetailForm.trnSalesEntity.DiscountId;
            }

            if (discountId != null)
            {
                Controllers.TrnSalesLineController trnPOSSalesLineController = new Controllers.TrnSalesLineController();
                if (trnPOSSalesLineController.IsVATExempt(Convert.ToInt32(discountId)) == true)
                {
                    comboBoxSalesLineDiscount.Enabled = false;
                }
                else
                {
                    comboBoxSalesLineDiscount.Enabled = true;
                }
            }
        }

        public void SaveSalesLine()
        {
            Entities.TrnSalesLineEntity newSalesLineEntity = new Entities.TrnSalesLineEntity()
            {
                Id = trnSalesLineEntity.Id,
                SalesId = trnSalesLineEntity.SalesId,
                ItemId = trnSalesLineEntity.ItemId,
                ItemDescription = trnSalesLineEntity.ItemDescription,
                UnitId = trnSalesLineEntity.UnitId,
                Unit = trnSalesLineEntity.Unit,
                Price = Convert.ToDecimal(textBoxSalesLinePrice.Text),
                DiscountId = Convert.ToInt32(comboBoxSalesLineDiscount.SelectedValue),
                Discount = trnSalesLineEntity.Discount,
                DiscountRate = Convert.ToDecimal(textBoxSalesLineDiscountRate.Text),
                DiscountAmount = Convert.ToDecimal(textBoxSalesLineDiscountAmount.Text),
                NetPrice = Convert.ToDecimal(textBoxSalesLineNetPrice.Text),
                Quantity = Convert.ToDecimal(textBoxSalesLineQuantity.Text),
                Amount = Convert.ToDecimal(textBoxSalesLineAmount.Text),
                TaxId = trnSalesLineEntity.TaxId,
                Tax = trnSalesLineEntity.Tax,
                TaxRate = trnSalesLineEntity.TaxRate,
                TaxAmount = Convert.ToDecimal(textBoxSalesLineVATAmount.Text),
                SalesAccountId = trnSalesLineEntity.SalesAccountId,
                AssetAccountId = trnSalesLineEntity.AssetAccountId,
                CostAccountId = trnSalesLineEntity.CostAccountId,
                TaxAccountId = trnSalesLineEntity.TaxAccountId,
                SalesLineTimeStamp = trnSalesLineEntity.SalesLineTimeStamp,
                UserId = trnSalesLineEntity.UserId,
                Preparation = textBoxSalesLineRemarks.Text,
                Price1 = 0,
                Price2 = 0,
                Price2LessTax = 0,
                PriceSplitPercentage = 0,
                IsPrinted = false
            };

            Controllers.TrnSalesLineController trnPOSSalesLineController = new Controllers.TrnSalesLineController();
            if (newSalesLineEntity.Id == 0)
            {
                String[] addSales = trnPOSSalesLineController.AddSalesLine(newSalesLineEntity);
                if (addSales[1].Equals("0") == false)
                {
                    if (trnSalesDetailForm != null)
                    {
                        trnSalesDetailForm.GetSalesLineList();
                    }

                    if (trnPOSTouchDetailForm != null)
                    {
                        trnPOSTouchDetailForm.GetSalesLineList();
                        trnPOSTouchDetailForm.UpdatePOSTouchSalesListDataSource();
                    }
                    if (trnPOSQuickServiceDetailForm != null)
                    {
                        trnPOSQuickServiceDetailForm.GetSalesLineList();
                        trnPOSQuickServiceDetailForm.UpdatePOSTouchSalesListDataSource();
                    }

                    if (trnPOSSearchItemForm != null)
                    {
                        trnPOSSearchItemForm.resetCursor();
                    }

                    Close();
                }
                else
                {
                    MessageBox.Show(addSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                String[] addSales = trnPOSSalesLineController.UpdateSalesLine(trnSalesLineEntity.Id, newSalesLineEntity);
                if (addSales[1].Equals("0") == false)
                {
                    if (trnSalesDetailForm != null)
                    {
                        trnSalesDetailForm.GetSalesLineList();
                    }

                    if (trnPOSTouchDetailForm != null)
                    {
                        trnPOSTouchDetailForm.GetSalesLineList();
                    }
                    if (trnPOSQuickServiceDetailForm != null)
                    {
                        trnPOSQuickServiceDetailForm.GetSalesLineList();
                    }

                    Close();
                }
                else
                {
                    MessageBox.Show(addSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        //private bool CheckFormOpened(string name)
        //{
        //    FormCollection fc = Application.OpenForms;

        //    foreach (Form frm in fc)
        //    {
        //        if (frm.Name == name)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Controllers.MstItemPriceController priceCotroller = new Controllers.MstItemPriceController();
            if (Modules.SysCurrentModule.GetCurrentSettings().IsTriggeredQuantity == true)
            {
                List<Entities.MstItemPriceEntity> triggerPrices = priceCotroller.TriggeredItemPrice(
                    trnSalesLineEntity.ItemId,
                    Convert.ToDecimal(textBoxSalesLineQuantity.Text),
                    Convert.ToDecimal(textBoxSalesLinePrice.Text)
                );

                if (triggerPrices.Any())
                {
                    textBoxSalesLinePrice.Text = priceCotroller.TriggeredItemPrice(trnSalesLineEntity.ItemId, Convert.ToDecimal(textBoxSalesLineQuantity.Text), Convert.ToDecimal(textBoxSalesLinePrice.Text)).FirstOrDefault().Price.ToString("#,##0.00");
                }
                //else 
                //{
                //    textBoxSalesLinePrice.Text = itemDetail.Price.ToString("#,##0.00");
                //}
            }
            if (trnSalesDetailForm != null)
            {
                Int32 lastUserId = Modules.SysCurrentModule.GetCurrentSettings().LastUserId;
                Boolean isOverRide = Modules.SysCurrentModule.GetCurrentSettings().IsOverRide;
                if (isOverRide == true)
                {
                    trnSalesDetailForm.OverrideSales(lastUserId, isOverRide);

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

            ComputeAmount();
            SaveSalesLine();
            //if (CheckFormOpened("TrnPOSSearchItemForm") == true)
            //{
            //    TrnPOSSearchItemForm trnSalesDetailSearchItemForm = new TrnPOSSearchItemForm(null, null, trnSalesEntity);
            //    trnSalesDetailSearchItemForm.Close();
            //}

            //TrnPOSSearchItemForm trnSalesDetailSearchItemForms = new TrnPOSSearchItemForm(null, null, trnSalesEntity);
            //trnSalesDetailSearchItemForms.ShowDialog();
        }

        private void comboBoxSalesLineDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSalesLineDiscount.SelectedItem == null)
            {
                return;
            }

            var selectedItemDiscount = (Entities.MstDiscountEntity)comboBoxSalesLineDiscount.SelectedItem;
            if (selectedItemDiscount != null)
            {
                if (selectedItemDiscount.Id == 3)
                {
                    textBoxSalesLineDiscountRate.ReadOnly = false;
                    textBoxSalesLineDiscountAmount.ReadOnly = false;

                    textBoxSalesLineDiscountRate.Text = trnSalesLineEntity.DiscountRate.ToString();
                    textBoxSalesLineDiscountAmount.Text = trnSalesLineEntity.DiscountAmount.ToString();
                }
                else
                {
                    textBoxSalesLineDiscountRate.ReadOnly = true;
                    textBoxSalesLineDiscountAmount.ReadOnly = true;
                    if (selectedItemDiscount.DiscountRate == 0)
                    {
                        textBoxSalesLineDiscountAmount.Text = selectedItemDiscount.DiscountAmount.ToString("#,##0.00");
                    }
                    if (selectedItemDiscount.DiscountAmount == 0)
                    {
                        textBoxSalesLineDiscountRate.Text = selectedItemDiscount.DiscountRate.ToString("#,##0.00");
                    }
                }
                if (selectedItemDiscount.DiscountRate == 0)
                {
                    textBoxSalesLineDiscountAmount.Text = selectedItemDiscount.DiscountAmount.ToString("#,##0.00");
                    ComputeDiscountRate();
                }
                ComputeAmount();
            }
        }

        public void ComputeAmount()
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxSalesLinePrice.Text) == false)
                {
                    Decimal quantity = Convert.ToDecimal(textBoxSalesLineQuantity.Text);
                    Decimal price = Convert.ToDecimal(textBoxSalesLinePrice.Text);
                    Decimal discountRate = Convert.ToDecimal(textBoxSalesLineDiscountRate.Text);
                    Decimal taxRate = trnSalesLineEntity.TaxRate;

                    Decimal discountAmount = Convert.ToDecimal(textBoxSalesLineDiscountAmount.Text);
                    if (discountRate > 0)
                    {
                        discountAmount = price * (discountRate / 100);
                    }

                    Decimal netPrice = price - discountAmount;
                    Decimal amount = netPrice * quantity;

                    Decimal taxAmount = 0;
                    if (taxRate > 0)
                    {
                        taxAmount = ((price / (1 + (taxRate / 100)) * (taxRate / 100)) * quantity);
                    }

                    textBoxSalesLineDiscountAmount.Text = discountAmount.ToString("#,##0.00");
                    textBoxSalesLineNetPrice.Text = netPrice.ToString("#,##0.00");
                    textBoxSalesLineAmount.Text = amount.ToString("#,##0.00");
                    textBoxSalesLineVATAmount.Text = taxAmount.ToString("#,##0.00");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSalesLineQuantity_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSalesLineQuantity.Text))
            {
                textBoxSalesLineQuantity.Text = "0.00";
            }

            ComputeAmount();
        }

        private void textBoxSalesLineQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxSalesLineQuantity_Leave(object sender, EventArgs e)
        {
            textBoxSalesLineQuantity.Text = Convert.ToDecimal(textBoxSalesLineQuantity.Text).ToString("#,##0.00");
        }

        private void textBoxSalesLineQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    SaveSalesLine();
            //}
        }

        private void textBoxSalesLinePrice_Click(object sender, EventArgs e)
        {
            TrnPOSItemPriceForm trnSalesDetailSalesItemDetailItemPriceForm = new TrnPOSItemPriceForm(this, trnSalesLineEntity);
            trnSalesDetailSalesItemDetailItemPriceForm.ShowDialog();
        }

        public void UpdatePrice(Decimal price, Decimal quantity)
        {
            textBoxSalesLinePrice.Text = price.ToString("#,##0.00");
            textBoxSalesLineQuantity.Text = quantity.ToString("#,##0.00");
            ComputeAmount();
        }



        private void textBoxSalesLineDiscountRate_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSalesLineDiscountRate.Text))
            {
                textBoxSalesLineDiscountRate.Text = "0.00";
            }
            else
            {
                ComputeAmount();
                textBoxSalesLineDiscountRate.Text = Convert.ToDecimal(textBoxSalesLineDiscountRate.Text).ToString();
            }
        }

        private void textBoxSalesLineDiscountAmount_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSalesLineDiscountAmount.Text))
            {
                textBoxSalesLineDiscountAmount.Text = "0.00";
            }
            else
            {
                ComputeDiscountRate();
                textBoxSalesLineDiscountAmount.Text = Convert.ToDecimal(textBoxSalesLineDiscountAmount.Text).ToString();
            }
        }
        public void ComputeDiscountRate()
        {
            Decimal discountAmount = Convert.ToDecimal(textBoxSalesLineDiscountAmount.Text);
            if (discountAmount > 0)
            {
                Decimal quantity = Convert.ToDecimal(textBoxSalesLineQuantity.Text);
                Decimal price = Convert.ToDecimal(textBoxSalesLinePrice.Text);
                Decimal amount = quantity * price;

                Decimal discountRate = (discountAmount / amount) * 100;
                textBoxSalesLineDiscountRate.Text = discountRate.ToString("#,##0.00");
                ComputeAmount();
            }
            else
            {
                textBoxSalesLineDiscountRate.Text = "0";
                ComputeAmount();
            }
        }

        private void textBoxSalesLineDiscountRate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxSalesLineDiscountAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    {
                        if (buttonSave.Enabled == true)
                        {
                            ComputeAmount();
                            buttonSave.PerformClick();
                            Close();
                        }

                        break;
                    }
                case Keys.Escape:
                    {
                        Close();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void GetItemPriceList(Int32 itemId)
        {
            Controllers.MstItemPriceController mstItemPriceController = new Controllers.MstItemPriceController();

            var _itemPriceList = mstItemPriceController.ListItemPrice(itemId);

            if (_itemPriceList.Any())
            {
                itemPriceList = _itemPriceList;
            }
        }

        private void GetItemDetail(Int32 itemId)
        {
            Controllers.MstItemController mstItemController = new Controllers.MstItemController();
            var _itemDetail = mstItemController.DetailItem(itemId);

            if (_itemDetail != null)
            {
                itemDetail = _itemDetail;
            }
        }

        private void textBoxSalesLinePrice_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSalesLinePrice.Text))
            {
                textBoxSalesLinePrice.Text = "0.00";
            }

            ComputeAmount();
        }

        private void pictureBoxNumpad_Click(object sender, EventArgs e)
        {
            SysKeyboard.SysNumberForm sysKeyboardNumpadForm = new SysKeyboard.SysNumberForm(this, null, null, null, "Quantity");
            sysKeyboardNumpadForm.ShowDialog();
        }

        private void pictureBoxKeyboard_Click(object sender, EventArgs e)
        {
            SysKeyboard.SysKeyboardForm sysKeyboardForm = new SysKeyboard.SysKeyboardForm(this, null, null, null, null, null, null, null, null, "Remarks");
            sysKeyboardForm.ShowDialog();
        }

        private void pictureBoxPrice_Click(object sender, EventArgs e)
        {
            SysKeyboard.SysNumberForm sysKeyboardNumpadForm = new SysKeyboard.SysNumberForm(this, null, null, null, "Price");
            sysKeyboardNumpadForm.ShowDialog();
        }

        private void pictureBoxDiscount_Click(object sender, EventArgs e)
        {
            SysKeyboard.SysNumberForm sysKeyboardNumpadForm = new SysKeyboard.SysNumberForm(this, null, null, null, "DiscountAmount");
            sysKeyboardNumpadForm.ShowDialog();
        }

        private void pictureBoxRate_Click(object sender, EventArgs e)
        {
            SysKeyboard.SysNumberForm sysKeyboardNumpadForm = new SysKeyboard.SysNumberForm(this, null, null, null, "DiscountRate");
            sysKeyboardNumpadForm.ShowDialog();
        }

        public void getSysNumpadQuantity(Int32 quanity)
        {
            textBoxSalesLineQuantity.Text = Convert.ToString(quanity);
            ComputeAmount();
        }
        public void getSysNumpadPrice(Decimal price)
        {
            textBoxSalesLinePrice.Text = price.ToString("#,##0.00");
            ComputeAmount();
        }
        public void getSysNumpadDiscount(Decimal discount)
        {
            textBoxSalesLineDiscountAmount.Text = discount.ToString("#,##0.00");
            ComputeAmount();
        }

        public void getSysNumpadDiscountRate(Decimal discount)
        {
            textBoxSalesLineDiscountRate.Text = discount.ToString("#,##0.00");
            ComputeAmount();
        }
        public void getSysKeyboardRemarks(String text)
        {
            textBoxSalesLineRemarks.Text = text;
        }

    }
}
