namespace RMS.Forms.Reports
{
    partial class frmItemMasterDetailsReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemMasterDetailsReports));
            this.chkDepartment = new System.Windows.Forms.CheckBox();
            this.chkCategory = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbSupplierCategory = new RMS.ColumnComboBox();
            this.cmbSupplierDepartment = new RMS.ColumnComboBox();
            this.SuspendLayout();
            // 
            // chkDepartment
            // 
            this.chkDepartment.AutoSize = true;
            this.chkDepartment.Location = new System.Drawing.Point(201, 15);
            this.chkDepartment.Name = "chkDepartment";
            this.chkDepartment.Size = new System.Drawing.Size(45, 17);
            this.chkDepartment.TabIndex = 2;
            this.chkDepartment.Text = "ALL";
            this.chkDepartment.UseVisualStyleBackColor = true;
            // 
            // chkCategory
            // 
            this.chkCategory.AutoSize = true;
            this.chkCategory.Location = new System.Drawing.Point(201, 51);
            this.chkCategory.Name = "chkCategory";
            this.chkCategory.Size = new System.Drawing.Size(45, 17);
            this.chkCategory.TabIndex = 3;
            this.chkCategory.Text = "ALL";
            this.chkCategory.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Category";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbSupplierCategory
            // 
            this.cmbSupplierCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSupplierCategory.DropDownWidth = 17;
            this.cmbSupplierCategory.FormattingEnabled = true;
            this.cmbSupplierCategory.Location = new System.Drawing.Point(74, 49);
            this.cmbSupplierCategory.Name = "cmbSupplierCategory";
            this.cmbSupplierCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbSupplierCategory.TabIndex = 1;
            this.cmbSupplierCategory.ViewColumn = 0;
            // 
            // cmbSupplierDepartment
            // 
            this.cmbSupplierDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSupplierDepartment.DropDownWidth = 17;
            this.cmbSupplierDepartment.FormattingEnabled = true;
            this.cmbSupplierDepartment.Location = new System.Drawing.Point(74, 13);
            this.cmbSupplierDepartment.Name = "cmbSupplierDepartment";
            this.cmbSupplierDepartment.Size = new System.Drawing.Size(121, 21);
            this.cmbSupplierDepartment.TabIndex = 0;
            this.cmbSupplierDepartment.ViewColumn = 0;
            // 
            // frmItemMasterDetailsReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 151);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkCategory);
            this.Controls.Add(this.chkDepartment);
            this.Controls.Add(this.cmbSupplierCategory);
            this.Controls.Add(this.cmbSupplierDepartment);
            this.Name = "frmItemMasterDetailsReports";
            this.Text = "frmItemMasterDetailsReports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColumnComboBox cmbSupplierDepartment;
        private ColumnComboBox cmbSupplierCategory;
        private System.Windows.Forms.CheckBox chkDepartment;
        private System.Windows.Forms.CheckBox chkCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}