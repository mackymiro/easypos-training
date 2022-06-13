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

namespace EasyPOS.Forms.Software._80mmReport
{
    public partial class TopHourlySellingSalesReport : Form
    {
        public DateTime date;
        public String startHour;
        public String endHour;


        public TopHourlySellingSalesReport(DateTime startDate,String objStartHour, String objEndHour)
        {
            InitializeComponent();
            date = startDate;
            startHour = objStartHour;
            endHour = objEndHour;

            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
            {
                PrintDocument.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 255, 38500);
                PrintDocument.Print();
            }
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Thermal Printer")
            {
                PrintDocument.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 270, 38500);
                PrintDocument.Print();
            }
            else
            {
                PrintDocument.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 175, 38500);
                PrintDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
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
                Font fontArial10Bold = new Font("Arial", 10, FontStyle.Bold);
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

                // =================
                // 80mm Report Title
                // =================
                String title = "Top Hourly Sales Report";
                graphics.DrawString(title, fontArial11Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(title, fontArial11Bold).Height;

                // ==================
                // Date Range Header
                // ==================
                String RangeDateText = "FROM" + " " + date.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                graphics.DrawString(RangeDateText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                y += graphics.MeasureString(RangeDateText, fontArial8Regular).Height;

                // ========
                // 1st Line
                // ========
                Point firstLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
                Point firstLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
                graphics.DrawLine(blackPen, firstLineFirstPoint, firstLineSecondPoint);

            // ===============
            // Stock-in Line
            // ===============

            String salesTime = "\nTime";
            String salesItemDescription = "\nItem Description";
            String salesQuantity = "\nQuantity";
            String amount = "\nAmount";
            graphics.DrawString(salesTime, fontArial7Bold, drawBrush, new RectangleF(x + 5, y, width, height), drawFormatLeft);
            graphics.DrawString(salesItemDescription, fontArial7Bold, drawBrush, new RectangleF(x + 40, y, width, height));
            graphics.DrawString(salesQuantity, fontArial7Bold, drawBrush, new RectangleF(x + 150, y, width, height));
            graphics.DrawString(amount, fontArial7Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(salesItemDescription, fontArial7Regular).Height + 3.0F;

            // ========
            // 2nd Line
            // ========
            Point secondLineFirstPoint = new Point(0, Convert.ToInt32(y) + 3);
            Point secondLineSecondPoint = new Point(500, Convert.ToInt32(y) + 3);
            graphics.DrawLine(blackPen, secondLineFirstPoint, secondLineSecondPoint);

            Decimal totalAmount = 0;

            var listSalesInvoices = from d in db.TrnSalesLines
                                    where d.TrnSale.SalesDate >= date
                                    && d.TrnSale.UpdateDateTime.Hour >= Convert.ToInt32(startHour)
                                    && d.TrnSale.UpdateDateTime.Hour <= Convert.ToInt32(endHour)
                                    && d.TrnSale.IsLocked == true
                                    && d.TrnSale.IsCancelled == false
                                    select new
                                    {
                                        Hour = d.TrnSale.UpdateDateTime.Hour,
                                        ItemDescription = d.MstItem.ItemDescription,
                                        ItemCategory = d.MstItem.Category,
                                        Unit = d.MstUnit.Unit,
                                        Price = d.Price,
                                        Quantity = d.Quantity,
                                        Amount = d.Amount
                                    };

            var topSellingItems = (from d in listSalesInvoices
                                   group d by new
                                   {
                                       d.Hour,
                                       d.ItemDescription,
                                       d.ItemCategory,
                                       d.Unit,
                                       d.Price
                                   } into g
                                   select new
                                   {
                                       Hour = g.Key.Hour,
                                       ItemDescription = g.Key.ItemDescription,
                                       ItemCategory = g.Key.ItemCategory,
                                       Quantity = g.Sum(d => d.Quantity),
                                       Unit = g.Key.Unit,
                                       Price = g.Key.Price,
                                       Amount = g.Sum(d => d.Amount)
                                   }).OrderBy(d => d.Hour).ThenByDescending(d => d.Quantity);
            if (topSellingItems.Any())
            {
                foreach (var topSellingItem in topSellingItems)
                {
                    //String PayType = collection.PayType;
                    //String PayTypeAmount = collection.Amount.ToString("#,##0.00");
                    totalAmount += topSellingItem.Amount;
                    RectangleF itemDataRectangle = new RectangleF
                    {
                        X = x + 15,
                        Y = y + 20,
                        Size = new Size(150, ((int)graphics.MeasureString(topSellingItem.ItemDescription + topSellingItem.ItemCategory, fontArial8Regular, 150, StringFormat.GenericDefault).Height))
                    };
                    graphics.DrawString(topSellingItem.Hour.ToString(), fontArial8Regular, drawBrush, new RectangleF(x +5, y+17, 245.0F, height),drawFormatLeft);
                    graphics.DrawString(topSellingItem.ItemDescription, fontArial8Regular, drawBrush, new RectangleF(x + 40, y, 245.0F, height));
                    graphics.DrawString(topSellingItem.Quantity.ToString(), fontArial8Regular, drawBrush, new RectangleF(x + 150, y, 245.0F, height));
                    y += itemDataRectangle.Size.Height + 3.0F;
                    if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
                    {
                        graphics.DrawString(topSellingItem.Amount.ToString("#,##0.00"), fontArial8Regular, drawBrush, new RectangleF(x, y + 2, 245.0F, height), drawFormatRight);
                    }
                    else
                    {
                        graphics.DrawString(topSellingItem.Amount.ToString("#,##0.00"), fontArial8Regular, drawBrush, new RectangleF(x, y, 255.0F, height), drawFormatRight);
                    }
                }
                // ========
                // 3rd Line
                // ========
                Point thirdLineFirstPoint = new Point(0, Convert.ToInt32(y) + 15);
                Point thirdLineSecondPoint = new Point(500, Convert.ToInt32(y) + 15);
                graphics.DrawLine(blackPen, thirdLineFirstPoint, thirdLineSecondPoint);

                String totalSalesAmount = "\n" + totalAmount.ToString("#,##0.00");
                graphics.DrawString(totalSalesAmount, fontArial8Bold, drawBrush, new RectangleF(x, y + 3, width, height), drawFormatRight);
            }


            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
            {
                String space = "\n\n\n\n\n\n\n\n\n\n.";
                graphics.DrawString(space, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            }
            else
            {
                String space = "\n\n\n.";
                graphics.DrawString(space, fontArial8Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            }
        }
    }
}
