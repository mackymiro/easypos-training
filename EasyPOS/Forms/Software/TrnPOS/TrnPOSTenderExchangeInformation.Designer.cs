﻿namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSTenderExchangeInformation
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSTenderExchangeInformation));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBoxAmount = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxOrderReturnNumber = new System.Windows.Forms.TextBox();
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
			this.panel1.Size = new System.Drawing.Size(840, 75);
			this.panel1.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(75, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(329, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Exchange Information";
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
			this.buttonClose.Location = new System.Drawing.Point(660, 15);
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
			this.buttonOK.Location = new System.Drawing.Point(486, 15);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(168, 48);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.TabStop = false;
			this.buttonOK.Text = "F2- OK";
			this.buttonOK.UseVisualStyleBackColor = false;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.textBoxAmount);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.textBoxOrderReturnNumber);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 75);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(840, 123);
			this.panel2.TabIndex = 9;
			// 
			// textBoxAmount
			// 
			this.textBoxAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxAmount.Location = new System.Drawing.Point(218, 62);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.ReadOnly = true;
			this.textBoxAmount.Size = new System.Drawing.Size(434, 39);
			this.textBoxAmount.TabIndex = 1;
			this.textBoxAmount.TabStop = false;
			this.textBoxAmount.Text = "0.00";
			this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label9.Location = new System.Drawing.Point(108, 66);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(106, 32);
			this.label9.TabIndex = 23;
			this.label9.Text = "Amount:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label2.Location = new System.Drawing.Point(16, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(197, 32);
			this.label2.TabIndex = 13;
			this.label2.Text = "Order Return No.";
			// 
			// textBoxOrderReturnNumber
			// 
			this.textBoxOrderReturnNumber.AcceptsTab = true;
			this.textBoxOrderReturnNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBoxOrderReturnNumber.HideSelection = false;
			this.textBoxOrderReturnNumber.Location = new System.Drawing.Point(218, 12);
			this.textBoxOrderReturnNumber.Name = "textBoxOrderReturnNumber";
			this.textBoxOrderReturnNumber.Size = new System.Drawing.Size(604, 39);
			this.textBoxOrderReturnNumber.TabIndex = 0;
			this.textBoxOrderReturnNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOrderReturnNumber_KeyDown);
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
			// TrnPOSTenderExchangeInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(840, 198);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "TrnPOSTenderExchangeInformation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exchange Information";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOrderReturnNumber;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label9;
    }
}