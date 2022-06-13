﻿namespace EasyPOS.Forms.Software.RepSalesReport
{
    partial class RepSalesReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepSalesReportForm));
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.comboBoxEndhours = new System.Windows.Forms.ComboBox();
            this.labelStartHour = new System.Windows.Forms.Label();
            this.comboBoxHours = new System.Windows.Forms.ComboBox();
            this.labelPaytype = new System.Windows.Forms.Label();
            this.comboBoxPayType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateAsOf = new System.Windows.Forms.DateTimePicker();
            this.labelDateAsOf = new System.Windows.Forms.Label();
            this.comboBoxSalesAgent = new System.Windows.Forms.ComboBox();
            this.labelAgent = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.comboBoxTerminal = new System.Windows.Forms.ComboBox();
            this.labelTerminal = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxSalesReport = new System.Windows.Forms.ListBox();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonView = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.printDialogStockWithdrawalReport = new System.Windows.Forms.PrintDialog();
            this.folderBrowserDialogStockWithdrawalReport = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogCollectionDetailReportFacepay = new System.Windows.Forms.FolderBrowserDialog();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelEndTime);
            this.panel4.Controls.Add(this.comboBoxEndhours);
            this.panel4.Controls.Add(this.labelStartHour);
            this.panel4.Controls.Add(this.comboBoxHours);
            this.panel4.Controls.Add(this.labelPaytype);
            this.panel4.Controls.Add(this.comboBoxPayType);
            this.panel4.Controls.Add(this.dateTimePickerDateAsOf);
            this.panel4.Controls.Add(this.labelDateAsOf);
            this.panel4.Controls.Add(this.comboBoxSalesAgent);
            this.panel4.Controls.Add(this.labelAgent);
            this.panel4.Controls.Add(this.comboBoxCustomer);
            this.panel4.Controls.Add(this.labelCustomer);
            this.panel4.Controls.Add(this.comboBoxTerminal);
            this.panel4.Controls.Add(this.labelTerminal);
            this.panel4.Controls.Add(this.dateTimePickerStartDate);
            this.panel4.Controls.Add(this.labelStartDate);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.dateTimePickerEndDate);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.labelEndDate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1141, 562);
            this.panel4.TabIndex = 8;
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Location = new System.Drawing.Point(897, 58);
            this.labelEndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(17, 23);
            this.labelEndTime.TabIndex = 37;
            this.labelEndTime.Text = "-";
            this.labelEndTime.Visible = false;
            // 
            // comboBoxEndhours
            // 
            this.comboBoxEndhours.FormattingEnabled = true;
            this.comboBoxEndhours.Location = new System.Drawing.Point(922, 55);
            this.comboBoxEndhours.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEndhours.Name = "comboBoxEndhours";
            this.comboBoxEndhours.Size = new System.Drawing.Size(67, 31);
            this.comboBoxEndhours.TabIndex = 36;
            this.comboBoxEndhours.Visible = false;
            this.comboBoxEndhours.SelectedIndexChanged += new System.EventHandler(this.comboBoxEndhours_SelectedIndexChanged);
            // 
            // labelStartHour
            // 
            this.labelStartHour.AutoSize = true;
            this.labelStartHour.Location = new System.Drawing.Point(766, 58);
            this.labelStartHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartHour.Name = "labelStartHour";
            this.labelStartHour.Size = new System.Drawing.Size(51, 23);
            this.labelStartHour.TabIndex = 35;
            this.labelStartHour.Text = "Time:";
            this.labelStartHour.Visible = false;
            // 
            // comboBoxHours
            // 
            this.comboBoxHours.FormattingEnabled = true;
            this.comboBoxHours.Location = new System.Drawing.Point(825, 55);
            this.comboBoxHours.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxHours.Name = "comboBoxHours";
            this.comboBoxHours.Size = new System.Drawing.Size(64, 31);
            this.comboBoxHours.TabIndex = 34;
            this.comboBoxHours.Visible = false;
            this.comboBoxHours.SelectedIndexChanged += new System.EventHandler(this.comboBoxHours_SelectedIndexChanged);
            // 
            // labelPaytype
            // 
            this.labelPaytype.AutoSize = true;
            this.labelPaytype.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.labelPaytype.Location = new System.Drawing.Point(405, 292);
            this.labelPaytype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPaytype.Name = "labelPaytype";
            this.labelPaytype.Size = new System.Drawing.Size(80, 23);
            this.labelPaytype.TabIndex = 33;
            this.labelPaytype.Text = "Pay Type:";
            this.labelPaytype.Visible = false;
            // 
            // comboBoxPayType
            // 
            this.comboBoxPayType.FormattingEnabled = true;
            this.comboBoxPayType.Location = new System.Drawing.Point(504, 289);
            this.comboBoxPayType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPayType.Name = "comboBoxPayType";
            this.comboBoxPayType.Size = new System.Drawing.Size(219, 31);
            this.comboBoxPayType.TabIndex = 32;
            this.comboBoxPayType.Visible = false;
            // 
            // dateTimePickerDateAsOf
            // 
            this.dateTimePickerDateAsOf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateAsOf.Location = new System.Drawing.Point(504, 244);
            this.dateTimePickerDateAsOf.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDateAsOf.Name = "dateTimePickerDateAsOf";
            this.dateTimePickerDateAsOf.Size = new System.Drawing.Size(220, 30);
            this.dateTimePickerDateAsOf.TabIndex = 30;
            this.dateTimePickerDateAsOf.Visible = false;
            // 
            // labelDateAsOf
            // 
            this.labelDateAsOf.AutoSize = true;
            this.labelDateAsOf.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.labelDateAsOf.Location = new System.Drawing.Point(406, 248);
            this.labelDateAsOf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateAsOf.Name = "labelDateAsOf";
            this.labelDateAsOf.Size = new System.Drawing.Size(91, 23);
            this.labelDateAsOf.TabIndex = 31;
            this.labelDateAsOf.Text = "Date as of:";
            this.labelDateAsOf.Visible = false;
            // 
            // comboBoxSalesAgent
            // 
            this.comboBoxSalesAgent.FormattingEnabled = true;
            this.comboBoxSalesAgent.Location = new System.Drawing.Point(504, 205);
            this.comboBoxSalesAgent.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSalesAgent.Name = "comboBoxSalesAgent";
            this.comboBoxSalesAgent.Size = new System.Drawing.Size(419, 31);
            this.comboBoxSalesAgent.TabIndex = 28;
            this.comboBoxSalesAgent.Visible = false;
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.labelAgent.Location = new System.Drawing.Point(398, 209);
            this.labelAgent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(103, 23);
            this.labelAgent.TabIndex = 29;
            this.labelAgent.Text = "Sales Agent:";
            this.labelAgent.Visible = false;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(504, 164);
            this.comboBoxCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(419, 31);
            this.comboBoxCustomer.TabIndex = 26;
            this.comboBoxCustomer.Visible = false;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.labelCustomer.Location = new System.Drawing.Point(409, 168);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(88, 23);
            this.labelCustomer.TabIndex = 27;
            this.labelCustomer.Text = "Customer:";
            this.labelCustomer.Visible = false;
            // 
            // comboBoxTerminal
            // 
            this.comboBoxTerminal.FormattingEnabled = true;
            this.comboBoxTerminal.Location = new System.Drawing.Point(504, 128);
            this.comboBoxTerminal.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTerminal.Name = "comboBoxTerminal";
            this.comboBoxTerminal.Size = new System.Drawing.Size(220, 31);
            this.comboBoxTerminal.TabIndex = 2;
            this.comboBoxTerminal.Visible = false;
            // 
            // labelTerminal
            // 
            this.labelTerminal.AutoSize = true;
            this.labelTerminal.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.labelTerminal.Location = new System.Drawing.Point(420, 130);
            this.labelTerminal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTerminal.Name = "labelTerminal";
            this.labelTerminal.Size = new System.Drawing.Size(78, 23);
            this.labelTerminal.TabIndex = 25;
            this.labelTerminal.Text = "Terminal:";
            this.labelTerminal.Visible = false;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(504, 55);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(220, 30);
            this.dateTimePickerStartDate.TabIndex = 0;
            this.dateTimePickerStartDate.Visible = false;
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.labelStartDate.Location = new System.Drawing.Point(406, 58);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(90, 23);
            this.labelStartDate.TabIndex = 23;
            this.labelStartDate.Text = "Start Date:";
            this.labelStartDate.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.listBoxSalesReport);
            this.panel2.Location = new System.Drawing.Point(12, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 543);
            this.panel2.TabIndex = 22;
            // 
            // listBoxSalesReport
            // 
            this.listBoxSalesReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSalesReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSalesReport.FormattingEnabled = true;
            this.listBoxSalesReport.ItemHeight = 23;
            this.listBoxSalesReport.Items.AddRange(new object[] {
            "Sales Summary Report",
            "Sales Detail Report",
            "Sales Return Detail Report",
            "",
            "Collection Summary Report",
            "Collection Detail Report",
            "Collection Detail Report (Facepay)",
            "",
            "80mm Sales Summary Report",
            "80mm Sales Detail Report",
            "80mm Sales Status Report",
            "80mm Collection Detail Report",
            "",
            "80mm Hourly Top Selling Sales Report",
            "80mm Item Sales Filtered By Category",
            "",
            "Cancelled Summary Report",
            "Stock Withdrawal Report",
            "",
            "Sales Summary Reward Report",
            "",
            "Net Sales Summary Report - Monthly",
            "Net Sales Summary Report - Daily",
            "",
            "Top Selling Items Report",
            "Hourly Top Selling Sales Report",
            "",
            "Customer List Report",
            "Unsold Item Report",
            "Cost Of Sales Report",
            "",
            "Accounts Receivable",
            "",
            "Statement Of Account"});
            this.listBoxSalesReport.Location = new System.Drawing.Point(0, 0);
            this.listBoxSalesReport.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSalesReport.Name = "listBoxSalesReport";
            this.listBoxSalesReport.Size = new System.Drawing.Size(380, 543);
            this.listBoxSalesReport.TabIndex = 4;
            this.listBoxSalesReport.SelectedIndexChanged += new System.EventHandler(this.listBoxSalesReport_SelectedIndexChanged);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(504, 91);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(220, 30);
            this.dateTimePickerEndDate.TabIndex = 1;
            this.dateTimePickerEndDate.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(398, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 38);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filters";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.labelEndDate.Location = new System.Drawing.Point(414, 94);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(84, 23);
            this.labelEndDate.TabIndex = 18;
            this.labelEndDate.Text = "End Date:";
            this.labelEndDate.Visible = false;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 62);
            this.panel1.TabIndex = 7;
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
            this.buttonView.Location = new System.Drawing.Point(948, 12);
            this.buttonView.Margin = new System.Windows.Forms.Padding(2);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(88, 40);
            this.buttonView.TabIndex = 5;
            this.buttonView.TabStop = false;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_OnClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Reports;
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
            this.label1.Size = new System.Drawing.Size(162, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales Report";
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
            this.buttonClose.Location = new System.Drawing.Point(1041, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 40);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_OnClick);
            // 
            // printDialogStockWithdrawalReport
            // 
            this.printDialogStockWithdrawalReport.UseEXDialog = true;
            // 
            // RepSalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1141, 624);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "RepSalesReportForm";
            this.Text = "SalesReportForm";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.ComboBox comboBoxTerminal;
        private System.Windows.Forms.Label labelTerminal;
        private System.Windows.Forms.PrintDialog printDialogStockWithdrawalReport;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogStockWithdrawalReport;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogCollectionDetailReportFacepay;
        private System.Windows.Forms.ListBox listBoxSalesReport;
        private System.Windows.Forms.ComboBox comboBoxSalesAgent;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateAsOf;
        private System.Windows.Forms.Label labelDateAsOf;
        private System.Windows.Forms.Label labelPaytype;
        private System.Windows.Forms.ComboBox comboBoxPayType;
        private System.Windows.Forms.Label labelStartHour;
        private System.Windows.Forms.ComboBox comboBoxHours;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.ComboBox comboBoxEndhours;
    }
}