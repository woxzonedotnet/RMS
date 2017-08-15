namespace RMS.Forms.Inventory
{
    partial class frmGoodsReceiveNote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoodsReceiveNote));
            this.dgvItemData = new System.Windows.Forms.DataGridView();
            this.clmSelectItem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTax_chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkVat = new System.Windows.Forms.CheckBox();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtVatAmount = new System.Windows.Forms.TextBox();
            this.txtGRNValue = new System.Windows.Forms.TextBox();
            this.lblGRNValue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVatPrecentage = new System.Windows.Forms.TextBox();
            this.lblVATAmount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtGRNNumber = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblGRNNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkPONumber = new System.Windows.Forms.CheckBox();
            this.txtPONumber = new System.Windows.Forms.TextBox();
            this.btnPOSesrch = new System.Windows.Forms.Button();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errGRN = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmbSupplier = new RMS.ColumnComboBox();
            this.cmbLocation = new RMS.ColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errGRN)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItemData
            // 
            this.dgvItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSelectItem,
            this.clmItemCode,
            this.clmItemDescription,
            this.clmUnit,
            this.clmOrderQuantity,
            this.clmUnitPrice,
            this.clmQuantity,
            this.clmValue,
            this.clmTax_chk,
            this.clmTaxAmount,
            this.clmTotalAmount});
            this.dgvItemData.Location = new System.Drawing.Point(9, 40);
            this.dgvItemData.Name = "dgvItemData";
            this.dgvItemData.Size = new System.Drawing.Size(631, 474);
            this.dgvItemData.TabIndex = 0;
            this.dgvItemData.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemData_CellValidated);
            this.dgvItemData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemData_CellValueChanged);
            this.dgvItemData.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvItemData_CurrentCellDirtyStateChanged);
            this.dgvItemData.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvItemData_RowsRemoved);
            this.dgvItemData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
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
            // clmOrderQuantity
            // 
            this.clmOrderQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmOrderQuantity.HeaderText = "Order Qty";
            this.clmOrderQuantity.Name = "clmOrderQuantity";
            this.clmOrderQuantity.ReadOnly = true;
            this.clmOrderQuantity.Visible = false;
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
            // 
            // clmTax_chk
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.NullValue = false;
            this.clmTax_chk.DefaultCellStyle = dataGridViewCellStyle2;
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
            // 
            // clmTotalAmount
            // 
            this.clmTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTotalAmount.HeaderText = "Total Amount";
            this.clmTotalAmount.Name = "clmTotalAmount";
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
            // txtGRNValue
            // 
            this.txtGRNValue.Location = new System.Drawing.Point(154, 12);
            this.txtGRNValue.Name = "txtGRNValue";
            this.txtGRNValue.Size = new System.Drawing.Size(129, 20);
            this.txtGRNValue.TabIndex = 63;
            this.txtGRNValue.Text = "0.00";
            this.txtGRNValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGRNValue
            // 
            this.lblGRNValue.AutoSize = true;
            this.lblGRNValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblGRNValue.Location = new System.Drawing.Point(27, 13);
            this.lblGRNValue.Name = "lblGRNValue";
            this.lblGRNValue.Size = new System.Drawing.Size(76, 16);
            this.lblGRNValue.TabIndex = 62;
            this.lblGRNValue.Text = "GRN Value";
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
            this.panel2.Controls.Add(this.txtGRNValue);
            this.panel2.Controls.Add(this.lblGRNValue);
            this.panel2.Location = new System.Drawing.Point(646, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 190);
            this.panel2.TabIndex = 74;
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(888, 478);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 73;
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
            this.btnClear.Location = new System.Drawing.Point(807, 478);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 72;
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
            this.btnPrint.Location = new System.Drawing.Point(726, 478);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 36);
            this.btnPrint.TabIndex = 71;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(121, 165);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(185, 20);
            this.dtpDate.TabIndex = 66;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDate.Location = new System.Drawing.Point(15, 169);
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
            // txtGRNNumber
            // 
            this.txtGRNNumber.Location = new System.Drawing.Point(121, 19);
            this.txtGRNNumber.Name = "txtGRNNumber";
            this.txtGRNNumber.ReadOnly = true;
            this.txtGRNNumber.Size = new System.Drawing.Size(142, 20);
            this.txtGRNNumber.TabIndex = 61;
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
            // lblGRNNumber
            // 
            this.lblGRNNumber.AutoSize = true;
            this.lblGRNNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblGRNNumber.Location = new System.Drawing.Point(15, 22);
            this.lblGRNNumber.Name = "lblGRNNumber";
            this.lblGRNNumber.Size = new System.Drawing.Size(89, 16);
            this.lblGRNNumber.TabIndex = 58;
            this.lblGRNNumber.Text = "GRN Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkPONumber);
            this.panel1.Controls.Add(this.txtPONumber);
            this.panel1.Controls.Add(this.btnPOSesrch);
            this.panel1.Controls.Add(this.txtInvoiceNo);
            this.panel1.Controls.Add(this.lblInvoiceNo);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.cmbSupplier);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.cmbLocation);
            this.panel1.Controls.Add(this.txtGRNNumber);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.lblGRNNumber);
            this.panel1.Location = new System.Drawing.Point(646, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 236);
            this.panel1.TabIndex = 69;
            // 
            // chkPONumber
            // 
            this.chkPONumber.AutoSize = true;
            this.chkPONumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.chkPONumber.Location = new System.Drawing.Point(18, 55);
            this.chkPONumber.Name = "chkPONumber";
            this.chkPONumber.Size = new System.Drawing.Size(97, 20);
            this.chkPONumber.TabIndex = 73;
            this.chkPONumber.Text = "PO Number";
            this.chkPONumber.UseVisualStyleBackColor = true;
            this.chkPONumber.CheckedChanged += new System.EventHandler(this.chkPONumber_CheckedChanged);
            // 
            // txtPONumber
            // 
            this.txtPONumber.Enabled = false;
            this.txtPONumber.Location = new System.Drawing.Point(121, 55);
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.ReadOnly = true;
            this.txtPONumber.Size = new System.Drawing.Size(144, 20);
            this.txtPONumber.TabIndex = 71;
            // 
            // btnPOSesrch
            // 
            this.btnPOSesrch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnPOSesrch.Enabled = false;
            this.btnPOSesrch.FlatAppearance.BorderSize = 0;
            this.btnPOSesrch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnPOSesrch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOSesrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOSesrch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPOSesrch.Image = global::RMS.Properties.Resources.search25;
            this.btnPOSesrch.Location = new System.Drawing.Point(271, 52);
            this.btnPOSesrch.Name = "btnPOSesrch";
            this.btnPOSesrch.Size = new System.Drawing.Size(35, 31);
            this.btnPOSesrch.TabIndex = 70;
            this.btnPOSesrch.UseVisualStyleBackColor = false;
            this.btnPOSesrch.Click += new System.EventHandler(this.btnPOSesrch_Click);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(121, 201);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(185, 20);
            this.txtInvoiceNo.TabIndex = 68;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblInvoiceNo.Location = new System.Drawing.Point(15, 202);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(72, 16);
            this.lblInvoiceNo.TabIndex = 67;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Image = global::RMS.Properties.Resources.search25;
            this.btnSearch.Location = new System.Drawing.Point(271, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(645, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 70;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errGRN
            // 
            this.errGRN.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 31);
            this.panel3.TabIndex = 75;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(13, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 16);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Goods Receive Note [ GRN ]";
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
            this.btnExit.Location = new System.Drawing.Point(936, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel4.Location = new System.Drawing.Point(972, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 497);
            this.panel4.TabIndex = 76;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel5.Location = new System.Drawing.Point(-9, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 497);
            this.panel5.TabIndex = 77;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel6.Location = new System.Drawing.Point(0, 519);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(973, 10);
            this.panel6.TabIndex = 77;
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
            // frmGoodsReceiveNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 520);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvItemData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGoodsReceiveNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods Receive Note (GRN)";
            this.Activated += new System.EventHandler(this.frmGoodsReceiveNote_Activated);
            this.Deactivate += new System.EventHandler(this.frmGoodsReceiveNote_Deactivate);
            this.Load += new System.EventHandler(this.frmGoodsReceiveNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errGRN)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ColumnComboBox cmbLocation;
        private System.Windows.Forms.DataGridView dgvItemData;
        private System.Windows.Forms.CheckBox chkVat;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtVatAmount;
        private System.Windows.Forms.TextBox txtGRNValue;
        private System.Windows.Forms.Label lblGRNValue;
        private ColumnComboBox cmbSupplier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtGRNNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblGRNNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVatPrecentage;
        private System.Windows.Forms.Label lblVATAmount;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.ErrorProvider errGRN;
        private System.Windows.Forms.TextBox txtPONumber;
        private System.Windows.Forms.Button btnPOSesrch;
        private System.Windows.Forms.CheckBox chkPONumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelectItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValue;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmTax_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalAmount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
    }
}