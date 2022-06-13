﻿namespace EasyPOS.Forms.Software.TrnStockIn
{
    partial class TrnStockInLineItemDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnStockInLineItemDetailForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxExpiryDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxStockInLinePrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStockInLineLotNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStockInLineAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStockInLineCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStockInLineItemDescription = new System.Windows.Forms.TextBox();
            this.textBoxStockInLineQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStockInLineUnit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 75);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Stock_In;
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
            this.label1.Location = new System.Drawing.Point(75, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock-In Item";
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
            this.buttonClose.Location = new System.Drawing.Point(704, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 48);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(591, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 48);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxExpiryDate);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxStockInLinePrice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxStockInLineLotNumber);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxStockInLineAmount);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxStockInLineCost);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxStockInLineItemDescription);
            this.panel2.Controls.Add(this.textBoxStockInLineQuantity);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxStockInLineUnit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 354);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(692, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "(mm/dd/yyyy)";
            // 
            // textBoxExpiryDate
            // 
            this.textBoxExpiryDate.AcceptsTab = true;
            this.textBoxExpiryDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxExpiryDate.HideSelection = false;
            this.textBoxExpiryDate.Location = new System.Drawing.Point(471, 128);
            this.textBoxExpiryDate.Name = "textBoxExpiryDate";
            this.textBoxExpiryDate.Size = new System.Drawing.Size(211, 35);
            this.textBoxExpiryDate.TabIndex = 3;
            this.textBoxExpiryDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label8.Location = new System.Drawing.Point(56, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 30);
            this.label8.TabIndex = 32;
            this.label8.Text = "Price:";
            // 
            // textBoxStockInLinePrice
            // 
            this.textBoxStockInLinePrice.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxStockInLinePrice.Location = new System.Drawing.Point(123, 300);
            this.textBoxStockInLinePrice.Name = "textBoxStockInLinePrice";
            this.textBoxStockInLinePrice.Size = new System.Drawing.Size(211, 35);
            this.textBoxStockInLinePrice.TabIndex = 2;
            this.textBoxStockInLinePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxStockInLinePrice.TextChanged += new System.EventHandler(this.textBoxStockInLinePrice_TextChanged);
            this.textBoxStockInLinePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStockInLinePrice_KeyPress);
            this.textBoxStockInLinePrice.Leave += new System.EventHandler(this.textBoxStockInLinePrice_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(342, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 30);
            this.label7.TabIndex = 30;
            this.label7.Text = "Lot Number:";
            // 
            // textBoxStockInLineLotNumber
            // 
            this.textBoxStockInLineLotNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxStockInLineLotNumber.Location = new System.Drawing.Point(471, 176);
            this.textBoxStockInLineLotNumber.Name = "textBoxStockInLineLotNumber";
            this.textBoxStockInLineLotNumber.Size = new System.Drawing.Size(229, 35);
            this.textBoxStockInLineLotNumber.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(350, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 30);
            this.label6.TabIndex = 28;
            this.label6.Text = "Expiry Date:";
            // 
            // textBoxStockInLineAmount
            // 
            this.textBoxStockInLineAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxStockInLineAmount.Location = new System.Drawing.Point(123, 258);
            this.textBoxStockInLineAmount.Name = "textBoxStockInLineAmount";
            this.textBoxStockInLineAmount.ReadOnly = true;
            this.textBoxStockInLineAmount.Size = new System.Drawing.Size(211, 35);
            this.textBoxStockInLineAmount.TabIndex = 8;
            this.textBoxStockInLineAmount.TabStop = false;
            this.textBoxStockInLineAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label9.Location = new System.Drawing.Point(26, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 30);
            this.label9.TabIndex = 23;
            this.label9.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(58, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cost:";
            // 
            // textBoxStockInLineCost
            // 
            this.textBoxStockInLineCost.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxStockInLineCost.Location = new System.Drawing.Point(123, 214);
            this.textBoxStockInLineCost.Name = "textBoxStockInLineCost";
            this.textBoxStockInLineCost.Size = new System.Drawing.Size(211, 35);
            this.textBoxStockInLineCost.TabIndex = 1;
            this.textBoxStockInLineCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxStockInLineCost.TextChanged += new System.EventHandler(this.textBoxStockInLineCost_TextChanged);
            this.textBoxStockInLineCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStockInLineCost_KeyPress);
            this.textBoxStockInLineCost.Leave += new System.EventHandler(this.textBoxStockInLineCost_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(21, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quantity:";
            // 
            // textBoxStockInLineItemDescription
            // 
            this.textBoxStockInLineItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStockInLineItemDescription.BackColor = System.Drawing.Color.White;
            this.textBoxStockInLineItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStockInLineItemDescription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxStockInLineItemDescription.Location = new System.Drawing.Point(16, 81);
            this.textBoxStockInLineItemDescription.Name = "textBoxStockInLineItemDescription";
            this.textBoxStockInLineItemDescription.ReadOnly = true;
            this.textBoxStockInLineItemDescription.Size = new System.Drawing.Size(795, 38);
            this.textBoxStockInLineItemDescription.TabIndex = 12;
            this.textBoxStockInLineItemDescription.TabStop = false;
            this.textBoxStockInLineItemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStockInLineQuantity
            // 
            this.textBoxStockInLineQuantity.AcceptsTab = true;
            this.textBoxStockInLineQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxStockInLineQuantity.HideSelection = false;
            this.textBoxStockInLineQuantity.Location = new System.Drawing.Point(123, 132);
            this.textBoxStockInLineQuantity.Name = "textBoxStockInLineQuantity";
            this.textBoxStockInLineQuantity.Size = new System.Drawing.Size(211, 35);
            this.textBoxStockInLineQuantity.TabIndex = 0;
            this.textBoxStockInLineQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxStockInLineQuantity.TextChanged += new System.EventHandler(this.textBoxStockInLineQuantity_TextChanged);
            this.textBoxStockInLineQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStockInLineQuantity_KeyPress);
            this.textBoxStockInLineQuantity.Leave += new System.EventHandler(this.textBoxStockInLineQuantity_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(62, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Unit:";
            // 
            // textBoxStockInLineUnit
            // 
            this.textBoxStockInLineUnit.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxStockInLineUnit.Location = new System.Drawing.Point(123, 171);
            this.textBoxStockInLineUnit.Name = "textBoxStockInLineUnit";
            this.textBoxStockInLineUnit.ReadOnly = true;
            this.textBoxStockInLineUnit.Size = new System.Drawing.Size(139, 35);
            this.textBoxStockInLineUnit.TabIndex = 9;
            this.textBoxStockInLineUnit.TabStop = false;
            // 
            // TrnStockInLineItemDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(824, 354);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TrnStockInLineItemDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock-In Line Item Detail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStockInLineItemDescription;
        private System.Windows.Forms.TextBox textBoxStockInLineQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStockInLineUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStockInLineCost;
        private System.Windows.Forms.TextBox textBoxStockInLineAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxStockInLinePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStockInLineLotNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxExpiryDate;
    }
}