namespace RMS.Forms
{
    partial class frmItemDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemDetails));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtROQ = new System.Windows.Forms.TextBox();
            this.lblROQ = new System.Windows.Forms.Label();
            this.txtROL = new System.Windows.Forms.TextBox();
            this.lblROL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSelling = new System.Windows.Forms.TextBox();
            this.lblSelling = new System.Windows.Forms.Label();
            this.txtWholeSale = new System.Windows.Forms.TextBox();
            this.lblWholeSale = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPackageSize = new System.Windows.Forms.TextBox();
            this.txtMinimumGP = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblPackageSize = new System.Windows.Forms.Label();
            this.lblCapacityML = new System.Windows.Forms.Label();
            this.lblMinimumGP = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblMCategory = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblWeighted = new System.Windows.Forms.Label();
            this.lblConsignm = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblActiveStatus = new System.Windows.Forms.Label();
            this.errItem = new System.Windows.Forms.ErrorProvider(this.components);
            this.fldBoolName = new System.Data.DataColumn();
            this.fldBoolValue = new System.Data.DataColumn();
            this.cmbConsignm = new System.Windows.Forms.ComboBox();
            this.cmbWeighted = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new RMS.ColumnComboBox();
            this.cmbCapacityType = new RMS.ColumnComboBox();
            this.cmbSupplier = new RMS.ColumnComboBox();
            this.cmbMCategory = new RMS.ColumnComboBox();
            this.cmbCategory = new RMS.ColumnComboBox();
            this.cmbDepartment = new RMS.ColumnComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(742, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 92;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(661, 440);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 91;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(580, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 90;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(499, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 89;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(95, 76);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(157, 20);
            this.txtMax.TabIndex = 34;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblMax.Location = new System.Drawing.Point(11, 77);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(33, 16);
            this.lblMax.TabIndex = 33;
            this.lblMax.Text = "Max";
            // 
            // txtROQ
            // 
            this.txtROQ.Location = new System.Drawing.Point(95, 47);
            this.txtROQ.Name = "txtROQ";
            this.txtROQ.Size = new System.Drawing.Size(157, 20);
            this.txtROQ.TabIndex = 32;
            // 
            // lblROQ
            // 
            this.lblROQ.AutoSize = true;
            this.lblROQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblROQ.Location = new System.Drawing.Point(11, 48);
            this.lblROQ.Name = "lblROQ";
            this.lblROQ.Size = new System.Drawing.Size(38, 16);
            this.lblROQ.TabIndex = 31;
            this.lblROQ.Text = "ROQ";
            // 
            // txtROL
            // 
            this.txtROL.Location = new System.Drawing.Point(95, 19);
            this.txtROL.Name = "txtROL";
            this.txtROL.Size = new System.Drawing.Size(157, 20);
            this.txtROL.TabIndex = 30;
            // 
            // lblROL
            // 
            this.lblROL.AutoSize = true;
            this.lblROL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblROL.Location = new System.Drawing.Point(11, 20);
            this.lblROL.Name = "lblROL";
            this.lblROL.Size = new System.Drawing.Size(35, 16);
            this.lblROL.TabIndex = 29;
            this.lblROL.Text = "ROL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSelling);
            this.groupBox1.Controls.Add(this.lblSelling);
            this.groupBox1.Controls.Add(this.txtWholeSale);
            this.groupBox1.Controls.Add(this.lblWholeSale);
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(this.lblCost);
            this.groupBox1.Location = new System.Drawing.Point(578, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 106);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price";
            // 
            // txtSelling
            // 
            this.txtSelling.Location = new System.Drawing.Point(95, 76);
            this.txtSelling.Name = "txtSelling";
            this.txtSelling.Size = new System.Drawing.Size(157, 20);
            this.txtSelling.TabIndex = 34;
            // 
            // lblSelling
            // 
            this.lblSelling.AutoSize = true;
            this.lblSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSelling.Location = new System.Drawing.Point(11, 77);
            this.lblSelling.Name = "lblSelling";
            this.lblSelling.Size = new System.Drawing.Size(49, 16);
            this.lblSelling.TabIndex = 33;
            this.lblSelling.Text = "Selling";
            // 
            // txtWholeSale
            // 
            this.txtWholeSale.Location = new System.Drawing.Point(95, 47);
            this.txtWholeSale.Name = "txtWholeSale";
            this.txtWholeSale.Size = new System.Drawing.Size(157, 20);
            this.txtWholeSale.TabIndex = 32;
            // 
            // lblWholeSale
            // 
            this.lblWholeSale.AutoSize = true;
            this.lblWholeSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblWholeSale.Location = new System.Drawing.Point(11, 48);
            this.lblWholeSale.Name = "lblWholeSale";
            this.lblWholeSale.Size = new System.Drawing.Size(78, 16);
            this.lblWholeSale.TabIndex = 31;
            this.lblWholeSale.Text = "Whole Sale";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(95, 19);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(157, 20);
            this.txtCost.TabIndex = 30;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCost.Location = new System.Drawing.Point(11, 20);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(35, 16);
            this.lblCost.TabIndex = 29;
            this.lblCost.Text = "Cost";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMax);
            this.groupBox2.Controls.Add(this.lblMax);
            this.groupBox2.Controls.Add(this.txtROQ);
            this.groupBox2.Controls.Add(this.lblROQ);
            this.groupBox2.Controls.Add(this.txtROL);
            this.groupBox2.Controls.Add(this.lblROL);
            this.groupBox2.Location = new System.Drawing.Point(578, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 106);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Re Oder";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 150);
            this.dataGridView1.TabIndex = 80;
            // 
            // txtPackageSize
            // 
            this.txtPackageSize.Location = new System.Drawing.Point(114, 231);
            this.txtPackageSize.Name = "txtPackageSize";
            this.txtPackageSize.Size = new System.Drawing.Size(157, 20);
            this.txtPackageSize.TabIndex = 75;
            // 
            // txtMinimumGP
            // 
            this.txtMinimumGP.Location = new System.Drawing.Point(396, 199);
            this.txtMinimumGP.Name = "txtMinimumGP";
            this.txtMinimumGP.Size = new System.Drawing.Size(157, 20);
            this.txtMinimumGP.TabIndex = 74;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(397, 231);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(115, 20);
            this.txtCapacity.TabIndex = 69;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(114, 200);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(157, 20);
            this.txtUnit.TabIndex = 68;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(396, 43);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(157, 82);
            this.txtDescription.TabIndex = 65;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(114, 42);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(157, 20);
            this.txtBarCode.TabIndex = 64;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(114, 12);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(157, 20);
            this.txtItemCode.TabIndex = 63;
            // 
            // lblPackageSize
            // 
            this.lblPackageSize.AutoSize = true;
            this.lblPackageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblPackageSize.Location = new System.Drawing.Point(17, 232);
            this.lblPackageSize.Name = "lblPackageSize";
            this.lblPackageSize.Size = new System.Drawing.Size(92, 16);
            this.lblPackageSize.TabIndex = 62;
            this.lblPackageSize.Text = "Package Size";
            // 
            // lblCapacityML
            // 
            this.lblCapacityML.AutoSize = true;
            this.lblCapacityML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCapacityML.Location = new System.Drawing.Point(299, 231);
            this.lblCapacityML.Name = "lblCapacityML";
            this.lblCapacityML.Size = new System.Drawing.Size(94, 16);
            this.lblCapacityML.TabIndex = 61;
            this.lblCapacityML.Text = "Capacity (kg/l)";
            // 
            // lblMinimumGP
            // 
            this.lblMinimumGP.AutoSize = true;
            this.lblMinimumGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblMinimumGP.Location = new System.Drawing.Point(299, 200);
            this.lblMinimumGP.Name = "lblMinimumGP";
            this.lblMinimumGP.Size = new System.Drawing.Size(83, 16);
            this.lblMinimumGP.TabIndex = 60;
            this.lblMinimumGP.Text = "Minimum GP";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSupplier.Location = new System.Drawing.Point(16, 169);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(58, 16);
            this.lblSupplier.TabIndex = 59;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblMCategory
            // 
            this.lblMCategory.AutoSize = true;
            this.lblMCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblMCategory.Location = new System.Drawing.Point(299, 168);
            this.lblMCategory.Name = "lblMCategory";
            this.lblMCategory.Size = new System.Drawing.Size(80, 16);
            this.lblMCategory.TabIndex = 58;
            this.lblMCategory.Text = "M. Category";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCategory.Location = new System.Drawing.Point(17, 137);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(63, 16);
            this.lblCategory.TabIndex = 56;
            this.lblCategory.Text = "Category";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDepartment.Location = new System.Drawing.Point(16, 105);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(78, 16);
            this.lblDepartment.TabIndex = 55;
            this.lblDepartment.Text = "Department";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblUnit.Location = new System.Drawing.Point(16, 201);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(31, 16);
            this.lblUnit.TabIndex = 54;
            this.lblUnit.Text = "Unit";
            // 
            // lblWeighted
            // 
            this.lblWeighted.AutoSize = true;
            this.lblWeighted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblWeighted.Location = new System.Drawing.Point(299, 137);
            this.lblWeighted.Name = "lblWeighted";
            this.lblWeighted.Size = new System.Drawing.Size(66, 16);
            this.lblWeighted.TabIndex = 53;
            this.lblWeighted.Text = "Weighted";
            // 
            // lblConsignm
            // 
            this.lblConsignm.AutoSize = true;
            this.lblConsignm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblConsignm.Location = new System.Drawing.Point(16, 73);
            this.lblConsignm.Name = "lblConsignm";
            this.lblConsignm.Size = new System.Drawing.Size(68, 16);
            this.lblConsignm.TabIndex = 52;
            this.lblConsignm.Text = "Consignm";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDescription.Location = new System.Drawing.Point(299, 44);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 16);
            this.lblDescription.TabIndex = 51;
            this.lblDescription.Text = "Description";
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblBarCode.Location = new System.Drawing.Point(16, 43);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(65, 16);
            this.lblBarCode.TabIndex = 50;
            this.lblBarCode.Text = "Bar Code";
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblItemCode.Location = new System.Drawing.Point(16, 13);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(69, 16);
            this.lblItemCode.TabIndex = 49;
            this.lblItemCode.Text = "Item Code";
            // 
            // lblActiveStatus
            // 
            this.lblActiveStatus.AutoSize = true;
            this.lblActiveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveStatus.Location = new System.Drawing.Point(576, 238);
            this.lblActiveStatus.Name = "lblActiveStatus";
            this.lblActiveStatus.Size = new System.Drawing.Size(85, 16);
            this.lblActiveStatus.TabIndex = 95;
            this.lblActiveStatus.Text = "Active Status";
            this.lblActiveStatus.Click += new System.EventHandler(this.lblActiveStatus_Click);
            // 
            // errItem
            // 
            this.errItem.ContainerControl = this;
            // 
            // fldBoolName
            // 
            this.fldBoolName.Caption = "Name";
            this.fldBoolName.ColumnName = "fldBoolName";
            // 
            // fldBoolValue
            // 
            this.fldBoolValue.Caption = "BoolValue";
            this.fldBoolValue.ColumnName = "fldBoolValue";
            // 
            // cmbConsignm
            // 
            this.cmbConsignm.FormattingEnabled = true;
            this.cmbConsignm.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbConsignm.Location = new System.Drawing.Point(114, 72);
            this.cmbConsignm.Name = "cmbConsignm";
            this.cmbConsignm.Size = new System.Drawing.Size(157, 21);
            this.cmbConsignm.TabIndex = 96;
            // 
            // cmbWeighted
            // 
            this.cmbWeighted.FormattingEnabled = true;
            this.cmbWeighted.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbWeighted.Location = new System.Drawing.Point(396, 136);
            this.cmbWeighted.Name = "cmbWeighted";
            this.cmbWeighted.Size = new System.Drawing.Size(157, 21);
            this.cmbWeighted.TabIndex = 96;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbStatus.DropDownWidth = 17;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(673, 237);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(157, 21);
            this.cmbStatus.TabIndex = 94;
            this.cmbStatus.ViewColumn = 0;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // cmbCapacityType
            // 
            this.cmbCapacityType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCapacityType.DropDownWidth = 17;
            this.cmbCapacityType.FormattingEnabled = true;
            this.cmbCapacityType.Location = new System.Drawing.Point(518, 230);
            this.cmbCapacityType.Name = "cmbCapacityType";
            this.cmbCapacityType.Size = new System.Drawing.Size(36, 21);
            this.cmbCapacityType.TabIndex = 93;
            this.cmbCapacityType.ViewColumn = 0;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSupplier.DropDownWidth = 17;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(114, 168);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(157, 21);
            this.cmbSupplier.TabIndex = 76;
            this.cmbSupplier.ViewColumn = 0;
            // 
            // cmbMCategory
            // 
            this.cmbMCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMCategory.DropDownWidth = 17;
            this.cmbMCategory.FormattingEnabled = true;
            this.cmbMCategory.Location = new System.Drawing.Point(396, 167);
            this.cmbMCategory.Name = "cmbMCategory";
            this.cmbMCategory.Size = new System.Drawing.Size(157, 21);
            this.cmbMCategory.TabIndex = 73;
            this.cmbMCategory.ViewColumn = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategory.DropDownWidth = 17;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(114, 136);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(157, 21);
            this.cmbCategory.TabIndex = 71;
            this.cmbCategory.ViewColumn = 0;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDepartment.DropDownWidth = 17;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(114, 104);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(157, 21);
            this.cmbDepartment.TabIndex = 70;
            this.cmbDepartment.ViewColumn = 0;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::RMS.Properties.Resources.search25;
            this.btnSearch.Location = new System.Drawing.Point(286, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 97;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // frmItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 489);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbWeighted);
            this.Controls.Add(this.cmbConsignm);
            this.Controls.Add(this.lblActiveStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbCapacityType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.txtPackageSize);
            this.Controls.Add(this.txtMinimumGP);
            this.Controls.Add(this.cmbMCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.lblPackageSize);
            this.Controls.Add(this.lblCapacityML);
            this.Controls.Add(this.lblMinimumGP);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblMCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblWeighted);
            this.Controls.Add(this.lblConsignm);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblBarCode);
            this.Controls.Add(this.lblItemCode);
            this.Name = "frmItemDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Details";
            this.Load += new System.EventHandler(this.frmItemDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtROQ;
        private System.Windows.Forms.Label lblROQ;
        private System.Windows.Forms.TextBox txtROL;
        private System.Windows.Forms.Label lblROL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSelling;
        private System.Windows.Forms.Label lblSelling;
        private System.Windows.Forms.TextBox txtWholeSale;
        private System.Windows.Forms.Label lblWholeSale;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ColumnComboBox cmbSupplier;
        private System.Windows.Forms.TextBox txtPackageSize;
        private System.Windows.Forms.TextBox txtMinimumGP;
        private ColumnComboBox cmbMCategory;
        private ColumnComboBox cmbCategory;
        private ColumnComboBox cmbDepartment;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label lblPackageSize;
        private System.Windows.Forms.Label lblCapacityML;
        private System.Windows.Forms.Label lblMinimumGP;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblMCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblWeighted;
        private System.Windows.Forms.Label lblConsignm;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.Label lblItemCode;
        private ColumnComboBox cmbCapacityType;
        private System.Windows.Forms.Label lblActiveStatus;
        private ColumnComboBox cmbStatus;
        private System.Windows.Forms.ErrorProvider errItem;
        private System.Data.DataColumn fldBoolName;
        private System.Data.DataColumn fldBoolValue;
        private System.Windows.Forms.ComboBox cmbConsignm;
        private System.Windows.Forms.ComboBox cmbWeighted;
        private System.Windows.Forms.Button btnSearch;
    }
}