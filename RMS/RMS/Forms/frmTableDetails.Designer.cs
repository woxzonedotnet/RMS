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
            this.cmbStatus = new RMS.ColumnComboBox();
            this.cmbTableLocation = new RMS.ColumnComboBox();
            this.cmbTableCategory = new RMS.ColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::RMS.Properties.Resources._1498666014_basics_19;
            this.btnSearch.Location = new System.Drawing.Point(289, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTableCode
            // 
            this.txtTableCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableCode.Location = new System.Drawing.Point(133, 46);
            this.txtTableCode.Name = "txtTableCode";
            this.txtTableCode.Size = new System.Drawing.Size(150, 21);
            this.txtTableCode.TabIndex = 19;
            // 
            // lblTableCode
            // 
            this.lblTableCode.AutoSize = true;
            this.lblTableCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableCode.Location = new System.Drawing.Point(23, 47);
            this.lblTableCode.Name = "lblTableCode";
            this.lblTableCode.Size = new System.Drawing.Size(65, 16);
            this.lblTableCode.TabIndex = 18;
            this.lblTableCode.Text = "Table No";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(23, 13);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(102, 16);
            this.lblTable.TabIndex = 24;
            this.lblTable.Text = "Table Category";
            // 
            // lblTableLocation
            // 
            this.lblTableLocation.AutoSize = true;
            this.lblTableLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableLocation.Location = new System.Drawing.Point(23, 81);
            this.lblTableLocation.Name = "lblTableLocation";
            this.lblTableLocation.Size = new System.Drawing.Size(98, 16);
            this.lblTableLocation.TabIndex = 25;
            this.lblTableLocation.Text = "Table Location";
            // 
            // lblNoOfSeats
            // 
            this.lblNoOfSeats.AutoSize = true;
            this.lblNoOfSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfSeats.Location = new System.Drawing.Point(23, 114);
            this.lblNoOfSeats.Name = "lblNoOfSeats";
            this.lblNoOfSeats.Size = new System.Drawing.Size(80, 16);
            this.lblNoOfSeats.TabIndex = 26;
            this.lblNoOfSeats.Text = "No Of Seats";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(257, 183);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(176, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(14, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(95, 183);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // nudNoOfSeats
            // 
            this.nudNoOfSeats.Location = new System.Drawing.Point(133, 114);
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
            this.label1.Location = new System.Drawing.Point(23, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Status";
            // 
            // errTable
            // 
            this.errTable.ContainerControl = this;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbStatus.DropDownWidth = 17;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(133, 147);
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
            this.cmbTableLocation.Location = new System.Drawing.Point(133, 80);
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
            this.cmbTableCategory.Location = new System.Drawing.Point(133, 12);
            this.cmbTableCategory.Name = "cmbTableCategory";
            this.cmbTableCategory.Size = new System.Drawing.Size(191, 21);
            this.cmbTableCategory.TabIndex = 21;
            this.cmbTableCategory.ViewColumn = 0;
            // 
            // frmTableDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 228);
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
            this.Name = "frmTableDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Details";
            this.Load += new System.EventHandler(this.frmTableDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTable)).EndInit();
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
    }
}