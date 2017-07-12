namespace RMS.Forms
{
    partial class frmMenuDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalMenuCost = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.columnComboBox1 = new RMS.ColumnComboBox();
            this.columnComboBox2 = new RMS.ColumnComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.columnComboBox3 = new RMS.ColumnComboBox();
            this.btBackColor = new System.Windows.Forms.Button();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.pnlBackColor = new System.Windows.Forms.Panel();
            this.pnlTextColor = new System.Windows.Forms.Panel();
            this.cmbServiceCharge = new System.Windows.Forms.CheckBox();
            this.cmbCancel = new System.Windows.Forms.CheckBox();
            this.btnSample = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtTotalMenuCost = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description Appear on Bill";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selling Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Printer Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(307, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Packing Charge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.Location = new System.Drawing.Point(307, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Time to Prepare";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label9.Location = new System.Drawing.Point(307, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Menu Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label10.Location = new System.Drawing.Point(488, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = "     In \r\nMinutes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label11.Location = new System.Drawing.Point(566, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Back Color";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label12.Location = new System.Drawing.Point(566, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Text Color";
            // 
            // lblTotalMenuCost
            // 
            this.lblTotalMenuCost.AutoSize = true;
            this.lblTotalMenuCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblTotalMenuCost.Location = new System.Drawing.Point(545, 404);
            this.lblTotalMenuCost.Name = "lblTotalMenuCost";
            this.lblTotalMenuCost.Size = new System.Drawing.Size(105, 16);
            this.lblTotalMenuCost.TabIndex = 12;
            this.lblTotalMenuCost.Text = "Total Menu Cost";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(344, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(180, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(344, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(180, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(108, 20);
            this.textBox4.TabIndex = 16;
            // 
            // columnComboBox1
            // 
            this.columnComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.columnComboBox1.DropDownWidth = 17;
            this.columnComboBox1.FormattingEnabled = true;
            this.columnComboBox1.Location = new System.Drawing.Point(180, 123);
            this.columnComboBox1.Name = "columnComboBox1";
            this.columnComboBox1.Size = new System.Drawing.Size(108, 21);
            this.columnComboBox1.TabIndex = 17;
            this.columnComboBox1.ViewColumn = 0;
            // 
            // columnComboBox2
            // 
            this.columnComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.columnComboBox2.DropDownWidth = 17;
            this.columnComboBox2.FormattingEnabled = true;
            this.columnComboBox2.Location = new System.Drawing.Point(180, 153);
            this.columnComboBox2.Name = "columnComboBox2";
            this.columnComboBox2.Size = new System.Drawing.Size(108, 21);
            this.columnComboBox2.TabIndex = 18;
            this.columnComboBox2.ViewColumn = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(417, 94);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(107, 20);
            this.textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(417, 123);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(66, 20);
            this.textBox6.TabIndex = 20;
            // 
            // columnComboBox3
            // 
            this.columnComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.columnComboBox3.DropDownWidth = 17;
            this.columnComboBox3.FormattingEnabled = true;
            this.columnComboBox3.Location = new System.Drawing.Point(417, 153);
            this.columnComboBox3.Name = "columnComboBox3";
            this.columnComboBox3.Size = new System.Drawing.Size(107, 21);
            this.columnComboBox3.TabIndex = 21;
            this.columnComboBox3.ViewColumn = 0;
            // 
            // btBackColor
            // 
            this.btBackColor.Location = new System.Drawing.Point(647, 3);
            this.btBackColor.Name = "btBackColor";
            this.btBackColor.Size = new System.Drawing.Size(33, 23);
            this.btBackColor.TabIndex = 22;
            this.btBackColor.Text = "...";
            this.btBackColor.UseVisualStyleBackColor = true;
            // 
            // btnTextColor
            // 
            this.btnTextColor.Location = new System.Drawing.Point(647, 32);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(33, 23);
            this.btnTextColor.TabIndex = 23;
            this.btnTextColor.Text = "...";
            this.btnTextColor.UseVisualStyleBackColor = true;
            // 
            // pnlBackColor
            // 
            this.pnlBackColor.BackColor = System.Drawing.Color.Aqua;
            this.pnlBackColor.Location = new System.Drawing.Point(548, 8);
            this.pnlBackColor.Name = "pnlBackColor";
            this.pnlBackColor.Size = new System.Drawing.Size(17, 16);
            this.pnlBackColor.TabIndex = 24;
            // 
            // pnlTextColor
            // 
            this.pnlTextColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlTextColor.Location = new System.Drawing.Point(548, 36);
            this.pnlTextColor.Name = "pnlTextColor";
            this.pnlTextColor.Size = new System.Drawing.Size(17, 16);
            this.pnlTextColor.TabIndex = 25;
            // 
            // cmbServiceCharge
            // 
            this.cmbServiceCharge.AutoSize = true;
            this.cmbServiceCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmbServiceCharge.Location = new System.Drawing.Point(548, 65);
            this.cmbServiceCharge.Name = "cmbServiceCharge";
            this.cmbServiceCharge.Size = new System.Drawing.Size(120, 20);
            this.cmbServiceCharge.TabIndex = 26;
            this.cmbServiceCharge.Text = "Service Charge";
            this.cmbServiceCharge.UseVisualStyleBackColor = true;
            // 
            // cmbCancel
            // 
            this.cmbCancel.AutoSize = true;
            this.cmbCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmbCancel.Location = new System.Drawing.Point(548, 94);
            this.cmbCancel.Name = "cmbCancel";
            this.cmbCancel.Size = new System.Drawing.Size(69, 20);
            this.cmbCancel.TabIndex = 27;
            this.cmbCancel.Text = "Cancel";
            this.cmbCancel.UseVisualStyleBackColor = true;
            // 
            // btnSample
            // 
            this.btnSample.Location = new System.Drawing.Point(686, 4);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(50, 51);
            this.btnSample.TabIndex = 28;
            this.btnSample.Text = "Sample";
            this.btnSample.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 285);
            this.dataGridView1.TabIndex = 29;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(548, 123);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(318, 264);
            this.dataGridView2.TabIndex = 30;
            // 
            // txtTotalMenuCost
            // 
            this.txtTotalMenuCost.Location = new System.Drawing.Point(710, 403);
            this.txtTotalMenuCost.Name = "txtTotalMenuCost";
            this.txtTotalMenuCost.Size = new System.Drawing.Size(156, 20);
            this.txtTotalMenuCost.TabIndex = 31;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(791, 439);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(710, 439);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(629, 439);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 36);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(548, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmMenuDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 487);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotalMenuCost);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSample);
            this.Controls.Add(this.cmbCancel);
            this.Controls.Add(this.cmbServiceCharge);
            this.Controls.Add(this.pnlTextColor);
            this.Controls.Add(this.pnlBackColor);
            this.Controls.Add(this.btnTextColor);
            this.Controls.Add(this.btBackColor);
            this.Controls.Add(this.columnComboBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.columnComboBox2);
            this.Controls.Add(this.columnComboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTotalMenuCost);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMenuDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalMenuCost;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private ColumnComboBox columnComboBox1;
        private ColumnComboBox columnComboBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private ColumnComboBox columnComboBox3;
        private System.Windows.Forms.Button btBackColor;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.Panel pnlBackColor;
        private System.Windows.Forms.Panel pnlTextColor;
        private System.Windows.Forms.CheckBox cmbServiceCharge;
        private System.Windows.Forms.CheckBox cmbCancel;
        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtTotalMenuCost;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
    }
}