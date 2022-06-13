namespace EasyPOS.Forms.Software.TrnPOS
{
    partial class TrnPOSSearchItemForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrnPOSSearchItemForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.textBoxFilter = new System.Windows.Forms.TextBox();
			this.dataGridViewSearchItemList = new System.Windows.Forms.DataGridView();
			this.ColumnSearchItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSearchItemBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSearchItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSearchItemGenericName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSearchItemOutTaxId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSearchItemOutTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSearchItemOutTaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSearchItemUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSearchItemUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSearchItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSearchItemOnHandQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSearchItemIsInventory = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ColumnSearchItemButtonPick = new System.Windows.Forms.DataGridViewButtonColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.buttonPageListFirst = new System.Windows.Forms.Button();
			this.buttonPageListNext = new System.Windows.Forms.Button();
			this.buttonPageListLast = new System.Windows.Forms.Button();
			this.buttonPageListPrevious = new System.Windows.Forms.Button();
			this.textBoxPageNumber = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchItemList)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1299, 75);
			this.panel1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(75, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Search Item";
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
			this.buttonClose.Location = new System.Drawing.Point(1122, 15);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(164, 48);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.TabStop = false;
			this.buttonClose.Text = "Esc - Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// textBoxFilter
			// 
			this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFilter.Location = new System.Drawing.Point(15, 8);
			this.textBoxFilter.Name = "textBoxFilter";
			this.textBoxFilter.Size = new System.Drawing.Size(1268, 35);
			this.textBoxFilter.TabIndex = 0;
			this.textBoxFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFilter_KeyDown);
			// 
			// dataGridViewSearchItemList
			// 
			this.dataGridViewSearchItemList.AllowUserToAddRows = false;
			this.dataGridViewSearchItemList.AllowUserToDeleteRows = false;
			this.dataGridViewSearchItemList.AllowUserToResizeRows = false;
			this.dataGridViewSearchItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewSearchItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewSearchItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSearchItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSearchItemId,
            this.ColumnSearchItemBarcode,
            this.ColumnSearchItemDescription,
            this.ColumnSearchItemGenericName,
            this.ColumnSearchItemOutTaxId,
            this.ColumnSearchItemOutTax,
            this.ColumnSearchItemOutTaxRate,
            this.ColumnSearchItemUnitId,
            this.ColumnSearchItemUnit,
            this.ColumnSearchItemPrice,
            this.ColumnSearchItemOnHandQuantity,
            this.ColumnSearchItemIsInventory,
            this.ColumnSearchItemButtonPick});
			this.dataGridViewSearchItemList.Location = new System.Drawing.Point(15, 51);
			this.dataGridViewSearchItemList.MultiSelect = false;
			this.dataGridViewSearchItemList.Name = "dataGridViewSearchItemList";
			this.dataGridViewSearchItemList.ReadOnly = true;
			this.dataGridViewSearchItemList.RowHeadersWidth = 62;
			this.dataGridViewSearchItemList.RowTemplate.Height = 24;
			this.dataGridViewSearchItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewSearchItemList.Size = new System.Drawing.Size(1269, 476);
			this.dataGridViewSearchItemList.TabIndex = 1;
			this.dataGridViewSearchItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchItemList_CellClick);
			this.dataGridViewSearchItemList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewSearchItemList_KeyDown);
			// 
			// ColumnSearchItemId
			// 
			this.ColumnSearchItemId.DataPropertyName = "ColumnSearchItemId";
			this.ColumnSearchItemId.HeaderText = "Id";
			this.ColumnSearchItemId.MinimumWidth = 8;
			this.ColumnSearchItemId.Name = "ColumnSearchItemId";
			this.ColumnSearchItemId.ReadOnly = true;
			this.ColumnSearchItemId.Visible = false;
			this.ColumnSearchItemId.Width = 150;
			// 
			// ColumnSearchItemBarcode
			// 
			this.ColumnSearchItemBarcode.DataPropertyName = "ColumnSearchItemBarcode";
			this.ColumnSearchItemBarcode.HeaderText = "Barcode";
			this.ColumnSearchItemBarcode.MinimumWidth = 8;
			this.ColumnSearchItemBarcode.Name = "ColumnSearchItemBarcode";
			this.ColumnSearchItemBarcode.ReadOnly = true;
			this.ColumnSearchItemBarcode.Width = 130;
			// 
			// ColumnSearchItemDescription
			// 
			this.ColumnSearchItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnSearchItemDescription.DataPropertyName = "ColumnSearchItemDescription";
			this.ColumnSearchItemDescription.HeaderText = "Item Description";
			this.ColumnSearchItemDescription.MinimumWidth = 8;
			this.ColumnSearchItemDescription.Name = "ColumnSearchItemDescription";
			this.ColumnSearchItemDescription.ReadOnly = true;
			// 
			// ColumnSearchItemGenericName
			// 
			this.ColumnSearchItemGenericName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnSearchItemGenericName.DataPropertyName = "ColumnSearchItemGenericName";
			this.ColumnSearchItemGenericName.HeaderText = "Generic Name";
			this.ColumnSearchItemGenericName.MinimumWidth = 8;
			this.ColumnSearchItemGenericName.Name = "ColumnSearchItemGenericName";
			this.ColumnSearchItemGenericName.ReadOnly = true;
			this.ColumnSearchItemGenericName.Visible = false;
			// 
			// ColumnSearchItemOutTaxId
			// 
			this.ColumnSearchItemOutTaxId.DataPropertyName = "ColumnSearchItemOutTaxId";
			this.ColumnSearchItemOutTaxId.HeaderText = "OutTaxId";
			this.ColumnSearchItemOutTaxId.MinimumWidth = 8;
			this.ColumnSearchItemOutTaxId.Name = "ColumnSearchItemOutTaxId";
			this.ColumnSearchItemOutTaxId.ReadOnly = true;
			this.ColumnSearchItemOutTaxId.Visible = false;
			this.ColumnSearchItemOutTaxId.Width = 150;
			// 
			// ColumnSearchItemOutTax
			// 
			this.ColumnSearchItemOutTax.DataPropertyName = "ColumnSearchItemOutTax";
			this.ColumnSearchItemOutTax.HeaderText = "OutTax";
			this.ColumnSearchItemOutTax.MinimumWidth = 8;
			this.ColumnSearchItemOutTax.Name = "ColumnSearchItemOutTax";
			this.ColumnSearchItemOutTax.ReadOnly = true;
			this.ColumnSearchItemOutTax.Visible = false;
			this.ColumnSearchItemOutTax.Width = 150;
			// 
			// ColumnSearchItemOutTaxRate
			// 
			this.ColumnSearchItemOutTaxRate.DataPropertyName = "ColumnSearchItemOutTaxRate";
			this.ColumnSearchItemOutTaxRate.HeaderText = "OutTaxRate";
			this.ColumnSearchItemOutTaxRate.MinimumWidth = 8;
			this.ColumnSearchItemOutTaxRate.Name = "ColumnSearchItemOutTaxRate";
			this.ColumnSearchItemOutTaxRate.ReadOnly = true;
			this.ColumnSearchItemOutTaxRate.Visible = false;
			this.ColumnSearchItemOutTaxRate.Width = 150;
			// 
			// ColumnSearchItemUnitId
			// 
			this.ColumnSearchItemUnitId.DataPropertyName = "ColumnSearchItemUnitId";
			this.ColumnSearchItemUnitId.HeaderText = "UnitId";
			this.ColumnSearchItemUnitId.MinimumWidth = 8;
			this.ColumnSearchItemUnitId.Name = "ColumnSearchItemUnitId";
			this.ColumnSearchItemUnitId.ReadOnly = true;
			this.ColumnSearchItemUnitId.Visible = false;
			this.ColumnSearchItemUnitId.Width = 150;
			// 
			// ColumnSearchItemUnit
			// 
			this.ColumnSearchItemUnit.DataPropertyName = "ColumnSearchItemUnit";
			this.ColumnSearchItemUnit.HeaderText = "Unit";
			this.ColumnSearchItemUnit.MinimumWidth = 8;
			this.ColumnSearchItemUnit.Name = "ColumnSearchItemUnit";
			this.ColumnSearchItemUnit.ReadOnly = true;
			this.ColumnSearchItemUnit.Visible = false;
			this.ColumnSearchItemUnit.Width = 150;
			// 
			// ColumnSearchItemPrice
			// 
			this.ColumnSearchItemPrice.DataPropertyName = "ColumnSearchItemPrice";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ColumnSearchItemPrice.DefaultCellStyle = dataGridViewCellStyle1;
			this.ColumnSearchItemPrice.HeaderText = "Price";
			this.ColumnSearchItemPrice.MinimumWidth = 8;
			this.ColumnSearchItemPrice.Name = "ColumnSearchItemPrice";
			this.ColumnSearchItemPrice.ReadOnly = true;
			this.ColumnSearchItemPrice.Width = 150;
			// 
			// ColumnSearchItemOnHandQuantity
			// 
			this.ColumnSearchItemOnHandQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.ColumnSearchItemOnHandQuantity.DataPropertyName = "ColumnSearchItemOnHandQuantity";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ColumnSearchItemOnHandQuantity.DefaultCellStyle = dataGridViewCellStyle2;
			this.ColumnSearchItemOnHandQuantity.HeaderText = "On Hand Qty.";
			this.ColumnSearchItemOnHandQuantity.MinimumWidth = 8;
			this.ColumnSearchItemOnHandQuantity.Name = "ColumnSearchItemOnHandQuantity";
			this.ColumnSearchItemOnHandQuantity.ReadOnly = true;
			this.ColumnSearchItemOnHandQuantity.Width = 177;
			// 
			// ColumnSearchItemIsInventory
			// 
			this.ColumnSearchItemIsInventory.DataPropertyName = "ColumnSearchItemIsInventory";
			this.ColumnSearchItemIsInventory.HeaderText = "I";
			this.ColumnSearchItemIsInventory.MinimumWidth = 8;
			this.ColumnSearchItemIsInventory.Name = "ColumnSearchItemIsInventory";
			this.ColumnSearchItemIsInventory.ReadOnly = true;
			this.ColumnSearchItemIsInventory.Width = 40;
			// 
			// ColumnSearchItemButtonPick
			// 
			this.ColumnSearchItemButtonPick.DataPropertyName = "ColumnSearchItemButtonPick";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(166)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			this.ColumnSearchItemButtonPick.DefaultCellStyle = dataGridViewCellStyle3;
			this.ColumnSearchItemButtonPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ColumnSearchItemButtonPick.HeaderText = "Pick";
			this.ColumnSearchItemButtonPick.MinimumWidth = 8;
			this.ColumnSearchItemButtonPick.Name = "ColumnSearchItemButtonPick";
			this.ColumnSearchItemButtonPick.ReadOnly = true;
			this.ColumnSearchItemButtonPick.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColumnSearchItemButtonPick.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ColumnSearchItemButtonPick.Width = 70;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.textBoxFilter);
			this.panel2.Controls.Add(this.dataGridViewSearchItemList);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 75);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1299, 588);
			this.panel2.TabIndex = 7;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.buttonPageListFirst);
			this.panel3.Controls.Add(this.buttonPageListNext);
			this.panel3.Controls.Add(this.buttonPageListLast);
			this.panel3.Controls.Add(this.buttonPageListPrevious);
			this.panel3.Controls.Add(this.textBoxPageNumber);
			this.panel3.Location = new System.Drawing.Point(15, 534);
			this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1270, 50);
			this.panel3.TabIndex = 2;
			// 
			// buttonPageListFirst
			// 
			this.buttonPageListFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPageListFirst.Enabled = false;
			this.buttonPageListFirst.FlatAppearance.BorderSize = 0;
			this.buttonPageListFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPageListFirst.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.buttonPageListFirst.Location = new System.Drawing.Point(6, 6);
			this.buttonPageListFirst.Name = "buttonPageListFirst";
			this.buttonPageListFirst.Size = new System.Drawing.Size(106, 39);
			this.buttonPageListFirst.TabIndex = 13;
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
			this.buttonPageListNext.Location = new System.Drawing.Point(396, 6);
			this.buttonPageListNext.Name = "buttonPageListNext";
			this.buttonPageListNext.Size = new System.Drawing.Size(106, 39);
			this.buttonPageListNext.TabIndex = 15;
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
			this.buttonPageListLast.Location = new System.Drawing.Point(498, 6);
			this.buttonPageListLast.Name = "buttonPageListLast";
			this.buttonPageListLast.Size = new System.Drawing.Size(106, 39);
			this.buttonPageListLast.TabIndex = 16;
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
			this.buttonPageListPrevious.Location = new System.Drawing.Point(111, 6);
			this.buttonPageListPrevious.Name = "buttonPageListPrevious";
			this.buttonPageListPrevious.Size = new System.Drawing.Size(106, 39);
			this.buttonPageListPrevious.TabIndex = 14;
			this.buttonPageListPrevious.Text = "Previous";
			this.buttonPageListPrevious.UseVisualStyleBackColor = false;
			this.buttonPageListPrevious.Click += new System.EventHandler(this.buttonPageListPrevious_Click);
			// 
			// textBoxPageNumber
			// 
			this.textBoxPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxPageNumber.BackColor = System.Drawing.Color.White;
			this.textBoxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPageNumber.Location = new System.Drawing.Point(268, 12);
			this.textBoxPageNumber.Name = "textBoxPageNumber";
			this.textBoxPageNumber.ReadOnly = true;
			this.textBoxPageNumber.Size = new System.Drawing.Size(90, 28);
			this.textBoxPageNumber.TabIndex = 17;
			this.textBoxPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			// TrnPOSSearchItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1299, 663);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "TrnPOSSearchItemForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search Item";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchItemList)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.DataGridView dataGridViewSearchItemList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonPageListFirst;
        private System.Windows.Forms.Button buttonPageListNext;
        private System.Windows.Forms.Button buttonPageListLast;
        private System.Windows.Forms.Button buttonPageListPrevious;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchItemBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchItemGenericName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchItemOutTaxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchItemOutTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchItemOutTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchItemUnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchItemUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchItemOnHandQuantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSearchItemIsInventory;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSearchItemButtonPick;
    }
}