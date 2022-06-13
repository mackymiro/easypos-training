namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSRefundForm
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
            this.buttonRefund = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxDisbursementNo = new System.Windows.Forms.TextBox();
            this.textBoxPeriodId = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxDisbursementDate = new System.Windows.Forms.TextBox();
            this.textBoxPayType = new System.Windows.Forms.TextBox();
            this.textBoxTerminal = new System.Windows.Forms.TextBox();
            this.textBoxApprovedBy = new System.Windows.Forms.TextBox();
            this.textBoxCheckedBy = new System.Windows.Forms.TextBox();
            this.textBoxPreparedBy = new System.Windows.Forms.TextBox();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxStockInNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBoxIsRefund = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonRefund);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 62);
            this.panel1.TabIndex = 7;
            // 
            // buttonRefund
            // 
            this.buttonRefund.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonRefund.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonRefund.FlatAppearance.BorderSize = 0;
            this.buttonRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefund.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefund.ForeColor = System.Drawing.Color.White;
            this.buttonRefund.Location = new System.Drawing.Point(732, 12);
            this.buttonRefund.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefund.Name = "buttonRefund";
            this.buttonRefund.Size = new System.Drawing.Size(135, 40);
            this.buttonRefund.TabIndex = 7;
            this.buttonRefund.TabStop = false;
            this.buttonRefund.Text = "Refund";
            this.buttonRefund.UseVisualStyleBackColor = false;
            this.buttonRefund.Click += new System.EventHandler(this.buttonRefund_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.POS;
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
            this.label1.Size = new System.Drawing.Size(99, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Refund";
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
            this.buttonClose.Location = new System.Drawing.Point(872, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(137, 40);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Esc - Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // textBoxDisbursementNo
            // 
            this.textBoxDisbursementNo.AcceptsTab = true;
            this.textBoxDisbursementNo.Enabled = false;
            this.textBoxDisbursementNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDisbursementNo.HideSelection = false;
            this.textBoxDisbursementNo.Location = new System.Drawing.Point(203, 77);
            this.textBoxDisbursementNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDisbursementNo.Name = "textBoxDisbursementNo";
            this.textBoxDisbursementNo.Size = new System.Drawing.Size(252, 34);
            this.textBoxDisbursementNo.TabIndex = 19;
            // 
            // textBoxPeriodId
            // 
            this.textBoxPeriodId.AcceptsTab = true;
            this.textBoxPeriodId.Enabled = false;
            this.textBoxPeriodId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPeriodId.HideSelection = false;
            this.textBoxPeriodId.Location = new System.Drawing.Point(203, 115);
            this.textBoxPeriodId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPeriodId.Name = "textBoxPeriodId";
            this.textBoxPeriodId.Size = new System.Drawing.Size(123, 34);
            this.textBoxPeriodId.TabIndex = 20;
            // 
            // textBoxType
            // 
            this.textBoxType.AcceptsTab = true;
            this.textBoxType.Enabled = false;
            this.textBoxType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxType.HideSelection = false;
            this.textBoxType.Location = new System.Drawing.Point(203, 191);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(252, 34);
            this.textBoxType.TabIndex = 22;
            // 
            // textBoxDisbursementDate
            // 
            this.textBoxDisbursementDate.AcceptsTab = true;
            this.textBoxDisbursementDate.Enabled = false;
            this.textBoxDisbursementDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxDisbursementDate.HideSelection = false;
            this.textBoxDisbursementDate.Location = new System.Drawing.Point(203, 153);
            this.textBoxDisbursementDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDisbursementDate.Name = "textBoxDisbursementDate";
            this.textBoxDisbursementDate.Size = new System.Drawing.Size(252, 34);
            this.textBoxDisbursementDate.TabIndex = 21;
            // 
            // textBoxPayType
            // 
            this.textBoxPayType.AcceptsTab = true;
            this.textBoxPayType.Enabled = false;
            this.textBoxPayType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPayType.HideSelection = false;
            this.textBoxPayType.Location = new System.Drawing.Point(203, 267);
            this.textBoxPayType.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPayType.Name = "textBoxPayType";
            this.textBoxPayType.Size = new System.Drawing.Size(252, 34);
            this.textBoxPayType.TabIndex = 24;
            // 
            // textBoxTerminal
            // 
            this.textBoxTerminal.AcceptsTab = true;
            this.textBoxTerminal.Enabled = false;
            this.textBoxTerminal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxTerminal.HideSelection = false;
            this.textBoxTerminal.Location = new System.Drawing.Point(203, 229);
            this.textBoxTerminal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTerminal.Name = "textBoxTerminal";
            this.textBoxTerminal.Size = new System.Drawing.Size(123, 34);
            this.textBoxTerminal.TabIndex = 23;
            // 
            // textBoxApprovedBy
            // 
            this.textBoxApprovedBy.AcceptsTab = true;
            this.textBoxApprovedBy.Enabled = false;
            this.textBoxApprovedBy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxApprovedBy.HideSelection = false;
            this.textBoxApprovedBy.Location = new System.Drawing.Point(737, 305);
            this.textBoxApprovedBy.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxApprovedBy.Name = "textBoxApprovedBy";
            this.textBoxApprovedBy.Size = new System.Drawing.Size(252, 34);
            this.textBoxApprovedBy.TabIndex = 32;
            // 
            // textBoxCheckedBy
            // 
            this.textBoxCheckedBy.AcceptsTab = true;
            this.textBoxCheckedBy.Enabled = false;
            this.textBoxCheckedBy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxCheckedBy.HideSelection = false;
            this.textBoxCheckedBy.Location = new System.Drawing.Point(737, 267);
            this.textBoxCheckedBy.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCheckedBy.Name = "textBoxCheckedBy";
            this.textBoxCheckedBy.Size = new System.Drawing.Size(252, 34);
            this.textBoxCheckedBy.TabIndex = 31;
            // 
            // textBoxPreparedBy
            // 
            this.textBoxPreparedBy.AcceptsTab = true;
            this.textBoxPreparedBy.Enabled = false;
            this.textBoxPreparedBy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPreparedBy.HideSelection = false;
            this.textBoxPreparedBy.Location = new System.Drawing.Point(737, 229);
            this.textBoxPreparedBy.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPreparedBy.Name = "textBoxPreparedBy";
            this.textBoxPreparedBy.Size = new System.Drawing.Size(252, 34);
            this.textBoxPreparedBy.TabIndex = 30;
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.AcceptsTab = true;
            this.textBoxRemarks.Enabled = false;
            this.textBoxRemarks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxRemarks.HideSelection = false;
            this.textBoxRemarks.Location = new System.Drawing.Point(737, 191);
            this.textBoxRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(252, 34);
            this.textBoxRemarks.TabIndex = 29;
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.AcceptsTab = true;
            this.textBoxAccount.Enabled = false;
            this.textBoxAccount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxAccount.HideSelection = false;
            this.textBoxAccount.Location = new System.Drawing.Point(737, 153);
            this.textBoxAccount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(252, 34);
            this.textBoxAccount.TabIndex = 28;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.AcceptsTab = true;
            this.textBoxAmount.Enabled = false;
            this.textBoxAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxAmount.HideSelection = false;
            this.textBoxAmount.Location = new System.Drawing.Point(737, 115);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(130, 34);
            this.textBoxAmount.TabIndex = 27;
            // 
            // textBoxStockInNo
            // 
            this.textBoxStockInNo.AcceptsTab = true;
            this.textBoxStockInNo.Enabled = false;
            this.textBoxStockInNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxStockInNo.HideSelection = false;
            this.textBoxStockInNo.Location = new System.Drawing.Point(737, 77);
            this.textBoxStockInNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStockInNo.Name = "textBoxStockInNo";
            this.textBoxStockInNo.Size = new System.Drawing.Size(252, 34);
            this.textBoxStockInNo.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Disbursement No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(14, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Period Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(14, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Disbursement Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(14, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(14, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Terminal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(14, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 38;
            this.label7.Text = "Pay Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(14, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 39;
            this.label8.Tag = "";
            this.label8.Text = "IsRefund";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(531, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 23);
            this.label9.TabIndex = 46;
            this.label9.Text = "Approved By";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(531, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 23);
            this.label10.TabIndex = 45;
            this.label10.Text = "Checked By";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.Location = new System.Drawing.Point(531, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 23);
            this.label11.TabIndex = 44;
            this.label11.Text = "Prepared By";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.Location = new System.Drawing.Point(531, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 23);
            this.label12.TabIndex = 43;
            this.label12.Text = "Remarks";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.Location = new System.Drawing.Point(531, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 23);
            this.label13.TabIndex = 42;
            this.label13.Text = "Account";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label14.Location = new System.Drawing.Point(531, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 23);
            this.label14.TabIndex = 41;
            this.label14.Text = "Amount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label15.Location = new System.Drawing.Point(531, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 23);
            this.label15.TabIndex = 40;
            this.label15.Text = "Return Stock-In No.";
            // 
            // checkBoxIsRefund
            // 
            this.checkBoxIsRefund.AutoSize = true;
            this.checkBoxIsRefund.Location = new System.Drawing.Point(203, 314);
            this.checkBoxIsRefund.Name = "checkBoxIsRefund";
            this.checkBoxIsRefund.Size = new System.Drawing.Size(18, 17);
            this.checkBoxIsRefund.TabIndex = 47;
            this.checkBoxIsRefund.UseVisualStyleBackColor = true;
            // 
            // TrnPOSRefundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 368);
            this.Controls.Add(this.checkBoxIsRefund);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxApprovedBy);
            this.Controls.Add(this.textBoxCheckedBy);
            this.Controls.Add(this.textBoxPreparedBy);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.textBoxAccount);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxStockInNo);
            this.Controls.Add(this.textBoxPayType);
            this.Controls.Add(this.textBoxTerminal);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxDisbursementDate);
            this.Controls.Add(this.textBoxPeriodId);
            this.Controls.Add(this.textBoxDisbursementNo);
            this.Controls.Add(this.panel1);
            this.Name = "TrnPOSRefundForm";
            this.Text = "TrnPOSRefundForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRefund;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxDisbursementNo;
        private System.Windows.Forms.TextBox textBoxPeriodId;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxDisbursementDate;
        private System.Windows.Forms.TextBox textBoxPayType;
        private System.Windows.Forms.TextBox textBoxTerminal;
        private System.Windows.Forms.TextBox textBoxApprovedBy;
        private System.Windows.Forms.TextBox textBoxCheckedBy;
        private System.Windows.Forms.TextBox textBoxPreparedBy;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxStockInNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBoxIsRefund;
    }
}