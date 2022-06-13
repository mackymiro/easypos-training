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
    public partial class ItemSalesByCategory80mmReportForm : Form
    {
        public DateTime startDate;
        public DateTime endDate;
        public ItemSalesByCategory80mmReportForm(DateTime StartDate, DateTime EndDate)
        {
            InitializeComponent();
            startDate = StartDate;
            endDate = EndDate;

            if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Dot Matrix Printer")
            {
                printDocument80mm.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 255, 38500);
                printDocument80mm.Print();
            }
            else if (Modules.SysCurrentModule.GetCurrentSettings().PrinterType == "Thermal Printer")
            {
                printDocument80mm.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 270, 38500);
                printDocument80mm.Print();
            }
            else
            {
                printDocument80mm.DefaultPageSettings.PaperSize = new PaperSize("Official Receipt", 175, 38500);
                printDocument80mm.Print();
            }
        }

        private void printDocument80mm_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            String title = "Sales Item Report";
            graphics.DrawString(title, fontArial11Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(title, fontArial11Bold).Height;

            // ==================
            // Date Range Header
            // ==================
            String RangeDateText = "FROM" + " " + startDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
            graphics.DrawString(RangeDateText, fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += graphics.MeasureString(RangeDateText, fontArial8Regular).Height;

            // ========
            // 1st Line
            // ========
            Point firstLineFirstPoint = new Point(0, Convert.ToInt32(y) + 5);
            Point firstLineSecondPoint = new Point(500, Convert.ToInt32(y) + 5);
            graphics.DrawLine(blackPen, firstLineFirstPoint, firstLineSecondPoint);

            // ===============
            // Sales Line
            // ===============

            String category = "\nItem Category";
            String quantity = "\nSold Quantity";
            String Amount = "\nAmount";
            graphics.DrawString(category, fontArial7Bold, drawBrush, new RectangleF(x + 20, y, width, height), drawFormatLeft);
            graphics.DrawString(quantity, fontArial7Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            graphics.DrawString(Amount, fontArial7Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += graphics.MeasureString(category, fontArial7Regular).Height + 3.0F;


            // ========
            // 2nd Line
            // ========
            Point secondLineFirstPoint = new Point(0, Convert.ToInt32(y) + 3);
            Point secondLineSecondPoint = new Point(500, Convert.ToInt32(y) + 3);
            graphics.DrawLine(blackPen, secondLineFirstPoint, secondLineSecondPoint);

            Decimal totalAmount = 0;

            var listSalesInvoices = from d in db.TrnSalesLines
                                    where d.TrnSale.SalesDate >= startDate
                                    && d.TrnSale.SalesDate >= endDate
                                    && d.TrnSale.IsLocked == true
                                    && d.TrnSale.IsCancelled == false
                                    select new
                                    {
                                        ItemCategory = d.MstItem.Category,
                                        SoldQuantity = d.Quantity,
                                        Amount = d.Amount
                                    };

            var categoriesItem = from d in listSalesInvoices
                                  group d by new
                                  {
                                      d.ItemCategory,
                                  } into g
                                  select new
                                  {
                                      ItemCategory = g.Key.ItemCategory,
                                      Quantity = g.Sum(d => d.SoldQuantity),
                                      Amount = g.Sum(d => d.Amount)
                                  };
            if (categoriesItem.Any())
            {
                foreach (var item in categoriesItem)
                {
                    totalAmount += item.Amount;
                    String salesData = item.ItemCategory + item.Quantity + item.Amount.ToString("#,##0.00");

                    RectangleF itemDataRectangle = new RectangleF
                    {
                        X = x,
                        Y = y,

                        Size = new Size(240, ((int)graphics.MeasureString(salesData, fontArial8Regular, 240, StringFormat.GenericDefault).Height))
                    };
                    graphics.DrawString("\n" + item.ItemCategory + "\n", fontArial8Regular, drawBrush, new RectangleF(x, y, 120, height), drawFormatLeft);
                    graphics.DrawString("\n" + item.Quantity + "\n", fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
                    graphics.DrawString("\n" + item.Amount.ToString("#,##0.00") + "\n", fontArial8Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
                    y += itemDataRectangle.Size.Height + 3.0F;
                }
                // ========
                // 3rd Line
                // ========
                Point thirdLineFirstPoint = new Point(0, Convert.ToInt32(y) + 15);
                Point thirdLineSecondPoint = new Point(500, Convert.ToInt32(y) + 15);
                graphics.DrawLine(blackPen, thirdLineFirstPoint, thirdLineSecondPoint);

                String totalSalesAmount = "\n" + totalAmount.ToString("#,##0.00");
                graphics.DrawString(totalSalesAmount, fontArial8Regular, drawBrush, new RectangleF(x, y+2, width, height), drawFormatRight);
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
