using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.SysKeyboard
{
    public partial class SysNumberForm : Form
    {
        public TrnPOS.TrnPOSSalesItemDetailForm trnPOSSalesItemDetailForm;
        public TrnPOS.TrnPOSLockSalesForm trnPOSSalesItemLockSalesForm;
        public TrnPOS.TrnPOSDiscountForm trnPOSDiscountForm;
        public TrnPOS.TrnPOSReturnPickQuantity trnPOSReturnPickQuantity;

        public String Text;
        //public String Price;
        //public String DiscountRate;
        //public String DiscountAmount;
        //public String Pax;
        public SysNumberForm(TrnPOS.TrnPOSSalesItemDetailForm POSSalesItemDetailForm, TrnPOS.TrnPOSLockSalesForm POSLockSalesForm ,TrnPOS.TrnPOSDiscountForm POSDiscountForm, TrnPOS.TrnPOSReturnPickQuantity POSReturnPickQuantity,String text)
        {
            InitializeComponent();
            trnPOSSalesItemDetailForm = POSSalesItemDetailForm;
            trnPOSSalesItemLockSalesForm = POSLockSalesForm;
            trnPOSDiscountForm = POSDiscountForm;
            trnPOSReturnPickQuantity = POSReturnPickQuantity;
            Text = text;
            //Price = price;
            //DiscountRate = discountRate;
            //DiscountAmount = discountAmount;
            //Pax = pax;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.Text.Length <= 13)
            {
                textBoxNumber.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.Text.Length <= 13)
            {
                textBoxNumber.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.Text.Length <= 13)
            {
                textBoxNumber.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.Text.Length <= 13)
            {
                textBoxNumber.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.Text.Length <= 13)
            {
                textBoxNumber.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.Text.Length <= 13)
            {
                textBoxNumber.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.Text.Length <= 13)
            {
                textBoxNumber.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.Text.Length <= 13)
            {
                textBoxNumber.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.Text.Length <= 13)
            {
                textBoxNumber.Text += "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.Text.Length <= 13)
            {
                textBoxNumber.Text += "0";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            textBoxNumber.Text = "";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Int32 number = Convert.ToInt32(textBoxNumber.Text);
            if (trnPOSSalesItemDetailForm != null && Text == "Quantity")
            {
                trnPOSSalesItemDetailForm.getSysNumpadQuantity(number);
            }
            else if (trnPOSSalesItemDetailForm != null && Text == "Price")
            {
                trnPOSSalesItemDetailForm.getSysNumpadPrice(number);
            }
            else if (trnPOSSalesItemDetailForm != null && Text == "DiscountRate")
            {
                trnPOSSalesItemDetailForm.getSysNumpadDiscountRate(number);
            }
            else if (trnPOSSalesItemDetailForm != null && Text == "DiscountAmount")
            {
                trnPOSSalesItemDetailForm.getSysNumpadDiscount(number);
            }
            else if (trnPOSSalesItemLockSalesForm != null && Text == "Pax")
            {
                trnPOSSalesItemLockSalesForm.getSysNumpadPax(number);
            }
            else if (trnPOSDiscountForm != null && Text == "DiscountRate")
            {
                trnPOSDiscountForm.getSysNumpadRate(number);
            }
            else if (trnPOSDiscountForm != null && Text == "DiscountAmount")
            {
                trnPOSDiscountForm.getSysNumpadAmount(number);
            }
            else if (trnPOSDiscountForm != null && Text == "Age")
            {
                trnPOSDiscountForm.getSysNumpadAge(number);
            }
            else if (trnPOSDiscountForm != null && Text == "Pax")
            {
                trnPOSDiscountForm.getSysNumpadPax(number);
            }
            else if (trnPOSDiscountForm != null && Text == "DiscountedPax")
            {
                trnPOSDiscountForm.getSysNumpadDPax(number);
            }
            else if (trnPOSReturnPickQuantity != null && Text == "Quantity")
            {
                trnPOSReturnPickQuantity.getSysNumpadQuantity(number);
            }
            else
            {

            }
            Close();
        }
    }
}
