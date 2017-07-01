namespace RMS.Forms
{
    partial class frmRecipeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipeDetails));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRecipeCost = new System.Windows.Forms.TextBox();
            this.lblRecipeCost = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbLocation = new RMS.ColumnComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmbOrderType = new RMS.ColumnComboBox();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.txtFullDescription = new System.Windows.Forms.TextBox();
            this.lblFullDescription = new System.Windows.Forms.Label();
            this.txtRecipeCode = new System.Windows.Forms.TextBox();
            this.lblRecipeCode = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(526, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(445, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(364, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtRecipeCost
            // 
            this.txtRecipeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeCost.Location = new System.Drawing.Point(445, 317);
            this.txtRecipeCost.Name = "txtRecipeCost";
            this.txtRecipeCost.Size = new System.Drawing.Size(150, 21);
            this.txtRecipeCost.TabIndex = 37;
            // 
            // lblRecipeCost
            // 
            this.lblRecipeCost.AutoSize = true;
            this.lblRecipeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeCost.Location = new System.Drawing.Point(345, 320);
            this.lblRecipeCost.Name = "lblRecipeCost";
            this.lblRecipeCost.Size = new System.Drawing.Size(82, 16);
            this.lblRecipeCost.TabIndex = 36;
            this.lblRecipeCost.Text = "Recipe Cost";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 192);
            this.dataGridView1.TabIndex = 35;
            // 
            // cmbLocation
            // 
            this.cmbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbLocation.DropDownWidth = 17;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(115, 83);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(150, 21);
            this.cmbLocation.TabIndex = 34;
            this.cmbLocation.ViewColumn = 0;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblLocation.Location = new System.Drawing.Point(15, 84);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(59, 16);
            this.lblLocation.TabIndex = 33;
            this.lblLocation.Text = "Location";
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbOrderType.DropDownWidth = 17;
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Location = new System.Drawing.Point(115, 48);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(150, 21);
            this.cmbOrderType.TabIndex = 32;
            this.cmbOrderType.ViewColumn = 0;
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblOrderType.Location = new System.Drawing.Point(15, 49);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(77, 16);
            this.lblOrderType.TabIndex = 31;
            this.lblOrderType.Text = "Order Type";
            // 
            // txtFullDescription
            // 
            this.txtFullDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullDescription.Location = new System.Drawing.Point(423, 13);
            this.txtFullDescription.Multiline = true;
            this.txtFullDescription.Name = "txtFullDescription";
            this.txtFullDescription.Size = new System.Drawing.Size(186, 87);
            this.txtFullDescription.TabIndex = 30;
            // 
            // lblFullDescription
            // 
            this.lblFullDescription.AutoSize = true;
            this.lblFullDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullDescription.Location = new System.Drawing.Point(317, 16);
            this.lblFullDescription.Name = "lblFullDescription";
            this.lblFullDescription.Size = new System.Drawing.Size(100, 16);
            this.lblFullDescription.TabIndex = 29;
            this.lblFullDescription.Text = "Full Description";
            // 
            // txtRecipeCode
            // 
            this.txtRecipeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeCode.Location = new System.Drawing.Point(115, 13);
            this.txtRecipeCode.Name = "txtRecipeCode";
            this.txtRecipeCode.Size = new System.Drawing.Size(150, 21);
            this.txtRecipeCode.TabIndex = 27;
            // 
            // lblRecipeCode
            // 
            this.lblRecipeCode.AutoSize = true;
            this.lblRecipeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeCode.Location = new System.Drawing.Point(15, 16);
            this.lblRecipeCode.Name = "lblRecipeCode";
            this.lblRecipeCode.Size = new System.Drawing.Size(88, 16);
            this.lblRecipeCode.TabIndex = 26;
            this.lblRecipeCode.Text = "Recipe Code";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::RMS.Properties.Resources._1498666014_basics_19;
            this.btnSearch.Location = new System.Drawing.Point(271, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 396);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRecipeCost);
            this.Controls.Add(this.lblRecipeCost);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.txtFullDescription);
            this.Controls.Add(this.lblFullDescription);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtRecipeCode);
            this.Controls.Add(this.lblRecipeCode);
            this.Name = "Form3";
            this.Text = "Recipe Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRecipeCost;
        private System.Windows.Forms.Label lblRecipeCost;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ColumnComboBox cmbLocation;
        private System.Windows.Forms.Label lblLocation;
        private ColumnComboBox cmbOrderType;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.TextBox txtFullDescription;
        private System.Windows.Forms.Label lblFullDescription;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRecipeCode;
        private System.Windows.Forms.Label lblRecipeCode;
    }
}