namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSTenderCheckInformation
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSTenderCheckInformation));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dateTimePickerCheckDate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxCheckBank = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxAmount = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxCheckNumber = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.buttonClose);
			this.panel1.Controls.Add(this.buttonOK);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(770, 75);
			this.panel1.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(75, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Check Information";
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
			this.buttonClose.Location = new System.Drawing.Point(591, 15);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(164, 48);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.TabStop = false;
			this.buttonClose.Text = "Esc - Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
			this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
			this.buttonOK.FlatAppearance.BorderSize = 0;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonOK.ForeColor = System.Drawing.Color.White;
			this.buttonOK.Location = new System.Drawing.Point(417, 15);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(168, 48);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.TabStop = false;
			this.buttonOK.Text = "Ent - OK";
			this.buttonOK.UseVisualStyleBackColor = false;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dateTimePickerCheckDate);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.textBoxCheckBank);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.textBoxAmount);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.textBoxCheckNumber);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 75);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(770, 217);
			this.panel2.TabIndex = 9;
			// 
			// dateTimePickerCheckDate
			// 
			this.dateTimePickerCheckDate.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.dateTimePickerCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerCheckDate.Location = new System.Drawing.Point(202, 60);
			this.dateTimePickerCheckDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimePickerCheckDate.Name = "dateTimePickerCheckDate";
			this.dateTimePickerCheckDate.Size = new System.Drawing.Size(210, 39);
			this.dateTimePickerCheckDate.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label5.Location = new System.Drawing.Point(126, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 32);
			this.label5.TabIndex = 39;
			this.label5.Text = "Bank:";
			// 
			// textBoxCheckBank
			// 
			this.textBoxCheckBank.AcceptsTab = true;
			this.textBoxCheckBank.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxCheckBank.HideSelection = false;
			this.textBoxCheckBank.Location = new System.Drawing.Point(202, 110);
			this.textBoxCheckBank.Name = "textBoxCheckBank";
			this.textBoxCheckBank.Size = new System.Drawing.Size(548, 39);
			this.textBoxCheckBank.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label3.Location = new System.Drawing.Point(60, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 32);
			this.label3.TabIndex = 35;
			this.label3.Text = "Check Date:";
			// 
			// textBoxAmount
			// 
			this.textBoxAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxAmount.Location = new System.Drawing.Point(202, 159);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.Size = new System.Drawing.Size(380, 39);
			this.textBoxAmount.TabIndex = 3;
			this.textBoxAmount.Text = "0.00";
			this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmount_KeyPress);
			this.textBoxAmount.Leave += new System.EventHandler(this.textBoxAmount_Leave);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label6.Location = new System.Drawing.Point(93, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(106, 32);
			this.label6.TabIndex = 33;
			this.label6.Text = "Amount:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label7.Location = new System.Drawing.Point(21, 15);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(180, 32);
			this.label7.TabIndex = 32;
			this.label7.Text = "Check Number:";
			// 
			// textBoxCheckNumber
			// 
			this.textBoxCheckNumber.AcceptsTab = true;
			this.textBoxCheckNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxCheckNumber.HideSelection = false;
			this.textBoxCheckNumber.Location = new System.Drawing.Point(202, 10);
			this.textBoxCheckNumber.Name = "textBoxCheckNumber";
			this.textBoxCheckNumber.Size = new System.Drawing.Size(548, 39);
			this.textBoxCheckNumber.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EasyPOS.Properties.Resources.POS;
			this.pictureBox1.Location = new System.Drawing.Point(15, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(57, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// TrnPOSTenderCheckInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(770, 292);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "TrnPOSTenderCheckInformation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Check Information";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCheckBank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCheckNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckDate;
    }
}