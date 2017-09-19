﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace RMS_FrontEnd
{
    public partial class Main : Form
    {

        #region Variable
        int screenWidth = 0;
        int screenHeight = 0;
        Point startPoint;
        Point menuscroll;
        #endregion

        #region Object
        #region UI
        
        #endregion

        clsDBConnection cDBConnection = new clsDBConnection();
        #endregion

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            screenWidth = this.Width;
            screenHeight = this.Height;
            DataTable dtMenu = new DataTable();
            string code = "LOC01";
            string where = "fldLocationCode = '"+code+"'";
            dtMenu = cDBConnection.SearchData("tbl_MenuDepartment",where);
            
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
            pnlMenu.BackColor = Color.FromArgb(6, 199, 255);
            pnlMenu.Location = new Point(3, 58);
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
            btnSubCategoryPrevious.ForeColor = Color.DarkRed;
            btnSubCategoryPrevious.Text = "<";
            btnSubCategoryPrevious.BackColor = Color.FromArgb(6, 199, 255);
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
            pnlSubCategory.AutoScrollPosition = new Point(10,10);
            gbSubCategory.Controls.Add(pnlSubCategory);
            


            //Button Next
            Button btnSubCategoryNext = new Button();
            btnSubCategoryNext.Location = new Point(pnlSubCategory.Location.X + pnlSubCategory.Width + 5, 30);
            btnSubCategoryNext.Height = gbSubCategory.Height - 50;
            btnSubCategoryNext.Width = (gbSubCategory.Width * 7) / 100;
            btnSubCategoryNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            btnSubCategoryNext.ForeColor = Color.DarkRed;
            btnSubCategoryNext.Text = ">";
            btnSubCategoryNext.BackColor = Color.FromArgb(6, 199, 255);
            btnSubCategoryNext.FlatStyle = FlatStyle.Flat;
            gbSubCategory.Controls.Add(btnSubCategoryNext);

            //previous button click event
            btnSubCategoryPrevious.Click += delegate
            {
                try
                {
                    pnlSubCategory.HorizontalScroll.Value -= 110;
                }
                catch (Exception ex)
                {
                    pnlSubCategory.AutoScrollPosition = new Point(0, 0);
                }
            };

            //next button click event
            btnSubCategoryNext.Click += delegate
            {
                pnlSubCategory.HorizontalScroll.Value += 110;
            };

            #endregion

            #region Item List
            //Item List
            GroupBox gbItems = new GroupBox();
            gbItems.Location = new Point(10, gbSubCategory.Location.Y + gbSubCategory.Height + 20);
            gbItems.Width = tbMenu.Width - 30;
            gbItems.Height = (tbMenu.Height * 70) / 100;
            gbItems.BackColor = Color.White;
            gbItems.Text = "ITEMS";
            gbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            tb.Controls.Add(gbItems);
            #endregion

            btnCategoryConfig(gbItems,pnlSubCategory, tb.Name);



                tbMenu.TabPages.Add(tb);
            }//Tab Page End

            #endregion

            

            #endregion

            #region Bill
            //panel Bill
            pnlBill.BackColor = Color.FromArgb(255, 255, 255);
            pnlBill.Location = new Point(pnlMenu.Location.X + pnlMenu.Width, 58);
            pnlBill.Height = (screenHeight * 90) / 100;
            pnlBill.Width = (screenWidth * 45) / 100;
            pnlBill.BringToFront();

            //Item Grid
            dgvItem.Location = new Point(5, 5);
            dgvItem.Height = 400;
            dgvItem.Width = pnlBill.Width - 10;
            dgvItem.Columns["clmName"].Width = (dgvItem.Width * 40) / 100;
            //pnlBill.Controls.Add(dgvItem);

            #endregion

            #region Sortcut
            //panel SortCut
            pnlShortCut.BackColor = Color.FromArgb(6, 199, 255);
            pnlShortCut.Location = new Point(pnlBill.Location.X + pnlBill.Width, 58);
            pnlShortCut.Height = (screenHeight * 90) / 100;
            pnlShortCut.Width = (screenWidth * 10) / 100;

            #endregion

            

            

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }




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

        public void btnCategoryConfig(GroupBox gbItems,MetroFramework.Controls.MetroPanel pnlSubCategory,string tabName)
        {
            //metroPanel1.Controls.Clear();
            //metroPanel1.VerticalScrollbar = true;

            DataTable dtCategory = new DataTable();
            string code = tabName;
            string where = "fldMenuDepartmentCode = '" + code + "'";
            dtCategory = cDBConnection.SearchData("tbl_MenuCategory", where);

            //string[] btnName = new string[] { "ADD", "Cancel", "CuT", "Put", "lol", "ADD", "Cancel", "CuT", "Put", "lol" };
            string[] btnBackColor = new string[] { "6,199,255", "0,255,0", "0,0,255", "125,24,156", "200,100,50", "6,199,255", "0,255,0", "0,0,255", "125,24,156", "200,100,50" };

            Color[] backColor = convertToColorArray(btnBackColor);
            int x = 30;
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
                b.BackColor = backColor[i];
                b.ForeColor = Color.White;
                b.Location = newLoc;
                newLoc.Offset(0, b.Height + 10);
                pnlSubCategory.Controls.Add(b);
                newLoc = new Point(x += 140, y);

                b.Click += delegate
                {
                    try
                    {
                        MessageBox.Show(b.Text+ "   Clicked");
                        btnItemConfig(gbItems, tabName);
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

        #region Item List Button Adding
        public void btnItemConfig(GroupBox gbItems, string tabName)
        {
            //metroPanel1.Controls.Clear();
            //metroPanel1.VerticalScrollbar = true;

            DataTable dtCategory = new DataTable();
            string code = tabName;
            string where = "fldMenuDepartmentCode = '" + code + "'";
            dtCategory = cDBConnection.SearchData("tbl_MenuCategory", where);

            //string[] btnName = new string[] { "ADD", "Cancel", "CuT", "Put", "lol", "ADD", "Cancel", "CuT", "Put", "lol" };
            string[] btnBackColor = new string[] { "6,199,255", "0,255,0", "0,0,255", "125,24,156", "200,100,50", "6,199,255", "0,255,0", "0,0,255", "125,24,156", "200,100,50" };

            Color[] backColor = convertToColorArray(btnBackColor);
            int x = 30;
            int y = 30;
            Point newLoc = new Point(x, y); // Set whatever you want for initial location

            int DataCount = dtCategory.Rows.Count;
            int count = 0;

            for (int j=0; j < Math.Abs(DataCount/4)+1; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    try
                    {
                        Button b = new Button();
                        b.FlatStyle = FlatStyle.Flat;
                        b.FlatAppearance.BorderColor = Color.FromArgb(0, 154, 199);
                        b.Size = new Size(110, 50);
                        b.Text = dtCategory.Rows[count]["fldMenuCategoryName"].ToString();
                        b.Name = dtCategory.Rows[count]["fldMenuCategoryCode"].ToString();
                        b.BackColor = backColor[count];
                        b.ForeColor = Color.White;
                        b.Location = newLoc;
                        newLoc.Offset(0, b.Height + 10);
                        gbItems.Controls.Add(b);
                        newLoc = new Point(x += 140, y);
                        count++;
                    }
                    catch (Exception ex)
                    {

                    }
                }
                newLoc = new Point(x=30, y += 70);
            }
        }
        #endregion

    }
}