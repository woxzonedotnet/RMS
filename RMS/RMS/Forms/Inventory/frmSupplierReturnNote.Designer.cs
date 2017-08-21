namespace RMS.Forms.Inventory
{
    partial class frmSupplierReturnNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierReturnNote));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvItemData = new System.Windows.Forms.DataGridView();
            this.clmSelectItem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTax_chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVatPrecentage = new System.Windows.Forms.TextBox();
            this.chkVat = new System.Windows.Forms.CheckBox();
            this.lblVATAmount = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtVatAmount = new System.Windows.Forms.TextBox();
            this.txtSRNValue = new System.Windows.Forms.TextBox();
            this.lblSRNValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkGRNNumber = new System.Windows.Forms.CheckBox();
            this.txtGRNNumber = new System.Windows.Forms.TextBox();
            this.btnGRNSesrch = new System.Windows.Forms.Button();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtSRNNumber = new System.Windows.Forms.TextBox();
            this.btnSRNSearch = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblSRNNumber = new System.Windows.Forms.Label();
            this.errSRN = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbSupplier = new RMS.ColumnComboBox();
            this.cmbLocation = new RMS.ColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSRN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(557, 454);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 80;
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
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(476, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 79;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Location = new System.Drawing.Point(395, 454);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 36);
            this.btnPrint.TabIndex = 78;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(314, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 77;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvItemData
            // 
            this.dgvItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSelectItem,
            this.clmItemCode,
            this.clmItemDescription,
            this.clmUnit,
            this.clmUnitPrice,
            this.clmQuantity,
            this.clmValue,
            this.clmTax_chk,
            this.clmTaxAmount,
            this.clmTotalAmount});
            this.dgvItemData.Location = new System.Drawing.Point(12, 12);
            this.dgvItemData.Name = "dgvItemData";
            this.dgvItemData.Size = new System.Drawing.Size(631, 432);
            this.dgvItemData.TabIndex = 81;
            this.dgvItemData.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemData_CellValidated);
            this.dgvItemData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemData_CellValueChanged);
            this.dgvItemData.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvItemData_CurrentCellDirtyStateChanged);
            this.dgvItemData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItemData_KeyDown);
            // 
            // clmSelectItem
            // 
            this.clmSelectItem.HeaderText = "";
            this.clmSelectItem.Name = "clmSelectItem";
            this.clmSelectItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmSelectItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmSelectItem.Visible = false;
            this.clmSelectItem.Width = 20;
            // 
            // clmItemCode
            // 
            this.clmItemCode.HeaderText = "Item Code";
            this.clmItemCode.Name = "clmItemCode";
            this.clmItemCode.ReadOnly = true;
            this.clmItemCode.Width = 70;
            // 
            // clmItemDescription
            // 
            this.clmItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmItemDescription.HeaderText = "Description";
            this.clmItemDescription.Name = "clmItemDescription";
            this.clmItemDescription.ReadOnly = true;
            // 
            // clmUnit
            // 
            this.clmUnit.HeaderText = "Unit";
            this.clmUnit.Name = "clmUnit";
            this.clmUnit.ReadOnly = true;
            this.clmUnit.Width = 60;
            // 
            // clmUnitPrice
            // 
            this.clmUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmUnitPrice.HeaderText = "UnitPrice";
            this.clmUnitPrice.Name = "clmUnitPrice";
            this.clmUnitPrice.ReadOnly = true;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Qty";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.Width = 60;
            // 
            // clmValue
            // 
            this.clmValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmValue.HeaderText = "Value";
            this.clmValue.Name = "clmValue";
            this.clmValue.ReadOnly = true;
            // 
            // clmTax_chk
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.NullValue = false;
            this.clmTax_chk.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmTax_chk.HeaderText = "Tax";
            this.clmTax_chk.Name = "clmTax_chk";
            this.clmTax_chk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmTax_chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmTax_chk.Width = 40;
            // 
            // clmTaxAmount
            // 
            this.clmTaxAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTaxAmount.HeaderText = "Tax Amount";
            this.clmTaxAmount.Name = "clmTaxAmount";
            this.clmTaxAmount.ReadOnly = true;
            // 
            // clmTotalAmount
            // 
            this.clmTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTotalAmount.HeaderText = "Total Amount";
            this.clmTotalAmount.Name = "clmTotalAmount";
            this.clmTotalAmount.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtVatPrecentage);
            this.panel2.Controls.Add(this.chkVat);
            this.panel2.Controls.Add(this.lblVATAmount);
            this.panel2.Controls.Add(this.txtNetAmount);
            this.panel2.Controls.Add(this.lblNetAmount);
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.lblDiscount);
            this.panel2.Controls.Add(this.txtVatAmount);
            this.panel2.Controls.Add(this.txtSRNValue);
            this.panel2.Controls.Add(this.lblSRNValue);
            this.panel2.Location = new System.Drawing.Point(649, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 190);
            this.panel2.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(267, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "%";
            // 
            // txtVatPrecentage
            // 
            this.txtVatPrecentage.Enabled = false;
            this.txtVatPrecentage.Location = new System.Drawing.Point(154, 47);
            this.txtVatPrecentage.Name = "txtVatPrecentage";
            this.txtVatPrecentage.Size = new System.Drawing.Size(111, 20);
            this.txtVatPrecentage.TabIndex = 71;
            this.txtVatPrecentage.Text = "0.00";
            this.txtVatPrecentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVatPrecentage.TextChanged += new System.EventHandler(this.txtVatPrecentage_TextChanged);
            // 
            // chkVat
            // 
            this.chkVat.AutoSize = true;
            this.chkVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.chkVat.Location = new System.Drawing.Point(28, 46);
            this.chkVat.Name = "chkVat";
            this.chkVat.Size = new System.Drawing.Size(54, 20);
            this.chkVat.TabIndex = 70;
            this.chkVat.Text = "VAT";
            this.chkVat.UseVisualStyleBackColor = true;
            this.chkVat.CheckedChanged += new System.EventHandler(this.chkVat_CheckedChanged);
            // 
            // lblVATAmount
            // 
            this.lblVATAmount.AutoSize = true;
            this.lblVATAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblVATAmount.Location = new System.Drawing.Point(27, 82);
            this.lblVATAmount.Name = "lblVATAmount";
            this.lblVATAmount.Size = new System.Drawing.Size(83, 16);
            this.lblVATAmount.TabIndex = 70;
            this.lblVATAmount.Text = "VAT Amount";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Location = new System.Drawing.Point(154, 152);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(129, 20);
            this.txtNetAmount.TabIndex = 69;
            this.txtNetAmount.Text = "0.00";
            this.txtNetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblNetAmount.Location = new System.Drawing.Point(27, 154);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(87, 16);
            this.lblNetAmount.TabIndex = 68;
            this.lblNetAmount.Text = "Net Amount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(154, 117);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(129, 20);
            this.txtDiscount.TabIndex = 67;
            this.txtDiscount.Text = "0.00";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDiscount.Location = new System.Drawing.Point(27, 118);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(60, 16);
            this.lblDiscount.TabIndex = 66;
            this.lblDiscount.Text = "Discount";
            // 
            // txtVatAmount
            // 
            this.txtVatAmount.Location = new System.Drawing.Point(154, 82);
            this.txtVatAmount.Name = "txtVatAmount";
            this.txtVatAmount.Size = new System.Drawing.Size(129, 20);
            this.txtVatAmount.TabIndex = 65;
            this.txtVatAmount.Text = "0.00";
            this.txtVatAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSRNValue
            // 
            this.txtSRNValue.Location = new System.Drawing.Point(154, 12);
            this.txtSRNValue.Name = "txtSRNValue";
            this.txtSRNValue.Size = new System.Drawing.Size(129, 20);
            this.txtSRNValue.TabIndex = 63;
            this.txtSRNValue.Text = "0.00";
            this.txtSRNValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSRNValue
            // 
            this.lblSRNValue.AutoSize = true;
            this.lblSRNValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSRNValue.Location = new System.Drawing.Point(27, 13);
            this.lblSRNValue.Name = "lblSRNValue";
            this.lblSRNValue.Size = new System.Drawing.Size(75, 16);
            this.lblSRNValue.TabIndex = 62;
            this.lblSRNValue.Text = "SRN Value";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkGRNNumber);
            this.panel1.Controls.Add(this.txtGRNNumber);
            this.panel1.Controls.Add(this.btnGRNSesrch);
            this.panel1.Controls.Add(this.txtInvoiceNo);
            this.panel1.Controls.Add(this.lblInvoiceNo);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.cmbSupplier);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.cmbLocation);
            this.panel1.Controls.Add(this.txtSRNNumber);
            this.panel1.Controls.Add(this.btnSRNSearch);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.lblSRNNumber);
            this.panel1.Location = new System.Drawing.Point(649, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 236);
            this.panel1.TabIndex = 82;
            // 
            // chkGRNNumber
            // 
            this.chkGRNNumber.AutoSize = true;
            this.chkGRNNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.chkGRNNumber.Location = new System.Drawing.Point(18, 55);
            this.chkGRNNumber.Name = "chkGRNNumber";
            this.chkGRNNumber.Size = new System.Drawing.Size(108, 20);
            this.chkGRNNumber.TabIndex = 73;
            this.chkGRNNumber.Text = "GRN Number";
            this.chkGRNNumber.UseVisualStyleBackColor = true;
            this.chkGRNNumber.CheckedChanged += new System.EventHandler(this.chkGRNNumber_CheckedChanged);
            // 
            // txtGRNNumber
            // 
            this.txtGRNNumber.Enabled = false;
            this.txtGRNNumber.Location = new System.Drawing.Point(121, 55);
            this.txtGRNNumber.Name = "txtGRNNumber";
            this.txtGRNNumber.ReadOnly = true;
            this.txtGRNNumber.Size = new System.Drawing.Size(144, 20);
            this.txtGRNNumber.TabIndex = 71;
            // 
            // btnGRNSesrch
            // 
            this.btnGRNSesrch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnGRNSesrch.Enabled = false;
            this.btnGRNSesrch.FlatAppearance.BorderSize = 0;
            this.btnGRNSesrch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnGRNSesrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGRNSesrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGRNSesrch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGRNSesrch.Image = global::RMS.Properties.Resources.search25;
            this.btnGRNSesrch.Location = new System.Drawing.Point(271, 52);
            this.btnGRNSesrch.Name = "btnGRNSesrch";
            this.btnGRNSesrch.Size = new System.Drawing.Size(35, 31);
            this.btnGRNSesrch.TabIndex = 70;
            this.btnGRNSesrch.UseVisualStyleBackColor = false;
            this.btnGRNSesrch.Click += new System.EventHandler(this.btnGRNSesrch_Click);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.Location = new System.Drawing.Point(121, 167);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(185, 20);
            this.txtInvoiceNo.TabIndex = 68;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblInvoiceNo.Location = new System.Drawing.Point(15, 168);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(72, 16);
            this.lblInvoiceNo.TabIndex = 67;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(121, 205);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(185, 20);
            this.dtpDate.TabIndex = 66;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDate.Location = new System.Drawing.Point(15, 209);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 16);
            this.lblDate.TabIndex = 65;
            this.lblDate.Text = "Date";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSupplier.Location = new System.Drawing.Point(15, 129);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(58, 16);
            this.lblSupplier.TabIndex = 63;
            this.lblSupplier.Text = "Supplier";
            // 
            // txtSRNNumber
            // 
            this.txtSRNNumber.Location = new System.Drawing.Point(121, 19);
            this.txtSRNNumber.Name = "txtSRNNumber";
            this.txtSRNNumber.ReadOnly = true;
            this.txtSRNNumber.Size = new System.Drawing.Size(142, 20);
            this.txtSRNNumber.TabIndex = 61;
            // 
            // btnSRNSearch
            // 
            this.btnSRNSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSRNSearch.FlatAppearance.BorderSize = 0;
            this.btnSRNSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSRNSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSRNSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSRNSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSRNSearch.Image = global::RMS.Properties.Resources.search25;
            this.btnSRNSearch.Location = new System.Drawing.Point(271, 14);
            this.btnSRNSearch.Name = "btnSRNSearch";
            this.btnSRNSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSRNSearch.TabIndex = 60;
            this.btnSRNSearch.UseVisualStyleBackColor = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblLocation.Location = new System.Drawing.Point(15, 92);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(59, 16);
            this.lblLocation.TabIndex = 59;
            this.lblLocation.Text = "Location";
            // 
            // lblSRNNumber
            // 
            this.lblSRNNumber.AutoSize = true;
            this.lblSRNNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSRNNumber.Location = new System.Drawing.Point(15, 22);
            this.lblSRNNumber.Name = "lblSRNNumber";
            this.lblSRNNumber.Size = new System.Drawing.Size(88, 16);
            this.lblSRNNumber.TabIndex = 58;
            this.lblSRNNumber.Text = "SRN Number";
            // 
            // errSRN
            // 
            this.errSRN.ContainerControl = this;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSupplier.DropDownWidth = 17;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(121, 128);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(185, 21);
            this.cmbSupplier.TabIndex = 64;
            this.cmbSupplier.ViewColumn = 0;
            // 
            // cmbLocation
            // 
            this.cmbLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLocation.DropDownWidth = 17;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(121, 91);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(185, 21);
            this.cmbLocation.TabIndex = 62;
            this.cmbLocation.ViewColumn = 0;
            // 
            // frmSupplierReturnNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvItemData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Name = "frmSupplierReturnNote";
            this.Text = "Supplier Return Note (SRN)";
            this.Load += new System.EventHandler(this.frmSupplierReturnNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSRN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvItemData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVatPrecentage;
        private System.Windows.Forms.CheckBox chkVat;
        private System.Windows.Forms.Label lblVATAmount;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtVatAmount;
        private System.Windows.Forms.TextBox txtSRNValue;
        private System.Windows.Forms.Label lblSRNValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkGRNNumber;
        private System.Windows.Forms.TextBox txtGRNNumber;
        private System.Windows.Forms.Button btnGRNSesrch;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private ColumnComboBox cmbSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private ColumnComboBox cmbLocation;
        private System.Windows.Forms.TextBox txtSRNNumber;
        private System.Windows.Forms.Button btnSRNSearch;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblSRNNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelectItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmTax_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalAmount;
        private System.Windows.Forms.ErrorProvider errSRN;
    }
}