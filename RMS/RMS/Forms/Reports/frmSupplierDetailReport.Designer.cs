namespace RMS.Forms.Reports
{
    partial class frmSupplierDetailReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierDetailReport));
            this.label1 = new System.Windows.Forms.Label();
            this.chkCategory = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbSupplierCategory = new RMS.ColumnComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // chkCategory
            // 
            this.chkCategory.AutoSize = true;
            this.chkCategory.Location = new System.Drawing.Point(220, 41);
            this.chkCategory.Name = "chkCategory";
            this.chkCategory.Size = new System.Drawing.Size(45, 17);
            this.chkCategory.TabIndex = 2;
            this.chkCategory.Text = "ALL";
            this.chkCategory.UseVisualStyleBackColor = true;
            this.chkCategory.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbSupplierCategory
            // 
            this.cmbSupplierCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSupplierCategory.DropDownWidth = 17;
            this.cmbSupplierCategory.FormattingEnabled = true;
            this.cmbSupplierCategory.Location = new System.Drawing.Point(77, 39);
            this.cmbSupplierCategory.Name = "cmbSupplierCategory";
            this.cmbSupplierCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbSupplierCategory.TabIndex = 0;
            this.cmbSupplierCategory.ViewColumn = 0;
            // 
            // frmSupplierDetailReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 140);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSupplierCategory);
            this.Name = "frmSupplierDetailReport";
            this.Text = "frmSupplierDetailReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColumnComboBox cmbSupplierCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}