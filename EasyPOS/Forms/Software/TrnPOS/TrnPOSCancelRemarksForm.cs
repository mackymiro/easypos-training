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
    public partial class TrnPOSCancelRemarksForm : Form
    {
        public SysSoftwareForm sysSoftwareForm;

        public TrnPOSBarcodeForm trnSalesListForm;
        public TrnPOSTouchForm trnPOSTouchForm;
        public TrnPOSTouchQuickServiceForm trnPOSTouchQuickServiceForm;

        public Int32 salesId;

        public TrnPOSCancelRemarksForm(SysSoftwareForm softwareForm, TrnPOSBarcodeForm salesListForm, TrnPOSTouchForm POSTouchForm, TrnPOSTouchQuickServiceForm POSTouchQuickServiceForm ,Int32 currentSalesId)
        {
            InitializeComponent();

            sysSoftwareForm = softwareForm;
            trnSalesListForm = salesListForm;
            trnPOSTouchForm = POSTouchForm;
            trnPOSTouchQuickServiceForm = POSTouchQuickServiceForm;
            salesId = currentSalesId;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (trnSalesListForm != null)
            {
                trnSalesListForm.SetContinueCancel(false);
            }

            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            String remarks = textBoxCancelRemarks.Text;

            if (trnSalesListForm != null)
            {
                trnSalesListForm.SetCancelRemarks(remarks);
                trnSalesListForm.SetContinueCancel(true);
            }

            if (trnPOSTouchForm != null)
            {
                DialogResult cancelDialogResult = MessageBox.Show("Cancel Transaction? ", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cancelDialogResult == DialogResult.Yes)
                {
                    Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();

                    if (trnPOSSalesController.CanCancelCollection(salesId))
                    {
                        String[] cancelSales = trnPOSSalesController.CancelSales(salesId, textBoxCancelRemarks.Text);
                        if (cancelSales[1].Equals("0") == false)
                        {
                            MessageBox.Show("Cancel Successful.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            trnPOSTouchForm.UpdateSalesListGridDataSource();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(cancelSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not allowed.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (trnPOSTouchQuickServiceForm != null)
            {
                DialogResult cancelDialogResult = MessageBox.Show("Cancel Transaction? ", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cancelDialogResult == DialogResult.Yes)
                {
                    Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();

                    if (trnPOSSalesController.CanCancelCollection(salesId))
                    {
                        String[] cancelSales = trnPOSSalesController.CancelSales(salesId, textBoxCancelRemarks.Text);
                        if (cancelSales[1].Equals("0") == false)
                        {
                            MessageBox.Show("Cancel Successful.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            trnPOSTouchQuickServiceForm.UpdateSalesListGridDataSource();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(cancelSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not allowed.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    {
                        if (buttonOK.Enabled == true)
                        {
                            buttonOK.PerformClick();
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
