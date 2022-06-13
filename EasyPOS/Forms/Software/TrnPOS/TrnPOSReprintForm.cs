﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.TrnPOS
{
    public partial class TrnPOSReprintForm : Form
    {
        public SysSoftwareForm sysSoftwareForm;

        public Int32 trnSalesId = 0;
        public Int32 trnCollectionId = 0;

        public TrnPOSReprintForm(SysSoftwareForm softwareForm, Int32 salesId, Int32 collectionId)
        {
            InitializeComponent();

            sysSoftwareForm = softwareForm;

            trnSalesId = salesId;
            trnCollectionId = collectionId;
        }

        private void buttonOfficialReceipt_Click(object sender, EventArgs e)
        {
            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

            DialogResult cancelDialogResult = MessageBox.Show("Reprint Sales?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cancelDialogResult == DialogResult.Yes)
            {
                DialogResult printDialogResult = printDialogReprint.ShowDialog();
                if (printDialogResult == DialogResult.OK)
                {
                    new TrnPOSOfficialReceiptReportForm(trnSalesId, trnCollectionId, true, printDialogReprint.PrinterSettings.PrinterName);
                    Close();
                    var sales = from d in db.TrnSales
                                where d.Id == trnSalesId
                                select d;

                    var UpdateSales = sales.FirstOrDefault();
                    UpdateSales.IsReprinted = true;
                    UpdateSales.NumberOfReprinted = UpdateSales.NumberOfReprinted + 1;
                    db.SubmitChanges();

                }
            }
        }

        private void buttonDeliveryReceipt_Click(object sender, EventArgs e)
        {
            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

            DialogResult cancelDialogResult = MessageBox.Show("Reprint Sales?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cancelDialogResult == DialogResult.Yes)
            {
                new TrnPOSDeliveryReceiptReportForm("", StockWithdrawalReport(trnCollectionId), true, false, false);
                MessageBox.Show("Generate PDF Successful!", "Generate CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var sales = from d in db.TrnSales
                            where d.Id == trnSalesId
                            select d;

                var UpdateSales = sales.FirstOrDefault();
                UpdateSales.IsReprinted = true;
                UpdateSales.NumberOfReprinted = UpdateSales.NumberOfReprinted + 1;
                db.SubmitChanges();
            }
        }

        private void buttonWithdrawalSlip_Click(object sender, EventArgs e)
        {
            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

            DialogResult cancelDialogResult = MessageBox.Show("Reprint Sales?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cancelDialogResult == DialogResult.Yes)
            {
                new TrnPOSDeliveryReceiptReportForm("", StockWithdrawalReport(trnCollectionId), false,true, false);
                MessageBox.Show("Generate PDF Successful!", "Generate CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var sales = from d in db.TrnSales
                            where d.Id == trnSalesId
                            select d;

                var UpdateSales = sales.FirstOrDefault();
                UpdateSales.IsReprinted = true;
                UpdateSales.NumberOfReprinted = UpdateSales.NumberOfReprinted + 1;
                db.SubmitChanges();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ===============================================
        // Stock Withdrawal Report (Copied) To be modified
        // ===============================================
        public List<Entities.RepSalesReportCollectionSummaryReportEntity> StockWithdrawalReport(Int32 id)
        {
            Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

            var stockWithdrawalReports = from d in db.TrnCollections
                                         where d.Id == id
                                         select new Entities.RepSalesReportCollectionSummaryReportEntity
                                         {
                                             Id = d.Id,
                                             SalesId = d.SalesId,
                                             CollectionNumber = d.CollectionNumber
                                         };

            return stockWithdrawalReports.ToList();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F2:
                    {
                        if (buttonOfficialReceipt.Enabled == true)
                        {
                            buttonOfficialReceipt.PerformClick();
                            Focus();
                        }

                        break;
                    }
                case Keys.F3:
                    {
                        if (buttonDeliveryReceipt.Enabled == true)
                        {
                            buttonDeliveryReceipt.PerformClick();
                            Focus();
                        }

                        break;
                    }
                case Keys.F4:
                    {
                        if (buttonWithdrawalSlip.Enabled == true)
                        {
                            buttonWithdrawalSlip.PerformClick();
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
    }
}
