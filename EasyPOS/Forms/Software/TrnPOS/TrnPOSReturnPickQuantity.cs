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
    public partial class TrnPOSReturnPickQuantity : Form
    {
        public TrnPOSReturn trnPOSReturn;

        public TrnPOSReturnPickQuantity(TrnPOSReturn POSReturn, Decimal defaultQuantity)
        {
            InitializeComponent();

            textBoxReturnQuantity.Text = defaultQuantity.ToString("#,##0.00");
            trnPOSReturn = POSReturn;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Decimal quantity = Convert.ToDecimal(textBoxReturnQuantity.Text);
            trnPOSReturn.UpdateReturnQuantity(quantity);

            Close();
        }

        private void textBoxReturnQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxReturnQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Decimal quantity = Convert.ToDecimal(textBoxReturnQuantity.Text);
                trnPOSReturn.UpdateReturnQuantity(quantity);

                Close();
            }
        }

        private void textBoxReturnQuantity_Leave(object sender, EventArgs e)
        {
            textBoxReturnQuantity.Text = Convert.ToDecimal(textBoxReturnQuantity.Text).ToString("#,##0.00");
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

        private void pictureBoxNumpad_Click(object sender, EventArgs e)
        {
            SysKeyboard.SysNumberForm sysKeyboardNumpadForm = new SysKeyboard.SysNumberForm(null, null, null,this, "Quantity");
            sysKeyboardNumpadForm.ShowDialog();
        }
        public void getSysNumpadQuantity(Int32 number)
        {
            textBoxReturnQuantity.Text = Convert.ToString(number);
        }
    }
}
