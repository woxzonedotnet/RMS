namespace RMS.Forms.Inventory
{
    partial class frmStockAdjustmentNote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockAdjustmentNote));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblLocation = new System.Windows.Forms.Label();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtSANNumber = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSANNumber = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errStockAdjusment = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.clmItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhyQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSysStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbLocation = new RMS.ColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errStockAdjusment)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(105, 121);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(188, 20);
            this.dtpDate.TabIndex = 66;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblLocation.Location = new System.Drawing.Point(8, 89);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(59, 16);
            this.lblLocation.TabIndex = 63;
            this.lblLocation.Text = "Location";
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmItemCode,
            this.clmDescription,
            this.clmPhyQty,
            this.clmSysStock,
            this.clmCost,
            this.clmTotalCost});
            this.dgvItem.Location = new System.Drawing.Point(11, 163);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(642, 258);
            this.dgvItem.TabIndex = 0;
            this.dgvItem.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellValidated);
            this.dgvItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItem_KeyDown);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDate.Location = new System.Drawing.Point(8, 125);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 16);
            this.lblDate.TabIndex = 71;
            this.lblDate.Text = "Date";
            // 
            // txtSANNumber
            // 
            this.txtSANNumber.Location = new System.Drawing.Point(105, 56);
            this.txtSANNumber.Name = "txtSANNumber";
            this.txtSANNumber.ReadOnly = true;
            this.txtSANNumber.Size = new System.Drawing.Size(143, 20);
            this.txtSANNumber.TabIndex = 61;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(497, 463);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 93;
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
            this.btnPrint.Location = new System.Drawing.Point(416, 463);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 36);
            this.btnPrint.TabIndex = 92;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(529, 427);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalCost.Size = new System.Drawing.Size(124, 20);
            this.txtTotalCost.TabIndex = 70;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblTotalCost.Location = new System.Drawing.Point(441, 428);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(69, 16);
            this.lblTotalCost.TabIndex = 69;
            this.lblTotalCost.Text = "Total Cost";
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
            this.btnSearch.Location = new System.Drawing.Point(258, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblSANNumber
            // 
            this.lblSANNumber.AutoSize = true;
            this.lblSANNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSANNumber.Location = new System.Drawing.Point(8, 57);
            this.lblSANNumber.Name = "lblSANNumber";
            this.lblSANNumber.Size = new System.Drawing.Size(87, 16);
            this.lblSANNumber.TabIndex = 58;
            this.lblSANNumber.Text = "SAN Number";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(335, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 91;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(578, 463);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 94;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errStockAdjusment
            // 
            this.errStockAdjusment.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 31);
            this.panel2.TabIndex = 95;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(9, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 16);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Stock Adjustment Note";
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
            this.btnExit.Location = new System.Drawing.Point(624, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Location = new System.Drawing.Point(660, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 490);
            this.panel1.TabIndex = 96;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel3.Location = new System.Drawing.Point(-9, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 490);
            this.panel3.TabIndex = 97;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel4.Location = new System.Drawing.Point(-2, 509);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(663, 10);
            this.panel4.TabIndex = 98;
            // 
            // clmItemCode
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clmItemCode.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmItemCode.HeaderText = "Item Code";
            this.clmItemCode.Name = "clmItemCode";
            this.clmItemCode.ReadOnly = true;
            this.clmItemCode.Width = 60;
            // 
            // clmDescription
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmDescription.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmDescription.HeaderText = "Description";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            this.clmDescription.Width = 187;
            // 
            // clmPhyQty
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.0";
            this.clmPhyQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmPhyQty.HeaderText = "Phy.Qty";
            this.clmPhyQty.Name = "clmPhyQty";
            this.clmPhyQty.Width = 60;
            // 
            // clmSysStock
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.0";
            this.clmSysStock.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmSysStock.HeaderText = "Sys.Stock";
            this.clmSysStock.Name = "clmSysStock";
            this.clmSysStock.ReadOnly = true;
            this.clmSysStock.Width = 60;
            // 
            // clmCost
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "###,###.00";
            dataGridViewCellStyle5.NullValue = "0.0";
            this.clmCost.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmCost.HeaderText = "Cost";
            this.clmCost.Name = "clmCost";
            this.clmCost.ReadOnly = true;
            this.clmCost.Width = 115;
            // 
            // clmTotalCost
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "###,###.00";
            dataGridViewCellStyle6.NullValue = "0.0";
            this.clmTotalCost.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmTotalCost.HeaderText = "Total Cost";
            this.clmTotalCost.Name = "clmTotalCost";
            this.clmTotalCost.ReadOnly = true;
            this.clmTotalCost.Width = 115;
            // 
            // cmbLocation
            // 
            this.cmbLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLocation.DropDownWidth = 17;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(105, 88);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(188, 21);
            this.cmbLocation.TabIndex = 64;
            this.cmbLocation.ViewColumn = 0;
            // 
            // frmStockAdjustmentNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(661, 510);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSANNumber);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSANNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStockAdjustmentNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Adjustment Note";
            this.Load += new System.EventHandler(this.frmStockAdjustmentNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errStockAdjusment)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Label lblDate;
        private ColumnComboBox cmbLocation;
        private System.Windows.Forms.TextBox txtSANNumber;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSANNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errStockAdjusment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhyQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSysStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalCost;
    }
}