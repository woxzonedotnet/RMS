namespace RMS.Forms.Reports
{
    partial class frmRecipeDetailsRepot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipeDetailsRepot));
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.chkOrderType = new System.Windows.Forms.CheckBox();
            this.chkLocation = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbLocation = new RMS.ColumnComboBox();
            this.cmbOrderType = new RMS.ColumnComboBox();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblLocation.Location = new System.Drawing.Point(17, 62);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(59, 16);
            this.lblLocation.TabIndex = 75;
            this.lblLocation.Text = "Location";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblOrderType.Location = new System.Drawing.Point(17, 27);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(77, 16);
            this.lblOrderType.TabIndex = 73;
            this.lblOrderType.Text = "Order Type";
            // 
            // chkOrderType
            // 
            this.chkOrderType.AutoSize = true;
            this.chkOrderType.Location = new System.Drawing.Point(315, 27);
            this.chkOrderType.Name = "chkOrderType";
            this.chkOrderType.Size = new System.Drawing.Size(37, 17);
            this.chkOrderType.TabIndex = 78;
            this.chkOrderType.Text = "All";
            this.chkOrderType.UseVisualStyleBackColor = true;
            this.chkOrderType.CheckedChanged += new System.EventHandler(this.chkOrderType_CheckedChanged);
            // 
            // chkLocation
            // 
            this.chkLocation.AutoSize = true;
            this.chkLocation.Location = new System.Drawing.Point(314, 61);
            this.chkLocation.Name = "chkLocation";
            this.chkLocation.Size = new System.Drawing.Size(37, 17);
            this.chkLocation.TabIndex = 79;
            this.chkLocation.Text = "All";
            this.chkLocation.UseVisualStyleBackColor = true;
            this.chkLocation.CheckedChanged += new System.EventHandler(this.chkLocation_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(276, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 81;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(195, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 80;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbLocation
            // 
            this.cmbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLocation.DropDownWidth = 17;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(117, 61);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(191, 21);
            this.cmbLocation.TabIndex = 76;
            this.cmbLocation.ViewColumn = 0;
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbOrderType.DropDownWidth = 17;
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Location = new System.Drawing.Point(117, 26);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(191, 21);
            this.cmbOrderType.TabIndex = 74;
            this.cmbOrderType.ViewColumn = 0;
            // 
            // frmRecipeDetailsRepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 149);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkLocation);
            this.Controls.Add(this.chkOrderType);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.lblOrderType);
            this.Name = "frmRecipeDetailsRepot";
            this.Text = "Recipe Details Repot";
            this.Load += new System.EventHandler(this.frmRecipeDetailsRepot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColumnComboBox cmbLocation;
        private System.Windows.Forms.Label lblLocation;
        private ColumnComboBox cmbOrderType;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.CheckBox chkOrderType;
        private System.Windows.Forms.CheckBox chkLocation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}