namespace RMS.Forms.Inventory
{
    partial class frmPurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtPONumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblPONumber = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkVat = new System.Windows.Forms.CheckBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvItemData = new System.Windows.Forms.DataGridView();
            this.errPO = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbSupplier = new RMS.ColumnComboBox();
            this.cmbLocation = new RMS.ColumnComboBox();
            this.clmItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTax_chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPO)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.cmbSupplier);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.cmbLocation);
            this.panel1.Controls.Add(this.txtPONumber);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.lblPONumber);
            this.panel1.Location = new System.Drawing.Point(693, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 165);
            this.panel1.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(101, 129);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(120, 20);
            this.dtpDate.TabIndex = 66;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDate.Location = new System.Drawing.Point(15, 133);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 16);
            this.lblDate.TabIndex = 65;
            this.lblDate.Text = "Date";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSupplier.Location = new System.Drawing.Point(15, 94);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(58, 16);
            this.lblSupplier.TabIndex = 63;
            this.lblSupplier.Text = "Supplier";
            // 
            // txtPONumber
            // 
            this.txtPONumber.Location = new System.Drawing.Point(101, 19);
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.Size = new System.Drawing.Size(120, 20);
            this.txtPONumber.TabIndex = 61;
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
            this.btnSearch.Location = new System.Drawing.Point(231, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblLocation.Location = new System.Drawing.Point(15, 56);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(59, 16);
            this.lblLocation.TabIndex = 59;
            this.lblLocation.Text = "Location";
            // 
            // lblPONumber
            // 
            this.lblPONumber.AutoSize = true;
            this.lblPONumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblPONumber.Location = new System.Drawing.Point(15, 20);
            this.lblPONumber.Name = "lblPONumber";
            this.lblPONumber.Size = new System.Drawing.Size(78, 16);
            this.lblPONumber.TabIndex = 58;
            this.lblPONumber.Text = "PO Number";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(900, 362);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 66;
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
            this.btnClear.Location = new System.Drawing.Point(819, 362);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 65;
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
            this.btnPrint.Location = new System.Drawing.Point(738, 362);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 36);
            this.btnPrint.TabIndex = 64;
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
            this.btnSave.Location = new System.Drawing.Point(657, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chkVat);
            this.panel2.Controls.Add(this.txtRemark);
            this.panel2.Controls.Add(this.lblRemark);
            this.panel2.Controls.Add(this.txtNetAmount);
            this.panel2.Controls.Add(this.lblNetAmount);
            this.panel2.Controls.Add(this.txtVat);
            this.panel2.Controls.Add(this.txtPurchase);
            this.panel2.Controls.Add(this.lblPurchase);
            this.panel2.Location = new System.Drawing.Point(693, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 154);
            this.panel2.TabIndex = 67;
            // 
            // chkVat
            // 
            this.chkVat.AutoSize = true;
            this.chkVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.chkVat.Location = new System.Drawing.Point(20, 47);
            this.chkVat.Name = "chkVat";
            this.chkVat.Size = new System.Drawing.Size(54, 20);
            this.chkVat.TabIndex = 70;
            this.chkVat.Text = "VAT";
            this.chkVat.UseVisualStyleBackColor = true;
            this.chkVat.CheckedChanged += new System.EventHandler(this.chkVat_CheckedChanged);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(109, 119);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(157, 20);
            this.txtRemark.TabIndex = 69;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblRemark.Location = new System.Drawing.Point(17, 120);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(63, 16);
            this.lblRemark.TabIndex = 68;
            this.lblRemark.Text = "Remarks";
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Location = new System.Drawing.Point(109, 83);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.Size = new System.Drawing.Size(157, 20);
            this.txtNetAmount.TabIndex = 67;
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblNetAmount.Location = new System.Drawing.Point(17, 84);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(87, 16);
            this.lblNetAmount.TabIndex = 66;
            this.lblNetAmount.Text = "Net Amount";
            // 
            // txtVat
            // 
            this.txtVat.Enabled = false;
            this.txtVat.Location = new System.Drawing.Point(109, 47);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(157, 20);
            this.txtVat.TabIndex = 65;
            this.txtVat.TextChanged += new System.EventHandler(this.txtVat_TextChanged);
            // 
            // txtPurchase
            // 
            this.txtPurchase.Location = new System.Drawing.Point(109, 12);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(157, 20);
            this.txtPurchase.TabIndex = 63;
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblPurchase.Location = new System.Drawing.Point(17, 13);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(65, 16);
            this.lblPurchase.TabIndex = 62;
            this.lblPurchase.Text = "Purchase";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvItemData);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 333);
            this.panel3.TabIndex = 68;
            // 
            // dgvItemData
            // 
            this.dgvItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmItemCode,
            this.clmItemDescription,
            this.clmUnitPrice,
            this.clmQuantity,
            this.clmTax_chk,
            this.clmTaxAmount,
            this.clmTotalAmount});
            this.dgvItemData.Location = new System.Drawing.Point(3, 3);
            this.dgvItemData.Name = "dgvItemData";
            this.dgvItemData.Size = new System.Drawing.Size(656, 325);
            this.dgvItemData.TabIndex = 0;
            this.dgvItemData.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemData_CellValidated);
            this.dgvItemData.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvItemData_CurrentCellDirtyStateChanged);
            this.dgvItemData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // errPO
            // 
            this.errPO.ContainerControl = this;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSupplier.DropDownWidth = 17;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(101, 93);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(165, 21);
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
            this.cmbLocation.Location = new System.Drawing.Point(101, 55);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(165, 21);
            this.cmbLocation.TabIndex = 62;
            this.cmbLocation.ViewColumn = 0;
            // 
            // clmItemCode
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clmItemCode.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmItemCode.FillWeight = 213.198F;
            this.clmItemCode.Frozen = true;
            this.clmItemCode.HeaderText = "Item Code";
            this.clmItemCode.Name = "clmItemCode";
            this.clmItemCode.ReadOnly = true;
            this.clmItemCode.Width = 70;
            // 
            // clmItemDescription
            // 
            this.clmItemDescription.FillWeight = 77.3604F;
            this.clmItemDescription.Frozen = true;
            this.clmItemDescription.HeaderText = "Item Description";
            this.clmItemDescription.Name = "clmItemDescription";
            this.clmItemDescription.ReadOnly = true;
            this.clmItemDescription.Width = 130;
            // 
            // clmUnitPrice
            // 
            this.clmUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.clmUnitPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmUnitPrice.FillWeight = 77.3604F;
            this.clmUnitPrice.Frozen = true;
            this.clmUnitPrice.HeaderText = "Unit Price";
            this.clmUnitPrice.Name = "clmUnitPrice";
            this.clmUnitPrice.Width = 93;
            // 
            // clmQuantity
            // 
            this.clmQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clmQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmQuantity.FillWeight = 77.3604F;
            this.clmQuantity.Frozen = true;
            this.clmQuantity.HeaderText = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.Width = 94;
            // 
            // clmTax_chk
            // 
            this.clmTax_chk.Frozen = true;
            this.clmTax_chk.HeaderText = "TAX";
            this.clmTax_chk.Name = "clmTax_chk";
            this.clmTax_chk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmTax_chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmTax_chk.Width = 40;
            // 
            // clmTaxAmount
            // 
            this.clmTaxAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.NullValue = "0.00";
            this.clmTaxAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmTaxAmount.FillWeight = 77.3604F;
            this.clmTaxAmount.HeaderText = "Tax Amount";
            this.clmTaxAmount.Name = "clmTaxAmount";
            this.clmTaxAmount.ReadOnly = true;
            // 
            // clmTotalAmount
            // 
            this.clmTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTotalAmount.FillWeight = 77.3604F;
            this.clmTotalAmount.HeaderText = "Total Amount";
            this.clmTotalAmount.Name = "clmTotalAmount";
            this.clmTotalAmount.ReadOnly = true;
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(987, 410);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmPurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private ColumnComboBox cmbSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private ColumnComboBox cmbLocation;
        private System.Windows.Forms.TextBox txtPONumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblPONumber;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkVat;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvItemData;
        private System.Windows.Forms.ErrorProvider errPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmTax_chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalAmount;
    }
}