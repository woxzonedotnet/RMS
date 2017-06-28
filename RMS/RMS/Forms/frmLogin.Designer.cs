namespace RMS
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gboxLogin = new System.Windows.Forms.GroupBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCloseX = new System.Windows.Forms.Button();
            this.cmbLocation = new RMS.ColumnComboBox();
            this.cmbUserType = new RMS.ColumnComboBox();
            this.gboxLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(124, 53);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(204, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(124, 81);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(204, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(283, 144);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(43, 56);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(43, 84);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // gboxLogin
            // 
            this.gboxLogin.Controls.Add(this.btnLogin);
            this.gboxLogin.Controls.Add(this.lblLocation);
            this.gboxLogin.Controls.Add(this.btnClose);
            this.gboxLogin.Controls.Add(this.lblUserType);
            this.gboxLogin.Controls.Add(this.cmbLocation);
            this.gboxLogin.Controls.Add(this.lblUserName);
            this.gboxLogin.Controls.Add(this.cmbUserType);
            this.gboxLogin.Controls.Add(this.lblPassword);
            this.gboxLogin.Controls.Add(this.txtUserName);
            this.gboxLogin.Controls.Add(this.txtPassword);
            this.gboxLogin.Location = new System.Drawing.Point(12, 41);
            this.gboxLogin.Name = "gboxLogin";
            this.gboxLogin.Size = new System.Drawing.Size(373, 181);
            this.gboxLogin.TabIndex = 7;
            this.gboxLogin.TabStop = false;
            this.gboxLogin.Text = "User Login";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(43, 27);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(56, 13);
            this.lblUserType.TabIndex = 7;
            this.lblUserType.Text = "User Type";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(43, 113);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 8;
            this.lblLocation.Text = "Location";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnCloseX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 35);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 36);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 26);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(192, 144);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCloseX
            // 
            this.btnCloseX.FlatAppearance.BorderSize = 0;
            this.btnCloseX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.btnCloseX.Location = new System.Drawing.Point(368, 4);
            this.btnCloseX.Name = "btnCloseX";
            this.btnCloseX.Size = new System.Drawing.Size(23, 28);
            this.btnCloseX.TabIndex = 1;
            this.btnCloseX.Text = "X";
            this.btnCloseX.UseVisualStyleBackColor = true;
            this.btnCloseX.Click += new System.EventHandler(this.btnCloseX_Click);
            // 
            // cmbLocation
            // 
            this.cmbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLocation.DropDownWidth = 17;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(124, 110);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(204, 21);
            this.cmbLocation.TabIndex = 3;
            this.cmbLocation.ViewColumn = 0;
            // 
            // cmbUserType
            // 
            this.cmbUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbUserType.DropDownWidth = 17;
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Location = new System.Drawing.Point(124, 24);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(204, 21);
            this.cmbUserType.TabIndex = 2;
            this.cmbUserType.ViewColumn = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 267);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gboxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gboxLogin.ResumeLayout(false);
            this.gboxLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private ColumnComboBox cmbUserType;
        private ColumnComboBox cmbLocation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox gboxLogin;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCloseX;
    }
}

