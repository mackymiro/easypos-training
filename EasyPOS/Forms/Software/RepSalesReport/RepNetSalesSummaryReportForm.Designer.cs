﻿
namespace EasyPOS.Forms.Software.RepSalesReport
{
    partial class RepNetSalesSummaryReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepNetSalesSummaryReportForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGenerateCSV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNetSalesSummaryReport = new System.Windows.Forms.DataGridView();
            this.ColumnNetSalesSummaryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNetSalesSummaryCustomerCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNetSalesSummaryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNetSalesSummaryCostAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNetSalesSummarySalesAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNetSalesSummaryMarginAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNetSalesSummaryPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonPageListFirst = new System.Windows.Forms.Button();
            this.buttonPageListNext = new System.Windows.Forms.Button();
            this.buttonPageListLast = new System.Windows.Forms.Button();
            this.buttonPageListPrevious = new System.Windows.Forms.Button();
            this.textBoxPageNumber = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogGenerateCSV = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNetSalesSummaryReport)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonGenerateCSV);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 62);
            this.panel1.TabIndex = 11;
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
            this.buttonClose.Location = new System.Drawing.Point(1267, 9);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 40);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
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
            this.buttonGenerateCSV.Location = new System.Drawing.Point(1175, 9);
            this.buttonGenerateCSV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonGenerateCSV.Name = "buttonGenerateCSV";
            this.buttonGenerateCSV.Size = new System.Drawing.Size(88, 40);
            this.buttonGenerateCSV.TabIndex = 5;
            this.buttonGenerateCSV.TabStop = false;
            this.buttonGenerateCSV.Text = "CSV";
            this.buttonGenerateCSV.UseVisualStyleBackColor = false;
            this.buttonGenerateCSV.Click += new System.EventHandler(this.buttonGenerateCSV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Reports;
            this.pictureBox1.Location = new System.Drawing.Point(13, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(72, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Net Sales Summary Report - Daily";
            // 
            // dataGridViewNetSalesSummaryReport
            // 
            this.dataGridViewNetSalesSummaryReport.AllowUserToAddRows = false;
            this.dataGridViewNetSalesSummaryReport.AllowUserToDeleteRows = false;
            this.dataGridViewNetSalesSummaryReport.AllowUserToResizeRows = false;
            this.dataGridViewNetSalesSummaryReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNetSalesSummaryReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNetSalesSummaryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNetSalesSummaryReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNetSalesSummaryDate,
            this.ColumnNetSalesSummaryCustomerCount,
            this.ColumnNetSalesSummaryQuantity,
            this.ColumnNetSalesSummaryCostAmount,
            this.ColumnNetSalesSummarySalesAmount,
            this.ColumnNetSalesSummaryMarginAmount,
            this.ColumnNetSalesSummaryPercentage});
            this.dataGridViewNetSalesSummaryReport.Location = new System.Drawing.Point(-12, 61);
            this.dataGridViewNetSalesSummaryReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewNetSalesSummaryReport.MultiSelect = false;
            this.dataGridViewNetSalesSummaryReport.Name = "dataGridViewNetSalesSummaryReport";
            this.dataGridViewNetSalesSummaryReport.ReadOnly = true;
            this.dataGridViewNetSalesSummaryReport.RowHeadersWidth = 62;
            this.dataGridViewNetSalesSummaryReport.RowTemplate.Height = 24;
            this.dataGridViewNetSalesSummaryReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNetSalesSummaryReport.ShowEditingIcon = false;
            this.dataGridViewNetSalesSummaryReport.Size = new System.Drawing.Size(1368, 533);
            this.dataGridViewNetSalesSummaryReport.TabIndex = 12;
            // 
            // ColumnNetSalesSummaryDate
            // 
            this.ColumnNetSalesSummaryDate.DataPropertyName = "ColumnNetSalesSummaryDate";
            this.ColumnNetSalesSummaryDate.HeaderText = "Date";
            this.ColumnNetSalesSummaryDate.MinimumWidth = 8;
            this.ColumnNetSalesSummaryDate.Name = "ColumnNetSalesSummaryDate";
            this.ColumnNetSalesSummaryDate.ReadOnly = true;
            this.ColumnNetSalesSummaryDate.Width = 150;
            // 
            // ColumnNetSalesSummaryCustomerCount
            // 
            this.ColumnNetSalesSummaryCustomerCount.DataPropertyName = "ColumnNetSalesSummaryCustomerCount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnNetSalesSummaryCustomerCount.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnNetSalesSummaryCustomerCount.HeaderText = "Customer Count";
            this.ColumnNetSalesSummaryCustomerCount.MinimumWidth = 8;
            this.ColumnNetSalesSummaryCustomerCount.Name = "ColumnNetSalesSummaryCustomerCount";
            this.ColumnNetSalesSummaryCustomerCount.ReadOnly = true;
            this.ColumnNetSalesSummaryCustomerCount.Width = 150;
            // 
            // ColumnNetSalesSummaryQuantity
            // 
            this.ColumnNetSalesSummaryQuantity.DataPropertyName = "ColumnNetSalesSummaryQuantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnNetSalesSummaryQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnNetSalesSummaryQuantity.HeaderText = "Quantity";
            this.ColumnNetSalesSummaryQuantity.MinimumWidth = 8;
            this.ColumnNetSalesSummaryQuantity.Name = "ColumnNetSalesSummaryQuantity";
            this.ColumnNetSalesSummaryQuantity.ReadOnly = true;
            this.ColumnNetSalesSummaryQuantity.Width = 150;
            // 
            // ColumnNetSalesSummaryCostAmount
            // 
            this.ColumnNetSalesSummaryCostAmount.DataPropertyName = "ColumnNetSalesSummaryCostAmount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnNetSalesSummaryCostAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnNetSalesSummaryCostAmount.HeaderText = "Cost Amount";
            this.ColumnNetSalesSummaryCostAmount.MinimumWidth = 8;
            this.ColumnNetSalesSummaryCostAmount.Name = "ColumnNetSalesSummaryCostAmount";
            this.ColumnNetSalesSummaryCostAmount.ReadOnly = true;
            this.ColumnNetSalesSummaryCostAmount.Width = 150;
            // 
            // ColumnNetSalesSummarySalesAmount
            // 
            this.ColumnNetSalesSummarySalesAmount.DataPropertyName = "ColumnNetSalesSummarySalesAmount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnNetSalesSummarySalesAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnNetSalesSummarySalesAmount.HeaderText = "SalesAmount";
            this.ColumnNetSalesSummarySalesAmount.MinimumWidth = 8;
            this.ColumnNetSalesSummarySalesAmount.Name = "ColumnNetSalesSummarySalesAmount";
            this.ColumnNetSalesSummarySalesAmount.ReadOnly = true;
            this.ColumnNetSalesSummarySalesAmount.Width = 150;
            // 
            // ColumnNetSalesSummaryMarginAmount
            // 
            this.ColumnNetSalesSummaryMarginAmount.DataPropertyName = "ColumnNetSalesSummaryMarginAmount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnNetSalesSummaryMarginAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnNetSalesSummaryMarginAmount.HeaderText = "Margin Amount";
            this.ColumnNetSalesSummaryMarginAmount.MinimumWidth = 8;
            this.ColumnNetSalesSummaryMarginAmount.Name = "ColumnNetSalesSummaryMarginAmount";
            this.ColumnNetSalesSummaryMarginAmount.ReadOnly = true;
            this.ColumnNetSalesSummaryMarginAmount.Width = 150;
            // 
            // ColumnNetSalesSummaryPercentage
            // 
            this.ColumnNetSalesSummaryPercentage.DataPropertyName = "ColumnNetSalesSummaryPercentage";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnNetSalesSummaryPercentage.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnNetSalesSummaryPercentage.HeaderText = "%";
            this.ColumnNetSalesSummaryPercentage.MinimumWidth = 8;
            this.ColumnNetSalesSummaryPercentage.Name = "ColumnNetSalesSummaryPercentage";
            this.ColumnNetSalesSummaryPercentage.ReadOnly = true;
            this.ColumnNetSalesSummaryPercentage.Width = 150;
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
            this.panel4.Location = new System.Drawing.Point(0, 600);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1370, 52);
            this.panel4.TabIndex = 21;
            // 
            // buttonPageListFirst
            // 
            this.buttonPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPageListFirst.Enabled = false;
            this.buttonPageListFirst.FlatAppearance.BorderSize = 0;
            this.buttonPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPageListFirst.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.buttonPageListFirst.Location = new System.Drawing.Point(12, 10);
            this.buttonPageListFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPageListFirst.Name = "buttonPageListFirst";
            this.buttonPageListFirst.Size = new System.Drawing.Size(82, 32);
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
            this.buttonPageListNext.Location = new System.Drawing.Point(338, 10);
            this.buttonPageListNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPageListNext.Name = "buttonPageListNext";
            this.buttonPageListNext.Size = new System.Drawing.Size(82, 32);
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
            this.buttonPageListLast.Location = new System.Drawing.Point(422, 10);
            this.buttonPageListLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPageListLast.Name = "buttonPageListLast";
            this.buttonPageListLast.Size = new System.Drawing.Size(82, 32);
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
            this.buttonPageListPrevious.Location = new System.Drawing.Point(100, 10);
            this.buttonPageListPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPageListPrevious.Name = "buttonPageListPrevious";
            this.buttonPageListPrevious.Size = new System.Drawing.Size(88, 32);
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
            this.textBoxPageNumber.Location = new System.Drawing.Point(232, 15);
            this.textBoxPageNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPageNumber.Name = "textBoxPageNumber";
            this.textBoxPageNumber.ReadOnly = true;
            this.textBoxPageNumber.Size = new System.Drawing.Size(68, 23);
            this.textBoxPageNumber.TabIndex = 12;
            this.textBoxPageNumber.TabStop = false;
            this.textBoxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(1083, 9);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(88, 40);
            this.buttonPrint.TabIndex = 27;
            this.buttonPrint.TabStop = false;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // RepNetSalesSummaryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1370, 652);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridViewNetSalesSummaryReport);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RepNetSalesSummaryReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Net Sales Summary Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNetSalesSummaryReport)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonGenerateCSV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNetSalesSummaryReport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonPageListFirst;
        private System.Windows.Forms.Button buttonPageListNext;
        private System.Windows.Forms.Button buttonPageListLast;
        private System.Windows.Forms.Button buttonPageListPrevious;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGenerateCSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNetSalesSummaryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNetSalesSummaryCustomerCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNetSalesSummaryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNetSalesSummaryCostAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNetSalesSummarySalesAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNetSalesSummaryMarginAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNetSalesSummaryPercentage;
        private System.Windows.Forms.Button buttonPrint;
    }
}