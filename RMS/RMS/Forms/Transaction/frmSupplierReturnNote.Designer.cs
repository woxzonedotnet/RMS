namespace RMS.Forms.Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierReturnNote));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtGRNNumber = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblGRNNumber = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSRNValue = new System.Windows.Forms.TextBox();
            this.lblSRNValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmbSupplier = new RMS.ColumnComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbLocation = new RMS.ColumnComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSRNNumber = new System.Windows.Forms.TextBox();
            this.lblSRNNumber = new System.Windows.Forms.Label();
            this.rdTotal = new System.Windows.Forms.RadioButton();
            this.rdEdit = new System.Windows.Forms.RadioButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 317);
            this.panel3.TabIndex = 82;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(108, 159);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(120, 20);
            this.dtpDate.TabIndex = 66;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDate.Location = new System.Drawing.Point(15, 163);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 16);
            this.lblDate.TabIndex = 65;
            this.lblDate.Text = "Date";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSupplier.Location = new System.Drawing.Point(15, 124);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(58, 16);
            this.lblSupplier.TabIndex = 63;
            this.lblSupplier.Text = "Supplier";
            // 
            // txtGRNNumber
            // 
            this.txtGRNNumber.Location = new System.Drawing.Point(108, 49);
            this.txtGRNNumber.Name = "txtGRNNumber";
            this.txtGRNNumber.Size = new System.Drawing.Size(120, 20);
            this.txtGRNNumber.TabIndex = 61;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblLocation.Location = new System.Drawing.Point(15, 86);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(59, 16);
            this.lblLocation.TabIndex = 59;
            this.lblLocation.Text = "Location";
            // 
            // lblGRNNumber
            // 
            this.lblGRNNumber.AutoSize = true;
            this.lblGRNNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblGRNNumber.Location = new System.Drawing.Point(15, 50);
            this.lblGRNNumber.Name = "lblGRNNumber";
            this.lblGRNNumber.Size = new System.Drawing.Size(89, 16);
            this.lblGRNNumber.TabIndex = 58;
            this.lblGRNNumber.Text = "GRN Number";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSRNValue);
            this.panel2.Controls.Add(this.lblSRNValue);
            this.panel2.Location = new System.Drawing.Point(430, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 48);
            this.panel2.TabIndex = 81;
            // 
            // txtSRNValue
            // 
            this.txtSRNValue.Location = new System.Drawing.Point(116, 12);
            this.txtSRNValue.Name = "txtSRNValue";
            this.txtSRNValue.Size = new System.Drawing.Size(157, 20);
            this.txtSRNValue.TabIndex = 63;
            // 
            // lblSRNValue
            // 
            this.lblSRNValue.AutoSize = true;
            this.lblSRNValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSRNValue.Location = new System.Drawing.Point(17, 13);
            this.lblSRNValue.Name = "lblSRNValue";
            this.lblSRNValue.Size = new System.Drawing.Size(75, 16);
            this.lblSRNValue.TabIndex = 62;
            this.lblSRNValue.Text = "SRN Value";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(629, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 80;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(548, 348);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 79;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Location = new System.Drawing.Point(467, 348);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 36);
            this.btnPrint.TabIndex = 78;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSupplier.DropDownWidth = 17;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(108, 123);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(165, 21);
            this.cmbSupplier.TabIndex = 64;
            this.cmbSupplier.ViewColumn = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdEdit);
            this.panel1.Controls.Add(this.rdTotal);
            this.panel1.Controls.Add(this.txtSRNNumber);
            this.panel1.Controls.Add(this.lblSRNNumber);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.cmbSupplier);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.cmbLocation);
            this.panel1.Controls.Add(this.txtGRNNumber);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.lblGRNNumber);
            this.panel1.Location = new System.Drawing.Point(430, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 251);
            this.panel1.TabIndex = 76;
            // 
            // cmbLocation
            // 
            this.cmbLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLocation.DropDownWidth = 17;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(108, 85);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(165, 21);
            this.cmbLocation.TabIndex = 62;
            this.cmbLocation.ViewColumn = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(386, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 77;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
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
            this.btnSearch.Location = new System.Drawing.Point(238, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSRNNumber
            // 
            this.txtSRNNumber.Location = new System.Drawing.Point(108, 13);
            this.txtSRNNumber.Name = "txtSRNNumber";
            this.txtSRNNumber.Size = new System.Drawing.Size(165, 20);
            this.txtSRNNumber.TabIndex = 70;
            // 
            // lblSRNNumber
            // 
            this.lblSRNNumber.AutoSize = true;
            this.lblSRNNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSRNNumber.Location = new System.Drawing.Point(15, 14);
            this.lblSRNNumber.Name = "lblSRNNumber";
            this.lblSRNNumber.Size = new System.Drawing.Size(88, 16);
            this.lblSRNNumber.TabIndex = 69;
            this.lblSRNNumber.Text = "SRN Number";
            // 
            // rdTotal
            // 
            this.rdTotal.AutoSize = true;
            this.rdTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rdTotal.Location = new System.Drawing.Point(108, 194);
            this.rdTotal.Name = "rdTotal";
            this.rdTotal.Size = new System.Drawing.Size(57, 20);
            this.rdTotal.TabIndex = 71;
            this.rdTotal.TabStop = true;
            this.rdTotal.Text = "Total";
            this.rdTotal.UseVisualStyleBackColor = true;
            // 
            // rdEdit
            // 
            this.rdEdit.AutoSize = true;
            this.rdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.rdEdit.Location = new System.Drawing.Point(108, 220);
            this.rdEdit.Name = "rdEdit";
            this.rdEdit.Size = new System.Drawing.Size(49, 20);
            this.rdEdit.TabIndex = 72;
            this.rdEdit.TabStop = true;
            this.rdEdit.Text = "Edit";
            this.rdEdit.UseVisualStyleBackColor = true;
            // 
            // frmSupplierReturnNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 399);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Name = "frmSupplierReturnNote";
            this.Text = "Supplier Return Note (SRN)";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtGRNNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblGRNNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSRNValue;
        private System.Windows.Forms.Label lblSRNValue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private ColumnComboBox cmbSupplier;
        private System.Windows.Forms.Panel panel1;
        private ColumnComboBox cmbLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdEdit;
        private System.Windows.Forms.RadioButton rdTotal;
        private System.Windows.Forms.TextBox txtSRNNumber;
        private System.Windows.Forms.Label lblSRNNumber;
    }
}