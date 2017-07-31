namespace RMS.Forms
{
    partial class frmTableDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableDetails));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTableCode = new System.Windows.Forms.TextBox();
            this.lblTableCode = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblTableLocation = new System.Windows.Forms.Label();
            this.lblNoOfSeats = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.nudNoOfSeats = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.errTable = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.errSubLocation = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbStatus = new RMS.ColumnComboBox();
            this.cmbTableLocation = new RMS.ColumnComboBox();
            this.cmbTableCategory = new RMS.ColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSubLocation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSearch.Location = new System.Drawing.Point(289, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTableCode
            // 
            this.txtTableCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableCode.Location = new System.Drawing.Point(133, 75);
            this.txtTableCode.Name = "txtTableCode";
            this.txtTableCode.Size = new System.Drawing.Size(150, 21);
            this.txtTableCode.TabIndex = 19;
            this.txtTableCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTableCode_KeyDown);
            // 
            // lblTableCode
            // 
            this.lblTableCode.AutoSize = true;
            this.lblTableCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableCode.Location = new System.Drawing.Point(23, 76);
            this.lblTableCode.Name = "lblTableCode";
            this.lblTableCode.Size = new System.Drawing.Size(65, 16);
            this.lblTableCode.TabIndex = 18;
            this.lblTableCode.Text = "Table No";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(23, 42);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(102, 16);
            this.lblTable.TabIndex = 24;
            this.lblTable.Text = "Table Category";
            // 
            // lblTableLocation
            // 
            this.lblTableLocation.AutoSize = true;
            this.lblTableLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableLocation.Location = new System.Drawing.Point(23, 110);
            this.lblTableLocation.Name = "lblTableLocation";
            this.lblTableLocation.Size = new System.Drawing.Size(98, 16);
            this.lblTableLocation.TabIndex = 25;
            this.lblTableLocation.Text = "Table Location";
            // 
            // lblNoOfSeats
            // 
            this.lblNoOfSeats.AutoSize = true;
            this.lblNoOfSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfSeats.Location = new System.Drawing.Point(23, 143);
            this.lblNoOfSeats.Name = "lblNoOfSeats";
            this.lblNoOfSeats.Size = new System.Drawing.Size(80, 16);
            this.lblNoOfSeats.TabIndex = 26;
            this.lblNoOfSeats.Text = "No Of Seats";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(257, 212);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 29;
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
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(176, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 28;
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
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(14, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(95, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // nudNoOfSeats
            // 
            this.nudNoOfSeats.Location = new System.Drawing.Point(133, 143);
            this.nudNoOfSeats.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNoOfSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfSeats.Name = "nudNoOfSeats";
            this.nudNoOfSeats.Size = new System.Drawing.Size(109, 20);
            this.nudNoOfSeats.TabIndex = 31;
            this.nudNoOfSeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Status";
            // 
            // errTable
            // 
            this.errTable.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel3.Location = new System.Drawing.Point(-9, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 230);
            this.panel3.TabIndex = 38;
            // 
            // errSubLocation
            // 
            this.errSubLocation.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblFormTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 31);
            this.panel1.TabIndex = 37;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.btnExit.Location = new System.Drawing.Point(309, 0);
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
            this.lblFormTitle.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel2.Location = new System.Drawing.Point(345, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 231);
            this.panel2.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel4.Location = new System.Drawing.Point(0, 257);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 10);
            this.panel4.TabIndex = 39;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbStatus.DropDownWidth = 17;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(133, 176);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(109, 21);
            this.cmbStatus.TabIndex = 33;
            this.cmbStatus.ViewColumn = 0;
            // 
            // cmbTableLocation
            // 
            this.cmbTableLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTableLocation.DropDownWidth = 17;
            this.cmbTableLocation.FormattingEnabled = true;
            this.cmbTableLocation.Location = new System.Drawing.Point(133, 109);
            this.cmbTableLocation.Name = "cmbTableLocation";
            this.cmbTableLocation.Size = new System.Drawing.Size(191, 21);
            this.cmbTableLocation.TabIndex = 22;
            this.cmbTableLocation.ViewColumn = 0;
            // 
            // cmbTableCategory
            // 
            this.cmbTableCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTableCategory.DropDownWidth = 17;
            this.cmbTableCategory.FormattingEnabled = true;
            this.cmbTableCategory.Location = new System.Drawing.Point(133, 41);
            this.cmbTableCategory.Name = "cmbTableCategory";
            this.cmbTableCategory.Size = new System.Drawing.Size(191, 21);
            this.cmbTableCategory.TabIndex = 21;
            this.cmbTableCategory.ViewColumn = 0;
            // 
            // frmTableDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(346, 258);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNoOfSeats);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNoOfSeats);
            this.Controls.Add(this.lblTableLocation);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.cmbTableLocation);
            this.Controls.Add(this.cmbTableCategory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTableCode);
            this.Controls.Add(this.lblTableCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTableDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Details";
            this.Load += new System.EventHandler(this.frmTableDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSubLocation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTableCode;
        private System.Windows.Forms.Label lblTableCode;
        private ColumnComboBox cmbTableCategory;
        private ColumnComboBox cmbTableLocation;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblTableLocation;
        private System.Windows.Forms.Label lblNoOfSeats;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown nudNoOfSeats;
        private System.Windows.Forms.Label label1;
        private ColumnComboBox cmbStatus;
        private System.Windows.Forms.ErrorProvider errTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.ErrorProvider errSubLocation;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
    }
}