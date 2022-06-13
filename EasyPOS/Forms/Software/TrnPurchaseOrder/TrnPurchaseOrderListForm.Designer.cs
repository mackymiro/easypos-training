namespace EasyPOS.Forms.Software.TrnPurchaseOrder
{
    partial class TrnPurchaseOrderListForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dateTimePickerPurchaseOrderListFilter = new System.Windows.Forms.DateTimePicker();
			this.textBoxPurchaseOrderListFilter = new System.Windows.Forms.TextBox();
			this.dataGridViewPurchaseOrderList = new System.Windows.Forms.DataGridView();
			this.ColumnPurchaseOrderListButtonEdit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ColumnPurchaseOrderListButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ColumnPurchaseOrderListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPurchaseOrderListPeriodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPurchaseOrderListPurchaseOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPurchaseOrderListPurchaseOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPurchaseOrderListAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPurchaseOrderListSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPurchaseOrderListRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPurchaseOrderListPreparedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPurchaseOrderListCheckedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPurchaseOrderListApprovedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPurchaseOrderListIsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ColumnPurchaseOrderListEntryUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPurchaseOrderListEntryDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPurchaseOrderListUpdateUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPurchaseOrderListUpdateDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPurchaseOrderListRequestedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.buttonPurchaseOrderListPageListFirst = new System.Windows.Forms.Button();
			this.buttonPurchaseOrderListPageListPrevious = new System.Windows.Forms.Button();
			this.buttonPurchaseOrderListPageListNext = new System.Windows.Forms.Button();
			this.buttonPurchaseOrderListPageListLast = new System.Windows.Forms.Button();
			this.textBoxPurchaseOrderListPageNumber = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseOrderList)).BeginInit();
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
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1620, 75);
			this.panel1.TabIndex = 7;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EasyPOS.Properties.Resources.PurchaseOrder;
			this.pictureBox1.Location = new System.Drawing.Point(15, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(57, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(75, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(290, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Purchase Order List";
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
			this.buttonClose.Location = new System.Drawing.Point(1498, 15);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(105, 48);
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
			this.buttonAdd.Location = new System.Drawing.Point(1388, 15);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(105, 48);
			this.buttonAdd.TabIndex = 20;
			this.buttonAdd.TabStop = false;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// dateTimePickerPurchaseOrderListFilter
			// 
			this.dateTimePickerPurchaseOrderListFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerPurchaseOrderListFilter.Location = new System.Drawing.Point(15, 81);
			this.dateTimePickerPurchaseOrderListFilter.Name = "dateTimePickerPurchaseOrderListFilter";
			this.dateTimePickerPurchaseOrderListFilter.Size = new System.Drawing.Size(169, 35);
			this.dateTimePickerPurchaseOrderListFilter.TabIndex = 8;
			this.dateTimePickerPurchaseOrderListFilter.ValueChanged += new System.EventHandler(this.dateTimePickerPurchaseOrderListFilter_ValueChanged);
			// 
			// textBoxPurchaseOrderListFilter
			// 
			this.textBoxPurchaseOrderListFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPurchaseOrderListFilter.Location = new System.Drawing.Point(192, 81);
			this.textBoxPurchaseOrderListFilter.Name = "textBoxPurchaseOrderListFilter";
			this.textBoxPurchaseOrderListFilter.Size = new System.Drawing.Size(1410, 35);
			this.textBoxPurchaseOrderListFilter.TabIndex = 9;
			// 
			// dataGridViewPurchaseOrderList
			// 
			this.dataGridViewPurchaseOrderList.AllowUserToAddRows = false;
			this.dataGridViewPurchaseOrderList.AllowUserToDeleteRows = false;
			this.dataGridViewPurchaseOrderList.AllowUserToResizeRows = false;
			this.dataGridViewPurchaseOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewPurchaseOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewPurchaseOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPurchaseOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPurchaseOrderListButtonEdit,
            this.ColumnPurchaseOrderListButtonDelete,
            this.ColumnPurchaseOrderListId,
            this.ColumnPurchaseOrderListPeriodId,
            this.ColumnPurchaseOrderListPurchaseOrderDate,
            this.ColumnPurchaseOrderListPurchaseOrderNumber,
            this.ColumnPurchaseOrderListAmount,
            this.ColumnPurchaseOrderListSupplier,
            this.ColumnPurchaseOrderListRemarks,
            this.ColumnPurchaseOrderListPreparedBy,
            this.ColumnPurchaseOrderListCheckedBy,
            this.ColumnPurchaseOrderListApprovedBy,
            this.ColumnPurchaseOrderListIsLocked,
            this.ColumnPurchaseOrderListEntryUserId,
            this.ColumnPurchaseOrderListEntryDateTime,
            this.ColumnPurchaseOrderListUpdateUserId,
            this.ColumnPurchaseOrderListUpdateDateTime,
            this.ColumnPurchaseOrderListRequestedBy});
			this.dataGridViewPurchaseOrderList.Location = new System.Drawing.Point(15, 123);
			this.dataGridViewPurchaseOrderList.MultiSelect = false;
			this.dataGridViewPurchaseOrderList.Name = "dataGridViewPurchaseOrderList";
			this.dataGridViewPurchaseOrderList.ReadOnly = true;
			this.dataGridViewPurchaseOrderList.RowHeadersWidth = 62;
			this.dataGridViewPurchaseOrderList.RowTemplate.Height = 24;
			this.dataGridViewPurchaseOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewPurchaseOrderList.Size = new System.Drawing.Size(1588, 624);
			this.dataGridViewPurchaseOrderList.TabIndex = 21;
			this.dataGridViewPurchaseOrderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPurchaseOrderList_CellClick);
			// 
			// ColumnPurchaseOrderListButtonEdit
			// 
			this.ColumnPurchaseOrderListButtonEdit.DataPropertyName = "ColumnPurchaseOrderListButtonEdit";
			this.ColumnPurchaseOrderListButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ColumnPurchaseOrderListButtonEdit.HeaderText = "";
			this.ColumnPurchaseOrderListButtonEdit.MinimumWidth = 8;
			this.ColumnPurchaseOrderListButtonEdit.Name = "ColumnPurchaseOrderListButtonEdit";
			this.ColumnPurchaseOrderListButtonEdit.ReadOnly = true;
			this.ColumnPurchaseOrderListButtonEdit.Width = 70;
			// 
			// ColumnPurchaseOrderListButtonDelete
			// 
			this.ColumnPurchaseOrderListButtonDelete.DataPropertyName = "ColumnPurchaseOrderListButtonDelete";
			this.ColumnPurchaseOrderListButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ColumnPurchaseOrderListButtonDelete.HeaderText = "";
			this.ColumnPurchaseOrderListButtonDelete.MinimumWidth = 8;
			this.ColumnPurchaseOrderListButtonDelete.Name = "ColumnPurchaseOrderListButtonDelete";
			this.ColumnPurchaseOrderListButtonDelete.ReadOnly = true;
			this.ColumnPurchaseOrderListButtonDelete.Width = 70;
			// 
			// ColumnPurchaseOrderListId
			// 
			this.ColumnPurchaseOrderListId.DataPropertyName = "ColumnPurchaseOrderListId";
			this.ColumnPurchaseOrderListId.HeaderText = "Id";
			this.ColumnPurchaseOrderListId.MinimumWidth = 8;
			this.ColumnPurchaseOrderListId.Name = "ColumnPurchaseOrderListId";
			this.ColumnPurchaseOrderListId.ReadOnly = true;
			this.ColumnPurchaseOrderListId.Visible = false;
			this.ColumnPurchaseOrderListId.Width = 150;
			// 
			// ColumnPurchaseOrderListPeriodId
			// 
			this.ColumnPurchaseOrderListPeriodId.DataPropertyName = "ColumnPurchaseOrderListPeriodId";
			this.ColumnPurchaseOrderListPeriodId.HeaderText = "PeriodId";
			this.ColumnPurchaseOrderListPeriodId.MinimumWidth = 8;
			this.ColumnPurchaseOrderListPeriodId.Name = "ColumnPurchaseOrderListPeriodId";
			this.ColumnPurchaseOrderListPeriodId.ReadOnly = true;
			this.ColumnPurchaseOrderListPeriodId.Visible = false;
			this.ColumnPurchaseOrderListPeriodId.Width = 150;
			// 
			// ColumnPurchaseOrderListPurchaseOrderDate
			// 
			this.ColumnPurchaseOrderListPurchaseOrderDate.DataPropertyName = "ColumnPurchaseOrderListPurchaseOrderDate";
			this.ColumnPurchaseOrderListPurchaseOrderDate.HeaderText = "Purchase Order Date";
			this.ColumnPurchaseOrderListPurchaseOrderDate.MinimumWidth = 8;
			this.ColumnPurchaseOrderListPurchaseOrderDate.Name = "ColumnPurchaseOrderListPurchaseOrderDate";
			this.ColumnPurchaseOrderListPurchaseOrderDate.ReadOnly = true;
			this.ColumnPurchaseOrderListPurchaseOrderDate.Visible = false;
			this.ColumnPurchaseOrderListPurchaseOrderDate.Width = 95;
			// 
			// ColumnPurchaseOrderListPurchaseOrderNumber
			// 
			this.ColumnPurchaseOrderListPurchaseOrderNumber.DataPropertyName = "ColumnPurchaseOrderListPurchaseOrderNumber";
			this.ColumnPurchaseOrderListPurchaseOrderNumber.HeaderText = "Purchase Order No.";
			this.ColumnPurchaseOrderListPurchaseOrderNumber.MinimumWidth = 8;
			this.ColumnPurchaseOrderListPurchaseOrderNumber.Name = "ColumnPurchaseOrderListPurchaseOrderNumber";
			this.ColumnPurchaseOrderListPurchaseOrderNumber.ReadOnly = true;
			this.ColumnPurchaseOrderListPurchaseOrderNumber.Width = 150;
			// 
			// ColumnPurchaseOrderListAmount
			// 
			this.ColumnPurchaseOrderListAmount.DataPropertyName = "ColumnPurchaseOrderListAmount";
			this.ColumnPurchaseOrderListAmount.HeaderText = "Amount";
			this.ColumnPurchaseOrderListAmount.MinimumWidth = 8;
			this.ColumnPurchaseOrderListAmount.Name = "ColumnPurchaseOrderListAmount";
			this.ColumnPurchaseOrderListAmount.ReadOnly = true;
			this.ColumnPurchaseOrderListAmount.Visible = false;
			this.ColumnPurchaseOrderListAmount.Width = 150;
			// 
			// ColumnPurchaseOrderListSupplier
			// 
			this.ColumnPurchaseOrderListSupplier.DataPropertyName = "ColumnPurchaseOrderListSupplier";
			this.ColumnPurchaseOrderListSupplier.HeaderText = "Supplier";
			this.ColumnPurchaseOrderListSupplier.MinimumWidth = 8;
			this.ColumnPurchaseOrderListSupplier.Name = "ColumnPurchaseOrderListSupplier";
			this.ColumnPurchaseOrderListSupplier.ReadOnly = true;
			this.ColumnPurchaseOrderListSupplier.Width = 200;
			// 
			// ColumnPurchaseOrderListRemarks
			// 
			this.ColumnPurchaseOrderListRemarks.DataPropertyName = "ColumnPurchaseOrderListRemarks";
			this.ColumnPurchaseOrderListRemarks.HeaderText = "Remarks";
			this.ColumnPurchaseOrderListRemarks.MinimumWidth = 8;
			this.ColumnPurchaseOrderListRemarks.Name = "ColumnPurchaseOrderListRemarks";
			this.ColumnPurchaseOrderListRemarks.ReadOnly = true;
			this.ColumnPurchaseOrderListRemarks.Width = 300;
			// 
			// ColumnPurchaseOrderListPreparedBy
			// 
			this.ColumnPurchaseOrderListPreparedBy.DataPropertyName = "ColumnPurchaseOrderListPreparedBy";
			this.ColumnPurchaseOrderListPreparedBy.HeaderText = "Prepared By";
			this.ColumnPurchaseOrderListPreparedBy.MinimumWidth = 8;
			this.ColumnPurchaseOrderListPreparedBy.Name = "ColumnPurchaseOrderListPreparedBy";
			this.ColumnPurchaseOrderListPreparedBy.ReadOnly = true;
			this.ColumnPurchaseOrderListPreparedBy.Visible = false;
			this.ColumnPurchaseOrderListPreparedBy.Width = 150;
			// 
			// ColumnPurchaseOrderListCheckedBy
			// 
			this.ColumnPurchaseOrderListCheckedBy.DataPropertyName = "ColumnPurchaseOrderListCheckedBy";
			this.ColumnPurchaseOrderListCheckedBy.HeaderText = "Checked By";
			this.ColumnPurchaseOrderListCheckedBy.MinimumWidth = 8;
			this.ColumnPurchaseOrderListCheckedBy.Name = "ColumnPurchaseOrderListCheckedBy";
			this.ColumnPurchaseOrderListCheckedBy.ReadOnly = true;
			this.ColumnPurchaseOrderListCheckedBy.Visible = false;
			this.ColumnPurchaseOrderListCheckedBy.Width = 150;
			// 
			// ColumnPurchaseOrderListApprovedBy
			// 
			this.ColumnPurchaseOrderListApprovedBy.DataPropertyName = "ColumnPurchaseOrderListApprovedBy";
			this.ColumnPurchaseOrderListApprovedBy.HeaderText = "Approved By";
			this.ColumnPurchaseOrderListApprovedBy.MinimumWidth = 8;
			this.ColumnPurchaseOrderListApprovedBy.Name = "ColumnPurchaseOrderListApprovedBy";
			this.ColumnPurchaseOrderListApprovedBy.ReadOnly = true;
			this.ColumnPurchaseOrderListApprovedBy.Visible = false;
			this.ColumnPurchaseOrderListApprovedBy.Width = 150;
			// 
			// ColumnPurchaseOrderListIsLocked
			// 
			this.ColumnPurchaseOrderListIsLocked.DataPropertyName = "ColumnPurchaseOrderListIsLocked";
			this.ColumnPurchaseOrderListIsLocked.HeaderText = "L";
			this.ColumnPurchaseOrderListIsLocked.MinimumWidth = 8;
			this.ColumnPurchaseOrderListIsLocked.Name = "ColumnPurchaseOrderListIsLocked";
			this.ColumnPurchaseOrderListIsLocked.ReadOnly = true;
			this.ColumnPurchaseOrderListIsLocked.Width = 35;
			// 
			// ColumnPurchaseOrderListEntryUserId
			// 
			this.ColumnPurchaseOrderListEntryUserId.DataPropertyName = "ColumnPurchaseOrderListEntryUserId";
			this.ColumnPurchaseOrderListEntryUserId.HeaderText = "Entry User Id";
			this.ColumnPurchaseOrderListEntryUserId.MinimumWidth = 8;
			this.ColumnPurchaseOrderListEntryUserId.Name = "ColumnPurchaseOrderListEntryUserId";
			this.ColumnPurchaseOrderListEntryUserId.ReadOnly = true;
			this.ColumnPurchaseOrderListEntryUserId.Visible = false;
			this.ColumnPurchaseOrderListEntryUserId.Width = 150;
			// 
			// ColumnPurchaseOrderListEntryDateTime
			// 
			this.ColumnPurchaseOrderListEntryDateTime.DataPropertyName = "ColumnPurchaseOrderListEntryDateTime";
			this.ColumnPurchaseOrderListEntryDateTime.HeaderText = "Entry Date Time";
			this.ColumnPurchaseOrderListEntryDateTime.MinimumWidth = 8;
			this.ColumnPurchaseOrderListEntryDateTime.Name = "ColumnPurchaseOrderListEntryDateTime";
			this.ColumnPurchaseOrderListEntryDateTime.ReadOnly = true;
			this.ColumnPurchaseOrderListEntryDateTime.Visible = false;
			this.ColumnPurchaseOrderListEntryDateTime.Width = 150;
			// 
			// ColumnPurchaseOrderListUpdateUserId
			// 
			this.ColumnPurchaseOrderListUpdateUserId.DataPropertyName = "ColumnPurchaseOrderListUpdateUserId";
			this.ColumnPurchaseOrderListUpdateUserId.HeaderText = "Update User Id";
			this.ColumnPurchaseOrderListUpdateUserId.MinimumWidth = 8;
			this.ColumnPurchaseOrderListUpdateUserId.Name = "ColumnPurchaseOrderListUpdateUserId";
			this.ColumnPurchaseOrderListUpdateUserId.ReadOnly = true;
			this.ColumnPurchaseOrderListUpdateUserId.Visible = false;
			this.ColumnPurchaseOrderListUpdateUserId.Width = 150;
			// 
			// ColumnPurchaseOrderListUpdateDateTime
			// 
			this.ColumnPurchaseOrderListUpdateDateTime.DataPropertyName = "ColumnPurchaseOrderListUpdateDateTime";
			this.ColumnPurchaseOrderListUpdateDateTime.HeaderText = "Update Date Time";
			this.ColumnPurchaseOrderListUpdateDateTime.MinimumWidth = 8;
			this.ColumnPurchaseOrderListUpdateDateTime.Name = "ColumnPurchaseOrderListUpdateDateTime";
			this.ColumnPurchaseOrderListUpdateDateTime.ReadOnly = true;
			this.ColumnPurchaseOrderListUpdateDateTime.Visible = false;
			this.ColumnPurchaseOrderListUpdateDateTime.Width = 150;
			// 
			// ColumnPurchaseOrderListRequestedBy
			// 
			this.ColumnPurchaseOrderListRequestedBy.DataPropertyName = "ColumnPurchaseOrderListRequestedBy";
			this.ColumnPurchaseOrderListRequestedBy.HeaderText = "Requested By";
			this.ColumnPurchaseOrderListRequestedBy.MinimumWidth = 8;
			this.ColumnPurchaseOrderListRequestedBy.Name = "ColumnPurchaseOrderListRequestedBy";
			this.ColumnPurchaseOrderListRequestedBy.ReadOnly = true;
			this.ColumnPurchaseOrderListRequestedBy.Visible = false;
			this.ColumnPurchaseOrderListRequestedBy.Width = 150;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Controls.Add(this.buttonPurchaseOrderListPageListFirst);
			this.panel3.Controls.Add(this.buttonPurchaseOrderListPageListPrevious);
			this.panel3.Controls.Add(this.buttonPurchaseOrderListPageListNext);
			this.panel3.Controls.Add(this.buttonPurchaseOrderListPageListLast);
			this.panel3.Controls.Add(this.textBoxPurchaseOrderListPageNumber);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 753);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1620, 63);
			this.panel3.TabIndex = 22;
			// 
			// buttonPurchaseOrderListPageListFirst
			// 
			this.buttonPurchaseOrderListPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPurchaseOrderListPageListFirst.Enabled = false;
			this.buttonPurchaseOrderListPageListFirst.FlatAppearance.BorderSize = 0;
			this.buttonPurchaseOrderListPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPurchaseOrderListPageListFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.buttonPurchaseOrderListPageListFirst.Location = new System.Drawing.Point(15, 14);
			this.buttonPurchaseOrderListPageListFirst.Name = "buttonPurchaseOrderListPageListFirst";
			this.buttonPurchaseOrderListPageListFirst.Size = new System.Drawing.Size(99, 39);
			this.buttonPurchaseOrderListPageListFirst.TabIndex = 13;
			this.buttonPurchaseOrderListPageListFirst.Text = "First";
			this.buttonPurchaseOrderListPageListFirst.UseVisualStyleBackColor = false;
			this.buttonPurchaseOrderListPageListFirst.Click += new System.EventHandler(this.buttonPurchaseOrderListPageListFirst_Click);
			// 
			// buttonPurchaseOrderListPageListPrevious
			// 
			this.buttonPurchaseOrderListPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPurchaseOrderListPageListPrevious.Enabled = false;
			this.buttonPurchaseOrderListPageListPrevious.FlatAppearance.BorderSize = 0;
			this.buttonPurchaseOrderListPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPurchaseOrderListPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.buttonPurchaseOrderListPageListPrevious.Location = new System.Drawing.Point(120, 14);
			this.buttonPurchaseOrderListPageListPrevious.Name = "buttonPurchaseOrderListPageListPrevious";
			this.buttonPurchaseOrderListPageListPrevious.Size = new System.Drawing.Size(99, 39);
			this.buttonPurchaseOrderListPageListPrevious.TabIndex = 14;
			this.buttonPurchaseOrderListPageListPrevious.Text = "Previous";
			this.buttonPurchaseOrderListPageListPrevious.UseVisualStyleBackColor = false;
			this.buttonPurchaseOrderListPageListPrevious.Click += new System.EventHandler(this.buttonPurchaseOrderListPageListPrevious_Click);
			// 
			// buttonPurchaseOrderListPageListNext
			// 
			this.buttonPurchaseOrderListPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPurchaseOrderListPageListNext.FlatAppearance.BorderSize = 0;
			this.buttonPurchaseOrderListPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPurchaseOrderListPageListNext.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.buttonPurchaseOrderListPageListNext.Location = new System.Drawing.Point(315, 14);
			this.buttonPurchaseOrderListPageListNext.Name = "buttonPurchaseOrderListPageListNext";
			this.buttonPurchaseOrderListPageListNext.Size = new System.Drawing.Size(99, 39);
			this.buttonPurchaseOrderListPageListNext.TabIndex = 15;
			this.buttonPurchaseOrderListPageListNext.Text = "Next";
			this.buttonPurchaseOrderListPageListNext.UseVisualStyleBackColor = false;
			this.buttonPurchaseOrderListPageListNext.Click += new System.EventHandler(this.buttonPurchaseOrderListPageListNext_Click);
			// 
			// buttonPurchaseOrderListPageListLast
			// 
			this.buttonPurchaseOrderListPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPurchaseOrderListPageListLast.FlatAppearance.BorderSize = 0;
			this.buttonPurchaseOrderListPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPurchaseOrderListPageListLast.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.buttonPurchaseOrderListPageListLast.Location = new System.Drawing.Point(417, 14);
			this.buttonPurchaseOrderListPageListLast.Name = "buttonPurchaseOrderListPageListLast";
			this.buttonPurchaseOrderListPageListLast.Size = new System.Drawing.Size(99, 39);
			this.buttonPurchaseOrderListPageListLast.TabIndex = 16;
			this.buttonPurchaseOrderListPageListLast.Text = "Last";
			this.buttonPurchaseOrderListPageListLast.UseVisualStyleBackColor = false;
			this.buttonPurchaseOrderListPageListLast.Click += new System.EventHandler(this.buttonPurchaseOrderListPageListLast_Click);
			// 
			// textBoxPurchaseOrderListPageNumber
			// 
			this.textBoxPurchaseOrderListPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxPurchaseOrderListPageNumber.BackColor = System.Drawing.Color.White;
			this.textBoxPurchaseOrderListPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPurchaseOrderListPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.textBoxPurchaseOrderListPageNumber.Location = new System.Drawing.Point(225, 20);
			this.textBoxPurchaseOrderListPageNumber.Name = "textBoxPurchaseOrderListPageNumber";
			this.textBoxPurchaseOrderListPageNumber.ReadOnly = true;
			this.textBoxPurchaseOrderListPageNumber.Size = new System.Drawing.Size(82, 24);
			this.textBoxPurchaseOrderListPageNumber.TabIndex = 17;
			this.textBoxPurchaseOrderListPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TrnPurchaseOrderListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1620, 816);
			this.ControlBox = false;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.dataGridViewPurchaseOrderList);
			this.Controls.Add(this.textBoxPurchaseOrderListFilter);
			this.Controls.Add(this.dateTimePickerPurchaseOrderListFilter);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TrnPurchaseOrderListForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseOrderList)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseOrderListFilter;
        private System.Windows.Forms.TextBox textBoxPurchaseOrderListFilter;
        private System.Windows.Forms.DataGridView dataGridViewPurchaseOrderList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonPurchaseOrderListPageListFirst;
        private System.Windows.Forms.Button buttonPurchaseOrderListPageListPrevious;
        private System.Windows.Forms.Button buttonPurchaseOrderListPageListNext;
        private System.Windows.Forms.Button buttonPurchaseOrderListPageListLast;
        private System.Windows.Forms.TextBox textBoxPurchaseOrderListPageNumber;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnPurchaseOrderListButtonEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnPurchaseOrderListButtonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListPeriodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListPurchaseOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListPurchaseOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListPreparedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListCheckedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListApprovedBy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnPurchaseOrderListIsLocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListEntryUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListEntryDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListUpdateUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListUpdateDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderListRequestedBy;
    }
}