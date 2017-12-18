﻿namespace RMS_FrontEnd
{
    partial class frmFront_PayBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFront_PayBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbTableCat = new MetroFramework.Controls.MetroTabControl();
            this.tbCash = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCashPayment = new System.Windows.Forms.TextBox();
            this.txtCashBalance = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCashPay = new System.Windows.Forms.Button();
            this.tbCreditCard = new MetroFramework.Controls.MetroTabPage();
            this.txtCardPayment = new System.Windows.Forms.TextBox();
            this.cmbCardType = new MetroFramework.Controls.MetroComboBox();
            this.txtCardNumber = new MetroFramework.Controls.MetroTextBox();
            this.cmbCardBank = new MetroFramework.Controls.MetroComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCardBalance = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCardPay = new System.Windows.Forms.Button();
            this.tbCheque = new MetroFramework.Controls.MetroTabPage();
            this.txtChequePayment = new System.Windows.Forms.TextBox();
            this.dtChequeDate = new MetroFramework.Controls.MetroDateTime();
            this.txtChequeNumber = new MetroFramework.Controls.MetroTextBox();
            this.cmbChequeBank = new MetroFramework.Controls.MetroComboBox();
            this.txtChequeBalance = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChequePay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvPayMethod = new MetroFramework.Controls.MetroGrid();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtHeadBalance = new MetroFramework.Controls.MetroTextBox();
            this.txtHeadTotal = new MetroFramework.Controls.MetroTextBox();
            this.lblHeadBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbTableCat.SuspendLayout();
            this.tbCash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbCreditCard.SuspendLayout();
            this.tbCheque.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayMethod)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTableCat
            // 
            this.tbTableCat.Controls.Add(this.tbCash);
            this.tbTableCat.Controls.Add(this.tbCreditCard);
            this.tbTableCat.Controls.Add(this.tbCheque);
            this.tbTableCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTableCat.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tbTableCat.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tbTableCat.Location = new System.Drawing.Point(0, 0);
            this.tbTableCat.Name = "tbTableCat";
            this.tbTableCat.SelectedIndex = 0;
            this.tbTableCat.Size = new System.Drawing.Size(447, 301);
            this.tbTableCat.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tbTableCat.TabIndex = 0;
            this.tbTableCat.UseSelectable = true;
            this.tbTableCat.SelectedIndexChanged += new System.EventHandler(this.tbTableCat_SelectedIndexChanged);
            // 
            // tbCash
            // 
            this.tbCash.Controls.Add(this.pictureBox1);
            this.tbCash.Controls.Add(this.txtCashPayment);
            this.tbCash.Controls.Add(this.txtCashBalance);
            this.tbCash.Controls.Add(this.label9);
            this.tbCash.Controls.Add(this.label3);
            this.tbCash.Controls.Add(this.btnCashPay);
            this.tbCash.HorizontalScrollbarBarColor = true;
            this.tbCash.HorizontalScrollbarHighlightOnWheel = false;
            this.tbCash.HorizontalScrollbarSize = 10;
            this.tbCash.Location = new System.Drawing.Point(4, 44);
            this.tbCash.Name = "tbCash";
            this.tbCash.Size = new System.Drawing.Size(439, 253);
            this.tbCash.TabIndex = 0;
            this.tbCash.Text = "CASH";
            this.tbCash.VerticalScrollbarBarColor = true;
            this.tbCash.VerticalScrollbarHighlightOnWheel = false;
            this.tbCash.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtCashPayment
            // 
            this.txtCashPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashPayment.Location = new System.Drawing.Point(137, 31);
            this.txtCashPayment.Name = "txtCashPayment";
            this.txtCashPayment.Size = new System.Drawing.Size(278, 27);
            this.txtCashPayment.TabIndex = 9;
            this.txtCashPayment.Text = "0.00";
            this.txtCashPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCashPayment.TextChanged += new System.EventHandler(this.txtCashPayment_TextChanged);
            this.txtCashPayment.DoubleClick += new System.EventHandler(this.txtCashPayment_DoubleClick);
            // 
            // txtCashBalance
            // 
            // 
            // 
            // 
            this.txtCashBalance.CustomButton.Image = null;
            this.txtCashBalance.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.txtCashBalance.CustomButton.Name = "";
            this.txtCashBalance.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCashBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCashBalance.CustomButton.TabIndex = 1;
            this.txtCashBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCashBalance.CustomButton.UseSelectable = true;
            this.txtCashBalance.CustomButton.Visible = false;
            this.txtCashBalance.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCashBalance.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCashBalance.Lines = new string[] {
        "0.00"};
            this.txtCashBalance.Location = new System.Drawing.Point(79, 214);
            this.txtCashBalance.MaxLength = 32767;
            this.txtCashBalance.Name = "txtCashBalance";
            this.txtCashBalance.PasswordChar = '\0';
            this.txtCashBalance.ReadOnly = true;
            this.txtCashBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCashBalance.SelectedText = "";
            this.txtCashBalance.SelectionLength = 0;
            this.txtCashBalance.SelectionStart = 0;
            this.txtCashBalance.ShortcutsEnabled = true;
            this.txtCashBalance.Size = new System.Drawing.Size(220, 30);
            this.txtCashBalance.TabIndex = 8;
            this.txtCashBalance.Text = "0.00";
            this.txtCashBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCashBalance.UseSelectable = true;
            this.txtCashBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCashBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Payment Amount";
            // 
            // btnCashPay
            // 
            this.btnCashPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(168)))), ((int)(((byte)(27)))));
            this.btnCashPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnCashPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashPay.ForeColor = System.Drawing.Color.White;
            this.btnCashPay.Location = new System.Drawing.Point(344, 214);
            this.btnCashPay.Name = "btnCashPay";
            this.btnCashPay.Size = new System.Drawing.Size(92, 36);
            this.btnCashPay.TabIndex = 2;
            this.btnCashPay.Text = "PAY";
            this.btnCashPay.UseVisualStyleBackColor = false;
            this.btnCashPay.Click += new System.EventHandler(this.btnCashPay_Click);
            // 
            // tbCreditCard
            // 
            this.tbCreditCard.Controls.Add(this.txtCardPayment);
            this.tbCreditCard.Controls.Add(this.cmbCardType);
            this.tbCreditCard.Controls.Add(this.txtCardNumber);
            this.tbCreditCard.Controls.Add(this.cmbCardBank);
            this.tbCreditCard.Controls.Add(this.label11);
            this.tbCreditCard.Controls.Add(this.label12);
            this.tbCreditCard.Controls.Add(this.label13);
            this.tbCreditCard.Controls.Add(this.label14);
            this.tbCreditCard.Controls.Add(this.txtCardBalance);
            this.tbCreditCard.Controls.Add(this.label10);
            this.tbCreditCard.Controls.Add(this.btnCardPay);
            this.tbCreditCard.HorizontalScrollbarBarColor = true;
            this.tbCreditCard.HorizontalScrollbarHighlightOnWheel = false;
            this.tbCreditCard.HorizontalScrollbarSize = 10;
            this.tbCreditCard.Location = new System.Drawing.Point(4, 44);
            this.tbCreditCard.Name = "tbCreditCard";
            this.tbCreditCard.Size = new System.Drawing.Size(439, 253);
            this.tbCreditCard.TabIndex = 2;
            this.tbCreditCard.Text = "CREDIT CARD";
            this.tbCreditCard.VerticalScrollbarBarColor = true;
            this.tbCreditCard.VerticalScrollbarHighlightOnWheel = false;
            this.tbCreditCard.VerticalScrollbarSize = 10;
            // 
            // txtCardPayment
            // 
            this.txtCardPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardPayment.Location = new System.Drawing.Point(144, 153);
            this.txtCardPayment.Name = "txtCardPayment";
            this.txtCardPayment.Size = new System.Drawing.Size(247, 27);
            this.txtCardPayment.TabIndex = 23;
            this.txtCardPayment.Text = "0.00";
            this.txtCardPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCardPayment.TextChanged += new System.EventHandler(this.txtCardPayment_TextChanged);
            this.txtCardPayment.DoubleClick += new System.EventHandler(this.txtCardPayment_DoubleClick);
            // 
            // cmbCardType
            // 
            this.cmbCardType.FormattingEnabled = true;
            this.cmbCardType.ItemHeight = 23;
            this.cmbCardType.Location = new System.Drawing.Point(144, 59);
            this.cmbCardType.Name = "cmbCardType";
            this.cmbCardType.Size = new System.Drawing.Size(247, 29);
            this.cmbCardType.TabIndex = 22;
            this.cmbCardType.UseSelectable = true;
            // 
            // txtCardNumber
            // 
            // 
            // 
            // 
            this.txtCardNumber.CustomButton.Image = null;
            this.txtCardNumber.CustomButton.Location = new System.Drawing.Point(219, 2);
            this.txtCardNumber.CustomButton.Name = "";
            this.txtCardNumber.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCardNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCardNumber.CustomButton.TabIndex = 1;
            this.txtCardNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCardNumber.CustomButton.UseSelectable = true;
            this.txtCardNumber.CustomButton.Visible = false;
            this.txtCardNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCardNumber.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCardNumber.Lines = new string[0];
            this.txtCardNumber.Location = new System.Drawing.Point(144, 104);
            this.txtCardNumber.MaxLength = 16;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.PasswordChar = '\0';
            this.txtCardNumber.PromptText = "Card Number (XXXX-XXXX-XXXX-XXXX)";
            this.txtCardNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCardNumber.SelectedText = "";
            this.txtCardNumber.SelectionLength = 0;
            this.txtCardNumber.SelectionStart = 0;
            this.txtCardNumber.ShortcutsEnabled = true;
            this.txtCardNumber.Size = new System.Drawing.Size(247, 30);
            this.txtCardNumber.TabIndex = 20;
            this.txtCardNumber.UseSelectable = true;
            this.txtCardNumber.WaterMark = "Card Number (XXXX-XXXX-XXXX-XXXX)";
            this.txtCardNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCardNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCardNumber.DoubleClick += new System.EventHandler(this.txtCardNumber_DoubleClick);
            this.txtCardNumber.Validated += new System.EventHandler(this.txtCardNumber_Validated);
            // 
            // cmbCardBank
            // 
            this.cmbCardBank.FormattingEnabled = true;
            this.cmbCardBank.ItemHeight = 23;
            this.cmbCardBank.Location = new System.Drawing.Point(144, 14);
            this.cmbCardBank.Name = "cmbCardBank";
            this.cmbCardBank.Size = new System.Drawing.Size(247, 29);
            this.cmbCardBank.TabIndex = 19;
            this.cmbCardBank.UseSelectable = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Payment Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Card Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Card Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Bank Name";
            // 
            // txtCardBalance
            // 
            // 
            // 
            // 
            this.txtCardBalance.CustomButton.Image = null;
            this.txtCardBalance.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.txtCardBalance.CustomButton.Name = "";
            this.txtCardBalance.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCardBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCardBalance.CustomButton.TabIndex = 1;
            this.txtCardBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCardBalance.CustomButton.UseSelectable = true;
            this.txtCardBalance.CustomButton.Visible = false;
            this.txtCardBalance.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCardBalance.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtCardBalance.Lines = new string[] {
        "0.00"};
            this.txtCardBalance.Location = new System.Drawing.Point(79, 214);
            this.txtCardBalance.MaxLength = 32767;
            this.txtCardBalance.Name = "txtCardBalance";
            this.txtCardBalance.PasswordChar = '\0';
            this.txtCardBalance.ReadOnly = true;
            this.txtCardBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCardBalance.SelectedText = "";
            this.txtCardBalance.SelectionLength = 0;
            this.txtCardBalance.SelectionStart = 0;
            this.txtCardBalance.ShortcutsEnabled = true;
            this.txtCardBalance.Size = new System.Drawing.Size(220, 30);
            this.txtCardBalance.TabIndex = 9;
            this.txtCardBalance.Text = "0.00";
            this.txtCardBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCardBalance.UseSelectable = true;
            this.txtCardBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCardBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Balance";
            // 
            // btnCardPay
            // 
            this.btnCardPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(168)))), ((int)(((byte)(27)))));
            this.btnCardPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnCardPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardPay.ForeColor = System.Drawing.Color.White;
            this.btnCardPay.Location = new System.Drawing.Point(344, 214);
            this.btnCardPay.Name = "btnCardPay";
            this.btnCardPay.Size = new System.Drawing.Size(92, 36);
            this.btnCardPay.TabIndex = 3;
            this.btnCardPay.Text = "PAY";
            this.btnCardPay.UseVisualStyleBackColor = false;
            this.btnCardPay.Click += new System.EventHandler(this.btnCardPay_Click);
            // 
            // tbCheque
            // 
            this.tbCheque.Controls.Add(this.txtChequePayment);
            this.tbCheque.Controls.Add(this.dtChequeDate);
            this.tbCheque.Controls.Add(this.txtChequeNumber);
            this.tbCheque.Controls.Add(this.cmbChequeBank);
            this.tbCheque.Controls.Add(this.txtChequeBalance);
            this.tbCheque.Controls.Add(this.label8);
            this.tbCheque.Controls.Add(this.label7);
            this.tbCheque.Controls.Add(this.label6);
            this.tbCheque.Controls.Add(this.label5);
            this.tbCheque.Controls.Add(this.label4);
            this.tbCheque.Controls.Add(this.btnChequePay);
            this.tbCheque.HorizontalScrollbarBarColor = true;
            this.tbCheque.HorizontalScrollbarHighlightOnWheel = false;
            this.tbCheque.HorizontalScrollbarSize = 10;
            this.tbCheque.Location = new System.Drawing.Point(4, 44);
            this.tbCheque.Name = "tbCheque";
            this.tbCheque.Size = new System.Drawing.Size(439, 253);
            this.tbCheque.TabIndex = 1;
            this.tbCheque.Text = "CHEQUE";
            this.tbCheque.VerticalScrollbarBarColor = true;
            this.tbCheque.VerticalScrollbarHighlightOnWheel = false;
            this.tbCheque.VerticalScrollbarSize = 10;
            // 
            // txtChequePayment
            // 
            this.txtChequePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequePayment.Location = new System.Drawing.Point(144, 153);
            this.txtChequePayment.Name = "txtChequePayment";
            this.txtChequePayment.Size = new System.Drawing.Size(247, 27);
            this.txtChequePayment.TabIndex = 14;
            this.txtChequePayment.Text = "0.00";
            this.txtChequePayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChequePayment.TextChanged += new System.EventHandler(this.txtChequePayment_TextChanged);
            this.txtChequePayment.DoubleClick += new System.EventHandler(this.txtChequePayment_DoubleClick);
            // 
            // dtChequeDate
            // 
            this.dtChequeDate.Location = new System.Drawing.Point(144, 105);
            this.dtChequeDate.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtChequeDate.Name = "dtChequeDate";
            this.dtChequeDate.Size = new System.Drawing.Size(247, 29);
            this.dtChequeDate.TabIndex = 0;
            // 
            // txtChequeNumber
            // 
            // 
            // 
            // 
            this.txtChequeNumber.CustomButton.Image = null;
            this.txtChequeNumber.CustomButton.Location = new System.Drawing.Point(219, 2);
            this.txtChequeNumber.CustomButton.Name = "";
            this.txtChequeNumber.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtChequeNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChequeNumber.CustomButton.TabIndex = 1;
            this.txtChequeNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChequeNumber.CustomButton.UseSelectable = true;
            this.txtChequeNumber.CustomButton.Visible = false;
            this.txtChequeNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtChequeNumber.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtChequeNumber.Lines = new string[0];
            this.txtChequeNumber.Location = new System.Drawing.Point(144, 59);
            this.txtChequeNumber.MaxLength = 32767;
            this.txtChequeNumber.Name = "txtChequeNumber";
            this.txtChequeNumber.PasswordChar = '\0';
            this.txtChequeNumber.PromptText = "Cheque Number";
            this.txtChequeNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChequeNumber.SelectedText = "";
            this.txtChequeNumber.SelectionLength = 0;
            this.txtChequeNumber.SelectionStart = 0;
            this.txtChequeNumber.ShortcutsEnabled = false;
            this.txtChequeNumber.Size = new System.Drawing.Size(247, 30);
            this.txtChequeNumber.TabIndex = 11;
            this.txtChequeNumber.UseSelectable = true;
            this.txtChequeNumber.WaterMark = "Cheque Number";
            this.txtChequeNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChequeNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtChequeNumber.Click += new System.EventHandler(this.txtChequeNumber_Click);
            this.txtChequeNumber.DoubleClick += new System.EventHandler(this.txtChequeNumber_DoubleClick);
            this.txtChequeNumber.Validated += new System.EventHandler(this.txtChequeNumber_Validated);
            // 
            // cmbChequeBank
            // 
            this.cmbChequeBank.FormattingEnabled = true;
            this.cmbChequeBank.ItemHeight = 23;
            this.cmbChequeBank.Location = new System.Drawing.Point(144, 14);
            this.cmbChequeBank.Name = "cmbChequeBank";
            this.cmbChequeBank.Size = new System.Drawing.Size(247, 29);
            this.cmbChequeBank.TabIndex = 10;
            this.cmbChequeBank.UseSelectable = true;
            // 
            // txtChequeBalance
            // 
            // 
            // 
            // 
            this.txtChequeBalance.CustomButton.Image = null;
            this.txtChequeBalance.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.txtChequeBalance.CustomButton.Name = "";
            this.txtChequeBalance.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtChequeBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChequeBalance.CustomButton.TabIndex = 1;
            this.txtChequeBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChequeBalance.CustomButton.UseSelectable = true;
            this.txtChequeBalance.CustomButton.Visible = false;
            this.txtChequeBalance.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtChequeBalance.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtChequeBalance.Lines = new string[] {
        "0.00"};
            this.txtChequeBalance.Location = new System.Drawing.Point(79, 214);
            this.txtChequeBalance.MaxLength = 32767;
            this.txtChequeBalance.Name = "txtChequeBalance";
            this.txtChequeBalance.PasswordChar = '\0';
            this.txtChequeBalance.ReadOnly = true;
            this.txtChequeBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChequeBalance.SelectedText = "";
            this.txtChequeBalance.SelectionLength = 0;
            this.txtChequeBalance.SelectionStart = 0;
            this.txtChequeBalance.ShortcutsEnabled = true;
            this.txtChequeBalance.Size = new System.Drawing.Size(220, 30);
            this.txtChequeBalance.TabIndex = 9;
            this.txtChequeBalance.Text = "0.00";
            this.txtChequeBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChequeBalance.UseSelectable = true;
            this.txtChequeBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChequeBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Payment Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cheque Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cheque No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bank Name";
            // 
            // btnChequePay
            // 
            this.btnChequePay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(168)))), ((int)(((byte)(27)))));
            this.btnChequePay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnChequePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChequePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChequePay.ForeColor = System.Drawing.Color.White;
            this.btnChequePay.Location = new System.Drawing.Point(344, 214);
            this.btnChequePay.Name = "btnChequePay";
            this.btnChequePay.Size = new System.Drawing.Size(92, 36);
            this.btnChequePay.TabIndex = 3;
            this.btnChequePay.Text = "PAY";
            this.btnChequePay.UseVisualStyleBackColor = false;
            this.btnChequePay.Click += new System.EventHandler(this.btnChequePay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(153)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 2, 5, 2);
            this.panel1.Size = new System.Drawing.Size(713, 32);
            this.panel1.TabIndex = 5;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(9, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(68, 16);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Payment";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(673, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnComplete);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 351);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 2, 5, 2);
            this.panel2.Size = new System.Drawing.Size(709, 40);
            this.panel2.TabIndex = 2;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(168)))), ((int)(((byte)(27)))));
            this.btnComplete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnComplete.Enabled = false;
            this.btnComplete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Location = new System.Drawing.Point(414, 2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(145, 36);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "COMPLETE";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(28)))), ((int)(((byte)(2)))));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(18)))), ((int)(((byte)(2)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(559, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 36);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(709, 349);
            this.panel3.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.dgvPayMethod);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(447, 48);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(262, 301);
            this.panel7.TabIndex = 3;
            // 
            // dgvPayMethod
            // 
            this.dgvPayMethod.AllowUserToAddRows = false;
            this.dgvPayMethod.AllowUserToResizeRows = false;
            this.dgvPayMethod.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPayMethod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayMethod.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPayMethod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayMethod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayMethod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmType,
            this.clmAmount,
            this.clmStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayMethod.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayMethod.EnableHeadersVisualStyles = false;
            this.dgvPayMethod.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPayMethod.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPayMethod.Location = new System.Drawing.Point(10, 10);
            this.dgvPayMethod.Name = "dgvPayMethod";
            this.dgvPayMethod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayMethod.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayMethod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkRed;
            this.dgvPayMethod.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPayMethod.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dgvPayMethod.RowTemplate.Height = 45;
            this.dgvPayMethod.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayMethod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPayMethod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayMethod.Size = new System.Drawing.Size(242, 281);
            this.dgvPayMethod.TabIndex = 1;
            this.dgvPayMethod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayMethod_CellContentClick);
            // 
            // clmType
            // 
            this.clmType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmType.HeaderText = "Type";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            // 
            // clmAmount
            // 
            this.clmAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAmount.HeaderText = "Amount";
            this.clmAmount.Name = "clmAmount";
            this.clmAmount.ReadOnly = true;
            // 
            // clmStatus
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(18)))), ((int)(((byte)(2)))));
            this.clmStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clmStatus.HeaderText = "";
            this.clmStatus.MinimumWidth = 40;
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.Text = "X";
            this.clmStatus.UseColumnTextForButtonValue = true;
            this.clmStatus.Width = 40;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbTableCat);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 48);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(447, 301);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.txtHeadBalance);
            this.panel5.Controls.Add(this.txtHeadTotal);
            this.panel5.Controls.Add(this.lblHeadBalance);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(709, 48);
            this.panel5.TabIndex = 1;
            // 
            // txtHeadBalance
            // 
            // 
            // 
            // 
            this.txtHeadBalance.CustomButton.Image = null;
            this.txtHeadBalance.CustomButton.Location = new System.Drawing.Point(168, 2);
            this.txtHeadBalance.CustomButton.Name = "";
            this.txtHeadBalance.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtHeadBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHeadBalance.CustomButton.TabIndex = 1;
            this.txtHeadBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHeadBalance.CustomButton.UseSelectable = true;
            this.txtHeadBalance.CustomButton.Visible = false;
            this.txtHeadBalance.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtHeadBalance.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtHeadBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(18)))), ((int)(((byte)(2)))));
            this.txtHeadBalance.Lines = new string[] {
        "0.00"};
            this.txtHeadBalance.Location = new System.Drawing.Point(503, 9);
            this.txtHeadBalance.MaxLength = 32767;
            this.txtHeadBalance.Name = "txtHeadBalance";
            this.txtHeadBalance.PasswordChar = '\0';
            this.txtHeadBalance.ReadOnly = true;
            this.txtHeadBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHeadBalance.SelectedText = "";
            this.txtHeadBalance.SelectionLength = 0;
            this.txtHeadBalance.SelectionStart = 0;
            this.txtHeadBalance.ShortcutsEnabled = true;
            this.txtHeadBalance.Size = new System.Drawing.Size(196, 30);
            this.txtHeadBalance.TabIndex = 10;
            this.txtHeadBalance.Text = "0.00";
            this.txtHeadBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHeadBalance.UseCustomForeColor = true;
            this.txtHeadBalance.UseSelectable = true;
            this.txtHeadBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHeadBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHeadBalance.TextChanged += new System.EventHandler(this.txtHeadBalance_TextChanged);
            // 
            // txtHeadTotal
            // 
            // 
            // 
            // 
            this.txtHeadTotal.CustomButton.Image = null;
            this.txtHeadTotal.CustomButton.Location = new System.Drawing.Point(168, 2);
            this.txtHeadTotal.CustomButton.Name = "";
            this.txtHeadTotal.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtHeadTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHeadTotal.CustomButton.TabIndex = 1;
            this.txtHeadTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHeadTotal.CustomButton.UseSelectable = true;
            this.txtHeadTotal.CustomButton.Visible = false;
            this.txtHeadTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtHeadTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtHeadTotal.Lines = new string[] {
        "0.00"};
            this.txtHeadTotal.Location = new System.Drawing.Point(117, 9);
            this.txtHeadTotal.MaxLength = 32767;
            this.txtHeadTotal.Name = "txtHeadTotal";
            this.txtHeadTotal.PasswordChar = '\0';
            this.txtHeadTotal.ReadOnly = true;
            this.txtHeadTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHeadTotal.SelectedText = "";
            this.txtHeadTotal.SelectionLength = 0;
            this.txtHeadTotal.SelectionStart = 0;
            this.txtHeadTotal.ShortcutsEnabled = true;
            this.txtHeadTotal.Size = new System.Drawing.Size(196, 30);
            this.txtHeadTotal.TabIndex = 9;
            this.txtHeadTotal.Text = "0.00";
            this.txtHeadTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHeadTotal.UseSelectable = true;
            this.txtHeadTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHeadTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblHeadBalance
            // 
            this.lblHeadBalance.AutoSize = true;
            this.lblHeadBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblHeadBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadBalance.Location = new System.Drawing.Point(368, 16);
            this.lblHeadBalance.Name = "lblHeadBalance";
            this.lblHeadBalance.Size = new System.Drawing.Size(129, 16);
            this.lblHeadBalance.TabIndex = 3;
            this.lblHeadBalance.Text = "Available Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Amount";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(153)))), ((int)(((byte)(249)))));
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(713, 393);
            this.panel4.TabIndex = 6;
            // 
            // frmFront_PayBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 425);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFront_PayBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFront_PayBill";
            this.Load += new System.EventHandler(this.frmFront_PayBill_Load);
            this.tbTableCat.ResumeLayout(false);
            this.tbCash.ResumeLayout(false);
            this.tbCash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbCreditCard.ResumeLayout(false);
            this.tbCreditCard.PerformLayout();
            this.tbCheque.ResumeLayout(false);
            this.tbCheque.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayMethod)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbTableCat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblHeadBalance;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabPage tbCash;
        private System.Windows.Forms.Button btnCashPay;
        private MetroFramework.Controls.MetroTabPage tbCheque;
        private System.Windows.Forms.Button btnChequePay;
        private MetroFramework.Controls.MetroTabPage tbCreditCard;
        private System.Windows.Forms.Button btnCardPay;
        private MetroFramework.Controls.MetroTextBox txtCashBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtChequeBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtCardBalance;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroTextBox txtHeadBalance;
        private MetroFramework.Controls.MetroTextBox txtHeadTotal;
        private MetroFramework.Controls.MetroDateTime dtChequeDate;
        private MetroFramework.Controls.MetroTextBox txtChequeNumber;
        private MetroFramework.Controls.MetroComboBox cmbChequeBank;
        private MetroFramework.Controls.MetroGrid dgvPayMethod;
        private MetroFramework.Controls.MetroComboBox cmbCardType;
        private MetroFramework.Controls.MetroTextBox txtCardNumber;
        private MetroFramework.Controls.MetroComboBox cmbCardBank;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCashPayment;
        private System.Windows.Forms.TextBox txtChequePayment;
        private System.Windows.Forms.TextBox txtCardPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmount;
        private System.Windows.Forms.DataGridViewButtonColumn clmStatus;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}