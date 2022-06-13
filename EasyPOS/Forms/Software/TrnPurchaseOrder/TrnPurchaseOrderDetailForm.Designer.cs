namespace EasyPOS.Forms.Software.TrnPurchaseOrder
{
    partial class TrnPurchaseOrderDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStockIn = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonLock = new System.Windows.Forms.Button();
            this.buttonUnlock = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.Forms = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxApprovedBy = new System.Windows.Forms.ComboBox();
            this.comboBoxCheckedBy = new System.Windows.Forms.ComboBox();
            this.comboBoxPreparedBy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPurchaseOrderDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPurchaseOrderNumber = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonPurchaseOrderLineListPageListFirst = new System.Windows.Forms.Button();
            this.buttonPurchaseOrderLineListPageListPrevious = new System.Windows.Forms.Button();
            this.buttonPurchaseOrderLineListPageListNext = new System.Windows.Forms.Button();
            this.buttonPurchaseOrderLineListPageListLast = new System.Windows.Forms.Button();
            this.textBoxPurchaseOrderLineListPageNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSearchItem = new System.Windows.Forms.Button();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.buttonBarcode = new System.Windows.Forms.Button();
            this.dataGridViewPurchaseOrderLineList = new System.Windows.Forms.DataGridView();
            this.ColumnPurchaseOrderLineListButtonEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnPurchaseOrderLineListButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnPurchaseOrderLineListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPurchaseOrderLineListPurchaseOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPurchaseOrderLineListItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPurchaseOrderLineListItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPurchaseOrderLineListUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPurchaseOrderLineListUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPurchaseOrderLineListQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPurchaseOrderLineListCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPurchaseOrderLineListAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPurchaseOrderLineListReceivedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Forms.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseOrderLineList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonStockIn);
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Controls.Add(this.buttonLock);
            this.panel1.Controls.Add(this.buttonUnlock);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1644, 75);
            this.panel1.TabIndex = 8;
            // 
            // buttonStockIn
            // 
            this.buttonStockIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonStockIn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonStockIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonStockIn.FlatAppearance.BorderSize = 0;
            this.buttonStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStockIn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStockIn.ForeColor = System.Drawing.Color.White;
            this.buttonStockIn.Location = new System.Drawing.Point(1070, 15);
            this.buttonStockIn.Name = "buttonStockIn";
            this.buttonStockIn.Size = new System.Drawing.Size(116, 48);
            this.buttonStockIn.TabIndex = 25;
            this.buttonStockIn.TabStop = false;
            this.buttonStockIn.Text = "Stock-In";
            this.buttonStockIn.UseVisualStyleBackColor = false;
            this.buttonStockIn.Click += new System.EventHandler(this.buttonStockIn_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonPrint.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(1413, 15);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(105, 48);
            this.buttonPrint.TabIndex = 24;
            this.buttonPrint.TabStop = false;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonLock
            // 
            this.buttonLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonLock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonLock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonLock.FlatAppearance.BorderSize = 0;
            this.buttonLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLock.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLock.ForeColor = System.Drawing.Color.White;
            this.buttonLock.Location = new System.Drawing.Point(1191, 15);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(105, 48);
            this.buttonLock.TabIndex = 20;
            this.buttonLock.TabStop = false;
            this.buttonLock.Text = "Lock";
            this.buttonLock.UseVisualStyleBackColor = false;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // buttonUnlock
            // 
            this.buttonUnlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonUnlock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonUnlock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonUnlock.FlatAppearance.BorderSize = 0;
            this.buttonUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnlock.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnlock.ForeColor = System.Drawing.Color.White;
            this.buttonUnlock.Location = new System.Drawing.Point(1302, 15);
            this.buttonUnlock.Name = "buttonUnlock";
            this.buttonUnlock.Size = new System.Drawing.Size(105, 48);
            this.buttonUnlock.TabIndex = 21;
            this.buttonUnlock.TabStop = false;
            this.buttonUnlock.Text = "Unlock";
            this.buttonUnlock.UseVisualStyleBackColor = false;
            this.buttonUnlock.Click += new System.EventHandler(this.buttonUnlock_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
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
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(75, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Purchase Order Detail";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(79)))), ((int)(((byte)(28)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(1524, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 48);
            this.buttonClose.TabIndex = 23;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Forms
            // 
            this.Forms.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Forms.Controls.Add(this.label3);
            this.Forms.Controls.Add(this.comboBoxStatus);
            this.Forms.Controls.Add(this.textBoxRemarks);
            this.Forms.Controls.Add(this.label13);
            this.Forms.Controls.Add(this.label12);
            this.Forms.Controls.Add(this.label11);
            this.Forms.Controls.Add(this.comboBoxApprovedBy);
            this.Forms.Controls.Add(this.comboBoxCheckedBy);
            this.Forms.Controls.Add(this.comboBoxPreparedBy);
            this.Forms.Controls.Add(this.label7);
            this.Forms.Controls.Add(this.label5);
            this.Forms.Controls.Add(this.label4);
            this.Forms.Controls.Add(this.label2);
            this.Forms.Controls.Add(this.comboBoxSupplier);
            this.Forms.Controls.Add(this.dateTimePickerPurchaseOrderDate);
            this.Forms.Controls.Add(this.textBoxPurchaseOrderNumber);
            this.Forms.Dock = System.Windows.Forms.DockStyle.Top;
            this.Forms.Location = new System.Drawing.Point(0, 75);
            this.Forms.Name = "Forms";
            this.Forms.Padding = new System.Windows.Forms.Padding(12);
            this.Forms.Size = new System.Drawing.Size(1644, 266);
            this.Forms.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(770, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 25;
            this.label3.Text = "Status:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(855, 141);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(344, 36);
            this.comboBoxStatus.TabIndex = 24;
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxRemarks.Location = new System.Drawing.Point(272, 147);
            this.textBoxRemarks.Multiline = true;
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(356, 80);
            this.textBoxRemarks.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label13.Location = new System.Drawing.Point(708, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 30);
            this.label13.TabIndex = 23;
            this.label13.Text = "Approved by:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label12.Location = new System.Drawing.Point(720, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 30);
            this.label12.TabIndex = 22;
            this.label12.Text = "Checked by:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label11.Location = new System.Drawing.Point(716, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 30);
            this.label11.TabIndex = 21;
            this.label11.Text = "Prepared by:";
            // 
            // comboBoxApprovedBy
            // 
            this.comboBoxApprovedBy.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxApprovedBy.FormattingEnabled = true;
            this.comboBoxApprovedBy.Location = new System.Drawing.Point(855, 94);
            this.comboBoxApprovedBy.Name = "comboBoxApprovedBy";
            this.comboBoxApprovedBy.Size = new System.Drawing.Size(344, 36);
            this.comboBoxApprovedBy.TabIndex = 10;
            // 
            // comboBoxCheckedBy
            // 
            this.comboBoxCheckedBy.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxCheckedBy.FormattingEnabled = true;
            this.comboBoxCheckedBy.Location = new System.Drawing.Point(855, 50);
            this.comboBoxCheckedBy.Name = "comboBoxCheckedBy";
            this.comboBoxCheckedBy.Size = new System.Drawing.Size(344, 36);
            this.comboBoxCheckedBy.TabIndex = 9;
            // 
            // comboBoxPreparedBy
            // 
            this.comboBoxPreparedBy.Enabled = false;
            this.comboBoxPreparedBy.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxPreparedBy.FormattingEnabled = true;
            this.comboBoxPreparedBy.Location = new System.Drawing.Point(855, 6);
            this.comboBoxPreparedBy.Name = "comboBoxPreparedBy";
            this.comboBoxPreparedBy.Size = new System.Drawing.Size(344, 36);
            this.comboBoxPreparedBy.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(170, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "Remarks:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(176, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Supplier:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(56, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Purchase Order Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(26, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Purchase Order Number:";
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(272, 99);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(356, 36);
            this.comboBoxSupplier.TabIndex = 2;
            // 
            // dateTimePickerPurchaseOrderDate
            // 
            this.dateTimePickerPurchaseOrderDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dateTimePickerPurchaseOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPurchaseOrderDate.Location = new System.Drawing.Point(272, 51);
            this.dateTimePickerPurchaseOrderDate.Name = "dateTimePickerPurchaseOrderDate";
            this.dateTimePickerPurchaseOrderDate.Size = new System.Drawing.Size(235, 35);
            this.dateTimePickerPurchaseOrderDate.TabIndex = 1;
            // 
            // textBoxPurchaseOrderNumber
            // 
            this.textBoxPurchaseOrderNumber.Enabled = false;
            this.textBoxPurchaseOrderNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxPurchaseOrderNumber.Location = new System.Drawing.Point(272, 6);
            this.textBoxPurchaseOrderNumber.Name = "textBoxPurchaseOrderNumber";
            this.textBoxPurchaseOrderNumber.Size = new System.Drawing.Size(235, 35);
            this.textBoxPurchaseOrderNumber.TabIndex = 0;
            this.textBoxPurchaseOrderNumber.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.textBoxTotalAmount);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.buttonPurchaseOrderLineListPageListFirst);
            this.panel4.Controls.Add(this.buttonPurchaseOrderLineListPageListPrevious);
            this.panel4.Controls.Add(this.buttonPurchaseOrderLineListPageListNext);
            this.panel4.Controls.Add(this.buttonPurchaseOrderLineListPageListLast);
            this.panel4.Controls.Add(this.textBoxPurchaseOrderLineListPageNumber);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 777);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1644, 63);
            this.panel4.TabIndex = 26;
            // 
            // buttonPurchaseOrderLineListPageListFirst
            // 
            this.buttonPurchaseOrderLineListPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPurchaseOrderLineListPageListFirst.Enabled = false;
            this.buttonPurchaseOrderLineListPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonPurchaseOrderLineListPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchaseOrderLineListPageListFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPurchaseOrderLineListPageListFirst.Location = new System.Drawing.Point(15, 14);
            this.buttonPurchaseOrderLineListPageListFirst.Name = "buttonPurchaseOrderLineListPageListFirst";
            this.buttonPurchaseOrderLineListPageListFirst.Size = new System.Drawing.Size(99, 39);
            this.buttonPurchaseOrderLineListPageListFirst.TabIndex = 13;
            this.buttonPurchaseOrderLineListPageListFirst.TabStop = false;
            this.buttonPurchaseOrderLineListPageListFirst.Text = "First";
            this.buttonPurchaseOrderLineListPageListFirst.UseVisualStyleBackColor = false;
            this.buttonPurchaseOrderLineListPageListFirst.Click += new System.EventHandler(this.buttonPurchaseOrderLineListPageListFirst_Click);
            // 
            // buttonPurchaseOrderLineListPageListPrevious
            // 
            this.buttonPurchaseOrderLineListPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPurchaseOrderLineListPageListPrevious.Enabled = false;
            this.buttonPurchaseOrderLineListPageListPrevious.FlatAppearance.BorderSize = 0;
            this.buttonPurchaseOrderLineListPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchaseOrderLineListPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPurchaseOrderLineListPageListPrevious.Location = new System.Drawing.Point(120, 14);
            this.buttonPurchaseOrderLineListPageListPrevious.Name = "buttonPurchaseOrderLineListPageListPrevious";
            this.buttonPurchaseOrderLineListPageListPrevious.Size = new System.Drawing.Size(99, 39);
            this.buttonPurchaseOrderLineListPageListPrevious.TabIndex = 14;
            this.buttonPurchaseOrderLineListPageListPrevious.TabStop = false;
            this.buttonPurchaseOrderLineListPageListPrevious.Text = "Previous";
            this.buttonPurchaseOrderLineListPageListPrevious.UseVisualStyleBackColor = false;
            this.buttonPurchaseOrderLineListPageListPrevious.Click += new System.EventHandler(this.buttonPurchaseOrderLineListPageListPrevious_Click);
            // 
            // buttonPurchaseOrderLineListPageListNext
            // 
            this.buttonPurchaseOrderLineListPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPurchaseOrderLineListPageListNext.FlatAppearance.BorderSize = 0;
            this.buttonPurchaseOrderLineListPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchaseOrderLineListPageListNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPurchaseOrderLineListPageListNext.Location = new System.Drawing.Point(315, 14);
            this.buttonPurchaseOrderLineListPageListNext.Name = "buttonPurchaseOrderLineListPageListNext";
            this.buttonPurchaseOrderLineListPageListNext.Size = new System.Drawing.Size(99, 39);
            this.buttonPurchaseOrderLineListPageListNext.TabIndex = 15;
            this.buttonPurchaseOrderLineListPageListNext.TabStop = false;
            this.buttonPurchaseOrderLineListPageListNext.Text = "Next";
            this.buttonPurchaseOrderLineListPageListNext.UseVisualStyleBackColor = false;
            this.buttonPurchaseOrderLineListPageListNext.Click += new System.EventHandler(this.buttonPurchaseOrderLineListPageListNext_Click);
            // 
            // buttonPurchaseOrderLineListPageListLast
            // 
            this.buttonPurchaseOrderLineListPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPurchaseOrderLineListPageListLast.FlatAppearance.BorderSize = 0;
            this.buttonPurchaseOrderLineListPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchaseOrderLineListPageListLast.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPurchaseOrderLineListPageListLast.Location = new System.Drawing.Point(417, 14);
            this.buttonPurchaseOrderLineListPageListLast.Name = "buttonPurchaseOrderLineListPageListLast";
            this.buttonPurchaseOrderLineListPageListLast.Size = new System.Drawing.Size(99, 39);
            this.buttonPurchaseOrderLineListPageListLast.TabIndex = 16;
            this.buttonPurchaseOrderLineListPageListLast.TabStop = false;
            this.buttonPurchaseOrderLineListPageListLast.Text = "Last";
            this.buttonPurchaseOrderLineListPageListLast.UseVisualStyleBackColor = false;
            this.buttonPurchaseOrderLineListPageListLast.Click += new System.EventHandler(this.buttonPurchaseOrderLineListPageListLast_Click);
            // 
            // textBoxPurchaseOrderLineListPageNumber
            // 
            this.textBoxPurchaseOrderLineListPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPurchaseOrderLineListPageNumber.BackColor = System.Drawing.Color.White;
            this.textBoxPurchaseOrderLineListPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPurchaseOrderLineListPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPurchaseOrderLineListPageNumber.Location = new System.Drawing.Point(225, 20);
            this.textBoxPurchaseOrderLineListPageNumber.Name = "textBoxPurchaseOrderLineListPageNumber";
            this.textBoxPurchaseOrderLineListPageNumber.ReadOnly = true;
            this.textBoxPurchaseOrderLineListPageNumber.Size = new System.Drawing.Size(82, 24);
            this.textBoxPurchaseOrderLineListPageNumber.TabIndex = 17;
            this.textBoxPurchaseOrderLineListPageNumber.TabStop = false;
            this.textBoxPurchaseOrderLineListPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSearchItem);
            this.panel2.Controls.Add(this.textBoxBarcode);
            this.panel2.Controls.Add(this.buttonBarcode);
            this.panel2.Controls.Add(this.dataGridViewPurchaseOrderLineList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1644, 436);
            this.panel2.TabIndex = 27;
            // 
            // buttonSearchItem
            // 
            this.buttonSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.buttonSearchItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(34)))), ((int)(((byte)(116)))));
            this.buttonSearchItem.FlatAppearance.BorderSize = 0;
            this.buttonSearchItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonSearchItem.ForeColor = System.Drawing.Color.White;
            this.buttonSearchItem.Location = new System.Drawing.Point(1413, 6);
            this.buttonSearchItem.Name = "buttonSearchItem";
            this.buttonSearchItem.Size = new System.Drawing.Size(216, 48);
            this.buttonSearchItem.TabIndex = 33;
            this.buttonSearchItem.TabStop = false;
            this.buttonSearchItem.Text = "Search Item";
            this.buttonSearchItem.UseVisualStyleBackColor = false;
            this.buttonSearchItem.Click += new System.EventHandler(this.buttonSearchItem_Click);
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 13.3F, System.Drawing.FontStyle.Bold);
            this.textBoxBarcode.Location = new System.Drawing.Point(256, 6);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(1148, 43);
            this.textBoxBarcode.TabIndex = 32;
            this.textBoxBarcode.TabStop = false;
            this.textBoxBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBarcode_KeyDown);
            // 
            // buttonBarcode
            // 
            this.buttonBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.buttonBarcode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(34)))), ((int)(((byte)(116)))));
            this.buttonBarcode.FlatAppearance.BorderSize = 0;
            this.buttonBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarcode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonBarcode.ForeColor = System.Drawing.Color.White;
            this.buttonBarcode.Location = new System.Drawing.Point(15, 6);
            this.buttonBarcode.Name = "buttonBarcode";
            this.buttonBarcode.Size = new System.Drawing.Size(236, 48);
            this.buttonBarcode.TabIndex = 31;
            this.buttonBarcode.TabStop = false;
            this.buttonBarcode.Text = "Barcode";
            this.buttonBarcode.UseVisualStyleBackColor = false;
            this.buttonBarcode.Click += new System.EventHandler(this.buttonBarcode_Click);
            // 
            // dataGridViewPurchaseOrderLineList
            // 
            this.dataGridViewPurchaseOrderLineList.AllowUserToAddRows = false;
            this.dataGridViewPurchaseOrderLineList.AllowUserToDeleteRows = false;
            this.dataGridViewPurchaseOrderLineList.AllowUserToResizeRows = false;
            this.dataGridViewPurchaseOrderLineList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPurchaseOrderLineList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPurchaseOrderLineList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPurchaseOrderLineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchaseOrderLineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPurchaseOrderLineListButtonEdit,
            this.ColumnPurchaseOrderLineListButtonDelete,
            this.ColumnPurchaseOrderLineListId,
            this.ColumnPurchaseOrderLineListPurchaseOrderId,
            this.ColumnPurchaseOrderLineListItemId,
            this.ColumnPurchaseOrderLineListItemDescription,
            this.ColumnPurchaseOrderLineListUnitId,
            this.ColumnPurchaseOrderLineListUnit,
            this.ColumnPurchaseOrderLineListQuantity,
            this.ColumnPurchaseOrderLineListCost,
            this.ColumnPurchaseOrderLineListAmount,
            this.ColumnPurchaseOrderLineListReceivedQuantity});
            this.dataGridViewPurchaseOrderLineList.Location = new System.Drawing.Point(15, 59);
            this.dataGridViewPurchaseOrderLineList.MultiSelect = false;
            this.dataGridViewPurchaseOrderLineList.Name = "dataGridViewPurchaseOrderLineList";
            this.dataGridViewPurchaseOrderLineList.RowHeadersWidth = 62;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dataGridViewPurchaseOrderLineList.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewPurchaseOrderLineList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dataGridViewPurchaseOrderLineList.RowTemplate.Height = 24;
            this.dataGridViewPurchaseOrderLineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPurchaseOrderLineList.Size = new System.Drawing.Size(1612, 372);
            this.dataGridViewPurchaseOrderLineList.TabIndex = 30;
            this.dataGridViewPurchaseOrderLineList.TabStop = false;
            this.dataGridViewPurchaseOrderLineList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPurchaseOrderLineList_CellClick);
            this.dataGridViewPurchaseOrderLineList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPurchaseOrderLineList_CellEndEdit);
            // 
            // ColumnPurchaseOrderLineListButtonEdit
            // 
            this.ColumnPurchaseOrderLineListButtonEdit.DataPropertyName = "ColumnPurchaseOrderLineListButtonEdit";
            this.ColumnPurchaseOrderLineListButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnPurchaseOrderLineListButtonEdit.HeaderText = "";
            this.ColumnPurchaseOrderLineListButtonEdit.MinimumWidth = 8;
            this.ColumnPurchaseOrderLineListButtonEdit.Name = "ColumnPurchaseOrderLineListButtonEdit";
            this.ColumnPurchaseOrderLineListButtonEdit.ReadOnly = true;
            this.ColumnPurchaseOrderLineListButtonEdit.Width = 70;
            // 
            // ColumnPurchaseOrderLineListButtonDelete
            // 
            this.ColumnPurchaseOrderLineListButtonDelete.DataPropertyName = "ColumnPurchaseOrderLineListButtonDelete";
            this.ColumnPurchaseOrderLineListButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnPurchaseOrderLineListButtonDelete.HeaderText = "";
            this.ColumnPurchaseOrderLineListButtonDelete.MinimumWidth = 8;
            this.ColumnPurchaseOrderLineListButtonDelete.Name = "ColumnPurchaseOrderLineListButtonDelete";
            this.ColumnPurchaseOrderLineListButtonDelete.ReadOnly = true;
            this.ColumnPurchaseOrderLineListButtonDelete.Width = 70;
            // 
            // ColumnPurchaseOrderLineListId
            // 
            this.ColumnPurchaseOrderLineListId.DataPropertyName = "ColumnPurchaseOrderLineListId";
            this.ColumnPurchaseOrderLineListId.HeaderText = "Id";
            this.ColumnPurchaseOrderLineListId.MinimumWidth = 8;
            this.ColumnPurchaseOrderLineListId.Name = "ColumnPurchaseOrderLineListId";
            this.ColumnPurchaseOrderLineListId.ReadOnly = true;
            this.ColumnPurchaseOrderLineListId.Visible = false;
            this.ColumnPurchaseOrderLineListId.Width = 150;
            // 
            // ColumnPurchaseOrderLineListPurchaseOrderId
            // 
            this.ColumnPurchaseOrderLineListPurchaseOrderId.DataPropertyName = "ColumnPurchaseOrderLineListPurchaseOrderId";
            this.ColumnPurchaseOrderLineListPurchaseOrderId.HeaderText = "Purchase Order Id";
            this.ColumnPurchaseOrderLineListPurchaseOrderId.MinimumWidth = 8;
            this.ColumnPurchaseOrderLineListPurchaseOrderId.Name = "ColumnPurchaseOrderLineListPurchaseOrderId";
            this.ColumnPurchaseOrderLineListPurchaseOrderId.ReadOnly = true;
            this.ColumnPurchaseOrderLineListPurchaseOrderId.Visible = false;
            this.ColumnPurchaseOrderLineListPurchaseOrderId.Width = 150;
            // 
            // ColumnPurchaseOrderLineListItemId
            // 
            this.ColumnPurchaseOrderLineListItemId.DataPropertyName = "ColumnPurchaseOrderLineListItemId";
            this.ColumnPurchaseOrderLineListItemId.HeaderText = "Item Id";
            this.ColumnPurchaseOrderLineListItemId.MinimumWidth = 8;
            this.ColumnPurchaseOrderLineListItemId.Name = "ColumnPurchaseOrderLineListItemId";
            this.ColumnPurchaseOrderLineListItemId.ReadOnly = true;
            this.ColumnPurchaseOrderLineListItemId.Visible = false;
            this.ColumnPurchaseOrderLineListItemId.Width = 150;
            // 
            // ColumnPurchaseOrderLineListItemDescription
            // 
            this.ColumnPurchaseOrderLineListItemDescription.DataPropertyName = "ColumnPurchaseOrderLineListItemDescription";
            this.ColumnPurchaseOrderLineListItemDescription.HeaderText = "Item Description";
            this.ColumnPurchaseOrderLineListItemDescription.MinimumWidth = 8;
            this.ColumnPurchaseOrderLineListItemDescription.Name = "ColumnPurchaseOrderLineListItemDescription";
            this.ColumnPurchaseOrderLineListItemDescription.ReadOnly = true;
            this.ColumnPurchaseOrderLineListItemDescription.Width = 200;
            // 
            // ColumnPurchaseOrderLineListUnitId
            // 
            this.ColumnPurchaseOrderLineListUnitId.DataPropertyName = "ColumnPurchaseOrderLineListUnitId";
            this.ColumnPurchaseOrderLineListUnitId.HeaderText = "Unit Id";
            this.ColumnPurchaseOrderLineListUnitId.MinimumWidth = 8;
            this.ColumnPurchaseOrderLineListUnitId.Name = "ColumnPurchaseOrderLineListUnitId";
            this.ColumnPurchaseOrderLineListUnitId.ReadOnly = true;
            this.ColumnPurchaseOrderLineListUnitId.Visible = false;
            this.ColumnPurchaseOrderLineListUnitId.Width = 150;
            // 
            // ColumnPurchaseOrderLineListUnit
            // 
            this.ColumnPurchaseOrderLineListUnit.DataPropertyName = "ColumnPurchaseOrderLineListUnit";
            this.ColumnPurchaseOrderLineListUnit.HeaderText = "Unit";
            this.ColumnPurchaseOrderLineListUnit.MinimumWidth = 8;
            this.ColumnPurchaseOrderLineListUnit.Name = "ColumnPurchaseOrderLineListUnit";
            this.ColumnPurchaseOrderLineListUnit.ReadOnly = true;
            this.ColumnPurchaseOrderLineListUnit.Width = 150;
            // 
            // ColumnPurchaseOrderLineListQuantity
            // 
            this.ColumnPurchaseOrderLineListQuantity.DataPropertyName = "ColumnPurchaseOrderLineListQuantity";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnPurchaseOrderLineListQuantity.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnPurchaseOrderLineListQuantity.HeaderText = "Quantity";
            this.ColumnPurchaseOrderLineListQuantity.MinimumWidth = 8;
            this.ColumnPurchaseOrderLineListQuantity.Name = "ColumnPurchaseOrderLineListQuantity";
            this.ColumnPurchaseOrderLineListQuantity.ReadOnly = true;
            this.ColumnPurchaseOrderLineListQuantity.Width = 150;
            // 
            // ColumnPurchaseOrderLineListCost
            // 
            this.ColumnPurchaseOrderLineListCost.DataPropertyName = "ColumnPurchaseOrderLineListCost";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnPurchaseOrderLineListCost.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnPurchaseOrderLineListCost.HeaderText = "Cost";
            this.ColumnPurchaseOrderLineListCost.MinimumWidth = 8;
            this.ColumnPurchaseOrderLineListCost.Name = "ColumnPurchaseOrderLineListCost";
            this.ColumnPurchaseOrderLineListCost.ReadOnly = true;
            this.ColumnPurchaseOrderLineListCost.Width = 150;
            // 
            // ColumnPurchaseOrderLineListAmount
            // 
            this.ColumnPurchaseOrderLineListAmount.DataPropertyName = "ColumnPurchaseOrderLineListAmount";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnPurchaseOrderLineListAmount.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnPurchaseOrderLineListAmount.HeaderText = "Amount";
            this.ColumnPurchaseOrderLineListAmount.MinimumWidth = 8;
            this.ColumnPurchaseOrderLineListAmount.Name = "ColumnPurchaseOrderLineListAmount";
            this.ColumnPurchaseOrderLineListAmount.ReadOnly = true;
            this.ColumnPurchaseOrderLineListAmount.Width = 150;
            // 
            // ColumnPurchaseOrderLineListReceivedQuantity
            // 
            this.ColumnPurchaseOrderLineListReceivedQuantity.DataPropertyName = "ColumnPurchaseOrderLineListReceivedQuantity";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnPurchaseOrderLineListReceivedQuantity.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnPurchaseOrderLineListReceivedQuantity.HeaderText = "Received Qty.";
            this.ColumnPurchaseOrderLineListReceivedQuantity.MinimumWidth = 8;
            this.ColumnPurchaseOrderLineListReceivedQuantity.Name = "ColumnPurchaseOrderLineListReceivedQuantity";
            this.ColumnPurchaseOrderLineListReceivedQuantity.Width = 150;
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(1408, 14);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.ReadOnly = true;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(219, 35);
            this.textBoxTotalAmount.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1259, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total Amount:";
            // 
            // TrnPurchaseOrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1644, 840);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Forms);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrnPurchaseOrderDetailForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Forms.ResumeLayout(false);
            this.Forms.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchaseOrderLineList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Button buttonUnlock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel Forms;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxApprovedBy;
        private System.Windows.Forms.ComboBox comboBoxCheckedBy;
        private System.Windows.Forms.ComboBox comboBoxPreparedBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseOrderDate;
        private System.Windows.Forms.TextBox textBoxPurchaseOrderNumber;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonPurchaseOrderLineListPageListFirst;
        private System.Windows.Forms.Button buttonPurchaseOrderLineListPageListPrevious;
        private System.Windows.Forms.Button buttonPurchaseOrderLineListPageListNext;
        private System.Windows.Forms.Button buttonPurchaseOrderLineListPageListLast;
        private System.Windows.Forms.TextBox textBoxPurchaseOrderLineListPageNumber;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonStockIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSearchItem;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Button buttonBarcode;
        private System.Windows.Forms.DataGridView dataGridViewPurchaseOrderLineList;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnPurchaseOrderLineListButtonEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnPurchaseOrderLineListButtonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderLineListId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderLineListPurchaseOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderLineListItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderLineListItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderLineListUnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderLineListUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderLineListQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderLineListCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderLineListAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseOrderLineListReceivedQuantity;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Label label6;
    }
}