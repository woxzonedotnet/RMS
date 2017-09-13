namespace RMS_FrontEnd
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tbMenu = new MetroFramework.Controls.MetroTabControl();
            this.tbDrinks = new MetroFramework.Controls.MetroTabPage();
            this.gbItems = new System.Windows.Forms.GroupBox();
            this.gbSubCategory = new System.Windows.Forms.GroupBox();
            this.pnlSubCategory = new MetroFramework.Controls.MetroPanel();
            this.tbBreakfast = new MetroFramework.Controls.MetroTabPage();
            this.tbLunch = new MetroFramework.Controls.MetroTabPage();
            this.tbDinner = new MetroFramework.Controls.MetroTabPage();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.dgvItem = new MetroFramework.Controls.MetroGrid();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMinus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmEach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlShortCut = new System.Windows.Forms.Panel();
            this.btnSubCategoryPrevious = new System.Windows.Forms.Button();
            this.btnSubCategoryNext = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.tbMenu.SuspendLayout();
            this.tbDrinks.SuspendLayout();
            this.gbSubCategory.SuspendLayout();
            this.pnlBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(199)))));
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(961, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(909, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.tbMenu);
            this.pnlMenu.Location = new System.Drawing.Point(1, 58);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(540, 376);
            this.pnlMenu.TabIndex = 1;
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tbDrinks);
            this.tbMenu.Controls.Add(this.tbBreakfast);
            this.tbMenu.Controls.Add(this.tbLunch);
            this.tbMenu.Controls.Add(this.tbDinner);
            this.tbMenu.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tbMenu.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tbMenu.Location = new System.Drawing.Point(11, 13);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(514, 350);
            this.tbMenu.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tbMenu.TabIndex = 0;
            this.tbMenu.UseSelectable = true;
            // 
            // tbDrinks
            // 
            this.tbDrinks.Controls.Add(this.gbItems);
            this.tbDrinks.Controls.Add(this.gbSubCategory);
            this.tbDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDrinks.ForeColor = System.Drawing.Color.DarkRed;
            this.tbDrinks.HorizontalScrollbarBarColor = true;
            this.tbDrinks.HorizontalScrollbarHighlightOnWheel = false;
            this.tbDrinks.HorizontalScrollbarSize = 10;
            this.tbDrinks.Location = new System.Drawing.Point(4, 44);
            this.tbDrinks.Name = "tbDrinks";
            this.tbDrinks.Size = new System.Drawing.Size(506, 302);
            this.tbDrinks.TabIndex = 0;
            this.tbDrinks.Text = "DRINKS";
            this.tbDrinks.VerticalScrollbarBarColor = true;
            this.tbDrinks.VerticalScrollbarHighlightOnWheel = false;
            this.tbDrinks.VerticalScrollbarSize = 10;
            // 
            // gbItems
            // 
            this.gbItems.BackColor = System.Drawing.Color.White;
            this.gbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItems.Location = new System.Drawing.Point(13, 147);
            this.gbItems.Name = "gbItems";
            this.gbItems.Size = new System.Drawing.Size(490, 130);
            this.gbItems.TabIndex = 4;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "ITEM";
            // 
            // gbSubCategory
            // 
            this.gbSubCategory.BackColor = System.Drawing.Color.White;
            this.gbSubCategory.Controls.Add(this.btnSubCategoryNext);
            this.gbSubCategory.Controls.Add(this.btnSubCategoryPrevious);
            this.gbSubCategory.Controls.Add(this.pnlSubCategory);
            this.gbSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSubCategory.Location = new System.Drawing.Point(13, 15);
            this.gbSubCategory.Name = "gbSubCategory";
            this.gbSubCategory.Size = new System.Drawing.Size(490, 117);
            this.gbSubCategory.TabIndex = 3;
            this.gbSubCategory.TabStop = false;
            this.gbSubCategory.Text = "SUB CATEGORY";
            // 
            // pnlSubCategory
            // 
            this.pnlSubCategory.HorizontalScrollbarBarColor = true;
            this.pnlSubCategory.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSubCategory.HorizontalScrollbarSize = 10;
            this.pnlSubCategory.Location = new System.Drawing.Point(57, 29);
            this.pnlSubCategory.Name = "pnlSubCategory";
            this.pnlSubCategory.Size = new System.Drawing.Size(376, 65);
            this.pnlSubCategory.TabIndex = 2;
            this.pnlSubCategory.VerticalScrollbarBarColor = true;
            this.pnlSubCategory.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSubCategory.VerticalScrollbarSize = 10;
            // 
            // tbBreakfast
            // 
            this.tbBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBreakfast.HorizontalScrollbarBarColor = true;
            this.tbBreakfast.HorizontalScrollbarHighlightOnWheel = false;
            this.tbBreakfast.HorizontalScrollbarSize = 10;
            this.tbBreakfast.Location = new System.Drawing.Point(4, 44);
            this.tbBreakfast.Name = "tbBreakfast";
            this.tbBreakfast.Size = new System.Drawing.Size(506, 302);
            this.tbBreakfast.TabIndex = 1;
            this.tbBreakfast.Text = "BREAKFAST";
            this.tbBreakfast.VerticalScrollbarBarColor = true;
            this.tbBreakfast.VerticalScrollbarHighlightOnWheel = false;
            this.tbBreakfast.VerticalScrollbarSize = 10;
            // 
            // tbLunch
            // 
            this.tbLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLunch.HorizontalScrollbarBarColor = true;
            this.tbLunch.HorizontalScrollbarHighlightOnWheel = false;
            this.tbLunch.HorizontalScrollbarSize = 10;
            this.tbLunch.Location = new System.Drawing.Point(4, 44);
            this.tbLunch.Name = "tbLunch";
            this.tbLunch.Size = new System.Drawing.Size(506, 302);
            this.tbLunch.TabIndex = 2;
            this.tbLunch.Text = "LUNCH";
            this.tbLunch.VerticalScrollbarBarColor = true;
            this.tbLunch.VerticalScrollbarHighlightOnWheel = false;
            this.tbLunch.VerticalScrollbarSize = 10;
            // 
            // tbDinner
            // 
            this.tbDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDinner.HorizontalScrollbarBarColor = true;
            this.tbDinner.HorizontalScrollbarHighlightOnWheel = false;
            this.tbDinner.HorizontalScrollbarSize = 10;
            this.tbDinner.Location = new System.Drawing.Point(4, 44);
            this.tbDinner.Name = "tbDinner";
            this.tbDinner.Size = new System.Drawing.Size(506, 302);
            this.tbDinner.TabIndex = 3;
            this.tbDinner.Text = "DINNER";
            this.tbDinner.VerticalScrollbarBarColor = true;
            this.tbDinner.VerticalScrollbarHighlightOnWheel = false;
            this.tbDinner.VerticalScrollbarSize = 10;
            // 
            // pnlBill
            // 
            this.pnlBill.BackColor = System.Drawing.Color.White;
            this.pnlBill.Controls.Add(this.dgvItem);
            this.pnlBill.Location = new System.Drawing.Point(547, 58);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(325, 376);
            this.pnlBill.TabIndex = 2;
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToResizeRows = false;
            this.dgvItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmMinus,
            this.clmQty,
            this.btnPlus,
            this.clmEach,
            this.clmTotal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvItem.EnableHeadersVisualStyles = false;
            this.dgvItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvItem.Location = new System.Drawing.Point(3, 13);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkRed;
            this.dgvItem.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvItem.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dgvItem.RowTemplate.Height = 45;
            this.dgvItem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(316, 189);
            this.dgvItem.TabIndex = 0;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.MinimumWidth = 150;
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 150;
            // 
            // clmMinus
            // 
            this.clmMinus.HeaderText = "-";
            this.clmMinus.MinimumWidth = 45;
            this.clmMinus.Name = "clmMinus";
            this.clmMinus.Text = "-";
            this.clmMinus.UseColumnTextForButtonValue = true;
            this.clmMinus.Width = 45;
            // 
            // clmQty
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmQty.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmQty.HeaderText = "Qty";
            this.clmQty.MinimumWidth = 40;
            this.clmQty.Name = "clmQty";
            this.clmQty.Width = 40;
            // 
            // btnPlus
            // 
            this.btnPlus.HeaderText = "+";
            this.btnPlus.MinimumWidth = 45;
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Text = "+";
            this.btnPlus.UseColumnTextForButtonValue = true;
            this.btnPlus.Width = 45;
            // 
            // clmEach
            // 
            this.clmEach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmEach.HeaderText = "Each";
            this.clmEach.Name = "clmEach";
            this.clmEach.ReadOnly = true;
            // 
            // clmTotal
            // 
            this.clmTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTotal.HeaderText = "Total";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            // 
            // pnlShortCut
            // 
            this.pnlShortCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.pnlShortCut.Location = new System.Drawing.Point(872, 58);
            this.pnlShortCut.Name = "pnlShortCut";
            this.pnlShortCut.Size = new System.Drawing.Size(90, 376);
            this.pnlShortCut.TabIndex = 3;
            // 
            // btnSubCategoryPrevious
            // 
            this.btnSubCategoryPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubCategoryPrevious.Location = new System.Drawing.Point(6, 29);
            this.btnSubCategoryPrevious.Name = "btnSubCategoryPrevious";
            this.btnSubCategoryPrevious.Size = new System.Drawing.Size(45, 65);
            this.btnSubCategoryPrevious.TabIndex = 3;
            this.btnSubCategoryPrevious.Text = "<";
            this.btnSubCategoryPrevious.UseVisualStyleBackColor = true;
            // 
            // btnSubCategoryNext
            // 
            this.btnSubCategoryNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubCategoryNext.Location = new System.Drawing.Point(439, 29);
            this.btnSubCategoryNext.Name = "btnSubCategoryNext";
            this.btnSubCategoryNext.Size = new System.Drawing.Size(45, 65);
            this.btnSubCategoryNext.TabIndex = 4;
            this.btnSubCategoryNext.Text = ">";
            this.btnSubCategoryNext.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(962, 446);
            this.Controls.Add(this.pnlShortCut);
            this.Controls.Add(this.pnlBill);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.tbMenu.ResumeLayout(false);
            this.tbDrinks.ResumeLayout(false);
            this.gbSubCategory.ResumeLayout(false);
            this.pnlBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Panel pnlShortCut;
        private MetroFramework.Controls.MetroGrid dgvItem;
        private MetroFramework.Controls.MetroTabControl tbMenu;
        private MetroFramework.Controls.MetroTabPage tbDrinks;
        private MetroFramework.Controls.MetroPanel pnlSubCategory;
        private MetroFramework.Controls.MetroTabPage tbBreakfast;
        private MetroFramework.Controls.MetroTabPage tbLunch;
        private MetroFramework.Controls.MetroTabPage tbDinner;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewButtonColumn clmMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
        private System.Windows.Forms.DataGridViewButtonColumn btnPlus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.GroupBox gbItems;
        private System.Windows.Forms.GroupBox gbSubCategory;
        private System.Windows.Forms.Button btnSubCategoryNext;
        private System.Windows.Forms.Button btnSubCategoryPrevious;
    }
}