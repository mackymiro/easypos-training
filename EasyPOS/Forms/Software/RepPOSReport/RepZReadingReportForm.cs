﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.RepPOSReport
{
    public partial class RepZReadingReportForm : Form
    {
        private Modules.SysUserRightsModule sysUserRights;

        public Forms.Software.RepPOSReport.RepPOSReportForm repPOSReportForm;
        public Int32 filterTerminalId;
        public String filterTerminal = "";
        public DateTime filterDate;
        public Entities.RepPOSReportZReadingReportEntity zReadingReportEntity;
        public static String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Settings/SysCurrent.json");
        public RepZReadingReportForm(Forms.Software.RepPOSReport.RepPOSReportForm POSReportForm, Int32 terminalId, DateTime date)
        {
            InitializeComponent();

            sysUserRights = new Modules.SysUserRightsModule("RepPOS (Z Reading)");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (sysUserRights.GetUserRights().CanPrint == false)
                {
                    buttonPrint.Enabled = false;
                }
            }

            repPOSReportForm = POSReportForm;
            filterTerminalId = terminalId;
            filterDate = date;
            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
            {
                printDocumentZReadingReport.DefaultPageSettings.PaperSize = new PaperSize("Z Reading Report", 255, 1000);
                ZReadingDataSource();
            }
            else
            {
                printDocumentZReadingReport.DefaultPageSettings.PaperSize = new PaperSize("Z Reading Report", 270, 1000);
                ZReadingDataSource();
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

        public void CreateAndSendFile()
        {
            RepRobinsonsReportForm robinsonsReportForm = new RepRobinsonsReportForm(repPOSReportForm, filterTerminalId, filterDate);
            robinsonsReportForm.CreateFile();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            DialogResult printerDialogResult = printDialogZReadingReport.ShowDialog();
            if (printerDialogResult == DialogResult.OK)
            {
                PrintReport();
                Close();
            }

            if (Modules.SysCurrentModule.GetCurrentSettings().TenantOf == "RLC")
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
                    IsOverRide = true,
                    PrinterReady = currentSettings.PrinterReady,
                    RLCServerIP = currentSettings.RLCServerIP,
                    EODPerformedDate = filterDate.ToShortDateString(),
                    ShowServiceCharge = currentSettings.ShowServiceCharge
                };
                String newJson = new JavaScriptSerializer().Serialize(newSysCurrentEntities);
                File.WriteAllText(path, newJson);

                CreateAndSendFile();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void PrintReport()
        {
            printDocumentZReadingReport.Print();  
        }

        public void ZReadingDataSource()
        {

            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());
            Entities.RepPOSReportZReadingReportEntity repZReadingReportEntity = new Entities.RepPOSReportZReadingReportEntity()
            {
                Terminal = "",
                Date = "",
                TotalGrossSales = 0,
                TotalRegularDiscount = 0,
                TotalSeniorDiscount = 0,
                TotalPWDDiscount = 0,
                TotalSalesReturn = 0,
                TotalNetSales = 0,
                CollectionLines = new List<Entities.TrnCollectionLineEntity>(),
                TotalRefund = 0,
                TotalCollection = 0,
                TotalVATSales = 0,
                TotalVATAmount = 0,
                TotalNonVAT = 0,
                TotalVATExclusive = 0,
                TotalVATExempt = 0,
                TotalVATZeroRated = 0,
                CounterIdStart = "0000000000",
                CounterIdEnd = "0000000000",
                TotalCancelledTrnsactionCount = 0,
                TotalCancelledAmount = 0,
                TotalNumberOfTransactions = 0,
                TotalNumberOfSKU = 0,
                TotalQuantity = 0,
                GrossSalesTotalPreviousReading = 0,
                GrossSalesRunningTotal = 0,
                NetSalesTotalPreviousReading = 0,
                NetSalesRunningTotal = 0,
                ZReadingCounter = "0",
                TotalNonTaxableSalesAmount = 0,
                TotalGCCash = 0,
                TotalServiceCharge = 0,
            };

            repZReadingReportEntity.Date = filterDate.ToShortDateString();

            var terminal = from d in db.MstTerminals
                           where d.Id == filterTerminalId
                           select d;

            if (terminal.Any())
            {
                filterTerminal = terminal.FirstOrDefault().Terminal;
            }

            Decimal currentDeclareRate = 0;

            var currentSysDeclareRate = from d in db.SysDeclareRates
                                        where d.Date == filterDate
                                        select d;

            if (currentSysDeclareRate.Any())
            {
                if (currentSysDeclareRate.FirstOrDefault().DeclareRate != null)
                {
                    currentDeclareRate = Convert.ToDecimal(currentSysDeclareRate.FirstOrDefault().DeclareRate);
                }
            }
            else
            {
                currentDeclareRate = Modules.SysCurrentModule.GetCurrentSettings().DeclareRate;
            }
            //&& d.TrnSale.IsReturned == false
            var currentCollectionSalesLineQuery = from d in db.TrnSalesLines
                                                  where d.TrnSale.TrnCollections.Any() == true
                                                  && d.TrnSale.TrnCollections.Where(
                                                      c => c.TerminalId == filterTerminalId &&
                                                           c.CollectionDate == filterDate &&
                                                           c.IsLocked == true &&
                                                           c.IsCancelled == false &&
                                                           c.SalesId != null).Any() == true
                                                  && d.TrnSale.IsLocked == true
                                                  && d.TrnSale.IsCancelled == false
                                                  select d;

            if (currentCollectionSalesLineQuery.Any())
            {
                Decimal totalGrossSales = 0;
                Decimal totalNonTaxableGrossSales = 0;
                Decimal totalRegularDiscount = 0;
                Decimal totalSeniorCitizenDiscount = 0;
                Decimal totalPWDDiscount = 0;
                Decimal totalSalesReturn = 0;
                Decimal totalVATSales = 0;
                Decimal totalVATAmount = 0;
                Decimal totalNonVATSales = 0;
                Decimal totalVATExemptSales = 0;
                Decimal totalVATZeroRatedSales = 0;
                Decimal totalNoOfSKUs = 0;
                Decimal totalQUantity = 0;
                Decimal totalNonTaxableSales = 0;
                Decimal totalServiceCharge = 0;

                var salesLinesQuery = from d in currentCollectionSalesLineQuery
                                      where d.Quantity > 0
                                      select d;

                if (salesLinesQuery.Any())
                {
                    totalNoOfSKUs += salesLinesQuery.Count();
                    totalQUantity += salesLinesQuery.Sum(d => d.Quantity);
                    totalServiceCharge = salesLinesQuery.GroupBy(x => x.TrnSale).Sum(j => j.Key.ServiceChargeAmount);

                    var salesLines = salesLinesQuery.ToArray();

                    totalNonTaxableSales = salesLines.Sum(d => d.MstTax.Code == "EXEMPTVAT" ? ((d.Price - d.DiscountAmount) * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : 0);

                    //totalGrossSales = salesLines.Sum(d =>
                    //    d.MstTax.Code == "EXEMPTVAT" ?
                    //        d.MstItem.MstTax1.Rate > 0 ?
                    //            (d.Price * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : d.Price * d.Quantity
                    //    : d.MstTax.Rate > 0 ?
                    //            (d.Price * d.Quantity) - d.TaxAmount : d.Price * d.Quantity
                    //);
                    //totalGrossSales = salesLines.Sum(d => d.MstTax.Code == "EXEMPTVAT" ?
                    //                     (d.Price * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100))
                    //                 : d.MstTax.Rate > 0 ?
                    //                    d.Price * d.Quantity : d.Price * d.Quantity);
                    totalGrossSales = salesLines.Sum(d => d.Price * d.Quantity);

                    totalRegularDiscount = salesLines.Sum(d =>
                        d.MstDiscount.Discount != "Senior Citizen Discount" && d.MstDiscount.Discount != "PWD" ? ((d.Price * d.Quantity) * (d.DiscountRate / 100)) : 0
                    );

                    totalSeniorCitizenDiscount = salesLines.Sum(d =>
                        d.MstDiscount.Discount == "Senior Citizen Discount" ? d.DiscountAmount * d.Quantity : 0
                    );

                    totalPWDDiscount = salesLines.Sum(d =>
                        d.MstDiscount.Discount == "PWD" ? d.DiscountAmount * d.Quantity : 0
                    );

                    totalVATSales = salesLines.Sum(d =>
                       d.MstTax.Code == "VAT" && (d.MstDiscount.Discount != "Senior Citizen Discount" || d.MstDiscount.Discount != "PWD") ? ((d.Price * d.Quantity) - d.TaxAmount) : 0
                    );

                    totalVATAmount = salesLines.Sum(d =>
                        d.MstTax.Code == "VAT" ? ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : 0
                    );

                    totalNonVATSales = salesLines.Sum(d =>
                        d.MstTax.Code == "NONVAT" ? d.Price * d.Quantity : 0
                    );

                    totalVATExemptSales = salesLines.Sum(d =>
                        d.MstTax.Code == "EXEMPTVAT" && (d.MstDiscount.Discount == "Senior Citizen Discount" || d.MstDiscount.Discount == "PWD") ? ((d.Price * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100))) - d.DiscountAmount : 0
                    );
                    //Decimal _taxRate = 0;
                    //Decimal _price = 0;
                    //Decimal _quantity = 0;
                    //String _taxCode = "EXEMPTVAT";
                    //Decimal vatExempt = 0;

                    //foreach(var sales in salesLines)
                    //{
                    //    if(sales.MstTax.Code == _taxCode)
                    //    {
                    //        vatExempt = ((sales.Price * sales.Quantity) - ((sales.Price * sales.Quantity) / (1 + (sales.MstItem.MstTax1.Rate / 100)) * (sales.MstItem.MstTax1.Rate / 100)));
                    //    }
                    //}

                    totalVATZeroRatedSales = salesLines.Sum(d =>
                        d.MstTax.Code == "ZEROVAT" ? d.Price * d.Quantity : 0
                    );
                }

                Decimal VATSalesReturn = 0;
                Decimal VATAmountSalesReturn = 0;
                Decimal VATExemptSalesReturn = 0;
                Decimal VATAmountExemptSalesReturn = 0;

                //&& d.TrnSale.IsReturned == true
                var salesReturnLinesQuery = from d in db.TrnSalesLines
                                            where d.Quantity < 0
                                            && d.TrnSale.SalesDate == filterDate
                                            && d.TrnSale.IsLocked == true
                                            && d.TrnSale.IsCancelled == false
                                            && d.TrnSale.IsReturned == true
                                            select d;

                if (salesReturnLinesQuery.Any())
                {
                    var salesReturnLines = salesReturnLinesQuery.ToArray();

                    VATSalesReturn = salesReturnLines.Sum(d =>
                        d.MstTax.Code == "VAT" ? d.Price * d.Quantity : 0
                    );

                    VATAmountSalesReturn = salesReturnLines.Sum(d =>
                        d.MstTax.Code == "VAT" ? d.TaxAmount : 0
                    ) * -1;

                    VATExemptSalesReturn = salesReturnLines.Sum(d =>
                        d.MstTax.Code == "EXEMPTVAT" ? d.Price * d.Quantity : 0
                    );

                    VATAmountExemptSalesReturn = salesReturnLines.Sum(d =>
                        d.MstTax.Code == "EXEMPTVAT" ? ((d.Price * (d.Quantity * -1)) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : d.TaxAmount
                    ) * -1;

                    totalSalesReturn = (VATSalesReturn + VATExemptSalesReturn);
                }
                var disbursment = from d in db.TrnDisbursements
                                  where d.TerminalId == filterTerminalId
                                  && d.DisbursementDate == filterDate
                                  && d.IsLocked == true
                                  && d.IsRefund == true
                                  && d.RefundSalesId != null
                                  select d;
                Decimal refund = 0;
                if (disbursment.Any())
                {
                    refund = disbursment.Sum(d => d.Amount != null ? d.Amount : 0);
                }

                repZReadingReportEntity.TotalGrossSales = totalGrossSales - refund;
                repZReadingReportEntity.TotalRegularDiscount = totalRegularDiscount;
                repZReadingReportEntity.TotalSeniorDiscount = totalSeniorCitizenDiscount;
                repZReadingReportEntity.TotalPWDDiscount = totalPWDDiscount;
                repZReadingReportEntity.TotalSalesReturn = totalSalesReturn;
                repZReadingReportEntity.TotalServiceCharge = totalServiceCharge;

                String _totalGrossSales = ((totalGrossSales - refund) * currentDeclareRate).ToString("#,##0.00");
                String _totalRegularDiscount = (totalRegularDiscount * currentDeclareRate).ToString("#,##0.00");
                String _totalSeniorCitizenDiscount = (totalSeniorCitizenDiscount * currentDeclareRate).ToString("#,##0.00");
                String _totalPWDDiscount = (totalPWDDiscount * currentDeclareRate).ToString("#,##0.00");
                String _totalSalesReturn = (totalSalesReturn * currentDeclareRate).ToString("#,##0.00");

                repZReadingReportEntity.TotalNetSales = Convert.ToDecimal(_totalGrossSales) -
                                                        Convert.ToDecimal(_totalRegularDiscount) -
                                                        Convert.ToDecimal(_totalSeniorCitizenDiscount) -
                                                        Convert.ToDecimal(_totalPWDDiscount)
                                                       /*- (Convert.ToDecimal(_totalSalesReturn) * -1)*/;

                String _totalNonTaxableSales = (totalNonTaxableSales * currentDeclareRate).ToString("#,##0.00");
                repZReadingReportEntity.TotalNonTaxableSalesAmount = Convert.ToDecimal(_totalNonTaxableSales);
                repZReadingReportEntity.TotalVATSales = totalVATSales - (VATSalesReturn * -1);
                //repZReadingReportEntity.TotalVATAmount = totalVATAmount - VATAmountSalesReturn - VATAmountExemptSalesReturn;
                repZReadingReportEntity.TotalNonVAT = totalNonVATSales;
                repZReadingReportEntity.TotalVATExempt = totalVATExemptSales - (VATExemptSalesReturn * -1);
                repZReadingReportEntity.TotalVATZeroRated = totalVATZeroRatedSales;
                repZReadingReportEntity.TotalNumberOfSKU = totalNoOfSKUs;
                repZReadingReportEntity.TotalQuantity = totalQUantity;
            }

            var disbursmenet = from d in db.TrnDisbursements
                               where d.TerminalId == filterTerminalId
                               && d.DisbursementDate == filterDate
                               && d.IsLocked == true
                               && d.IsRefund == true
                               && d.RefundSalesId != null
                               select d;

            if (disbursmenet.Any())
            {
                repZReadingReportEntity.TotalRefund = disbursmenet.Sum(d => d.Amount);
            }

            var currentCollectionLinesQuery = from d in db.TrnCollectionLines
                                              where d.TrnCollection.TerminalId == filterTerminalId
                                              && d.TrnCollection.CollectionDate == filterDate
                                              && d.TrnCollection.IsLocked == true
                                              group d by new
                                              {
                                                  d.MstPayType.PayTypeCode,
                                                  d.MstPayType.PayType,
                                              } into g
                                              select new
                                              {
                                                  g.Key.PayTypeCode,
                                                  g.Key.PayType,
                                                  Amount = g.Sum(s => s.TrnCollection.IsCancelled == false ?
                                                  //s.MstPayType.PayTypeCode == "GIFTCERTIFICATE"? (s.Amount + s.TrnSale.TrnSalesLines.Where(x => x.MstItem.Category =="GC").FirstOrDefault().TrnSale.TrnCollections.FirstOrDefault().Amount !=null ?
                                                  //s.TrnSale.TrnSalesLines.Where(x => x.MstItem.Category == "GC").FirstOrDefault().TrnSale.TrnCollections.FirstOrDefault().Amount : 0) - s.TrnCollection.ChangeAmount
                                                  s.MstPayType.PayTypeCode == "CASH" ? s.Amount - s.TrnCollection.ChangeAmount : s.Amount : 0)
                                              };

            Decimal totalCollectionAmount = 0;

            //var currentCollectionItemGC = from d in db.TrnCollectionLines
            //                              where d.TrnCollection.TerminalId == filterTerminalId
            //                                 && d.TrnCollection.CollectionDate == filterDate
            //                                 && d.TrnCollection.IsLocked == true
            //                                 && d.MstPayType.PayTypeCode == "CASH"
            //                                 && d.TrnCollection.TrnSale.TrnSalesLines.FirstOrDefault().MstItem.Category == "GC"
            //                              select d;

            if (currentCollectionLinesQuery.ToList().Any())
            {
                var currentCollectionLines = currentCollectionLinesQuery.ToArray();
                //var collectedItemGC = currentCollectionItemGC.ToArray();
                for (Int32 i = 0; i < currentCollectionLines.Count(); i++)
                {
                    var collectionLine = currentCollectionLines[i];
                    repZReadingReportEntity.CollectionLines.Add(new Entities.TrnCollectionLineEntity()
                    {
                        PayType = collectionLine.PayType,
                        //Amount = collectionLine.PayTypeCode == "GIFTCERTIFICATE"? currentCollectionLines.Where(s => s.PayTypeCode == "GIFTCERTIFICATE").Sum(s => s.Amount) + collectedItemGC.Sum(x => x.Amount != null? x.Amount :0) : collectionLine.Amount
                        Amount = collectionLine.Amount
                    });

                    totalCollectionAmount += collectionLine.Amount;
                }
            }

            repZReadingReportEntity.TotalCollection = totalCollectionAmount - repZReadingReportEntity.TotalRefund;

            var currentCollectionLinesQueryGC = from d in db.TrnCollectionLines
                                                where d.TrnCollection.TerminalId == filterTerminalId
                                                && d.TrnCollection.CollectionDate == filterDate
                                                && d.TrnCollection.IsLocked == true
                                                && d.TrnCollection.IsCancelled == false
                                                && d.MstPayType.PayTypeCode == "CASH" && d.TrnCollection.TrnSale.TrnSalesLines.FirstOrDefault().MstItem.Category == "GC"
                                                //&& (d.MstPayType.PayTypeCode == "GIFTCERTIFICATE"
                                                //|| d.MstPayType.PayTypeCode == "CASH" && d.TrnCollection.TrnSale.TrnSalesLines.FirstOrDefault().MstItem.Category == "GC")
                                                group d by new
                                                {
                                                    d.MstPayType.PayTypeCode,
                                                    d.MstPayType.PayType,
                                                } into g
                                                select new
                                                {
                                                    g.Key.PayTypeCode,
                                                    g.Key.PayType,
                                                    Amount = g.Sum(s => s.Amount)
                                                };


            Decimal totalCollectionGCAmount = 0;

            if (currentCollectionLinesQueryGC.ToList().Any())
            {
                var currentCollectionLines = currentCollectionLinesQueryGC.ToArray();

                for (Int32 i = 0; i < currentCollectionLines.Count(); i++)
                {
                    var collectionLine = currentCollectionLines[i];

                    repZReadingReportEntity.CollectionLines.Add(new Entities.TrnCollectionLineEntity()
                    {
                        PayType = collectionLine.PayType,
                        Amount = collectionLine.Amount
                    });

                    totalCollectionGCAmount += collectionLine.Amount;
                }
            }
            Decimal RefundGC = 0;
            var disbursmentGC = from d in db.TrnDisbursements
                                where d.TerminalId == filterTerminalId
                                && d.DisbursementDate == filterDate
                                && d.IsLocked == true
                                && d.IsRefund == true
                                && d.RefundSalesId != null
                               && d.MstPayType.PayTypeCode == "CASH" && d.TrnSale.TrnSalesLines.FirstOrDefault().MstItem.Category == "GC"
                                select d;

            if (disbursmentGC.Any())
            {
                RefundGC = disbursmentGC.Sum(x => x.Amount);
            }


            repZReadingReportEntity.TotalGCCash = totalCollectionGCAmount - RefundGC;


            var counterCollections = from d in db.TrnCollections
                                     where d.TerminalId == filterTerminalId
                                     && d.CollectionDate == filterDate
                                     && d.IsLocked == true
                                     select d;

            if (counterCollections.Any())
            {
                repZReadingReportEntity.CounterIdStart = counterCollections.OrderBy(d => d.Id).FirstOrDefault().CollectionNumber;
                repZReadingReportEntity.CounterIdEnd = counterCollections.OrderByDescending(d => d.Id).FirstOrDefault().CollectionNumber;
                repZReadingReportEntity.TotalNumberOfTransactions = counterCollections.Count();
            }

            var currentCancelledCollections = from d in db.TrnCollections
                                              where d.TerminalId == filterTerminalId
                                              && d.CollectionDate == filterDate
                                              && d.IsLocked == true
                                              && d.IsCancelled == true
                                              select d;

            if (currentCancelledCollections.Any())
            {
                repZReadingReportEntity.TotalCancelledTrnsactionCount = currentCancelledCollections.Count();
                repZReadingReportEntity.TotalCancelledAmount = currentCancelledCollections.Sum(d => d.Amount);
            }

            var previousDeclareRates = from d in db.SysDeclareRates
                                       where d.Date < filterDate
                                       select d;
            Decimal prevDeclareRate = 0;

            if (previousDeclareRates.Any())
            {
                if (previousDeclareRates.FirstOrDefault().DeclareRate != null)
                {
                    prevDeclareRate = Convert.ToDecimal(previousDeclareRates.FirstOrDefault().DeclareRate);
                }
            }
            else
            {
                prevDeclareRate = Modules.SysCurrentModule.GetCurrentSettings().DeclareRate;
            }

            Decimal totalAccumulatedGrossSales = 0;
            Decimal totalAccumulatedRegularDiscount = 0;
            Decimal totalAccumulatedSeniorCitizenDiscount = 0;
            Decimal totalAccumulatedPWDDiscount = 0;
            Decimal totalAccumulatedSalesReturn = 0;
            Decimal totalAccumulatedServiceCharge = 0;

            //&& d.TrnSale.IsReturned == false

            var previousCollectionSalesLineQuery = from d in db.TrnSalesLines
                                                   where d.TrnSale.TrnCollections.Any() == true
                                                   && d.TrnSale.TrnCollections.Where(
                                                       c => c.TerminalId == filterTerminalId &&
                                                            c.CollectionDate < filterDate &&
                                                            c.IsLocked == true &&
                                                            c.IsCancelled == false &&
                                                            c.SalesId != null).Any() == true
                                                   && d.TrnSale.IsLocked == true
                                                   && d.TrnSale.IsCancelled == false
                                                   && d.TrnSale.IsReturned == false
                                                   select d;

            if (previousCollectionSalesLineQuery.Any())
            {
                var salesLinesQuery = from d in previousCollectionSalesLineQuery
                                      where d.Quantity > 0
                                      select d;

                if (salesLinesQuery.Any())
                {
                    var salesLines = salesLinesQuery.ToArray();
                    var previousDeclareRatesValues = previousDeclareRates.ToArray();

                    //totalAccumulatedGrossSales = salesLines.Sum(d =>
                    //    previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                    //        (
                    //            d.MstTax.Code == "EXEMPTVAT" ?
                    //                d.MstItem.MstTax1.Rate > 0 ?
                    //                    (d.Price * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : d.Price * d.Quantity
                    //            : d.MstTax.Rate > 0 ?
                    //                    (d.Price * d.Quantity) - d.TaxAmount : d.Price * d.Quantity
                    //        ) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)
                    //    :
                    //        (
                    //            d.MstTax.Code == "EXEMPTVAT" ?
                    //                d.MstItem.MstTax1.Rate > 0 ?
                    //                    (d.Price * d.Quantity) - ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : d.Price * d.Quantity
                    //            : d.MstTax.Rate > 0 ?
                    //                    (d.Price * d.Quantity) - d.TaxAmount : d.Price * d.Quantity
                    //        ) * currentDeclareRate
                    //);

                    totalAccumulatedGrossSales = salesLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            (d.Price * d.Quantity) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)
                        :
                           (d.Price * d.Quantity) * currentDeclareRate
                    );

                    totalAccumulatedRegularDiscount = salesLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            (d.MstDiscount.Discount != "Senior Citizen Discount" && d.MstDiscount.Discount != "PWD" ? d.DiscountAmount * d.Quantity : 0) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)
                        :
                            (d.MstDiscount.Discount != "Senior Citizen Discount" && d.MstDiscount.Discount != "PWD" ? d.DiscountAmount * d.Quantity : 0) * currentDeclareRate
                    );

                    totalAccumulatedSeniorCitizenDiscount = salesLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            (d.MstDiscount.Discount == "Senior Citizen Discount" ? d.DiscountAmount * d.Quantity : 0) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)
                        :
                            (d.MstDiscount.Discount == "Senior Citizen Discount" ? d.DiscountAmount * d.Quantity : 0) * currentDeclareRate
                    );

                    totalAccumulatedPWDDiscount = salesLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            (d.MstDiscount.Discount == "PWD" ? d.DiscountAmount * d.Quantity : 0) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)
                        :
                            (d.MstDiscount.Discount == "PWD" ? d.DiscountAmount * d.Quantity : 0) * currentDeclareRate
                    );

                    //totalAccumulatedServiceCharge = salesLinesQuery.GroupBy(x => x.TrnSale).Sum(d =>
                    //    previousDeclareRatesValues.Where(p => p.Date == d.Key.SalesDate).Any() == true ?
                    //    (d.Key.ServiceChargeAmount * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.Key.SalesDate).FirstOrDefault().DeclareRate))
                    //    :
                    //    (d.Key.ServiceChargeAmount * currentDeclareRate));
                }

                Decimal VATSalesReturn = 0;
                Decimal VATAmountSalesReturn = 0;
                Decimal VATExemptSalesReturn = 0;
                Decimal VATAmountExemptSalesReturn = 0;

                var previousSalesReturnLinesQuery = from d in db.TrnSalesLines
                                                    where d.Quantity < 0
                                                    && d.TrnSale.SalesDate < filterDate
                                                    && d.TrnSale.IsLocked == true
                                                    && d.TrnSale.IsCancelled == false
                                                    && d.TrnSale.IsReturned == true
                                                    select d;

                if (previousSalesReturnLinesQuery.Any())
                {
                    var salesReturnLines = previousSalesReturnLinesQuery.ToArray();
                    var previousDeclareRatesValues = previousDeclareRates.ToArray();

                    VATSalesReturn = salesReturnLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            Convert.ToDecimal(((d.MstTax.Code == "VAT" ? d.Price * d.Quantity : 0) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)).ToString("#,##0.00"))
                        :
                            Convert.ToDecimal(((d.MstTax.Code == "VAT" ? d.Price * d.Quantity : 0) * currentDeclareRate).ToString("#,##0.00"))
                    );

                    VATAmountSalesReturn = salesReturnLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            Convert.ToDecimal(((d.MstTax.Code == "VAT" ? ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : 0) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)).ToString("#,##0.00"))
                        :
                            Convert.ToDecimal(((d.MstTax.Code == "VAT" ? ((d.Price * d.Quantity) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : 0) * currentDeclareRate).ToString("#,##0.00"))
                    ) * -1;

                    VATExemptSalesReturn = salesReturnLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            Convert.ToDecimal(((d.MstTax.Code == "EXEMPTVAT" ? d.Price * d.Quantity : 0) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)).ToString("#,##0.00"))
                        :
                            Convert.ToDecimal(((d.MstTax.Code == "EXEMPTVAT" ? d.Price * d.Quantity : 0) * currentDeclareRate).ToString("#,##0.00"))
                    );

                    VATAmountExemptSalesReturn = salesReturnLines.Sum(d =>
                        previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).Any() == true ?
                            Convert.ToDecimal(((d.MstTax.Code == "EXEMPTVAT" ? ((d.Price * (d.Quantity * -1)) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : d.TaxAmount) * Convert.ToDecimal(previousDeclareRatesValues.Where(p => p.Date == d.TrnSale.SalesDate).FirstOrDefault().DeclareRate)).ToString("#,##0.00"))
                        :
                            Convert.ToDecimal(((d.MstTax.Code == "EXEMPTVAT" ? ((d.Price * (d.Quantity * -1)) / (1 + (d.MstItem.MstTax1.Rate / 100)) * (d.MstItem.MstTax1.Rate / 100)) : d.TaxAmount) * currentDeclareRate).ToString("#,##0.00"))
                    ) * -1;

                    totalAccumulatedSalesReturn = (VATSalesReturn + VATExemptSalesReturn);
                }


            }

            var prevDisbursment = from d in db.TrnDisbursements
                                  where d.TerminalId == filterTerminalId
                                  && d.DisbursementDate < filterDate
                                  && d.IsLocked == true
                                  && d.IsRefund == true
                                  && d.RefundSalesId != null
                                  select d;

            Decimal prevRefund = 0;
            if (prevDisbursment.Any())
            {
                prevRefund = prevDisbursment.Sum(d => d.Amount != null ? d.Amount : 0);
            }

            repZReadingReportEntity.GrossSalesTotalPreviousReading = totalAccumulatedGrossSales - prevRefund;
            repZReadingReportEntity.GrossSalesRunningTotal = (repZReadingReportEntity.TotalGrossSales * currentDeclareRate) + repZReadingReportEntity.GrossSalesTotalPreviousReading;

            Decimal _totalAccumulatedGrossSales = repZReadingReportEntity.GrossSalesTotalPreviousReading;
            String _totalAccumulatedRegularDiscount = totalAccumulatedRegularDiscount.ToString("#,##0.00");
            String _totalAccumulatedSeniorCitizenDiscount = totalAccumulatedSeniorCitizenDiscount.ToString("#,##0.00");
            String _totalAccumulatedPWDDiscount = totalAccumulatedPWDDiscount.ToString("#,##0.00");
            String _totalAccumulatedSalesReturn = totalAccumulatedSalesReturn.ToString("#,##0.00");

            Decimal _totalAccumulatedPreviousNetSales = Convert.ToDecimal(_totalAccumulatedGrossSales) -
                                                    Convert.ToDecimal(_totalAccumulatedRegularDiscount) -
                                                    Convert.ToDecimal(_totalAccumulatedSeniorCitizenDiscount) -
                                                    Convert.ToDecimal(_totalAccumulatedPWDDiscount)
                                                  /* - (Convert.ToDecimal(_totalAccumulatedSalesReturn) * -1)*/;

            repZReadingReportEntity.NetSalesTotalPreviousReading = _totalAccumulatedPreviousNetSales;
            repZReadingReportEntity.NetSalesRunningTotal = repZReadingReportEntity.TotalNetSales + repZReadingReportEntity.NetSalesTotalPreviousReading;

            var firstCollection = from d in db.TrnCollections
                                  where d.IsLocked == true
                                  select d;

            if (firstCollection.Any())
            {
                Double totalDays = (filterDate - firstCollection.FirstOrDefault().CollectionDate).TotalDays + 1;
                repZReadingReportEntity.ZReadingCounter = totalDays.ToString("#,##0");
            }

            Decimal tax = 1.12m;
            Decimal taxRate = .12m;
            repZReadingReportEntity.TotalVATAmount = ((repZReadingReportEntity.TotalGrossSales - (repZReadingReportEntity.TotalSeniorDiscount
                                                    + repZReadingReportEntity.TotalNonTaxableSalesAmount + repZReadingReportEntity.TotalPWDDiscount + repZReadingReportEntity.TotalGCCash))
                                                    / tax) * taxRate;

            zReadingReportEntity = repZReadingReportEntity;
        }

        private void printDocumentZReadingReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

            var dataSource = zReadingReportEntity;

            Decimal currentDeclareRate = 0;

            var currentSysDeclareRate = from d in db.SysDeclareRates
                                        where d.Date == filterDate
                                        select d;

            if (currentSysDeclareRate.Any())
            {
                if (currentSysDeclareRate.FirstOrDefault().DeclareRate != null)
                {
                    currentDeclareRate = Convert.ToDecimal(currentSysDeclareRate.FirstOrDefault().DeclareRate);
                }
            }
            else
            {
                currentDeclareRate = Modules.SysCurrentModule.GetCurrentSettings().DeclareRate;
            }

            // =============
            // Font Settings
            // =============
            Font fontArial12Bold = new Font("Arial", 12, FontStyle.Bold);
            Font fontArial12Regular = new Font("Arial", 12, FontStyle.Regular);
            Font fontArial11Bold = new Font("Arial", 11, FontStyle.Bold);
            Font fontArial11Regular = new Font("Arial", 11, FontStyle.Regular);
            Font fontArial8Bold = new Font("Arial", 8, FontStyle.Bold);
            Font fontArial8Regular = new Font("Arial", 8, FontStyle.Regular);

            // ==================
            // Alignment Settings
            // ==================
            StringFormat drawFormatCenter = new StringFormat { Alignment = StringAlignment.Center };
            StringFormat drawFormatLeft = new StringFormat { Alignment = StringAlignment.Near };
            StringFormat drawFormatRight = new StringFormat { Alignment = StringAlignment.Far };

            float x, y;
            float width, height;
            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
            {
                x = 5; y = 5;
                width = 245.0F; height = 0F;
            }
            else
            {
                x = 5; y = 5;
                width = 260.0F; height = 0F;
            }
            // ==============
            // Tools Settings
            // ==============
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Color.Black, 1);
            Pen whitePen = new Pen(Color.White, 1);

            // ========
            // Graphics
            // ========
            Graphics graphics = e.Graphics;

            // ==============
            // System Current
            // ==============
            var systemCurrent = Modules.SysCurrentModule.GetCurrentSettings();

            // ============
            // Company Name
            // ============
            String companyName = systemCurrent.CompanyName;
            float adjustStringName = 1;
            if (companyName.Length > 43)
            {
                adjustStringName = 3;
            }
            graphics.DrawString(companyName, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(companyName, fontArial8Regular).Height * adjustStringName;

            // ===============
            // Company Address
            // ===============
            String companyAddress = systemCurrent.Address;

            float adjuctHeight = 1;
            if (companyAddress.Length > 25)
            {
                adjuctHeight = 2;
            }
            

            graphics.DrawString(companyAddress, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += (graphics.MeasureString(companyAddress, fontArial8Regular).Height * adjuctHeight);

            // ==========
            // TIN Number
            // ==========
            String TINNumber = systemCurrent.TIN;
            graphics.DrawString("TIN: " + TINNumber, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(companyAddress, fontArial8Regular).Height;

            // =============
            // Serial Number
            // =============
            String serialNo = systemCurrent.SerialNo;
            graphics.DrawString("SN: " + serialNo, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(companyAddress, fontArial8Regular).Height;

            // ==============
            // Machine Number
            // ==============
            String machineNo = systemCurrent.MachineNo;
            graphics.DrawString("MIN: " + machineNo, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(companyAddress, fontArial8Regular).Height;

            // ===============
            // Terminal Number
            // ===============
            String terminal = filterTerminal;
            graphics.DrawString("Terminal: " + terminal, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(companyAddress, fontArial8Regular).Height;

            // ======================
            // Z Reading Report Title
            // ======================
            String zReadingReportTitle = "Z Reading Report";
            graphics.DrawString(zReadingReportTitle, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(zReadingReportTitle, fontArial8Regular).Height;

            // ====
            // Date 
            // ====
            String collectionDateText = filterDate.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
            graphics.DrawString(collectionDateText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(collectionDateText, fontArial8Regular).Height;

            // ========
            // 1st Line
            // ========
            Point firstLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
            Point firstLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
            graphics.DrawLine(blackPen, firstLineFirstPoint, firstLineSecondPoint);

            Decimal totalGrossSales = dataSource.TotalGrossSales * currentDeclareRate;
            Decimal totalRegularDiscount = dataSource.TotalRegularDiscount * currentDeclareRate;
            Decimal totalSeniorDiscount = dataSource.TotalSeniorDiscount * currentDeclareRate;
            Decimal totalPWDDiscount = dataSource.TotalPWDDiscount * currentDeclareRate;
            Decimal totalSalesReturn = dataSource.TotalSalesReturn * currentDeclareRate;
            Decimal totalNetSales = dataSource.TotalNetSales * currentDeclareRate;
            Decimal totalService = dataSource.TotalServiceCharge * currentDeclareRate;

            // ===========
            // Gross Sales
            // ===========
            String totalGrossSalesLabel = "\nGross Sales";
            String totalGrossSalesData = "\n" + totalGrossSales.ToString("#,##0.00");
            graphics.DrawString(totalGrossSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalGrossSalesData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalGrossSalesData, fontArial8Regular).Height;

            //==============
            //Service Charge
            //==============
            String totalServiceChargeLabel = "Service Charge";
            String totalServiceChargeData = totalService.ToString("#,##0.00");
            graphics.DrawString(totalServiceChargeLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalServiceChargeData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalServiceChargeData, fontArial8Regular).Height;

            // ================
            // Regular Discount
            // ================
            String totalRegularDiscountLabel = "Regular Discount";
            String totalRegularDiscountData = totalRegularDiscount.ToString("#,##0.00");
            graphics.DrawString(totalRegularDiscountLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalRegularDiscountData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalRegularDiscountData, fontArial8Regular).Height;

            // ===============
            // Senior Discount
            // ===============
            String totalSeniorDiscountLabel = "Senior Discount";
            String totalSeniorDiscountData = totalSeniorDiscount.ToString("#,##0.00");
            graphics.DrawString(totalSeniorDiscountLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalSeniorDiscountData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalSeniorDiscountData, fontArial8Regular).Height;

            // ============
            // PWD Discount
            // ============
            String totalPWDDiscountLabel = "PWD Discount";
            String totalPWDDiscountData = totalPWDDiscount.ToString("#,##0.00");
            graphics.DrawString(totalPWDDiscountLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalPWDDiscountData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalPWDDiscountData, fontArial8Regular).Height;

            // ============
            // Sales Return
            // ============
            String totalSalesReturnLabel = "Sales Return";
            String totalSalesReturnData = "(" + totalSalesReturn.ToString("#,##0.00") + ")";
            graphics.DrawString(totalSalesReturnLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalSalesReturnData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalSalesReturnData, fontArial8Regular).Height;

            // =========
            // Net Sales
            // =========
            String totalNetSalesLabel = "Net Sales \n\n";
            String totalNetSalesData = totalNetSales.ToString("#,##0.00") + "\n\n";
            graphics.DrawString(totalNetSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalNetSalesData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalNetSalesData, fontArial8Regular).Height;

            // ========
            // 2nd Line
            // ========
            Point secondLineFirstPoint = new Point(0, Convert.ToInt32(y) - 7);
            Point secondLineSecondPoint = new Point(500, Convert.ToInt32(y) - 7);
            graphics.DrawLine(blackPen, secondLineFirstPoint, secondLineSecondPoint);

            if (dataSource.CollectionLines.Any())
            {
                var previousSalesReturnLines = dataSource.CollectionLines.ToArray();

                for (Int32 i = 0; i < previousSalesReturnLines.Count(); i++)
                {
                    var collectionLine = previousSalesReturnLines[i];

                    // ================
                    // Collection Lines
                    // ================
                    String collectionLineLabel = collectionLine.PayType;
                    String collectionLineData = (collectionLine.Amount * currentDeclareRate).ToString("#,##0.00");
                    graphics.DrawString(collectionLineLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(collectionLineData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(collectionLineData, fontArial8Regular).Height;
                }

                Decimal totalRefund = dataSource.TotalRefund * currentDeclareRate;

                String totalRefundLabel = "Refund";
                String totalRefundData = "(" + totalRefund.ToString("#,##0.00") + ")";
                graphics.DrawString(totalRefundLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalRefundData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalRefundData, fontArial8Regular).Height;

                // ========
                // 3rd Line
                // ========
                Point thirdLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point thirdLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, thirdLineFirstPoint, thirdLineSecondPoint);
            }

            // ========
            // 3rd Line
            // ========
            Point thirdLineFirstPoint2 = new Point(0, Convert.ToInt32(y) + 5);
            Point thirdLineSecondPoint2 = new Point(500, Convert.ToInt32(y) + 5);
            graphics.DrawLine(blackPen, thirdLineFirstPoint2, thirdLineSecondPoint2);

            Decimal totalCollection = dataSource.TotalCollection * currentDeclareRate;

            String totalCollectionLabel = "\nTotal Collection";
            String totalCollectionData = "\n" + totalCollection.ToString("#,##0.00");
            graphics.DrawString(totalCollectionLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalCollectionData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalCollectionData, fontArial8Regular).Height;

            // ========
            // 4th Line
            // ========
            Point forthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
            Point forthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
            graphics.DrawLine(blackPen, forthLineFirstPoint, forthLineSecondPoint);

            Decimal totalVATSales = dataSource.TotalVATSales * currentDeclareRate;
            Decimal totalVATAmount = dataSource.TotalVATAmount * currentDeclareRate;
            Decimal totalNonVAT = dataSource.TotalNonVAT * currentDeclareRate;
            Decimal totalVATExclusive = dataSource.TotalVATExclusive * currentDeclareRate;
            Decimal totalVATExempt = dataSource.TotalVATExempt * currentDeclareRate;
            Decimal totalVATZeroRated = dataSource.TotalVATZeroRated * currentDeclareRate;

            String vatSalesLabel = "\nVAT Sales";
            String totalVatSalesData = "\n" + totalVATSales.ToString("#,##0.00");
            graphics.DrawString(vatSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalVatSalesData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalVatSalesData, fontArial8Regular).Height;

            String totalVATAmountLabel = "VAT Amount";
            String totalVATAmountData = totalVATAmount.ToString("#,##0.00");
            graphics.DrawString(totalVATAmountLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalVATAmountData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalVATAmountData, fontArial8Regular).Height;

            String totalNonVATLabel = "Non-VAT";
            String totalNonVATAmount = totalNonVAT.ToString("#,##0.00");
            graphics.DrawString(totalNonVATLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalNonVATAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalNonVATAmount, fontArial8Regular).Height;

            String totalVATExemptLabel = "VAT Exempt";
            String totalVATExemptData = totalVATExempt.ToString("#,##0.00");
            graphics.DrawString(totalVATExemptLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalVATExemptData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalVATExemptData, fontArial8Regular).Height;

            String totalVATZeroRatedLabel = "VAT Zero Rated";
            String totalVatZeroRatedData = totalVATZeroRated.ToString("#,##0.00");
            graphics.DrawString(totalVATZeroRatedLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalVatZeroRatedData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalVatZeroRatedData, fontArial8Regular).Height;

            // ========
            // 5th Line
            // ========
            Point fifthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
            Point fifthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
            graphics.DrawLine(blackPen, fifthLineFirstPoint, fifthLineSecondPoint);

            String counterIdStart = dataSource.CounterIdStart;
            String counterIdEnd = dataSource.CounterIdEnd;

            String startCounterIdLabel = "\nCounter ID Start";
            String startCounterIdData = "\n" + counterIdStart;
            graphics.DrawString(startCounterIdLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(startCounterIdData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(startCounterIdData, fontArial8Regular).Height;

            String endCounterIdLabel = "Counter ID End";
            String endCounterIdData = counterIdEnd;
            graphics.DrawString(endCounterIdLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(endCounterIdData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(endCounterIdData, fontArial8Regular).Height;

            // ========
            // 6th Line
            // ========
            Point sixthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
            Point sixthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
            graphics.DrawLine(blackPen, sixthLineFirstPoint, sixthLineSecondPoint);

            Decimal totalCancelledTrnsactionCount = dataSource.TotalCancelledTrnsactionCount;
            Decimal totalCancelledAmount = dataSource.TotalCancelledAmount * currentDeclareRate;

            String totalCancelledTrnsactionCountLabel = "\nCancelled Tx.";
            String totalCancelledTrnsactionCountData = "\n" + totalCancelledTrnsactionCount.ToString("#,##0");
            graphics.DrawString(totalCancelledTrnsactionCountLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalCancelledTrnsactionCountData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalCancelledTrnsactionCountData, fontArial8Regular).Height;

            String totalCancelledAmountLabel = "Cancelled Amount";
            String totalCancelledAmountData = totalCancelledAmount.ToString("#,##0.00");
            graphics.DrawString(totalCancelledAmountLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalCancelledAmountData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalCancelledAmountData, fontArial8Regular).Height;

            // ========
            // 7th Line
            // ========
            Point seventhLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
            Point seventhLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
            graphics.DrawLine(blackPen, seventhLineFirstPoint, seventhLineSecondPoint);

            Decimal totalNumberOfTransactions = dataSource.TotalNumberOfTransactions;
            Decimal totalNumberOfSKU = dataSource.TotalNumberOfSKU;
            Decimal totalQuantity = dataSource.TotalQuantity;

            String totalNumberOfTransactionsLabel = "\nNo. of Transactions";
            String totalNumberOfTransactionsData = "\n" + totalNumberOfTransactions.ToString("#,##0");
            graphics.DrawString(totalNumberOfTransactionsLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalNumberOfTransactionsData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalNumberOfTransactionsData, fontArial8Regular).Height;

            String totalNumberOfSKULabel = "No. of SKU";
            String totalNumberOfSKUData = totalNumberOfSKU.ToString("#,##0");
            graphics.DrawString(totalNumberOfSKULabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalNumberOfSKUData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalNumberOfSKUData, fontArial8Regular).Height;

            String totalQuantityLabel = "Total Quantity";
            String totalQuantityData = totalQuantity.ToString("#,##0.00");
            graphics.DrawString(totalQuantityLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalQuantityData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalQuantityData, fontArial8Regular).Height;

            // ========
            // 8th Line
            // ========
            Point eightLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
            Point eightLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
            graphics.DrawLine(blackPen, eightLineFirstPoint, eightLineSecondPoint);

            graphics.DrawString("\nAccumulated Gross Sales", fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            y += graphics.MeasureString("\nAccumulated Gross Sales", fontArial8Regular).Height;

            Decimal grossSalesTotalPreviousReading = dataSource.GrossSalesTotalPreviousReading;
            Decimal grossSalesRunningTotal = dataSource.GrossSalesRunningTotal;

            String grossSalesTotalPreviousReadingLabel = "\nPrevious Reading";
            String grossSalesTotalPreviousReadingData = "\n" + grossSalesTotalPreviousReading.ToString("#,##0.00");
            graphics.DrawString(grossSalesTotalPreviousReadingLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(grossSalesTotalPreviousReadingData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(grossSalesTotalPreviousReadingData, fontArial8Regular).Height;

            graphics.DrawString("Gross Sales", fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalGrossSales.ToString("#,##0.00"), fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalGrossSales.ToString("#,##0.00"), fontArial8Regular).Height;

            String grossSalesRunningTotalLabel = "Accu. Gross Sales";
            String grossSalesRunningTotalData = grossSalesRunningTotal.ToString("#,##0.00");
            graphics.DrawString(grossSalesRunningTotalLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(grossSalesRunningTotalData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(grossSalesRunningTotalData, fontArial8Regular).Height;

            // ========
            // 9th Line
            // ========
            Point ninethLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
            Point ninethLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
            graphics.DrawLine(blackPen, ninethLineFirstPoint, ninethLineSecondPoint);

            graphics.DrawString("\nAccumulated Net Sales", fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            y += graphics.MeasureString("\nAccumulated Net Sales", fontArial8Regular).Height;

            Decimal netSalesTotalPreviousReading = dataSource.NetSalesTotalPreviousReading;
            Decimal netSalesRunningTotal = dataSource.NetSalesRunningTotal;

            String netSalesTotalPreviousReadingLabel = "\nPrevious Reading";
            String netSalesTotalPreviousReadingData = "\n" + netSalesTotalPreviousReading.ToString("#,##0.00");
            graphics.DrawString(netSalesTotalPreviousReadingLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(netSalesTotalPreviousReadingData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(netSalesTotalPreviousReadingData, fontArial8Regular).Height;

            graphics.DrawString("Net Sales", fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(totalNetSales.ToString("#,##0.00"), fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(totalNetSales.ToString("#,##0.00"), fontArial8Regular).Height;

            String netSalesRunningTotalLabel = "Accu. Net Sales";
            String netSalesRunningTotalData = netSalesRunningTotal.ToString("#,##0.00");
            graphics.DrawString(netSalesRunningTotalLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(netSalesRunningTotalData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(netSalesRunningTotalData, fontArial8Regular).Height;

            // =========
            // 10th Line
            // =========
            Point tenthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
            Point tenthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
            graphics.DrawLine(blackPen, tenthLineFirstPoint, tenthLineSecondPoint);

            String zReadingCounter = dataSource.ZReadingCounter;

            String zReadingCounterLabel = "\nZ-Reading Counter";
            String zReadingCounterData = "\n" + zReadingCounter;
            graphics.DrawString(zReadingCounterLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
            graphics.DrawString(zReadingCounterData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(zReadingCounterData, fontArial8Regular).Height;

            // =========
            // 11th Line
            // =========
            Point eleventhLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
            Point eleventhLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
            graphics.DrawLine(blackPen, eleventhLineFirstPoint, eleventhLineSecondPoint);

            String zReadingFooter = systemCurrent.ZReadingFooter;

            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
            {
                String zReadingEndLabel = "\n" + zReadingFooter + "\n \n\n\n\n\n\n\n.";
                graphics.DrawString(zReadingEndLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(zReadingEndLabel, fontArial8Regular).Height;
            }
            else
            {
                String zReadingEndLabel = "\n" + zReadingFooter + "\n \n\n\n.";
                graphics.DrawString(zReadingEndLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(zReadingEndLabel, fontArial8Regular).Height;
            }

         
        }
    }
}

