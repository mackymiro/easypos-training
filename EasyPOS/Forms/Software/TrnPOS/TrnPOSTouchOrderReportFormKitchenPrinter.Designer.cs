namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSTouchOrderReportFormKitchenPrinter
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
            this.printDocumentKitchenReport = new System.Drawing.Printing.PrintDocument();
            this.printDocumentReturnReport = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // printDocumentKitchenReport
            // 
            this.printDocumentKitchenReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentKitchenReport_PrintPage);
            // 
            // TrnPOSTouchOrderReportFormKitchenPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 47);
            this.ControlBox = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrnPOSTouchOrderReportFormKitchenPrinter";
            this.Text = "TrnPOSTouchOrderReportFormKitchenPrinter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocumentKitchenReport;
        private System.Drawing.Printing.PrintDocument printDocumentReturnReport;
    }
}