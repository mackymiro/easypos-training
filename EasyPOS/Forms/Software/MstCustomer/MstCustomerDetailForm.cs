﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EasyPOS.Forms.Software.MstCustomer
{
    public partial class MstCustomerDetailForm : Form
    {
        public SysSoftwareForm sysSoftwareForm;
        private Modules.SysUserRightsModule sysUserRights;

        public MstCustomerListForm mstCustomerListForm;
        public Entities.MstCustomerEntity mstCustomerEntity;
        public List<String> gender;

        public MstCustomerDetailForm(SysSoftwareForm softwareForm, MstCustomerListForm itemListForm, Entities.MstCustomerEntity itemEntity)
        {
            InitializeComponent();
            sysSoftwareForm = softwareForm;

            sysUserRights = new Modules.SysUserRightsModule("MstCustomerDetail");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                mstCustomerListForm = itemListForm;
                mstCustomerEntity = itemEntity;

                gender = new List<String>
                {
                    "Male",
                    "Female"
                };

                comboBoxGender.DataSource = gender;

                textBoxCustomerCode.Focus();
                GetTermList();

            }
        }

        public void GetTermList()
        {
            Controllers.MstCustomerController mstCustomerController = new Controllers.MstCustomerController();
            if (mstCustomerController.DropdownListCustomerTerm().Any())
            {
                comboBoxTerm.DataSource = mstCustomerController.DropdownListCustomerTerm();
                comboBoxTerm.ValueMember = "Id";
                comboBoxTerm.DisplayMember = "Term";

                GetCustomerDetail();
            }
        }

        public void ComputeAge()
        {
            Int32 dateNow = Int32.Parse(DateTime.Now.ToString("yyyyMMdd"));
            Int32 birthDay = Int32.Parse(dateTimePickerBirthday.Value.ToString("yyyyMMdd"));

            Int32 currentAge = (dateNow - birthDay)/ 10000;
            textBoxAge.Text = Convert.ToString(currentAge);
        }

        public void GetCustomerDetail()
        {
            UpdateComponents(mstCustomerEntity.IsLocked);

            textBoxCustomerCode.Text = mstCustomerEntity.CustomerCode;
            textBoxCustomer.Text = mstCustomerEntity.Customer;
            textBoxAddress.Text = mstCustomerEntity.Address;
            textBoxContactPerson.Text = mstCustomerEntity.ContactPerson;
            textBoxContactNumber.Text = mstCustomerEntity.ContactNumber;
            textBoxCreditLimit.Text = mstCustomerEntity.CreditLimit.ToString("#,##0.00");
            comboBoxTerm.SelectedValue = mstCustomerEntity.TermId;
            textBoxTIN.Text = mstCustomerEntity.TIN;
            checkBoxWithReward.Checked = mstCustomerEntity.WithReward;
            textBoxRewardNumber.Text = mstCustomerEntity.RewardNumber;
            textBoxRewardConversion.Text = mstCustomerEntity.RewardConversion.ToString("#,##0.00");
            textBoxAvailableReward.Text = mstCustomerEntity.AvailableReward.ToString("#,##0.00");
            textBoxDefaultPrice.Text = mstCustomerEntity.DefaultPriceDescription;
            textBoxBusinessStyle.Text = mstCustomerEntity.BusinessStyle;
            dateTimePickerBirthday.Text = mstCustomerEntity.Birthday;
            textBoxAge.Text = mstCustomerEntity.Age.ToString();
            comboBoxGender.Text = mstCustomerEntity.Gender;
            textBoxEmailAddress.Text = mstCustomerEntity.EmailAddress;
        }

        public void UpdateComponents(Boolean isLocked)
        {
            if (sysUserRights.GetUserRights().CanLock == false)
            {
                buttonLock.Enabled = false;
            }
            else
            {
                buttonLock.Enabled = !isLocked;
            }

            if (sysUserRights.GetUserRights().CanUnlock == false)
            {
                buttonUnlock.Enabled = false;
            }
            else
            {
                buttonUnlock.Enabled = isLocked;
            }

            textBoxCustomerCode.Enabled = !isLocked;
            textBoxCustomer.Enabled = !isLocked;
            textBoxAddress.Enabled = !isLocked;
            textBoxContactPerson.Enabled = !isLocked;
            textBoxContactNumber.Enabled = !isLocked;
            textBoxCreditLimit.Enabled = !isLocked;
            comboBoxTerm.Enabled = !isLocked;
            textBoxTIN.Enabled = !isLocked;
            checkBoxWithReward.Enabled = !isLocked;
            textBoxRewardNumber.Enabled = !isLocked;
            textBoxRewardConversion.Enabled = !isLocked;
            textBoxDefaultPrice.Enabled = !isLocked;
            textBoxCustomerCode.Focus();
            textBoxBusinessStyle.Enabled = !isLocked;
            dateTimePickerBirthday.Enabled = !isLocked;
            textBoxAge.Enabled = !isLocked;
            comboBoxGender.Enabled = !isLocked;
            textBoxEmailAddress.Enabled = !isLocked;
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            Controllers.MstCustomerController mstCustomerController = new Controllers.MstCustomerController();

            Entities.MstCustomerEntity newCustomerEntity = new Entities.MstCustomerEntity()
            {
                CustomerCode = textBoxCustomerCode.Text,
                Customer = textBoxCustomer.Text,
                Address = textBoxAddress.Text,
                ContactPerson = textBoxContactPerson.Text,
                ContactNumber = textBoxContactNumber.Text,
                CreditLimit = Convert.ToDecimal(textBoxCreditLimit.Text),
                TermId = Convert.ToInt32(comboBoxTerm.SelectedValue),
                TIN = textBoxTIN.Text,
                WithReward = checkBoxWithReward.Checked,
                RewardNumber = textBoxRewardNumber.Text,
                RewardConversion = Convert.ToDecimal(textBoxRewardConversion.Text),
                AvailableReward = Convert.ToDecimal(textBoxAvailableReward.Text),
                DefaultPriceDescription = textBoxDefaultPrice.Text,
                BusinessStyle = textBoxBusinessStyle.Text,
                Birthday = dateTimePickerBirthday.Text,
                Age = Convert.ToInt32(textBoxAge.Text),
                Gender = comboBoxGender.Text,
                EmailAddress = textBoxEmailAddress.Text,
            };

            String[] lockCustomer = mstCustomerController.LockCustomer(mstCustomerEntity.Id, newCustomerEntity);
            if (lockCustomer[1].Equals("0") == false)
            {
                UpdateComponents(true);
                mstCustomerListForm.UpdateCustomerListDataSource();
            }
            else
            {
                UpdateComponents(false);
                MessageBox.Show(lockCustomer[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Controllers.MstCustomerController mstCustomerController = new Controllers.MstCustomerController();

                String[] unlockCustomer = mstCustomerController.UnlockCustomer(mstCustomerEntity.Id);
                if (unlockCustomer[1].Equals("0") == false)
                {
                    UpdateComponents(false);
                    mstCustomerListForm.UpdateCustomerListDataSource();
                }
                else
                {
                    UpdateComponents(true);
                    MessageBox.Show(unlockCustomer[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            sysSoftwareForm.RemoveTabPage();
        }

        private void textBoxCreditLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxRewardConversion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxAvailableReward_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dateTimePickerBirthday_ValueChanged(object sender, EventArgs e)
        {
            ComputeAge();
        }

        //private void textBoxEmailAddress_Validating(object sender, CancelEventArgs e)
        //{
            //System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            ////txtmail is name/object of textbox
            //if (textBoxEmailAddress.Text.Length > 0)
            //{

            //    //rEMail is object of Regex class located in System.Text.RegularExpressions
            //    if (!rEMail.IsMatch(textBoxEmailAddress.Text))
            //    {
            //        MessageBox.Show("Email is not in correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        textBoxEmailAddress.SelectAll();
            //        e.Cancel = true;
            //    }
            //}
        //}
    }
}
