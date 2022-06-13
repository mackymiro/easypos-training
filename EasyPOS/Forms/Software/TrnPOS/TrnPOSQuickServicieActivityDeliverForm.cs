using System;
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
    public partial class TrnPOSQuickServicieActivityDeliverForm : Form
    {
        TrnPOSTouchQuickServiceForm TrnPOSTouchQuickServiceForm;
        TrnPOSQuickServiceActivityForm trnPOSQuickServiceActivityForm;
        public Int32 salesId;
        public TrnPOSQuickServicieActivityDeliverForm(TrnPOSTouchQuickServiceForm POSTouchQuickServiceForm, TrnPOSQuickServiceActivityForm POSQuickServiceActivityForm, Int32 currentSalesId, String remarks)
        {
            InitializeComponent();
            TrnPOSTouchQuickServiceForm = POSTouchQuickServiceForm;
            trnPOSQuickServiceActivityForm = POSQuickServiceActivityForm;
            salesId = currentSalesId;
            textBoxRemarks.Text = remarks;
            ListDrivers();
        }

        public void ListDrivers()
        {
            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            if (trnPOSSalesController.DropdownListDriver().Any())
            {
                comboBoxDeliveredBy.DataSource = trnPOSSalesController.DropdownListDriver();
                comboBoxDeliveredBy.ValueMember = "Id";
                comboBoxDeliveredBy.DisplayMember = "FullName";
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            AssignDeliveryMan();
        }

        public void AssignDeliveryMan()
        {
            Int32 driverId = Convert.ToInt32(comboBoxDeliveredBy.SelectedValue);
            String driverName = comboBoxDeliveredBy.Text;

            DialogResult assignDriverDialogResult = MessageBox.Show("Assign Driver? ", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (assignDriverDialogResult == DialogResult.Yes)
            {
                Controllers.TrnSalesController trnSalesController = new Controllers.TrnSalesController();

                String[] assignDriver = trnSalesController.AssignDriverSales(salesId, driverName, driverId.ToString());
                if (assignDriver[1].Equals("0") == false)
                {
                    MessageBox.Show("Assign Successful.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TrnPOSTouchQuickServiceForm.UpdateSalesListGridDataSource();
                    trnPOSQuickServiceActivityForm.Close();

                    Close();
                }
                else
                {
                    MessageBox.Show(assignDriver[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxDeliveredBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AssignDeliveryMan();
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
                            Close();
                        }

                        break;
                    }
                case Keys.Escape:
                    {
                        Close();
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
