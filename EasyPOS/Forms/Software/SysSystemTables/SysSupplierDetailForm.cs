﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.SysSystemTables
{
    public partial class SysSupplierDetailForm : Form
    {
        SysSystemTablesForm sysSystemTablesForm;
        private Modules.SysUserRightsModule sysUserRights;

        Entities.MstSupplierEntity mstSupplierEntity;

        public SysSupplierDetailForm(SysSystemTablesForm systemTablesForm, Entities.MstSupplierEntity supplierEntity)
        {
            InitializeComponent();
            sysSystemTablesForm = systemTablesForm;
            mstSupplierEntity = supplierEntity;

            sysUserRights = new Modules.SysUserRightsModule("SysTables");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GetTermList();
            }

        }

        public void GetTermList()
        {
            Controllers.MstSupplierController mstSupplierController = new Controllers.MstSupplierController();
            var terms = mstSupplierController.DropDownListTerms();
            if (terms.Any())
            {
                comboBoxTerm.DataSource = terms;
                comboBoxTerm.ValueMember = "Id";
                comboBoxTerm.DisplayMember = "Term";

                GetAccountList();
            }
        }

        public void GetAccountList()
        {
            Controllers.MstSupplierController mstSupplierController = new Controllers.MstSupplierController();
            var accounts = mstSupplierController.DropDownListAccount();
            if (accounts.Any())
            {
                comboBoxAccount.DataSource = accounts;
                comboBoxAccount.ValueMember = "Id";
                comboBoxAccount.DisplayMember = "Account";
                LoadComponent(mstSupplierEntity.IsLocked);
            }
        }

        public void LoadComponent(Boolean isLocked)
        {
            if (sysUserRights.GetUserRights().CanLock == false)
            {
                buttonLock.Enabled = false;
                buttonLock.Enabled = false;
                textBoxSupplier.Enabled = false;
                textBoxAddress.Enabled = false;
                textBoxTelephoneNumber.Enabled = false;
                textBoxCellphoneNumber.Enabled = false;
                textBoxFaxNumber.Enabled = false;
                comboBoxTerm.Enabled = false;
                textBoxTIN.Enabled = false;
                comboBoxAccount.Enabled = false;
            }
            else
            {
                buttonLock.Enabled = !isLocked;
                textBoxSupplier.Enabled = !isLocked;
                textBoxAddress.Enabled = !isLocked;
                textBoxTelephoneNumber.Enabled = !isLocked;
                textBoxCellphoneNumber.Enabled = !isLocked;
                textBoxFaxNumber.Enabled = !isLocked;
                comboBoxTerm.Enabled = !isLocked;
                textBoxTIN.Enabled = !isLocked;
                comboBoxAccount.Enabled = !isLocked;
                textBoxSupplier.Focus();
            }

            if (sysUserRights.GetUserRights().CanUnlock == false)
            {
                buttonUnlock.Enabled = false;
            }
            else
            {
                buttonUnlock.Enabled = isLocked;
            }

            textBoxSupplier.Text = mstSupplierEntity.Supplier;
            textBoxAddress.Text = mstSupplierEntity.Address;
            textBoxTelephoneNumber.Text = mstSupplierEntity.TelephoneNumber;
            textBoxCellphoneNumber.Text = mstSupplierEntity.CellphoneNumber;
            textBoxFaxNumber.Text = mstSupplierEntity.FaxNumber;
            comboBoxTerm.SelectedValue = mstSupplierEntity.TermId;
            textBoxTIN.Text = mstSupplierEntity.TIN;
            comboBoxAccount.SelectedValue = mstSupplierEntity.AccountId;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            mstSupplierEntity.Supplier = textBoxSupplier.Text;
            mstSupplierEntity.Address = textBoxAddress.Text;
            mstSupplierEntity.TelephoneNumber = textBoxTelephoneNumber.Text;
            mstSupplierEntity.CellphoneNumber = textBoxCellphoneNumber.Text;
            mstSupplierEntity.FaxNumber = textBoxFaxNumber.Text;
            mstSupplierEntity.TermId = Convert.ToInt32(comboBoxTerm.SelectedValue);
            mstSupplierEntity.TIN = textBoxTIN.Text;
            mstSupplierEntity.AccountId = Convert.ToInt32(comboBoxAccount.SelectedValue);

            Controllers.MstSupplierController mstSupplierController = new Controllers.MstSupplierController();
            String[] updateSupplier = mstSupplierController.LockSupplier(mstSupplierEntity);
            if (updateSupplier[1].Equals("0") == false)
            {
                LoadComponent(true);
                sysSystemTablesForm.UpdateSupplierListDataSource();
            }
            else
            {
                MessageBox.Show(updateSupplier[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {
            Controllers.MstSupplierController mstSupplierController = new Controllers.MstSupplierController();
            String[] updateSupplier = mstSupplierController.UnlockSupplier(mstSupplierEntity);
            if (updateSupplier[1].Equals("0") == false)
            {
                LoadComponent(false);
                sysSystemTablesForm.UpdateSupplierListDataSource();
            }
            else
            {
                MessageBox.Show(updateSupplier[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
