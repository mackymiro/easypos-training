namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSQuickServiceActivityForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSQuickServiceActivityForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelInvoiceNumber = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.imageListQuickServiceOther = new System.Windows.Forms.ImageList(this.components);
            this.buttonReprint = new System.Windows.Forms.Button();
            this.imageListQuickServicePrint = new System.Windows.Forms.ImageList(this.components);
            this.buttonDeliver = new System.Windows.Forms.Button();
            this.buttonTender = new System.Windows.Forms.Button();
            this.buttonBillOut = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPrintPartialBill = new System.Windows.Forms.Button();
            this.imageListQuickService = new System.Windows.Forms.ImageList(this.components);
            this.buttonEditOrder = new System.Windows.Forms.Button();
            this.printDialogReprintOR = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 62);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyPOS.Properties.Resources.POS_Touch;
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
            this.label1.Size = new System.Drawing.Size(238, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "POS Touch Activity";
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
            this.buttonClose.Location = new System.Drawing.Point(854, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(136, 40);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "Esc - Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.labelInvoiceNumber);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 52);
            this.panel3.TabIndex = 9;
            // 
            // labelInvoiceNumber
            // 
            this.labelInvoiceNumber.AutoSize = true;
            this.labelInvoiceNumber.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvoiceNumber.ForeColor = System.Drawing.Color.White;
            this.labelInvoiceNumber.Location = new System.Drawing.Point(18, 8);
            this.labelInvoiceNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInvoiceNumber.Name = "labelInvoiceNumber";
            this.labelInvoiceNumber.Size = new System.Drawing.Size(0, 30);
            this.labelInvoiceNumber.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.ImageIndex = 0;
            this.buttonCancel.ImageList = this.imageListQuickServiceOther;
            this.buttonCancel.Location = new System.Drawing.Point(668, 390);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Padding = new System.Windows.Forms.Padding(10);
            this.buttonCancel.Size = new System.Drawing.Size(322, 134);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "\r\nF7 - Cancel";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // imageListQuickServiceOther
            // 
            this.imageListQuickServiceOther.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListQuickServiceOther.ImageStream")));
            this.imageListQuickServiceOther.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListQuickServiceOther.Images.SetKeyName(0, "cancel.png");
            this.imageListQuickServiceOther.Images.SetKeyName(1, "delete.png");
            this.imageListQuickServiceOther.Images.SetKeyName(2, "splitMergeBill.png");
            // 
            // buttonReprint
            // 
            this.buttonReprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonReprint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonReprint.FlatAppearance.BorderSize = 0;
            this.buttonReprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReprint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReprint.ForeColor = System.Drawing.Color.White;
            this.buttonReprint.ImageIndex = 0;
            this.buttonReprint.ImageList = this.imageListQuickServicePrint;
            this.buttonReprint.Location = new System.Drawing.Point(337, 254);
            this.buttonReprint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReprint.Name = "buttonReprint";
            this.buttonReprint.Padding = new System.Windows.Forms.Padding(10);
            this.buttonReprint.Size = new System.Drawing.Size(322, 131);
            this.buttonReprint.TabIndex = 19;
            this.buttonReprint.Text = " \r\nF5 -Reprint";
            this.buttonReprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonReprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonReprint.UseVisualStyleBackColor = false;
            this.buttonReprint.Click += new System.EventHandler(this.buttonReprint_Click);
            // 
            // imageListQuickServicePrint
            // 
            this.imageListQuickServicePrint.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListQuickServicePrint.ImageStream")));
            this.imageListQuickServicePrint.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListQuickServicePrint.Images.SetKeyName(0, "print.png");
            this.imageListQuickServicePrint.Images.SetKeyName(1, "tender.png");
            this.imageListQuickServicePrint.Images.SetKeyName(2, "delivery.png");
            // 
            // buttonDeliver
            // 
            this.buttonDeliver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonDeliver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonDeliver.FlatAppearance.BorderSize = 0;
            this.buttonDeliver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeliver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDeliver.ForeColor = System.Drawing.Color.White;
            this.buttonDeliver.ImageIndex = 2;
            this.buttonDeliver.ImageList = this.imageListQuickServicePrint;
            this.buttonDeliver.Location = new System.Drawing.Point(10, 390);
            this.buttonDeliver.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeliver.Name = "buttonDeliver";
            this.buttonDeliver.Padding = new System.Windows.Forms.Padding(10);
            this.buttonDeliver.Size = new System.Drawing.Size(322, 131);
            this.buttonDeliver.TabIndex = 18;
            this.buttonDeliver.Text = "\r\nF8 - Deliver";
            this.buttonDeliver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeliver.UseVisualStyleBackColor = false;
            this.buttonDeliver.Click += new System.EventHandler(this.buttonDeliver_Click);
            // 
            // buttonTender
            // 
            this.buttonTender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonTender.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonTender.FlatAppearance.BorderSize = 0;
            this.buttonTender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTender.ForeColor = System.Drawing.Color.White;
            this.buttonTender.ImageIndex = 1;
            this.buttonTender.ImageList = this.imageListQuickServicePrint;
            this.buttonTender.Location = new System.Drawing.Point(666, 118);
            this.buttonTender.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTender.Name = "buttonTender";
            this.buttonTender.Padding = new System.Windows.Forms.Padding(10);
            this.buttonTender.Size = new System.Drawing.Size(322, 131);
            this.buttonTender.TabIndex = 17;
            this.buttonTender.Text = "\r\nF4 - Tender";
            this.buttonTender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonTender.UseVisualStyleBackColor = false;
            this.buttonTender.Click += new System.EventHandler(this.buttonTender_Click);
            // 
            // buttonBillOut
            // 
            this.buttonBillOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonBillOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonBillOut.FlatAppearance.BorderSize = 0;
            this.buttonBillOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBillOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBillOut.ForeColor = System.Drawing.Color.White;
            this.buttonBillOut.ImageIndex = 0;
            this.buttonBillOut.ImageList = this.imageListQuickServicePrint;
            this.buttonBillOut.Location = new System.Drawing.Point(338, 118);
            this.buttonBillOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBillOut.Name = "buttonBillOut";
            this.buttonBillOut.Padding = new System.Windows.Forms.Padding(10);
            this.buttonBillOut.Size = new System.Drawing.Size(322, 131);
            this.buttonBillOut.TabIndex = 16;
            this.buttonBillOut.Text = " \r\nF3 -Bill Out";
            this.buttonBillOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBillOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBillOut.UseVisualStyleBackColor = false;
            this.buttonBillOut.Click += new System.EventHandler(this.buttonBillOut_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.ImageIndex = 1;
            this.buttonDelete.ImageList = this.imageListQuickServiceOther;
            this.buttonDelete.Location = new System.Drawing.Point(666, 254);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(10);
            this.buttonDelete.Size = new System.Drawing.Size(322, 132);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "\r\nF6 - Delete";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPrintPartialBill
            // 
            this.buttonPrintPartialBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonPrintPartialBill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonPrintPartialBill.FlatAppearance.BorderSize = 0;
            this.buttonPrintPartialBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintPartialBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPrintPartialBill.ForeColor = System.Drawing.Color.White;
            this.buttonPrintPartialBill.ImageIndex = 0;
            this.buttonPrintPartialBill.ImageList = this.imageListQuickServicePrint;
            this.buttonPrintPartialBill.Location = new System.Drawing.Point(338, 390);
            this.buttonPrintPartialBill.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrintPartialBill.Name = "buttonPrintPartialBill";
            this.buttonPrintPartialBill.Padding = new System.Windows.Forms.Padding(10);
            this.buttonPrintPartialBill.Size = new System.Drawing.Size(321, 131);
            this.buttonPrintPartialBill.TabIndex = 13;
            this.buttonPrintPartialBill.Text = "\r\nF9 - Print Partial Bill";
            this.buttonPrintPartialBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPrintPartialBill.UseVisualStyleBackColor = false;
            this.buttonPrintPartialBill.Click += new System.EventHandler(this.buttonPrintPartialBill_Click);
            // 
            // imageListQuickService
            // 
            this.imageListQuickService.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListQuickService.ImageStream")));
            this.imageListQuickService.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListQuickService.Images.SetKeyName(0, "editOrder.png");
            this.imageListQuickService.Images.SetKeyName(1, "print.png");
            this.imageListQuickService.Images.SetKeyName(2, "cancel.png");
            this.imageListQuickService.Images.SetKeyName(3, "delete.png");
            this.imageListQuickService.Images.SetKeyName(4, "changeTable.png");
            this.imageListQuickService.Images.SetKeyName(5, "delivery.png");
            this.imageListQuickService.Images.SetKeyName(6, "splitMergeBill.png");
            this.imageListQuickService.Images.SetKeyName(7, "tender.png");
            // 
            // buttonEditOrder
            // 
            this.buttonEditOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
            this.buttonEditOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
            this.buttonEditOrder.FlatAppearance.BorderSize = 0;
            this.buttonEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEditOrder.ForeColor = System.Drawing.Color.White;
            this.buttonEditOrder.ImageIndex = 0;
            this.buttonEditOrder.ImageList = this.imageListQuickService;
            this.buttonEditOrder.Location = new System.Drawing.Point(13, 117);
            this.buttonEditOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditOrder.Name = "buttonEditOrder";
            this.buttonEditOrder.Padding = new System.Windows.Forms.Padding(10);
            this.buttonEditOrder.Size = new System.Drawing.Size(321, 268);
            this.buttonEditOrder.TabIndex = 12;
            this.buttonEditOrder.Text = "\r\nF2 - Edit Order";
            this.buttonEditOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEditOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEditOrder.UseVisualStyleBackColor = false;
            this.buttonEditOrder.Click += new System.EventHandler(this.buttonEditOrder_Click);
            // 
            // printDialogReprintOR
            // 
            this.printDialogReprintOR.UseEXDialog = true;
            // 
            // TrnPOSQuickServiceActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 535);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReprint);
            this.Controls.Add(this.buttonDeliver);
            this.Controls.Add(this.buttonTender);
            this.Controls.Add(this.buttonBillOut);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPrintPartialBill);
            this.Controls.Add(this.buttonEditOrder);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrnPOSQuickServiceActivityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrnPOSQuickServiceActivityForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelInvoiceNumber;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonReprint;
        private System.Windows.Forms.Button buttonDeliver;
        private System.Windows.Forms.Button buttonTender;
        private System.Windows.Forms.Button buttonBillOut;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPrintPartialBill;
        private System.Windows.Forms.Button buttonEditOrder;
        private System.Windows.Forms.ImageList imageListQuickService;
        private System.Windows.Forms.ImageList imageListQuickServiceOther;
        private System.Windows.Forms.ImageList imageListQuickServicePrint;
        private System.Windows.Forms.PrintDialog printDialogReprintOR;
    }
}