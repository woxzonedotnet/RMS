using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using DataAccess;
using BusinessObject;
using BusinessLogic;

namespace RMS_FrontEnd
{
    public partial class Front_Main : Form
    {

        #region Variable
        int screenWidth = 0;
        int screenHeight = 0;
        Point startPoint;
        Point menuscroll;
        string LocCode = "LOC01";
        string subLocCode = "ddd";
        #endregion

        #region Object
        #region UI
        
        #endregion

        objFoodOrder oFoodOrder = new objFoodOrder();
        clsFoodOrder cFoodOrder = new clsFoodOrder();
        clsDBConnection cDBConnection = new clsDBConnection();
        #endregion

        public Front_Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            screenWidth = this.Width;
            screenHeight = this.Height;
            DataTable dtMenu = new DataTable();
            string where = "fldLocationCode = '" + LocCode + "'";
            dtMenu = cDBConnection.SearchData("tbl_MenuDepartment", where);

            #region Header
            //panel Header
            pnlHeader.BackColor = Color.FromArgb(0, 154, 199);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Height = (screenHeight * 7) / 100;
            pnlHeader.Width = screenWidth;

            btnClose.Location = new Point(screenWidth - 45, 8);
            #endregion

            #region Menu
            //panel Menu
            //pnlMenu.BackColor = Color.FromArgb(6, 199, 255);
            pnlMenu.BackColor = Color.White;
            pnlMenu.Location = new Point(0, 58);
            pnlMenu.Height = (screenHeight * 90) / 100;
            pnlMenu.Width = (screenWidth * 50) / 100;

            #region TAB
            //Tab View
            //MetroFramework.Controls.MetroTabControl tbMenu = new MetroFramework.Controls.MetroTabControl();
            tbMenu.Location = new Point(10, 10);
            tbMenu.Width = pnlMenu.Width - 20;
            tbMenu.Height = pnlMenu.Height - 20;
            tbMenu.FontSize = MetroFramework.MetroTabControlSize.Tall;
            tbMenu.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            tbMenu.SizeMode = TabSizeMode.FillToRight;
            tbMenu.Appearance = TabAppearance.Normal;
            #endregion

            #region TAB_Page
            for (int i = 0; i < dtMenu.Rows.Count; i++)
            {
                MetroFramework.Controls.MetroTabPage tb = new MetroFramework.Controls.MetroTabPage();
                tb.Text = dtMenu.Rows[i]["fldMenuDepartmentName"].ToString();
                tb.Name = dtMenu.Rows[i]["fldMenuDepartmentCode"].ToString();

                #region Category
                //Sub Category
                GroupBox gbSubCategory = new GroupBox();
                gbSubCategory.Location = new Point(10, 10);
                gbSubCategory.Width = tbMenu.Width - 30;
                gbSubCategory.Height = (tbMenu.Height * 18) / 100;
                gbSubCategory.BackColor = Color.White;
                gbSubCategory.Text = "CATEGORY";
                gbSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                tb.Controls.Add(gbSubCategory);

                //Button Previous
                Button btnSubCategoryPrevious = new Button();
                btnSubCategoryPrevious.Location = new Point(10, 30);
                btnSubCategoryPrevious.Height = gbSubCategory.Height - 50;
                btnSubCategoryPrevious.Width = (gbSubCategory.Width * 7) / 100;
                btnSubCategoryPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                btnSubCategoryPrevious.ForeColor = Color.White;
                btnSubCategoryPrevious.Text = "<";
                btnSubCategoryPrevious.BackColor = Color.FromArgb(240, 173, 78);
                btnSubCategoryPrevious.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 162, 34);
                btnSubCategoryPrevious.FlatStyle = FlatStyle.Flat;
                gbSubCategory.Controls.Add(btnSubCategoryPrevious);


                //Button Panel
                MetroFramework.Controls.MetroPanel pnlSubCategory = new MetroFramework.Controls.MetroPanel();
                pnlSubCategory.Location = new Point(btnSubCategoryPrevious.Location.X + btnSubCategoryPrevious.Width + 5, 30);
                pnlSubCategory.Height = gbSubCategory.Height - 50;
                pnlSubCategory.Width = (gbSubCategory.Width * 81) / 100;
                pnlSubCategory.UseCustomBackColor = true;
                pnlSubCategory.BackColor = Color.FromArgb(255, 255, 255);
                pnlSubCategory.AutoScroll = true;
                pnlSubCategory.AutoScrollPosition = new Point(10, 10);
                pnlSubCategory.VerticalScrollbarHighlightOnWheel = true;
                gbSubCategory.Controls.Add(pnlSubCategory);



                //Button Next
                Button btnSubCategoryNext = new Button();
                btnSubCategoryNext.Location = new Point(pnlSubCategory.Location.X + pnlSubCategory.Width + 5, 30);
                btnSubCategoryNext.Height = gbSubCategory.Height - 50;
                btnSubCategoryNext.Width = (gbSubCategory.Width * 7) / 100;
                btnSubCategoryNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                btnSubCategoryNext.ForeColor = Color.White;
                btnSubCategoryNext.Text = ">";
                btnSubCategoryNext.BackColor = Color.FromArgb(240, 173, 78);
                btnSubCategoryNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 162, 34);
                btnSubCategoryNext.FlatStyle = FlatStyle.Flat;
                gbSubCategory.Controls.Add(btnSubCategoryNext);

                //previous button click event
                btnSubCategoryPrevious.Click += delegate
                {
                    try
                    {
                        pnlSubCategory.HorizontalScroll.Value -= 200;
                    }
                    catch (Exception ex)
                    {
                        pnlSubCategory.AutoScrollPosition = new Point(0, 0);
                    }
                };

                //next button click event
                btnSubCategoryNext.Click += delegate
                {
                    try
                    {
                        pnlSubCategory.HorizontalScroll.Value += 200;
                    }
                    catch (Exception ex)
                    {
                        //pnlSubCategory.AutoScrollPosition = new Point(0, 0);
                    }

                };

                #endregion

                #region Item List
                //Item List
                GroupBox gbItems = new GroupBox();
                gbItems.Location = new Point(10, gbSubCategory.Location.Y + gbSubCategory.Height + 20);
                gbItems.Width = tbMenu.Width - 100;
                gbItems.Height = (tbMenu.Height * 70) / 100;
                gbItems.BackColor = Color.White;
                gbItems.Text = "ITEMS";
                gbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                tb.Controls.Add(gbItems);

                //Button Panel
                MetroFramework.Controls.MetroPanel pnlItemList = new MetroFramework.Controls.MetroPanel();
                pnlItemList.Location = new Point(2, 20);
                pnlItemList.Height = gbItems.Height - 22;
                pnlItemList.Width = gbItems.Width - 4;
                pnlItemList.UseCustomBackColor = true;
                pnlItemList.BackColor = Color.FromArgb(255, 255, 255);
                pnlItemList.AutoScroll = true;
                pnlItemList.AutoScrollPosition = new Point(10, 10);
                gbItems.Controls.Add(pnlItemList);

                //Button Up
                Button btnItemUp = new Button();
                btnItemUp.Location = new Point(gbItems.Location.X + gbItems.Width + 5, gbSubCategory.Location.Y + gbSubCategory.Height + 30);
                btnItemUp.Height = 40;
                btnItemUp.Width = (tbMenu.Width * 10) / 100;
                btnItemUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                btnItemUp.ForeColor = Color.White;
                btnItemUp.Text = "˄";
                btnItemUp.BackColor = Color.FromArgb(240, 173, 78);
                btnItemUp.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 162, 34);
                btnItemUp.FlatStyle = FlatStyle.Flat;
                tb.Controls.Add(btnItemUp);

                //Button Down
                Button btnItemDown = new Button();
                btnItemDown.Location = new Point(gbItems.Location.X + gbItems.Width + 5, btnItemUp.Location.Y + btnItemUp.Height + 10);
                btnItemDown.Height = 40;
                btnItemDown.Width = (tbMenu.Width * 10) / 100;
                btnItemDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                btnItemDown.ForeColor = Color.White;
                btnItemDown.Text = "˅";
                btnItemDown.BackColor = Color.FromArgb(240, 173, 78);
                btnItemDown.FlatAppearance.MouseOverBackColor = Color.FromArgb(238, 162, 34);
                btnItemDown.FlatStyle = FlatStyle.Flat;
                tb.Controls.Add(btnItemDown);

                //Up button click event
                btnItemUp.Click += delegate
                {
                    try
                    {
                        pnlItemList.VerticalScroll.Value -= 200;
                    }
                    catch (Exception ex)
                    {
                        pnlItemList.AutoScrollPosition = new Point(0, 0);
                    }
                };

                //next button click event
                btnItemDown.Click += delegate
                {
                    try
                    {
                        pnlItemList.VerticalScroll.Value += 200;
                    }
                    catch (Exception ex)
                    {
                        //pnlItemList.AutoScrollPosition = new Point(0, 0);
                    }

                };

                #endregion

                btnCategoryConfig(gbItems, pnlItemList, pnlSubCategory, tb.Name);

                tbMenu.TabPages.Add(tb);
            }//Tab Page End

            #endregion

            #endregion

            #region Bill
            //panel Bill
            pnlBill.BackColor = Color.FromArgb(255, 255, 255);
            pnlBill.Location = new Point(pnlMenu.Location.X + pnlMenu.Width, 58);
            pnlBill.Height = (screenHeight * 90) / 100;
            pnlBill.Width = (screenWidth * 50) / 100;
            DateTimeUpdate.Start();
            pnlBill.BringToFront();

            //Bill Head
            lDate.Location = new Point(5, 10);
            lblDate.Location = new Point(lDate.Location.X + lDate.Width + 5, 10);

            lSteward.Location = new Point(((pnlBill.Width*50)/100),10);
            lblSteward.Location = new Point(lSteward.Location.X + lSteward.Width + 5, 10);

            lTime.Location = new Point(5, lDate.Location.Y + lDate.Height+10);
            lblTime.Location = new Point(lTime.Location.X + lTime.Width + 5, lDate.Location.Y + lDate.Height+10);

            lOrderType.Location = new Point(((pnlBill.Width * 50) / 100), lSteward.Location.Y + lSteward.Height + 10);
            lblOrderType.Location = new Point(lOrderType.Location.X + lOrderType.Width + 5, lSteward.Location.Y + lSteward.Height + 10);

            lOrderNo.Location = new Point(5, lTime.Location.Y + lTime.Height + 10);
            lblOrderNo.Location = new Point(lOrderNo.Location.X + lOrderNo.Width + 5, lTime.Location.Y + lTime.Height + 10);

            lTableNo.Location = new Point(((pnlBill.Width * 50) / 100), lOrderType.Location.Y + lOrderType.Height + 10);
            lblTableNo.Location = new Point(lTableNo.Location.X + lTableNo.Width + 5, lOrderType.Location.Y + lOrderType.Height + 10);

            //Item Grid
            dgvItem.Location = new Point(5, 90);
            dgvItem.Height = (pnlBill.Height * 45) / 100;
            dgvItem.Width = pnlBill.Width - 10;
            dgvItem.Columns["clmName"].Width = (dgvItem.Width * 40) / 100;
            dgvItem.BorderStyle = BorderStyle.FixedSingle;
            pnlBill.Controls.Add(dgvItem);

            //Bill Info
            gbBillInfo.Location = new Point(5, dgvItem.Location.Y + dgvItem.Height + 10);
            gbBillInfo.Height = (pnlBill.Height * 40) / 100;
            gbBillInfo.Width = pnlBill.Width - 10;
            gbBillInfo.BackColor = Color.White;
            gbBillInfo.Text = "BILL INFORMATION";
            gbBillInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            pnlBill.Controls.Add(gbBillInfo);

            int gbBillWidth = gbBillInfo.Width;
            int gbBillHeight = gbBillInfo.Height;

            lblSubTotal.Location = new Point(5, 25);
            lblSubTotal.Width = (gbBillWidth * 8) / 100;
            lblSubTotal.Height = (gbBillHeight * 2) / 100;
            lblSubTotal.Font = fontRechange(gbBillInfo, 2);

            txtSubTotal.Location = new Point(lblSubTotal.Location.X + lblSubTotal.Width, 25);
            txtSubTotal.Width = (gbBillWidth * 28) / 100;
            txtSubTotal.Height = (gbBillHeight * 2) / 100;
            txtSubTotal.AutoSize = true;
            txtSubTotal.Font = fontRechange(gbBillInfo, 2);

            lblTotal.Location = new Point(txtSubTotal.Location.X + txtSubTotal.Width + 5, 25);
            lblTotal.Width = (gbBillWidth * 20) / 100;
            lblTotal.Height = (gbBillHeight * 2) / 100;
            lblTotal.Font = fontRechange(gbBillInfo, 4);

            txtTotal.Location = new Point(lblTotal.Location.X + lblTotal.Width, 25);
            txtTotal.Width = (gbBillWidth * 35) / 100;
            txtTotal.Height = (gbBillHeight * 2) / 100;
            txtTotal.AutoSize = true;
            txtTotal.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            txtTotal.Font = fontRechange(gbBillInfo, 4);

            lblDiscount.Location = new Point(5, lblSubTotal.Location.Y + lblSubTotal.Height + 15);
            lblDiscount.Width = (gbBillWidth * 8) / 100;
            lblDiscount.Height = (gbBillHeight * 2) / 100;
            lblDiscount.Font = fontRechange(gbBillInfo, 2);

            txtDiscount.Location = new Point(lblSubTotal.Location.X + lblSubTotal.Width, txtSubTotal.Location.Y + txtSubTotal.Height + 5);
            txtDiscount.Width = (gbBillWidth * 28) / 100;
            txtDiscount.Height = (gbBillHeight * 2) / 100;
            txtDiscount.Font = fontRechange(gbBillInfo, 2);

            lblTax.Location = new Point(5, lblDiscount.Location.Y + lblDiscount.Height + 15);
            lblTax.Width = (gbBillWidth * 8) / 100;
            lblTax.Height = (gbBillHeight * 2) / 100;
            lblTax.Font = fontRechange(gbBillInfo, 2);

            txtTax.Location = new Point(lblSubTotal.Location.X + lblSubTotal.Width, txtDiscount.Location.Y + txtDiscount.Height + 5);
            txtTax.Width = (gbBillWidth * 28) / 100;
            txtTax.Height = (gbBillHeight * 2) / 100;
            txtTax.Font = fontRechange(gbBillInfo, 2);

            //Buttons
            btnTakeaway.Location = new Point(5, lblTax.Location.Y + lblTax.Height + 10);
            btnTakeaway.Width = (gbBillWidth * 20) / 100;
            btnTakeaway.Height = (gbBillHeight * 15) / 100;
            btnTakeaway.Font = fontRechange(btnTakeaway, 9);

            btnTable.Location = new Point(btnTakeaway.Location.X + btnTakeaway.Width + 10, lblTax.Location.Y + lblTax.Height + 10);
            btnTable.Width = (gbBillWidth * 20) / 100;
            btnTable.Height = (gbBillHeight * 15) / 100;
            btnTable.Font = fontRechange(btnTable, 10);

            btnRoom.Location = new Point(btnTable.Location.X + btnTable.Width + 10, lblTax.Location.Y + lblTax.Height + 10);
            btnRoom.Width = (gbBillWidth * 20) / 100;
            btnRoom.Height = (gbBillHeight * 15) / 100;
            btnRoom.Font = fontRechange(btnRoom, 10);

            btnPayBill.Location = new Point(btnRoom.Location.X + btnRoom.Width + 10, lblTax.Location.Y + lblTax.Height + 10);
            btnPayBill.Width = (gbBillWidth * 20) / 100;
            btnPayBill.Height = (gbBillHeight * 15) / 100;
            btnPayBill.Font = fontRechange(btnPayBill, 10);

            btnBooking.Location = new Point(5, btnTakeaway.Location.Y + btnTakeaway.Height + 10);
            btnBooking.Width = (gbBillWidth * 20) / 100;
            btnBooking.Height = (gbBillHeight * 15) / 100;
            btnBooking.Font = fontRechange(btnBooking, 10);

            btnJoingBill.Location = new Point(btnBooking.Location.X + btnBooking.Width + 10, btnTakeaway.Location.Y + btnTakeaway.Height + 10);
            btnJoingBill.Width = (gbBillWidth * 20) / 100;
            btnJoingBill.Height = (gbBillHeight * 15) / 100;
            btnJoingBill.Font = fontRechange(btnJoingBill, 10);

            btnHoldOrder.Location = new Point(btnJoingBill.Location.X + btnJoingBill.Width + 10, btnTakeaway.Location.Y + btnTakeaway.Height + 10);
            btnHoldOrder.Width = (gbBillWidth * 20) / 100;
            btnHoldOrder.Height = (gbBillHeight * 15) / 100;
            btnHoldOrder.Font = fontRechange(btnHoldOrder, 10);

            btnCancelBill.Location = new Point(btnHoldOrder.Location.X + btnHoldOrder.Width + 10, btnTakeaway.Location.Y + btnTakeaway.Height + 10);
            btnCancelBill.Width = (gbBillWidth * 20) / 100;
            btnCancelBill.Height = (gbBillHeight * 15) / 100;
            btnCancelBill.Font = fontRechange(btnCancelBill, 10);

            #endregion

            #region Sortcut
            //panel SortCut
            //pnlShortCut.BackColor = Color.FromArgb(6, 199, 255);
            //pnlShortCut.Location = new Point(pnlBill.Location.X + pnlBill.Width, 58);
            //pnlShortCut.Height = (screenHeight * 90) / 100;
            //pnlShortCut.Width = (screenWidth * 10) / 100;

            #endregion
            

            

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        #region Color Function
        public Color[] convertToColorArray(string[] colorList)
        {
            Color[] color = new Color[colorList.Length];
            for (int j = 0; j < colorList.Length; j++)
            {
                var splitString = colorList[j].Split(',');
                int red, green, blue;
                red = int.Parse(splitString[0]);
                green = int.Parse(splitString[1]);
                blue = int.Parse(splitString[2]);

                color[j] = Color.FromArgb(red, green, blue);
            }
            return color;
        }

        public Color convertToColorArray(string strcolor)
        {
            Color color = new Color();

            var splitString = strcolor.Split(',');
            int red, green, blue;
            red = int.Parse(splitString[0]);
            green = int.Parse(splitString[1]);
            blue = int.Parse(splitString[2]);
            color = Color.FromArgb(red, green, blue);

            return color;
        }
        #endregion

        #region Category List Button Adding
        public void btnCategoryConfig(GroupBox gbItems,MetroFramework.Controls.MetroPanel pnlItemList, MetroFramework.Controls.MetroPanel pnlSubCategory, string tabName)
        {
            //metroPanel1.Controls.Clear();
            //metroPanel1.VerticalScrollbar = true;

            DataTable dtCategory = new DataTable();
            string code = tabName;
            string where = "fldMenuDepartmentCode = '" + code + "'";
            dtCategory = cDBConnection.SearchData("tbl_MenuCategory", where);

            //string[] btnName = new string[] { "ADD", "Cancel", "CuT", "Put", "lol", "ADD", "Cancel", "CuT", "Put", "lol" };
            //string[] btnBackColor = new string[] { "6,199,255", "0,255,0", "0,0,255", "125,24,156", "200,100,50", "6,199,255", "0,255,0", "0,0,255", "125,24,156", "200,100,50" };

            //Color[] backColor = convertToColorArray(btnBackColor);
            int x = 15;
            int y = 5;
            Point newLoc = new Point(x, y); // Set whatever you want for initial location

            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                Button b = new Button();
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderColor = Color.FromArgb(0, 154, 199);
                b.Size = new Size(110, 50);
                b.Text = dtCategory.Rows[i]["fldMenuCategoryName"].ToString();
                b.Name = dtCategory.Rows[i]["fldMenuCategoryCode"].ToString();
                b.BackColor = Color.FromArgb(250, 250, 250);
                b.ForeColor = Color.FromArgb(119, 168, 27);
                b.FlatAppearance.BorderColor = Color.FromArgb(119, 168, 27);
                b.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 219, 89);
                b.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 168, 27);
                b.Location = newLoc;
                newLoc.Offset(0, b.Height + 10);
                pnlSubCategory.Controls.Add(b);
                newLoc = new Point(x += 140, y);

                b.Click += delegate
                {
                    try
                    {
                        //MessageBox.Show(b.Text+ "   Clicked");
                        gbItems.Text = b.Text + " ITEMS";
                        btnItemConfig(pnlItemList, b.Name);
                    }
                    catch (Exception ex)
                    {
                        
                    }
                };
            }

            //for (int j = 0; j < 10; j++)
            //{
            //    //for (int i = 0; i < 1; ++i)
            //    //{
            //    Button b = new Button();
            //    b.FlatStyle = FlatStyle.Flat;
            //    b.FlatAppearance.BorderColor = Color.FromArgb(0, 154, 199);
            //    b.Size = new Size(80, 50);
            //    b.Text = btnName[j];
            //    b.BackColor = backColor[j];
            //    b.ForeColor = Color.White;
            //    b.Location = newLoc;
            //    newLoc.Offset(0, b.Height + 10);
            //    pnlSubCategory.Controls.Add(b);
            //    //}
            //    newLoc = new Point(x += 100, y);
            //}
        }
        #endregion

        #region Item List Button Adding
        public void btnItemConfig(MetroFramework.Controls.MetroPanel pnlItemList, string tabName)
        {
            //metroPanel1.Controls.Clear();
            //metroPanel1.VerticalScrollbar = true;
            pnlItemList.Controls.Clear();

            DataTable dtCategory = new DataTable();
            string code = tabName;
            string where = "fldMenuCategoryCode = '" + code + "'";
            dtCategory = cDBConnection.SearchData("tbl_MenuDetails", where);

            //string[] btnName = new string[] { "ADD", "Cancel", "CuT", "Put", "lol", "ADD", "Cancel", "CuT", "Put", "lol" };
            //string[] btnBackColor = new string[] { "6,199,255", "0,255,0", "0,0,255", "125,24,156", "200,100,50", "6,199,255", "0,255,0", "0,0,255", "125,24,156", "200,100,50" };

            //Color[] backColor = convertToColorArray(btnBackColor);
            int x = 15;
            int y = 10;
            Point newLoc = new Point(x, y); // Set whatever you want for initial location

            int DataCount = dtCategory.Rows.Count;
            int count = 0;

            //for (int j=0; j < Math.Abs(DataCount/4)+1; j++)
            //{
                for (int i = 0; i < DataCount; i++)
                {
                    try
                    {
                        Panel buttonBackPnl = new Panel();
                        buttonBackPnl.Size = new System.Drawing.Size(100,78);
                        buttonBackPnl.Location = newLoc;
                        buttonBackPnl.BackColor = System.Drawing.ColorTranslator.FromHtml("#"+dtCategory.Rows[i]["fldBackgroundColor"].ToString());

                        Panel imgPanel = new Panel();
                        imgPanel.Size = new System.Drawing.Size(buttonBackPnl.Width - 4, (buttonBackPnl.Height * 70) / 100);
                        imgPanel.Location = new Point(2,2);
                        //imgPanel.BackColor = Color.Red;
                        buttonBackPnl.Controls.Add(imgPanel);
                        PictureBox picMenuButton = new PictureBox();
                        imgPanel.Controls.Add(picMenuButton);
                        picMenuButton.Name = dtCategory.Rows[i]["fldMenuCode"].ToString();
                        picMenuButton.Dock = DockStyle.Fill;
                        byte[] photoArray = (byte[])dtCategory.Rows[i]["fldImage"];
                        ArrayToImageBox(photoArray,picMenuButton);

                        Panel ButtonTextPnl = new Panel();
                        ButtonTextPnl.Size = new System.Drawing.Size(buttonBackPnl.Width, (buttonBackPnl.Height * 30) / 100);
                        //ButtonTextPnl.BackColor = Color.Red;
                        buttonBackPnl.Controls.Add(ButtonTextPnl);
                        ButtonTextPnl.Dock = DockStyle.Bottom;

                        Label buttonText = new Label();
                        ButtonTextPnl.Controls.Add(buttonText);
                        buttonText.Dock = DockStyle.Fill;
                        buttonText.TextAlign = ContentAlignment.MiddleCenter;
                        buttonText.Text = dtCategory.Rows[i]["fldButtonName"].ToString();
                        buttonText.ForeColor = System.Drawing.ColorTranslator.FromHtml("#" + dtCategory.Rows[i]["fldForegroundColor"].ToString());
                        string fontFamily = dtCategory.Rows[i]["fldFontName"].ToString();
                        float fontsize = float.Parse(dtCategory.Rows[i]["fldFontSize"].ToString());
                        FontStyle fontStyle = (FontStyle)Enum.Parse(typeof(FontStyle),dtCategory.Rows[i]["fldFontStyle"].ToString(), true);
                        buttonText.Font = new System.Drawing.Font(fontFamily, fontsize, fontStyle);

                        picMenuButton.Click += delegate
                        {
                            try
                            {
                                string where2 = "fldMenuCode = '" + picMenuButton.Name + "'";
                                DataTable dtCategoryClick = new DataTable();
                                dtCategoryClick = cDBConnection.SearchData("tbl_MenuDetails", where2);
                                bool existing = false;
                                for (int k = 0; k < dgvItem.Rows.Count; k++)
                                {
                                    if (dgvItem.Rows[k].Cells["clmMenuID"].Value != null && picMenuButton.Name.Equals(dgvItem.Rows[k].Cells["clmMenuID"].Value))
                                    {
                                        int qty = Convert.ToInt32(dgvItem.Rows[k].Cells["clmQty"].Value);
                                        dgvItem.Rows[k].Cells["clmQty"].Value = qty + 1;
                                        existing = true;
                                        break;
                                    }
                                    else
                                    {
                                        existing = false;
                                    }
                                }
                                if (!existing)
                                {
                                    int noOfRows = 0;
                                    noOfRows = dgvItem.Rows.Count;
                                    DataGridViewRow row = new DataGridViewRow();
                                    row.CreateCells(dgvItem);
                                    row.Cells[0].Value = dtCategoryClick.Rows[0]["fldMenuCode"].ToString();
                                    row.Cells[1].Value = dtCategoryClick.Rows[0]["fldDescription"].ToString();
                                    row.Cells[3].Value = 1;
                                    row.Cells[5].Value = dtCategoryClick.Rows[0]["fldSellingPrice"].ToString();
                                    row.Cells[6].Value = dtCategoryClick.Rows[0]["fldSellingPrice"].ToString();
                                    row.Height = 40;
                                    dgvItem.Rows.Add(row);
                                    
                                }
                                totalCalculate();
                            }
                            catch (Exception ex)
                            {

                            }
                        };
                        //Button b = new Button();
                        //b.FlatStyle = FlatStyle.Flat;
                        //b.FlatAppearance.BorderColor = Color.FromArgb(0, 154, 199);
                        //b.Size = new Size(110, 50);
                        //b.Text = dtCategory.Rows[count]["fldMenuCategoryName"].ToString();
                        //b.Name = dtCategory.Rows[count]["fldMenuCategoryCode"].ToString();
                        //b.BackColor = backColor[count];
                        //b.ForeColor = Color.White;
                        //b.Location = newLoc;
                        //newLoc.Offset(0, b.Height + 10);
                        pnlItemList.Controls.Add(buttonBackPnl);
                        newLoc = new Point(x += 140, y);
                        count++;
                    }
                    catch (Exception ex)
                    {

                    }
                }
                newLoc = new Point(x=15, y += 70);
            //}
        }
        #endregion

        private void DateTimeUpdate_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.Date.ToString("yyyy-MMM-dd");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
            Application.DoEvents();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmFront_Calculator Calculator = new frmFront_Calculator();
            Calculator.Show();
        }

        private void txtTotal_DoubleClick(object sender, EventArgs e)
        {
            frmFront_Calculator Calculator = new frmFront_Calculator(this.txtTotal);
            Calculator.Show();
        }

        public void totalCalculate()
        {
            double subTotal = 0;
            double Total = 0;

            for (int i = 0; i < dgvItem.Rows.Count; i++)
            {
                int qty = Convert.ToInt32(dgvItem.Rows[i].Cells["clmQty"].Value);
                double each = Convert.ToDouble(dgvItem.Rows[i].Cells["clmEach"].Value);
                double rowTotal =  qty * each;
                dgvItem.Rows[i].Cells["clmTotal"].Value = rowTotal;
                subTotal += rowTotal;
            }
            txtSubTotal.Text = subTotal.ToString();
            double discount = Convert.ToDouble(txtDiscount.Text);
            double tax = Convert.ToDouble(txtTax.Text);
            Total = subTotal - discount + tax;
            txtTotal.Text = Total.ToString();
        }

        #region Image Functions
        public byte[] ImageBoxToArray(PictureBox picMenuButton)
        {
            byte[] imgArray;

            MemoryStream ms = new MemoryStream();
            picMenuButton.Image.Save(ms, ImageFormat.Png);
            imgArray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(imgArray, 0, imgArray.Length);

            return imgArray;
        }

        public void ArrayToImageBox(byte[] imgArray, PictureBox picMenuButton)
        {
            MemoryStream ms = new MemoryStream(imgArray);
            picMenuButton.Image = Image.FromStream(ms);
            picMenuButton.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        #endregion

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItem.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0 && dgvItem.Columns[e.ColumnIndex].Name =="clmMinus")
            {
                int val = Convert.ToInt32(dgvItem.CurrentRow.Cells["clmQty"].Value);
                if (val > 0)
                {
                    dgvItem.CurrentRow.Cells["clmQty"].Value = --val;
                }
                else
                {
                    dgvItem.CurrentRow.Cells["clmQty"].Value = --val;
                    if (val < 0)
                    {
                        DialogResult response = MessageBox.Show("Do You Want To Remove This From List?", "Remove Item", MessageBoxButtons.YesNo);
                        if (response == DialogResult.Yes)
                        {
                            dgvItem.Rows.RemoveAt(dgvItem.CurrentRow.Index);
                        }
                        else
                        {
                            dgvItem.CurrentRow.Cells["clmQty"].Value = 0;
                        }
                    }
                }
                
            }
            else if (dgvItem.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0 && dgvItem.Columns[e.ColumnIndex].Name == "clmPlus")
            {
                int val = Convert.ToInt32(dgvItem.CurrentRow.Cells["clmQty"].Value);
                dgvItem.CurrentRow.Cells["clmQty"].Value = ++val;
            }

            totalCalculate();
        }

        private void btnTakeaway_Click(object sender, EventArgs e)
        {
            if (dgvItem.Rows.Count > 0)
            {
                frmFront_Steward steward = new frmFront_Steward(lblSteward);
                steward.ShowDialog();
                this.lblOrderType.Text = "Take Away";
                if (dgvItem.Rows.Count > 0)
                {
                    this.btnPayBill.Enabled = true;
                }
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            if (dgvItem.Rows.Count > 0)
            {
                frmFront_Steward steward = new frmFront_Steward(lblSteward);
                steward.ShowDialog();
                this.lblOrderType.Text = "Table";

                frmFront_Table table = new frmFront_Table(lblTableNo);
                table.ShowDialog();

                if (dgvItem.Rows.Count > 0)
                {
                    this.btnPayBill.Enabled = true;
                }
            }
            else
            {
                frmFront_Table table = new frmFront_Table();
                table.ShowDialog();
                if (dgvItem.Rows.Count > 0)
                {
                    this.btnPayBill.Enabled = true;
                }
            }
            
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            if (dgvItem.Rows.Count > 0)
            {
                frmFront_Steward steward = new frmFront_Steward(lblSteward);
                steward.ShowDialog();
                this.lblOrderType.Text = "Room";
                if (dgvItem.Rows.Count > 0)
                {
                    this.btnPayBill.Enabled = true;
                }
                
            }
            
        }

        private void Front_Main_SizeChanged(object sender, EventArgs e)
        {
            
        }

        public Font fontRechange(Control ctrl,double size)
        {
            Font newFont = new System.Drawing.Font("Microsoft Sans Serif", (float)((ctrl.Width*size)/100), FontStyle.Bold);
            return newFont;
        }

        public void placeOrder(string orderNo,string stewardCode,string tableCode,double subTotal,double discount,double tax,DataGridView dataGrid)
        {
            oFoodOrder.LocationCode = LocCode;
            oFoodOrder.SubLocationCode = subLocCode;
            oFoodOrder.OrderNo= orderNo;
            oFoodOrder.StewardCode = stewardCode;
            oFoodOrder.TableCode = tableCode;
            oFoodOrder.Date = DateTime.Today.Date;
            oFoodOrder.Time = DateTime.Today;
            oFoodOrder.SubTotal = subTotal;
            oFoodOrder.Discount = discount;
            oFoodOrder.Tax = tax;
            oFoodOrder.OrderState = 2;

            oFoodOrder.Items = DataGridToDataTable(dataGrid,orderNo);

            cFoodOrder.InsertUpdateData(oFoodOrder);
        }

        public DataTable DataGridToDataTable(DataGridView dgv, string strOrderNo)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("fldOrderNo");
            dt.Columns.Add("fldMenuCode");
            dt.Columns.Add("fldMenuName");
            dt.Columns.Add("fldQty");
            dt.Columns.Add("fldCost");


            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                try
                {
                    dRow["fldOrderNo"] = strOrderNo;
                    dRow["fldMenuCode"] = row.Cells["clmMenuID"].Value.ToString();
                    dRow["fldMenuName"] = row.Cells["clmName"].Value.ToString();
                    dRow["fldQty"] = row.Cells["clmQty"].Value.ToString();
                    dRow["fldCost"] = Convert.ToDouble(row.Cells["clmEach"].Value);
                    dt.Rows.Add(dRow);
                }
                catch (Exception ex)
                {

                }

            }
            return dt;
        }
    }
}
