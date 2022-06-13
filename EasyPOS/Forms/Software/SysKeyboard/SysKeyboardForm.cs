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
    public partial class SysKeyboardForm : Form
    {
        public TrnPOS.TrnPOSSalesItemDetailForm trnPOSSalesItemDetailForm;
        public Account.SysLogin.SysLoginForm sysLoginForm;
        public TrnPOS.TrnPOSTouchQuickServiceForm trnPOSTouchQuickServiceForm;
        public TrnPOS.TrnPOSReturn trnPOSReturn;
        public TrnPOS.TrnPOSLockSalesForm trnPOSLockSalesForm;
        public TrnPOS.TrnPOSDiscountForm TrnPOSDiscount;
        public TrnPOS.TrnPOSTouchForm trnPOSTouch;
        public TrnPOS.TrnPOSTouchDetailForm trnPOSTouchDetailForm;
        public TrnPOS.TrnPOSQuickServiceDetailForm trnPOSQuickServiceDetailForm;
        public String Text;
        //public String Password;
        //public String OrderNumber;
        //public String ReturnOR;
        //public String ReturnSalesNo;
        //public String Remarks;
        public SysKeyboardForm(TrnPOS.TrnPOSSalesItemDetailForm posSalesItemDetailForm, Account.SysLogin.SysLoginForm sysLogInForm,TrnPOS.TrnPOSTouchQuickServiceForm POSTouchQuickServiceForm, TrnPOS.TrnPOSReturn POSReturn ,
                                TrnPOS.TrnPOSLockSalesForm POSLockSalesForm, TrnPOS.TrnPOSDiscountForm POSDiscountForm, TrnPOS.TrnPOSTouchForm POSTouchForm, TrnPOS.TrnPOSTouchDetailForm POSTouchDetailForm,
                                TrnPOS.TrnPOSQuickServiceDetailForm POSQuickServiceDetailForm,String text)
        {
            InitializeComponent();
            trnPOSSalesItemDetailForm = posSalesItemDetailForm;
            sysLoginForm = sysLogInForm;
            trnPOSTouchQuickServiceForm = POSTouchQuickServiceForm;
            trnPOSReturn = POSReturn;
            trnPOSLockSalesForm = POSLockSalesForm;
            TrnPOSDiscount = POSDiscountForm;
            trnPOSTouch = POSTouchForm;
            trnPOSTouchDetailForm = POSTouchDetailForm;
            trnPOSQuickServiceDetailForm = POSQuickServiceDetailForm;
            Text = text;
            //Password = password;
            //ReturnOR = returnOR;
            //ReturnSalesNo = returnSalesNo;
            //Remarks = remarks;
        } 
        private void buttonLowerCase_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Lower Case")
            {
                buttonLowerCase.Text = "Upper Case";
                buttonQ.Text = "q";
                buttonW.Text = "w";
                buttonE.Text = "e";
                buttonR.Text = "r";
                buttonT.Text = "t";
                buttonY.Text = "y";
                buttonU.Text = "u";
                buttonI.Text = "i";
                buttonO.Text = "o";
                buttonP.Text = "p";
                buttonA.Text = "a";
                buttonS.Text = "s";
                buttonD.Text = "d";
                buttonF.Text = "f";
                buttonG.Text = "g";
                buttonH.Text = "h";
                buttonJ.Text = "j";
                buttonK.Text = "k";
                buttonL.Text = "l";
                buttonZ.Text = "z";
                buttonX.Text = "x";
                buttonC.Text = "c";
                buttonV.Text = "v";
                buttonB.Text = "b";
                buttonN.Text = "n";
                buttonM.Text = "m";
            }
            else
            {
                buttonLowerCase.Text = "Lower Case";
                buttonQ.Text = "Q";
                buttonW.Text = "W";
                buttonE.Text = "E";
                buttonR.Text = "R";
                buttonT.Text = "T";
                buttonY.Text = "Y";
                buttonU.Text = "U";
                buttonI.Text = "I";
                buttonO.Text = "O";
                buttonP.Text = "P";
                buttonA.Text = "A";
                buttonS.Text = "S";
                buttonD.Text = "D";
                buttonF.Text = "F";
                buttonG.Text = "G";
                buttonH.Text = "H";
                buttonJ.Text = "J";
                buttonK.Text = "K";
                buttonL.Text = "L";
                buttonZ.Text = "Z";
                buttonX.Text = "X";
                buttonC.Text = "C";
                buttonV.Text = "V";
                buttonB.Text = "B";
                buttonN.Text = "N";
                buttonM.Text = "M";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxArea.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxArea.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxArea.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxArea.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxArea.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxArea.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxArea.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxArea.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxArea.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxArea.Text += "0";
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (textBoxArea.Text.Length > 0)
            {
                textBoxArea.Text = textBoxArea.Text.Remove(textBoxArea.Text.Length - 1);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxArea.Text = "";
        }

        private void buttonSpace_Click(object sender, EventArgs e)
        {
            textBoxArea.Text += " ";

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            String text = textBoxArea.Text;
            if(trnPOSSalesItemDetailForm != null && Text == "Remarks")
            {
                trnPOSSalesItemDetailForm.getSysKeyboardRemarks(text);
            }
            if (Text == "Username")
            {
                sysLoginForm.getSysKeyboardUsername(text);
            }
            else if (Text == "Password")
            {
                sysLoginForm.getSysKeyboardPassword(text);
            }
            else if (trnPOSTouchQuickServiceForm != null && Text == "OrderNumber")
            {
                trnPOSTouchQuickServiceForm.getSysKeyboardOrderNumber(text);
                trnPOSTouchQuickServiceForm.UpdateSalesListGridDataSource();
            }
            else if (trnPOSReturn != null && Text == "OrderNumber")
            {
                trnPOSReturn.getSysKkeyboardOrderNumber(text);
                trnPOSReturn.UpdateReturnDataSource();
            }
            else if (trnPOSLockSalesForm != null && Text == "Remarks")
            {
                trnPOSLockSalesForm.getSysKeyboardRemarks(text);
            }
            else if (trnPOSLockSalesForm != null && Text == "CustomerCode")
            {
                trnPOSLockSalesForm.getKeyboardCustomerCode(text);
            }
            else if (TrnPOSDiscount != null && Text == "Id")
            {
                TrnPOSDiscount.getSysKeybordId(text);
            }
            else if (TrnPOSDiscount != null && Text == "Name")
            {
                TrnPOSDiscount.getSysKeybordName(text);
            }
            else if (trnPOSTouch != null && Text == "OrderNumber")
            {
                trnPOSTouch.getSysKeyboardOR(text);
                trnPOSTouch.UpdateSalesListGridDataSource();
            }
            else if (trnPOSTouchDetailForm != null && Text == "Barcode")
            {
                trnPOSTouchDetailForm.getSysKkeyboardBarcode(text);
                trnPOSTouchDetailForm.updateGetBarcode();
            }
            else
            {

            }
            Close();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "q";
            }
            else
            {
                textBoxArea.Text += "Q";
            }
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "w";
            }
            else
            {
                textBoxArea.Text += "W";
            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "e";
            }
            else
            {
                textBoxArea.Text += "E";
            }
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "r";
            }
            else
            {
                textBoxArea.Text += "R";
            }
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "t";
            }
            else
            {
                textBoxArea.Text += "T";
            }
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "y";
            }
            else
            {
                textBoxArea.Text += "Y";
            }
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "u";
            }
            else
            {
                textBoxArea.Text += "U";
            }
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "i";
            }
            else
            {
                textBoxArea.Text += "I";
            }
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "o";
            }
            else
            {
                textBoxArea.Text += "O";
            }
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "p";
            }
            else
            {
                textBoxArea.Text += "P";
            }
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {

            textBoxArea.Text += ",";
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "a";
            }
            else
            {
                textBoxArea.Text += "A";
            }
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "s";
            }
            else
            {
                textBoxArea.Text += "S";
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "d";
            }
            else
            {
                textBoxArea.Text += "D";
            }
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "f";
            }
            else
            {
                textBoxArea.Text += "F";
            }
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "g";
            }
            else
            {
                textBoxArea.Text += "G";
            }
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "h";
            }
            else
            {
                textBoxArea.Text += "H";
            }
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "j";
            }
            else
            {
                textBoxArea.Text += "J";
            }
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "k";
            }
            else
            {
                textBoxArea.Text += "K";
            }
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "l";
            }
            else
            {
                textBoxArea.Text += "L";
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBoxArea.Text += ".";
        }

        private void buttonDash_Click(object sender, EventArgs e)
        {
            textBoxArea.Text += "-";
        }

        private void buttonSlash_Click(object sender, EventArgs e)
        {
            textBoxArea.Text += "/";
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "z";
            }
            else
            {
                textBoxArea.Text += "Z";
            }
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "x";
            }
            else
            {
                textBoxArea.Text += "X";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "c";
            }
            else
            {
                textBoxArea.Text += "C";
            }
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "v";
            }
            else
            {
                textBoxArea.Text += "V";
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "b";
            }
            else
            {
                textBoxArea.Text += "B";
            }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "n";
            }
            else
            {
                textBoxArea.Text += "N";
            }
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            if (buttonLowerCase.Text == "Upper Case")
            {
                textBoxArea.Text += "m";
            }
            else
            {
                textBoxArea.Text += "M";
            }
        }
    }
}
