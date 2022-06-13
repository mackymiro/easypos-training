﻿namespace EasyPOS.Forms.Software.SysKitchenDisplay
{
    partial class SysKitchenDisplayForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysKitchenDisplayForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBoxSINumber = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClose = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dataGridViewDoneItemDisplay = new System.Windows.Forms.DataGridView();
			this.ColumnDoneItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonKitchen5 = new System.Windows.Forms.Button();
			this.buttonKitchenItem5 = new System.Windows.Forms.Button();
			this.buttonKitchenItem10 = new System.Windows.Forms.Button();
			this.buttonKitchenItem15 = new System.Windows.Forms.Button();
			this.buttonKitchenItem20 = new System.Windows.Forms.Button();
			this.buttonKitchen4 = new System.Windows.Forms.Button();
			this.buttonKitchen1 = new System.Windows.Forms.Button();
			this.imageListKitchenDisplay = new System.Windows.Forms.ImageList(this.components);
			this.buttonKitchen2 = new System.Windows.Forms.Button();
			this.buttonKitchen3 = new System.Windows.Forms.Button();
			this.buttonKitchenItem4 = new System.Windows.Forms.Button();
			this.buttonKitchenItem9 = new System.Windows.Forms.Button();
			this.buttonKitchenItem14 = new System.Windows.Forms.Button();
			this.buttonKitchenItem19 = new System.Windows.Forms.Button();
			this.buttonKitchenItem1 = new System.Windows.Forms.Button();
			this.buttonKitchenItem2 = new System.Windows.Forms.Button();
			this.buttonKitchenItem3 = new System.Windows.Forms.Button();
			this.buttonKitchenItem6 = new System.Windows.Forms.Button();
			this.buttonKitchenItem7 = new System.Windows.Forms.Button();
			this.buttonKitchenItem8 = new System.Windows.Forms.Button();
			this.buttonKitchenItem11 = new System.Windows.Forms.Button();
			this.buttonKitchenItem12 = new System.Windows.Forms.Button();
			this.buttonKitchenItem13 = new System.Windows.Forms.Button();
			this.buttonKitchenItem16 = new System.Windows.Forms.Button();
			this.buttonKitchenItem17 = new System.Windows.Forms.Button();
			this.buttonKitchenItem18 = new System.Windows.Forms.Button();
			this.buttonKitchenItemNext = new System.Windows.Forms.Button();
			this.buttonKitchenPageNext = new System.Windows.Forms.Button();
			this.buttonKitchenItemPrevious = new System.Windows.Forms.Button();
			this.buttonKitchenPagePrevious = new System.Windows.Forms.Button();
			this.dateTimePickerSalesDate = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoneItemDisplay)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.comboBoxSINumber);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.buttonClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1644, 75);
			this.panel1.TabIndex = 4;
			// 
			// comboBoxSINumber
			// 
			this.comboBoxSINumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSINumber.FormattingEnabled = true;
			this.comboBoxSINumber.Location = new System.Drawing.Point(1234, 21);
			this.comboBoxSINumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBoxSINumber.Name = "comboBoxSINumber";
			this.comboBoxSINumber.Size = new System.Drawing.Size(280, 36);
			this.comboBoxSINumber.TabIndex = 16;
			this.comboBoxSINumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxSINumber_SelectedIndexChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EasyPOS.Properties.Resources.Kitchen;
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
			this.label1.Size = new System.Drawing.Size(236, 41);
			this.label1.TabIndex = 2;
			this.label1.Text = "Kitchen Display";
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
			this.buttonClose.Location = new System.Drawing.Point(1524, 15);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(105, 48);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.buttonRefresh);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.panel2);
			this.panel3.Controls.Add(this.dateTimePickerSalesDate);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.ForeColor = System.Drawing.Color.White;
			this.panel3.Location = new System.Drawing.Point(0, 75);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1644, 765);
			this.panel3.TabIndex = 15;
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
			this.buttonRefresh.FlatAppearance.BorderSize = 0;
			this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.buttonRefresh.ForeColor = System.Drawing.Color.White;
			this.buttonRefresh.Location = new System.Drawing.Point(15, 720);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(1422, 40);
			this.buttonRefresh.TabIndex = 48;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.UseVisualStyleBackColor = false;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.dataGridViewDoneItemDisplay);
			this.panel4.Location = new System.Drawing.Point(1444, 56);
			this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(184, 705);
			this.panel4.TabIndex = 22;
			// 
			// dataGridViewDoneItemDisplay
			// 
			this.dataGridViewDoneItemDisplay.AllowUserToAddRows = false;
			this.dataGridViewDoneItemDisplay.AllowUserToDeleteRows = false;
			this.dataGridViewDoneItemDisplay.AllowUserToResizeColumns = false;
			this.dataGridViewDoneItemDisplay.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridViewDoneItemDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewDoneItemDisplay.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewDoneItemDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewDoneItemDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridViewDoneItemDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDoneItemDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewDoneItemDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDoneItemDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDoneItems,
            this.ColumnQuantity});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDoneItemDisplay.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewDoneItemDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewDoneItemDisplay.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridViewDoneItemDisplay.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewDoneItemDisplay.Name = "dataGridViewDoneItemDisplay";
			this.dataGridViewDoneItemDisplay.ReadOnly = true;
			this.dataGridViewDoneItemDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewDoneItemDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewDoneItemDisplay.RowHeadersVisible = false;
			this.dataGridViewDoneItemDisplay.RowHeadersWidth = 62;
			this.dataGridViewDoneItemDisplay.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridViewDoneItemDisplay.RowTemplate.Height = 45;
			this.dataGridViewDoneItemDisplay.RowTemplate.ReadOnly = true;
			this.dataGridViewDoneItemDisplay.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewDoneItemDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewDoneItemDisplay.Size = new System.Drawing.Size(184, 705);
			this.dataGridViewDoneItemDisplay.TabIndex = 9;
			// 
			// ColumnDoneItems
			// 
			this.ColumnDoneItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnDoneItems.DataPropertyName = "ColumnDoneItems";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			this.ColumnDoneItems.DefaultCellStyle = dataGridViewCellStyle3;
			this.ColumnDoneItems.HeaderText = "Done Items";
			this.ColumnDoneItems.MinimumWidth = 8;
			this.ColumnDoneItems.Name = "ColumnDoneItems";
			this.ColumnDoneItems.ReadOnly = true;
			// 
			// ColumnQuantity
			// 
			this.ColumnQuantity.DataPropertyName = "ColumnQuantity";
			this.ColumnQuantity.HeaderText = "Qty.";
			this.ColumnQuantity.MinimumWidth = 8;
			this.ColumnQuantity.Name = "ColumnQuantity";
			this.ColumnQuantity.ReadOnly = true;
			this.ColumnQuantity.Width = 150;
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.buttonKitchen5);
			this.panel2.Controls.Add(this.buttonKitchenItem5);
			this.panel2.Controls.Add(this.buttonKitchenItem10);
			this.panel2.Controls.Add(this.buttonKitchenItem15);
			this.panel2.Controls.Add(this.buttonKitchenItem20);
			this.panel2.Controls.Add(this.buttonKitchen4);
			this.panel2.Controls.Add(this.buttonKitchen1);
			this.panel2.Controls.Add(this.buttonKitchen2);
			this.panel2.Controls.Add(this.buttonKitchen3);
			this.panel2.Controls.Add(this.buttonKitchenItem4);
			this.panel2.Controls.Add(this.buttonKitchenItem9);
			this.panel2.Controls.Add(this.buttonKitchenItem14);
			this.panel2.Controls.Add(this.buttonKitchenItem19);
			this.panel2.Controls.Add(this.buttonKitchenItem1);
			this.panel2.Controls.Add(this.buttonKitchenItem2);
			this.panel2.Controls.Add(this.buttonKitchenItem3);
			this.panel2.Controls.Add(this.buttonKitchenItem6);
			this.panel2.Controls.Add(this.buttonKitchenItem7);
			this.panel2.Controls.Add(this.buttonKitchenItem8);
			this.panel2.Controls.Add(this.buttonKitchenItem11);
			this.panel2.Controls.Add(this.buttonKitchenItem12);
			this.panel2.Controls.Add(this.buttonKitchenItem13);
			this.panel2.Controls.Add(this.buttonKitchenItem16);
			this.panel2.Controls.Add(this.buttonKitchenItem17);
			this.panel2.Controls.Add(this.buttonKitchenItem18);
			this.panel2.Controls.Add(this.buttonKitchenItemNext);
			this.panel2.Controls.Add(this.buttonKitchenPageNext);
			this.panel2.Controls.Add(this.buttonKitchenItemPrevious);
			this.panel2.Controls.Add(this.buttonKitchenPagePrevious);
			this.panel2.Location = new System.Drawing.Point(15, 6);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.panel2.Size = new System.Drawing.Size(1422, 708);
			this.panel2.TabIndex = 21;
			// 
			// buttonKitchen5
			// 
			this.buttonKitchen5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
			this.buttonKitchen5.FlatAppearance.BorderSize = 0;
			this.buttonKitchen5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchen5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonKitchen5.Location = new System.Drawing.Point(1066, 9);
			this.buttonKitchen5.Name = "buttonKitchen5";
			this.buttonKitchen5.Size = new System.Drawing.Size(228, 130);
			this.buttonKitchen5.TabIndex = 47;
			this.buttonKitchen5.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem5
			// 
			this.buttonKitchenItem5.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem5.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem5.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem5.Location = new System.Drawing.Point(1066, 146);
			this.buttonKitchenItem5.Name = "buttonKitchenItem5";
			this.buttonKitchenItem5.Size = new System.Drawing.Size(228, 134);
			this.buttonKitchenItem5.TabIndex = 46;
			this.buttonKitchenItem5.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem10
			// 
			this.buttonKitchenItem10.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem10.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem10.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem10.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem10.Location = new System.Drawing.Point(1066, 285);
			this.buttonKitchenItem10.Name = "buttonKitchenItem10";
			this.buttonKitchenItem10.Size = new System.Drawing.Size(228, 134);
			this.buttonKitchenItem10.TabIndex = 45;
			this.buttonKitchenItem10.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem15
			// 
			this.buttonKitchenItem15.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem15.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem15.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem15.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem15.Location = new System.Drawing.Point(1066, 424);
			this.buttonKitchenItem15.Name = "buttonKitchenItem15";
			this.buttonKitchenItem15.Size = new System.Drawing.Size(228, 134);
			this.buttonKitchenItem15.TabIndex = 44;
			this.buttonKitchenItem15.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem20
			// 
			this.buttonKitchenItem20.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem20.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem20.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem20.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem20.Location = new System.Drawing.Point(1066, 564);
			this.buttonKitchenItem20.Name = "buttonKitchenItem20";
			this.buttonKitchenItem20.Size = new System.Drawing.Size(228, 134);
			this.buttonKitchenItem20.TabIndex = 43;
			this.buttonKitchenItem20.UseVisualStyleBackColor = false;
			// 
			// buttonKitchen4
			// 
			this.buttonKitchen4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
			this.buttonKitchen4.FlatAppearance.BorderSize = 0;
			this.buttonKitchen4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchen4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonKitchen4.Location = new System.Drawing.Point(832, 9);
			this.buttonKitchen4.Name = "buttonKitchen4";
			this.buttonKitchen4.Size = new System.Drawing.Size(228, 130);
			this.buttonKitchen4.TabIndex = 41;
			this.buttonKitchen4.UseVisualStyleBackColor = false;
			// 
			// buttonKitchen1
			// 
			this.buttonKitchen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
			this.buttonKitchen1.FlatAppearance.BorderSize = 0;
			this.buttonKitchen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchen1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonKitchen1.ImageKey = "KitchenMain.png";
			this.buttonKitchen1.ImageList = this.imageListKitchenDisplay;
			this.buttonKitchen1.Location = new System.Drawing.Point(126, 9);
			this.buttonKitchen1.Name = "buttonKitchen1";
			this.buttonKitchen1.Size = new System.Drawing.Size(230, 130);
			this.buttonKitchen1.TabIndex = 38;
			this.buttonKitchen1.Text = "Main Course Kitchen";
			this.buttonKitchen1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonKitchen1.UseVisualStyleBackColor = false;
			// 
			// imageListKitchenDisplay
			// 
			this.imageListKitchenDisplay.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListKitchenDisplay.ImageStream")));
			this.imageListKitchenDisplay.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListKitchenDisplay.Images.SetKeyName(0, "Barbeque.png");
			this.imageListKitchenDisplay.Images.SetKeyName(1, "Beverages.png");
			this.imageListKitchenDisplay.Images.SetKeyName(2, "KitchenMain.png");
			// 
			// buttonKitchen2
			// 
			this.buttonKitchen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
			this.buttonKitchen2.FlatAppearance.BorderSize = 0;
			this.buttonKitchen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchen2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonKitchen2.ImageKey = "Beverages.png";
			this.buttonKitchen2.ImageList = this.imageListKitchenDisplay;
			this.buttonKitchen2.Location = new System.Drawing.Point(362, 9);
			this.buttonKitchen2.Name = "buttonKitchen2";
			this.buttonKitchen2.Size = new System.Drawing.Size(230, 130);
			this.buttonKitchen2.TabIndex = 37;
			this.buttonKitchen2.Text = "Beverages";
			this.buttonKitchen2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonKitchen2.UseVisualStyleBackColor = false;
			// 
			// buttonKitchen3
			// 
			this.buttonKitchen3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(128)))));
			this.buttonKitchen3.FlatAppearance.BorderSize = 0;
			this.buttonKitchen3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchen3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonKitchen3.ImageKey = "Barbeque.png";
			this.buttonKitchen3.ImageList = this.imageListKitchenDisplay;
			this.buttonKitchen3.Location = new System.Drawing.Point(597, 9);
			this.buttonKitchen3.Name = "buttonKitchen3";
			this.buttonKitchen3.Size = new System.Drawing.Size(230, 130);
			this.buttonKitchen3.TabIndex = 36;
			this.buttonKitchen3.Text = "Barbeque Station";
			this.buttonKitchen3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.buttonKitchen3.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem4
			// 
			this.buttonKitchenItem4.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem4.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem4.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem4.Location = new System.Drawing.Point(832, 146);
			this.buttonKitchenItem4.Name = "buttonKitchenItem4";
			this.buttonKitchenItem4.Size = new System.Drawing.Size(228, 134);
			this.buttonKitchenItem4.TabIndex = 35;
			this.buttonKitchenItem4.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem9
			// 
			this.buttonKitchenItem9.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem9.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem9.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem9.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem9.Location = new System.Drawing.Point(832, 285);
			this.buttonKitchenItem9.Name = "buttonKitchenItem9";
			this.buttonKitchenItem9.Size = new System.Drawing.Size(228, 134);
			this.buttonKitchenItem9.TabIndex = 32;
			this.buttonKitchenItem9.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem14
			// 
			this.buttonKitchenItem14.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem14.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem14.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem14.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem14.Location = new System.Drawing.Point(832, 424);
			this.buttonKitchenItem14.Name = "buttonKitchenItem14";
			this.buttonKitchenItem14.Size = new System.Drawing.Size(228, 134);
			this.buttonKitchenItem14.TabIndex = 29;
			this.buttonKitchenItem14.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem19
			// 
			this.buttonKitchenItem19.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem19.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem19.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem19.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem19.Location = new System.Drawing.Point(832, 564);
			this.buttonKitchenItem19.Name = "buttonKitchenItem19";
			this.buttonKitchenItem19.Size = new System.Drawing.Size(228, 134);
			this.buttonKitchenItem19.TabIndex = 26;
			this.buttonKitchenItem19.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem1
			// 
			this.buttonKitchenItem1.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem1.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonKitchenItem1.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem1.Location = new System.Drawing.Point(126, 146);
			this.buttonKitchenItem1.Name = "buttonKitchenItem1";
			this.buttonKitchenItem1.Size = new System.Drawing.Size(230, 134);
			this.buttonKitchenItem1.TabIndex = 23;
			this.buttonKitchenItem1.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem2
			// 
			this.buttonKitchenItem2.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem2.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem2.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem2.Location = new System.Drawing.Point(362, 146);
			this.buttonKitchenItem2.Name = "buttonKitchenItem2";
			this.buttonKitchenItem2.Size = new System.Drawing.Size(230, 134);
			this.buttonKitchenItem2.TabIndex = 22;
			this.buttonKitchenItem2.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem3
			// 
			this.buttonKitchenItem3.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem3.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem3.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem3.Location = new System.Drawing.Point(597, 146);
			this.buttonKitchenItem3.Name = "buttonKitchenItem3";
			this.buttonKitchenItem3.Size = new System.Drawing.Size(230, 134);
			this.buttonKitchenItem3.TabIndex = 21;
			this.buttonKitchenItem3.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem6
			// 
			this.buttonKitchenItem6.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem6.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem6.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem6.Location = new System.Drawing.Point(126, 285);
			this.buttonKitchenItem6.Name = "buttonKitchenItem6";
			this.buttonKitchenItem6.Size = new System.Drawing.Size(230, 134);
			this.buttonKitchenItem6.TabIndex = 20;
			this.buttonKitchenItem6.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem7
			// 
			this.buttonKitchenItem7.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem7.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem7.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem7.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem7.Location = new System.Drawing.Point(362, 285);
			this.buttonKitchenItem7.Name = "buttonKitchenItem7";
			this.buttonKitchenItem7.Size = new System.Drawing.Size(230, 134);
			this.buttonKitchenItem7.TabIndex = 19;
			this.buttonKitchenItem7.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem8
			// 
			this.buttonKitchenItem8.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem8.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem8.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem8.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem8.Location = new System.Drawing.Point(597, 285);
			this.buttonKitchenItem8.Name = "buttonKitchenItem8";
			this.buttonKitchenItem8.Size = new System.Drawing.Size(230, 134);
			this.buttonKitchenItem8.TabIndex = 18;
			this.buttonKitchenItem8.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem11
			// 
			this.buttonKitchenItem11.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem11.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem11.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem11.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem11.Location = new System.Drawing.Point(126, 424);
			this.buttonKitchenItem11.Name = "buttonKitchenItem11";
			this.buttonKitchenItem11.Size = new System.Drawing.Size(230, 134);
			this.buttonKitchenItem11.TabIndex = 17;
			this.buttonKitchenItem11.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem12
			// 
			this.buttonKitchenItem12.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem12.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem12.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem12.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem12.Location = new System.Drawing.Point(362, 424);
			this.buttonKitchenItem12.Name = "buttonKitchenItem12";
			this.buttonKitchenItem12.Size = new System.Drawing.Size(230, 134);
			this.buttonKitchenItem12.TabIndex = 16;
			this.buttonKitchenItem12.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem13
			// 
			this.buttonKitchenItem13.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem13.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem13.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem13.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem13.Location = new System.Drawing.Point(597, 424);
			this.buttonKitchenItem13.Name = "buttonKitchenItem13";
			this.buttonKitchenItem13.Size = new System.Drawing.Size(230, 134);
			this.buttonKitchenItem13.TabIndex = 15;
			this.buttonKitchenItem13.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem16
			// 
			this.buttonKitchenItem16.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem16.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem16.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem16.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem16.Location = new System.Drawing.Point(126, 564);
			this.buttonKitchenItem16.Name = "buttonKitchenItem16";
			this.buttonKitchenItem16.Size = new System.Drawing.Size(230, 134);
			this.buttonKitchenItem16.TabIndex = 14;
			this.buttonKitchenItem16.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem17
			// 
			this.buttonKitchenItem17.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem17.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem17.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem17.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem17.Location = new System.Drawing.Point(362, 564);
			this.buttonKitchenItem17.Name = "buttonKitchenItem17";
			this.buttonKitchenItem17.Size = new System.Drawing.Size(230, 134);
			this.buttonKitchenItem17.TabIndex = 13;
			this.buttonKitchenItem17.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItem18
			// 
			this.buttonKitchenItem18.BackColor = System.Drawing.SystemColors.Control;
			this.buttonKitchenItem18.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItem18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItem18.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
			this.buttonKitchenItem18.ForeColor = System.Drawing.Color.Black;
			this.buttonKitchenItem18.Location = new System.Drawing.Point(597, 564);
			this.buttonKitchenItem18.Name = "buttonKitchenItem18";
			this.buttonKitchenItem18.Size = new System.Drawing.Size(230, 134);
			this.buttonKitchenItem18.TabIndex = 12;
			this.buttonKitchenItem18.UseVisualStyleBackColor = false;
			// 
			// buttonKitchenItemNext
			// 
			this.buttonKitchenItemNext.BackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonKitchenItemNext.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItemNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItemNext.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonKitchenItemNext.ForeColor = System.Drawing.Color.White;
			this.buttonKitchenItemNext.Location = new System.Drawing.Point(1300, 146);
			this.buttonKitchenItemNext.Name = "buttonKitchenItemNext";
			this.buttonKitchenItemNext.Size = new System.Drawing.Size(111, 552);
			this.buttonKitchenItemNext.TabIndex = 5;
			this.buttonKitchenItemNext.Text = ">";
			this.buttonKitchenItemNext.UseVisualStyleBackColor = false;
			this.buttonKitchenItemNext.Click += new System.EventHandler(this.buttonKitchenItemNext_Click);
			// 
			// buttonKitchenPageNext
			// 
			this.buttonKitchenPageNext.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonKitchenPageNext.FlatAppearance.BorderSize = 0;
			this.buttonKitchenPageNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenPageNext.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonKitchenPageNext.Location = new System.Drawing.Point(1300, 9);
			this.buttonKitchenPageNext.Name = "buttonKitchenPageNext";
			this.buttonKitchenPageNext.Size = new System.Drawing.Size(111, 130);
			this.buttonKitchenPageNext.TabIndex = 4;
			this.buttonKitchenPageNext.Text = ">";
			this.buttonKitchenPageNext.UseVisualStyleBackColor = false;
			this.buttonKitchenPageNext.Click += new System.EventHandler(this.buttonKitchenPageNext_Click);
			// 
			// buttonKitchenItemPrevious
			// 
			this.buttonKitchenItemPrevious.BackColor = System.Drawing.SystemColors.ControlDark;
			this.buttonKitchenItemPrevious.FlatAppearance.BorderSize = 0;
			this.buttonKitchenItemPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenItemPrevious.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonKitchenItemPrevious.ForeColor = System.Drawing.Color.White;
			this.buttonKitchenItemPrevious.Location = new System.Drawing.Point(9, 146);
			this.buttonKitchenItemPrevious.Name = "buttonKitchenItemPrevious";
			this.buttonKitchenItemPrevious.Size = new System.Drawing.Size(111, 552);
			this.buttonKitchenItemPrevious.TabIndex = 1;
			this.buttonKitchenItemPrevious.Text = "<";
			this.buttonKitchenItemPrevious.UseVisualStyleBackColor = false;
			this.buttonKitchenItemPrevious.Click += new System.EventHandler(this.buttonKitchenItemPrevious_Click);
			// 
			// buttonKitchenPagePrevious
			// 
			this.buttonKitchenPagePrevious.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonKitchenPagePrevious.FlatAppearance.BorderSize = 0;
			this.buttonKitchenPagePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonKitchenPagePrevious.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonKitchenPagePrevious.Location = new System.Drawing.Point(9, 9);
			this.buttonKitchenPagePrevious.Name = "buttonKitchenPagePrevious";
			this.buttonKitchenPagePrevious.Size = new System.Drawing.Size(111, 130);
			this.buttonKitchenPagePrevious.TabIndex = 0;
			this.buttonKitchenPagePrevious.Text = "<";
			this.buttonKitchenPagePrevious.UseVisualStyleBackColor = false;
			this.buttonKitchenPagePrevious.Click += new System.EventHandler(this.buttonKitchenPagePrevious_Click);
			// 
			// dateTimePickerSalesDate
			// 
			this.dateTimePickerSalesDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerSalesDate.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.dateTimePickerSalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerSalesDate.Location = new System.Drawing.Point(1443, 6);
			this.dateTimePickerSalesDate.Name = "dateTimePickerSalesDate";
			this.dateTimePickerSalesDate.Size = new System.Drawing.Size(182, 39);
			this.dateTimePickerSalesDate.TabIndex = 9;
			this.dateTimePickerSalesDate.ValueChanged += new System.EventHandler(this.dateTimePickerSalesDate_ValueChanged);
			// 
			// SysKitchenDisplayForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1644, 840);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SysKitchenDisplayForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SysKitchenDisplayForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoneItemDisplay)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePickerSalesDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonKitchen5;
        private System.Windows.Forms.Button buttonKitchenItem5;
        private System.Windows.Forms.Button buttonKitchenItem10;
        private System.Windows.Forms.Button buttonKitchenItem15;
        private System.Windows.Forms.Button buttonKitchenItem20;
        private System.Windows.Forms.Button buttonKitchen4;
        private System.Windows.Forms.Button buttonKitchen1;
        private System.Windows.Forms.Button buttonKitchen2;
        private System.Windows.Forms.Button buttonKitchen3;
        private System.Windows.Forms.Button buttonKitchenItem4;
        private System.Windows.Forms.Button buttonKitchenItem9;
        private System.Windows.Forms.Button buttonKitchenItem14;
        private System.Windows.Forms.Button buttonKitchenItem19;
        private System.Windows.Forms.Button buttonKitchenItem1;
        private System.Windows.Forms.Button buttonKitchenItem2;
        private System.Windows.Forms.Button buttonKitchenItem3;
        private System.Windows.Forms.Button buttonKitchenItem6;
        private System.Windows.Forms.Button buttonKitchenItem7;
        private System.Windows.Forms.Button buttonKitchenItem8;
        private System.Windows.Forms.Button buttonKitchenItem11;
        private System.Windows.Forms.Button buttonKitchenItem12;
        private System.Windows.Forms.Button buttonKitchenItem13;
        private System.Windows.Forms.Button buttonKitchenItem16;
        private System.Windows.Forms.Button buttonKitchenItem17;
        private System.Windows.Forms.Button buttonKitchenItem18;
        private System.Windows.Forms.Button buttonKitchenItemNext;
        private System.Windows.Forms.Button buttonKitchenPageNext;
        private System.Windows.Forms.Button buttonKitchenItemPrevious;
        private System.Windows.Forms.Button buttonKitchenPagePrevious;
        private System.Windows.Forms.ImageList imageListKitchenDisplay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewDoneItemDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDoneItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.ComboBox comboBoxSINumber;
    }
}