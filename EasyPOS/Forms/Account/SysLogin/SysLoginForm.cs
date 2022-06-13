using EasyPOS.Forms.Software.TrnPOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Account.SysLogin
{
    public partial class SysLoginForm : Form
    {
        public TrnPOSBarcodeForm _trnPOSBarcodeForm;
        public TrnPOSBarcodeDetailForm _trnPOSBarcodeDetailForm;
        public TrnPOSTouchForm _trnPOSTouchForm;
        public TrnPOSTouchDetailForm _trnPOSTouchDetailForm;
        public TrnPOSTouchQuickServiceForm _trnPOSTouchQuickServiceForm;
        public TrnPOSQuickServiceDetailForm _trnPOSQuickServiceDetailForm;
        public Boolean _isOverride = false;
        public SysLoginForm(TrnPOSBarcodeForm trnPOSBarcodeForm, TrnPOSBarcodeDetailForm trnPOSBarcodeDetailForm, TrnPOSTouchForm trnPOSTouchForm, TrnPOSTouchDetailForm trnPOSTouchDetailForm,
                            TrnPOSTouchQuickServiceForm trnPOSTouchQuickServiceForm, TrnPOSQuickServiceDetailForm trnPOSQuickServiceDetailForm, Boolean isOverride)
        {
            InitializeComponent();

            _isOverride = isOverride;

            if(Modules.SysCurrentModule.GetCurrentSettings().DateLogin == false)
            {
                radioButtonLoginDate.Enabled = false;
            }
            else
            {
                radioButtonLoginDate.Enabled = true;
            }

            if (Modules.SysCurrentModule.GetCurrentSettings().SwipeLogin == false)
            {
                textBoxUserCardNumber.Visible = false;
            }
            else
            {
                textBoxUserCardNumber.Visible = true;
            }
            dateTimePickerLoginDate.Enabled = false;
            textBoxUsername.Focus();
            labelVersion.Text = "EasyPOS Version: " + Modules.SysCurrentModule.GetCurrentSettings().CurrentVersion;
            labelSupport.Text = "Support: Human Incubator Inc. " + Modules.SysCurrentModule.GetCurrentSettings().CurrentSupport;

            _trnPOSBarcodeForm = trnPOSBarcodeForm;
            _trnPOSBarcodeDetailForm = trnPOSBarcodeDetailForm;
            _trnPOSTouchForm = trnPOSTouchForm;
            _trnPOSTouchDetailForm = trnPOSTouchDetailForm;
            _trnPOSTouchQuickServiceForm = trnPOSTouchQuickServiceForm;
            _trnPOSQuickServiceDetailForm = trnPOSQuickServiceDetailForm;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (_trnPOSTouchForm != null || _trnPOSBarcodeForm != null)
            {
                if (Modules.SysCurrentModule.GetCurrentSettings().PromptLoginSales == false)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Hide();
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private bool CheckFormOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    return true;
                }
            }

            return false;
        }

        public void Login()
        {
            Controllers.SysLoginController sysLoginController = new Controllers.SysLoginController();
            String[] login = sysLoginController.Login(textBoxUserCardNumber.Text, textBoxUsername.Text, textBoxPassword.Text, dateTimePickerLoginDate.Value.ToShortDateString(), radioButtonLoginDate.Checked, _isOverride);
            if (login[1].Equals("0") == false)
            {
                if (_isOverride == true)
                {
                    if (_trnPOSTouchDetailForm != null)
                    {
                        _trnPOSTouchDetailForm.OverrideSales(Convert.ToInt32(login[1]), _isOverride);
                    }

                    if (_trnPOSBarcodeDetailForm != null)
                    {
                        _trnPOSBarcodeDetailForm.OverrideSales(Convert.ToInt32(login[1]),_isOverride);
                    }

                    if (_trnPOSQuickServiceDetailForm != null)
                    {
                        _trnPOSQuickServiceDetailForm.OverrideSales(Convert.ToInt32(login[1]), _isOverride);
                    }

                    Hide();
                }
                else
                {
                    if (Modules.SysCurrentModule.GetCurrentSettings().PromptLoginSales == false)
                    {
                        Software.SysSoftwareForm sysSoftwareForm = new Software.SysSoftwareForm();
                        sysSoftwareForm.Show();

                        Hide();
                    }
                    else
                    {
                        Hide();

                        if (CheckFormOpened("SysSoftwareForm") == false)
                        {
                            Software.SysSoftwareForm sysSoftwareForm = new Software.SysSoftwareForm();
                            sysSoftwareForm.Show();
                        }
                        else
                        {
                            if (_trnPOSTouchForm != null)
                            {
                                _trnPOSTouchForm.NewWalkInSales();
                            }

                            if (_trnPOSBarcodeForm != null)
                            {
                                _trnPOSBarcodeForm.newSales();
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(login[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBoxUserCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void SysLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isOverride == false)
            {
                if (_trnPOSTouchForm != null || _trnPOSTouchDetailForm != null || _trnPOSBarcodeForm != null || _trnPOSBarcodeDetailForm != null)
                {
                    if (Modules.SysCurrentModule.GetCurrentSettings().PromptLoginSales == false)
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            }

        }

        private void radioButtonSystemDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerLoginDate.Enabled = false;
        }

        private void radioButtonLoginDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerLoginDate.Enabled = true;
        }

        private void pictureBoxKeyboardUser_Click(object sender, EventArgs e)
        {
            Software.SysKeyboard.SysKeyboardForm sysKeyboardForm = new Software.SysKeyboard.SysKeyboardForm(null,this,null,null,null,null,null,null,null,"Username");
            sysKeyboardForm.ShowDialog();
        }

        private void pictureBoxKeyboardPassword_Click(object sender, EventArgs e)
        {
            Software.SysKeyboard.SysKeyboardForm sysKeyboardForm = new Software.SysKeyboard.SysKeyboardForm(null,this, null, null,null,null, null, null,null, "Password");
            sysKeyboardForm.ShowDialog();
        }
        public void getSysKeyboardUsername(String username)
        {
            textBoxUsername.Text = username;
        }
        public void getSysKeyboardPassword(String password)
        {
            textBoxPassword.Text = password;
        }
    }
}
