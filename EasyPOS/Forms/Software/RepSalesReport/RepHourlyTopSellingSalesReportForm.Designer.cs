﻿
namespace EasyPOS.Forms.Software.RepSalesReport
{
    partial class RepHourlyTopSellingSalesReportForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepHourlyTopSellingSalesReportForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonView = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.dataGridViewHourlyTopSellingSalesReport = new System.Windows.Forms.DataGridView();
			this.ColumnHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.buttonPageListFirst = new System.Windows.Forms.Button();
			this.buttonPageListNext = new System.Windows.Forms.Button();
			this.buttonPageListLast = new System.Windows.Forms.Button();
			this.buttonPageListPrevious = new System.Windows.Forms.Button();
			this.textBoxPageNumber = new System.Windows.Forms.TextBox();
			this.folderBrowserDialogGenerateCSV = new System.Windows.Forms.FolderBrowserDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHourlyTopSellingSalesReport)).BeginInit();
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
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1644, 75);
			this.panel1.TabIndex = 13;
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
			this.buttonView.Location = new System.Drawing.Point(1410, 14);
			this.buttonView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonView.Name = "buttonView";
			this.buttonView.Size = new System.Drawing.Size(105, 48);
			this.buttonView.TabIndex = 5;
			this.buttonView.TabStop = false;
			this.buttonView.Text = "CSV";
			this.buttonView.UseVisualStyleBackColor = false;
			this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(86, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(463, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Hourly Top Selling Sales Report";
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
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// dataGridViewHourlyTopSellingSalesReport
			// 
			this.dataGridViewHourlyTopSellingSalesReport.AllowUserToAddRows = false;
			this.dataGridViewHourlyTopSellingSalesReport.AllowUserToDeleteRows = false;
			this.dataGridViewHourlyTopSellingSalesReport.AllowUserToResizeRows = false;
			this.dataGridViewHourlyTopSellingSalesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewHourlyTopSellingSalesReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewHourlyTopSellingSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewHourlyTopSellingSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHour,
            this.ColumnNo,
            this.ColumnCategory,
            this.ColumnItemDescription,
            this.ColumnQuantity,
            this.ColumnUnit,
            this.ColumnPrice,
            this.ColumnAmount});
			this.dataGridViewHourlyTopSellingSalesReport.Location = new System.Drawing.Point(2, 66);
			this.dataGridViewHourlyTopSellingSalesReport.MultiSelect = false;
			this.dataGridViewHourlyTopSellingSalesReport.Name = "dataGridViewHourlyTopSellingSalesReport";
			this.dataGridViewHourlyTopSellingSalesReport.ReadOnly = true;
			this.dataGridViewHourlyTopSellingSalesReport.RowHeadersWidth = 62;
			this.dataGridViewHourlyTopSellingSalesReport.RowTemplate.Height = 24;
			this.dataGridViewHourlyTopSellingSalesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewHourlyTopSellingSalesReport.ShowEditingIcon = false;
			this.dataGridViewHourlyTopSellingSalesReport.Size = new System.Drawing.Size(1641, 651);
			this.dataGridViewHourlyTopSellingSalesReport.TabIndex = 14;
			// 
			// ColumnHour
			// 
			this.ColumnHour.DataPropertyName = "ColumnHour";
			this.ColumnHour.HeaderText = "Hour";
			this.ColumnHour.MinimumWidth = 8;
			this.ColumnHour.Name = "ColumnHour";
			this.ColumnHour.ReadOnly = true;
			this.ColumnHour.Width = 150;
			// 
			// ColumnNo
			// 
			this.ColumnNo.DataPropertyName = "ColumnNo";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ColumnNo.DefaultCellStyle = dataGridViewCellStyle1;
			this.ColumnNo.HeaderText = "No";
			this.ColumnNo.MinimumWidth = 8;
			this.ColumnNo.Name = "ColumnNo";
			this.ColumnNo.ReadOnly = true;
			this.ColumnNo.Width = 150;
			// 
			// ColumnCategory
			// 
			this.ColumnCategory.DataPropertyName = "ColumnCategory";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ColumnCategory.DefaultCellStyle = dataGridViewCellStyle2;
			this.ColumnCategory.HeaderText = "Category";
			this.ColumnCategory.MinimumWidth = 8;
			this.ColumnCategory.Name = "ColumnCategory";
			this.ColumnCategory.ReadOnly = true;
			this.ColumnCategory.Width = 150;
			// 
			// ColumnItemDescription
			// 
			this.ColumnItemDescription.DataPropertyName = "ColumnItemDescription";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ColumnItemDescription.DefaultCellStyle = dataGridViewCellStyle3;
			this.ColumnItemDescription.FillWeight = 250F;
			this.ColumnItemDescription.HeaderText = "Item Description";
			this.ColumnItemDescription.MinimumWidth = 8;
			this.ColumnItemDescription.Name = "ColumnItemDescription";
			this.ColumnItemDescription.ReadOnly = true;
			this.ColumnItemDescription.Width = 250;
			// 
			// ColumnQuantity
			// 
			this.ColumnQuantity.DataPropertyName = "ColumnQuantity";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ColumnQuantity.DefaultCellStyle = dataGridViewCellStyle4;
			this.ColumnQuantity.HeaderText = "Quantity";
			this.ColumnQuantity.MinimumWidth = 8;
			this.ColumnQuantity.Name = "ColumnQuantity";
			this.ColumnQuantity.ReadOnly = true;
			this.ColumnQuantity.Width = 150;
			// 
			// ColumnUnit
			// 
			this.ColumnUnit.DataPropertyName = "ColumnUnit";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ColumnUnit.DefaultCellStyle = dataGridViewCellStyle5;
			this.ColumnUnit.HeaderText = "Unit";
			this.ColumnUnit.MinimumWidth = 8;
			this.ColumnUnit.Name = "ColumnUnit";
			this.ColumnUnit.ReadOnly = true;
			this.ColumnUnit.Width = 150;
			// 
			// ColumnPrice
			// 
			this.ColumnPrice.DataPropertyName = "ColumnPrice";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ColumnPrice.DefaultCellStyle = dataGridViewCellStyle6;
			this.ColumnPrice.HeaderText = "Price";
			this.ColumnPrice.MinimumWidth = 8;
			this.ColumnPrice.Name = "ColumnPrice";
			this.ColumnPrice.ReadOnly = true;
			this.ColumnPrice.Width = 150;
			// 
			// ColumnAmount
			// 
			this.ColumnAmount.DataPropertyName = "ColumnAmount";
			this.ColumnAmount.HeaderText = "Amount";
			this.ColumnAmount.MinimumWidth = 8;
			this.ColumnAmount.Name = "ColumnAmount";
			this.ColumnAmount.ReadOnly = true;
			this.ColumnAmount.Width = 150;
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
			this.panel4.Location = new System.Drawing.Point(0, 720);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1644, 63);
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
			this.buttonPageListFirst.Click += new System.EventHandler(this.buttonSalesListPageListFirst_Click);
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
			this.buttonPageListNext.Click += new System.EventHandler(this.buttonSalesListPageListNext_Click);
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
			this.buttonPageListLast.Click += new System.EventHandler(this.buttonSalesListPageListLast_Click);
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
			this.buttonPageListPrevious.Size = new System.Drawing.Size(105, 39);
			this.buttonPageListPrevious.TabIndex = 9;
			this.buttonPageListPrevious.TabStop = false;
			this.buttonPageListPrevious.Text = "Previous";
			this.buttonPageListPrevious.UseVisualStyleBackColor = false;
			this.buttonPageListPrevious.Click += new System.EventHandler(this.buttonSalesListPageListPrevious_Click);
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
			// RepHourlyTopSellingSalesReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1644, 783);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.dataGridViewHourlyTopSellingSalesReport);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "RepHourlyTopSellingSalesReportForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hourly Top Selling Sales Report";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHourlyTopSellingSalesReport)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewHourlyTopSellingSalesReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonPageListFirst;
        private System.Windows.Forms.Button buttonPageListNext;
        private System.Windows.Forms.Button buttonPageListLast;
        private System.Windows.Forms.Button buttonPageListPrevious;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGenerateCSV;
    }
}