
namespace EasyPOS.Forms.Software.TrnCollection
{
    partial class TrnCollectionListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewCollectionList = new System.Windows.Forms.DataGridView();
            this.ColumnCollectionListButtonEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnCollectionListButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnCollectionListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListPeriodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListCollectionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListCollectionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListTerminalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListCancelledCollectionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListManualORNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListSalesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListSalesBalanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListTenderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListChangeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListPreparedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListCheckedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListApprovedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListIsCancelled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnCollectionListIsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnCollectionListEntryUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListEntryDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListUpdateUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCollectionListUpdateDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCollectionListFilter = new System.Windows.Forms.TextBox();
            this.dateTimePickerCollectionListFilter = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCollectionListPageListFirst = new System.Windows.Forms.Button();
            this.buttonCollectionListPageListPrevious = new System.Windows.Forms.Button();
            this.buttonCollectionListPageListNext = new System.Windows.Forms.Button();
            this.buttonCollectionListPageListLast = new System.Windows.Forms.Button();
            this.textBoxCollectionListPageNumber = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCollectionList)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1637, 62);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.PurchaseOrder;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Collection List";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(1536, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 40);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(1444, 12);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 40);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.TabStop = false;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewCollectionList
            // 
            this.dataGridViewCollectionList.AllowUserToAddRows = false;
            this.dataGridViewCollectionList.AllowUserToDeleteRows = false;
            this.dataGridViewCollectionList.AllowUserToResizeRows = false;
            this.dataGridViewCollectionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCollectionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCollectionList.ColumnHeadersHeight = 45;
            this.dataGridViewCollectionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCollectionListButtonEdit,
            this.ColumnCollectionListButtonDelete,
            this.ColumnCollectionListId,
            this.ColumnCollectionListPeriodId,
            this.ColumnCollectionListCollectionDate,
            this.ColumnCollectionListCollectionNumber,
            this.ColumnCollectionListTerminalId,
            this.ColumnCollectionListTerminal,
            this.ColumnCollectionListCancelledCollectionNumber,
            this.ColumnCollectionListManualORNumber,
            this.ColumnCollectionListCustomerId,
            this.ColumnCollectionListCustomer,
            this.ColumnCollectionListRemarks,
            this.ColumnCollectionListSalesId,
            this.ColumnCollectionListSalesBalanceAmount,
            this.ColumnCollectionListAmount,
            this.ColumnCollectionListTenderAmount,
            this.ColumnCollectionListChangeAmount,
            this.ColumnCollectionListPreparedBy,
            this.ColumnCollectionListCheckedBy,
            this.ColumnCollectionListApprovedBy,
            this.ColumnCollectionListIsCancelled,
            this.ColumnCollectionListIsLocked,
            this.ColumnCollectionListEntryUserId,
            this.ColumnCollectionListEntryDateTime,
            this.ColumnCollectionListUpdateUserId,
            this.ColumnCollectionListUpdateDateTime});
            this.dataGridViewCollectionList.Location = new System.Drawing.Point(26, 105);
            this.dataGridViewCollectionList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCollectionList.MultiSelect = false;
            this.dataGridViewCollectionList.Name = "dataGridViewCollectionList";
            this.dataGridViewCollectionList.ReadOnly = true;
            this.dataGridViewCollectionList.RowHeadersWidth = 62;
            this.dataGridViewCollectionList.RowTemplate.Height = 24;
            this.dataGridViewCollectionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCollectionList.Size = new System.Drawing.Size(1611, 492);
            this.dataGridViewCollectionList.TabIndex = 24;
            this.dataGridViewCollectionList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCollectionList_CellClick);
            // 
            // ColumnCollectionListButtonEdit
            // 
            this.ColumnCollectionListButtonEdit.DataPropertyName = "ColumnCollectionListButtonEdit";
            this.ColumnCollectionListButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnCollectionListButtonEdit.Frozen = true;
            this.ColumnCollectionListButtonEdit.HeaderText = "";
            this.ColumnCollectionListButtonEdit.MinimumWidth = 8;
            this.ColumnCollectionListButtonEdit.Name = "ColumnCollectionListButtonEdit";
            this.ColumnCollectionListButtonEdit.ReadOnly = true;
            this.ColumnCollectionListButtonEdit.Width = 70;
            // 
            // ColumnCollectionListButtonDelete
            // 
            this.ColumnCollectionListButtonDelete.DataPropertyName = "ColumnCollectionListButtonDelete";
            this.ColumnCollectionListButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnCollectionListButtonDelete.Frozen = true;
            this.ColumnCollectionListButtonDelete.HeaderText = "";
            this.ColumnCollectionListButtonDelete.MinimumWidth = 8;
            this.ColumnCollectionListButtonDelete.Name = "ColumnCollectionListButtonDelete";
            this.ColumnCollectionListButtonDelete.ReadOnly = true;
            this.ColumnCollectionListButtonDelete.Width = 70;
            // 
            // ColumnCollectionListId
            // 
            this.ColumnCollectionListId.DataPropertyName = "ColumnCollectionListId";
            this.ColumnCollectionListId.HeaderText = "Id";
            this.ColumnCollectionListId.MinimumWidth = 8;
            this.ColumnCollectionListId.Name = "ColumnCollectionListId";
            this.ColumnCollectionListId.ReadOnly = true;
            this.ColumnCollectionListId.Visible = false;
            this.ColumnCollectionListId.Width = 150;
            // 
            // ColumnCollectionListPeriodId
            // 
            this.ColumnCollectionListPeriodId.DataPropertyName = "ColumnCollectionListPeriodId";
            this.ColumnCollectionListPeriodId.HeaderText = "PeriodId";
            this.ColumnCollectionListPeriodId.MinimumWidth = 8;
            this.ColumnCollectionListPeriodId.Name = "ColumnCollectionListPeriodId";
            this.ColumnCollectionListPeriodId.ReadOnly = true;
            this.ColumnCollectionListPeriodId.Visible = false;
            this.ColumnCollectionListPeriodId.Width = 150;
            // 
            // ColumnCollectionListCollectionDate
            // 
            this.ColumnCollectionListCollectionDate.DataPropertyName = "ColumnCollectionListCollectionDate";
            this.ColumnCollectionListCollectionDate.HeaderText = "Collection Date";
            this.ColumnCollectionListCollectionDate.MinimumWidth = 8;
            this.ColumnCollectionListCollectionDate.Name = "ColumnCollectionListCollectionDate";
            this.ColumnCollectionListCollectionDate.ReadOnly = true;
            this.ColumnCollectionListCollectionDate.Visible = false;
            this.ColumnCollectionListCollectionDate.Width = 95;
            // 
            // ColumnCollectionListCollectionNumber
            // 
            this.ColumnCollectionListCollectionNumber.DataPropertyName = "ColumnCollectionListCollectionNumber";
            this.ColumnCollectionListCollectionNumber.HeaderText = "Collection No.";
            this.ColumnCollectionListCollectionNumber.MinimumWidth = 8;
            this.ColumnCollectionListCollectionNumber.Name = "ColumnCollectionListCollectionNumber";
            this.ColumnCollectionListCollectionNumber.ReadOnly = true;
            this.ColumnCollectionListCollectionNumber.Width = 150;
            // 
            // ColumnCollectionListTerminalId
            // 
            this.ColumnCollectionListTerminalId.DataPropertyName = "ColumnCollectionListTerminalId";
            this.ColumnCollectionListTerminalId.HeaderText = "Terminal Id";
            this.ColumnCollectionListTerminalId.MinimumWidth = 8;
            this.ColumnCollectionListTerminalId.Name = "ColumnCollectionListTerminalId";
            this.ColumnCollectionListTerminalId.ReadOnly = true;
            this.ColumnCollectionListTerminalId.Visible = false;
            this.ColumnCollectionListTerminalId.Width = 150;
            // 
            // ColumnCollectionListTerminal
            // 
            this.ColumnCollectionListTerminal.DataPropertyName = "ColumnCollectionListTerminal";
            this.ColumnCollectionListTerminal.HeaderText = "Terminal";
            this.ColumnCollectionListTerminal.MinimumWidth = 8;
            this.ColumnCollectionListTerminal.Name = "ColumnCollectionListTerminal";
            this.ColumnCollectionListTerminal.ReadOnly = true;
            this.ColumnCollectionListTerminal.Width = 80;
            // 
            // ColumnCollectionListCancelledCollectionNumber
            // 
            this.ColumnCollectionListCancelledCollectionNumber.DataPropertyName = "ColumnCollectionListCancelledCollectionNumber";
            this.ColumnCollectionListCancelledCollectionNumber.HeaderText = "Cancelled Collection Number";
            this.ColumnCollectionListCancelledCollectionNumber.MinimumWidth = 8;
            this.ColumnCollectionListCancelledCollectionNumber.Name = "ColumnCollectionListCancelledCollectionNumber";
            this.ColumnCollectionListCancelledCollectionNumber.ReadOnly = true;
            this.ColumnCollectionListCancelledCollectionNumber.Width = 150;
            // 
            // ColumnCollectionListManualORNumber
            // 
            this.ColumnCollectionListManualORNumber.DataPropertyName = "ColumnCollectionListManualORNumber";
            this.ColumnCollectionListManualORNumber.HeaderText = "Manual OR Number";
            this.ColumnCollectionListManualORNumber.MinimumWidth = 8;
            this.ColumnCollectionListManualORNumber.Name = "ColumnCollectionListManualORNumber";
            this.ColumnCollectionListManualORNumber.ReadOnly = true;
            this.ColumnCollectionListManualORNumber.Width = 150;
            // 
            // ColumnCollectionListCustomerId
            // 
            this.ColumnCollectionListCustomerId.DataPropertyName = "ColumnCollectionListCustomerId";
            this.ColumnCollectionListCustomerId.HeaderText = "Customer Id";
            this.ColumnCollectionListCustomerId.MinimumWidth = 8;
            this.ColumnCollectionListCustomerId.Name = "ColumnCollectionListCustomerId";
            this.ColumnCollectionListCustomerId.ReadOnly = true;
            this.ColumnCollectionListCustomerId.Visible = false;
            this.ColumnCollectionListCustomerId.Width = 150;
            // 
            // ColumnCollectionListCustomer
            // 
            this.ColumnCollectionListCustomer.DataPropertyName = "ColumnCollectionListCustomer";
            this.ColumnCollectionListCustomer.HeaderText = "Customer";
            this.ColumnCollectionListCustomer.MinimumWidth = 8;
            this.ColumnCollectionListCustomer.Name = "ColumnCollectionListCustomer";
            this.ColumnCollectionListCustomer.ReadOnly = true;
            this.ColumnCollectionListCustomer.Width = 150;
            // 
            // ColumnCollectionListRemarks
            // 
            this.ColumnCollectionListRemarks.DataPropertyName = "ColumnCollectionListRemarks";
            this.ColumnCollectionListRemarks.HeaderText = "Remarks";
            this.ColumnCollectionListRemarks.MinimumWidth = 8;
            this.ColumnCollectionListRemarks.Name = "ColumnCollectionListRemarks";
            this.ColumnCollectionListRemarks.ReadOnly = true;
            this.ColumnCollectionListRemarks.Width = 200;
            // 
            // ColumnCollectionListSalesId
            // 
            this.ColumnCollectionListSalesId.DataPropertyName = "ColumnCollectionListSalesId";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnCollectionListSalesId.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnCollectionListSalesId.HeaderText = "Sales Id";
            this.ColumnCollectionListSalesId.MinimumWidth = 8;
            this.ColumnCollectionListSalesId.Name = "ColumnCollectionListSalesId";
            this.ColumnCollectionListSalesId.ReadOnly = true;
            this.ColumnCollectionListSalesId.Visible = false;
            this.ColumnCollectionListSalesId.Width = 150;
            // 
            // ColumnCollectionListSalesBalanceAmount
            // 
            this.ColumnCollectionListSalesBalanceAmount.DataPropertyName = "ColumnCollectionListSalesBalanceAmount";
            this.ColumnCollectionListSalesBalanceAmount.HeaderText = "Sales Balance Amount";
            this.ColumnCollectionListSalesBalanceAmount.MinimumWidth = 8;
            this.ColumnCollectionListSalesBalanceAmount.Name = "ColumnCollectionListSalesBalanceAmount";
            this.ColumnCollectionListSalesBalanceAmount.ReadOnly = true;
            this.ColumnCollectionListSalesBalanceAmount.Width = 150;
            // 
            // ColumnCollectionListAmount
            // 
            this.ColumnCollectionListAmount.DataPropertyName = "ColumnCollectionListAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnCollectionListAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnCollectionListAmount.HeaderText = "Amount";
            this.ColumnCollectionListAmount.MinimumWidth = 8;
            this.ColumnCollectionListAmount.Name = "ColumnCollectionListAmount";
            this.ColumnCollectionListAmount.ReadOnly = true;
            this.ColumnCollectionListAmount.Visible = false;
            this.ColumnCollectionListAmount.Width = 150;
            // 
            // ColumnCollectionListTenderAmount
            // 
            this.ColumnCollectionListTenderAmount.DataPropertyName = "ColumnCollectionListTenderAmount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnCollectionListTenderAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnCollectionListTenderAmount.HeaderText = "Tender Amount";
            this.ColumnCollectionListTenderAmount.MinimumWidth = 8;
            this.ColumnCollectionListTenderAmount.Name = "ColumnCollectionListTenderAmount";
            this.ColumnCollectionListTenderAmount.ReadOnly = true;
            this.ColumnCollectionListTenderAmount.Width = 150;
            // 
            // ColumnCollectionListChangeAmount
            // 
            this.ColumnCollectionListChangeAmount.DataPropertyName = "ColumnCollectionListChangeAmount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnCollectionListChangeAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnCollectionListChangeAmount.HeaderText = "Change Amount";
            this.ColumnCollectionListChangeAmount.MinimumWidth = 8;
            this.ColumnCollectionListChangeAmount.Name = "ColumnCollectionListChangeAmount";
            this.ColumnCollectionListChangeAmount.ReadOnly = true;
            this.ColumnCollectionListChangeAmount.Width = 150;
            // 
            // ColumnCollectionListPreparedBy
            // 
            this.ColumnCollectionListPreparedBy.DataPropertyName = "ColumnCollectionListPreparedBy";
            this.ColumnCollectionListPreparedBy.HeaderText = "Prepared By";
            this.ColumnCollectionListPreparedBy.MinimumWidth = 8;
            this.ColumnCollectionListPreparedBy.Name = "ColumnCollectionListPreparedBy";
            this.ColumnCollectionListPreparedBy.ReadOnly = true;
            this.ColumnCollectionListPreparedBy.Visible = false;
            this.ColumnCollectionListPreparedBy.Width = 150;
            // 
            // ColumnCollectionListCheckedBy
            // 
            this.ColumnCollectionListCheckedBy.DataPropertyName = "ColumnCollectionListCheckedBy";
            this.ColumnCollectionListCheckedBy.HeaderText = "Checked By";
            this.ColumnCollectionListCheckedBy.MinimumWidth = 8;
            this.ColumnCollectionListCheckedBy.Name = "ColumnCollectionListCheckedBy";
            this.ColumnCollectionListCheckedBy.ReadOnly = true;
            this.ColumnCollectionListCheckedBy.Visible = false;
            this.ColumnCollectionListCheckedBy.Width = 150;
            // 
            // ColumnCollectionListApprovedBy
            // 
            this.ColumnCollectionListApprovedBy.DataPropertyName = "ColumnCollectionListApprovedBy";
            this.ColumnCollectionListApprovedBy.HeaderText = "Approved By";
            this.ColumnCollectionListApprovedBy.MinimumWidth = 8;
            this.ColumnCollectionListApprovedBy.Name = "ColumnCollectionListApprovedBy";
            this.ColumnCollectionListApprovedBy.ReadOnly = true;
            this.ColumnCollectionListApprovedBy.Visible = false;
            this.ColumnCollectionListApprovedBy.Width = 150;
            // 
            // ColumnCollectionListIsCancelled
            // 
            this.ColumnCollectionListIsCancelled.DataPropertyName = "ColumnCollectionListIsCancelled";
            this.ColumnCollectionListIsCancelled.HeaderText = "C";
            this.ColumnCollectionListIsCancelled.MinimumWidth = 8;
            this.ColumnCollectionListIsCancelled.Name = "ColumnCollectionListIsCancelled";
            this.ColumnCollectionListIsCancelled.ReadOnly = true;
            this.ColumnCollectionListIsCancelled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCollectionListIsCancelled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnCollectionListIsCancelled.Width = 35;
            // 
            // ColumnCollectionListIsLocked
            // 
            this.ColumnCollectionListIsLocked.DataPropertyName = "ColumnCollectionListIsLocked";
            this.ColumnCollectionListIsLocked.HeaderText = "L";
            this.ColumnCollectionListIsLocked.MinimumWidth = 8;
            this.ColumnCollectionListIsLocked.Name = "ColumnCollectionListIsLocked";
            this.ColumnCollectionListIsLocked.ReadOnly = true;
            this.ColumnCollectionListIsLocked.Width = 35;
            // 
            // ColumnCollectionListEntryUserId
            // 
            this.ColumnCollectionListEntryUserId.DataPropertyName = "ColumnCollectionListEntryUserId";
            this.ColumnCollectionListEntryUserId.HeaderText = "Entry User Id";
            this.ColumnCollectionListEntryUserId.MinimumWidth = 8;
            this.ColumnCollectionListEntryUserId.Name = "ColumnCollectionListEntryUserId";
            this.ColumnCollectionListEntryUserId.ReadOnly = true;
            this.ColumnCollectionListEntryUserId.Visible = false;
            this.ColumnCollectionListEntryUserId.Width = 150;
            // 
            // ColumnCollectionListEntryDateTime
            // 
            this.ColumnCollectionListEntryDateTime.DataPropertyName = "ColumnCollectionListEntryDateTime";
            this.ColumnCollectionListEntryDateTime.HeaderText = "Entry Date Time";
            this.ColumnCollectionListEntryDateTime.MinimumWidth = 8;
            this.ColumnCollectionListEntryDateTime.Name = "ColumnCollectionListEntryDateTime";
            this.ColumnCollectionListEntryDateTime.ReadOnly = true;
            this.ColumnCollectionListEntryDateTime.Visible = false;
            this.ColumnCollectionListEntryDateTime.Width = 150;
            // 
            // ColumnCollectionListUpdateUserId
            // 
            this.ColumnCollectionListUpdateUserId.DataPropertyName = "ColumnCollectionListUpdateUserId";
            this.ColumnCollectionListUpdateUserId.HeaderText = "Update User Id";
            this.ColumnCollectionListUpdateUserId.MinimumWidth = 8;
            this.ColumnCollectionListUpdateUserId.Name = "ColumnCollectionListUpdateUserId";
            this.ColumnCollectionListUpdateUserId.ReadOnly = true;
            this.ColumnCollectionListUpdateUserId.Visible = false;
            this.ColumnCollectionListUpdateUserId.Width = 150;
            // 
            // ColumnCollectionListUpdateDateTime
            // 
            this.ColumnCollectionListUpdateDateTime.DataPropertyName = "ColumnCollectionListUpdateDateTime";
            this.ColumnCollectionListUpdateDateTime.HeaderText = "Update Date Time";
            this.ColumnCollectionListUpdateDateTime.MinimumWidth = 8;
            this.ColumnCollectionListUpdateDateTime.Name = "ColumnCollectionListUpdateDateTime";
            this.ColumnCollectionListUpdateDateTime.ReadOnly = true;
            this.ColumnCollectionListUpdateDateTime.Visible = false;
            this.ColumnCollectionListUpdateDateTime.Width = 150;
            // 
            // textBoxCollectionListFilter
            // 
            this.textBoxCollectionListFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCollectionListFilter.Location = new System.Drawing.Point(171, 68);
            this.textBoxCollectionListFilter.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCollectionListFilter.Name = "textBoxCollectionListFilter";
            this.textBoxCollectionListFilter.Size = new System.Drawing.Size(1451, 30);
            this.textBoxCollectionListFilter.TabIndex = 23;
            // 
            // dateTimePickerCollectionListFilter
            // 
            this.dateTimePickerCollectionListFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCollectionListFilter.Location = new System.Drawing.Point(12, 68);
            this.dateTimePickerCollectionListFilter.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerCollectionListFilter.Name = "dateTimePickerCollectionListFilter";
            this.dateTimePickerCollectionListFilter.Size = new System.Drawing.Size(153, 30);
            this.dateTimePickerCollectionListFilter.TabIndex = 22;
            this.dateTimePickerCollectionListFilter.ValueChanged += new System.EventHandler(this.dateTimePickerCollectionListFilter_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.buttonCollectionListPageListFirst);
            this.panel3.Controls.Add(this.buttonCollectionListPageListPrevious);
            this.panel3.Controls.Add(this.buttonCollectionListPageListNext);
            this.panel3.Controls.Add(this.buttonCollectionListPageListLast);
            this.panel3.Controls.Add(this.textBoxCollectionListPageNumber);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 586);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1637, 58);
            this.panel3.TabIndex = 25;
            // 
            // buttonCollectionListPageListFirst
            // 
            this.buttonCollectionListPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCollectionListPageListFirst.Enabled = false;
            this.buttonCollectionListPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonCollectionListPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCollectionListPageListFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCollectionListPageListFirst.Location = new System.Drawing.Point(12, 16);
            this.buttonCollectionListPageListFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCollectionListPageListFirst.Name = "buttonCollectionListPageListFirst";
            this.buttonCollectionListPageListFirst.Size = new System.Drawing.Size(82, 32);
            this.buttonCollectionListPageListFirst.TabIndex = 13;
            this.buttonCollectionListPageListFirst.Text = "First";
            this.buttonCollectionListPageListFirst.UseVisualStyleBackColor = false;
            this.buttonCollectionListPageListFirst.Click += new System.EventHandler(this.buttonCollectionListPageListFirst_Click);
            // 
            // buttonCollectionListPageListPrevious
            // 
            this.buttonCollectionListPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCollectionListPageListPrevious.Enabled = false;
            this.buttonCollectionListPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonCollectionListPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCollectionListPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCollectionListPageListPrevious.Location = new System.Drawing.Point(100, 16);
            this.buttonCollectionListPageListPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCollectionListPageListPrevious.Name = "buttonCollectionListPageListPrevious";
            this.buttonCollectionListPageListPrevious.Size = new System.Drawing.Size(82, 32);
            this.buttonCollectionListPageListPrevious.TabIndex = 14;
            this.buttonCollectionListPageListPrevious.Text = "Previous";
            this.buttonCollectionListPageListPrevious.UseVisualStyleBackColor = false;
            this.buttonCollectionListPageListPrevious.Click += new System.EventHandler(this.buttonCollectionListPageListPrevious_Click);
            // 
            // buttonCollectionListPageListNext
            // 
            this.buttonCollectionListPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCollectionListPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonCollectionListPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCollectionListPageListNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCollectionListPageListNext.Location = new System.Drawing.Point(262, 16);
            this.buttonCollectionListPageListNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCollectionListPageListNext.Name = "buttonCollectionListPageListNext";
            this.buttonCollectionListPageListNext.Size = new System.Drawing.Size(82, 32);
            this.buttonCollectionListPageListNext.TabIndex = 15;
            this.buttonCollectionListPageListNext.Text = "Next";
            this.buttonCollectionListPageListNext.UseVisualStyleBackColor = false;
            this.buttonCollectionListPageListNext.Click += new System.EventHandler(this.buttonCollectionListPageListNext_Click);
            // 
            // buttonCollectionListPageListLast
            // 
            this.buttonCollectionListPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCollectionListPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonCollectionListPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCollectionListPageListLast.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCollectionListPageListLast.Location = new System.Drawing.Point(348, 16);
            this.buttonCollectionListPageListLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCollectionListPageListLast.Name = "buttonCollectionListPageListLast";
            this.buttonCollectionListPageListLast.Size = new System.Drawing.Size(82, 32);
            this.buttonCollectionListPageListLast.TabIndex = 16;
            this.buttonCollectionListPageListLast.Text = "Last";
            this.buttonCollectionListPageListLast.UseVisualStyleBackColor = false;
            this.buttonCollectionListPageListLast.Click += new System.EventHandler(this.buttonCollectionListPageListLast_Click);
            // 
            // textBoxCollectionListPageNumber
            // 
            this.textBoxCollectionListPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCollectionListPageNumber.BackColor = System.Drawing.Color.White;
            this.textBoxCollectionListPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCollectionListPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxCollectionListPageNumber.Location = new System.Drawing.Point(188, 21);
            this.textBoxCollectionListPageNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCollectionListPageNumber.Name = "textBoxCollectionListPageNumber";
            this.textBoxCollectionListPageNumber.ReadOnly = true;
            this.textBoxCollectionListPageNumber.Size = new System.Drawing.Size(69, 20);
            this.textBoxCollectionListPageNumber.TabIndex = 17;
            this.textBoxCollectionListPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TrnCollectionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1637, 644);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewCollectionList);
            this.Controls.Add(this.textBoxCollectionListFilter);
            this.Controls.Add(this.dateTimePickerCollectionListFilter);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TrnCollectionListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrnCollectionListForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCollectionList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewCollectionList;
        private System.Windows.Forms.TextBox textBoxCollectionListFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerCollectionListFilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCollectionListPageListFirst;
        private System.Windows.Forms.Button buttonCollectionListPageListPrevious;
        private System.Windows.Forms.Button buttonCollectionListPageListNext;
        private System.Windows.Forms.Button buttonCollectionListPageListLast;
        private System.Windows.Forms.TextBox textBoxCollectionListPageNumber;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCollectionListButtonEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCollectionListButtonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListPeriodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListCollectionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListCollectionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListTerminalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListCancelledCollectionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListManualORNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListSalesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListSalesBalanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListTenderAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListChangeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListPreparedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListCheckedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListApprovedBy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCollectionListIsCancelled;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCollectionListIsLocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListEntryUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListEntryDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListUpdateUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionListUpdateDateTime;
    }
}