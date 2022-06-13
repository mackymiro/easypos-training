namespace EasyPOS.Forms.Software.MstItem
{
    partial class MstItemComponentDetailForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MstItemComponentDetailForm));
			this.textBoxCost = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxQuantity = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBoxItemComponent = new System.Windows.Forms.ComboBox();
			this.textBoxAmount = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxOnHantQty = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxUnit = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxCost
			// 
			this.textBoxCost.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textBoxCost.Location = new System.Drawing.Point(193, 214);
			this.textBoxCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxCost.Name = "textBoxCost";
			this.textBoxCost.ReadOnly = true;
			this.textBoxCost.Size = new System.Drawing.Size(233, 35);
			this.textBoxCost.TabIndex = 3;
			this.textBoxCost.TabStop = false;
			this.textBoxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.label4.Location = new System.Drawing.Point(122, 214);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 30);
			this.label4.TabIndex = 22;
			this.label4.Text = "Cost:";
			// 
			// textBoxQuantity
			// 
			this.textBoxQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textBoxQuantity.Location = new System.Drawing.Point(193, 170);
			this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxQuantity.Name = "textBoxQuantity";
			this.textBoxQuantity.Size = new System.Drawing.Size(233, 35);
			this.textBoxQuantity.TabIndex = 2;
			this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
			this.textBoxQuantity.Leave += new System.EventHandler(this.textBoxQuantity_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.label3.Location = new System.Drawing.Point(85, 172);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 30);
			this.label3.TabIndex = 20;
			this.label3.Text = "Quantity:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.label2.Location = new System.Drawing.Point(127, 131);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 30);
			this.label2.TabIndex = 18;
			this.label2.Text = "Unit:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.buttonSave);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.buttonClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(698, 76);
			this.panel1.TabIndex = 17;
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
			this.buttonSave.Location = new System.Drawing.Point(466, 14);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(106, 48);
			this.buttonSave.TabIndex = 20;
			this.buttonSave.TabStop = false;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(76, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(348, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Item Component Detail";
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
			this.buttonClose.Location = new System.Drawing.Point(578, 14);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(106, 48);
			this.buttonClose.TabIndex = 21;
			this.buttonClose.TabStop = false;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.label6.Location = new System.Drawing.Point(10, 82);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(175, 30);
			this.label6.TabIndex = 27;
			this.label6.Text = "Item Component:";
			// 
			// comboBoxItemComponent
			// 
			this.comboBoxItemComponent.FormattingEnabled = true;
			this.comboBoxItemComponent.Location = new System.Drawing.Point(192, 83);
			this.comboBoxItemComponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBoxItemComponent.Name = "comboBoxItemComponent";
			this.comboBoxItemComponent.Size = new System.Drawing.Size(491, 36);
			this.comboBoxItemComponent.TabIndex = 0;
			this.comboBoxItemComponent.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemComponent_SelectedIndexChanged);
			this.comboBoxItemComponent.Click += new System.EventHandler(this.comboBoxItemComponent_Click);
			// 
			// textBoxAmount
			// 
			this.textBoxAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textBoxAmount.Location = new System.Drawing.Point(193, 257);
			this.textBoxAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.ReadOnly = true;
			this.textBoxAmount.Size = new System.Drawing.Size(233, 35);
			this.textBoxAmount.TabIndex = 4;
			this.textBoxAmount.TabStop = false;
			this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.label7.Location = new System.Drawing.Point(89, 257);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 30);
			this.label7.TabIndex = 29;
			this.label7.Text = "Amount:";
			// 
			// textBoxOnHantQty
			// 
			this.textBoxOnHantQty.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textBoxOnHantQty.Location = new System.Drawing.Point(192, 300);
			this.textBoxOnHantQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxOnHantQty.Name = "textBoxOnHantQty";
			this.textBoxOnHantQty.ReadOnly = true;
			this.textBoxOnHantQty.Size = new System.Drawing.Size(233, 35);
			this.textBoxOnHantQty.TabIndex = 5;
			this.textBoxOnHantQty.TabStop = false;
			this.textBoxOnHantQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.label8.Location = new System.Drawing.Point(41, 302);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(146, 30);
			this.label8.TabIndex = 31;
			this.label8.Text = "On Hand Qty.:";
			// 
			// textBoxUnit
			// 
			this.textBoxUnit.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.textBoxUnit.Location = new System.Drawing.Point(193, 127);
			this.textBoxUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxUnit.Name = "textBoxUnit";
			this.textBoxUnit.ReadOnly = true;
			this.textBoxUnit.Size = new System.Drawing.Size(233, 35);
			this.textBoxUnit.TabIndex = 1;
			this.textBoxUnit.TabStop = false;
			this.textBoxUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Item;
			this.pictureBox1.Location = new System.Drawing.Point(14, 14);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(58, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// MstItemComponentDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(698, 350);
			this.Controls.Add(this.textBoxUnit);
			this.Controls.Add(this.textBoxOnHantQty);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBoxAmount);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBoxItemComponent);
			this.Controls.Add(this.textBoxCost);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxQuantity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "MstItemComponentDetailForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Item Component Detail";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxItemComponent;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxOnHantQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxUnit;
    }
}