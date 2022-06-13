namespace EasyPOS.Forms.Software.RepSalesReport
{
    partial class RepCustomerListReportForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepCustomerListReportForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonGenerateCSV = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewCustomerListReport = new System.Windows.Forms.DataGridView();
			this.ColumnCustomerListButtonEdit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ColumnCustomerListButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ColumnCustomerListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCustomerListCustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCustomerListCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCustomerListContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCustomerListAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCustomerListIsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.buttonPageListFirst = new System.Windows.Forms.Button();
			this.buttonPageListNext = new System.Windows.Forms.Button();
			this.buttonPageListLast = new System.Windows.Forms.Button();
			this.buttonPageListPrevious = new System.Windows.Forms.Button();
			this.textBoxPageNumber = new System.Windows.Forms.TextBox();
			this.folderBrowserDialogGenerateCSV = new System.Windows.Forms.FolderBrowserDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerListReport)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.buttonClose);
			this.panel1.Controls.Add(this.buttonGenerateCSV);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1588, 75);
			this.panel1.TabIndex = 11;
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
			this.buttonClose.Location = new System.Drawing.Point(1466, 14);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(105, 48);
			this.buttonClose.TabIndex = 6;
			this.buttonClose.TabStop = false;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonGenerateCSV
			// 
			this.buttonGenerateCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGenerateCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
			this.buttonGenerateCSV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
			this.buttonGenerateCSV.FlatAppearance.BorderSize = 0;
			this.buttonGenerateCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGenerateCSV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonGenerateCSV.ForeColor = System.Drawing.Color.White;
			this.buttonGenerateCSV.Location = new System.Drawing.Point(1354, 14);
			this.buttonGenerateCSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonGenerateCSV.Name = "buttonGenerateCSV";
			this.buttonGenerateCSV.Size = new System.Drawing.Size(105, 48);
			this.buttonGenerateCSV.TabIndex = 5;
			this.buttonGenerateCSV.TabStop = false;
			this.buttonGenerateCSV.Text = "CSV";
			this.buttonGenerateCSV.UseVisualStyleBackColor = false;
			this.buttonGenerateCSV.Click += new System.EventHandler(this.buttonGenerateCSV_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(86, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(315, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Customer List Report";
			// 
			// dataGridViewCustomerListReport
			// 
			this.dataGridViewCustomerListReport.AllowUserToAddRows = false;
			this.dataGridViewCustomerListReport.AllowUserToDeleteRows = false;
			this.dataGridViewCustomerListReport.AllowUserToResizeRows = false;
			this.dataGridViewCustomerListReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewCustomerListReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewCustomerListReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCustomerListReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCustomerListButtonEdit,
            this.ColumnCustomerListButtonDelete,
            this.ColumnCustomerListId,
            this.ColumnCustomerListCustomerCode,
            this.ColumnCustomerListCustomer,
            this.ColumnCustomerListContactNumber,
            this.ColumnCustomerListAddress,
            this.ColumnCustomerListIsLocked});
			this.dataGridViewCustomerListReport.Location = new System.Drawing.Point(3, 69);
			this.dataGridViewCustomerListReport.MultiSelect = false;
			this.dataGridViewCustomerListReport.Name = "dataGridViewCustomerListReport";
			this.dataGridViewCustomerListReport.ReadOnly = true;
			this.dataGridViewCustomerListReport.RowHeadersWidth = 62;
			this.dataGridViewCustomerListReport.RowTemplate.Height = 24;
			this.dataGridViewCustomerListReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewCustomerListReport.ShowEditingIcon = false;
			this.dataGridViewCustomerListReport.Size = new System.Drawing.Size(1582, 448);
			this.dataGridViewCustomerListReport.TabIndex = 12;
			// 
			// ColumnCustomerListButtonEdit
			// 
			this.ColumnCustomerListButtonEdit.DataPropertyName = "ColumnCustomerListButtonEdit";
			this.ColumnCustomerListButtonEdit.HeaderText = "";
			this.ColumnCustomerListButtonEdit.MinimumWidth = 8;
			this.ColumnCustomerListButtonEdit.Name = "ColumnCustomerListButtonEdit";
			this.ColumnCustomerListButtonEdit.ReadOnly = true;
			this.ColumnCustomerListButtonEdit.Visible = false;
			this.ColumnCustomerListButtonEdit.Width = 150;
			// 
			// ColumnCustomerListButtonDelete
			// 
			this.ColumnCustomerListButtonDelete.DataPropertyName = "ColumnCustomerListButtonDelete";
			this.ColumnCustomerListButtonDelete.HeaderText = "";
			this.ColumnCustomerListButtonDelete.MinimumWidth = 8;
			this.ColumnCustomerListButtonDelete.Name = "ColumnCustomerListButtonDelete";
			this.ColumnCustomerListButtonDelete.ReadOnly = true;
			this.ColumnCustomerListButtonDelete.Visible = false;
			this.ColumnCustomerListButtonDelete.Width = 150;
			// 
			// ColumnCustomerListId
			// 
			this.ColumnCustomerListId.DataPropertyName = "ColumnCustomerListId";
			this.ColumnCustomerListId.HeaderText = "Id";
			this.ColumnCustomerListId.MinimumWidth = 8;
			this.ColumnCustomerListId.Name = "ColumnCustomerListId";
			this.ColumnCustomerListId.ReadOnly = true;
			this.ColumnCustomerListId.Visible = false;
			this.ColumnCustomerListId.Width = 150;
			// 
			// ColumnCustomerListCustomerCode
			// 
			this.ColumnCustomerListCustomerCode.DataPropertyName = "ColumnCustomerListCustomerCode";
			this.ColumnCustomerListCustomerCode.HeaderText = "Customer Code";
			this.ColumnCustomerListCustomerCode.MinimumWidth = 8;
			this.ColumnCustomerListCustomerCode.Name = "ColumnCustomerListCustomerCode";
			this.ColumnCustomerListCustomerCode.ReadOnly = true;
			this.ColumnCustomerListCustomerCode.Width = 150;
			// 
			// ColumnCustomerListCustomer
			// 
			this.ColumnCustomerListCustomer.DataPropertyName = "ColumnCustomerListCustomer";
			this.ColumnCustomerListCustomer.HeaderText = "Customer";
			this.ColumnCustomerListCustomer.MinimumWidth = 8;
			this.ColumnCustomerListCustomer.Name = "ColumnCustomerListCustomer";
			this.ColumnCustomerListCustomer.ReadOnly = true;
			this.ColumnCustomerListCustomer.Width = 150;
			// 
			// ColumnCustomerListContactNumber
			// 
			this.ColumnCustomerListContactNumber.DataPropertyName = "ColumnCustomerListContactNumber";
			this.ColumnCustomerListContactNumber.HeaderText = "Contact Number";
			this.ColumnCustomerListContactNumber.MinimumWidth = 8;
			this.ColumnCustomerListContactNumber.Name = "ColumnCustomerListContactNumber";
			this.ColumnCustomerListContactNumber.ReadOnly = true;
			this.ColumnCustomerListContactNumber.Width = 150;
			// 
			// ColumnCustomerListAddress
			// 
			this.ColumnCustomerListAddress.DataPropertyName = "ColumnCustomerListAddress";
			this.ColumnCustomerListAddress.HeaderText = "Address";
			this.ColumnCustomerListAddress.MinimumWidth = 8;
			this.ColumnCustomerListAddress.Name = "ColumnCustomerListAddress";
			this.ColumnCustomerListAddress.ReadOnly = true;
			this.ColumnCustomerListAddress.Width = 150;
			// 
			// ColumnCustomerListIsLocked
			// 
			this.ColumnCustomerListIsLocked.DataPropertyName = "ColumnCustomerListIsLocked";
			this.ColumnCustomerListIsLocked.HeaderText = "IsLocked";
			this.ColumnCustomerListIsLocked.MinimumWidth = 8;
			this.ColumnCustomerListIsLocked.Name = "ColumnCustomerListIsLocked";
			this.ColumnCustomerListIsLocked.ReadOnly = true;
			this.ColumnCustomerListIsLocked.Visible = false;
			this.ColumnCustomerListIsLocked.Width = 150;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.buttonPageListFirst);
			this.panel4.Controls.Add(this.buttonPageListNext);
			this.panel4.Controls.Add(this.buttonPageListLast);
			this.panel4.Controls.Add(this.buttonPageListPrevious);
			this.panel4.Controls.Add(this.textBoxPageNumber);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 511);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1588, 63);
			this.panel4.TabIndex = 21;
			// 
			// buttonPageListFirst
			// 
			this.buttonPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPageListFirst.Enabled = false;
			this.buttonPageListFirst.FlatAppearance.BorderSize = 0;
			this.buttonPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPageListFirst.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.buttonPageListFirst.Location = new System.Drawing.Point(15, 12);
			this.buttonPageListFirst.Name = "buttonPageListFirst";
			this.buttonPageListFirst.Size = new System.Drawing.Size(99, 39);
			this.buttonPageListFirst.TabIndex = 8;
			this.buttonPageListFirst.TabStop = false;
			this.buttonPageListFirst.Text = "First";
			this.buttonPageListFirst.UseVisualStyleBackColor = false;
			this.buttonPageListFirst.Click += new System.EventHandler(this.buttonPageListFirst_Click);
			// 
			// buttonPageListNext
			// 
			this.buttonPageListNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPageListNext.FlatAppearance.BorderSize = 0;
			this.buttonPageListNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPageListNext.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.buttonPageListNext.Location = new System.Drawing.Point(405, 12);
			this.buttonPageListNext.Name = "buttonPageListNext";
			this.buttonPageListNext.Size = new System.Drawing.Size(99, 39);
			this.buttonPageListNext.TabIndex = 10;
			this.buttonPageListNext.TabStop = false;
			this.buttonPageListNext.Text = "Next";
			this.buttonPageListNext.UseVisualStyleBackColor = false;
			this.buttonPageListNext.Click += new System.EventHandler(this.buttonPageListNext_Click);
			// 
			// buttonPageListLast
			// 
			this.buttonPageListLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPageListLast.FlatAppearance.BorderSize = 0;
			this.buttonPageListLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPageListLast.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.buttonPageListLast.Location = new System.Drawing.Point(507, 12);
			this.buttonPageListLast.Name = "buttonPageListLast";
			this.buttonPageListLast.Size = new System.Drawing.Size(99, 39);
			this.buttonPageListLast.TabIndex = 11;
			this.buttonPageListLast.TabStop = false;
			this.buttonPageListLast.Text = "Last";
			this.buttonPageListLast.UseVisualStyleBackColor = false;
			this.buttonPageListLast.Click += new System.EventHandler(this.buttonPageListLast_Click);
			// 
			// buttonPageListPrevious
			// 
			this.buttonPageListPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPageListPrevious.Enabled = false;
			this.buttonPageListPrevious.FlatAppearance.BorderSize = 0;
			this.buttonPageListPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPageListPrevious.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.buttonPageListPrevious.Location = new System.Drawing.Point(120, 12);
			this.buttonPageListPrevious.Name = "buttonPageListPrevious";
			this.buttonPageListPrevious.Size = new System.Drawing.Size(104, 39);
			this.buttonPageListPrevious.TabIndex = 9;
			this.buttonPageListPrevious.TabStop = false;
			this.buttonPageListPrevious.Text = "Previous";
			this.buttonPageListPrevious.UseVisualStyleBackColor = false;
			this.buttonPageListPrevious.Click += new System.EventHandler(this.buttonPageListPrevious_Click);
			// 
			// textBoxPageNumber
			// 
			this.textBoxPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxPageNumber.BackColor = System.Drawing.Color.White;
			this.textBoxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPageNumber.Location = new System.Drawing.Point(278, 18);
			this.textBoxPageNumber.Name = "textBoxPageNumber";
			this.textBoxPageNumber.ReadOnly = true;
			this.textBoxPageNumber.Size = new System.Drawing.Size(82, 28);
			this.textBoxPageNumber.TabIndex = 12;
			this.textBoxPageNumber.TabStop = false;
			this.textBoxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Reports;
			this.pictureBox1.Location = new System.Drawing.Point(16, 9);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(54, 57);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// RepCustomerListReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1588, 574);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.dataGridViewCustomerListReport);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "RepCustomerListReportForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer List Report";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerListReport)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonGenerateCSV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCustomerListReport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonPageListFirst;
        private System.Windows.Forms.Button buttonPageListNext;
        private System.Windows.Forms.Button buttonPageListLast;
        private System.Windows.Forms.Button buttonPageListPrevious;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogGenerateCSV;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCustomerListButtonEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCustomerListButtonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerListId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerListCustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerListCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerListContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomerListAddress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCustomerListIsLocked;
    }
}