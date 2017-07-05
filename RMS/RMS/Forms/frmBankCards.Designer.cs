namespace RMS.Forms
{
    partial class frmBankCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankCards));
            this.lblCardCode = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.lblShowOrder = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblCommision = new System.Windows.Forms.Label();
            this.lblPresentage = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtShowOrder = new System.Windows.Forms.TextBox();
            this.txtCommision = new System.Windows.Forms.TextBox();
            this.cmbCurrency = new RMS.ColumnComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCardCode
            // 
            this.lblCardCode.AutoSize = true;
            this.lblCardCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCardCode.Location = new System.Drawing.Point(43, 26);
            this.lblCardCode.Name = "lblCardCode";
            this.lblCardCode.Size = new System.Drawing.Size(73, 16);
            this.lblCardCode.TabIndex = 0;
            this.lblCardCode.Text = "Card Code";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCardName.Location = new System.Drawing.Point(43, 62);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(77, 16);
            this.lblCardName.TabIndex = 1;
            this.lblCardName.Text = "Card Name";
            // 
            // lblShowOrder
            // 
            this.lblShowOrder.AutoSize = true;
            this.lblShowOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblShowOrder.Location = new System.Drawing.Point(43, 98);
            this.lblShowOrder.Name = "lblShowOrder";
            this.lblShowOrder.Size = new System.Drawing.Size(78, 16);
            this.lblShowOrder.TabIndex = 2;
            this.lblShowOrder.Text = "Show Order";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCurrency.Location = new System.Drawing.Point(43, 135);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(61, 16);
            this.lblCurrency.TabIndex = 3;
            this.lblCurrency.Text = "Currency";
            // 
            // lblCommision
            // 
            this.lblCommision.AutoSize = true;
            this.lblCommision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCommision.Location = new System.Drawing.Point(43, 173);
            this.lblCommision.Name = "lblCommision";
            this.lblCommision.Size = new System.Drawing.Size(75, 16);
            this.lblCommision.TabIndex = 4;
            this.lblCommision.Text = "Commision";
            // 
            // lblPresentage
            // 
            this.lblPresentage.AutoSize = true;
            this.lblPresentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblPresentage.Location = new System.Drawing.Point(316, 173);
            this.lblPresentage.Name = "lblPresentage";
            this.lblPresentage.Size = new System.Drawing.Size(20, 16);
            this.lblPresentage.TabIndex = 5;
            this.lblPresentage.Text = "%";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::RMS.Properties.Resources._1498666014_basics_19;
            this.btnSearch.Location = new System.Drawing.Point(320, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 31);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtCardCode
            // 
            this.txtCardCode.Location = new System.Drawing.Point(132, 25);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.Size = new System.Drawing.Size(182, 20);
            this.txtCardCode.TabIndex = 11;
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(132, 61);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(182, 20);
            this.txtCardName.TabIndex = 12;
            // 
            // txtShowOrder
            // 
            this.txtShowOrder.Location = new System.Drawing.Point(132, 97);
            this.txtShowOrder.Name = "txtShowOrder";
            this.txtShowOrder.Size = new System.Drawing.Size(182, 20);
            this.txtShowOrder.TabIndex = 13;
            // 
            // txtCommision
            // 
            this.txtCommision.Location = new System.Drawing.Point(132, 172);
            this.txtCommision.Name = "txtCommision";
            this.txtCommision.Size = new System.Drawing.Size(182, 20);
            this.txtCommision.TabIndex = 14;
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCurrency.DropDownWidth = 17;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(132, 134);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(182, 21);
            this.cmbCurrency.TabIndex = 15;
            this.cmbCurrency.ViewColumn = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(280, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(199, 208);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(118, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmBankCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 257);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.txtCommision);
            this.Controls.Add(this.txtShowOrder);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.txtCardCode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPresentage);
            this.Controls.Add(this.lblCommision);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblShowOrder);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.lblCardCode);
            this.Name = "frmBankCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Cards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardCode;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label lblShowOrder;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblCommision;
        private System.Windows.Forms.Label lblPresentage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtShowOrder;
        private System.Windows.Forms.TextBox txtCommision;
        private ColumnComboBox cmbCurrency;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}