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
    public partial class TrnPOSLockSalesForm : Form
    {
        public TrnPOSBarcodeDetailForm trnPOSBarcodeDetailForm;
        public TrnPOSTouchDetailForm trnPOSTouchDetailForm;
        public TrnPOSQuickServiceDetailForm trnPOSQuickServiceDetailForm;
        public Entities.TrnSalesEntity trnSalesEntity;

        public String customerCode = "";
        public String customerName = "";

        public TrnPOSLockSalesForm(TrnPOSBarcodeDetailForm POSBarcodeDetailForm, TrnPOSTouchDetailForm POSTouchDetailForm, TrnPOSQuickServiceDetailForm POSQuickServiceDetailForm, Entities.TrnSalesEntity salesEntity)
        {
            InitializeComponent();

            trnPOSBarcodeDetailForm = POSBarcodeDetailForm;
            trnPOSTouchDetailForm = POSTouchDetailForm;
            trnPOSQuickServiceDetailForm = POSQuickServiceDetailForm;
            trnSalesEntity = salesEntity;

            GetTermList();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void GetTermList()
        {
            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            if (trnPOSSalesController.TenderSalesDropdownListTerm().Any())
            {
                comboBoxTenderSalesTerms.DataSource = trnPOSSalesController.TenderSalesDropdownListTerm();
                comboBoxTenderSalesTerms.ValueMember = "Id";
                comboBoxTenderSalesTerms.DisplayMember = "Term";

                GetCustomerList();
            }
        }

        public void GetCustomerList()
        {
            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            if (trnPOSSalesController.TenderSalesDropdownListCustomer().Any())
            {
                //List<Entities.MstCustomerEntity> newCustomerList = new List<Entities.MstCustomerEntity>();
                //newCustomerList.Add(new Entities.MstCustomerEntity
                //{
                //    Id = 0,
                //    Customer = "Input"
                //});

                //foreach (var obj in trnPOSSalesController.TenderSalesDropdownListCustomer())
                //{
                //    newCustomerList.Add(new Entities.MstCustomerEntity
                //    {
                //        Id = obj.Id,
                //        Customer = obj.Customer
                //    });
                //};

                //comboBoxTenderSalesCustomer.DataSource = newCustomerList;
                //comboBoxTenderSalesCustomer.ValueMember = "Id";
                //comboBoxTenderSalesCustomer.DisplayMember = "Customer";
                comboBoxTenderSalesCustomer.DataSource = trnPOSSalesController.TenderSalesDropdownListCustomer();
                comboBoxTenderSalesCustomer.ValueMember = "Id";
                comboBoxTenderSalesCustomer.DisplayMember = "Customer";

                GetUserList();
            }
        }

        public void GetUserList()
        {
            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            if (trnPOSSalesController.TenderSalesDropdownListUser().Any())
            {
                comboBoxTenderSalesUsers.DataSource = trnPOSSalesController.TenderSalesDropdownListUser();
                comboBoxTenderSalesUsers.ValueMember = "Id";
                comboBoxTenderSalesUsers.DisplayMember = "FullName";

                var currentUserId = Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId;
                comboBoxTenderSalesUsers.SelectedValue = Convert.ToInt32(currentUserId);
            }
            Int32 pax = trnPOSSalesController.getPax(trnSalesEntity.Id);

            textBoxCustomerCode.Text = trnSalesEntity.CustomerCode;
            comboBoxTenderSalesCustomer.SelectedValue = trnSalesEntity.CustomerId;
            comboBoxTenderSalesTerms.SelectedValue = trnSalesEntity.TermId;
            comboBoxTenderSalesUsers.SelectedValue = trnSalesEntity.SalesAgent;
            textBoxTenderSalesRemarks.Text = trnSalesEntity.Remarks;
            textBoxPax.Text = pax.ToString();
        }

        private void comboBoxTenderSalesCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTenderSalesCustomer.SelectedItem == null)
            {
                return;
            }

            var selectedItemCustomer = (Entities.MstCustomerEntity)comboBoxTenderSalesCustomer.SelectedItem;
            if (selectedItemCustomer != null)
            {
                customerCode = selectedItemCustomer.CustomerCode;
                customerName = selectedItemCustomer.Customer;
                textBoxTenderSalesRewardAvailable.Text = selectedItemCustomer.AvailableReward.ToString("#,##0.00");
                comboBoxTenderSalesTerms.SelectedValue = selectedItemCustomer.TermId;
                textBoxCustomerCode2.Text = selectedItemCustomer.CustomerCode;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (trnPOSTouchDetailForm != null || trnPOSQuickServiceDetailForm != null)
            {
                if (Modules.SysCurrentModule.GetCurrentSettings().ShowServiceCharge == true)
                {
                    DialogResult tenderPrinterReadyDialogResult = MessageBox.Show("Add Service Charge?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tenderPrinterReadyDialogResult == DialogResult.Yes)
                    {
                        Controllers.TrnSalesController trnSalesController = new Controllers.TrnSalesController();
                        Decimal tempoSalesAmount = trnSalesController.getSalesAmount(trnSalesEntity.Id);
                        Decimal ServiceCharge = tempoSalesAmount * 0.10m;
                        trnSalesController.updateServiceCharge(trnSalesEntity.Id, ServiceCharge);
                        Controllers.TrnSalesLineController trnSaleslineController = new Controllers.TrnSalesLineController();
                        trnSaleslineController.UpdateSalesLineServiceCharge(trnSalesEntity.Id);

                        Entities.TrnSalesEntity newSalesEntity = new Entities.TrnSalesEntity()
                        {
                            CustomerId = Convert.ToInt32(comboBoxTenderSalesCustomer.SelectedValue),
                            TermId = Convert.ToInt32(comboBoxTenderSalesTerms.SelectedValue),
                            Remarks = textBoxTenderSalesRemarks.Text,
                            SalesAgent = Convert.ToInt32(comboBoxTenderSalesUsers.SelectedValue),
                            Amount = trnSalesEntity.Amount + ServiceCharge,
                            Pax = Convert.ToInt32(textBoxPax.Text)
                        };
                        Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
                        String[] updateSales = trnPOSSalesController.LockSales(trnSalesEntity.Id, newSalesEntity);
                        if (updateSales[1].Equals("0") == false)
                        {
                            if (trnPOSBarcodeDetailForm != null)
                            {
                                trnPOSBarcodeDetailForm.trnSalesEntity.CustomerCode = customerCode;
                                trnPOSBarcodeDetailForm.trnSalesEntity.Customer = customerName;
                                trnPOSBarcodeDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;

                                trnPOSBarcodeDetailForm.GetSalesDetail();
                                trnPOSBarcodeDetailForm.LockComponents(true);

                                trnPOSBarcodeDetailForm.trnSalesEntity.CustomerId = newSalesEntity.CustomerId;
                                trnPOSBarcodeDetailForm.trnSalesEntity.TermId = newSalesEntity.TermId;
                                trnPOSBarcodeDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;
                                trnPOSBarcodeDetailForm.trnSalesEntity.SalesAgent = newSalesEntity.SalesAgent;
                            }

                            if (trnPOSTouchDetailForm != null)
                            {
                                trnPOSTouchDetailForm.trnSalesEntity.CustomerCode = customerCode;
                                trnPOSTouchDetailForm.trnSalesEntity.Customer = customerName;
                                trnPOSTouchDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;
                                trnPOSTouchDetailForm.trnSalesEntity.Amount = newSalesEntity.Amount;

                                trnPOSTouchDetailForm.GetSalesDetail();
                                trnPOSTouchDetailForm.LockComponents(true);
                                trnPOSTouchDetailForm.GetSalesLineList();

                                trnPOSTouchDetailForm.trnSalesEntity.CustomerId = newSalesEntity.CustomerId;
                                trnPOSTouchDetailForm.trnSalesEntity.TermId = newSalesEntity.TermId;
                                trnPOSTouchDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;
                                trnPOSTouchDetailForm.trnSalesEntity.SalesAgent = newSalesEntity.SalesAgent;
                            }

                            if (trnPOSQuickServiceDetailForm != null)
                            {
                                trnPOSQuickServiceDetailForm.trnSalesEntity.CustomerCode = customerCode;
                                trnPOSQuickServiceDetailForm.trnSalesEntity.Customer = customerName;
                                trnPOSQuickServiceDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;
                                trnPOSQuickServiceDetailForm.trnSalesEntity.Amount = newSalesEntity.Amount;

                                trnPOSQuickServiceDetailForm.GetSalesDetail();
                                trnPOSQuickServiceDetailForm.LockComponents(true);

                                trnPOSQuickServiceDetailForm.trnSalesEntity.CustomerId = newSalesEntity.CustomerId;
                                trnPOSQuickServiceDetailForm.trnSalesEntity.TermId = newSalesEntity.TermId;
                                trnPOSQuickServiceDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;
                                trnPOSQuickServiceDetailForm.trnSalesEntity.SalesAgent = newSalesEntity.SalesAgent;
                            }

                            Close();
                        }
                        else
                        {
                            MessageBox.Show(updateSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        Controllers.TrnSalesController trnSalesController = new Controllers.TrnSalesController();
                        Decimal SCAmount = trnSalesController.getServiceCharge(trnSalesEntity.Id);
                        Entities.TrnSalesEntity newSalesEntity = new Entities.TrnSalesEntity()
                        {
                            CustomerId = Convert.ToInt32(comboBoxTenderSalesCustomer.SelectedValue),
                            TermId = Convert.ToInt32(comboBoxTenderSalesTerms.SelectedValue),
                            Remarks = textBoxTenderSalesRemarks.Text,
                            SalesAgent = Convert.ToInt32(comboBoxTenderSalesUsers.SelectedValue),
                            Amount = trnSalesEntity.Amount - SCAmount,
                            Pax = Convert.ToInt32(textBoxPax.Text)
                        };

                        Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
                        String[] updateSales = trnPOSSalesController.LockSales(trnSalesEntity.Id, newSalesEntity);
                        if (updateSales[1].Equals("0") == false)
                        {
                            if (trnPOSBarcodeDetailForm != null)
                            {
                                trnPOSBarcodeDetailForm.trnSalesEntity.CustomerCode = customerCode;
                                trnPOSBarcodeDetailForm.trnSalesEntity.Customer = customerName;
                                trnPOSBarcodeDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;

                                trnPOSBarcodeDetailForm.GetSalesDetail();
                                trnPOSBarcodeDetailForm.LockComponents(true);

                                trnPOSBarcodeDetailForm.trnSalesEntity.CustomerId = newSalesEntity.CustomerId;
                                trnPOSBarcodeDetailForm.trnSalesEntity.TermId = newSalesEntity.TermId;
                                trnPOSBarcodeDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;
                                trnPOSBarcodeDetailForm.trnSalesEntity.SalesAgent = newSalesEntity.SalesAgent;
                            }

                            if (trnPOSTouchDetailForm != null)
                            {
                                trnPOSTouchDetailForm.trnSalesEntity.CustomerCode = customerCode;
                                trnPOSTouchDetailForm.trnSalesEntity.Customer = customerName;
                                trnPOSTouchDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;
                                trnPOSTouchDetailForm.trnSalesEntity.Amount = newSalesEntity.Amount;

                                trnPOSTouchDetailForm.GetSalesDetail();
                                trnPOSTouchDetailForm.LockComponents(true);

                                trnPOSTouchDetailForm.trnSalesEntity.CustomerId = newSalesEntity.CustomerId;
                                trnPOSTouchDetailForm.trnSalesEntity.TermId = newSalesEntity.TermId;
                                trnPOSTouchDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;
                                trnPOSTouchDetailForm.trnSalesEntity.SalesAgent = newSalesEntity.SalesAgent;
                            }

                            if (trnPOSQuickServiceDetailForm != null)
                            {
                                trnPOSQuickServiceDetailForm.trnSalesEntity.CustomerCode = customerCode;
                                trnPOSQuickServiceDetailForm.trnSalesEntity.Customer = customerName;
                                trnPOSQuickServiceDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;
                                trnPOSQuickServiceDetailForm.trnSalesEntity.Amount = newSalesEntity.Amount;

                                trnPOSQuickServiceDetailForm.GetSalesDetail();
                                trnPOSQuickServiceDetailForm.LockComponents(true);

                                trnPOSQuickServiceDetailForm.trnSalesEntity.CustomerId = newSalesEntity.CustomerId;
                                trnPOSQuickServiceDetailForm.trnSalesEntity.TermId = newSalesEntity.TermId;
                                trnPOSQuickServiceDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;
                                trnPOSQuickServiceDetailForm.trnSalesEntity.SalesAgent = newSalesEntity.SalesAgent;
                            }
                            Decimal ServiceCharge = 0;
                            trnPOSSalesController.updateServiceCharge(trnSalesEntity.Id, ServiceCharge);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(updateSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }
                else
                {
                    Entities.TrnSalesEntity newSalesEntity = new Entities.TrnSalesEntity()
                    {
                        CustomerId = Convert.ToInt32(comboBoxTenderSalesCustomer.SelectedValue),
                        TermId = Convert.ToInt32(comboBoxTenderSalesTerms.SelectedValue),
                        Remarks = textBoxTenderSalesRemarks.Text,
                        SalesAgent = Convert.ToInt32(comboBoxTenderSalesUsers.SelectedValue),
                        Amount = trnSalesEntity.Amount,
                        Pax = Convert.ToInt32(textBoxPax.Text)
                    };
                    Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
                    String[] updateSales = trnPOSSalesController.LockSales(trnSalesEntity.Id, newSalesEntity);
                    if (updateSales[1].Equals("0") == false)
                    {
                        if (trnPOSBarcodeDetailForm != null)
                        {
                            trnPOSBarcodeDetailForm.trnSalesEntity.CustomerCode = customerCode;
                            trnPOSBarcodeDetailForm.trnSalesEntity.Customer = customerName;
                            trnPOSBarcodeDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;

                            trnPOSBarcodeDetailForm.GetSalesDetail();
                            trnPOSBarcodeDetailForm.LockComponents(true);

                            trnPOSBarcodeDetailForm.trnSalesEntity.CustomerId = newSalesEntity.CustomerId;
                            trnPOSBarcodeDetailForm.trnSalesEntity.TermId = newSalesEntity.TermId;
                            trnPOSBarcodeDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;
                            trnPOSBarcodeDetailForm.trnSalesEntity.SalesAgent = newSalesEntity.SalesAgent;
                        }

                        if (trnPOSTouchDetailForm != null)
                        {
                            trnPOSTouchDetailForm.trnSalesEntity.CustomerCode = customerCode;
                            trnPOSTouchDetailForm.trnSalesEntity.Customer = customerName;
                            trnPOSTouchDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;

                            trnPOSTouchDetailForm.GetSalesDetail();
                            trnPOSTouchDetailForm.LockComponents(true);

                            trnPOSTouchDetailForm.trnSalesEntity.CustomerId = newSalesEntity.CustomerId;
                            trnPOSTouchDetailForm.trnSalesEntity.TermId = newSalesEntity.TermId;
                            trnPOSTouchDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;
                            trnPOSTouchDetailForm.trnSalesEntity.SalesAgent = newSalesEntity.SalesAgent;
                        }

                        if (trnPOSQuickServiceDetailForm != null)
                        {
                            trnPOSQuickServiceDetailForm.trnSalesEntity.CustomerCode = customerCode;
                            trnPOSQuickServiceDetailForm.trnSalesEntity.Customer = customerName;
                            trnPOSQuickServiceDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;

                            trnPOSQuickServiceDetailForm.GetSalesDetail();
                            trnPOSQuickServiceDetailForm.LockComponents(true);

                            trnPOSQuickServiceDetailForm.trnSalesEntity.CustomerId = newSalesEntity.CustomerId;
                            trnPOSQuickServiceDetailForm.trnSalesEntity.TermId = newSalesEntity.TermId;
                            trnPOSQuickServiceDetailForm.trnSalesEntity.Remarks = newSalesEntity.Remarks;
                            trnPOSQuickServiceDetailForm.trnSalesEntity.SalesAgent = newSalesEntity.SalesAgent;
                        }

                        Close();
                    }
                    else
                    {
                        MessageBox.Show(updateSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBoxCustomerCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<Entities.MstCustomerEntity> customers = (List<Entities.MstCustomerEntity>)comboBoxTenderSalesCustomer.DataSource;
                var customer = from d in customers
                               where d.CustomerCode == textBoxCustomerCode.Text
                               select d;

                if (customer.Any())
                {
                    comboBoxTenderSalesCustomer.SelectedValue = customer.FirstOrDefault().Id;
                }
                else
                {
                    MessageBox.Show("Invalid customer code.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F2:
                    {
                        if (buttonSave.Enabled == true)
                        {
                            buttonSave.PerformClick();
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

        private void comboBoxTenderSalesCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String inputString = comboBoxTenderSalesCustomer.Text;
                comboBoxTenderSalesCustomer.SelectedIndex = comboBoxTenderSalesCustomer.FindString(inputString);
            }
        }

        private void pictureBoxKeyboardRemarks_Click(object sender, EventArgs e)
        {
            SysKeyboard.SysKeyboardForm sysKeyboardForm = new SysKeyboard.SysKeyboardForm(null, null, null, null, this, null, null, null, null, "Remarks");
            sysKeyboardForm.ShowDialog();
        }

        private void pictureBoxNumpad_Click(object sender, EventArgs e)
        {
            SysKeyboard.SysNumberForm sysKeyboardNumpadForm = new SysKeyboard.SysNumberForm(null, this, null, null, "Pax");
            sysKeyboardNumpadForm.ShowDialog();
        }
        public void getSysKeyboardRemarks(String Remarks)
        {
            textBoxTenderSalesRemarks.Text = Remarks;
        }
        public void getSysNumpadPax(Int32 pax)
        {
            textBoxPax.Text = Convert.ToString(pax);
        }
        public void getKeyboardCustomerCode(String customerCode)
        {
            textBoxCustomerCode.Text = customerCode;
        }

        private void pictureBoxCustomerCode_Click(object sender, EventArgs e)
        {
            SysKeyboard.SysKeyboardForm sysKeyboardForm = new SysKeyboard.SysKeyboardForm(null, null, null, null, this, null, null, null, null, "CustomerCode");
            sysKeyboardForm.ShowDialog();
        }
    }
}