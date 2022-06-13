﻿namespace EasyPOS.Forms.Software.SysSystemTables
{
    partial class SysSupplierDetailForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysSupplierDetailForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonUnlock = new System.Windows.Forms.Button();
			this.buttonLock = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.comboBoxTerm = new System.Windows.Forms.ComboBox();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.Term = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxSupplier = new System.Windows.Forms.TextBox();
			this.textBoxCellphoneNumber = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxTelephoneNumber = new System.Windows.Forms.TextBox();
			this.textBoxFaxNumber = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxTIN = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxAccount = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.buttonUnlock);
			this.panel1.Controls.Add(this.buttonLock);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.buttonClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(676, 76);
			this.panel1.TabIndex = 6;
			// 
			// buttonUnlock
			// 
			this.buttonUnlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUnlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
			this.buttonUnlock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
			this.buttonUnlock.FlatAppearance.BorderSize = 0;
			this.buttonUnlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUnlock.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUnlock.ForeColor = System.Drawing.Color.White;
			this.buttonUnlock.Location = new System.Drawing.Point(445, 14);
			this.buttonUnlock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonUnlock.Name = "buttonUnlock";
			this.buttonUnlock.Size = new System.Drawing.Size(106, 48);
			this.buttonUnlock.TabIndex = 21;
			this.buttonUnlock.TabStop = false;
			this.buttonUnlock.Text = "Unlock";
			this.buttonUnlock.UseVisualStyleBackColor = false;
			this.buttonUnlock.Click += new System.EventHandler(this.buttonUnlock_Click);
			// 
			// buttonLock
			// 
			this.buttonLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
			this.buttonLock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
			this.buttonLock.FlatAppearance.BorderSize = 0;
			this.buttonLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLock.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLock.ForeColor = System.Drawing.Color.White;
			this.buttonLock.Location = new System.Drawing.Point(334, 14);
			this.buttonLock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonLock.Name = "buttonLock";
			this.buttonLock.Size = new System.Drawing.Size(106, 48);
			this.buttonLock.TabIndex = 20;
			this.buttonLock.TabStop = false;
			this.buttonLock.Text = "Lock";
			this.buttonLock.UseVisualStyleBackColor = false;
			this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(76, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Supplier Detail";
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
			this.buttonClose.Location = new System.Drawing.Point(556, 14);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(106, 48);
			this.buttonClose.TabIndex = 22;
			this.buttonClose.TabStop = false;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// comboBoxTerm
			// 
			this.comboBoxTerm.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.comboBoxTerm.FormattingEnabled = true;
			this.comboBoxTerm.Location = new System.Drawing.Point(170, 392);
			this.comboBoxTerm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBoxTerm.Name = "comboBoxTerm";
			this.comboBoxTerm.Size = new System.Drawing.Size(268, 36);
			this.comboBoxTerm.TabIndex = 5;
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textBoxAddress.Location = new System.Drawing.Point(170, 126);
			this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxAddress.Multiline = true;
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(490, 129);
			this.textBoxAddress.TabIndex = 1;
			// 
			// Term
			// 
			this.Term.AutoSize = true;
			this.Term.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.Term.Location = new System.Drawing.Point(102, 396);
			this.Term.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Term.Name = "Term";
			this.Term.Size = new System.Drawing.Size(63, 30);
			this.Term.TabIndex = 16;
			this.Term.Text = "Term:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.label3.Location = new System.Drawing.Point(74, 130);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 30);
			this.label3.TabIndex = 15;
			this.label3.Text = "Address:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.label2.Location = new System.Drawing.Point(72, 86);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 30);
			this.label2.TabIndex = 14;
			this.label2.Text = "Supplier:";
			// 
			// textBoxSupplier
			// 
			this.textBoxSupplier.AcceptsTab = true;
			this.textBoxSupplier.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textBoxSupplier.HideSelection = false;
			this.textBoxSupplier.Location = new System.Drawing.Point(170, 83);
			this.textBoxSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxSupplier.Name = "textBoxSupplier";
			this.textBoxSupplier.Size = new System.Drawing.Size(490, 35);
			this.textBoxSupplier.TabIndex = 0;
			// 
			// textBoxCellphoneNumber
			// 
			this.textBoxCellphoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textBoxCellphoneNumber.Location = new System.Drawing.Point(170, 306);
			this.textBoxCellphoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxCellphoneNumber.Name = "textBoxCellphoneNumber";
			this.textBoxCellphoneNumber.Size = new System.Drawing.Size(490, 35);
			this.textBoxCellphoneNumber.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.label5.Location = new System.Drawing.Point(16, 310);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(150, 30);
			this.label5.TabIndex = 21;
			this.label5.Text = "Cellphone No.:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.label6.Location = new System.Drawing.Point(14, 266);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(152, 30);
			this.label6.TabIndex = 20;
			this.label6.Text = "Telephone No.:";
			// 
			// textBoxTelephoneNumber
			// 
			this.textBoxTelephoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textBoxTelephoneNumber.Location = new System.Drawing.Point(170, 263);
			this.textBoxTelephoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxTelephoneNumber.Name = "textBoxTelephoneNumber";
			this.textBoxTelephoneNumber.Size = new System.Drawing.Size(490, 35);
			this.textBoxTelephoneNumber.TabIndex = 2;
			// 
			// textBoxFaxNumber
			// 
			this.textBoxFaxNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textBoxFaxNumber.Location = new System.Drawing.Point(170, 349);
			this.textBoxFaxNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxFaxNumber.Name = "textBoxFaxNumber";
			this.textBoxFaxNumber.Size = new System.Drawing.Size(380, 35);
			this.textBoxFaxNumber.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.label7.Location = new System.Drawing.Point(79, 353);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 30);
			this.label7.TabIndex = 23;
			this.label7.Text = "Fax No.:";
			// 
			// textBoxTIN
			// 
			this.textBoxTIN.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textBoxTIN.Location = new System.Drawing.Point(170, 437);
			this.textBoxTIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxTIN.Name = "textBoxTIN";
			this.textBoxTIN.Size = new System.Drawing.Size(380, 35);
			this.textBoxTIN.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(122, 446);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 20);
			this.label4.TabIndex = 27;
			this.label4.Text = "TIN:";
			// 
			// comboBoxAccount
			// 
			this.comboBoxAccount.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.comboBoxAccount.FormattingEnabled = true;
			this.comboBoxAccount.Location = new System.Drawing.Point(170, 480);
			this.comboBoxAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBoxAccount.Name = "comboBoxAccount";
			this.comboBoxAccount.Size = new System.Drawing.Size(380, 36);
			this.comboBoxAccount.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.label8.Location = new System.Drawing.Point(71, 484);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 30);
			this.label8.TabIndex = 25;
			this.label8.Text = "Account:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EasyPOS.Properties.Resources.System_Tables;
			this.pictureBox1.Location = new System.Drawing.Point(14, 14);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(58, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// SysSupplierDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(676, 527);
			this.Controls.Add(this.textBoxTIN);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBoxAccount);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBoxFaxNumber);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBoxCellphoneNumber);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxTelephoneNumber);
			this.Controls.Add(this.comboBoxTerm);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.Term);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxSupplier);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "SysSupplierDetailForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Supplier Detail";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox comboBoxTerm;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label Term;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.TextBox textBoxCellphoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTelephoneNumber;
        private System.Windows.Forms.TextBox textBoxFaxNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonUnlock;
    }
}