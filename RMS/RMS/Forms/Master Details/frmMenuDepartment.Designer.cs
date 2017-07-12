namespace RMS.Forms
{
    partial class frmMenuDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuDepartment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtSupplierCode = new System.Windows.Forms.TextBox();
            this.lblSupplierCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.columnComboBox1 = new RMS.ColumnComboBox();
            this.columnComboBox2 = new RMS.ColumnComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Category";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioButton2.Location = new System.Drawing.Point(28, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Charge";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioButton1.Location = new System.Drawing.Point(28, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(132, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Menu Department";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierCode.Location = new System.Drawing.Point(109, 111);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(150, 21);
            this.txtSupplierCode.TabIndex = 5;
            // 
            // lblSupplierCode
            // 
            this.lblSupplierCode.AutoSize = true;
            this.lblSupplierCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierCode.Location = new System.Drawing.Point(9, 114);
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.Size = new System.Drawing.Size(78, 16);
            this.lblSupplierCode.TabIndex = 4;
            this.lblSupplierCode.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Main Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Charge Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sales GL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Inventory";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(109, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 21);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(109, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 21);
            this.textBox2.TabIndex = 11;
            // 
            // columnComboBox1
            // 
            this.columnComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.columnComboBox1.DropDownWidth = 17;
            this.columnComboBox1.FormattingEnabled = true;
            this.columnComboBox1.Location = new System.Drawing.Point(109, 147);
            this.columnComboBox1.Name = "columnComboBox1";
            this.columnComboBox1.Size = new System.Drawing.Size(150, 21);
            this.columnComboBox1.TabIndex = 12;
            this.columnComboBox1.ViewColumn = 0;
            // 
            // columnComboBox2
            // 
            this.columnComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.columnComboBox2.DropDownWidth = 17;
            this.columnComboBox2.FormattingEnabled = true;
            this.columnComboBox2.Location = new System.Drawing.Point(109, 183);
            this.columnComboBox2.Name = "columnComboBox2";
            this.columnComboBox2.Size = new System.Drawing.Size(150, 21);
            this.columnComboBox2.TabIndex = 13;
            this.columnComboBox2.ViewColumn = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(184, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(103, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(22, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmMenuDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 346);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.columnComboBox2);
            this.Controls.Add(this.columnComboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSupplierCode);
            this.Controls.Add(this.lblSupplierCode);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMenuDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Department";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtSupplierCode;
        private System.Windows.Forms.Label lblSupplierCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private ColumnComboBox columnComboBox1;
        private ColumnComboBox columnComboBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}