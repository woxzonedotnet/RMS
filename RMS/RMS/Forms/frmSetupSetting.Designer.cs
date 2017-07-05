namespace RMS.Forms
{
    partial class frmSetupSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetupSetting));
            this.cmbMainLocation = new RMS.ColumnComboBox();
            this.lblMainLocation = new System.Windows.Forms.Label();
            this.txtServiceCharge = new System.Windows.Forms.TextBox();
            this.lblServiceCharge = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.lblVat = new System.Windows.Forms.Label();
            this.txtGuidCharge = new System.Windows.Forms.TextBox();
            this.lblGuidCharge = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbMainLocation
            // 
            this.cmbMainLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMainLocation.DropDownWidth = 17;
            this.cmbMainLocation.FormattingEnabled = true;
            this.cmbMainLocation.Location = new System.Drawing.Point(116, 12);
            this.cmbMainLocation.Name = "cmbMainLocation";
            this.cmbMainLocation.Size = new System.Drawing.Size(150, 21);
            this.cmbMainLocation.TabIndex = 36;
            this.cmbMainLocation.ViewColumn = 0;
            // 
            // lblMainLocation
            // 
            this.lblMainLocation.AutoSize = true;
            this.lblMainLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblMainLocation.Location = new System.Drawing.Point(16, 13);
            this.lblMainLocation.Name = "lblMainLocation";
            this.lblMainLocation.Size = new System.Drawing.Size(91, 16);
            this.lblMainLocation.TabIndex = 35;
            this.lblMainLocation.Text = "Main Location";
            // 
            // txtServiceCharge
            // 
            this.txtServiceCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceCharge.Location = new System.Drawing.Point(116, 48);
            this.txtServiceCharge.Name = "txtServiceCharge";
            this.txtServiceCharge.Size = new System.Drawing.Size(150, 21);
            this.txtServiceCharge.TabIndex = 34;
            // 
            // lblServiceCharge
            // 
            this.lblServiceCharge.AutoSize = true;
            this.lblServiceCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCharge.Location = new System.Drawing.Point(16, 51);
            this.lblServiceCharge.Name = "lblServiceCharge";
            this.lblServiceCharge.Size = new System.Drawing.Size(101, 16);
            this.lblServiceCharge.TabIndex = 33;
            this.lblServiceCharge.Text = "Service Charge";
            // 
            // txtVat
            // 
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.Location = new System.Drawing.Point(116, 83);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(150, 21);
            this.txtVat.TabIndex = 38;
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(16, 86);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(35, 16);
            this.lblVat.TabIndex = 37;
            this.lblVat.Text = "VAT";
            // 
            // txtGuidCharge
            // 
            this.txtGuidCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuidCharge.Location = new System.Drawing.Point(116, 118);
            this.txtGuidCharge.Name = "txtGuidCharge";
            this.txtGuidCharge.Size = new System.Drawing.Size(150, 21);
            this.txtGuidCharge.TabIndex = 40;
            // 
            // lblGuidCharge
            // 
            this.lblGuidCharge.AutoSize = true;
            this.lblGuidCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuidCharge.Location = new System.Drawing.Point(16, 121);
            this.lblGuidCharge.Name = "lblGuidCharge";
            this.lblGuidCharge.Size = new System.Drawing.Size(83, 16);
            this.lblGuidCharge.TabIndex = 39;
            this.lblGuidCharge.Text = "Guid Charge";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(191, 152);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(100, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(272, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(272, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(272, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "%";
            // 
            // frmSetupSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 202);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGuidCharge);
            this.Controls.Add(this.lblGuidCharge);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.cmbMainLocation);
            this.Controls.Add(this.lblMainLocation);
            this.Controls.Add(this.txtServiceCharge);
            this.Controls.Add(this.lblServiceCharge);
            this.Name = "frmSetupSetting";
            this.Text = "Setup Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColumnComboBox cmbMainLocation;
        private System.Windows.Forms.Label lblMainLocation;
        private System.Windows.Forms.TextBox txtServiceCharge;
        private System.Windows.Forms.Label lblServiceCharge;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.TextBox txtGuidCharge;
        private System.Windows.Forms.Label lblGuidCharge;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}