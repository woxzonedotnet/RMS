﻿namespace RMS.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.bankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsReciveNoteGRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierReturnNoteSRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockAjestmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRNCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInitializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDetailsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierDetailsReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeDetailsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDetailsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRNListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOListingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueNoteListingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStripMain.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterDataToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.processToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
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
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierCategoryToolStripMenuItem,
            this.supplierDetailsToolStripMenuItem,
            this.departmentDetailsToolStripMenuItem,
            this.categoryDetailsToolStripMenuItem,
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
            this.supplierCategoryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.supplierCategoryToolStripMenuItem.Enabled = false;
            this.supplierCategoryToolStripMenuItem.Name = "supplierCategoryToolStripMenuItem";
            this.supplierCategoryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.supplierCategoryToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.supplierCategoryToolStripMenuItem.Text = "Supplier Category";
            this.supplierCategoryToolStripMenuItem.Click += new System.EventHandler(this.supplierCategoryToolStripMenuItem_Click);
            // 
            // supplierDetailsToolStripMenuItem
            // 
            this.supplierDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.supplierDetailsToolStripMenuItem.Enabled = false;
            this.supplierDetailsToolStripMenuItem.Name = "supplierDetailsToolStripMenuItem";
            this.supplierDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.supplierDetailsToolStripMenuItem.Text = "Supplier Details";
            this.supplierDetailsToolStripMenuItem.Click += new System.EventHandler(this.supplierDetailsToolStripMenuItem_Click);
            // 
            // departmentDetailsToolStripMenuItem
            // 
            this.departmentDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.departmentDetailsToolStripMenuItem.Enabled = false;
            this.departmentDetailsToolStripMenuItem.Name = "departmentDetailsToolStripMenuItem";
            this.departmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.departmentDetailsToolStripMenuItem.Text = "Department Details";
            this.departmentDetailsToolStripMenuItem.Click += new System.EventHandler(this.departmentDetailsToolStripMenuItem_Click);
            // 
            // categoryDetailsToolStripMenuItem
            // 
            this.categoryDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.categoryDetailsToolStripMenuItem.Enabled = false;
            this.categoryDetailsToolStripMenuItem.Name = "categoryDetailsToolStripMenuItem";
            this.categoryDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.categoryDetailsToolStripMenuItem.Text = "Category Details";
            this.categoryDetailsToolStripMenuItem.Click += new System.EventHandler(this.categoryDetailsToolStripMenuItem_Click);
            // 
            // locationDetailsToolStripMenuItem
            // 
            this.locationDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.locationDetailsToolStripMenuItem.Enabled = false;
            this.locationDetailsToolStripMenuItem.Name = "locationDetailsToolStripMenuItem";
            this.locationDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.locationDetailsToolStripMenuItem.Text = "Location Details";
            this.locationDetailsToolStripMenuItem.Click += new System.EventHandler(this.locationDetailsToolStripMenuItem_Click);
            // 
            // itemDetailsToolStripMenuItem
            // 
            this.itemDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.itemDetailsToolStripMenuItem.Enabled = false;
            this.itemDetailsToolStripMenuItem.Name = "itemDetailsToolStripMenuItem";
            this.itemDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.itemDetailsToolStripMenuItem.Text = "Item Details";
            this.itemDetailsToolStripMenuItem.Click += new System.EventHandler(this.itemDetailsToolStripMenuItem_Click);
            // 
            // addStewardToolStripMenuItem
            // 
            this.addStewardToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addStewardToolStripMenuItem.Enabled = false;
            this.addStewardToolStripMenuItem.Name = "addStewardToolStripMenuItem";
            this.addStewardToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addStewardToolStripMenuItem.Text = "Add Steward";
            this.addStewardToolStripMenuItem.Click += new System.EventHandler(this.addStewardToolStripMenuItem_Click);
            // 
            // customerDetailsToolStripMenuItem
            // 
            this.customerDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.customerDetailsToolStripMenuItem.Enabled = false;
            this.customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            this.customerDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.customerDetailsToolStripMenuItem.Text = "Customer Details";
            this.customerDetailsToolStripMenuItem.Click += new System.EventHandler(this.customerDetailsToolStripMenuItem_Click);
            // 
            // menuDepartmentToolStripMenuItem
            // 
            this.menuDepartmentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuDepartmentToolStripMenuItem.Enabled = false;
            this.menuDepartmentToolStripMenuItem.Name = "menuDepartmentToolStripMenuItem";
            this.menuDepartmentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.menuDepartmentToolStripMenuItem.Text = "Menu Department";
            this.menuDepartmentToolStripMenuItem.Click += new System.EventHandler(this.menuDepartmentToolStripMenuItem_Click);
            // 
            // menuCategoryDetailsToolStripMenuItem
            // 
            this.menuCategoryDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuCategoryDetailsToolStripMenuItem.Enabled = false;
            this.menuCategoryDetailsToolStripMenuItem.Name = "menuCategoryDetailsToolStripMenuItem";
            this.menuCategoryDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.menuCategoryDetailsToolStripMenuItem.Text = "Menu Category Details";
            this.menuCategoryDetailsToolStripMenuItem.Click += new System.EventHandler(this.menuCategoryDetailsToolStripMenuItem_Click);
            // 
            // recipeDetailsToolStripMenuItem
            // 
            this.recipeDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.recipeDetailsToolStripMenuItem.Enabled = false;
            this.recipeDetailsToolStripMenuItem.Name = "recipeDetailsToolStripMenuItem";
            this.recipeDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.recipeDetailsToolStripMenuItem.Text = "Recipe Details";
            this.recipeDetailsToolStripMenuItem.Click += new System.EventHandler(this.recipeDetailsToolStripMenuItem_Click);
            // 
            // menuDetailsToolStripMenuItem
            // 
            this.menuDetailsToolStripMenuItem.Enabled = false;
            this.menuDetailsToolStripMenuItem.Name = "menuDetailsToolStripMenuItem";
            this.menuDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.menuDetailsToolStripMenuItem.Text = "Menu Details";
            this.menuDetailsToolStripMenuItem.Click += new System.EventHandler(this.menuDetailsToolStripMenuItem_Click);
            // 
            // tableCategoryDetailsToolStripMenuItem
            // 
            this.tableCategoryDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableCategoryDetailsToolStripMenuItem.Enabled = false;
            this.tableCategoryDetailsToolStripMenuItem.Name = "tableCategoryDetailsToolStripMenuItem";
            this.tableCategoryDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.tableCategoryDetailsToolStripMenuItem.Text = "Table Category Details";
            this.tableCategoryDetailsToolStripMenuItem.Click += new System.EventHandler(this.tableCategoryDetailsToolStripMenuItem_Click);
            // 
            // tableDetailsToolStripMenuItem
            // 
            this.tableDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableDetailsToolStripMenuItem.Enabled = false;
            this.tableDetailsToolStripMenuItem.Name = "tableDetailsToolStripMenuItem";
            this.tableDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.tableDetailsToolStripMenuItem.Text = "Table Details";
            this.tableDetailsToolStripMenuItem.Click += new System.EventHandler(this.tableDetailsToolStripMenuItem_Click);
            // 
            // bankToolStripMenuItem
            // 
            this.bankToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bankToolStripMenuItem.Enabled = false;
            this.bankToolStripMenuItem.Name = "bankToolStripMenuItem";
            this.bankToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.bankToolStripMenuItem.Text = "Bank Details";
            this.bankToolStripMenuItem.Click += new System.EventHandler(this.bankToolStripMenuItem_Click);
            // 
            // bankCardsToolStripMenuItem
            // 
            this.bankCardsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bankCardsToolStripMenuItem.Enabled = false;
            this.bankCardsToolStripMenuItem.Name = "bankCardsToolStripMenuItem";
            this.bankCardsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.bankCardsToolStripMenuItem.Text = "Bank Cards";
            this.bankCardsToolStripMenuItem.Click += new System.EventHandler(this.bankCardsToolStripMenuItem_Click);
            // 
            // setupSettingsToolStripMenuItem
            // 
            this.setupSettingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.setupSettingsToolStripMenuItem.Enabled = false;
            this.setupSettingsToolStripMenuItem.Name = "setupSettingsToolStripMenuItem";
            this.setupSettingsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.setupSettingsToolStripMenuItem.Text = "Setup Settings";
            this.setupSettingsToolStripMenuItem.Click += new System.EventHandler(this.setupSettingsToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaToolStripMenuItem,
            this.goodsReciveNoteGRNToolStripMenuItem,
            this.supplierReturnNoteSRNToolStripMenuItem,
            this.transferNoteToolStripMenuItem,
            this.stockAjestmentToolStripMenuItem,
            this.gRNCancelToolStripMenuItem,
            this.issuToolStripMenuItem,
            this.stockInitializeToolStripMenuItem});
            this.transactionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(69, 31);
            this.transactionToolStripMenuItem.Text = "Inventory";
            // 
            // aaToolStripMenuItem
            // 
            this.aaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.aaToolStripMenuItem.Enabled = false;
            this.aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            this.aaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.aaToolStripMenuItem.Text = "Purchase Order (PO)";
            this.aaToolStripMenuItem.Click += new System.EventHandler(this.aaToolStripMenuItem_Click);
            // 
            // goodsReciveNoteGRNToolStripMenuItem
            // 
            this.goodsReciveNoteGRNToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.goodsReciveNoteGRNToolStripMenuItem.Enabled = false;
            this.goodsReciveNoteGRNToolStripMenuItem.Name = "goodsReciveNoteGRNToolStripMenuItem";
            this.goodsReciveNoteGRNToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.goodsReciveNoteGRNToolStripMenuItem.Text = "Goods Receive Note (GRN)";
            this.goodsReciveNoteGRNToolStripMenuItem.Click += new System.EventHandler(this.goodsReciveNoteGRNToolStripMenuItem_Click);
            // 
            // supplierReturnNoteSRNToolStripMenuItem
            // 
            this.supplierReturnNoteSRNToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.supplierReturnNoteSRNToolStripMenuItem.Enabled = false;
            this.supplierReturnNoteSRNToolStripMenuItem.Name = "supplierReturnNoteSRNToolStripMenuItem";
            this.supplierReturnNoteSRNToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.supplierReturnNoteSRNToolStripMenuItem.Text = "Supplier Return Note (SRN)";
            this.supplierReturnNoteSRNToolStripMenuItem.Click += new System.EventHandler(this.supplierReturnNoteSRNToolStripMenuItem_Click);
            // 
            // transferNoteToolStripMenuItem
            // 
            this.transferNoteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.transferNoteToolStripMenuItem.Enabled = false;
            this.transferNoteToolStripMenuItem.Name = "transferNoteToolStripMenuItem";
            this.transferNoteToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.transferNoteToolStripMenuItem.Text = "Issue Note";
            this.transferNoteToolStripMenuItem.Click += new System.EventHandler(this.transferNoteToolStripMenuItem_Click);
            // 
            // stockAjestmentToolStripMenuItem
            // 
            this.stockAjestmentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.stockAjestmentToolStripMenuItem.Enabled = false;
            this.stockAjestmentToolStripMenuItem.Name = "stockAjestmentToolStripMenuItem";
            this.stockAjestmentToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.stockAjestmentToolStripMenuItem.Text = "Stock Ajustment Note";
            this.stockAjestmentToolStripMenuItem.Click += new System.EventHandler(this.stockAjestmentToolStripMenuItem_Click);
            // 
            // gRNCancelToolStripMenuItem
            // 
            this.gRNCancelToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gRNCancelToolStripMenuItem.Enabled = false;
            this.gRNCancelToolStripMenuItem.Name = "gRNCancelToolStripMenuItem";
            this.gRNCancelToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.gRNCancelToolStripMenuItem.Text = "GRN Cancel";
            this.gRNCancelToolStripMenuItem.Click += new System.EventHandler(this.gRNCancelToolStripMenuItem_Click);
            // 
            // issuToolStripMenuItem
            // 
            this.issuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.issuToolStripMenuItem.Enabled = false;
            this.issuToolStripMenuItem.Name = "issuToolStripMenuItem";
            this.issuToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.issuToolStripMenuItem.Text = "Transfer Note";
            this.issuToolStripMenuItem.Click += new System.EventHandler(this.issuToolStripMenuItem_Click);
            // 
            // stockInitializeToolStripMenuItem
            // 
            this.stockInitializeToolStripMenuItem.Enabled = false;
            this.stockInitializeToolStripMenuItem.Name = "stockInitializeToolStripMenuItem";
            this.stockInitializeToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.stockInitializeToolStripMenuItem.Text = "Stock Initialize";
            this.stockInitializeToolStripMenuItem.Click += new System.EventHandler(this.stockInitializeToolStripMenuItem_Click);
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
            this.ddToolStripMenuItem,
            this.gRNListToolStripMenuItem,
            this.pOListingReportToolStripMenuItem,
            this.issueNoteListingReportToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 31);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // ddToolStripMenuItem
            // 
            this.ddToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDetailsReportToolStripMenuItem,
            this.supplierDetailsReportToolStripMenuItem1,
            this.recipeDetailsReportToolStripMenuItem,
            this.menuDetailsReportToolStripMenuItem});
            this.ddToolStripMenuItem.Enabled = false;
            this.ddToolStripMenuItem.Name = "ddToolStripMenuItem";
            this.ddToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ddToolStripMenuItem.Text = "Master Report";
            // 
            // itemDetailsReportToolStripMenuItem
            // 
            this.itemDetailsReportToolStripMenuItem.Enabled = false;
            this.itemDetailsReportToolStripMenuItem.Name = "itemDetailsReportToolStripMenuItem";
            this.itemDetailsReportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.itemDetailsReportToolStripMenuItem.Text = "Item Details Report";
            this.itemDetailsReportToolStripMenuItem.Click += new System.EventHandler(this.itemDetailsReportToolStripMenuItem_Click);
            // 
            // supplierDetailsReportToolStripMenuItem1
            // 
            this.supplierDetailsReportToolStripMenuItem1.Enabled = false;
            this.supplierDetailsReportToolStripMenuItem1.Name = "supplierDetailsReportToolStripMenuItem1";
            this.supplierDetailsReportToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.supplierDetailsReportToolStripMenuItem1.Text = "Supplier Details Report";
            this.supplierDetailsReportToolStripMenuItem1.Click += new System.EventHandler(this.supplierDetailsReportToolStripMenuItem1_Click);
            // 
            // recipeDetailsReportToolStripMenuItem
            // 
            this.recipeDetailsReportToolStripMenuItem.Enabled = false;
            this.recipeDetailsReportToolStripMenuItem.Name = "recipeDetailsReportToolStripMenuItem";
            this.recipeDetailsReportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.recipeDetailsReportToolStripMenuItem.Text = "Recipe Details Report";
            this.recipeDetailsReportToolStripMenuItem.Click += new System.EventHandler(this.recipeDetailsReportToolStripMenuItem_Click);
            // 
            // menuDetailsReportToolStripMenuItem
            // 
            this.menuDetailsReportToolStripMenuItem.Enabled = false;
            this.menuDetailsReportToolStripMenuItem.Name = "menuDetailsReportToolStripMenuItem";
            this.menuDetailsReportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.menuDetailsReportToolStripMenuItem.Text = "Menu Details Report";
            // 
            // gRNListToolStripMenuItem
            // 
            this.gRNListToolStripMenuItem.Enabled = false;
            this.gRNListToolStripMenuItem.Name = "gRNListToolStripMenuItem";
            this.gRNListToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.gRNListToolStripMenuItem.Text = "GRN Listing Report";
            this.gRNListToolStripMenuItem.Click += new System.EventHandler(this.gRNListToolStripMenuItem_Click);
            // 
            // pOListingReportToolStripMenuItem
            // 
            this.pOListingReportToolStripMenuItem.Enabled = false;
            this.pOListingReportToolStripMenuItem.Name = "pOListingReportToolStripMenuItem";
            this.pOListingReportToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.pOListingReportToolStripMenuItem.Text = "PO Listing Report";
            this.pOListingReportToolStripMenuItem.Click += new System.EventHandler(this.pOListingReportToolStripMenuItem_Click);
            // 
            // issueNoteListingReportToolStripMenuItem
            // 
            this.issueNoteListingReportToolStripMenuItem.Enabled = false;
            this.issueNoteListingReportToolStripMenuItem.Name = "issueNoteListingReportToolStripMenuItem";
            this.issueNoteListingReportToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.issueNoteListingReportToolStripMenuItem.Text = "Issue Note Listing Report";
            this.issueNoteListingReportToolStripMenuItem.Click += new System.EventHandler(this.issueNoteListingReportToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmUserToolStripMenuItem,
            this.userRolesToolStripMenuItem});
            this.userToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.userToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 31);
            this.userToolStripMenuItem.Text = "User";
            // 
            // frmUserToolStripMenuItem
            // 
            this.frmUserToolStripMenuItem.Enabled = false;
            this.frmUserToolStripMenuItem.Name = "frmUserToolStripMenuItem";
            this.frmUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.frmUserToolStripMenuItem.Text = "User Master";
            this.frmUserToolStripMenuItem.Click += new System.EventHandler(this.ffToolStripMenuItem_Click);
            // 
            // userRolesToolStripMenuItem
            // 
            this.userRolesToolStripMenuItem.Enabled = false;
            this.userRolesToolStripMenuItem.Name = "userRolesToolStripMenuItem";
            this.userRolesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userRolesToolStripMenuItem.Text = "User Roles";
            this.userRolesToolStripMenuItem.Click += new System.EventHandler(this.userRolesToolStripMenuItem_Click);
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
            this.btnExit.Location = new System.Drawing.Point(806, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.menuStripMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 35);
            this.panel1.TabIndex = 3;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(150)))), ((int)(((byte)(153)))));
            this.btnMinimize.Location = new System.Drawing.Point(769, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 35);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(843, 447);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsReciveNoteGRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierReturnNoteSRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockAjestmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRNCancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInitializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemDetailsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierDetailsReportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recipeDetailsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDetailsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRNListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOListingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueNoteListingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRolesToolStripMenuItem;
    }
}