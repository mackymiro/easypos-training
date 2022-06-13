﻿
namespace EasyPOS.Forms.Software.RepSalesReport
{
    partial class RepSalesSummaryRewardReportForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepSalesSummaryRewardReportForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonGenerateCSV = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.dataGridViewSalesSummaryRewardReport = new System.Windows.Forms.DataGridView();
			this.ColumnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnRewardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAvailableReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTotalClaimReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.buttonPageListFirst = new System.Windows.Forms.Button();
			this.buttonPageListNext = new System.Windows.Forms.Button();
			this.buttonPageListLast = new System.Windows.Forms.Button();
			this.buttonPageListPrevious = new System.Windows.Forms.Button();
			this.textBoxPageNumber = new System.Windows.Forms.TextBox();
			this.folderBrowserDialogGenerateCSV = new System.Windows.Forms.FolderBrowserDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesSummaryRewardReport)).BeginInit();
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
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1644, 75);
			this.panel1.TabIndex = 9;
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
			this.label1.Size = new System.Drawing.Size(450, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Sales Summary Reward Report";
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
			// dataGridViewSalesSummaryRewardReport
			// 
			this.dataGridViewSalesSummaryRewardReport.AllowUserToAddRows = false;
			this.dataGridViewSalesSummaryRewardReport.AllowUserToDeleteRows = false;
			this.dataGridViewSalesSummaryRewardReport.AllowUserToResizeRows = false;
			this.dataGridViewSalesSummaryRewardReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewSalesSummaryRewardReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewSalesSummaryRewardReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSalesSummaryRewardReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCustomer,
            this.ColumnRewardNo,
            this.ColumnAvailableReward,
            this.ColumnTotalClaimReward});
			this.dataGridViewSalesSummaryRewardReport.Location = new System.Drawing.Point(0, 78);
			this.dataGridViewSalesSummaryRewardReport.MultiSelect = false;
			this.dataGridViewSalesSummaryRewardReport.Name = "dataGridViewSalesSummaryRewardReport";
			this.dataGridViewSalesSummaryRewardReport.ReadOnly = true;
			this.dataGridViewSalesSummaryRewardReport.RowHeadersWidth = 62;
			this.dataGridViewSalesSummaryRewardReport.RowTemplate.Height = 24;
			this.dataGridViewSalesSummaryRewardReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewSalesSummaryRewardReport.ShowEditingIcon = false;
			this.dataGridViewSalesSummaryRewardReport.Size = new System.Drawing.Size(1644, 648);
			this.dataGridViewSalesSummaryRewardReport.TabIndex = 23;
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
			// ColumnRewardNo
			// 
			this.ColumnRewardNo.DataPropertyName = "ColumnRewardNo";
			this.ColumnRewardNo.HeaderText = "Reward No.";
			this.ColumnRewardNo.MinimumWidth = 8;
			this.ColumnRewardNo.Name = "ColumnRewardNo";
			this.ColumnRewardNo.ReadOnly = true;
			this.ColumnRewardNo.Width = 150;
			// 
			// ColumnAvailableReward
			// 
			this.ColumnAvailableReward.DataPropertyName = "ColumnAvailableReward";
			this.ColumnAvailableReward.HeaderText = "Reward Available";
			this.ColumnAvailableReward.MinimumWidth = 8;
			this.ColumnAvailableReward.Name = "ColumnAvailableReward";
			this.ColumnAvailableReward.ReadOnly = true;
			this.ColumnAvailableReward.Width = 150;
			// 
			// ColumnTotalClaimReward
			// 
			this.ColumnTotalClaimReward.DataPropertyName = "ColumnTotalClaimReward";
			this.ColumnTotalClaimReward.HeaderText = "Total Claim Reward";
			this.ColumnTotalClaimReward.MinimumWidth = 8;
			this.ColumnTotalClaimReward.Name = "ColumnTotalClaimReward";
			this.ColumnTotalClaimReward.ReadOnly = true;
			this.ColumnTotalClaimReward.Width = 150;
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
			this.panel4.TabIndex = 24;
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
			// RepSalesSummaryRewardReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1644, 783);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.dataGridViewSalesSummaryRewardReport);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "RepSalesSummaryRewardReportForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SalesSummaryRewardReportForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesSummaryRewardReport)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewSalesSummaryRewardReport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonPageListFirst;
        private System.Windows.Forms.Button buttonPageListNext;
        private System.Windows.Forms.Button buttonPageListLast;
        private System.Windows.Forms.Button buttonPageListPrevious;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGenerateCSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRewardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvailableReward;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalClaimReward;
    }
}