﻿namespace EasyPOS.Forms.Software.RepInventoryReport
{
    partial class RepStockInDetailReportForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepStockInDetailReportForm));
			this.folderBrowserDialogGenerateCSV = new System.Windows.Forms.FolderBrowserDialog();
			this.buttonGenerateCSV = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBoxFilter = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonPageListFirst = new System.Windows.Forms.Button();
			this.buttonPageListNext = new System.Windows.Forms.Button();
			this.buttonPageListLast = new System.Windows.Forms.Button();
			this.buttonPageListPrevious = new System.Windows.Forms.Button();
			this.textBoxPageNumber = new System.Windows.Forms.TextBox();
			this.dataGridViewStockInDetailReport = new System.Windows.Forms.DataGridView();
			this.ColumnItemListCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnItemListBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnStockInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnStockInNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnManualStockInNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnIsReturn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ColumnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnLotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockInDetailReport)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonGenerateCSV
			// 
			this.buttonGenerateCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGenerateCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
			this.buttonGenerateCSV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
			this.buttonGenerateCSV.FlatAppearance.BorderSize = 0;
			this.buttonGenerateCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGenerateCSV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGenerateCSV.ForeColor = System.Drawing.Color.White;
			this.buttonGenerateCSV.Location = new System.Drawing.Point(1410, 14);
			this.buttonGenerateCSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonGenerateCSV.Name = "buttonGenerateCSV";
			this.buttonGenerateCSV.Size = new System.Drawing.Size(105, 48);
			this.buttonGenerateCSV.TabIndex = 5;
			this.buttonGenerateCSV.TabStop = false;
			this.buttonGenerateCSV.Text = "CSV";
			this.buttonGenerateCSV.UseVisualStyleBackColor = false;
			this.buttonGenerateCSV.Click += new System.EventHandler(this.buttonGenerateCSV_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(86, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(328, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Stock In Detail Report";
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
			this.buttonClose.Location = new System.Drawing.Point(1522, 14);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(105, 48);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.TabStop = false;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_OnClick);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.textBoxFilter);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.dataGridViewStockInDetailReport);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 75);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1644, 708);
			this.panel2.TabIndex = 19;
			// 
			// textBoxFilter
			// 
			this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFilter.Location = new System.Drawing.Point(0, 3);
			this.textBoxFilter.Name = "textBoxFilter";
			this.textBoxFilter.Size = new System.Drawing.Size(1639, 35);
			this.textBoxFilter.TabIndex = 22;
			this.textBoxFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFilter_KeyDown);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.textBoxTotalAmount);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.buttonPageListFirst);
			this.panel4.Controls.Add(this.buttonPageListNext);
			this.panel4.Controls.Add(this.buttonPageListLast);
			this.panel4.Controls.Add(this.buttonPageListPrevious);
			this.panel4.Controls.Add(this.textBoxPageNumber);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 645);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1644, 63);
			this.panel4.TabIndex = 20;
			// 
			// textBoxTotalAmount
			// 
			this.textBoxTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTotalAmount.Location = new System.Drawing.Point(1200, 16);
			this.textBoxTotalAmount.Name = "textBoxTotalAmount";
			this.textBoxTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBoxTotalAmount.Size = new System.Drawing.Size(369, 28);
			this.textBoxTotalAmount.TabIndex = 15;
			this.textBoxTotalAmount.TabStop = false;
			this.textBoxTotalAmount.WordWrap = false;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1032, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 30);
			this.label2.TabIndex = 13;
			this.label2.Text = "Total Amount:";
			// 
			// buttonPageListFirst
			// 
			this.buttonPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPageListFirst.Enabled = false;
			this.buttonPageListFirst.FlatAppearance.BorderSize = 0;
			this.buttonPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPageListFirst.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.buttonPageListFirst.Location = new System.Drawing.Point(15, 10);
			this.buttonPageListFirst.Name = "buttonPageListFirst";
			this.buttonPageListFirst.Size = new System.Drawing.Size(99, 39);
			this.buttonPageListFirst.TabIndex = 8;
			this.buttonPageListFirst.TabStop = false;
			this.buttonPageListFirst.Text = "First";
			this.buttonPageListFirst.UseVisualStyleBackColor = false;
			this.buttonPageListFirst.Click += new System.EventHandler(this.buttonPageListFirst_Click);
			// 
			// buttonPageListNext
			// 
			this.buttonPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPageListNext.FlatAppearance.BorderSize = 0;
			this.buttonPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPageListNext.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.buttonPageListNext.Location = new System.Drawing.Point(405, 10);
			this.buttonPageListNext.Name = "buttonPageListNext";
			this.buttonPageListNext.Size = new System.Drawing.Size(99, 39);
			this.buttonPageListNext.TabIndex = 10;
			this.buttonPageListNext.TabStop = false;
			this.buttonPageListNext.Text = "Next";
			this.buttonPageListNext.UseVisualStyleBackColor = false;
			this.buttonPageListNext.Click += new System.EventHandler(this.buttonPageListNext_Click);
			// 
			// buttonPageListLast
			// 
			this.buttonPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPageListLast.FlatAppearance.BorderSize = 0;
			this.buttonPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPageListLast.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.buttonPageListLast.Location = new System.Drawing.Point(507, 10);
			this.buttonPageListLast.Name = "buttonPageListLast";
			this.buttonPageListLast.Size = new System.Drawing.Size(99, 39);
			this.buttonPageListLast.TabIndex = 11;
			this.buttonPageListLast.TabStop = false;
			this.buttonPageListLast.Text = "Last";
			this.buttonPageListLast.UseVisualStyleBackColor = false;
			this.buttonPageListLast.Click += new System.EventHandler(this.buttonPageListLast_Click);
			// 
			// buttonPageListPrevious
			// 
			this.buttonPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPageListPrevious.Enabled = false;
			this.buttonPageListPrevious.FlatAppearance.BorderSize = 0;
			this.buttonPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.buttonPageListPrevious.Location = new System.Drawing.Point(120, 10);
			this.buttonPageListPrevious.Name = "buttonPageListPrevious";
			this.buttonPageListPrevious.Size = new System.Drawing.Size(116, 39);
			this.buttonPageListPrevious.TabIndex = 9;
			this.buttonPageListPrevious.TabStop = false;
			this.buttonPageListPrevious.Text = "Previous";
			this.buttonPageListPrevious.UseVisualStyleBackColor = false;
			this.buttonPageListPrevious.Click += new System.EventHandler(this.buttonPageListPrevious_Click);
			// 
			// textBoxPageNumber
			// 
			this.textBoxPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxPageNumber.BackColor = System.Drawing.Color.White;
			this.textBoxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPageNumber.Location = new System.Drawing.Point(278, 16);
			this.textBoxPageNumber.Name = "textBoxPageNumber";
			this.textBoxPageNumber.ReadOnly = true;
			this.textBoxPageNumber.Size = new System.Drawing.Size(82, 28);
			this.textBoxPageNumber.TabIndex = 12;
			this.textBoxPageNumber.TabStop = false;
			this.textBoxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dataGridViewStockInDetailReport
			// 
			this.dataGridViewStockInDetailReport.AllowUserToAddRows = false;
			this.dataGridViewStockInDetailReport.AllowUserToDeleteRows = false;
			this.dataGridViewStockInDetailReport.AllowUserToResizeRows = false;
			this.dataGridViewStockInDetailReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewStockInDetailReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewStockInDetailReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStockInDetailReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItemListCode,
            this.ColumnItemListBarcode,
            this.ColumnStockInDate,
            this.ColumnStockInNumber,
            this.ColumnManualStockInNumber,
            this.ColumnRemarks,
            this.ColumnIsReturn,
            this.ColumnItem,
            this.ColumnUnit,
            this.ColumnQuantity,
            this.ColumnCost,
            this.ColumnAmount,
            this.ColumnExpiryDate,
            this.ColumnLotNumber,
            this.ColumnSellingPrice});
			this.dataGridViewStockInDetailReport.Location = new System.Drawing.Point(3, 45);
			this.dataGridViewStockInDetailReport.MultiSelect = false;
			this.dataGridViewStockInDetailReport.Name = "dataGridViewStockInDetailReport";
			this.dataGridViewStockInDetailReport.ReadOnly = true;
			this.dataGridViewStockInDetailReport.RowHeadersWidth = 62;
			this.dataGridViewStockInDetailReport.RowTemplate.Height = 24;
			this.dataGridViewStockInDetailReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewStockInDetailReport.ShowEditingIcon = false;
			this.dataGridViewStockInDetailReport.Size = new System.Drawing.Size(1638, 594);
			this.dataGridViewStockInDetailReport.TabIndex = 0;
			// 
			// ColumnItemListCode
			// 
			this.ColumnItemListCode.DataPropertyName = "ColumnItemListCode";
			this.ColumnItemListCode.HeaderText = "Item Code";
			this.ColumnItemListCode.MinimumWidth = 8;
			this.ColumnItemListCode.Name = "ColumnItemListCode";
			this.ColumnItemListCode.ReadOnly = true;
			this.ColumnItemListCode.Width = 150;
			// 
			// ColumnItemListBarcode
			// 
			this.ColumnItemListBarcode.DataPropertyName = "ColumnItemListBarcode";
			this.ColumnItemListBarcode.HeaderText = "Barcode";
			this.ColumnItemListBarcode.MinimumWidth = 8;
			this.ColumnItemListBarcode.Name = "ColumnItemListBarcode";
			this.ColumnItemListBarcode.ReadOnly = true;
			this.ColumnItemListBarcode.Width = 150;
			// 
			// ColumnStockInDate
			// 
			this.ColumnStockInDate.DataPropertyName = "ColumnStockInDate";
			this.ColumnStockInDate.HeaderText = "Stock In Date";
			this.ColumnStockInDate.MinimumWidth = 8;
			this.ColumnStockInDate.Name = "ColumnStockInDate";
			this.ColumnStockInDate.ReadOnly = true;
			this.ColumnStockInDate.Width = 120;
			// 
			// ColumnStockInNumber
			// 
			this.ColumnStockInNumber.DataPropertyName = "ColumnStockInNumber";
			this.ColumnStockInNumber.HeaderText = "Stock In No.";
			this.ColumnStockInNumber.MinimumWidth = 8;
			this.ColumnStockInNumber.Name = "ColumnStockInNumber";
			this.ColumnStockInNumber.ReadOnly = true;
			this.ColumnStockInNumber.Width = 120;
			// 
			// ColumnManualStockInNumber
			// 
			this.ColumnManualStockInNumber.DataPropertyName = "ColumnManualStockInNumber";
			this.ColumnManualStockInNumber.HeaderText = "Manual Stock In No.";
			this.ColumnManualStockInNumber.MinimumWidth = 8;
			this.ColumnManualStockInNumber.Name = "ColumnManualStockInNumber";
			this.ColumnManualStockInNumber.ReadOnly = true;
			this.ColumnManualStockInNumber.Width = 120;
			// 
			// ColumnRemarks
			// 
			this.ColumnRemarks.DataPropertyName = "ColumnRemarks";
			this.ColumnRemarks.HeaderText = "Remarks";
			this.ColumnRemarks.MinimumWidth = 8;
			this.ColumnRemarks.Name = "ColumnRemarks";
			this.ColumnRemarks.ReadOnly = true;
			this.ColumnRemarks.Width = 120;
			// 
			// ColumnIsReturn
			// 
			this.ColumnIsReturn.DataPropertyName = "ColumnIsReturn";
			this.ColumnIsReturn.HeaderText = "Return";
			this.ColumnIsReturn.MinimumWidth = 8;
			this.ColumnIsReturn.Name = "ColumnIsReturn";
			this.ColumnIsReturn.ReadOnly = true;
			this.ColumnIsReturn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColumnIsReturn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ColumnIsReturn.Width = 150;
			// 
			// ColumnItem
			// 
			this.ColumnItem.DataPropertyName = "ColumnItem";
			this.ColumnItem.HeaderText = "Item Description";
			this.ColumnItem.MinimumWidth = 8;
			this.ColumnItem.Name = "ColumnItem";
			this.ColumnItem.ReadOnly = true;
			this.ColumnItem.Width = 200;
			// 
			// ColumnUnit
			// 
			this.ColumnUnit.DataPropertyName = "ColumnUnit";
			this.ColumnUnit.HeaderText = "Unit";
			this.ColumnUnit.MinimumWidth = 8;
			this.ColumnUnit.Name = "ColumnUnit";
			this.ColumnUnit.ReadOnly = true;
			this.ColumnUnit.Width = 150;
			// 
			// ColumnQuantity
			// 
			this.ColumnQuantity.DataPropertyName = "ColumnQuantity";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ColumnQuantity.DefaultCellStyle = dataGridViewCellStyle1;
			this.ColumnQuantity.HeaderText = "Quantity";
			this.ColumnQuantity.MinimumWidth = 8;
			this.ColumnQuantity.Name = "ColumnQuantity";
			this.ColumnQuantity.ReadOnly = true;
			this.ColumnQuantity.Width = 120;
			// 
			// ColumnCost
			// 
			this.ColumnCost.DataPropertyName = "ColumnCost";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ColumnCost.DefaultCellStyle = dataGridViewCellStyle2;
			this.ColumnCost.HeaderText = "Cost";
			this.ColumnCost.MinimumWidth = 8;
			this.ColumnCost.Name = "ColumnCost";
			this.ColumnCost.ReadOnly = true;
			this.ColumnCost.Width = 120;
			// 
			// ColumnAmount
			// 
			this.ColumnAmount.DataPropertyName = "ColumnAmount";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ColumnAmount.DefaultCellStyle = dataGridViewCellStyle3;
			this.ColumnAmount.HeaderText = "Amount";
			this.ColumnAmount.MinimumWidth = 8;
			this.ColumnAmount.Name = "ColumnAmount";
			this.ColumnAmount.ReadOnly = true;
			this.ColumnAmount.Width = 120;
			// 
			// ColumnExpiryDate
			// 
			this.ColumnExpiryDate.DataPropertyName = "ColumnExpiryDate";
			this.ColumnExpiryDate.HeaderText = "Expiry Date";
			this.ColumnExpiryDate.MinimumWidth = 8;
			this.ColumnExpiryDate.Name = "ColumnExpiryDate";
			this.ColumnExpiryDate.ReadOnly = true;
			this.ColumnExpiryDate.Width = 120;
			// 
			// ColumnLotNumber
			// 
			this.ColumnLotNumber.DataPropertyName = "ColumnLotNumber";
			this.ColumnLotNumber.HeaderText = "Lot No.";
			this.ColumnLotNumber.MinimumWidth = 8;
			this.ColumnLotNumber.Name = "ColumnLotNumber";
			this.ColumnLotNumber.ReadOnly = true;
			this.ColumnLotNumber.Width = 150;
			// 
			// ColumnSellingPrice
			// 
			this.ColumnSellingPrice.DataPropertyName = "ColumnSellingPrice";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ColumnSellingPrice.DefaultCellStyle = dataGridViewCellStyle4;
			this.ColumnSellingPrice.HeaderText = "Selling Price";
			this.ColumnSellingPrice.MinimumWidth = 8;
			this.ColumnSellingPrice.Name = "ColumnSellingPrice";
			this.ColumnSellingPrice.ReadOnly = true;
			this.ColumnSellingPrice.Width = 120;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.buttonGenerateCSV);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.buttonClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1644, 75);
			this.panel1.TabIndex = 18;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Reports;
			this.pictureBox1.Location = new System.Drawing.Point(16, 9);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(54, 57);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// RepStockInDetailReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1644, 783);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "RepStockInDetailReportForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stock In Detail Report";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockInDetailReport)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGenerateCSV;
        private System.Windows.Forms.Button buttonGenerateCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPageListFirst;
        private System.Windows.Forms.Button buttonPageListNext;
        private System.Windows.Forms.Button buttonPageListLast;
        private System.Windows.Forms.Button buttonPageListPrevious;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewStockInDetailReport;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemListCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemListBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockInNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnManualStockInNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemarks;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSellingPrice;
    }
}