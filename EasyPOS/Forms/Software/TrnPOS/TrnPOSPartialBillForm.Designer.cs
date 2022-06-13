
namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSPartialBillForm
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
            this.printDocumentPartialBill = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // printDocumentPartialBill
            // 
            this.printDocumentPartialBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentPartialBill_PrintPage);
            // 
            // TrnPOSPartialBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 37);
            this.ControlBox = false;
            this.Name = "TrnPOSPartialBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partial Bill";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocumentPartialBill;
    }
}