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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankCards));
            this.lblCardCode = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.lblCardType = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblCommision = new System.Windows.Forms.Label();
            this.lblPresentage = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCardCode = new System.Windows.Forms.TextBox();
            this.txtCommision = new System.Windows.Forms.TextBox();
            this.lblActiveStatus = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errBankCard = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbCardType = new RMS.ColumnComboBox();
            this.cmbStatus = new RMS.ColumnComboBox();
            this.cmbBankName = new RMS.ColumnComboBox();
            this.cmbCurrency = new RMS.ColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errBankCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCardCode
            // 
            this.lblCardCode.AutoSize = true;
            this.lblCardCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCardCode.Location = new System.Drawing.Point(35, 26);
            this.lblCardCode.Name = "lblCardCode";
            this.lblCardCode.Size = new System.Drawing.Size(73, 16);
            this.lblCardCode.TabIndex = 0;
            this.lblCardCode.Text = "Card Code";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCardName.Location = new System.Drawing.Point(35, 62);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(79, 16);
            this.lblCardName.TabIndex = 1;
            this.lblCardName.Text = "Bank Name";
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCardType.Location = new System.Drawing.Point(35, 98);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(72, 16);
            this.lblCardType.TabIndex = 2;
            this.lblCardType.Text = "Card Type";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCurrency.Location = new System.Drawing.Point(35, 135);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(61, 16);
            this.lblCurrency.TabIndex = 3;
            this.lblCurrency.Text = "Currency";
            // 
            // lblCommision
            // 
            this.lblCommision.AutoSize = true;
            this.lblCommision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCommision.Location = new System.Drawing.Point(35, 173);
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCardCode
            // 
            this.txtCardCode.Location = new System.Drawing.Point(132, 25);
            this.txtCardCode.Name = "txtCardCode";
            this.txtCardCode.Size = new System.Drawing.Size(182, 20);
            this.txtCardCode.TabIndex = 11;
            // 
            // txtCommision
            // 
            this.txtCommision.Location = new System.Drawing.Point(132, 172);
            this.txtCommision.Name = "txtCommision";
            this.txtCommision.Size = new System.Drawing.Size(182, 20);
            this.txtCommision.TabIndex = 14;
            // 
            // lblActiveStatus
            // 
            this.lblActiveStatus.AutoSize = true;
            this.lblActiveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveStatus.Location = new System.Drawing.Point(35, 210);
            this.lblActiveStatus.Name = "lblActiveStatus";
            this.lblActiveStatus.Size = new System.Drawing.Size(85, 16);
            this.lblActiveStatus.TabIndex = 53;
            this.lblActiveStatus.Text = "Active Status";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClose.Location = new System.Drawing.Point(280, 245);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClear.Location = new System.Drawing.Point(199, 245);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnUpdate.Location = new System.Drawing.Point(118, 245);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSave.Location = new System.Drawing.Point(37, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errBankCard
            // 
            this.errBankCard.ContainerControl = this;
            // 
            // cmbCardType
            // 
            this.cmbCardType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCardType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCardType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCardType.DropDownWidth = 17;
            this.cmbCardType.FormattingEnabled = true;
            this.cmbCardType.Location = new System.Drawing.Point(132, 97);
            this.cmbCardType.Name = "cmbCardType";
            this.cmbCardType.Size = new System.Drawing.Size(182, 21);
            this.cmbCardType.TabIndex = 58;
            this.cmbCardType.ViewColumn = 0;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbStatus.DropDownWidth = 17;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(132, 209);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(131, 21);
            this.cmbStatus.TabIndex = 52;
            this.cmbStatus.ViewColumn = 0;
            // 
            // cmbBankName
            // 
            this.cmbBankName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBankName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBankName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBankName.DropDownWidth = 17;
            this.cmbBankName.FormattingEnabled = true;
            this.cmbBankName.Location = new System.Drawing.Point(132, 61);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.Size = new System.Drawing.Size(182, 21);
            this.cmbBankName.TabIndex = 19;
            this.cmbBankName.ViewColumn = 0;
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
            // frmBankCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 297);
            this.Controls.Add(this.cmbCardType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblActiveStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbBankName);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.txtCommision);
            this.Controls.Add(this.txtCardCode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPresentage);
            this.Controls.Add(this.lblCommision);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblCardType);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.lblCardCode);
            this.Name = "frmBankCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Cards";
            this.Load += new System.EventHandler(this.frmBankCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errBankCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardCode;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblCommision;
        private System.Windows.Forms.Label lblPresentage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCardCode;
        private System.Windows.Forms.TextBox txtCommision;
        private ColumnComboBox cmbCurrency;
        private ColumnComboBox cmbBankName;
        private System.Windows.Forms.Label lblActiveStatus;
        private ColumnComboBox cmbStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errBankCard;
        private ColumnComboBox cmbCardType;
    }
}