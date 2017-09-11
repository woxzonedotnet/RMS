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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.dgvItem = new MetroFramework.Controls.MetroGrid();
            this.pnlShortCut = new System.Windows.Forms.Panel();
            this.tbMenu = new MetroFramework.Controls.MetroTabControl();
            this.tbDrinks = new MetroFramework.Controls.MetroTabPage();
            this.tbBreakfast = new MetroFramework.Controls.MetroTabPage();
            this.tbLunch = new MetroFramework.Controls.MetroTabPage();
            this.tbDinner = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMinus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmEach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.tbMenu.SuspendLayout();
            this.tbDrinks.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmMinus,
            this.clmQty,
            this.btnPlus,
            this.clmEach,
            this.clmTotal});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvItem.EnableHeadersVisualStyles = false;
            this.dgvItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvItem.Location = new System.Drawing.Point(3, 13);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.DarkRed;
            this.dgvItem.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvItem.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dgvItem.RowTemplate.Height = 45;
            this.dgvItem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(316, 189);
            this.dgvItem.TabIndex = 0;
            // 
            // pnlShortCut
            // 
            this.pnlShortCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.pnlShortCut.Location = new System.Drawing.Point(872, 58);
            this.pnlShortCut.Name = "pnlShortCut";
            this.pnlShortCut.Size = new System.Drawing.Size(90, 376);
            this.pnlShortCut.TabIndex = 3;
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
            this.tbDrinks.Controls.Add(this.groupBox2);
            this.tbDrinks.Controls.Add(this.groupBox1);
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
            // tbBreakfast
            // 
            this.tbBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBreakfast.HorizontalScrollbarBarColor = true;
            this.tbBreakfast.HorizontalScrollbarHighlightOnWheel = false;
            this.tbBreakfast.HorizontalScrollbarSize = 10;
            this.tbBreakfast.Location = new System.Drawing.Point(4, 44);
            this.tbBreakfast.Name = "tbBreakfast";
            this.tbBreakfast.Size = new System.Drawing.Size(506, 229);
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
            this.tbLunch.Size = new System.Drawing.Size(506, 229);
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
            this.tbDinner.Size = new System.Drawing.Size(506, 229);
            this.tbDinner.TabIndex = 3;
            this.tbDinner.Text = "DINNER";
            this.tbDinner.VerticalScrollbarBarColor = true;
            this.tbDinner.VerticalScrollbarHighlightOnWheel = false;
            this.tbDinner.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(73, 29);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(390, 65);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmQty.DefaultCellStyle = dataGridViewCellStyle22;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.metroPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SUB CATEGORY";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ITEM";
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
            this.pnlBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.tbMenu.ResumeLayout(false);
            this.tbDrinks.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabPage tbBreakfast;
        private MetroFramework.Controls.MetroTabPage tbLunch;
        private MetroFramework.Controls.MetroTabPage tbDinner;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewButtonColumn clmMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
        private System.Windows.Forms.DataGridViewButtonColumn btnPlus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}