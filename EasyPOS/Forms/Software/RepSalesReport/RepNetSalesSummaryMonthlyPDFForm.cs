﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.RepSalesReport
{
    public partial class RepNetSalesSummaryMonthlyPDFForm : Form
    {
        public DateTime dateStart;
        public DateTime dateEnd;
        public RepNetSalesSummaryMonthlyPDFForm(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            dateStart = startDate;
            dateEnd = endDate;
            Print();
        }
        public String getMonth(Int32 number)
        {
            String returnMonth = "";

            switch (number)
            {
                case 1:
                    returnMonth = "January";
                    break;
                case 2:
                    returnMonth = "Febraury";
                    break;
                case 3:
                    returnMonth = "March";
                    break;
                case 4:
                    returnMonth = "April";
                    break;
                case 5:
                    returnMonth = "May";
                    break;
                case 6:
                    returnMonth = "June";
                    break;
                case 7:
                    returnMonth = "July";
                    break;
                case 8:
                    returnMonth = "August";
                    break;
                case 9:
                    returnMonth = "September";
                    break;
                case 10:
                    returnMonth = "October";
                    break;
                case 11:
                    returnMonth = "November";
                    break;
                case 12:
                    returnMonth = "December";
                    break;
                default:
                    break;
            }

            return returnMonth;
        }
        public void Print()
        {
            try
            {
                Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

                iTextSharp.text.Font fontTimesNewRoman10 = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10);
                iTextSharp.text.Font fontTimesNewRoman10Italic = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10, iTextSharp.text.Font.ITALIC);
                iTextSharp.text.Font fontTimesNewRoman10Bold = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontTimesNewRoman14Bold = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD);

                Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.5F, 100.0F, BaseColor.DARK_GRAY, Element.ALIGN_MIDDLE, 10F)));

                var fileName = "SalesSummaryReport" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
                var currentUser = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;

                var systemCurrent = Modules.SysCurrentModule.GetCurrentSettings();

                Document document = new Document(PageSize.LETTER.Rotate());
                document.SetMargins(30f, 30f, 100f, 30f);

                PdfWriter pdfWriter = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
                pdfWriter.PageEvent = new ConfigureHeaderFooter(dateStart, dateEnd);

                document.Open();

                Controllers.RepSalesReportController repSalesSummaryReportController = new Controllers.RepSalesReportController();
                var salesList = repSalesSummaryReportController.GetNetSalesSummaryReportMonthly(dateStart, dateEnd);

                if (salesList.Any())
                {
                    PdfPTable tableLines = new PdfPTable(8);
                    tableLines.SetWidths(new float[] { 50f, 70f, 50f, 60f, 80f, 70f, 100f, 70f/*, 60f, 60f */});
                    tableLines.WidthPercentage = 100;

                    Decimal totalCustomerCount = 0;
                    Decimal totalQuantity = 0;
                    Decimal totalCostAmount = 0;
                    Decimal totalSalesAmount = 0;
                    Decimal totalMarginAmount = 0;
                    Decimal totalPercentage = 0;

                    foreach (var sales in salesList)
                    {
                        tableLines.AddCell(new PdfPCell(new Phrase(getMonth(sales.Month), fontTimesNewRoman10)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f });
                        tableLines.AddCell(new PdfPCell(new Phrase(sales.Year.ToString(), fontTimesNewRoman10)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f, HorizontalAlignment = 2 });
                        tableLines.AddCell(new PdfPCell(new Phrase(sales.CustomerCount.ToString(), fontTimesNewRoman10)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f, HorizontalAlignment = 2 });
                        tableLines.AddCell(new PdfPCell(new Phrase(sales.Quantity.ToString(), fontTimesNewRoman10)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f, HorizontalAlignment = 2 });
                        tableLines.AddCell(new PdfPCell(new Phrase(sales.CostAmount.ToString("#,##.00"), fontTimesNewRoman10)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f, HorizontalAlignment = 2 });
                        tableLines.AddCell(new PdfPCell(new Phrase(sales.SalesAmount.ToString("#,##.00"), fontTimesNewRoman10)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f, HorizontalAlignment = 2 });
                        tableLines.AddCell(new PdfPCell(new Phrase(sales.MarginAmount.ToString("#,##.00"), fontTimesNewRoman10)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f, HorizontalAlignment = 2 });
                        tableLines.AddCell(new PdfPCell(new Phrase(sales.Percentage.ToString("#,##.00"), fontTimesNewRoman10)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 0f, HorizontalAlignment = 2 });
              
                        totalCustomerCount += Convert.ToDecimal(sales.CustomerCount);
                        totalQuantity += Convert.ToDecimal(sales.Quantity);
                        totalCostAmount += Convert.ToDecimal(sales.CostAmount);
                        totalSalesAmount += Convert.ToDecimal(sales.SalesAmount);
                        totalMarginAmount += Convert.ToDecimal(sales.MarginAmount);
                        totalPercentage += Convert.ToDecimal(sales.Percentage);
                    }

                    tableLines.AddCell(new PdfPCell(new Phrase(line)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = -5f, Colspan = 8 });
                    tableLines.AddCell(new PdfPCell(new Phrase("Total: ", fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, Colspan = 2, HorizontalAlignment = 2 });
                    tableLines.AddCell(new PdfPCell(new Phrase(totalCustomerCount.ToString(), fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 2 });
                    tableLines.AddCell(new PdfPCell(new Phrase(totalQuantity.ToString(), fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 2 });
                    tableLines.AddCell(new PdfPCell(new Phrase(totalCostAmount.ToString("#,##0.00"), fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 2 });
                    tableLines.AddCell(new PdfPCell(new Phrase(totalSalesAmount.ToString("#,##0.00"), fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 2 });
                    tableLines.AddCell(new PdfPCell(new Phrase(totalMarginAmount.ToString("#,##0.00"), fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 2 });
                    tableLines.AddCell(new PdfPCell(new Phrase(totalPercentage.ToString("#,##0.00"), fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 2 });
                    tableLines.AddCell(new PdfPCell(new Phrase(" ", fontTimesNewRoman10Bold)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 3f, PaddingBottom = 20f, HorizontalAlignment = 2 });

                    document.Add(tableLines);
                    document.Close();

                    //ProcessStartInfo info = new ProcessStartInfo(fileName)
                    //{
                    //    Verb = "Print",
                    //    CreateNoWindow = true,
                    //    WindowStyle = ProcessWindowStyle.Hidden
                    //};

                    //Process printDwg = new Process
                    //{
                    //    StartInfo = info
                    //};

                    //printDwg.Start();
                    //printDwg.Close();


                    Process.Start(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Easy ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        class ConfigureHeaderFooter : PdfPageEventHelper
        {
            public DateTime dateStart;
            public DateTime dateEnd;
            public Int32 filterTerminalId;
            public Int32 filterCustomerId;
            public Int32 filterSalesAgentId;

            public Data.easyposdbDataContext db;

            public ConfigureHeaderFooter(DateTime startDate, DateTime endDate)
            {
                dateStart = startDate;
                dateEnd = endDate;

                db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());
            }

            public override void OnEndPage(PdfWriter writer, Document document)
            {
                iTextSharp.text.Font fontTimesNewRoman10 = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10);
                iTextSharp.text.Font fontTimesNewRoman10Bold = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontTimesNewRoman14Bold = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD);

                Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0F, 100.0F, BaseColor.BLACK, Element.ALIGN_MIDDLE, 7F)));

                var systemCurrent = Modules.SysCurrentModule.GetCurrentSettings();

                String companyName = systemCurrent.CompanyName;
                String documentTitle = "Sales Summary Monthly Report";

                PdfPTable tableHeader = new PdfPTable(4);
                tableHeader.SetWidths(new float[] { 20f, 30f, 20f, 50f });
                tableHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                tableHeader.AddCell(new PdfPCell(new Phrase(companyName, fontTimesNewRoman14Bold)) { Colspan = 2, Border = 0, Padding = 3f, PaddingBottom = 3f });
                tableHeader.AddCell(new PdfPCell(new Phrase(documentTitle, fontTimesNewRoman14Bold)) { HorizontalAlignment = 2, Colspan = 2, Border = 0, Padding = 3f, PaddingBottom = 3f });
                tableHeader.AddCell(new PdfPCell(new Phrase("From : " + dateStart.ToShortDateString() + " To: " + dateEnd.ToShortDateString() + "\n", fontTimesNewRoman10)) { Colspan = 4, Border = 0, Padding = 3f, PaddingBottom = -5f });

                PdfPTable tableLines = new PdfPTable(8);
                tableLines.SetWidths(new float[] { 50f, 70f, 50f, 60f, 80f, 70f, 100f, 70f/*, 60f, 60f*/ });
                tableLines.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                tableLines.AddCell(new PdfPCell(new Phrase(" \n", fontTimesNewRoman10Bold)) { Border = 0, Colspan = 12, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Month", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Year", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Customer Count", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Quantity", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Cost Amount", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Sales Amount", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("Margin Amount", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableLines.AddCell(new PdfPCell(new Phrase("%", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                //tableLines.AddCell(new PdfPCell(new Phrase("Sales", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                //tableLines.AddCell(new PdfPCell(new Phrase("Amount", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                //tableLines.AddCell(new PdfPCell(new Phrase("Date/Time", fontTimesNewRoman10Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 5f });
                tableHeader.AddCell(new PdfPCell(tableLines) { Border = 0, Colspan = 4, PaddingBottom = -5f, PaddingLeft = 0f, PaddingRight = 0f });
                tableHeader.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin) + 67f, writer.DirectContent);
            }
        }
    }
}
