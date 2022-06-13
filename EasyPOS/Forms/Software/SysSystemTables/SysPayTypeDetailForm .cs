﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyPOS.Entities;

namespace EasyPOS.Forms.Software.SysSystemTables
{
    public partial class SysPayTypeDetailForm  : Form
    {
        SysSystemTablesForm sysSystemTablesForm;
        private Modules.SysUserRightsModule sysUserRights;

        MstPayTypeEntity mstPayTypeEntity;

        public SysPayTypeDetailForm (SysSystemTablesForm systemTablesForm, MstPayTypeEntity payTypeEntity)
        {
            InitializeComponent();
            sysSystemTablesForm = systemTablesForm;
            mstPayTypeEntity = payTypeEntity;

            sysUserRights = new Modules.SysUserRightsModule("SysTables");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (sysUserRights.GetUserRights().CanAdd == false)
                {
                    buttonSave.Enabled = false;
                }

                GetAccountList();
                textBoxPayTypeCode.Focus();
            }
        }

        public void LoadPayType()
        {
            if (mstPayTypeEntity != null)
            {
                textBoxPayTypeCode.Text = mstPayTypeEntity.PayTypeCode;
                textBoxPayType.Text = mstPayTypeEntity.PayType;
                comboBoxAccount.SelectedValue = mstPayTypeEntity.AccountId;
            }
        }

        public void GetAccountList()
        {
            Controllers.MstPayTypeController mstPayTypeController = new Controllers.MstPayTypeController();
            var accounts = mstPayTypeController.DropDownListAccount();
            if (accounts.Any())
            {
                comboBoxAccount.DataSource = accounts;
                comboBoxAccount.ValueMember = "Id";
                comboBoxAccount.DisplayMember = "Account";

                LoadPayType();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (mstPayTypeEntity == null)
            {
                MstPayTypeEntity updatePayType = new MstPayTypeEntity()
                {
                    PayTypeCode = textBoxPayTypeCode.Text,
                    PayType = textBoxPayType.Text,
                    AccountId = Convert.ToInt32(comboBoxAccount.SelectedValue)
                };

                Controllers.MstPayTypeController mstPayTypeController = new Controllers.MstPayTypeController();
                String[] addPayType = mstPayTypeController.AddPayType(updatePayType);
                if (addPayType[1].Equals("0"))
                {
                    MessageBox.Show(addPayType[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sysSystemTablesForm.UpdatePayTypeListDataSource();
                    Close();
                }
            }
            else
            {
                mstPayTypeEntity.PayTypeCode = textBoxPayTypeCode.Text;
                mstPayTypeEntity.PayType = textBoxPayType.Text;
                mstPayTypeEntity.AccountId = Convert.ToInt32(comboBoxAccount.SelectedValue);

                Controllers.MstPayTypeController mstPayTypeController = new Controllers.MstPayTypeController();
                String[] updatePayType = mstPayTypeController.UpdatePayType(mstPayTypeEntity);
                if (updatePayType[1].Equals("0"))
                {
                    MessageBox.Show(updatePayType[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sysSystemTablesForm.UpdatePayTypeListDataSource();
                    Close();
                }
            }
        }
    }
}
