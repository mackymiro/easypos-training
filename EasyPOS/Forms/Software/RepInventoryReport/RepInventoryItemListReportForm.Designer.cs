﻿namespace EasyPOS.Forms.Software.RepInventoryReport
{
    partial class RepInventoryItemListReportForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepInventoryItemListReportForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonGenerateCSV = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.dataGridViewItemListReport = new System.Windows.Forms.DataGridView();
			this.ColumnItemListButtonEdit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ColumnItemListButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ColumnItemListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnItemListCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnItemListBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnItemListDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnItemListUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnItemListCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnItemListCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnItemListPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnItemListOnHandQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnItemListIsInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnItemListIsLocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.buttonPageListFirst = new System.Windows.Forms.Button();
			this.buttonPageListNext = new System.Windows.Forms.Button();
			this.buttonPageListLast = new System.Windows.Forms.Button();
			this.buttonPageListPrevious = new System.Windows.Forms.Button();
			this.textBoxPageNumber = new System.Windows.Forms.TextBox();
			this.folderBrowserDialogGenerateCSV = new System.Windows.Forms.FolderBrowserDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemListReport)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.buttonGenerateCSV);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.buttonClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1588, 75);
			this.panel1.TabIndex = 17;
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
			this.buttonGenerateCSV.Location = new System.Drawing.Point(1354, 14);
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
			this.label1.Size = new System.Drawing.Size(317, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Inventory List Report";
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
			this.buttonClose.Location = new System.Drawing.Point(1467, 14);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(105, 48);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// dataGridViewItemListReport
			// 
			this.dataGridViewItemListReport.AllowUserToAddRows = false;
			this.dataGridViewItemListReport.AllowUserToDeleteRows = false;
			this.dataGridViewItemListReport.AllowUserToResizeRows = false;
			this.dataGridViewItemListReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewItemListReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewItemListReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewItemListReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItemListButtonEdit,
            this.ColumnItemListButtonDelete,
            this.ColumnItemListId,
            this.ColumnItemListCode,
            this.ColumnItemListBarcode,
            this.ColumnItemListDescription,
            this.ColumnItemListUnit,
            this.ColumnItemListCategory,
            this.ColumnItemListCost,
            this.ColumnItemListPrice,
            this.ColumnItemListOnHandQuantity,
            this.ColumnItemListIsInventory,
            this.ColumnItemListIsLocked,
            this.ColumnSupplier});
			this.dataGridViewItemListReport.Location = new System.Drawing.Point(0, 74);
			this.dataGridViewItemListReport.MultiSelect = false;
			this.dataGridViewItemListReport.Name = "dataGridViewItemListReport";
			this.dataGridViewItemListReport.ReadOnly = true;
			this.dataGridViewItemListReport.RowHeadersWidth = 62;
			this.dataGridViewItemListReport.RowTemplate.Height = 24;
			this.dataGridViewItemListReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewItemListReport.ShowEditingIcon = false;
			this.dataGridViewItemListReport.Size = new System.Drawing.Size(1586, 444);
			this.dataGridViewItemListReport.TabIndex = 18;
			// 
			// ColumnItemListButtonEdit
			// 
			this.ColumnItemListButtonEdit.DataPropertyName = "ColumnItemListButtonEdit";
			this.ColumnItemListButtonEdit.HeaderText = "";
			this.ColumnItemListButtonEdit.MinimumWidth = 8;
			this.ColumnItemListButtonEdit.Name = "ColumnItemListButtonEdit";
			this.ColumnItemListButtonEdit.ReadOnly = true;
			this.ColumnItemListButtonEdit.Visible = false;
			this.ColumnItemListButtonEdit.Width = 150;
			// 
			// ColumnItemListButtonDelete
			// 
			this.ColumnItemListButtonDelete.DataPropertyName = "ColumnItemListButtonDelete";
			this.ColumnItemListButtonDelete.HeaderText = "";
			this.ColumnItemListButtonDelete.MinimumWidth = 8;
			this.ColumnItemListButtonDelete.Name = "ColumnItemListButtonDelete";
			this.ColumnItemListButtonDelete.ReadOnly = true;
			this.ColumnItemListButtonDelete.Visible = false;
			this.ColumnItemListButtonDelete.Width = 150;
			// 
			// ColumnItemListId
			// 
			this.ColumnItemListId.DataPropertyName = "ColumnItemListId";
			this.ColumnItemListId.HeaderText = "Id";
			this.ColumnItemListId.MinimumWidth = 8;
			this.ColumnItemListId.Name = "ColumnItemListId";
			this.ColumnItemListId.ReadOnly = true;
			this.ColumnItemListId.Visible = false;
			this.ColumnItemListId.Width = 150;
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
			// ColumnItemListDescription
			// 
			this.ColumnItemListDescription.DataPropertyName = "ColumnItemListDescription";
			this.ColumnItemListDescription.HeaderText = "Item Description";
			this.ColumnItemListDescription.MinimumWidth = 8;
			this.ColumnItemListDescription.Name = "ColumnItemListDescription";
			this.ColumnItemListDescription.ReadOnly = true;
			this.ColumnItemListDescription.Width = 150;
			// 
			// ColumnItemListUnit
			// 
			this.ColumnItemListUnit.DataPropertyName = "ColumnItemListUnit";
			this.ColumnItemListUnit.HeaderText = "Unit";
			this.ColumnItemListUnit.MinimumWidth = 8;
			this.ColumnItemListUnit.Name = "ColumnItemListUnit";
			this.ColumnItemListUnit.ReadOnly = true;
			this.ColumnItemListUnit.Width = 150;
			// 
			// ColumnItemListCategory
			// 
			this.ColumnItemListCategory.DataPropertyName = "ColumnItemListCategory";
			this.ColumnItemListCategory.HeaderText = "Category";
			this.ColumnItemListCategory.MinimumWidth = 8;
			this.ColumnItemListCategory.Name = "ColumnItemListCategory";
			this.ColumnItemListCategory.ReadOnly = true;
			this.ColumnItemListCategory.Visible = false;
			this.ColumnItemListCategory.Width = 150;
			// 
			// ColumnItemListCost
			// 
			this.ColumnItemListCost.DataPropertyName = "ColumnItemListCost";
			this.ColumnItemListCost.HeaderText = "Cost";
			this.ColumnItemListCost.MinimumWidth = 8;
			this.ColumnItemListCost.Name = "ColumnItemListCost";
			this.ColumnItemListCost.ReadOnly = true;
			this.ColumnItemListCost.Width = 150;
			// 
			// ColumnItemListPrice
			// 
			this.ColumnItemListPrice.DataPropertyName = "ColumnItemListPrice";
			this.ColumnItemListPrice.HeaderText = "Price";
			this.ColumnItemListPrice.MinimumWidth = 8;
			this.ColumnItemListPrice.Name = "ColumnItemListPrice";
			this.ColumnItemListPrice.ReadOnly = true;
			this.ColumnItemListPrice.Width = 150;
			// 
			// ColumnItemListOnHandQuantity
			// 
			this.ColumnItemListOnHandQuantity.DataPropertyName = "ColumnItemListOnHandQuantity";
			this.ColumnItemListOnHandQuantity.HeaderText = "OnHandQuantity";
			this.ColumnItemListOnHandQuantity.MinimumWidth = 8;
			this.ColumnItemListOnHandQuantity.Name = "ColumnItemListOnHandQuantity";
			this.ColumnItemListOnHandQuantity.ReadOnly = true;
			this.ColumnItemListOnHandQuantity.Visible = false;
			this.ColumnItemListOnHandQuantity.Width = 150;
			// 
			// ColumnItemListIsInventory
			// 
			this.ColumnItemListIsInventory.DataPropertyName = "ColumnItemListIsInventory";
			this.ColumnItemListIsInventory.HeaderText = "I";
			this.ColumnItemListIsInventory.MinimumWidth = 8;
			this.ColumnItemListIsInventory.Name = "ColumnItemListIsInventory";
			this.ColumnItemListIsInventory.ReadOnly = true;
			this.ColumnItemListIsInventory.Visible = false;
			this.ColumnItemListIsInventory.Width = 150;
			// 
			// ColumnItemListIsLocked
			// 
			this.ColumnItemListIsLocked.DataPropertyName = "ColumnItemListIsLocked";
			this.ColumnItemListIsLocked.HeaderText = "L";
			this.ColumnItemListIsLocked.MinimumWidth = 8;
			this.ColumnItemListIsLocked.Name = "ColumnItemListIsLocked";
			this.ColumnItemListIsLocked.ReadOnly = true;
			this.ColumnItemListIsLocked.Visible = false;
			this.ColumnItemListIsLocked.Width = 150;
			// 
			// ColumnSupplier
			// 
			this.ColumnSupplier.DataPropertyName = "ColumnSupplier";
			this.ColumnSupplier.HeaderText = "Supplier";
			this.ColumnSupplier.MinimumWidth = 8;
			this.ColumnSupplier.Name = "ColumnSupplier";
			this.ColumnSupplier.ReadOnly = true;
			this.ColumnSupplier.Visible = false;
			this.ColumnSupplier.Width = 150;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.buttonPageListFirst);
			this.panel4.Controls.Add(this.buttonPageListNext);
			this.panel4.Controls.Add(this.buttonPageListLast);
			this.panel4.Controls.Add(this.buttonPageListPrevious);
			this.panel4.Controls.Add(this.textBoxPageNumber);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 511);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1588, 63);
			this.panel4.TabIndex = 22;
			// 
			// buttonPageListFirst
			// 
			this.buttonPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPageListFirst.Enabled = false;
			this.buttonPageListFirst.FlatAppearance.BorderSize = 0;
			this.buttonPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPageListFirst.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.buttonPageListFirst.Location = new System.Drawing.Point(15, 12);
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
			this.buttonPageListNext.Location = new System.Drawing.Point(405, 12);
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
			this.buttonPageListLast.Location = new System.Drawing.Point(507, 12);
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
			this.buttonPageListPrevious.Location = new System.Drawing.Point(120, 12);
			this.buttonPageListPrevious.Name = "buttonPageListPrevious";
			this.buttonPageListPrevious.Size = new System.Drawing.Size(104, 39);
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
			this.textBoxPageNumber.Location = new System.Drawing.Point(278, 18);
			this.textBoxPageNumber.Name = "textBoxPageNumber";
			this.textBoxPageNumber.ReadOnly = true;
			this.textBoxPageNumber.Size = new System.Drawing.Size(82, 28);
			this.textBoxPageNumber.TabIndex = 12;
			this.textBoxPageNumber.TabStop = false;
			this.textBoxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			// RepInventoryItemListReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1588, 574);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.dataGridViewItemListReport);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "RepInventoryItemListReportForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inventory List Report";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemListReport)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGenerateCSV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewItemListReport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonPageListFirst;
        private System.Windows.Forms.Button buttonPageListNext;
        private System.Windows.Forms.Button buttonPageListLast;
        private System.Windows.Forms.Button buttonPageListPrevious;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGenerateCSV;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnItemListButtonEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnItemListButtonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemListId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemListCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemListBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemListDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemListUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemListCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemListCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemListPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemListOnHandQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemListIsInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemListIsLocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupplier;
    }
}