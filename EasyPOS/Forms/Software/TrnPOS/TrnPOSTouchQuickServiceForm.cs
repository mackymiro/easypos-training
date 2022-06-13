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
    public partial class TrnPOSTouchQuickServiceForm : Form
    {
        public SysSoftwareForm sysSoftwareForm;
        private Modules.SysUserRightsModule sysUserRights;

        public List<Entities.DgvTrnSalesListEntity> salesList;

        public BindingSource dataOpenSalesListSource = new BindingSource();
        public BindingSource dataBilledOutSalesListSource = new BindingSource();
        public BindingSource dataCollectedSalesListSource = new BindingSource();

        public TrnPOSQuickServiceActivityForm trnPOSQuickServiceActivityForm;

        public TrnPOSTouchQuickServiceForm(SysSoftwareForm softwareForm)
        {
            InitializeComponent();
            String currentDate = DateTime.Today.ToShortDateString() + "\t\t";
            if (Modules.SysCurrentModule.GetCurrentSettings().IsLoginDate == true)
            {
                currentDate = Modules.SysCurrentModule.GetCurrentSettings().CurrentDate + "\t\t";
            }

            dateTimePickerSalesDate.Value = Convert.ToDateTime(currentDate);

            sysUserRights = new Modules.SysUserRightsModule("TrnSales");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (sysUserRights.GetUserRights().CanAdd == false)
                {
                    buttonWalkIn.Enabled = false;
                }

                GetTerminalList();
            }

            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            textBoxLastChange.Text = trnPOSSalesController.GetLastChange(Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().TerminalId)).ToString("#,##0.00");

            sysSoftwareForm = softwareForm;

        }
        public void NewSales(String tableCode, Int32 customerId)
        {
            try
            {
                Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
                Int32 salesId = trnPOSSalesController.getTableSalesId(tableCode, dateTimePickerSalesDate.Value.Date);

                if (salesId != 0)
                {
                    Entities.TrnSalesEntity salesEntity = trnPOSSalesController.DetailSales(salesId);

                    trnPOSQuickServiceActivityForm = new TrnPOSQuickServiceActivityForm(sysSoftwareForm, this, salesEntity);
                    trnPOSQuickServiceActivityForm.ShowDialog();
                }
                else
                {
                    String[] addSales = trnPOSSalesController.AddSales(tableCode, customerId);

                    if (addSales[1].Equals("0") == false)
                    {
                        sysSoftwareForm.AddTabPagePOSQuickServiceSalesDetail(this, trnPOSSalesController.DetailSales(Convert.ToInt32(addSales[1])));
                        UpdateSalesListGridDataSource();
                    }
                    else
                    {
                        MessageBox.Show(addSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NewWalkInSales()
        {
            Int32 customerId = Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().WalkinCustomerId);

            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            String[] addSales = trnPOSSalesController.AddSales("Walk-in", customerId);
            if (addSales[1].Equals("0") == false)
            {
                sysSoftwareForm.AddTabPagePOSQuickServiceSalesDetail(this, trnPOSSalesController.DetailSales(Convert.ToInt32(addSales[1])));
                UpdateSalesListGridDataSource();
            }
            else
            {
                MessageBox.Show(addSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetTerminalList()
        {
            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            if (trnPOSSalesController.DropdownListTerminal().Any())
            {
                comboBoxTerminal.DataSource = trnPOSSalesController.DropdownListTerminal();
                comboBoxTerminal.ValueMember = "Id";
                comboBoxTerminal.DisplayMember = "Terminal";

                comboBoxTerminal.SelectedValue = Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().TerminalId);

                UpdateSalesListGridDataSource();
                CreateSalesListDataGrid();
            }
        }
        public void UpdateSalesListGridDataSource()
        {
            DateTime salesDate = dateTimePickerSalesDate.Value.Date;
            Int32 terminalId = Convert.ToInt32(comboBoxTerminal.SelectedValue);
            String filter = textBoxFilter.Text;

            GetSalesListDataAsync(salesDate, terminalId, filter);

            Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
            textBoxLastChange.Text = trnPOSSalesController.GetLastChange(Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().TerminalId)).ToString("#,##0.00");
        }
        public async void GetSalesListDataAsync(DateTime salesDate, Int32 terminalId, String filter)
        {
            var salesList = await GetSalesListDataTask(salesDate, terminalId, filter);
            if (salesList.Any())
            {
                if (tabControlSales.SelectedTab == tabPageOpen)
                {
                    buttonTenderAll.Enabled = true;

                    var openSales = from d in salesList where d.ColumnIsLocked == false select d;
                    if (openSales.Any())
                    {
                        dataOpenSalesListSource.DataSource = openSales;
                        textBoxTotalAmount.Text = openSales.Sum(d => Convert.ToDecimal(d.ColumnAmount)).ToString("#,##0.00");
                    }
                    else
                    {
                        dataOpenSalesListSource.Clear();
                        textBoxTotalAmount.Text = (0).ToString("#,##0.00");
                    }
                }

                if (tabControlSales.SelectedTab == tabPageBilledOut)
                {
                    buttonTenderAll.Enabled = true;

                    var billedOutSales = from d in salesList where d.ColumnIsLocked == true && d.ColumnIsTendered == false select d;
                    if (billedOutSales.Any())
                    {
                        dataBilledOutSalesListSource.DataSource = billedOutSales;
                        textBoxTotalAmount.Text = billedOutSales.Sum(d => Convert.ToDecimal(d.ColumnAmount)).ToString("#,##0.00");
                    }
                    else
                    {
                        dataBilledOutSalesListSource.Clear();
                        textBoxTotalAmount.Text = (0).ToString("#,##0.00");
                    }
                }

                if (tabControlSales.SelectedTab == tabPageCollected)
                {
                    buttonTenderAll.Enabled = false;

                    var collectedSales = from d in salesList where d.ColumnIsTendered == true select d;
                    if (collectedSales.Any())
                    {
                        dataCollectedSalesListSource.DataSource = collectedSales;
                        textBoxTotalAmount.Text = collectedSales.Sum(d => Convert.ToDecimal(d.ColumnAmount)).ToString("#,##0.00");
                    }
                    else
                    {
                        dataCollectedSalesListSource.Clear();
                        textBoxTotalAmount.Text = (0).ToString("#,##0.00");
                    }
                }
            }
            else
            {
                dataOpenSalesListSource.Clear();
                dataBilledOutSalesListSource.Clear();
                dataCollectedSalesListSource.Clear();
            }
        }
        public async Task<List<Entities.DgvTrnSalesListEntity>> GetSalesListDataTask(DateTime salesDate, Int32 terminalId, String filter)
        {
            return await Task.Factory.StartNew(() =>
            {
                List<Entities.DgvTrnSalesListEntity> rowList = new List<Entities.DgvTrnSalesListEntity>();

                Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();
                var salesList = trnPOSSalesController.POSTTouchListSales(salesDate, terminalId, filter);
                if (salesList.Any())
                {
                    var row = from d in salesList
                              select new Entities.DgvTrnSalesListEntity
                              {
                                  ColumnEdit = "Edit",
                                  ColumnDelete = "Delete",
                                  ColumnId = d.Id,
                                  ColumnTerminal = d.Terminal,
                                  ColumnSalesDate = d.SalesDate,
                                  ColumnSalesNumber = d.SalesNumber,
                                  ColumnManualSalesNumber = d.ManualInvoiceNumber,
                                  ColumnRececiptInvoiceNumber = d.CollectionNumber,
                                  ColumnCustomerCode = d.CustomerCode,
                                  ColumnCustomer = d.Customer,
                                  ColumnSalesAgent = d.SalesAgentUserName,
                                  ColumnTable = d.Table,
                                  ColumnIsLocked = d.IsLocked,
                                  ColumnIsTendered = d.IsTendered,
                                  ColumnIsCancelled = d.IsCancelled,
                                  ColumnSpace = "",
                                  ColumnRemarks = d.Remarks,
                                  ColumnAmount = d.Amount.ToString("#,##0.00"),
                                  ColumnDelivery = d.DeliveryDriver,
                              };

                    rowList = row.ToList();
                }

                return rowList;
            });
        }
        public void ArrangeColumns()
        {
            dataGridViewOpenSalesList.AutoGenerateColumns = false;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnEdit"].DisplayIndex = 0;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnDelete"].DisplayIndex = 1;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnId"].DisplayIndex = 2;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnTerminal"].DisplayIndex = 3;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnSalesDate"].DisplayIndex = 4;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnSalesNumber"].DisplayIndex = 5;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnManualSalesNumber"].DisplayIndex = 6;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnRececiptInvoiceNumber"].DisplayIndex = 7;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnCustomerCode"].DisplayIndex = 8;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnCustomer"].DisplayIndex = 9;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnSalesAgent"].DisplayIndex = 10;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnTable"].DisplayIndex = 11;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnIsLocked"].DisplayIndex = 12;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnIsTendered"].DisplayIndex = 13;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnIsCancelled"].DisplayIndex = 14;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnAmount"].DisplayIndex = 15;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnRemarks"].DisplayIndex = 16;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnDelivery"].DisplayIndex = 17;
            dataGridViewOpenSalesList.Columns["TabPageOpenColumnSpace"].DisplayIndex = 18;

            dataGridViewBilledOutSalesList.AutoGenerateColumns = false;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnEdit"].DisplayIndex = 0;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnDelete"].DisplayIndex = 1;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnId"].DisplayIndex = 2;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnTerminal"].DisplayIndex = 3;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnSalesDate"].DisplayIndex = 4;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnSalesNumber"].DisplayIndex = 5;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnManualSalesNumber"].DisplayIndex = 6;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnInvoiceNumber"].DisplayIndex = 7;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnCustomerCode"].DisplayIndex = 8;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnCustomer"].DisplayIndex = 9;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnSalesAgent"].DisplayIndex = 10;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnTable"].DisplayIndex = 11;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnIsLocked"].DisplayIndex = 12;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnIsTendered"].DisplayIndex = 13;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnIsCancelled"].DisplayIndex = 14;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnAmount"].DisplayIndex = 15;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnRemarks"].DisplayIndex = 16;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnDelivery"].DisplayIndex = 17;
            dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnSpace"].DisplayIndex = 18;

            dataGridViewCollectedSalesList.AutoGenerateColumns = false;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnEdit"].DisplayIndex = 0;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnDelete"].DisplayIndex = 1;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnId"].DisplayIndex = 2;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnTerminal"].DisplayIndex = 3;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnSalesDate"].DisplayIndex = 4;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnSalesNumber"].DisplayIndex = 5;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnManualSalesNumber"].DisplayIndex = 6;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnCollectionNumber"].DisplayIndex = 7;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnCustomerCode"].DisplayIndex = 8;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnCustomer"].DisplayIndex = 9;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnSalesAgent"].DisplayIndex = 10;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnTable"].DisplayIndex = 11;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnIsLocked"].DisplayIndex = 12;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnIsTendered"].DisplayIndex = 13;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnIsCancelled"].DisplayIndex = 14;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnAmount"].DisplayIndex = 15;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnRemarks"].DisplayIndex = 16;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnDelivery"].DisplayIndex = 17;
            dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnSpace"].DisplayIndex = 18;
        }

        public void CreateSalesListDataGrid()
        {
            ArrangeColumns();

            dataGridViewOpenSalesList.DataSource = dataOpenSalesListSource;
            dataGridViewBilledOutSalesList.DataSource = dataBilledOutSalesListSource;
            dataGridViewCollectedSalesList.DataSource = dataCollectedSalesListSource;
        }

        private void comboBoxTerminal_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSalesListGridDataSource();
        }

        private void dateTimePickerSalesDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateSalesListGridDataSource();
        }

        private void textBoxFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateSalesListGridDataSource();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            sysSoftwareForm.RemoveTabPage();
        }

        private void buttonTenderAll_Click(object sender, EventArgs e)
        {
            DialogResult deleteDialogResult = MessageBox.Show("Are you sure you want to tender all sales?", "Easy POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteDialogResult == DialogResult.Yes)
            {
                Controllers.TrnSalesController trnPOSSalesController = new Controllers.TrnSalesController();

                if (tabControlSales.SelectedTab == tabPageOpen)
                {
                    List<Int32> salesIds = new List<Int32>();
                    foreach (DataGridViewRow row in dataGridViewOpenSalesList.Rows)
                    {
                        var salesId = Convert.ToInt32(row.Cells[dataGridViewOpenSalesList.Columns["TabPageOpenColumnId"].Index].Value);
                        salesIds.Add(salesId);
                    }

                    String[] tenderAllSales = trnPOSSalesController.TenderAllSales(salesIds);
                    if (tenderAllSales[1].Equals("0") == false)
                    {
                        MessageBox.Show("Tender successful.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateSalesListGridDataSource();
                    }
                    else
                    {
                        MessageBox.Show(tenderAllSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (tabControlSales.SelectedTab == tabPageBilledOut)
                {
                    List<Int32> salesIds = new List<Int32>();
                    foreach (DataGridViewRow row in dataGridViewBilledOutSalesList.Rows)
                    {
                        var salesId = Convert.ToInt32(row.Cells[dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnId"].Index].Value);
                        salesIds.Add(salesId);
                    }

                    String[] tenderAllSales = trnPOSSalesController.TenderAllSales(salesIds);
                    if (tenderAllSales[1].Equals("0") == false)
                    {
                        MessageBox.Show("Tender successful.", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateSalesListGridDataSource();
                    }
                    else
                    {
                        MessageBox.Show(tenderAllSales[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonWalkIn_Click(object sender, EventArgs e)
        {
            if (Modules.SysCurrentModule.GetCurrentSettings().PromptLoginSales == true)
            {
                Account.SysLogin.SysLoginForm login = new Account.SysLogin.SysLoginForm(null, null, null, null,this,null, false);
                login.ShowDialog();
            }
            else
            {
                NewWalkInSales();
            }
        }

        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            TrnPOSDeliveryCustomerInformation trnPOSDeliveryCustomerInformation = new TrnPOSDeliveryCustomerInformation(null, this);
            trnPOSDeliveryCustomerInformation.ShowDialog();
        }

        public void ClosePOSTouchActivity()
        {
            trnPOSQuickServiceActivityForm.Close();
        }

        private void tabControlSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateSalesListGridDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewOpenSalesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dataGridViewOpenSalesList.CurrentCell.ColumnIndex == dataGridViewOpenSalesList.Columns["TabPageOpenColumnSalesNumber"].Index)
            {
                Controllers.TrnSalesController trnSalesController = new Controllers.TrnSalesController();
                Entities.TrnSalesEntity salesEntity = trnSalesController.DetailSales(Convert.ToInt32(dataGridViewOpenSalesList.Rows[dataGridViewOpenSalesList.CurrentCell.RowIndex].Cells[dataGridViewOpenSalesList.Columns["TabPageOpenColumnId"].Index].Value));
                trnPOSQuickServiceActivityForm = new TrnPOSQuickServiceActivityForm(sysSoftwareForm, this, salesEntity);
                trnPOSQuickServiceActivityForm.ShowDialog();
            }
        }

        private void dataGridViewBilledOutSalesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dataGridViewBilledOutSalesList.CurrentCell.ColumnIndex == dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnSalesNumber"].Index)
            {
                Controllers.TrnSalesController trnSalesController = new Controllers.TrnSalesController();
                Entities.TrnSalesEntity salesEntity = trnSalesController.DetailSales(Convert.ToInt32(dataGridViewBilledOutSalesList.Rows[dataGridViewBilledOutSalesList.CurrentCell.RowIndex].Cells[dataGridViewBilledOutSalesList.Columns["tabPageBilledOutColumnId"].Index].Value));

                trnPOSQuickServiceActivityForm = new TrnPOSQuickServiceActivityForm(sysSoftwareForm, this, salesEntity);
                trnPOSQuickServiceActivityForm.ShowDialog();
            }
        }

        private void dataGridViewCollectedSalesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dataGridViewCollectedSalesList.CurrentCell.ColumnIndex == dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnSalesNumber"].Index)
            {
                Controllers.TrnSalesController trnSalesController = new Controllers.TrnSalesController();
                Entities.TrnSalesEntity salesEntity = trnSalesController.DetailSales(Convert.ToInt32(dataGridViewCollectedSalesList.Rows[dataGridViewCollectedSalesList.CurrentCell.RowIndex].Cells[dataGridViewCollectedSalesList.Columns["tabPageCollectedColumnId"].Index].Value));

                trnPOSQuickServiceActivityForm = new TrnPOSQuickServiceActivityForm(sysSoftwareForm, this, salesEntity);
                trnPOSQuickServiceActivityForm.ShowDialog();
            }
        }

        private void buttonHideItems_Click(object sender, EventArgs e)
        {
            if (panelButton.Visible == true)
            {
                panelButton.Visible = false;
            }
            else
            {
                panelButton.Visible = true;
            }
        }
        public void getSysKeyboardOrderNumber(String text)
        {
            textBoxFilter.Text = text;
        }

        private void pictureBoxKeyboardOR_Click(object sender, EventArgs e)
        {
            SysKeyboard.SysKeyboardForm sysKeyboardForm = new SysKeyboard.SysKeyboardForm(null, null, this, null, null,null,null,null,null, "OrderNumber");
            sysKeyboardForm.ShowDialog();
        }
    }
}