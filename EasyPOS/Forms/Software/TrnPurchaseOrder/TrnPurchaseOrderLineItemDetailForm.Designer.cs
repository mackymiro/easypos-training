namespace EasyPOS.Forms.Software.TrnPurchaseOrder
{
    partial class TrnPurchaseOrderLineItemDetailForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPurchaseOrderLineAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPurchaseOrderLineCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPurchaseOrderLineItemDescription = new System.Windows.Forms.TextBox();
            this.textBoxPurchaseOrderLineQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPurchaseOrderLineUnit = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(642, 77);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.PurchaseOrder;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Purchase Order Item";
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
            this.buttonClose.Location = new System.Drawing.Point(522, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 49);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.TabStop = false;
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
            this.buttonSave.Location = new System.Drawing.Point(410, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 49);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.TabStop = false;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxPurchaseOrderLineAmount);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxPurchaseOrderLineCost);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxPurchaseOrderLineItemDescription);
            this.panel2.Controls.Add(this.textBoxPurchaseOrderLineQuantity);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxPurchaseOrderLineUnit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 283);
            this.panel2.TabIndex = 10;
            // 
            // textBoxPurchaseOrderLineAmount
            // 
            this.textBoxPurchaseOrderLineAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxPurchaseOrderLineAmount.Location = new System.Drawing.Point(117, 191);
            this.textBoxPurchaseOrderLineAmount.Name = "textBoxPurchaseOrderLineAmount";
            this.textBoxPurchaseOrderLineAmount.ReadOnly = true;
            this.textBoxPurchaseOrderLineAmount.Size = new System.Drawing.Size(211, 35);
            this.textBoxPurchaseOrderLineAmount.TabIndex = 3;
            this.textBoxPurchaseOrderLineAmount.TabStop = false;
            this.textBoxPurchaseOrderLineAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPurchaseOrderLineAmount.TextChanged += new System.EventHandler(this.textBoxPurchaseOrderLineAmount_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label9.Location = new System.Drawing.Point(21, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 30);
            this.label9.TabIndex = 23;
            this.label9.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(51, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cost:";
            // 
            // textBoxPurchaseOrderLineCost
            // 
            this.textBoxPurchaseOrderLineCost.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxPurchaseOrderLineCost.Location = new System.Drawing.Point(117, 145);
            this.textBoxPurchaseOrderLineCost.Name = "textBoxPurchaseOrderLineCost";
            this.textBoxPurchaseOrderLineCost.Size = new System.Drawing.Size(211, 35);
            this.textBoxPurchaseOrderLineCost.TabIndex = 2;
            this.textBoxPurchaseOrderLineCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPurchaseOrderLineCost.TextChanged += new System.EventHandler(this.textBoxPurchaseOrderLineCost_TextChanged);
            this.textBoxPurchaseOrderLineCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPurchaseOrderLineCost_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quantity:";
            // 
            // textBoxPurchaseOrderLineItemDescription
            // 
            this.textBoxPurchaseOrderLineItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPurchaseOrderLineItemDescription.BackColor = System.Drawing.Color.White;
            this.textBoxPurchaseOrderLineItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPurchaseOrderLineItemDescription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxPurchaseOrderLineItemDescription.Location = new System.Drawing.Point(15, 8);
            this.textBoxPurchaseOrderLineItemDescription.Name = "textBoxPurchaseOrderLineItemDescription";
            this.textBoxPurchaseOrderLineItemDescription.ReadOnly = true;
            this.textBoxPurchaseOrderLineItemDescription.Size = new System.Drawing.Size(614, 38);
            this.textBoxPurchaseOrderLineItemDescription.TabIndex = 12;
            this.textBoxPurchaseOrderLineItemDescription.TabStop = false;
            this.textBoxPurchaseOrderLineItemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPurchaseOrderLineQuantity
            // 
            this.textBoxPurchaseOrderLineQuantity.AcceptsTab = true;
            this.textBoxPurchaseOrderLineQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxPurchaseOrderLineQuantity.HideSelection = false;
            this.textBoxPurchaseOrderLineQuantity.Location = new System.Drawing.Point(117, 54);
            this.textBoxPurchaseOrderLineQuantity.Name = "textBoxPurchaseOrderLineQuantity";
            this.textBoxPurchaseOrderLineQuantity.Size = new System.Drawing.Size(211, 35);
            this.textBoxPurchaseOrderLineQuantity.TabIndex = 0;
            this.textBoxPurchaseOrderLineQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPurchaseOrderLineQuantity.TextChanged += new System.EventHandler(this.textBoxPurchaseOrderLineQuantity_TextChanged);
            this.textBoxPurchaseOrderLineQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPurchaseOrderLineQuantity_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.Location = new System.Drawing.Point(56, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Unit:";
            // 
            // textBoxPurchaseOrderLineUnit
            // 
            this.textBoxPurchaseOrderLineUnit.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBoxPurchaseOrderLineUnit.Location = new System.Drawing.Point(117, 98);
            this.textBoxPurchaseOrderLineUnit.Name = "textBoxPurchaseOrderLineUnit";
            this.textBoxPurchaseOrderLineUnit.ReadOnly = true;
            this.textBoxPurchaseOrderLineUnit.Size = new System.Drawing.Size(139, 35);
            this.textBoxPurchaseOrderLineUnit.TabIndex = 1;
            this.textBoxPurchaseOrderLineUnit.TabStop = false;
            // 
            // TrnPurchaseOrderLineItemDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 360);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TrnPurchaseOrderLineItemDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrnPurchaseOrderLineItemDetailForm";
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
        private System.Windows.Forms.TextBox textBoxPurchaseOrderLineAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPurchaseOrderLineCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPurchaseOrderLineItemDescription;
        private System.Windows.Forms.TextBox textBoxPurchaseOrderLineQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPurchaseOrderLineUnit;
    }
}