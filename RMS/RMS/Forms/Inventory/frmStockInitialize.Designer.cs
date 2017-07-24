namespace RMS.Forms.Inventory
{
    partial class frmStockInitialize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockInitialize));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDepartment = new RMS.ColumnComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbLocation = new RMS.ColumnComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmbCategory = new RMS.ColumnComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbSubCategory = new RMS.ColumnComboBox();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.chkLocation = new System.Windows.Forms.CheckBox();
            this.chkDepartment = new System.Windows.Forms.CheckBox();
            this.chkCategory = new System.Windows.Forms.CheckBox();
            this.chkSubCategory = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkSubCategory);
            this.panel1.Controls.Add(this.chkCategory);
            this.panel1.Controls.Add(this.chkDepartment);
            this.panel1.Controls.Add(this.chkLocation);
            this.panel1.Controls.Add(this.cmbSubCategory);
            this.panel1.Controls.Add(this.lblSubCategory);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.cmbLocation);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.cmbDepartment);
            this.panel1.Controls.Add(this.lblDepartment);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 164);
            this.panel1.TabIndex = 91;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDepartment.DropDownWidth = 17;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(112, 53);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(161, 21);
            this.cmbDepartment.TabIndex = 62;
            this.cmbDepartment.ViewColumn = 0;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDepartment.Location = new System.Drawing.Point(15, 54);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(78, 16);
            this.lblDepartment.TabIndex = 59;
            this.lblDepartment.Text = "Department";
            // 
            // cmbLocation
            // 
            this.cmbLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLocation.DropDownWidth = 17;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(112, 14);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(161, 21);
            this.cmbLocation.TabIndex = 64;
            this.cmbLocation.ViewColumn = 0;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblLocation.Location = new System.Drawing.Point(15, 15);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(59, 16);
            this.lblLocation.TabIndex = 63;
            this.lblLocation.Text = "Location";
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategory.DropDownWidth = 17;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(112, 91);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(161, 21);
            this.cmbCategory.TabIndex = 66;
            this.cmbCategory.ViewColumn = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCategory.Location = new System.Drawing.Point(15, 92);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(63, 16);
            this.lblCategory.TabIndex = 65;
            this.lblCategory.Text = "Category";
            // 
            // cmbSubCategory
            // 
            this.cmbSubCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSubCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSubCategory.DropDownWidth = 17;
            this.cmbSubCategory.FormattingEnabled = true;
            this.cmbSubCategory.Location = new System.Drawing.Point(112, 130);
            this.cmbSubCategory.Name = "cmbSubCategory";
            this.cmbSubCategory.Size = new System.Drawing.Size(161, 21);
            this.cmbSubCategory.TabIndex = 68;
            this.cmbSubCategory.ViewColumn = 0;
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSubCategory.Location = new System.Drawing.Point(15, 131);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(90, 16);
            this.lblSubCategory.TabIndex = 67;
            this.lblSubCategory.Text = "Sub Category";
            // 
            // chkLocation
            // 
            this.chkLocation.AutoSize = true;
            this.chkLocation.Location = new System.Drawing.Point(295, 17);
            this.chkLocation.Name = "chkLocation";
            this.chkLocation.Size = new System.Drawing.Size(45, 17);
            this.chkLocation.TabIndex = 69;
            this.chkLocation.Text = "ALL";
            this.chkLocation.UseVisualStyleBackColor = true;
            // 
            // chkDepartment
            // 
            this.chkDepartment.AutoSize = true;
            this.chkDepartment.Location = new System.Drawing.Point(295, 57);
            this.chkDepartment.Name = "chkDepartment";
            this.chkDepartment.Size = new System.Drawing.Size(45, 17);
            this.chkDepartment.TabIndex = 70;
            this.chkDepartment.Text = "ALL";
            this.chkDepartment.UseVisualStyleBackColor = true;
            // 
            // chkCategory
            // 
            this.chkCategory.AutoSize = true;
            this.chkCategory.Location = new System.Drawing.Point(295, 95);
            this.chkCategory.Name = "chkCategory";
            this.chkCategory.Size = new System.Drawing.Size(45, 17);
            this.chkCategory.TabIndex = 71;
            this.chkCategory.Text = "ALL";
            this.chkCategory.UseVisualStyleBackColor = true;
            // 
            // chkSubCategory
            // 
            this.chkSubCategory.AutoSize = true;
            this.chkSubCategory.Location = new System.Drawing.Point(295, 134);
            this.chkSubCategory.Name = "chkSubCategory";
            this.chkSubCategory.Size = new System.Drawing.Size(45, 17);
            this.chkSubCategory.TabIndex = 72;
            this.chkSubCategory.Text = "ALL";
            this.chkSubCategory.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(287, 192);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 93;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnInitialize
            // 
            this.btnInitialize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnInitialize.FlatAppearance.BorderSize = 0;
            this.btnInitialize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnInitialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnInitialize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInitialize.Location = new System.Drawing.Point(197, 192);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(75, 36);
            this.btnInitialize.TabIndex = 92;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = false;
            // 
            // frmStockInitialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 240);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.panel1);
            this.Name = "frmStockInitialize";
            this.Text = "Stock Initialize";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ColumnComboBox cmbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.CheckBox chkSubCategory;
        private System.Windows.Forms.CheckBox chkCategory;
        private System.Windows.Forms.CheckBox chkDepartment;
        private System.Windows.Forms.CheckBox chkLocation;
        private ColumnComboBox cmbSubCategory;
        private System.Windows.Forms.Label lblSubCategory;
        private ColumnComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private ColumnComboBox cmbLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInitialize;
    }
}