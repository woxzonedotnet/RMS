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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableDetails));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTableNo = new System.Windows.Forms.TextBox();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.cmbTable = new RMS.ColumnComboBox();
            this.cmbTableLocation = new RMS.ColumnComboBox();
            this.txtNoOfSeats = new System.Windows.Forms.TextBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblTableLocation = new System.Windows.Forms.Label();
            this.lblNoOfSeats = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::RMS.Properties.Resources._1498666014_basics_19;
            this.btnSearch.Location = new System.Drawing.Point(289, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtTableNo
            // 
            this.txtTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableNo.Location = new System.Drawing.Point(133, 12);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.Size = new System.Drawing.Size(150, 21);
            this.txtTableNo.TabIndex = 19;
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNo.Location = new System.Drawing.Point(23, 15);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(65, 16);
            this.lblTableNo.TabIndex = 18;
            this.lblTableNo.Text = "Table No";
            // 
            // cmbTable
            // 
            this.cmbTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTable.DropDownWidth = 17;
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(133, 48);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(191, 21);
            this.cmbTable.TabIndex = 21;
            this.cmbTable.ViewColumn = 0;
            // 
            // cmbTableLocation
            // 
            this.cmbTableLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTableLocation.DropDownWidth = 17;
            this.cmbTableLocation.FormattingEnabled = true;
            this.cmbTableLocation.Location = new System.Drawing.Point(133, 85);
            this.cmbTableLocation.Name = "cmbTableLocation";
            this.cmbTableLocation.Size = new System.Drawing.Size(191, 21);
            this.cmbTableLocation.TabIndex = 22;
            this.cmbTableLocation.ViewColumn = 0;
            // 
            // txtNoOfSeats
            // 
            this.txtNoOfSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfSeats.Location = new System.Drawing.Point(133, 122);
            this.txtNoOfSeats.Name = "txtNoOfSeats";
            this.txtNoOfSeats.Size = new System.Drawing.Size(191, 21);
            this.txtNoOfSeats.TabIndex = 23;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(23, 49);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(44, 16);
            this.lblTable.TabIndex = 24;
            this.lblTable.Text = "Table";
            // 
            // lblTableLocation
            // 
            this.lblTableLocation.AutoSize = true;
            this.lblTableLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableLocation.Location = new System.Drawing.Point(23, 86);
            this.lblTableLocation.Name = "lblTableLocation";
            this.lblTableLocation.Size = new System.Drawing.Size(98, 16);
            this.lblTableLocation.TabIndex = 25;
            this.lblTableLocation.Text = "Table Location";
            // 
            // lblNoOfSeats
            // 
            this.lblNoOfSeats.AutoSize = true;
            this.lblNoOfSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfSeats.Location = new System.Drawing.Point(23, 125);
            this.lblNoOfSeats.Name = "lblNoOfSeats";
            this.lblNoOfSeats.Size = new System.Drawing.Size(80, 16);
            this.lblNoOfSeats.TabIndex = 26;
            this.lblNoOfSeats.Text = "No Of Seats";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(257, 155);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(176, 155);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(14, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(95, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 30;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmTableDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNoOfSeats);
            this.Controls.Add(this.lblTableLocation);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.txtNoOfSeats);
            this.Controls.Add(this.cmbTableLocation);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTableNo);
            this.Controls.Add(this.lblTableNo);
            this.Name = "frmTableDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.Label lblTableNo;
        private ColumnComboBox cmbTable;
        private ColumnComboBox cmbTableLocation;
        private System.Windows.Forms.TextBox txtNoOfSeats;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblTableLocation;
        private System.Windows.Forms.Label lblNoOfSeats;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
    }
}