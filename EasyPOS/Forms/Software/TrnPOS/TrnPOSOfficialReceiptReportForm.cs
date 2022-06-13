using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.TrnPOS
{
    public partial class TrnPOSOfficialReceiptReportForm : Form
    {
        public Int32 trnSalesId = 0;
        public Int32 trnCollectionId = 0;
        public Boolean trnIsReprinted = false;

        public TrnPOSOfficialReceiptReportForm(Int32 salesId, Int32 collectionId, Boolean isReprinted, String printerName)
        {
            InitializeComponent();

            trnSalesId = salesId;
            trnCollectionId = collectionId;
            trnIsReprinted = isReprinted;

            if (trnIsReprinted == true)
            {
                printDocumentOfficialReceipt.PrinterSettings.PrinterName = printerName;
            }
            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
            {
                printDocumentOfficialReceipt.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 255, 38500);
                printDocumentOfficialReceipt.Print();

            }
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Thermal Printer")
            {
                printDocumentOfficialReceipt.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 270, 38500);
                printDocumentOfficialReceipt.Print();
            }
            else
            {
                printDocumentOfficialReceipt.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 175, 38500);
                printDocumentOfficialReceipt.Print();
            }
        }

        private void printDocumentOfficialReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // ============
            // Data Context
            // ============
            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

            // =============
            // Font Settings
            // =============
            Font fontArial12Bold = new Font("Arial", 12, FontStyle.Bold);
            Font fontArial12Regular = new Font("Arial", 12, FontStyle.Regular);
            Font fontArial11Bold = new Font("Arial", 11, FontStyle.Bold);
            Font fontArial11Regular = new Font("Arial", 11, FontStyle.Regular);
            Font fontArial8Bold = new Font("Arial", 8, FontStyle.Bold);
            Font fontArial8Regular = new Font("Arial", 8, FontStyle.Regular);
            Font fontArial7Bold = new Font("Arial", 7, FontStyle.Bold);
            Font fontArial7Regular = new Font("Arial", 7, FontStyle.Regular);


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
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Thermal Printer")
            {
                x = 5; y = 5;
                width = 260.0F; height = 0F;
            }
            else
            {
                x = 5; y = 5;
                width = 170.0F; height = 0F;
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
            y += (graphics.MeasureString(companyName, fontArial8Regular).Height * adjustStringName);

            // ===============
            // Company Address
            // ===============

            String companyAddress = systemCurrent.Address;

            float adjustStringAddress = 1;
            if (companyAddress.Length > 26)
            {
                adjustStringAddress = 2;
            }

            graphics.DrawString(companyAddress, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += (graphics.MeasureString(companyAddress, fontArial8Regular).Height * adjustStringAddress);

            // ==========
            // TIN Number
            // ==========
            String TINNumber = systemCurrent.TIN;
            graphics.DrawString("TIN: " + TINNumber, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(companyAddress, fontArial8Regular).Height;

            // =============
            // Serial Number
            // =============
            float adjustStringSerialNo = 1;
            if (companyAddress.Length > 43)
            {
                adjustStringSerialNo = 3;
            }
            String serialNo = systemCurrent.SerialNo;
            graphics.DrawString("SN: " + serialNo, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(companyAddress, fontArial8Regular).Height * adjustStringSerialNo;

            // ==============
            // Machine Number
            // ==============
            String machineNo = systemCurrent.MachineNo;
            graphics.DrawString("MIN: " + machineNo, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(companyAddress, fontArial8Regular).Height;

            // ======================
            // Official Receipt Title
            // ======================
            String officialReceiptTitle = systemCurrent.ORPrintTitle;
            graphics.DrawString(officialReceiptTitle, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(officialReceiptTitle, fontArial8Regular).Height;

            //var sales = from d in db.TrnSales where d.Id == trnSalesId select d;
            // ==============
            // Customer Name
            // ==============

            //String customerName = sales.Any() == true ? sales.FirstOrDefault().MstCustomer.Customer : "";
            //graphics.DrawString("MIN: " + machineNo, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            //y += graphics.MeasureString(companyAddress, fontArial8Regular).Height;

            // =================
            // Collection Header
            // =================
            var collections = from d in db.TrnCollections where d.Id == trnCollectionId select d;
            if (collections.Any())
            {
                String collectionNumberText = collections.FirstOrDefault().CollectionNumber;
                graphics.DrawString(collectionNumberText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(collectionNumberText, fontArial8Regular).Height;

                String collectionDateText = collections.FirstOrDefault().CollectionDate.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
                graphics.DrawString(collectionDateText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(collectionDateText, fontArial8Regular).Height;

                String collectionTimeText = collections.FirstOrDefault().UpdateDateTime.ToString("H:mm:ss", CultureInfo.InvariantCulture);
                graphics.DrawString(collectionTimeText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(collectionTimeText, fontArial8Regular).Height;

                if (trnIsReprinted)
                {
                    graphics.DrawString("REPRINTED", fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                    y += graphics.MeasureString("REPRINTED", fontArial8Regular).Height;
                }


                // ==========
                // Sales Line
                // ==========
                Decimal totalNetGrossSales = 0;
                Decimal totalSales = 0;
                Decimal totalDiscount = 0;
                Decimal change = 0;
                Decimal totalVATSales = 0;
                Decimal totalVATAmount = 0;
                Decimal totalNonVATSales = 0;
                //Decimal totalVATExclusive = 0;
                Decimal totalVATExempt = 0;
                Decimal totalVATZeroRated = 0;
                Decimal totalNumberOfItems = 0;
                String discountGiven = "";
                Decimal totalGrossSales = 0;
                Decimal lessVAT = 0;
                Decimal totalServiceCharge = 0;

                var sales = from d in db.TrnSales where d.Id == trnSalesId select d;

                String itemLabel = "\nITEM";
                String amountLabel = "\nAMOUNT";
                graphics.DrawString(itemLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(amountLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(itemLabel, fontArial8Regular).Height + 5.0F;

                var salesLines = from d in db.TrnSalesLines where d.SalesId == trnSalesId select d;
                if (salesLines.Any())
                {
                    var salesLineGroupbyItem = from s in salesLines
                                               group s by new
                                               {
                                                   s.ItemId,
                                                   s.MstItem,
                                                   s.UnitId,
                                                   s.MstUnit,
                                                   s.NetPrice,
                                                   s.Price,
                                                   s.TaxId,
                                                   s.MstTax,
                                                   s.MstDiscount,
                                                   s.DiscountId,
                                                   s.DiscountRate,
                                                   s.SalesAccountId,
                                                   s.AssetAccountId,
                                                   s.CostAccountId,
                                                   s.TaxAccountId,
                                                   s.UserId,
                                                   s.Preparation,
                                                   s.Price1,
                                                   s.Price2,
                                                   s.Price2LessTax,
                                                   s.PriceSplitPercentage,
                                                   s.TrnSale,
                                                   s.ServiceCharge
                                               } into g
                                               select new
                                               {
                                                   g.Key.ItemId,
                                                   g.Key.MstItem,
                                                   g.Key.MstItem.ItemDescription,
                                                   g.Key.MstUnit.Unit,
                                                   g.Key.Price,
                                                   g.Key.NetPrice,
                                                   g.Key.MstDiscount,
                                                   g.Key.DiscountId,
                                                   g.Key.DiscountRate,
                                                   g.Key.TaxId,
                                                   g.Key.MstTax,
                                                   g.Key.MstTax.Tax,
                                                   Amount = g.Sum(a => a.Amount),
                                                   Quantity = g.Sum(a => a.Quantity),
                                                   DiscountAmount = g.Sum(a => a.DiscountAmount * a.Quantity),
                                                   TaxAmount = g.Sum(a => a.TaxAmount),
                                                   g.Key.TrnSale.DiscountedPax,
                                                   g.Key.TrnSale.Pax,
                                                   ServiceCharge = g.Sum(a => a.ServiceCharge)
                                               };

                    if (salesLineGroupbyItem.Any())
                    {
                        foreach (var salesLine in salesLineGroupbyItem.ToList())
                        {
                            totalNumberOfItems += salesLine.Quantity;
                            totalNetGrossSales += salesLine.Price * salesLine.Quantity;
                            totalGrossSales += salesLine.Price * salesLine.Quantity;
                            totalSales += salesLine.NetPrice  * salesLine.Quantity;
                            totalDiscount += salesLine.DiscountAmount;
                            discountGiven = salesLine.MstDiscount.Discount;
                            totalServiceCharge += salesLine.ServiceCharge;
                            if (salesLine.MstTax.Code == "VAT")
                            {
                                totalVATSales += (salesLine.Price * salesLine.Quantity) - ((salesLine.Price * salesLine.Quantity) / (1 + (salesLine.MstItem.MstTax1.Rate / 100)) * (salesLine.MstItem.MstTax1.Rate / 100));
                                totalVATAmount += ((salesLine.Price * salesLine.Quantity) / (1 + (salesLine.MstItem.MstTax1.Rate / 100)) * (salesLine.MstItem.MstTax1.Rate / 100));
                            }
                            else if (salesLine.MstTax.Code == "NONVAT")
                            {
                                totalNonVATSales += salesLine.Price * salesLine.Quantity;
                            }
                            else if (salesLine.MstTax.Code == "EXEMPTVAT")
                            {
                                if (salesLine.MstItem.MstTax1.Rate > 0)
                                {
                                    totalVATSales += (((salesLine.Price * salesLine.Quantity) / salesLine.Pax.GetValueOrDefault()) * salesLine.DiscountedPax.GetValueOrDefault());
                                    totalVATAmount += ((((salesLine.Price * salesLine.Quantity) / salesLine.Pax.GetValueOrDefault()) * salesLine.DiscountedPax.GetValueOrDefault()) / (1 + (salesLine.MstItem.MstTax1.Rate / 100)) * (salesLine.MstItem.MstTax1.Rate / 100));
                                    totalVATExempt += ((((salesLine.Price * salesLine.Quantity)/ salesLine.Pax.GetValueOrDefault()) * salesLine.DiscountedPax.GetValueOrDefault()) / (1 + (salesLine.MstItem.MstTax1.Rate / 100)));
                                    lessVAT += ((((salesLine.Price * salesLine.Quantity) / salesLine.Pax.GetValueOrDefault()) * salesLine.DiscountedPax.GetValueOrDefault()) / (1 + (salesLine.MstItem.MstTax1.Rate / 100)) * (salesLine.MstItem.MstTax1.Rate / 100));

                                }
                                else
                                {
                                    totalVATExempt += salesLine.Price * salesLine.Quantity;
                                }
                            }
                            else if (salesLine.MstTax.Code == "ZEROVAT")
                            {
                                totalVATZeroRated += salesLine.Price * salesLine.Quantity;
                            }

                            String itemData = salesLine.ItemDescription + "\n" + salesLine.Quantity.ToString("#,##0.00") + " " + salesLine.Unit + " @ " + salesLine.Price.ToString("#,##0.00");
                            String itemAmountData = (salesLine.Price * salesLine.Quantity).ToString("#,##0.00");
                            RectangleF itemDataRectangle = new RectangleF
                            {
                                X = x,
                                Y = y,
                                Size = new Size(150, ((int)graphics.MeasureString(itemData, fontArial8Regular, 150, StringFormat.GenericDefault).Height))
                            };
                            graphics.DrawString(itemData, fontArial8Regular, Brushes.Black, itemDataRectangle, drawFormatLeft);
                            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
                            {
                                graphics.DrawString(itemAmountData, fontArial8Regular, drawBrush, new RectangleF(x, y, 245.0F, height), drawFormatRight);
                            }
                            else
                            {
                                graphics.DrawString(itemAmountData, fontArial8Regular, drawBrush, new RectangleF(x, y, 250.0F, height), drawFormatRight);
                            }
                            y += itemDataRectangle.Size.Height + 3.0F;
                        }
                    }
                }

                // ========
                // 2nd Line
                // ========
                Point secondLineFirstPoint = new Point(0, Convert.ToInt32(y) + 10);
                Point secondLineSecondPoint = new Point(500, Convert.ToInt32(y) + 10);
                graphics.DrawLine(blackPen, secondLineFirstPoint, secondLineSecondPoint);

                String totalNetSalesAmount = totalSales.ToString("#,##0.00");
                String totalSCAmount = totalServiceCharge.ToString("#,##0.00");

                Decimal totalAmountDue = Convert.ToDecimal(totalNetSalesAmount) + Convert.ToDecimal(totalSCAmount);

                // ==============================
                // Total Sales and Total Discount
                // ==============================
                //String totalNetSalesLabel = "\nTotal Net Sales";
                //String totalNetSalesAmount = "\n" + totalNetGrossSales.ToString("#,##0.00");
                //graphics.DrawString(totalNetSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                //graphics.DrawString(totalNetSalesAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                //y += graphics.MeasureString(totalNetSalesAmount, fontArial8Regular).Height;

                String totalSalesLabel = "\nSub-total Amount";
                String totalSalesAmount = "\n" + totalGrossSales.ToString("#,##0.00");
                graphics.DrawString(totalSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalSalesAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalSalesAmount, fontArial8Regular).Height;

                String serviceChargeLabel = "Service Charge";
                String totalServiceChargeAmount = totalServiceCharge.ToString("#,##0.00");
                graphics.DrawString(serviceChargeLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalServiceChargeAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalServiceChargeAmount, fontArial8Regular).Height;

                String lessVATLabel = "LESS: VAT";
                String totalLessVATAmount = lessVAT.ToString("#,##0.00");
                graphics.DrawString(lessVATLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalLessVATAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalLessVATAmount, fontArial8Regular).Height;

                //if (totalVATExempt > 0)
                //{
                //    String ExemptVATLabel = "\nVAT-Exempt Sales";
                //    String totalVATExemptAmount = "\n" + totalVATExempt.ToString("#,##0.00");
                //    graphics.DrawString(ExemptVATLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                //    graphics.DrawString(totalVATExemptAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                //    y += graphics.MeasureString(totalVATExemptAmount, fontArial8Regular).Height;
                //}
                if (discountGiven != "Zero Discount")
                {
                    String DiscountLabel = "Discount Given";
                    String Discount = discountGiven;
                    graphics.DrawString(DiscountLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    graphics.DrawString(Discount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += graphics.MeasureString(Discount, fontArial8Regular).Height;
                }
                String totalDiscountLabel = "LESS: Discount";
                String totalDiscountAmount = totalDiscount.ToString("#,##0.00");
                graphics.DrawString(totalDiscountLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalDiscountAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalDiscountAmount, fontArial8Regular).Height;

                String netSalesLabel = "Total Amount Due";
                String netSalesAmount = totalAmountDue.ToString("#,##0.00");
                graphics.DrawString(netSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(netSalesAmount, fontArial12Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(netSalesAmount, fontArial12Regular).Height;

                String totalNumberOfItemsLabel = "Total No. of Item(s)\n\n";
                String totalNumberOfItemsQuantity = totalNumberOfItems.ToString("#,##0.00") + "\n\n";
                graphics.DrawString(totalNumberOfItemsLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalNumberOfItemsQuantity, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalNumberOfItemsQuantity, fontArial8Regular).Height;

                // ========
                // 3rd Line
                // ========
                Point thirdLineFirstPoint = new Point(0, Convert.ToInt32(y) - 7);
                Point thirdLineSecondPoint = new Point(500, Convert.ToInt32(y) - 7);
                graphics.DrawLine(blackPen, thirdLineFirstPoint, thirdLineSecondPoint);

                // ================
                // Collection Lines
                // ================
                var collectionLines = from d in db.TrnCollectionLines where d.CollectionId == collections.FirstOrDefault().Id select d;
                if (collectionLines.Any())
                {
                    foreach (var collectionLine in collectionLines)
                    {
                        String collectionLineLabel = collectionLine.MstPayType.PayType;
                        String collectionLineAmount = collectionLine.Amount.ToString("#,##0.00");

                        graphics.DrawString(collectionLineLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                        graphics.DrawString(collectionLineAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                        y += graphics.MeasureString(collectionLineAmount, fontArial8Regular).Height;
                    }
                }

                // ======
                // Change
                // ======
                change = collections.FirstOrDefault().ChangeAmount;

                String changelabel = "Change";
                String changeAmount = change.ToString("#,##0.00");
                graphics.DrawString(changelabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(changeAmount, fontArial12Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(changeAmount, fontArial8Regular).Height;

                // ========
                // 4th Line
                // ========
                Point forthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point forthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, forthLineFirstPoint, forthLineSecondPoint);

                // ============
                // VAT Analysis
                // ============
                String vatAnalysisLabel = "\nVAT ANALYSIS";
                graphics.DrawString(vatAnalysisLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                y += graphics.MeasureString(vatAnalysisLabel, fontArial8Regular).Height + +5.0F;

                String vatSalesLabel = "VAT Sales";
                String totalVatSalesAmount = totalVATSales.ToString("#,##0.00");
                graphics.DrawString(vatSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalVatSalesAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalVatSalesAmount, fontArial8Regular).Height;

                String totalVATAmountLabel = "VAT Amount";
                String totalVatAmount = totalVATAmount.ToString("#,##0.00");
                graphics.DrawString(totalVATAmountLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalVatAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalVatAmount, fontArial8Regular).Height;

                String totalNonVATSalesLabel = "Non-VAT";
                String totalNonVatAmount = totalNonVATSales.ToString("#,##0.00");
                graphics.DrawString(totalNonVATSalesLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalNonVatAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalNonVatAmount, fontArial8Regular).Height;

                //String totalVATExclusiveLabel = "VAT Exclusive";
                //String totaltotalVATExclusiveAmount = totalVATExclusive.ToString("#,##0.00");
                //graphics.DrawString(totalVATExclusiveLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                //graphics.DrawString(totaltotalVATExclusiveAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                //y += graphics.MeasureString(totaltotalVATExclusiveAmount, fontArial8Regular).Height;

                String totalVATExemptLabel = "VAT Exempt";
                String totaltotalVATExemptAmount = totalVATExempt.ToString("#,##0.00");
                graphics.DrawString(totalVATExemptLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totaltotalVATExemptAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totaltotalVATExemptAmount, fontArial8Regular).Height;

                String totalVATZeroRatedLabel = "VAT Zero Rated";
                String totalVatZeroRatedAmount = totalVATZeroRated.ToString("#,##0.00");
                graphics.DrawString(totalVATZeroRatedLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(totalVatZeroRatedAmount, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(totalVatZeroRatedAmount, fontArial8Regular).Height;

                // ========
                // 6th Line
                // ========
                Point sixthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point sixthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, sixthLineFirstPoint, sixthLineSecondPoint);

                // =======
                // Cashier
                // =======
                String cashier = collections.FirstOrDefault().MstUser3.UserName;

                String cashierLabel = "\nCashier";
                String cashierUserData = "\n" + cashier;
                graphics.DrawString(cashierLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                graphics.DrawString(cashierUserData, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                y += graphics.MeasureString(cashierUserData, fontArial8Regular).Height;

                // ========
                // 7th Line
                // ========
                Point seventhLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point seventhLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, seventhLineFirstPoint, seventhLineSecondPoint);
                if (Modules.SysCurrentModule.GetCurrentSettings().ShowCustomerInfo == false)
                {
                    String soldToLabel = "\nCustomer Name: _______________________";

                    // ==================================
                    // Senior Citizen and PWD Information
                    // ==================================
                    if (collections.FirstOrDefault().SalesId != null)
                    {
                        if (collections.FirstOrDefault().TrnSale.DiscountId == 7 || collections.FirstOrDefault().TrnSale.DiscountId == 16)
                        {
                            String seniorCitizenID = collections.FirstOrDefault().TrnSale.SeniorCitizenId;
                            String seniorCitizenName = collections.FirstOrDefault().TrnSale.SeniorCitizenName;
                            String seniorCitizenAge = collections.FirstOrDefault().TrnSale.SeniorCitizenAge.ToString();

                            graphics.DrawString("\nSC/PWD ID: " + seniorCitizenID, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenID, fontArial8Regular).Height;

                            graphics.DrawString("\nSC/PWD Name: " + seniorCitizenName, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenName, fontArial8Regular).Height;

                            graphics.DrawString("\nSC/PWD Age: " + seniorCitizenAge, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenAge, fontArial8Regular).Height;

                            // ========
                            // 8th Line
                            // ========
                            Point eightLineFirstPoint = new Point(0, Convert.ToInt32(y) + 18);
                            Point eightLineSecondPoint = new Point(500, Convert.ToInt32(y) + 18);
                            graphics.DrawLine(blackPen, eightLineFirstPoint, eightLineSecondPoint);

                            soldToLabel = "\n\nCustomer Name: _______________________";
                        }
                    }

                    graphics.DrawString(soldToLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToLabel, fontArial8Regular).Height;

                    String soldToAddressLabel = "Address: _____________________________";
                    graphics.DrawString(soldToAddressLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToAddressLabel, fontArial8Regular).Height;

                    String soldToTINLabel = "TIN: _________________________________";
                    graphics.DrawString(soldToTINLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToTINLabel, fontArial8Regular).Height;

                    String soldToBusinessStyleLabel = "Business Style: ________________________";
                    graphics.DrawString(soldToBusinessStyleLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToTINLabel, fontArial8Regular).Height;
                }
                else
                {
                    String customerName = collections.FirstOrDefault().TrnSale.MstCustomer.Customer;
                    String customerAddress = collections.FirstOrDefault().TrnSale.MstCustomer.Address;
                    String customerTIN = collections.FirstOrDefault().TrnSale.MstCustomer.TIN;
                    String customerBusinessStyle = collections.FirstOrDefault().TrnSale.MstCustomer.BusinessStyle;
                    String soldToLabel = "\nCustomer Name: " + customerName;
                    graphics.DrawString(soldToLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToLabel, fontArial8Regular).Height;

                    // ==================================
                    // Senior Citizen and PWD Information
                    // ==================================
                    if (collections.FirstOrDefault().SalesId != null)
                    {
                        if (collections.FirstOrDefault().TrnSale.DiscountId == 7 || collections.FirstOrDefault().TrnSale.DiscountId == 16)
                        {
                            String seniorCitizenID = collections.FirstOrDefault().TrnSale.SeniorCitizenId;
                            String seniorCitizenName = collections.FirstOrDefault().TrnSale.SeniorCitizenName;
                            String seniorCitizenAge = collections.FirstOrDefault().TrnSale.SeniorCitizenAge.ToString();

                            graphics.DrawString("\nSC/PWD ID: " + seniorCitizenID, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenID, fontArial8Regular).Height;

                            graphics.DrawString("\nSC/PWD Name: " + seniorCitizenName, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenName, fontArial8Regular).Height;

                            graphics.DrawString("\nSC/PWD Age: " + seniorCitizenAge, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                            y += graphics.MeasureString(seniorCitizenAge, fontArial8Regular).Height;

                            // ========
                            // 8th Line
                            // ========
                            Point eightLineFirstPoint = new Point(0, Convert.ToInt32(y) + 18);
                            Point eightLineSecondPoint = new Point(500, Convert.ToInt32(y) + 18);
                            graphics.DrawLine(blackPen, eightLineFirstPoint, eightLineSecondPoint);

                            soldToLabel = "\n\nCustomer Name: " + customerName;
                        }
                    }



                    String soldToAddressLabel = "Address: " + customerAddress;
                    graphics.DrawString(soldToAddressLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToAddressLabel, fontArial8Regular).Height;

                    String soldToTINLabel = "TIN: " + customerTIN;
                    graphics.DrawString(soldToTINLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToTINLabel, fontArial8Regular).Height;

                    String soldToBusinessStyleLabel = "Business Style: " + customerBusinessStyle;
                    graphics.DrawString(soldToBusinessStyleLabel, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(soldToTINLabel, fontArial8Regular).Height;
                }


                // ========
                // 9th Line
                // ========
                Point ninethLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point ninethLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, ninethLineFirstPoint, ninethLineSecondPoint);

                String remarks = "\nRemarks: \n\n " + collections.FirstOrDefault().TrnSale.Remarks;
                graphics.DrawString(remarks, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                y += graphics.MeasureString(remarks, fontArial8Regular).Height;

                if(collections.FirstOrDefault().TrnCollectionLines.FirstOrDefault().MstPayType.PayTypeCode == "CREDITCARD")
                {
                    //// =========
                    //// 10th Line
                    //// =========
                    Point tenthLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                    Point tenthLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                    graphics.DrawLine(blackPen, tenthLineFirstPoint, tenthLineSecondPoint);
                    String CCnumber = collectionLines.FirstOrDefault().CreditCardNumber.Substring(0, 12);
                    String CCLast4Number = collectionLines.FirstOrDefault().CreditCardNumber.Substring(12, 4);
                    String creditCardNumber = "\nCredit Card Number:" + CCnumber.Replace(CCnumber, "************") + CCLast4Number;
                    graphics.DrawString(creditCardNumber, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(creditCardNumber, fontArial8Regular).Height;

                    String creditCardType = "Credit Card Type:" + collectionLines.FirstOrDefault().CreditCardType;
                    graphics.DrawString(creditCardType, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(creditCardType, fontArial8Regular).Height;

                    String creditCardBank = "Credit Card Bank:" + collectionLines.FirstOrDefault().CreditCardBank;
                    graphics.DrawString(creditCardBank, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                    y += graphics.MeasureString(creditCardNumber, fontArial8Regular).Height;
                }


                //String orderNumber = "\nOrder Number: \n\n " + collections.FirstOrDefault().TrnSale.SalesNumber;
                //graphics.DrawString(orderNumber, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                //y += graphics.MeasureString(orderNumber, fontArial8Regular).Height;

                // =========
                // 11th Line
                // =========
                Point eleventhLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point eleventhLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, eleventhLineFirstPoint, eleventhLineSecondPoint);

                String receiptFooter = "\n" + systemCurrent.ReceiptFooter;
                graphics.DrawString(receiptFooter, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(receiptFooter, fontArial8Regular).Height;


                if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
                {
                    String space = "\n\n\n\n\n\n\n\n\n\n.";
                    graphics.DrawString(space, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                }
                else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Thermal Printer")
                {
                    String space = "\n\n\n.";
                    graphics.DrawString(space, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                }
                else
                {
                    String space = "\n.";
                    graphics.DrawString(space, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                }
            }
        }
    }
}
