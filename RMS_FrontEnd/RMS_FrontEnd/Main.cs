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

            btnClose.Location = new Point(screenWidth - 45, 10);

            //panel Header
            pnlHeader.BackColor = Color.FromArgb(0, 154, 199);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Width = screenWidth;

            //panel Menu
            pnlMenu.BackColor = Color.FromArgb(6, 199, 255);
            pnlMenu.Location = new Point(3, 58);
            pnlMenu.Height = (screenHeight * 90) / 100;
            pnlMenu.Width = (screenWidth * 50) / 100;

            //panel Bill
            pnlBill.BackColor = Color.FromArgb(255, 255, 255);
            pnlBill.Location = new Point(pnlMenu.Location.X + pnlMenu.Width, 58);
            pnlBill.Height = (screenHeight * 90) / 100;
            pnlBill.Width = (screenWidth * 40) / 100;
            pnlBill.BringToFront();

            //panel SortCut
            pnlShortCut.BackColor = Color.FromArgb(6, 199, 255);
            pnlShortCut.Location = new Point(pnlBill.Location.X + pnlBill.Width, 58);
            pnlShortCut.Height = (screenHeight * 90) / 100;
            pnlShortCut.Width = (screenWidth * 10) / 100;

            metroPanel1.UseCustomBackColor = true;
            metroPanel1.BackColor = Color.FromArgb(0, 75, 98);

            //Item Grid
            dgvItem.Location = new Point(5, 5);
            dgvItem.Height = 400;
            dgvItem.Width = pnlBill.Width - 10;
            //pnlBill.Controls.Add(dgvItem);

            //Tab View
            tbMenu.Location = new Point(10, 10);
            tbMenu.Width = pnlMenu.Width - 20;
            tbMenu.Height = pnlMenu.Height - 20;
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
                metroPanel1.Controls.Add(b);
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
