﻿namespace EasyPOS.Forms.Software.RepSalesReport
{
    partial class RepCancelSalesSummaryReportForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepCancelSalesSummaryReportForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonView = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridCancelSalesSummaryReport = new System.Windows.Forms.DataGridView();
			this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCollectionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCancelledCollectionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCollectionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSalesNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPreparedByUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonPageListFirst = new System.Windows.Forms.Button();
			this.buttonPageListNext = new System.Windows.Forms.Button();
			this.buttonPageListLast = new System.Windows.Forms.Button();
			this.buttonPageListPrevious = new System.Windows.Forms.Button();
			this.textBoxPageNumber = new System.Windows.Forms.TextBox();
			this.folderBrowserDialogGenerateCSV = new System.Windows.Forms.FolderBrowserDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCancelSalesSummaryReport)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.buttonView);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.buttonClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1644, 74);
			this.panel1.TabIndex = 10;
			// 
			// buttonView
			// 
			this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
			this.buttonView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
			this.buttonView.FlatAppearance.BorderSize = 0;
			this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonView.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonView.ForeColor = System.Drawing.Color.White;
			this.buttonView.Location = new System.Drawing.Point(1410, 13);
			this.buttonView.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
			this.buttonView.Name = "buttonView";
			this.buttonView.Size = new System.Drawing.Size(106, 48);
			this.buttonView.TabIndex = 5;
			this.buttonView.TabStop = false;
			this.buttonView.Text = "CSV";
			this.buttonView.UseVisualStyleBackColor = false;
			this.buttonView.Click += new System.EventHandler(this.buttonGenerateCSV_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(85, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(401, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Cancelled Summary Report";
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
			this.buttonClose.Location = new System.Drawing.Point(1523, 13);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(106, 48);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.TabStop = false;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_OnClick);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dataGridCancelSalesSummaryReport);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 74);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1644, 708);
			this.panel2.TabIndex = 11;
			// 
			// dataGridCancelSalesSummaryReport
			// 
			this.dataGridCancelSalesSummaryReport.AllowUserToAddRows = false;
			this.dataGridCancelSalesSummaryReport.AllowUserToDeleteRows = false;
			this.dataGridCancelSalesSummaryReport.AllowUserToResizeRows = false;
			this.dataGridCancelSalesSummaryReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridCancelSalesSummaryReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridCancelSalesSummaryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCancelSalesSummaryReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnTerminal,
            this.ColumnCollectionDate,
            this.ColumnCancelledCollectionNumber,
            this.ColumnCollectionNumber,
            this.ColumnCustomerCode,
            this.ColumnCustomer,
            this.ColumnSalesNumber,
            this.ColumnRemarks,
            this.ColumnPreparedByUserName,
            this.ColumnAmount});
			this.dataGridCancelSalesSummaryReport.Location = new System.Drawing.Point(14, 7);
			this.dataGridCancelSalesSummaryReport.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridCancelSalesSummaryReport.MultiSelect = false;
			this.dataGridCancelSalesSummaryReport.Name = "dataGridCancelSalesSummaryReport";
			this.dataGridCancelSalesSummaryReport.ReadOnly = true;
			this.dataGridCancelSalesSummaryReport.RowHeadersWidth = 62;
			this.dataGridCancelSalesSummaryReport.RowTemplate.Height = 24;
			this.dataGridCancelSalesSummaryReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridCancelSalesSummaryReport.ShowEditingIcon = false;
			this.dataGridCancelSalesSummaryReport.Size = new System.Drawing.Size(1614, 634);
			this.dataGridCancelSalesSummaryReport.TabIndex = 21;
			// 
			// ColumnId
			// 
			this.ColumnId.DataPropertyName = "ColumnId";
			this.ColumnId.HeaderText = "Id";
			this.ColumnId.MinimumWidth = 8;
			this.ColumnId.Name = "ColumnId";
			this.ColumnId.ReadOnly = true;
			this.ColumnId.Visible = false;
			this.ColumnId.Width = 150;
			// 
			// ColumnTerminal
			// 
			this.ColumnTerminal.DataPropertyName = "ColumnTerminal";
			this.ColumnTerminal.HeaderText = "Terminal";
			this.ColumnTerminal.MinimumWidth = 8;
			this.ColumnTerminal.Name = "ColumnTerminal";
			this.ColumnTerminal.ReadOnly = true;
			this.ColumnTerminal.Width = 150;
			// 
			// ColumnCollectionDate
			// 
			this.ColumnCollectionDate.DataPropertyName = "ColumnCollectionDate";
			this.ColumnCollectionDate.HeaderText = "Collection Date";
			this.ColumnCollectionDate.MinimumWidth = 8;
			this.ColumnCollectionDate.Name = "ColumnCollectionDate";
			this.ColumnCollectionDate.ReadOnly = true;
			this.ColumnCollectionDate.Width = 120;
			// 
			// ColumnCancelledCollectionNumber
			// 
			this.ColumnCancelledCollectionNumber.DataPropertyName = "ColumnCancelledCollectionNumber";
			this.ColumnCancelledCollectionNumber.HeaderText = "Cancelled Collection No.";
			this.ColumnCancelledCollectionNumber.MinimumWidth = 8;
			this.ColumnCancelledCollectionNumber.Name = "ColumnCancelledCollectionNumber";
			this.ColumnCancelledCollectionNumber.ReadOnly = true;
			this.ColumnCancelledCollectionNumber.Width = 120;
			// 
			// ColumnCollectionNumber
			// 
			this.ColumnCollectionNumber.DataPropertyName = "ColumnCollectionNumber";
			this.ColumnCollectionNumber.HeaderText = "Collection No.";
			this.ColumnCollectionNumber.MinimumWidth = 8;
			this.ColumnCollectionNumber.Name = "ColumnCollectionNumber";
			this.ColumnCollectionNumber.ReadOnly = true;
			this.ColumnCollectionNumber.Width = 120;
			// 
			// ColumnCustomerCode
			// 
			this.ColumnCustomerCode.DataPropertyName = "ColumnCustomerCode";
			this.ColumnCustomerCode.HeaderText = "Customer Code";
			this.ColumnCustomerCode.MinimumWidth = 8;
			this.ColumnCustomerCode.Name = "ColumnCustomerCode";
			this.ColumnCustomerCode.ReadOnly = true;
			this.ColumnCustomerCode.Width = 150;
			// 
			// ColumnCustomer
			// 
			this.ColumnCustomer.DataPropertyName = "ColumnCustomer";
			this.ColumnCustomer.FillWeight = 150F;
			this.ColumnCustomer.HeaderText = "Customer";
			this.ColumnCustomer.MinimumWidth = 8;
			this.ColumnCustomer.Name = "ColumnCustomer";
			this.ColumnCustomer.ReadOnly = true;
			this.ColumnCustomer.Width = 200;
			// 
			// ColumnSalesNumber
			// 
			this.ColumnSalesNumber.DataPropertyName = "ColumnSalesNumber";
			this.ColumnSalesNumber.HeaderText = "Sales No.";
			this.ColumnSalesNumber.MinimumWidth = 8;
			this.ColumnSalesNumber.Name = "ColumnSalesNumber";
			this.ColumnSalesNumber.ReadOnly = true;
			this.ColumnSalesNumber.Width = 120;
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
			// ColumnPreparedByUserName
			// 
			this.ColumnPreparedByUserName.DataPropertyName = "ColumnPreparedByUserName";
			this.ColumnPreparedByUserName.FillWeight = 120F;
			this.ColumnPreparedByUserName.HeaderText = "Prepared By";
			this.ColumnPreparedByUserName.MinimumWidth = 8;
			this.ColumnPreparedByUserName.Name = "ColumnPreparedByUserName";
			this.ColumnPreparedByUserName.ReadOnly = true;
			this.ColumnPreparedByUserName.Width = 150;
			// 
			// ColumnAmount
			// 
			this.ColumnAmount.DataPropertyName = "ColumnAmount";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ColumnAmount.DefaultCellStyle = dataGridViewCellStyle1;
			this.ColumnAmount.HeaderText = "Amount";
			this.ColumnAmount.MinimumWidth = 8;
			this.ColumnAmount.Name = "ColumnAmount";
			this.ColumnAmount.ReadOnly = true;
			this.ColumnAmount.Width = 120;
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
			this.panel4.Location = new System.Drawing.Point(0, 720);
			this.panel4.Margin = new System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1644, 62);
			this.panel4.TabIndex = 20;
			// 
			// textBoxTotalAmount
			// 
			this.textBoxTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTotalAmount.Location = new System.Drawing.Point(1200, 17);
			this.textBoxTotalAmount.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxTotalAmount.Name = "textBoxTotalAmount";
			this.textBoxTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBoxTotalAmount.Size = new System.Drawing.Size(370, 28);
			this.textBoxTotalAmount.TabIndex = 15;
			this.textBoxTotalAmount.TabStop = false;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1032, 17);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
			this.buttonPageListFirst.Location = new System.Drawing.Point(14, 11);
			this.buttonPageListFirst.Margin = new System.Windows.Forms.Padding(2);
			this.buttonPageListFirst.Name = "buttonPageListFirst";
			this.buttonPageListFirst.Size = new System.Drawing.Size(98, 38);
			this.buttonPageListFirst.TabIndex = 8;
			this.buttonPageListFirst.TabStop = false;
			this.buttonPageListFirst.Text = "First";
			this.buttonPageListFirst.UseVisualStyleBackColor = false;
			// 
			// buttonPageListNext
			// 
			this.buttonPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPageListNext.FlatAppearance.BorderSize = 0;
			this.buttonPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPageListNext.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.buttonPageListNext.Location = new System.Drawing.Point(406, 11);
			this.buttonPageListNext.Margin = new System.Windows.Forms.Padding(2);
			this.buttonPageListNext.Name = "buttonPageListNext";
			this.buttonPageListNext.Size = new System.Drawing.Size(98, 38);
			this.buttonPageListNext.TabIndex = 10;
			this.buttonPageListNext.TabStop = false;
			this.buttonPageListNext.Text = "Next";
			this.buttonPageListNext.UseVisualStyleBackColor = false;
			// 
			// buttonPageListLast
			// 
			this.buttonPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPageListLast.FlatAppearance.BorderSize = 0;
			this.buttonPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPageListLast.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.buttonPageListLast.Location = new System.Drawing.Point(506, 11);
			this.buttonPageListLast.Margin = new System.Windows.Forms.Padding(2);
			this.buttonPageListLast.Name = "buttonPageListLast";
			this.buttonPageListLast.Size = new System.Drawing.Size(98, 38);
			this.buttonPageListLast.TabIndex = 11;
			this.buttonPageListLast.TabStop = false;
			this.buttonPageListLast.Text = "Last";
			this.buttonPageListLast.UseVisualStyleBackColor = false;
			// 
			// buttonPageListPrevious
			// 
			this.buttonPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPageListPrevious.Enabled = false;
			this.buttonPageListPrevious.FlatAppearance.BorderSize = 0;
			this.buttonPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.buttonPageListPrevious.Location = new System.Drawing.Point(120, 11);
			this.buttonPageListPrevious.Margin = new System.Windows.Forms.Padding(2);
			this.buttonPageListPrevious.Name = "buttonPageListPrevious";
			this.buttonPageListPrevious.Size = new System.Drawing.Size(98, 38);
			this.buttonPageListPrevious.TabIndex = 9;
			this.buttonPageListPrevious.TabStop = false;
			this.buttonPageListPrevious.Text = "Previous";
			this.buttonPageListPrevious.UseVisualStyleBackColor = false;
			// 
			// textBoxPageNumber
			// 
			this.textBoxPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxPageNumber.BackColor = System.Drawing.Color.White;
			this.textBoxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPageNumber.Location = new System.Drawing.Point(286, 17);
			this.textBoxPageNumber.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxPageNumber.Name = "textBoxPageNumber";
			this.textBoxPageNumber.ReadOnly = true;
			this.textBoxPageNumber.Size = new System.Drawing.Size(83, 28);
			this.textBoxPageNumber.TabIndex = 12;
			this.textBoxPageNumber.TabStop = false;
			this.textBoxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Reports;
			this.pictureBox1.Location = new System.Drawing.Point(17, 10);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(54, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// RepCancelSalesSummaryReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1644, 782);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
			this.Name = "RepCancelSalesSummaryReportForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cancelled Sales Summary Report";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridCancelSalesSummaryReport)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonView;
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGenerateCSV;
        private System.Windows.Forms.DataGridView dataGridCancelSalesSummaryReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCancelledCollectionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCollectionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreparedByUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
    }
}