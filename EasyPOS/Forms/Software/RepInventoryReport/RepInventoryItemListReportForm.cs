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

namespace EasyPOS.Forms.Software.RepInventoryReport
{
    public partial class RepInventoryItemListReportForm : Form
    {
        public List<Entities.DgvMstItemListEntity> itemList;
        public BindingSource dataItemListSource = new BindingSource();
        public PagedList<Entities.DgvMstItemListEntity> pageList;
        public Int32 pageNumber = 1;
        public Int32 pageSize = 50;

        public RepInventoryItemListReportForm()
        {
            InitializeComponent();
            GetInventoryListDataSource();
            GetItemListDataGridSource();
        }
        public List<Entities.DgvMstItemListEntity> GetInventoryListReport()
        {
            List<Entities.DgvMstItemListEntity> rowList = new List<Entities.DgvMstItemListEntity>();

            Controllers.RepInventoryReportController repInvetoryReportController = new Controllers.RepInventoryReportController();

            var inventoryListReport = repInvetoryReportController.GetInventoryListReport();
            if (inventoryListReport.Any())
            {
                var row = from d in inventoryListReport
                          select new Entities.DgvMstItemListEntity
                          {
                              ColumnItemListCode = d.ItemCode,
                              ColumnItemListBarcode = d.BarCode,
                              ColumnItemListDescription = d.ItemDescription,
                              ColumnItemListUnit = d.Unit,
                              ColumnItemListCategory = d.Category,
                              ColumnItemListPrice = Convert.ToDecimal(d.Price).ToString("#,##0.00"),
                              ColumnItemListCost = Convert.ToDecimal(d.Cost).ToString("#,##0.00"),
                              ColumnItemListOnHandQuantity = Convert.ToDecimal(d.OnhandQuantity).ToString("#,##0.00"),
                              ColumnItemListIsInventory = d.IsInventory,
                              ColumnItemListIsLocked = d.IsLocked
                          };

                rowList = row.ToList();

            }
            return rowList;
        }
        public void GetInventoryListDataSource()
        {
            itemList = GetInventoryListReport();
            if (itemList.Any())
            {

                pageList = new PagedList<Entities.DgvMstItemListEntity>(itemList, pageNumber, pageSize);

                if (pageList.PageCount == 1)
                {
                    buttonPageListFirst.Enabled = false;
                    buttonPageListPrevious.Enabled = false;
                    buttonPageListNext.Enabled = false;
                    buttonPageListLast.Enabled = false;
                }
                else if (pageNumber == 1)
                {
                    buttonPageListFirst.Enabled = false;
                    buttonPageListPrevious.Enabled = false;
                    buttonPageListNext.Enabled = true;
                    buttonPageListLast.Enabled = true;
                }
                else if (pageNumber == pageList.PageCount)
                {
                    buttonPageListFirst.Enabled = true;
                    buttonPageListPrevious.Enabled = true;
                    buttonPageListNext.Enabled = false;
                    buttonPageListLast.Enabled = false;
                }
                else
                {
                    buttonPageListFirst.Enabled = true;
                    buttonPageListPrevious.Enabled = true;
                    buttonPageListNext.Enabled = true;
                    buttonPageListLast.Enabled = true;
                }

                textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
                dataItemListSource.DataSource = pageList;
            }
            else
            {
                buttonPageListFirst.Enabled = false;
                buttonPageListPrevious.Enabled = false;
                buttonPageListNext.Enabled = false;
                buttonPageListLast.Enabled = false;

                dataItemListSource.Clear();
                textBoxPageNumber.Text = "0 / 0";
            }
        }

        public void GetItemListDataGridSource()
        {
            dataGridViewItemListReport.DataSource = dataItemListSource;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPageListFirst_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvMstItemListEntity>(itemList, 1, pageSize);
            dataItemListSource.DataSource = pageList;

            buttonPageListFirst.Enabled = false;
            buttonPageListPrevious.Enabled = false;
            buttonPageListNext.Enabled = true;
            buttonPageListLast.Enabled = true;

            pageNumber = 1;
            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonPageListPrevious_Click(object sender, EventArgs e)
        {
            if (pageList.HasPreviousPage == true)
            {
                pageList = new PagedList<Entities.DgvMstItemListEntity>(itemList, --pageNumber, pageSize);
                dataItemListSource.DataSource = pageList;
            }

            buttonPageListNext.Enabled = true;
            buttonPageListLast.Enabled = true;

            if (pageNumber == 1)
            {
                buttonPageListFirst.Enabled = false;
                buttonPageListPrevious.Enabled = false;
            }

            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonPageListNext_Click(object sender, EventArgs e)
        {
            if (pageList.HasNextPage == true)
            {
                pageList = new PagedList<Entities.DgvMstItemListEntity>(itemList, ++pageNumber, pageSize);
                dataItemListSource.DataSource = pageList;
            }

            buttonPageListFirst.Enabled = true;
            buttonPageListPrevious.Enabled = true;

            if (pageNumber == pageList.PageCount)
            {
                buttonPageListNext.Enabled = false;
                buttonPageListLast.Enabled = false;
            }

            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;
        }

        private void buttonPageListLast_Click(object sender, EventArgs e)
        {
            pageList = new PagedList<Entities.DgvMstItemListEntity>(itemList, pageList.PageCount, pageSize);
            dataItemListSource.DataSource = pageList;

            buttonPageListFirst.Enabled = true;
            buttonPageListPrevious.Enabled = true;
            buttonPageListNext.Enabled = false;
            buttonPageListLast.Enabled = false;

            pageNumber = pageList.PageCount;
            textBoxPageNumber.Text = pageNumber + " / " + pageList.PageCount;

        }

        private void buttonGenerateCSV_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = folderBrowserDialogGenerateCSV.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    StringBuilder csv = new StringBuilder();
                    String[] header = { "Item Code", "Barcode", "Item Description","Unit", "Cost", "Price" };
                    csv.AppendLine(String.Join(",", header));

                    if (itemList.Any())
                    {
                        foreach (var item in itemList)
                        {
                            String Barcode = "";
                            if (item.ColumnItemListBarcode != null)
                            {
                                Barcode = item.ColumnItemListBarcode.Replace(",", "");
                            }

                            String[] data = {
                                "="+"\""+item.ColumnItemListCode + "\"",
                                "="+"\""+Barcode+"\"",
                                item.ColumnItemListDescription.Replace("," , ""),
                                item.ColumnItemListUnit.Replace("," , ""),
                                item.ColumnItemListCost.Replace("," , ""),
                                item.ColumnItemListPrice.Replace("," , "")
                            };
                            csv.AppendLine(String.Join(",", data));
                        }
                    }

                    String executingUser = WindowsIdentity.GetCurrent().Name;

                    DirectorySecurity securityRules = new DirectorySecurity();
                    securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.Read, AccessControlType.Allow));
                    securityRules.AddAccessRule(new FileSystemAccessRule(executingUser, FileSystemRights.FullControl, AccessControlType.Allow));

                    DirectoryInfo createDirectorySTCSV = Directory.CreateDirectory(folderBrowserDialogGenerateCSV.SelectedPath, securityRules);
                    File.WriteAllText(createDirectorySTCSV.FullName + "\\InventoryListReport_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".csv", csv.ToString(), Encoding.GetEncoding("iso-8859-1"));

                    MessageBox.Show("Generate CSV Successful!", "Generate CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
