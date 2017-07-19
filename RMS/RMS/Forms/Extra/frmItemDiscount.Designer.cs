namespace RMS.Forms.Extra
{
    partial class frmItemDiscount
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
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.chkPercentage = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.rbPromotional = new System.Windows.Forms.RadioButton();
            this.rbQuantity = new System.Windows.Forms.RadioButton();
            this.dtpExpireOn = new System.Windows.Forms.DateTimePicker();
            this.dtpStartOn = new System.Windows.Forms.DateTimePicker();
            this.lblExpireOn = new System.Windows.Forms.Label();
            this.lblStartOn = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(117, 167);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(97, 20);
            this.txtPercentage.TabIndex = 97;
            // 
            // chkPercentage
            // 
            this.chkPercentage.AutoSize = true;
            this.chkPercentage.Location = new System.Drawing.Point(15, 169);
            this.chkPercentage.Name = "chkPercentage";
            this.chkPercentage.Size = new System.Drawing.Size(98, 17);
            this.chkPercentage.TabIndex = 96;
            this.chkPercentage.Text = "Percentage (%)";
            this.chkPercentage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtQuantity);
            this.groupBox3.Controls.Add(this.rbPromotional);
            this.groupBox3.Controls.Add(this.rbQuantity);
            this.groupBox3.Location = new System.Drawing.Point(15, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 95);
            this.groupBox3.TabIndex = 95;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discount";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(102, 32);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(97, 20);
            this.txtQuantity.TabIndex = 43;
            // 
            // rbPromotional
            // 
            this.rbPromotional.AutoSize = true;
            this.rbPromotional.Location = new System.Drawing.Point(15, 63);
            this.rbPromotional.Name = "rbPromotional";
            this.rbPromotional.Size = new System.Drawing.Size(80, 17);
            this.rbPromotional.TabIndex = 1;
            this.rbPromotional.Text = "Promotional";
            this.rbPromotional.UseVisualStyleBackColor = true;
            // 
            // rbQuantity
            // 
            this.rbQuantity.AutoSize = true;
            this.rbQuantity.Location = new System.Drawing.Point(15, 31);
            this.rbQuantity.Name = "rbQuantity";
            this.rbQuantity.Size = new System.Drawing.Size(64, 17);
            this.rbQuantity.TabIndex = 0;
            this.rbQuantity.Text = "Quantity";
            this.rbQuantity.UseVisualStyleBackColor = true;
            // 
            // dtpExpireOn
            // 
            this.dtpExpireOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpireOn.Location = new System.Drawing.Point(130, 33);
            this.dtpExpireOn.Name = "dtpExpireOn";
            this.dtpExpireOn.Size = new System.Drawing.Size(97, 20);
            this.dtpExpireOn.TabIndex = 94;
            // 
            // dtpStartOn
            // 
            this.dtpStartOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartOn.Location = new System.Drawing.Point(15, 32);
            this.dtpStartOn.Name = "dtpStartOn";
            this.dtpStartOn.Size = new System.Drawing.Size(97, 20);
            this.dtpStartOn.TabIndex = 93;
            // 
            // lblExpireOn
            // 
            this.lblExpireOn.AutoSize = true;
            this.lblExpireOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblExpireOn.Location = new System.Drawing.Point(127, 9);
            this.lblExpireOn.Name = "lblExpireOn";
            this.lblExpireOn.Size = new System.Drawing.Size(66, 16);
            this.lblExpireOn.TabIndex = 92;
            this.lblExpireOn.Text = "Expire On";
            // 
            // lblStartOn
            // 
            this.lblStartOn.AutoSize = true;
            this.lblStartOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblStartOn.Location = new System.Drawing.Point(12, 9);
            this.lblStartOn.Name = "lblStartOn";
            this.lblStartOn.Size = new System.Drawing.Size(55, 16);
            this.lblStartOn.TabIndex = 89;
            this.lblStartOn.Text = "Start On";
            // 
            // frmItemDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 204);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.chkPercentage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtpExpireOn);
            this.Controls.Add(this.dtpStartOn);
            this.Controls.Add(this.lblExpireOn);
            this.Controls.Add(this.lblStartOn);
            this.Name = "frmItemDiscount";
            this.Text = "Item Discount";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.CheckBox chkPercentage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.RadioButton rbPromotional;
        private System.Windows.Forms.RadioButton rbQuantity;
        private System.Windows.Forms.DateTimePicker dtpExpireOn;
        private System.Windows.Forms.DateTimePicker dtpStartOn;
        private System.Windows.Forms.Label lblExpireOn;
        private System.Windows.Forms.Label lblStartOn;
    }
}