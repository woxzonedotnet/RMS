namespace RMS.Forms.Inventory
{
    partial class frmTransferNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferNote));
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbLocationTo = new RMS.ColumnComboBox();
            this.cmbLocationFrom = new RMS.ColumnComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblLocationFrom = new System.Windows.Forms.Label();
            this.lblIssuesNumber = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtIssuesNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblLocationTo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(112, 164);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(188, 20);
            this.txtTotal.TabIndex = 70;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblTotal.Location = new System.Drawing.Point(15, 165);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 16);
            this.lblTotal.TabIndex = 69;
            this.lblTotal.Text = "Total";
            // 
            // cmbLocationTo
            // 
            this.cmbLocationTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLocationTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocationTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLocationTo.DropDownWidth = 17;
            this.cmbLocationTo.FormattingEnabled = true;
            this.cmbLocationTo.Location = new System.Drawing.Point(112, 91);
            this.cmbLocationTo.Name = "cmbLocationTo";
            this.cmbLocationTo.Size = new System.Drawing.Size(188, 21);
            this.cmbLocationTo.TabIndex = 64;
            this.cmbLocationTo.ViewColumn = 0;
            // 
            // cmbLocationFrom
            // 
            this.cmbLocationFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLocationFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocationFrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLocationFrom.DropDownWidth = 17;
            this.cmbLocationFrom.FormattingEnabled = true;
            this.cmbLocationFrom.Location = new System.Drawing.Point(112, 53);
            this.cmbLocationFrom.Name = "cmbLocationFrom";
            this.cmbLocationFrom.Size = new System.Drawing.Size(188, 21);
            this.cmbLocationFrom.TabIndex = 62;
            this.cmbLocationFrom.ViewColumn = 0;
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
            this.btnSearch.Location = new System.Drawing.Point(265, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 251);
            this.panel3.TabIndex = 89;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblLocationFrom
            // 
            this.lblLocationFrom.AutoSize = true;
            this.lblLocationFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblLocationFrom.Location = new System.Drawing.Point(15, 54);
            this.lblLocationFrom.Name = "lblLocationFrom";
            this.lblLocationFrom.Size = new System.Drawing.Size(93, 16);
            this.lblLocationFrom.TabIndex = 59;
            this.lblLocationFrom.Text = "Location From";
            // 
            // lblIssuesNumber
            // 
            this.lblIssuesNumber.AutoSize = true;
            this.lblIssuesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblIssuesNumber.Location = new System.Drawing.Point(15, 18);
            this.lblIssuesNumber.Name = "lblIssuesNumber";
            this.lblIssuesNumber.Size = new System.Drawing.Size(91, 16);
            this.lblIssuesNumber.TabIndex = 58;
            this.lblIssuesNumber.Text = "Issue Number";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(592, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 86;
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
            this.btnPrint.Location = new System.Drawing.Point(511, 227);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 36);
            this.btnPrint.TabIndex = 85;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // txtIssuesNumber
            // 
            this.txtIssuesNumber.Location = new System.Drawing.Point(112, 17);
            this.txtIssuesNumber.Name = "txtIssuesNumber";
            this.txtIssuesNumber.Size = new System.Drawing.Size(143, 20);
            this.txtIssuesNumber.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.cmbLocationTo);
            this.panel1.Controls.Add(this.lblLocationTo);
            this.panel1.Controls.Add(this.cmbLocationFrom);
            this.panel1.Controls.Add(this.txtIssuesNumber);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblLocationFrom);
            this.panel1.Controls.Add(this.lblIssuesNumber);
            this.panel1.Location = new System.Drawing.Point(430, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 200);
            this.panel1.TabIndex = 83;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDate.Location = new System.Drawing.Point(15, 131);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 16);
            this.lblDate.TabIndex = 71;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(112, 127);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(143, 20);
            this.dtpDate.TabIndex = 66;
            // 
            // lblLocationTo
            // 
            this.lblLocationTo.AutoSize = true;
            this.lblLocationTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblLocationTo.Location = new System.Drawing.Point(15, 92);
            this.lblLocationTo.Name = "lblLocationTo";
            this.lblLocationTo.Size = new System.Drawing.Size(79, 16);
            this.lblLocationTo.TabIndex = 63;
            this.lblLocationTo.Text = "Location To";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(430, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 84;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(673, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 87;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // frmTransferNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 276);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "frmTransferNote";
            this.Text = "Transfer Note";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private ColumnComboBox cmbLocationTo;
        private ColumnComboBox cmbLocationFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblLocationFrom;
        private System.Windows.Forms.Label lblIssuesNumber;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtIssuesNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblLocationTo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDate;

    }
}