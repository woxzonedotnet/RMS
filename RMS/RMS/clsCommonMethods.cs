using BusinessLogic;
using DataAccess;
using RMS.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Xml;

namespace RMS
{
    public class clsCommonMethods
    {
        #region Objects
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsBrowsData cBrowsData = new clsBrowsData();
        clsDBConnection DbConn = new clsDBConnection();
        #endregion

        #region Variables
        string cpuInfo;
        #endregion

        public string BrowsData(string strTableName, string[] strFieldList, string[] strHeadingList, int[] iHeaderWidth, string strReturnField, string Where_Clause, string header)
        {
            frmBrowsData frmBrows = new frmBrowsData(cBrowsData.BrowsData(strTableName, strFieldList, Where_Clause), strTableName, strFieldList, strHeadingList, iHeaderWidth, strReturnField, Where_Clause, header);
            frmBrows.ShowDialog();
            return cGlobleVariable.BrowsDataValue;
        }

        public void ClearForm(System.Windows.Forms.Control parent)
        {
            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
                {
                    ((System.Windows.Forms.RichTextBox)ctrControl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(RMS.ColumnComboBox)))
                {
                    ((RMS.ColumnComboBox)ctrControl).ClearItems();
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    ((System.Windows.Forms.CheckBox)ctrControl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    ((System.Windows.Forms.RadioButton)ctrControl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    ((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex = -1;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.PictureBox)))
                {
                    ((System.Windows.Forms.PictureBox)ctrControl).Image = null;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.DateTimePicker)))
                {
                    ((System.Windows.Forms.DateTimePicker)ctrControl).Value = DateTime.Now;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.NumericUpDown))) 
                {
                    ((System.Windows.Forms.NumericUpDown)ctrControl).Value = 1;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.DataGridView)))
                {
                    ((System.Windows.Forms.DataGridView)ctrControl).Rows.Clear();
                }

                if (ctrControl.Controls.Count > 0)
                {
                    ClearForm(ctrControl);
                }
            }
        }

        public void loadComboRMS(DataTable dtFillData, RMS.ColumnComboBox objFillComb, int ViewColumn)
        {
            objFillComb.Data = dtFillData;
            objFillComb.ViewColumn = ViewColumn;

            for (int i = 0; i < dtFillData.Columns.Count; i++)
            {
                objFillComb.Columns[i].Display = false;
            }
            objFillComb.Columns[ViewColumn].Display = true;
        }

        public void MoveNextControl(KeyPressEventArgs KeyAschii)
        {
            if (KeyAschii.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        public string UniqID()
        {
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = managClass.GetInstances();

            foreach (ManagementObject managObj in managCollec)
            {
                cpuInfo = managObj.Properties["processorID"].Value.ToString();
                break;
            }
            cpuInfo += "-" + System.Environment.MachineName + @"\" + System.Environment.UserName;

            cGlobleVariable.UniqID = cpuInfo;
            return cGlobleVariable.UniqID;
        }

        public string DateYear() 
        {
            DateTime strDateTime = System.DateTime.Now;
            string strYear = strDateTime.Year.ToString();
            strYear = strYear.Substring(2);
            return strYear;
        }
    }
}
