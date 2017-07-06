namespace RMS.Forms
{
    partial class frmMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoryDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStewardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategoryDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableCategoryDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.bankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterDataToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.processToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(843, 35);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 31);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierCategoryToolStripMenuItem,
            this.supplierDetailsToolStripMenuItem,
            this.departmentDetailsToolStripMenuItem,
            this.categoryDetailsToolStripMenuItem,
            this.subCategoryDetailsToolStripMenuItem,
            this.locationDetailsToolStripMenuItem,
            this.itemDetailsToolStripMenuItem,
            this.addStewardToolStripMenuItem,
            this.customerDetailsToolStripMenuItem,
            this.menuDepartmentToolStripMenuItem,
            this.menuCategoryDetailsToolStripMenuItem,
            this.recipeDetailsToolStripMenuItem,
            this.menuDetailsToolStripMenuItem,
            this.tableCategoryDetailsToolStripMenuItem,
            this.tableDetailsToolStripMenuItem,
            this.bankToolStripMenuItem,
            this.bankCardsToolStripMenuItem,
            this.setupSettingsToolStripMenuItem});
            this.masterDataToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(82, 31);
            this.masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // supplierCategoryToolStripMenuItem
            // 
            this.supplierCategoryToolStripMenuItem.Name = "supplierCategoryToolStripMenuItem";
            this.supplierCategoryToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.supplierCategoryToolStripMenuItem.Text = "Supplier Category";
            this.supplierCategoryToolStripMenuItem.Click += new System.EventHandler(this.supplierCategoryToolStripMenuItem_Click);
            // 
            // supplierDetailsToolStripMenuItem
            // 
            this.supplierDetailsToolStripMenuItem.Name = "supplierDetailsToolStripMenuItem";
            this.supplierDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.supplierDetailsToolStripMenuItem.Text = "Supplier Details";
            this.supplierDetailsToolStripMenuItem.Click += new System.EventHandler(this.supplierDetailsToolStripMenuItem_Click);
            // 
            // departmentDetailsToolStripMenuItem
            // 
            this.departmentDetailsToolStripMenuItem.Name = "departmentDetailsToolStripMenuItem";
            this.departmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.departmentDetailsToolStripMenuItem.Text = "Department Details";
            this.departmentDetailsToolStripMenuItem.Click += new System.EventHandler(this.departmentDetailsToolStripMenuItem_Click);
            // 
            // categoryDetailsToolStripMenuItem
            // 
            this.categoryDetailsToolStripMenuItem.Name = "categoryDetailsToolStripMenuItem";
            this.categoryDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.categoryDetailsToolStripMenuItem.Text = "Category Details";
            this.categoryDetailsToolStripMenuItem.Click += new System.EventHandler(this.categoryDetailsToolStripMenuItem_Click);
            // 
            // subCategoryDetailsToolStripMenuItem
            // 
            this.subCategoryDetailsToolStripMenuItem.Name = "subCategoryDetailsToolStripMenuItem";
            this.subCategoryDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.subCategoryDetailsToolStripMenuItem.Text = "Sub Category Details";
            this.subCategoryDetailsToolStripMenuItem.Click += new System.EventHandler(this.subCategoryDetailsToolStripMenuItem_Click);
            // 
            // locationDetailsToolStripMenuItem
            // 
            this.locationDetailsToolStripMenuItem.Name = "locationDetailsToolStripMenuItem";
            this.locationDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.locationDetailsToolStripMenuItem.Text = "Location Details";
            this.locationDetailsToolStripMenuItem.Click += new System.EventHandler(this.locationDetailsToolStripMenuItem_Click);
            // 
            // itemDetailsToolStripMenuItem
            // 
            this.itemDetailsToolStripMenuItem.Name = "itemDetailsToolStripMenuItem";
            this.itemDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.itemDetailsToolStripMenuItem.Text = "Item Details";
            this.itemDetailsToolStripMenuItem.Click += new System.EventHandler(this.itemDetailsToolStripMenuItem_Click);
            // 
            // addStewardToolStripMenuItem
            // 
            this.addStewardToolStripMenuItem.Name = "addStewardToolStripMenuItem";
            this.addStewardToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addStewardToolStripMenuItem.Text = "Add Steward";
            this.addStewardToolStripMenuItem.Click += new System.EventHandler(this.addStewardToolStripMenuItem_Click);
            // 
            // customerDetailsToolStripMenuItem
            // 
            this.customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            this.customerDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.customerDetailsToolStripMenuItem.Text = "Customer Details";
            this.customerDetailsToolStripMenuItem.Click += new System.EventHandler(this.customerDetailsToolStripMenuItem_Click);
            // 
            // menuDepartmentToolStripMenuItem
            // 
            this.menuDepartmentToolStripMenuItem.Name = "menuDepartmentToolStripMenuItem";
            this.menuDepartmentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.menuDepartmentToolStripMenuItem.Text = "Menu Department";
            this.menuDepartmentToolStripMenuItem.Click += new System.EventHandler(this.menuDepartmentToolStripMenuItem_Click);
            // 
            // menuCategoryDetailsToolStripMenuItem
            // 
            this.menuCategoryDetailsToolStripMenuItem.Name = "menuCategoryDetailsToolStripMenuItem";
            this.menuCategoryDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.menuCategoryDetailsToolStripMenuItem.Text = "Menu Category Details";
            this.menuCategoryDetailsToolStripMenuItem.Click += new System.EventHandler(this.menuCategoryDetailsToolStripMenuItem_Click);
            // 
            // recipeDetailsToolStripMenuItem
            // 
            this.recipeDetailsToolStripMenuItem.Name = "recipeDetailsToolStripMenuItem";
            this.recipeDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.recipeDetailsToolStripMenuItem.Text = "Recipe Details";
            this.recipeDetailsToolStripMenuItem.Click += new System.EventHandler(this.recipeDetailsToolStripMenuItem_Click);
            // 
            // menuDetailsToolStripMenuItem
            // 
            this.menuDetailsToolStripMenuItem.Name = "menuDetailsToolStripMenuItem";
            this.menuDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.menuDetailsToolStripMenuItem.Text = "Menu Details";
            this.menuDetailsToolStripMenuItem.Click += new System.EventHandler(this.menuDetailsToolStripMenuItem_Click);
            // 
            // tableCategoryDetailsToolStripMenuItem
            // 
            this.tableCategoryDetailsToolStripMenuItem.Name = "tableCategoryDetailsToolStripMenuItem";
            this.tableCategoryDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.tableCategoryDetailsToolStripMenuItem.Text = "Table Category Details";
            this.tableCategoryDetailsToolStripMenuItem.Click += new System.EventHandler(this.tableCategoryDetailsToolStripMenuItem_Click);
            // 
            // tableDetailsToolStripMenuItem
            // 
            this.tableDetailsToolStripMenuItem.Name = "tableDetailsToolStripMenuItem";
            this.tableDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.tableDetailsToolStripMenuItem.Text = "Table Details";
            this.tableDetailsToolStripMenuItem.Click += new System.EventHandler(this.tableDetailsToolStripMenuItem_Click);
            // 
            // bankCardsToolStripMenuItem
            // 
            this.bankCardsToolStripMenuItem.Name = "bankCardsToolStripMenuItem";
            this.bankCardsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.bankCardsToolStripMenuItem.Text = "Bank Cards";
            this.bankCardsToolStripMenuItem.Click += new System.EventHandler(this.bankCardsToolStripMenuItem_Click);
            // 
            // setupSettingsToolStripMenuItem
            // 
            this.setupSettingsToolStripMenuItem.Name = "setupSettingsToolStripMenuItem";
            this.setupSettingsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.setupSettingsToolStripMenuItem.Text = "Setup Settings";
            this.setupSettingsToolStripMenuItem.Click += new System.EventHandler(this.setupSettingsToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaToolStripMenuItem});
            this.transactionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(80, 31);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // aaToolStripMenuItem
            // 
            this.aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            this.aaToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.aaToolStripMenuItem.Text = "aa";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssToolStripMenuItem});
            this.processToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 31);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // ssToolStripMenuItem
            // 
            this.ssToolStripMenuItem.Name = "ssToolStripMenuItem";
            this.ssToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.ssToolStripMenuItem.Text = "ss";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 31);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // ddToolStripMenuItem
            // 
            this.ddToolStripMenuItem.Name = "ddToolStripMenuItem";
            this.ddToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.ddToolStripMenuItem.Text = "dd";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ffToolStripMenuItem});
            this.userToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.userToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 31);
            this.userToolStripMenuItem.Text = "User";
            // 
            // ffToolStripMenuItem
            // 
            this.ffToolStripMenuItem.Name = "ffToolStripMenuItem";
            this.ffToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.ffToolStripMenuItem.Text = "ff";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.button1.Location = new System.Drawing.Point(806, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.menuStripMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 35);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.button3.Location = new System.Drawing.Point(769, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "_";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bankToolStripMenuItem
            // 
            this.bankToolStripMenuItem.Name = "bankToolStripMenuItem";
            this.bankToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.bankToolStripMenuItem.Text = "Bank Details";
            this.bankToolStripMenuItem.Click += new System.EventHandler(this.bankToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(843, 361);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Restaurants Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoryDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStewardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCategoryDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableCategoryDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankToolStripMenuItem;
    }
}