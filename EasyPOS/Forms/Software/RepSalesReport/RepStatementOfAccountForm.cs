﻿using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.RepSalesReport
{
    public partial class RepStatementOfAccountForm : Form
    {
        public List<Entities.DgvRepStatementOfAccountListEntity> salesList;
        public BindingSource dataSalesListSource = new BindingSource();
        public PagedList<Entities.DgvRepStatementOfAccountListEntity> pageList;
        public Int32 pageNumber = 1;
        public Int32 pageSize = 50;

        public DateTime dateStart;
        public DateTime dateEnd;
        public Int32 filterTerminalId;
        public Int32 filterCustomerId;
        public Int32 filterSalesAgentId;
        public RepStatementOfAccountForm(DateTime startDate, DateTime endDate, Int32 terminalId, Int32 CustomerId, Int32 SalesAgentId)
        {
            InitializeComponent();
           
            filterCustomerId = CustomerId;
            dateStart = startDate;
            dateEnd = endDate;


            GetSalesSummaryListDataSource();
            CreateSalesSummaryListDataGrid();
        }

        public List<Entities.DgvRepStatementOfAccountListEntity> GetSalesSummaryListData(Int32 CustomerId, DateTime startDate, DateTime endDate)
        {
            List<Entities.DgvRepStatementOfAccountListEntity> rowList = new List<Entities.DgvRepStatementOfAccountListEntity>();

            Controllers.RepSalesReportController repSalesSummaryReportController = new Controllers.RepSalesReportController();

            var salesList = repSalesSummaryReportController.SOAReport(CustomerId , startDate , endDate);
            if (salesList.Any())
            {
                Decimal totalAmount = 0;
                var row = from d in salesList
                          select new Entities.DgvRepStatementOfAccountListEntity
                          {
                              ColumnId = d.Id,                  
                              ColumnSalesDate = d.SalesDate,
                              ColumnSalesNumber = d.SalesNumber,
                              ColumnCustomerCode = d.CustomerCode,
                              ColumnCustomer = d.Customer,                          
                              ColumnAmount = d.Amount.ToString("#,##0.00"),
                              ColumnPaidAmount = d.PaidAmount.ToString("#,##0.00"),
                              ColumnBalanceAmount = d.BalanceAmount.ToString("#,##0.00"),
                              ColumnEntryDateTime = d.EntryDateTime,                           
                          };

                totalAmount = salesList.Sum(d => d.Amount);
                textBoxTotalAmount.Text = totalAmount.ToString("#,##0.00");

                rowList = row.ToList();

            }
            return rowList;
        }

        public void GetSalesSummaryListDataSource()
        {
            salesList = GetSalesSummaryListData(filterCustomerId, dateStart, dateEnd );
            if (salesList.Any())
            {

                pageList = new PagedList<Entities.DgvRepStatementOfAccountListEntity>(salesList, pageNumber, pageSize);

                if (pageList.PageCount == 1)
                {
                    buttonSalesListPageListFirst.Enabled = false;
                    buttonSalesListPageListPrevious.Enabled = false;
                    buttonSalesListPageListNext.Enabled = false;
                    buttonSalesListPageListLast.Enabled = false;
                }
                else if (pageNumber == 1)
                {
                    buttonSalesListPageListFirst.Enabled = false;
                    buttonSalesListPageListPrevious.Enabled = false;
                    buttonSalesListPageListNext.Enabled = true;
                    buttonSalesListPageListLast.Enabled = true;
                }
                else if (pageNumber == pageList.PageCount)
                {
                    buttonSalesListPageListFirst.Enabled = true;
                    buttonSalesListPageListPrevious.Enabled = true;
                    buttonSalesListPageListNext.Enabled = false;
                    buttonSalesListPageListLast.Enabled = false;
                }
                else
                {
                    buttonSalesListPageListFirst.Enabled = true;
                    buttonSalesListPageListPrevious.Enabled = true;
                    buttonSalesListPageListNext.Enabled = true;
                    buttonSalesListPageListLast.Enabled = true;
                }

                textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
                dataSalesListSource.DataSource = pageList;
            }
            else
            {
                buttonSalesListPageListFirst.Enabled = false;
                buttonSalesListPageListPrevious.Enabled = false;
                buttonSalesListPageListNext.Enabled = false;
                buttonSalesListPageListLast.Enabled = false;

                dataSalesListSource.Clear();
                textBoxPageNumber.Text = "0 / 0";
            }
        }

        public void CreateSalesSummaryListDataGrid()
        {
            dataGridViewSalesSummaryReport.DataSource = dataSalesListSource;
        }

        private void buttonSalesListPageListFirst_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvRepStatementOfAccountListEntity>(salesList, 1, pageSize);
            dataSalesListSource.DataSource = pageList;

            buttonSalesListPageListFirst.Enabled = false;
            buttonSalesListPageListPrevious.Enabled = false;
            buttonSalesListPageListNext.Enabled = true;
            buttonSalesListPageListLast.Enabled = true;

            pageNumber = 1;
            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonSalesListPageListPrevious_Click(object sender, EventArgs e)
        {
            if (pageList.HasPreviousPage == true)
            {
                pageList = new PagedList<Entities.DgvRepStatementOfAccountListEntity>(salesList, --pageNumber, pageSize);
                dataSalesListSource.DataSource = pageList;
            }

            buttonSalesListPageListNext.Enabled = true;
            buttonSalesListPageListLast.Enabled = true;

            if (pageNumber == 1)
            {
                buttonSalesListPageListFirst.Enabled = false;
                buttonSalesListPageListPrevious.Enabled = false;
            }

            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonSalesListPageListNext_Click(object sender, EventArgs e)
        {
            if (pageList.HasNextPage == true)
            {
                pageList = new PagedList<Entities.DgvRepStatementOfAccountListEntity>(salesList, ++pageNumber, pageSize);
                dataSalesListSource.DataSource = pageList;
            }

            buttonSalesListPageListFirst.Enabled = true;
            buttonSalesListPageListPrevious.Enabled = true;

            if (pageNumber == pageList.PageCount)
            {
                buttonSalesListPageListNext.Enabled = false;
                buttonSalesListPageListLast.Enabled = false;
            }

            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonSalesListPageListLast_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvRepStatementOfAccountListEntity>(salesList, pageList.PageCount, pageSize);
            dataSalesListSource.DataSource = pageList;

            buttonSalesListPageListFirst.Enabled = true;
            buttonSalesListPageListPrevious.Enabled = true;
            buttonSalesListPageListNext.Enabled = false;
            buttonSalesListPageListLast.Enabled = false;

            pageNumber = pageList.PageCount;
            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonClose_OnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGenerateCSV_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = folderBrowserDialogGenerateCSV.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    StringBuilder csv = new StringBuilder();
                    String[] header = { "Date", "Sales Number", "Customer Code", "Customer", "Paid Amount", "Balance Amount", "Amount" };
                    csv.AppendLine(String.Join(",", header));

                    if (salesList.Any())
                    {
                        foreach (var sales in salesList)
                        {
                            String customerCode = "";
                            if (sales.ColumnCustomerCode != null)
                            {
                                customerCode = sales.ColumnCustomerCode.Replace(",", "");
                            }

                            String[] data = {
                               
                                sales.ColumnSalesDate,
                                sales.ColumnSalesNumber,
                                customerCode,
                                sales.ColumnCustomer.Replace("," , ""),                            
                                //sales.ColumnTerm.Replace("," , ""),
                                //sales.ColumnRemarks.Replace(",", String.Empty).Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty),
                                //sales.ColumnPreparedByUserName.Replace("," , ""),
                                sales.ColumnAmount.Replace("," , ""),
                                sales.ColumnPaidAmount.Replace("," , ""),
                                sales.ColumnBalanceAmount.Replace("," , ""),
                                sales.ColumnEntryDateTime,
                            };

                            csv.AppendLine(String.Join(",", data));
                        }
                    }

                    String executingUser = WindowsIdentity.GetCurrent().Name;

                    DirectorySecurity securityRules = new DirectorySecurity();
                    securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.Read, AccessControlType.Allow));
                    securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.FullControl, AccessControlType.Allow));

                    DirectoryInfo createDirectorySTCSV = Directory.CreateDirectory(folderBrowserDialogGenerateCSV.SelectedPath, securityRules);
                    File.WriteAllText(createDirectorySTCSV.FullName + "\\SalesSummaryReport_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".csv", csv.ToString(), Encoding.GetEncoding("iso-8859-1"));

                    MessageBox.Show("Generate CSV Successful!", "Generate CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
           new RepStatementOfAccountPDFForm(filterCustomerId, dateStart, dateEnd);

        }
    }
}
