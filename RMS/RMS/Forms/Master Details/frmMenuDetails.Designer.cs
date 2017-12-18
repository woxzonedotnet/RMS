namespace RMS.Forms
{
    partial class frmMenuDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalMenuCost = new System.Windows.Forms.Label();
            this.txtMenuCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDiscriptionOnBill = new System.Windows.Forms.TextBox();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.txtPackingCharge = new System.Windows.Forms.TextBox();
            this.txtPrepareTime = new System.Windows.Forms.TextBox();
            this.btBackColor = new System.Windows.Forms.Button();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.chkServiceCharge = new System.Windows.Forms.CheckBox();
            this.dgvRecipe = new System.Windows.Forms.DataGridView();
            this.clmRecipeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRecipeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLocation = new System.Windows.Forms.DataGridView();
            this.clmLocationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmServiceChargePresentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalMenuCost = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSupplierCode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.colorBacground = new System.Windows.Forms.ColorDialog();
            this.colorForground = new System.Windows.Forms.ColorDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.errSRN = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMenuButton = new System.Windows.Forms.Panel();
            this.pnlMenuButtonLabel = new System.Windows.Forms.Panel();
            this.lblMenuButtonName = new System.Windows.Forms.Label();
            this.picMenuButton = new System.Windows.Forms.PictureBox();
            this.btnImageBrowse = new System.Windows.Forms.Button();
            this.txtImageLocation = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MenuButtonFont = new System.Windows.Forms.FontDialog();
            this.btnImageFont = new System.Windows.Forms.Button();
            this.txtButtonName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbStatus = new RMS.ColumnComboBox();
            this.cmbMenuDepartment = new RMS.ColumnComboBox();
            this.cmbMenuCategory = new RMS.ColumnComboBox();
            this.cmbLocation = new RMS.ColumnComboBox();
            this.cmbPrintLocation = new RMS.ColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSRN)).BeginInit();
            this.pnlMenuButton.SuspendLayout();
            this.pnlMenuButtonLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description Appear on Bill";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selling Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(267, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Printer Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(267, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Packing Charge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.Location = new System.Drawing.Point(12, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Time to Prepare";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label9.Location = new System.Drawing.Point(267, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Menu Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label10.Location = new System.Drawing.Point(194, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "In Minutes";
            // 
            // lblTotalMenuCost
            // 
            this.lblTotalMenuCost.AutoSize = true;
            this.lblTotalMenuCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblTotalMenuCost.Location = new System.Drawing.Point(534, 407);
            this.lblTotalMenuCost.Name = "lblTotalMenuCost";
            this.lblTotalMenuCost.Size = new System.Drawing.Size(105, 16);
            this.lblTotalMenuCost.TabIndex = 12;
            this.lblTotalMenuCost.Text = "Total Menu Cost";
            // 
            // txtMenuCode
            // 
            this.txtMenuCode.Location = new System.Drawing.Point(180, 49);
            this.txtMenuCode.Name = "txtMenuCode";
            this.txtMenuCode.Size = new System.Drawing.Size(226, 20);
            this.txtMenuCode.TabIndex = 13;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(180, 77);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(344, 20);
            this.txtDescription.TabIndex = 14;
            // 
            // txtDiscriptionOnBill
            // 
            this.txtDiscriptionOnBill.Location = new System.Drawing.Point(180, 105);
            this.txtDiscriptionOnBill.Name = "txtDiscriptionOnBill";
            this.txtDiscriptionOnBill.Size = new System.Drawing.Size(344, 20);
            this.txtDiscriptionOnBill.TabIndex = 15;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(127, 191);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(134, 20);
            this.txtSellingPrice.TabIndex = 16;
            // 
            // txtPackingCharge
            // 
            this.txtPackingCharge.Location = new System.Drawing.Point(373, 191);
            this.txtPackingCharge.Name = "txtPackingCharge";
            this.txtPackingCharge.Size = new System.Drawing.Size(151, 20);
            this.txtPackingCharge.TabIndex = 19;
            // 
            // txtPrepareTime
            // 
            this.txtPrepareTime.Location = new System.Drawing.Point(127, 221);
            this.txtPrepareTime.Name = "txtPrepareTime";
            this.txtPrepareTime.Size = new System.Drawing.Size(66, 20);
            this.txtPrepareTime.TabIndex = 20;
            // 
            // btBackColor
            // 
            this.btBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btBackColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBackColor.ForeColor = System.Drawing.SystemColors.Control;
            this.btBackColor.Location = new System.Drawing.Point(548, 159);
            this.btBackColor.Name = "btBackColor";
            this.btBackColor.Size = new System.Drawing.Size(78, 36);
            this.btBackColor.TabIndex = 22;
            this.btBackColor.Text = "Background";
            this.btBackColor.UseVisualStyleBackColor = false;
            this.btBackColor.Click += new System.EventHandler(this.btBackColor_Click);
            // 
            // btnTextColor
            // 
            this.btnTextColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnTextColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnTextColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextColor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTextColor.Location = new System.Drawing.Point(651, 159);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(78, 36);
            this.btnTextColor.TabIndex = 23;
            this.btnTextColor.Text = "Text Color";
            this.btnTextColor.UseVisualStyleBackColor = false;
            this.btnTextColor.Click += new System.EventHandler(this.btnTextColor_Click);
            // 
            // chkServiceCharge
            // 
            this.chkServiceCharge.AutoSize = true;
            this.chkServiceCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.chkServiceCharge.Location = new System.Drawing.Point(270, 221);
            this.chkServiceCharge.Name = "chkServiceCharge";
            this.chkServiceCharge.Size = new System.Drawing.Size(120, 20);
            this.chkServiceCharge.TabIndex = 26;
            this.chkServiceCharge.Text = "Service Charge";
            this.chkServiceCharge.UseVisualStyleBackColor = true;
            // 
            // dgvRecipe
            // 
            this.dgvRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRecipeCode,
            this.clmRecipeDescription,
            this.clmUnitPrice,
            this.clmQuantity,
            this.clmTotalCost});
            this.dgvRecipe.Location = new System.Drawing.Point(16, 247);
            this.dgvRecipe.Name = "dgvRecipe";
            this.dgvRecipe.Size = new System.Drawing.Size(512, 231);
            this.dgvRecipe.TabIndex = 29;
            this.dgvRecipe.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecipe_CellValidated);
            this.dgvRecipe.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvRecipe_CurrentCellDirtyStateChanged);
            this.dgvRecipe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRecipe_KeyDown);
            this.dgvRecipe.Leave += new System.EventHandler(this.dgvRecipe_Leave);
            // 
            // clmRecipeCode
            // 
            this.clmRecipeCode.HeaderText = "Recipe Code";
            this.clmRecipeCode.Name = "clmRecipeCode";
            this.clmRecipeCode.ReadOnly = true;
            this.clmRecipeCode.Width = 80;
            // 
            // clmRecipeDescription
            // 
            this.clmRecipeDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmRecipeDescription.HeaderText = "Recipe Description";
            this.clmRecipeDescription.Name = "clmRecipeDescription";
            // 
            // clmUnitPrice
            // 
            this.clmUnitPrice.HeaderText = "Unit Price";
            this.clmUnitPrice.Name = "clmUnitPrice";
            this.clmUnitPrice.Width = 80;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.Width = 60;
            // 
            // clmTotalCost
            // 
            this.clmTotalCost.HeaderText = "Total Cost";
            this.clmTotalCost.Name = "clmTotalCost";
            this.clmTotalCost.ReadOnly = true;
            this.clmTotalCost.Width = 80;
            // 
            // dgvLocation
            // 
            this.dgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmLocationCode,
            this.clmLocation,
            this.clmSalePrice,
            this.clmServiceChargePresentage});
            this.dgvLocation.Location = new System.Drawing.Point(537, 247);
            this.dgvLocation.Name = "dgvLocation";
            this.dgvLocation.Size = new System.Drawing.Size(318, 150);
            this.dgvLocation.TabIndex = 30;
            this.dgvLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvLocation_KeyDown);
            // 
            // clmLocationCode
            // 
            this.clmLocationCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmLocationCode.HeaderText = "Location Code";
            this.clmLocationCode.Name = "clmLocationCode";
            this.clmLocationCode.ReadOnly = true;
            // 
            // clmLocation
            // 
            this.clmLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmLocation.HeaderText = "Location";
            this.clmLocation.Name = "clmLocation";
            // 
            // clmSalePrice
            // 
            this.clmSalePrice.HeaderText = "Sale Price";
            this.clmSalePrice.Name = "clmSalePrice";
            this.clmSalePrice.Width = 80;
            // 
            // clmServiceChargePresentage
            // 
            this.clmServiceChargePresentage.HeaderText = "Service Charge Presentage %";
            this.clmServiceChargePresentage.Name = "clmServiceChargePresentage";
            this.clmServiceChargePresentage.Width = 80;
            // 
            // txtTotalMenuCost
            // 
            this.txtTotalMenuCost.Location = new System.Drawing.Point(651, 406);
            this.txtTotalMenuCost.Name = "txtTotalMenuCost";
            this.txtTotalMenuCost.Size = new System.Drawing.Size(204, 20);
            this.txtTotalMenuCost.TabIndex = 31;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::RMS.Properties.Resources.search25;
            this.btnSearch.Location = new System.Drawing.Point(417, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel4.Location = new System.Drawing.Point(-11, 490);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(944, 10);
            this.panel4.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel3.Location = new System.Drawing.Point(-9, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 541);
            this.panel3.TabIndex = 57;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel2.Location = new System.Drawing.Point(867, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 551);
            this.panel2.TabIndex = 56;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(780, 442);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(618, 442);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(699, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 52;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(537, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.AutoSize = true;
            this.lblSupplierCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierCode.Location = new System.Drawing.Point(12, 162);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Size = new System.Drawing.Size(114, 16);
            this.lblSupplierCode.TabIndex = 50;
            this.lblSupplierCode.Text = "Menu Department";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 31);
            this.panel1.TabIndex = 60;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(86, 16);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Menu Details";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.btnExit.Location = new System.Drawing.Point(831, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(545, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 62;
            this.label11.Text = "Status";
            // 
            // errSRN
            // 
            this.errSRN.ContainerControl = this;
            // 
            // pnlMenuButton
            // 
            this.pnlMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.pnlMenuButton.Controls.Add(this.pnlMenuButtonLabel);
            this.pnlMenuButton.Controls.Add(this.picMenuButton);
            this.pnlMenuButton.Location = new System.Drawing.Point(740, 116);
            this.pnlMenuButton.Name = "pnlMenuButton";
            this.pnlMenuButton.Size = new System.Drawing.Size(115, 79);
            this.pnlMenuButton.TabIndex = 64;
            // 
            // pnlMenuButtonLabel
            // 
            this.pnlMenuButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuButtonLabel.Controls.Add(this.lblMenuButtonName);
            this.pnlMenuButtonLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMenuButtonLabel.Location = new System.Drawing.Point(0, 58);
            this.pnlMenuButtonLabel.Name = "pnlMenuButtonLabel";
            this.pnlMenuButtonLabel.Size = new System.Drawing.Size(115, 21);
            this.pnlMenuButtonLabel.TabIndex = 2;
            // 
            // lblMenuButtonName
            // 
            this.lblMenuButtonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenuButtonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuButtonName.ForeColor = System.Drawing.Color.White;
            this.lblMenuButtonName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMenuButtonName.Location = new System.Drawing.Point(0, 0);
            this.lblMenuButtonName.Name = "lblMenuButtonName";
            this.lblMenuButtonName.Size = new System.Drawing.Size(115, 21);
            this.lblMenuButtonName.TabIndex = 0;
            this.lblMenuButtonName.Text = "Name";
            this.lblMenuButtonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuButtonName.Click += new System.EventHandler(this.label12_Click);
            // 
            // picMenuButton
            // 
            this.picMenuButton.Location = new System.Drawing.Point(3, 3);
            this.picMenuButton.Name = "picMenuButton";
            this.picMenuButton.Size = new System.Drawing.Size(109, 59);
            this.picMenuButton.TabIndex = 1;
            this.picMenuButton.TabStop = false;
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnImageBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnImageBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageBrowse.ForeColor = System.Drawing.Color.White;
            this.btnImageBrowse.Location = new System.Drawing.Point(786, 71);
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.Size = new System.Drawing.Size(70, 23);
            this.btnImageBrowse.TabIndex = 68;
            this.btnImageBrowse.Text = "Browse";
            this.btnImageBrowse.UseVisualStyleBackColor = false;
            this.btnImageBrowse.Click += new System.EventHandler(this.btnImageBrowse_Click);
            // 
            // txtImageLocation
            // 
            this.txtImageLocation.Location = new System.Drawing.Point(597, 73);
            this.txtImageLocation.Name = "txtImageLocation";
            this.txtImageLocation.Size = new System.Drawing.Size(183, 20);
            this.txtImageLocation.TabIndex = 67;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label13.Location = new System.Drawing.Point(545, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 16);
            this.label13.TabIndex = 69;
            this.label13.Text = "Image";
            // 
            // btnImageFont
            // 
            this.btnImageFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnImageFont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnImageFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageFont.ForeColor = System.Drawing.Color.White;
            this.btnImageFont.Location = new System.Drawing.Point(687, 129);
            this.btnImageFont.Name = "btnImageFont";
            this.btnImageFont.Size = new System.Drawing.Size(50, 26);
            this.btnImageFont.TabIndex = 70;
            this.btnImageFont.Text = "Font";
            this.btnImageFont.UseVisualStyleBackColor = false;
            this.btnImageFont.Click += new System.EventHandler(this.btnImageFont_Click);
            // 
            // txtButtonName
            // 
            this.txtButtonName.Location = new System.Drawing.Point(547, 133);
            this.txtButtonName.Name = "txtButtonName";
            this.txtButtonName.Size = new System.Drawing.Size(134, 20);
            this.txtButtonName.TabIndex = 71;
            this.txtButtonName.Text = "Name";
            this.txtButtonName.TextChanged += new System.EventHandler(this.txtButtonName_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label14.Location = new System.Drawing.Point(545, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 16);
            this.label14.TabIndex = 72;
            this.label14.Text = "Button Name";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbStatus.DropDownWidth = 17;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(596, 214);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(185, 21);
            this.cmbStatus.TabIndex = 63;
            this.cmbStatus.ViewColumn = 0;
            // 
            // cmbMenuDepartment
            // 
            this.cmbMenuDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMenuDepartment.DropDownWidth = 17;
            this.cmbMenuDepartment.FormattingEnabled = true;
            this.cmbMenuDepartment.Location = new System.Drawing.Point(127, 161);
            this.cmbMenuDepartment.Name = "cmbMenuDepartment";
            this.cmbMenuDepartment.Size = new System.Drawing.Size(134, 21);
            this.cmbMenuDepartment.TabIndex = 61;
            this.cmbMenuDepartment.ViewColumn = 0;
            this.cmbMenuDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbMenuDepartment_SelectedIndexChanged);
            // 
            // cmbMenuCategory
            // 
            this.cmbMenuCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMenuCategory.DropDownWidth = 17;
            this.cmbMenuCategory.FormattingEnabled = true;
            this.cmbMenuCategory.Location = new System.Drawing.Point(373, 161);
            this.cmbMenuCategory.Name = "cmbMenuCategory";
            this.cmbMenuCategory.Size = new System.Drawing.Size(151, 21);
            this.cmbMenuCategory.TabIndex = 21;
            this.cmbMenuCategory.ViewColumn = 0;
            // 
            // cmbLocation
            // 
            this.cmbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLocation.DropDownWidth = 17;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(127, 132);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(134, 21);
            this.cmbLocation.TabIndex = 18;
            this.cmbLocation.ViewColumn = 0;
            // 
            // cmbPrintLocation
            // 
            this.cmbPrintLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPrintLocation.DropDownWidth = 17;
            this.cmbPrintLocation.FormattingEnabled = true;
            this.cmbPrintLocation.Location = new System.Drawing.Point(373, 132);
            this.cmbPrintLocation.Name = "cmbPrintLocation";
            this.cmbPrintLocation.Size = new System.Drawing.Size(151, 21);
            this.cmbPrintLocation.TabIndex = 17;
            this.cmbPrintLocation.ViewColumn = 0;
            // 
            // frmMenuDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 491);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtButtonName);
            this.Controls.Add(this.btnImageFont);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnImageBrowse);
            this.Controls.Add(this.txtImageLocation);
            this.Controls.Add(this.pnlMenuButton);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbMenuDepartment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSupplierCode);
            this.Controls.Add(this.txtTotalMenuCost);
            this.Controls.Add(this.dgvLocation);
            this.Controls.Add(this.dgvRecipe);
            this.Controls.Add(this.chkServiceCharge);
            this.Controls.Add(this.btnTextColor);
            this.Controls.Add(this.btBackColor);
            this.Controls.Add(this.cmbMenuCategory);
            this.Controls.Add(this.txtPrepareTime);
            this.Controls.Add(this.txtPackingCharge);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.cmbPrintLocation);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.txtDiscriptionOnBill);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtMenuCode);
            this.Controls.Add(this.lblTotalMenuCost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuDetails";
            this.Load += new System.EventHandler(this.frmMenuDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSRN)).EndInit();
            this.pnlMenuButton.ResumeLayout(false);
            this.pnlMenuButtonLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenuButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalMenuCost;
        private System.Windows.Forms.TextBox txtMenuCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDiscriptionOnBill;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private ColumnComboBox cmbPrintLocation;
        private ColumnComboBox cmbLocation;
        private System.Windows.Forms.TextBox txtPackingCharge;
        private System.Windows.Forms.TextBox txtPrepareTime;
        private ColumnComboBox cmbMenuCategory;
        private System.Windows.Forms.Button btBackColor;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.CheckBox chkServiceCharge;
        private System.Windows.Forms.DataGridView dgvRecipe;
        private System.Windows.Forms.DataGridView dgvLocation;
        private System.Windows.Forms.TextBox txtTotalMenuCost;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSupplierCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private ColumnComboBox cmbMenuDepartment;
        private System.Windows.Forms.ColorDialog colorBacground;
        private System.Windows.Forms.ColorDialog colorForground;
        private ColumnComboBox cmbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errSRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRecipeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRecipeDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalCost;
        private System.Windows.Forms.Button btnImageBrowse;
        private System.Windows.Forms.TextBox txtImageLocation;
        private System.Windows.Forms.Panel pnlMenuButton;
        private System.Windows.Forms.Panel pnlMenuButtonLabel;
        private System.Windows.Forms.Label lblMenuButtonName;
        private System.Windows.Forms.PictureBox picMenuButton;
        private System.Windows.Forms.Button btnImageFont;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.FontDialog MenuButtonFont;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtButtonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmServiceChargePresentage;
    }
}