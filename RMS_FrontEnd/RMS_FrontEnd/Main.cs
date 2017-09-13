using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            screenWidth = this.Width;
            screenHeight = this.Height;

            
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
            #endregion

            #region SubCategory
            //Sub Category
            //GroupBox gbSubCategory = new GroupBox();
            gbSubCategory.Location = new Point(10,10);
            gbSubCategory.Width = tbMenu.Width - 30;
            gbSubCategory.Height = (tbMenu.Height * 18) / 100;
            gbSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            tbDrinks.Controls.Add(gbSubCategory);

            //Button Previous
            //Button btnSubCategoryPrevious = new Button();
            btnSubCategoryPrevious.Location = new Point(10,30);
            btnSubCategoryPrevious.Height = gbSubCategory.Height - 50;
            btnSubCategoryPrevious.Width = (gbSubCategory.Width * 7) / 100;
            btnSubCategoryPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            btnSubCategoryPrevious.ForeColor = Color.DarkRed;
            btnSubCategoryPrevious.Text = "<";
            btnSubCategoryPrevious.BackColor = Color.FromArgb(6, 199, 255);
            btnSubCategoryPrevious.FlatStyle = FlatStyle.Flat;
            gbSubCategory.Controls.Add(btnSubCategoryPrevious);

            //Button Panel
            //MetroFramework.Controls.MetroPanel pnlSubCategory = new MetroFramework.Controls.MetroPanel();
            pnlSubCategory.Location = new Point(btnSubCategoryPrevious.Location.X+ btnSubCategoryPrevious.Width + 5,30);
            pnlSubCategory.Height = gbSubCategory.Height - 50;
            pnlSubCategory.Width = (gbSubCategory.Width * 81) / 100;
            pnlSubCategory.UseCustomBackColor = true;
            pnlSubCategory.BackColor = Color.FromArgb(0, 75, 98);
            gbSubCategory.Controls.Add(pnlSubCategory);

            //Button Next
            //Button btnSubCategoryNext = new Button();
            btnSubCategoryNext.Location = new Point(pnlSubCategory.Location.X+pnlSubCategory.Width+5, 30);
            btnSubCategoryNext.Height = gbSubCategory.Height - 50;
            btnSubCategoryNext.Width = (gbSubCategory.Width * 7) / 100;
            btnSubCategoryNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            btnSubCategoryNext.ForeColor = Color.DarkRed;
            btnSubCategoryNext.Text = ">";
            btnSubCategoryNext.BackColor = Color.FromArgb(6, 199, 255);
            btnSubCategoryNext.FlatStyle = FlatStyle.Flat;
            gbSubCategory.Controls.Add(btnSubCategoryNext);


            #endregion

            #region Item List
            //Item List
            //GroupBox gbItems = new GroupBox();
            gbItems.Location = new Point(10, gbSubCategory.Location.Y+gbSubCategory.Height+20);
            gbItems.Width = tbMenu.Width - 30;
            gbItems.Height = (tbMenu.Height * 70) / 100;
            gbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            tbDrinks.Controls.Add(gbItems);
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

        public void buttonConfig()
        {
            //metroPanel1.Controls.Clear();
            //metroPanel1.VerticalScrollbar = true;

            string[] btnName = new string[] { "ADD", "Cancel", "CuT", "Put", "lol", "ADD", "Cancel", "CuT", "Put", "lol" };
            string[] btnBackColor = new string[] { "6,199,255", "0,255,0", "0,0,255", "125,24,156", "200,100,50", "6,199,255", "0,255,0", "0,0,255", "125,24,156", "200,100,50" };

            Color[] backColor = convertToColorArray(btnBackColor);
            int x = 30;
            int y = 5;
            Point newLoc = new Point(x, y); // Set whatever you want for initial location
            for (int j = 0; j < 10; j++)
            {
                //for (int i = 0; i < 1; ++i)
                //{
                Button b = new Button();
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderColor = Color.FromArgb(0, 154, 199);
                b.Size = new Size(80, 50);
                b.Text = btnName[j];
                b.BackColor = backColor[j];
                b.ForeColor = Color.White;
                b.Location = newLoc;
                newLoc.Offset(0, b.Height + 10);
                pnlSubCategory.Controls.Add(b);
                //}
                newLoc = new Point(x += 100, y);
            }
        }

        //private void metroPanel1_MouseHover(object sender, EventArgs e)
        //{
        //    startPoint = MousePosition;
        //    menuscroll = metroPanel1.AutoScrollPosition;
        //}

        //private void metroPanel1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    //int x = MousePosition.X;
        //    ////int px = metroPanel1.AutoScrollPosition.X;
        //    //label1.Text = x.ToString();
        //    ////Point scroll = new Point(menuscroll.X,0);
        //    //label2.Text = metroPanel1.AutoScrollPosition.X.ToString();
        //    ////metroPanel1.AutoScrollPosition = MousePosition;
        //    //int v = startPoint.X - x;
        //    //menuscroll.X += v;
        //    //metroPanel1.AutoScrollPosition = menuscroll;

        //    ////if (x > startPoint.X)
        //    ////{
        //    ////    int v = startPoint.X - x;
        //    ////    scroll.X -= v;
        //    ////    metroPanel1.AutoScrollPosition = scroll;
        //    ////}
        //    ////else
        //    ////{
        //    ////    int v = startPoint.X - x;
        //    ////    scroll.X -= v;
        //    ////    metroPanel1.AutoScrollPosition = scroll;
        //    ////}
        //}

    }
}
