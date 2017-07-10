namespace RMS.Forms
{
    partial class frmSubLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubLocation));
            this.lblLocationCode = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.txtSubLocationCode = new System.Windows.Forms.TextBox();
            this.txtSubLocationName = new System.Windows.Forms.TextBox();
            this.chkShowInFrontEnd = new System.Windows.Forms.CheckBox();
            this.chkIsOrderLocation = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errSubLocation = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbStatus = new RMS.ColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errSubLocation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocationCode
            // 
            this.lblLocationCode.AutoSize = true;
            this.lblLocationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationCode.Location = new System.Drawing.Point(14, 60);
            this.lblLocationCode.Name = "lblLocationCode";
            this.lblLocationCode.Size = new System.Drawing.Size(95, 16);
            this.lblLocationCode.TabIndex = 0;
            this.lblLocationCode.Text = "Location Code";
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.Location = new System.Drawing.Point(14, 96);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(99, 16);
            this.lblLocationName.TabIndex = 1;
            this.lblLocationName.Text = "Location Name";
            // 
            // txtSubLocationCode
            // 
            this.txtSubLocationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubLocationCode.Location = new System.Drawing.Point(115, 57);
            this.txtSubLocationCode.Name = "txtSubLocationCode";
            this.txtSubLocationCode.Size = new System.Drawing.Size(166, 21);
            this.txtSubLocationCode.TabIndex = 2;
            // 
            // txtSubLocationName
            // 
            this.txtSubLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubLocationName.Location = new System.Drawing.Point(115, 93);
            this.txtSubLocationName.Name = "txtSubLocationName";
            this.txtSubLocationName.Size = new System.Drawing.Size(207, 21);
            this.txtSubLocationName.TabIndex = 3;
            // 
            // chkShowInFrontEnd
            // 
            this.chkShowInFrontEnd.AutoSize = true;
            this.chkShowInFrontEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowInFrontEnd.Location = new System.Drawing.Point(115, 123);
            this.chkShowInFrontEnd.Name = "chkShowInFrontEnd";
            this.chkShowInFrontEnd.Size = new System.Drawing.Size(133, 20);
            this.chkShowInFrontEnd.TabIndex = 4;
            this.chkShowInFrontEnd.Text = "Show In Front End";
            this.chkShowInFrontEnd.UseVisualStyleBackColor = true;
            // 
            // chkIsOrderLocation
            // 
            this.chkIsOrderLocation.AutoSize = true;
            this.chkIsOrderLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsOrderLocation.Location = new System.Drawing.Point(115, 146);
            this.chkIsOrderLocation.Name = "chkIsOrderLocation";
            this.chkIsOrderLocation.Size = new System.Drawing.Size(128, 20);
            this.chkIsOrderLocation.TabIndex = 5;
            this.chkIsOrderLocation.Text = "Is Order Location";
            this.chkIsOrderLocation.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(12, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(174, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 37);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(255, 225);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 37);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errSubLocation
            // 
            this.errSubLocation.ContainerControl = this;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Image = global::RMS.Properties.Resources.search25;
            this.btnSearch.Location = new System.Drawing.Point(287, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(345, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 37);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(93, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 37);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblFormTitle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 31);
            this.panel1.TabIndex = 35;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.btnExit.Location = new System.Drawing.Point(300, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFormTitle.Location = new System.Drawing.Point(13, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(0, 16);
            this.lblFormTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(12, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 16);
            this.lblTitle.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel3.Location = new System.Drawing.Point(-9, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 246);
            this.panel3.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel2.Location = new System.Drawing.Point(336, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 246);
            this.panel2.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel4.Location = new System.Drawing.Point(0, 268);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 10);
            this.panel4.TabIndex = 37;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbStatus.DropDownWidth = 17;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(115, 179);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(128, 21);
            this.cmbStatus.TabIndex = 14;
            this.cmbStatus.ViewColumn = 0;
            // 
            // frmSubLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 269);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkIsOrderLocation);
            this.Controls.Add(this.chkShowInFrontEnd);
            this.Controls.Add(this.txtSubLocationName);
            this.Controls.Add(this.txtSubLocationCode);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.lblLocationCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmSubLocation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub Location";
            this.Load += new System.EventHandler(this.frmSubLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errSubLocation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocationCode;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.TextBox txtSubLocationCode;
        private System.Windows.Forms.TextBox txtSubLocationName;
        private System.Windows.Forms.CheckBox chkShowInFrontEnd;
        private System.Windows.Forms.CheckBox chkIsOrderLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errSubLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private ColumnComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Button btnExit;
    }
}