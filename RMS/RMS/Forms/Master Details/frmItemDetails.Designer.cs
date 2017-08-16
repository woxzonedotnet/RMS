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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvLocationData = new System.Windows.Forms.DataGridView();
            this.clmLocationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmShelfQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDamageQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonthOpenQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPackageSize = new System.Windows.Forms.TextBox();
            this.txtMinimumGP = new System.Windows.Forms.TextBox();
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
            this.lblWeighted = new System.Windows.Forms.Label();
            this.lblConsignm = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.errItem = new System.Windows.Forms.ErrorProvider(this.components);
            this.fldBoolName = new System.Data.DataColumn();
            this.fldBoolValue = new System.Data.DataColumn();
            this.cmbConsignm = new System.Windows.Forms.ComboBox();
            this.cmbWeighted = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbStatus = new RMS.ColumnComboBox();
            this.cmbUnit = new RMS.ColumnComboBox();
            this.cmbSupplier = new RMS.ColumnComboBox();
            this.cmbMenuCategory = new RMS.ColumnComboBox();
            this.cmbCategory = new RMS.ColumnComboBox();
            this.cmbDepartment = new RMS.ColumnComboBox();
            this.cmbCapacity = new RMS.ColumnComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocationData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errItem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(595, 475);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 92;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(514, 475);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 91;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(433, 475);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 90;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(352, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 89;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(95, 76);
            this.txtMax.Name = "txtMax";
            this.txtMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMax.Size = new System.Drawing.Size(75, 20);
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
            this.txtROQ.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtROQ.Size = new System.Drawing.Size(75, 20);
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
            this.txtROL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtROL.Size = new System.Drawing.Size(75, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(486, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 106);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price";
            // 
            // txtSelling
            // 
            this.txtSelling.Location = new System.Drawing.Point(95, 76);
            this.txtSelling.Name = "txtSelling";
            this.txtSelling.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSelling.Size = new System.Drawing.Size(75, 20);
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
            this.txtWholeSale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWholeSale.Size = new System.Drawing.Size(75, 20);
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
            this.txtCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCost.Size = new System.Drawing.Size(75, 20);
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
            this.groupBox2.Location = new System.Drawing.Point(486, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 106);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Re Oder";
            // 
            // dgvLocationData
            // 
            this.dgvLocationData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocationData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmLocationCode,
            this.clmLocationName,
            this.clmShelfQty,
            this.clmDamageQty,
            this.clmMonthOpenQty});
            this.dgvLocationData.Location = new System.Drawing.Point(8, 313);
            this.dgvLocationData.Name = "dgvLocationData";
            this.dgvLocationData.Size = new System.Drawing.Size(662, 150);
            this.dgvLocationData.TabIndex = 80;
            this.dgvLocationData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // clmLocationCode
            // 
            this.clmLocationCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmLocationCode.FillWeight = 43.13193F;
            this.clmLocationCode.HeaderText = "Location Code";
            this.clmLocationCode.Name = "clmLocationCode";
            this.clmLocationCode.ReadOnly = true;
            // 
            // clmLocationName
            // 
            this.clmLocationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmLocationName.FillWeight = 142.5132F;
            this.clmLocationName.HeaderText = "Location Name";
            this.clmLocationName.Name = "clmLocationName";
            this.clmLocationName.ReadOnly = true;
            // 
            // clmShelfQty
            // 
            this.clmShelfQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.clmShelfQty.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmShelfQty.FillWeight = 84.71056F;
            this.clmShelfQty.HeaderText = "Shelf Quantity";
            this.clmShelfQty.Name = "clmShelfQty";
            this.clmShelfQty.ReadOnly = true;
            // 
            // clmDamageQty
            // 
            this.clmDamageQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.clmDamageQty.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmDamageQty.FillWeight = 102.7407F;
            this.clmDamageQty.HeaderText = "Damage Quantity";
            this.clmDamageQty.Name = "clmDamageQty";
            this.clmDamageQty.ReadOnly = true;
            // 
            // clmMonthOpenQty
            // 
            this.clmMonthOpenQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.clmMonthOpenQty.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmMonthOpenQty.FillWeight = 126.9036F;
            this.clmMonthOpenQty.HeaderText = "Month Open Quantity";
            this.clmMonthOpenQty.Name = "clmMonthOpenQty";
            this.clmMonthOpenQty.ReadOnly = true;
            // 
            // txtPackageSize
            // 
            this.txtPackageSize.Location = new System.Drawing.Point(380, 182);
            this.txtPackageSize.Name = "txtPackageSize";
            this.txtPackageSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPackageSize.Size = new System.Drawing.Size(90, 20);
            this.txtPackageSize.TabIndex = 75;
            // 
            // txtMinimumGP
            // 
            this.txtMinimumGP.Location = new System.Drawing.Point(103, 247);
            this.txtMinimumGP.Name = "txtMinimumGP";
            this.txtMinimumGP.Size = new System.Drawing.Size(157, 20);
            this.txtMinimumGP.TabIndex = 74;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(286, 56);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(184, 82);
            this.txtDescription.TabIndex = 65;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(103, 86);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(157, 20);
            this.txtBarCode.TabIndex = 64;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(103, 56);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(116, 20);
            this.txtItemCode.TabIndex = 63;
            // 
            // lblPackageSize
            // 
            this.lblPackageSize.AutoSize = true;
            this.lblPackageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblPackageSize.Location = new System.Drawing.Point(283, 183);
            this.lblPackageSize.Name = "lblPackageSize";
            this.lblPackageSize.Size = new System.Drawing.Size(68, 16);
            this.lblPackageSize.TabIndex = 62;
            this.lblPackageSize.Text = "Pack Size";
            // 
            // lblCapacityML
            // 
            this.lblCapacityML.AutoSize = true;
            this.lblCapacityML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCapacityML.Location = new System.Drawing.Point(6, 279);
            this.lblCapacityML.Name = "lblCapacityML";
            this.lblCapacityML.Size = new System.Drawing.Size(61, 16);
            this.lblCapacityML.TabIndex = 61;
            this.lblCapacityML.Text = "Capacity";
            // 
            // lblMinimumGP
            // 
            this.lblMinimumGP.AutoSize = true;
            this.lblMinimumGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblMinimumGP.Location = new System.Drawing.Point(6, 248);
            this.lblMinimumGP.Name = "lblMinimumGP";
            this.lblMinimumGP.Size = new System.Drawing.Size(83, 16);
            this.lblMinimumGP.TabIndex = 60;
            this.lblMinimumGP.Text = "Minimum GP";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSupplier.Location = new System.Drawing.Point(5, 214);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(58, 16);
            this.lblSupplier.TabIndex = 59;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblMCategory
            // 
            this.lblMCategory.AutoSize = true;
            this.lblMCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblMCategory.Location = new System.Drawing.Point(6, 182);
            this.lblMCategory.Name = "lblMCategory";
            this.lblMCategory.Size = new System.Drawing.Size(80, 16);
            this.lblMCategory.TabIndex = 58;
            this.lblMCategory.Text = "M. Category";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCategory.Location = new System.Drawing.Point(6, 150);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(63, 16);
            this.lblCategory.TabIndex = 56;
            this.lblCategory.Text = "Category";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDepartment.Location = new System.Drawing.Point(5, 118);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(78, 16);
            this.lblDepartment.TabIndex = 55;
            this.lblDepartment.Text = "Department";
            // 
            // lblWeighted
            // 
            this.lblWeighted.AutoSize = true;
            this.lblWeighted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblWeighted.Location = new System.Drawing.Point(283, 150);
            this.lblWeighted.Name = "lblWeighted";
            this.lblWeighted.Size = new System.Drawing.Size(66, 16);
            this.lblWeighted.TabIndex = 53;
            this.lblWeighted.Text = "Weighted";
            // 
            // lblConsignm
            // 
            this.lblConsignm.AutoSize = true;
            this.lblConsignm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblConsignm.Location = new System.Drawing.Point(282, 215);
            this.lblConsignm.Name = "lblConsignm";
            this.lblConsignm.Size = new System.Drawing.Size(68, 16);
            this.lblConsignm.TabIndex = 52;
            this.lblConsignm.Text = "Consignm";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDescription.Location = new System.Drawing.Point(283, 37);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 16);
            this.lblDescription.TabIndex = 51;
            this.lblDescription.Text = "Description";
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblBarCode.Location = new System.Drawing.Point(5, 87);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(65, 16);
            this.lblBarCode.TabIndex = 50;
            this.lblBarCode.Text = "Bar Code";
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblItemCode.Location = new System.Drawing.Point(5, 57);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(69, 16);
            this.lblItemCode.TabIndex = 49;
            this.lblItemCode.Text = "Item Code";
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
            this.cmbConsignm.Location = new System.Drawing.Point(380, 214);
            this.cmbConsignm.Name = "cmbConsignm";
            this.cmbConsignm.Size = new System.Drawing.Size(90, 21);
            this.cmbConsignm.TabIndex = 96;
            // 
            // cmbWeighted
            // 
            this.cmbWeighted.FormattingEnabled = true;
            this.cmbWeighted.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbWeighted.Location = new System.Drawing.Point(380, 149);
            this.cmbWeighted.Name = "cmbWeighted";
            this.cmbWeighted.Size = new System.Drawing.Size(90, 21);
            this.cmbWeighted.TabIndex = 96;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::RMS.Properties.Resources.search25;
            this.btnSearch.Location = new System.Drawing.Point(225, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 97;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 31);
            this.panel1.TabIndex = 98;
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
            this.lblTitle.Size = new System.Drawing.Size(78, 16);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Item Details";
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
            this.btnExit.Location = new System.Drawing.Point(642, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 99;
            this.label1.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel2.Location = new System.Drawing.Point(678, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 495);
            this.panel2.TabIndex = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel3.Location = new System.Drawing.Point(-9, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 502);
            this.panel3.TabIndex = 101;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel4.Location = new System.Drawing.Point(0, 524);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(679, 10);
            this.panel4.TabIndex = 101;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbStatus.DropDownWidth = 17;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(380, 248);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(90, 21);
            this.cmbStatus.TabIndex = 94;
            this.cmbStatus.ViewColumn = 0;
            // 
            // cmbUnit
            // 
            this.cmbUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbUnit.DropDownWidth = 17;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(208, 278);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(53, 21);
            this.cmbUnit.TabIndex = 93;
            this.cmbUnit.ViewColumn = 0;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSupplier.DropDownWidth = 17;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(103, 213);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(157, 21);
            this.cmbSupplier.TabIndex = 76;
            this.cmbSupplier.ViewColumn = 0;
            // 
            // cmbMenuCategory
            // 
            this.cmbMenuCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMenuCategory.DropDownWidth = 17;
            this.cmbMenuCategory.FormattingEnabled = true;
            this.cmbMenuCategory.Location = new System.Drawing.Point(103, 181);
            this.cmbMenuCategory.Name = "cmbMenuCategory";
            this.cmbMenuCategory.Size = new System.Drawing.Size(157, 21);
            this.cmbMenuCategory.TabIndex = 73;
            this.cmbMenuCategory.ViewColumn = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategory.DropDownWidth = 17;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(103, 149);
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
            this.cmbDepartment.Location = new System.Drawing.Point(103, 117);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(157, 21);
            this.cmbDepartment.TabIndex = 70;
            this.cmbDepartment.ViewColumn = 0;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbCapacity
            // 
            this.cmbCapacity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCapacity.DropDownWidth = 17;
            this.cmbCapacity.FormattingEnabled = true;
            this.cmbCapacity.Location = new System.Drawing.Point(103, 278);
            this.cmbCapacity.Name = "cmbCapacity";
            this.cmbCapacity.Size = new System.Drawing.Size(99, 21);
            this.cmbCapacity.TabIndex = 102;
            this.cmbCapacity.ViewColumn = 0;
            // 
            // frmItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(679, 525);
            this.Controls.Add(this.cmbCapacity);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbWeighted);
            this.Controls.Add(this.cmbConsignm);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvLocationData);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.txtPackageSize);
            this.Controls.Add(this.txtMinimumGP);
            this.Controls.Add(this.cmbMenuCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbDepartment);
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
            this.Controls.Add(this.lblWeighted);
            this.Controls.Add(this.lblConsignm);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblBarCode);
            this.Controls.Add(this.lblItemCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItemDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Details";
            this.Load += new System.EventHandler(this.frmItemDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocationData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvLocationData;
        private ColumnComboBox cmbSupplier;
        private System.Windows.Forms.TextBox txtPackageSize;
        private System.Windows.Forms.TextBox txtMinimumGP;
        private ColumnComboBox cmbMenuCategory;
        private ColumnComboBox cmbCategory;
        private ColumnComboBox cmbDepartment;
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
        private System.Windows.Forms.Label lblWeighted;
        private System.Windows.Forms.Label lblConsignm;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.Label lblItemCode;
        private ColumnComboBox cmbUnit;
        private ColumnComboBox cmbStatus;
        private System.Windows.Forms.ErrorProvider errItem;
        private System.Data.DataColumn fldBoolName;
        private System.Data.DataColumn fldBoolValue;
        private System.Windows.Forms.ComboBox cmbConsignm;
        private System.Windows.Forms.ComboBox cmbWeighted;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmShelfQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDamageQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonthOpenQty;
        private ColumnComboBox cmbCapacity;
    }
}