﻿namespace RMS.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetupSetting));
            this.lblMainLocation = new System.Windows.Forms.Label();
            this.txtServiceCharge = new System.Windows.Forms.TextBox();
            this.lblServiceCharge = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.lblVat = new System.Windows.Forms.Label();
            this.txtGuidCharge = new System.Windows.Forms.TextBox();
            this.lblGuidCharge = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.errSetupSetting = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbMainLocation = new RMS.ColumnComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSetupSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainLocation
            // 
            this.lblMainLocation.AutoSize = true;
            this.lblMainLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblMainLocation.Location = new System.Drawing.Point(12, 47);
            this.lblMainLocation.Name = "lblMainLocation";
            this.lblMainLocation.Size = new System.Drawing.Size(91, 16);
            this.lblMainLocation.TabIndex = 35;
            this.lblMainLocation.Text = "Main Location";
            // 
            // txtServiceCharge
            // 
            this.txtServiceCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceCharge.Location = new System.Drawing.Point(118, 82);
            this.txtServiceCharge.Name = "txtServiceCharge";
            this.txtServiceCharge.Size = new System.Drawing.Size(145, 21);
            this.txtServiceCharge.TabIndex = 34;
            this.txtServiceCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblServiceCharge
            // 
            this.lblServiceCharge.AutoSize = true;
            this.lblServiceCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCharge.Location = new System.Drawing.Point(12, 85);
            this.lblServiceCharge.Name = "lblServiceCharge";
            this.lblServiceCharge.Size = new System.Drawing.Size(101, 16);
            this.lblServiceCharge.TabIndex = 33;
            this.lblServiceCharge.Text = "Service Charge";
            // 
            // txtVat
            // 
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.Location = new System.Drawing.Point(118, 117);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(145, 21);
            this.txtVat.TabIndex = 38;
            this.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(12, 120);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(35, 16);
            this.lblVat.TabIndex = 37;
            this.lblVat.Text = "VAT";
            // 
            // txtGuidCharge
            // 
            this.txtGuidCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuidCharge.Location = new System.Drawing.Point(118, 152);
            this.txtGuidCharge.Name = "txtGuidCharge";
            this.txtGuidCharge.Size = new System.Drawing.Size(145, 21);
            this.txtGuidCharge.TabIndex = 40;
            this.txtGuidCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGuidCharge
            // 
            this.lblGuidCharge.AutoSize = true;
            this.lblGuidCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuidCharge.Location = new System.Drawing.Point(12, 155);
            this.lblGuidCharge.Name = "lblGuidCharge";
            this.lblGuidCharge.Size = new System.Drawing.Size(83, 16);
            this.lblGuidCharge.TabIndex = 39;
            this.lblGuidCharge.Text = "Guid Charge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(269, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(269, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(269, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "%";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(196, 185);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(115, 185);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(34, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 31);
            this.panel1.TabIndex = 50;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 16);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Setup Setting";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.btnExit.Location = new System.Drawing.Point(268, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel2.Location = new System.Drawing.Point(304, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 207);
            this.panel2.TabIndex = 51;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel3.Location = new System.Drawing.Point(-9, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 207);
            this.panel3.TabIndex = 52;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel4.Location = new System.Drawing.Point(0, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 10);
            this.panel4.TabIndex = 53;
            // 
            // errSetupSetting
            // 
            this.errSetupSetting.ContainerControl = this;
            // 
            // cmbMainLocation
            // 
            this.cmbMainLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMainLocation.DropDownWidth = 17;
            this.cmbMainLocation.FormattingEnabled = true;
            this.cmbMainLocation.Location = new System.Drawing.Point(118, 46);
            this.cmbMainLocation.Name = "cmbMainLocation";
            this.cmbMainLocation.Size = new System.Drawing.Size(171, 21);
            this.cmbMainLocation.TabIndex = 36;
            this.cmbMainLocation.ViewColumn = 0;
            this.cmbMainLocation.SelectedIndexChanged += new System.EventHandler(this.cmbMainLocation_SelectedIndexChanged);
            // 
            // frmSetupSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(305, 234);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGuidCharge);
            this.Controls.Add(this.lblGuidCharge);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.cmbMainLocation);
            this.Controls.Add(this.lblMainLocation);
            this.Controls.Add(this.txtServiceCharge);
            this.Controls.Add(this.lblServiceCharge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetupSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup Setting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSetupSetting)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ErrorProvider errSetupSetting;
    }
}