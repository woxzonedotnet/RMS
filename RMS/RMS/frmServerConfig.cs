using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace RMS
{
    public partial class frmServerConfig : Form
    {
        #region Variables
        string path = System.AppDomain.CurrentDomain.BaseDirectory + "ServerConfig.xml";
        Point lastClick;
        #endregion

        public frmServerConfig()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region Validate ServerConfig Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtServerName.Text == "")
            {
                errServerConfig.SetError(txtServerName, "Please Enter Server Name");
                isValidate = false;
            }
            else
            {
                errServerConfig.SetError(txtServerName, "");
            }

            if (txtDatabaseName.Text == "")
            {
                errServerConfig.SetError(txtDatabaseName, "Please Enter Database Name");
                isValidate = false;
            }
            else
            {
                errServerConfig.SetError(txtDatabaseName, "");
            }

            if (txtUsername.Text == "")
            {
                errServerConfig.SetError(txtUsername, "Please Enter Username");
                isValidate = false;
            }
            else
            {
                errServerConfig.SetError(txtUsername, "");
            }

            if (txtPassword.Text == "")
            {
                errServerConfig.SetError(txtPassword, "Please Enter Password");
                isValidate = false;
            }
            else
            {
                errServerConfig.SetError(txtPassword, "");
            }
            return isValidate;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                XmlTextWriter writer = new XmlTextWriter(path, null);
                writer.WriteStartDocument();
                writer.WriteStartElement("scpd", "urn:schemas-upnp-org:service-1-0");
                writer.WriteStartElement("ServerConfig");

                writer.WriteStartElement("ServerName");
                writer.WriteString(this.txtServerName.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("DatabaseName");
                writer.WriteString(this.txtDatabaseName.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("username");
                writer.WriteString(this.txtUsername.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("password");
                writer.WriteString(this.txtPassword.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("security");
                writer.WriteString("True");
                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();

                MessageBox.Show("Server Config","New Settings Apply!!");
                Application.Restart();
            }
        }

        private void frmServerConfig_Load(object sender, EventArgs e)
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(path);
                this.txtServerName.Text = document.GetElementsByTagName("ServerName")[0].InnerText;
                this.txtDatabaseName.Text = document.GetElementsByTagName("DatabaseName")[0].InnerText;
                this.txtUsername.Text = document.GetElementsByTagName("username")[0].InnerText;
                this.txtPassword.Text = document.GetElementsByTagName("password")[0].InnerText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Setting load error please contact administrator","\n"+ex.Message);
            }
        }

        #region Form Move
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        #endregion
    }
}
