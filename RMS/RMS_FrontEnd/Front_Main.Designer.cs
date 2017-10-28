namespace RMS_FrontEnd
{
    partial class Front_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Front_Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tbMenu = new MetroFramework.Controls.MetroTabControl();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblSteward = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lTableNo = new System.Windows.Forms.Label();
            this.lOrderType = new System.Windows.Forms.Label();
            this.lSteward = new System.Windows.Forms.Label();
            this.lOrderNo = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.gbBillInfo = new System.Windows.Forms.GroupBox();
            this.btnCancelBill = new System.Windows.Forms.Button();
            this.btnHoldOrder = new System.Windows.Forms.Button();
            this.btnJoingBill = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnPayBill = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnTakeaway = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.dgvItem = new MetroFramework.Controls.MetroGrid();
            this.clmMenuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMinus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmEach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlBill.SuspendLayout();
            this.gbBillInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(199)))));
            this.pnlHeader.Controls.Add(this.button6);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(961, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(131)))), ((int)(((byte)(1)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(532, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 44);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.pnlMenu.Size = new System.Drawing.Size(155, 376);
            this.pnlMenu.TabIndex = 1;
            // 
            // tbMenu
            // 
            this.tbMenu.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tbMenu.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tbMenu.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tbMenu.HotTrack = true;
            this.tbMenu.Location = new System.Drawing.Point(11, 13);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.Size = new System.Drawing.Size(124, 350);
            this.tbMenu.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tbMenu.TabIndex = 0;
            this.tbMenu.UseSelectable = true;
            // 
            // pnlBill
            // 
            this.pnlBill.BackColor = System.Drawing.Color.White;
            this.pnlBill.Controls.Add(this.lblTableNo);
            this.pnlBill.Controls.Add(this.lblOrderType);
            this.pnlBill.Controls.Add(this.lblSteward);
            this.pnlBill.Controls.Add(this.lblOrderNo);
            this.pnlBill.Controls.Add(this.lblTime);
            this.pnlBill.Controls.Add(this.lblDate);
            this.pnlBill.Controls.Add(this.lTableNo);
            this.pnlBill.Controls.Add(this.lOrderType);
            this.pnlBill.Controls.Add(this.lSteward);
            this.pnlBill.Controls.Add(this.lOrderNo);
            this.pnlBill.Controls.Add(this.lTime);
            this.pnlBill.Controls.Add(this.lDate);
            this.pnlBill.Controls.Add(this.gbBillInfo);
            this.pnlBill.Controls.Add(this.dgvItem);
            this.pnlBill.Location = new System.Drawing.Point(251, 58);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(612, 467);
            this.pnlBill.TabIndex = 2;
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTableNo.Location = new System.Drawing.Point(456, 61);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(52, 16);
            this.lblTableNo.TabIndex = 22;
            this.lblTableNo.Text = "TB001";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOrderType.Location = new System.Drawing.Point(456, 35);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(49, 16);
            this.lblOrderType.TabIndex = 21;
            this.lblOrderType.Text = "Table";
            // 
            // lblSteward
            // 
            this.lblSteward.AutoSize = true;
            this.lblSteward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteward.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSteward.Location = new System.Drawing.Point(456, 9);
            this.lblSteward.Name = "lblSteward";
            this.lblSteward.Size = new System.Drawing.Size(64, 16);
            this.lblSteward.TabIndex = 20;
            this.lblSteward.Text = "_______";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOrderNo.Location = new System.Drawing.Point(96, 61);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(62, 16);
            this.lblOrderNo.TabIndex = 19;
            this.lblOrderNo.Text = "OR0001";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTime.Location = new System.Drawing.Point(96, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(51, 16);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "Time :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDate.Location = new System.Drawing.Point(96, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 16);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Date :";
            // 
            // lTableNo
            // 
            this.lTableNo.AutoSize = true;
            this.lTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTableNo.Location = new System.Drawing.Point(326, 61);
            this.lTableNo.Name = "lTableNo";
            this.lTableNo.Size = new System.Drawing.Size(127, 16);
            this.lTableNo.TabIndex = 16;
            this.lTableNo.Text = "Table/Room No :";
            // 
            // lOrderType
            // 
            this.lOrderType.AutoSize = true;
            this.lOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrderType.Location = new System.Drawing.Point(326, 35);
            this.lOrderType.Name = "lOrderType";
            this.lOrderType.Size = new System.Drawing.Size(95, 16);
            this.lOrderType.TabIndex = 15;
            this.lOrderType.Text = "Order Type :";
            // 
            // lSteward
            // 
            this.lSteward.AutoSize = true;
            this.lSteward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSteward.Location = new System.Drawing.Point(326, 9);
            this.lSteward.Name = "lSteward";
            this.lSteward.Size = new System.Drawing.Size(72, 16);
            this.lSteward.TabIndex = 14;
            this.lSteward.Text = "Steward :";
            // 
            // lOrderNo
            // 
            this.lOrderNo.AutoSize = true;
            this.lOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrderNo.Location = new System.Drawing.Point(11, 61);
            this.lOrderNo.Name = "lOrderNo";
            this.lOrderNo.Size = new System.Drawing.Size(79, 16);
            this.lOrderNo.TabIndex = 13;
            this.lOrderNo.Text = "Order No :";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.Location = new System.Drawing.Point(11, 35);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(51, 16);
            this.lTime.TabIndex = 12;
            this.lTime.Text = "Time :";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.Location = new System.Drawing.Point(11, 9);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(49, 16);
            this.lDate.TabIndex = 11;
            this.lDate.Text = "Date :";
            // 
            // gbBillInfo
            // 
            this.gbBillInfo.Controls.Add(this.btnCancelBill);
            this.gbBillInfo.Controls.Add(this.btnHoldOrder);
            this.gbBillInfo.Controls.Add(this.btnJoingBill);
            this.gbBillInfo.Controls.Add(this.btnBooking);
            this.gbBillInfo.Controls.Add(this.btnPayBill);
            this.gbBillInfo.Controls.Add(this.btnRoom);
            this.gbBillInfo.Controls.Add(this.btnTable);
            this.gbBillInfo.Controls.Add(this.btnTakeaway);
            this.gbBillInfo.Controls.Add(this.button1);
            this.gbBillInfo.Controls.Add(this.lblDiscount);
            this.gbBillInfo.Controls.Add(this.txtTotal);
            this.gbBillInfo.Controls.Add(this.txtDiscount);
            this.gbBillInfo.Controls.Add(this.lblTax);
            this.gbBillInfo.Controls.Add(this.lblTotal);
            this.gbBillInfo.Controls.Add(this.txtSubTotal);
            this.gbBillInfo.Controls.Add(this.txtTax);
            this.gbBillInfo.Controls.Add(this.lblSubTotal);
            this.gbBillInfo.Location = new System.Drawing.Point(3, 182);
            this.gbBillInfo.Name = "gbBillInfo";
            this.gbBillInfo.Size = new System.Drawing.Size(606, 282);
            this.gbBillInfo.TabIndex = 10;
            this.gbBillInfo.TabStop = false;
            this.gbBillInfo.Text = "Bill Information";
            // 
            // btnCancelBill
            // 
            this.btnCancelBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.btnCancelBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.btnCancelBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBill.ForeColor = System.Drawing.Color.White;
            this.btnCancelBill.Location = new System.Drawing.Point(463, 174);
            this.btnCancelBill.Name = "btnCancelBill";
            this.btnCancelBill.Size = new System.Drawing.Size(131, 41);
            this.btnCancelBill.TabIndex = 17;
            this.btnCancelBill.Text = "CANCEL BILL";
            this.btnCancelBill.UseVisualStyleBackColor = false;
            // 
            // btnHoldOrder
            // 
            this.btnHoldOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.btnHoldOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.btnHoldOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoldOrder.ForeColor = System.Drawing.Color.White;
            this.btnHoldOrder.Location = new System.Drawing.Point(314, 174);
            this.btnHoldOrder.Name = "btnHoldOrder";
            this.btnHoldOrder.Size = new System.Drawing.Size(131, 41);
            this.btnHoldOrder.TabIndex = 16;
            this.btnHoldOrder.Text = "HOLD ORDER";
            this.btnHoldOrder.UseVisualStyleBackColor = false;
            // 
            // btnJoingBill
            // 
            this.btnJoingBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.btnJoingBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.btnJoingBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoingBill.ForeColor = System.Drawing.Color.White;
            this.btnJoingBill.Location = new System.Drawing.Point(164, 174);
            this.btnJoingBill.Name = "btnJoingBill";
            this.btnJoingBill.Size = new System.Drawing.Size(131, 41);
            this.btnJoingBill.TabIndex = 15;
            this.btnJoingBill.Text = "JOIN BILL";
            this.btnJoingBill.UseVisualStyleBackColor = false;
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.btnBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(11, 174);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(131, 41);
            this.btnBooking.TabIndex = 14;
            this.btnBooking.Text = "BOOKING";
            this.btnBooking.UseVisualStyleBackColor = false;
            // 
            // btnPayBill
            // 
            this.btnPayBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(168)))), ((int)(((byte)(27)))));
            this.btnPayBill.Enabled = false;
            this.btnPayBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btnPayBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayBill.ForeColor = System.Drawing.Color.White;
            this.btnPayBill.Location = new System.Drawing.Point(463, 116);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(131, 41);
            this.btnPayBill.TabIndex = 13;
            this.btnPayBill.Text = "PAY BILL";
            this.btnPayBill.UseVisualStyleBackColor = false;
            this.btnPayBill.Click += new System.EventHandler(this.btnPayBill_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(189)))), ((int)(((byte)(249)))));
            this.btnRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(158)))), ((int)(((byte)(238)))));
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Location = new System.Drawing.Point(314, 116);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(131, 41);
            this.btnRoom.TabIndex = 12;
            this.btnRoom.Text = "ROOM";
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(110)))), ((int)(((byte)(158)))));
            this.btnTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(86)))), ((int)(((byte)(147)))));
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.Location = new System.Drawing.Point(164, 116);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(131, 41);
            this.btnTable.TabIndex = 11;
            this.btnTable.Text = "TABLE";
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnTakeaway
            // 
            this.btnTakeaway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(148)))), ((int)(((byte)(18)))));
            this.btnTakeaway.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(131)))), ((int)(((byte)(1)))));
            this.btnTakeaway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeaway.ForeColor = System.Drawing.Color.White;
            this.btnTakeaway.Location = new System.Drawing.Point(11, 116);
            this.btnTakeaway.Name = "btnTakeaway";
            this.btnTakeaway.Size = new System.Drawing.Size(131, 41);
            this.btnTakeaway.TabIndex = 10;
            this.btnTakeaway.Text = "TAKEAWAY";
            this.btnTakeaway.UseVisualStyleBackColor = false;
            this.btnTakeaway.Click += new System.EventHandler(this.btnTakeaway_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDiscount.Location = new System.Drawing.Point(8, 56);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(68, 16);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "Discount";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(392, 27);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(202, 38);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.DoubleClick += new System.EventHandler(this.txtTotal_DoubleClick);
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Location = new System.Drawing.Point(88, 55);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(202, 20);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.Text = "0.00";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTax.Location = new System.Drawing.Point(8, 83);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(34, 16);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(306, 29);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 31);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Location = new System.Drawing.Point(88, 28);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(202, 20);
            this.txtSubTotal.TabIndex = 7;
            this.txtSubTotal.Text = "0.00";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTax.Location = new System.Drawing.Point(88, 82);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(202, 20);
            this.txtTax.TabIndex = 6;
            this.txtTax.Text = "0.00";
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubTotal.Location = new System.Drawing.Point(8, 32);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(75, 16);
            this.lblSubTotal.TabIndex = 3;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
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
            this.clmMenuID,
            this.clmName,
            this.clmMinus,
            this.clmQty,
            this.clmPlus,
            this.clmEach,
            this.clmTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItem.EnableHeadersVisualStyles = false;
            this.dgvItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvItem.Location = new System.Drawing.Point(3, 93);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkRed;
            this.dgvItem.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItem.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dgvItem.RowTemplate.Height = 45;
            this.dgvItem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(518, 83);
            this.dgvItem.TabIndex = 0;
            this.dgvItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellContentClick);
            // 
            // clmMenuID
            // 
            this.clmMenuID.HeaderText = "Menu ID";
            this.clmMenuID.Name = "clmMenuID";
            this.clmMenuID.Visible = false;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmQty.HeaderText = "Qty";
            this.clmQty.MinimumWidth = 40;
            this.clmQty.Name = "clmQty";
            this.clmQty.Width = 40;
            // 
            // clmPlus
            // 
            this.clmPlus.HeaderText = "+";
            this.clmPlus.MinimumWidth = 45;
            this.clmPlus.Name = "clmPlus";
            this.clmPlus.Text = "+";
            this.clmPlus.UseColumnTextForButtonValue = true;
            this.clmPlus.Width = 45;
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
            // DateTimeUpdate
            // 
            this.DateTimeUpdate.Enabled = true;
            this.DateTimeUpdate.Tick += new System.EventHandler(this.DateTimeUpdate_Tick);
            // 
            // Front_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(962, 532);
            this.Controls.Add(this.pnlBill);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Front_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Front_Main_SizeChanged);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlBill.ResumeLayout(false);
            this.pnlBill.PerformLayout();
            this.gbBillInfo.ResumeLayout(false);
            this.gbBillInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlBill;
        private MetroFramework.Controls.MetroGrid dgvItem;
        private MetroFramework.Controls.MetroTabControl tbMenu;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.GroupBox gbBillInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPayBill;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnTakeaway;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblSteward;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lTableNo;
        private System.Windows.Forms.Label lOrderType;
        private System.Windows.Forms.Label lSteward;
        private System.Windows.Forms.Label lOrderNo;
        private System.Windows.Forms.Timer DateTimeUpdate;
        private System.Windows.Forms.Button btnCancelBill;
        private System.Windows.Forms.Button btnHoldOrder;
        private System.Windows.Forms.Button btnJoingBill;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMenuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewButtonColumn clmMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
        private System.Windows.Forms.DataGridViewButtonColumn clmPlus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
    }
}