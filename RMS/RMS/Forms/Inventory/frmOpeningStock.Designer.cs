namespace RMS.Forms.Inventory
{
    partial class frmOpeningStock
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
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.btnItemSearch = new System.Windows.Forms.Button();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.btnStockSearch = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblStockCode = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(113, 55);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(157, 20);
            this.txtItemCode.TabIndex = 99;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblItemCode.Location = new System.Drawing.Point(15, 56);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(69, 16);
            this.lblItemCode.TabIndex = 98;
            this.lblItemCode.Text = "Item Code";
            // 
            // btnItemSearch
            // 
            this.btnItemSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnItemSearch.FlatAppearance.BorderSize = 0;
            this.btnItemSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnItemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemSearch.Image = global::RMS.Properties.Resources.search25;
            this.btnItemSearch.Location = new System.Drawing.Point(285, 48);
            this.btnItemSearch.Name = "btnItemSearch";
            this.btnItemSearch.Size = new System.Drawing.Size(35, 31);
            this.btnItemSearch.TabIndex = 100;
            this.btnItemSearch.UseVisualStyleBackColor = false;
            // 
            // btnNewItem
            // 
            this.btnNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnNewItem.FlatAppearance.BorderSize = 0;
            this.btnNewItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewItem.ForeColor = System.Drawing.Color.White;
            this.btnNewItem.Location = new System.Drawing.Point(326, 48);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(35, 31);
            this.btnNewItem.TabIndex = 101;
            this.btnNewItem.Text = "+";
            this.btnNewItem.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 103;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblQuantity.Location = new System.Drawing.Point(15, 91);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(56, 16);
            this.lblQuantity.TabIndex = 102;
            this.lblQuantity.Text = "Quantity";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 105;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblUnitPrice.Location = new System.Drawing.Point(15, 127);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(65, 16);
            this.lblUnitPrice.TabIndex = 104;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // btnStockSearch
            // 
            this.btnStockSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnStockSearch.FlatAppearance.BorderSize = 0;
            this.btnStockSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnStockSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockSearch.Image = global::RMS.Properties.Resources.search25;
            this.btnStockSearch.Location = new System.Drawing.Point(285, 5);
            this.btnStockSearch.Name = "btnStockSearch";
            this.btnStockSearch.Size = new System.Drawing.Size(35, 31);
            this.btnStockSearch.TabIndex = 108;
            this.btnStockSearch.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 20);
            this.textBox3.TabIndex = 107;
            // 
            // lblStockCode
            // 
            this.lblStockCode.AutoSize = true;
            this.lblStockCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblStockCode.Location = new System.Drawing.Point(15, 13);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(78, 16);
            this.lblStockCode.TabIndex = 106;
            this.lblStockCode.Text = "Stock Code";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDate.Location = new System.Drawing.Point(15, 165);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 16);
            this.lblDate.TabIndex = 109;
            this.lblDate.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 110;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(286, 198);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 114;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(205, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 113;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(124, 198);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 112;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 111;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmOpeningStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 247);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnStockSearch);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblStockCode);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnNewItem);
            this.Controls.Add(this.btnItemSearch);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.lblItemCode);
            this.Name = "frmOpeningStock";
            this.Text = "Opening Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItemSearch;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnStockSearch;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblStockCode;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
    }
}