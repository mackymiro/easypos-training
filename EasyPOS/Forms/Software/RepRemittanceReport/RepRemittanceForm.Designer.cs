namespace EasyPOS.Forms.Software.RepRemittanceReport
{
    partial class RepRemittanceForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepRemittanceForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonView = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dateTimePickerEndDateFilter = new System.Windows.Forms.DateTimePicker();
			this.labelEndDate = new System.Windows.Forms.Label();
			this.comboBoxRemittanceNumber = new System.Windows.Forms.ComboBox();
			this.labelRemittanceNumber = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.listBoxRemittanceReport = new System.Windows.Forms.ListBox();
			this.dateTimePickerStartDateFilter = new System.Windows.Forms.DateTimePicker();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.labelUser = new System.Windows.Forms.Label();
			this.labelTerminal = new System.Windows.Forms.Label();
			this.labelStartDate = new System.Windows.Forms.Label();
			this.comboBoxUser = new System.Windows.Forms.ComboBox();
			this.comboBoxTerminal = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
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
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1644, 75);
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
			this.buttonView.Location = new System.Drawing.Point(1412, 15);
			this.buttonView.Name = "buttonView";
			this.buttonView.Size = new System.Drawing.Size(105, 48);
			this.buttonView.TabIndex = 20;
			this.buttonView.TabStop = false;
			this.buttonView.Text = "View";
			this.buttonView.UseVisualStyleBackColor = false;
			this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Reports;
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
			this.label1.Location = new System.Drawing.Point(75, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(282, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Remittance Report";
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
			this.buttonClose.Location = new System.Drawing.Point(1524, 15);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(105, 48);
			this.buttonClose.TabIndex = 21;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_OnClick);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dateTimePickerEndDateFilter);
			this.panel4.Controls.Add(this.labelEndDate);
			this.panel4.Controls.Add(this.comboBoxRemittanceNumber);
			this.panel4.Controls.Add(this.labelRemittanceNumber);
			this.panel4.Controls.Add(this.panel2);
			this.panel4.Controls.Add(this.dateTimePickerStartDateFilter);
			this.panel4.Controls.Add(this.panel3);
			this.panel4.Controls.Add(this.labelUser);
			this.panel4.Controls.Add(this.labelTerminal);
			this.panel4.Controls.Add(this.labelStartDate);
			this.panel4.Controls.Add(this.comboBoxUser);
			this.panel4.Controls.Add(this.comboBoxTerminal);
			this.panel4.Controls.Add(this.panel1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1644, 840);
			this.panel4.TabIndex = 8;
			this.panel4.TabStop = true;
			// 
			// dateTimePickerEndDateFilter
			// 
			this.dateTimePickerEndDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerEndDateFilter.Location = new System.Drawing.Point(654, 231);
			this.dateTimePickerEndDateFilter.Name = "dateTimePickerEndDateFilter";
			this.dateTimePickerEndDateFilter.Size = new System.Drawing.Size(264, 35);
			this.dateTimePickerEndDateFilter.TabIndex = 34;
			this.dateTimePickerEndDateFilter.Visible = false;
			this.dateTimePickerEndDateFilter.ValueChanged += new System.EventHandler(this.dateTimePickerEndDateFilter_ValueChanged);
			// 
			// labelEndDate
			// 
			this.labelEndDate.AutoSize = true;
			this.labelEndDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.labelEndDate.Location = new System.Drawing.Point(543, 234);
			this.labelEndDate.Name = "labelEndDate";
			this.labelEndDate.Size = new System.Drawing.Size(103, 30);
			this.labelEndDate.TabIndex = 35;
			this.labelEndDate.Text = "End Date:";
			this.labelEndDate.Visible = false;
			// 
			// comboBoxRemittanceNumber
			// 
			this.comboBoxRemittanceNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.comboBoxRemittanceNumber.FormattingEnabled = true;
			this.comboBoxRemittanceNumber.Location = new System.Drawing.Point(654, 322);
			this.comboBoxRemittanceNumber.Name = "comboBoxRemittanceNumber";
			this.comboBoxRemittanceNumber.Size = new System.Drawing.Size(264, 36);
			this.comboBoxRemittanceNumber.TabIndex = 33;
			this.comboBoxRemittanceNumber.Visible = false;
			// 
			// labelRemittanceNumber
			// 
			this.labelRemittanceNumber.AutoSize = true;
			this.labelRemittanceNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.labelRemittanceNumber.Location = new System.Drawing.Point(488, 327);
			this.labelRemittanceNumber.Name = "labelRemittanceNumber";
			this.labelRemittanceNumber.Size = new System.Drawing.Size(161, 30);
			this.labelRemittanceNumber.TabIndex = 32;
			this.labelRemittanceNumber.Text = "Remittance No.:";
			this.labelRemittanceNumber.Visible = false;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.listBoxRemittanceReport);
			this.panel2.Location = new System.Drawing.Point(15, 82);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(456, 668);
			this.panel2.TabIndex = 30;
			// 
			// listBoxRemittanceReport
			// 
			this.listBoxRemittanceReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBoxRemittanceReport.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxRemittanceReport.FormattingEnabled = true;
			this.listBoxRemittanceReport.ItemHeight = 28;
			this.listBoxRemittanceReport.Items.AddRange(new object[] {
            "Remittance Report",
            "",
            "Cash In/Out Summary Report"});
			this.listBoxRemittanceReport.Location = new System.Drawing.Point(0, 0);
			this.listBoxRemittanceReport.Name = "listBoxRemittanceReport";
			this.listBoxRemittanceReport.Size = new System.Drawing.Size(456, 668);
			this.listBoxRemittanceReport.TabIndex = 4;
			this.listBoxRemittanceReport.SelectedIndexChanged += new System.EventHandler(this.listBoxRemittanceReport_SelectedIndexChanged);
			// 
			// dateTimePickerStartDateFilter
			// 
			this.dateTimePickerStartDateFilter.Checked = false;
			this.dateTimePickerStartDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerStartDateFilter.Location = new System.Drawing.Point(654, 186);
			this.dateTimePickerStartDateFilter.Name = "dateTimePickerStartDateFilter";
			this.dateTimePickerStartDateFilter.Size = new System.Drawing.Size(264, 35);
			this.dateTimePickerStartDateFilter.TabIndex = 1;
			this.dateTimePickerStartDateFilter.Visible = false;
			this.dateTimePickerStartDateFilter.ValueChanged += new System.EventHandler(this.dateTimePickerStartDateFilter_ValueChanged);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(477, 82);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1152, 45);
			this.panel3.TabIndex = 23;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(10, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 30);
			this.label2.TabIndex = 0;
			this.label2.Text = "Filters";
			// 
			// labelUser
			// 
			this.labelUser.AutoSize = true;
			this.labelUser.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.labelUser.Location = new System.Drawing.Point(585, 279);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(59, 30);
			this.labelUser.TabIndex = 28;
			this.labelUser.Text = "User:";
			this.labelUser.Visible = false;
			// 
			// labelTerminal
			// 
			this.labelTerminal.AutoSize = true;
			this.labelTerminal.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.labelTerminal.Location = new System.Drawing.Point(550, 146);
			this.labelTerminal.Name = "labelTerminal";
			this.labelTerminal.Size = new System.Drawing.Size(96, 30);
			this.labelTerminal.TabIndex = 25;
			this.labelTerminal.Text = "Terminal:";
			this.labelTerminal.Visible = false;
			// 
			// labelStartDate
			// 
			this.labelStartDate.AutoSize = true;
			this.labelStartDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.labelStartDate.Location = new System.Drawing.Point(534, 189);
			this.labelStartDate.Name = "labelStartDate";
			this.labelStartDate.Size = new System.Drawing.Size(110, 30);
			this.labelStartDate.TabIndex = 26;
			this.labelStartDate.Text = "Start Date:";
			this.labelStartDate.Visible = false;
			// 
			// comboBoxUser
			// 
			this.comboBoxUser.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.comboBoxUser.FormattingEnabled = true;
			this.comboBoxUser.Location = new System.Drawing.Point(654, 276);
			this.comboBoxUser.Name = "comboBoxUser";
			this.comboBoxUser.Size = new System.Drawing.Size(502, 36);
			this.comboBoxUser.TabIndex = 2;
			this.comboBoxUser.Visible = false;
			this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
			// 
			// comboBoxTerminal
			// 
			this.comboBoxTerminal.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.comboBoxTerminal.FormattingEnabled = true;
			this.comboBoxTerminal.Location = new System.Drawing.Point(654, 141);
			this.comboBoxTerminal.Name = "comboBoxTerminal";
			this.comboBoxTerminal.Size = new System.Drawing.Size(264, 36);
			this.comboBoxTerminal.TabIndex = 0;
			this.comboBoxTerminal.Visible = false;
			this.comboBoxTerminal.SelectedIndexChanged += new System.EventHandler(this.comboBoxTerminal_SelectedIndexChanged);
			// 
			// RepRemittanceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1644, 840);
			this.Controls.Add(this.panel4);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "RepRemittanceForm";
			this.Text = "RepRemittanceReportForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxRemittanceReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDateFilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelTerminal;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.ComboBox comboBoxTerminal;
        private System.Windows.Forms.Label labelRemittanceNumber;
        private System.Windows.Forms.ComboBox comboBoxRemittanceNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDateFilter;
        private System.Windows.Forms.Label labelEndDate;
    }
}