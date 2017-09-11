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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.pnlShortCut = new System.Windows.Forms.Panel();
            this.dgvItem = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tbMenu = new MetroFramework.Controls.MetroTabControl();
            this.tbDrink = new System.Windows.Forms.TabPage();
            this.tbBreakfast = new System.Windows.Forms.TabPage();
            this.tbLunch = new System.Windows.Forms.TabPage();
            this.tbDinner = new System.Windows.Forms.TabPage();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMinus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPlus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmEach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.tbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(199)))));
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(824, 54);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(751, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.tbMenu);
            this.pnlMenu.Location = new System.Drawing.Point(12, 69);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(410, 268);
            this.pnlMenu.TabIndex = 1;
            // 
            // pnlBill
            // 
            this.pnlBill.BackColor = System.Drawing.Color.White;
            this.pnlBill.Controls.Add(this.dgvItem);
            this.pnlBill.Controls.Add(this.metroPanel1);
            this.pnlBill.Location = new System.Drawing.Point(458, 69);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(233, 225);
            this.pnlBill.TabIndex = 2;
            // 
            // pnlShortCut
            // 
            this.pnlShortCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.pnlShortCut.Location = new System.Drawing.Point(697, 69);
            this.pnlShortCut.Name = "pnlShortCut";
            this.pnlShortCut.Size = new System.Drawing.Size(128, 225);
            this.pnlShortCut.TabIndex = 3;
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToResizeRows = false;
            this.dgvItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmMinus,
            this.clmQty,
            this.btnPlus,
            this.clmEach,
            this.clmTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItem.EnableHeadersVisualStyles = false;
            this.dgvItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvItem.Location = new System.Drawing.Point(18, 13);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(198, 93);
            this.dgvItem.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(49, 123);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(130, 61);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tbDrink);
            this.tbMenu.Controls.Add(this.tbBreakfast);
            this.tbMenu.Controls.Add(this.tbLunch);
            this.tbMenu.Controls.Add(this.tbDinner);
            this.tbMenu.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tbMenu.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tbMenu.ItemSize = new System.Drawing.Size(56, 40);
            this.tbMenu.Location = new System.Drawing.Point(16, 13);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(382, 175);
            this.tbMenu.TabIndex = 1;
            this.tbMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbMenu.UseSelectable = true;
            // 
            // tbDrink
            // 
            this.tbDrink.Location = new System.Drawing.Point(4, 44);
            this.tbDrink.Name = "tbDrink";
            this.tbDrink.Size = new System.Drawing.Size(374, 127);
            this.tbDrink.TabIndex = 0;
            this.tbDrink.Text = "DRINKS";
            // 
            // tbBreakfast
            // 
            this.tbBreakfast.Location = new System.Drawing.Point(4, 38);
            this.tbBreakfast.Name = "tbBreakfast";
            this.tbBreakfast.Size = new System.Drawing.Size(374, 133);
            this.tbBreakfast.TabIndex = 1;
            this.tbBreakfast.Text = "BREAKFAST";
            // 
            // tbLunch
            // 
            this.tbLunch.Location = new System.Drawing.Point(4, 38);
            this.tbLunch.Name = "tbLunch";
            this.tbLunch.Size = new System.Drawing.Size(374, 133);
            this.tbLunch.TabIndex = 2;
            this.tbLunch.Text = "LUNCH";
            // 
            // tbDinner
            // 
            this.tbDinner.Location = new System.Drawing.Point(4, 38);
            this.tbDinner.Name = "tbDinner";
            this.tbDinner.Size = new System.Drawing.Size(374, 133);
            this.tbDinner.TabIndex = 3;
            this.tbDinner.Text = "DINNER";
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.MinimumWidth = 100;
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmMinus
            // 
            this.clmMinus.HeaderText = "-";
            this.clmMinus.MinimumWidth = 20;
            this.clmMinus.Name = "clmMinus";
            this.clmMinus.Width = 20;
            // 
            // clmQty
            // 
            this.clmQty.HeaderText = "Qty";
            this.clmQty.MinimumWidth = 10;
            this.clmQty.Name = "clmQty";
            this.clmQty.Width = 10;
            // 
            // btnPlus
            // 
            this.btnPlus.HeaderText = "+";
            this.btnPlus.MinimumWidth = 20;
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Width = 20;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(826, 349);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Panel pnlShortCut;
        private MetroFramework.Controls.MetroGrid dgvItem;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabControl tbMenu;
        private System.Windows.Forms.TabPage tbDrink;
        private System.Windows.Forms.TabPage tbBreakfast;
        private System.Windows.Forms.TabPage tbLunch;
        private System.Windows.Forms.TabPage tbDinner;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewButtonColumn clmMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
        private System.Windows.Forms.DataGridViewButtonColumn btnPlus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
    }
}