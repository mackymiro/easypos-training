﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.MstUser
{
    public partial class MstUserFormDetailForm : Form
    {
        public MstUserDetailForm mstUserDetailForm;
        private Modules.SysUserRightsModule sysUserRights;

        public Entities.MstUserFormEntity mtUserFormEntity;

        public MstUserFormDetailForm(MstUserDetailForm userDetailForm, Entities.MstUserFormEntity userFormEntity)
        {
            InitializeComponent();

            mstUserDetailForm = userDetailForm;
            mtUserFormEntity = userFormEntity;

            sysUserRights = new Modules.SysUserRightsModule("MstUserDetail");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (sysUserRights.GetUserRights().CanEdit == false)
                {
                    buttonSave.Enabled = false;
                }

                GetFormList();
                comboBoxForm.Focus();
            }

            
        }

        public void GetFormList()
        {
            Controllers.MstUserFormController mstUserFormController = new Controllers.MstUserFormController();
            if (mstUserFormController.DropdownListForm().Any())
            {
                comboBoxForm.DataSource = mstUserFormController.DropdownListForm();
                comboBoxForm.ValueMember = "Id";
                comboBoxForm.DisplayMember = "FormDescription";

                GetUserFormDetail();
            }
        }

        public void GetUserFormDetail()
        {
            comboBoxForm.SelectedValue = mtUserFormEntity.FormId;
            checkBoxCanDelete.Checked = mtUserFormEntity.CanDelete;
            checkBoxCanAdd.Checked = mtUserFormEntity.CanAdd;
            checkBoxCanLock.Checked = mtUserFormEntity.CanLock;
            checkBoxCanUnlock.Checked = mtUserFormEntity.CanUnlock;
            checkBoxCanPrint.Checked = mtUserFormEntity.CanPrint;
            checkBoxCanPreview.Checked = mtUserFormEntity.CanPreview;
            checkBoxCanEdit.Checked = mtUserFormEntity.CanEdit;
            checkBoxCanTender.Checked = mtUserFormEntity.CanTender;
            checkBoxCanDiscount.Checked = mtUserFormEntity.CanDiscount;
            checkBoxCanView.Checked = mtUserFormEntity.CanView;
            checkBoxCanSplit.Checked = mtUserFormEntity.CanSplit;
            checkBoxCanCancel.Checked = mtUserFormEntity.CanCancel;
            checkBoxCanReturn.Checked = mtUserFormEntity.CanReturn;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveUserForm();
        }

        public void SaveUserForm()
        {
            Entities.MstUserFormEntity newUserFormEntity = new Entities.MstUserFormEntity()
            {
                Id = mtUserFormEntity.Id,
                FormId = Convert.ToInt32(comboBoxForm.SelectedValue),
                Form = "",
                UserId = mtUserFormEntity.UserId,
                CanDelete = checkBoxCanDelete.Checked,
                CanAdd = checkBoxCanAdd.Checked,
                CanLock = checkBoxCanLock.Checked,
                CanUnlock = checkBoxCanUnlock.Checked,
                CanPrint = checkBoxCanPrint.Checked,
                CanPreview = checkBoxCanPreview.Checked,
                CanEdit = checkBoxCanEdit.Checked,
                CanTender = checkBoxCanTender.Checked,
                CanDiscount = checkBoxCanDiscount.Checked,
                CanView = checkBoxCanView.Checked,
                CanSplit = checkBoxCanSplit.Checked,
                CanCancel = checkBoxCanCancel.Checked,
                CanReturn = checkBoxCanReturn.Checked
            };

            Controllers.MstUserFormController mstUserFormController = new Controllers.MstUserFormController();
            if (newUserFormEntity.Id == 0)
            {
                String[] addUserForm = mstUserFormController.AddUserForm(newUserFormEntity);
                if (addUserForm[1].Equals("0") == false)
                {
                    mstUserDetailForm.UpdateUserFormListDataSource();
                    Close();
                }
                else
                {
                    MessageBox.Show(addUserForm[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                String[] updateUserForm = mstUserFormController.UpdateUserForm(mtUserFormEntity.Id, newUserFormEntity);
                if (updateUserForm[1].Equals("0") == false)
                {
                    mstUserDetailForm.UpdateUserFormListDataSource();
                    Close();
                }
                else
                {
                    MessageBox.Show(updateUserForm[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
