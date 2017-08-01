using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessObject;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Reports
{
    public partial class frmReportViewer : Form
    {
        #region Objects
        objReportMaster oReportMaster = new objReportMaster();
        clsReportMaster cReportMaster = new clsReportMaster();
        ReportDocument cReportDocument = new ReportDocument();
        ParameterField cParameterField;
        ParameterDiscreteValue cParameterDiscreteValue;
        ParameterFields cParameterFields;
        #endregion

        #region Variables
        Point lastClick;
        System.Object[,] arrParamFields;

        private string strSelectionFormular = string.Empty;
        private string strLocationCode;
        private int iReportID;
        #endregion

        #region Constructor
        public frmReportViewer()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public frmReportViewer(int ReportID, string LocationCode)
        {
            InitializeComponent();
            iReportID = ReportID;
            strLocationCode = LocationCode;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public frmReportViewer(int ReportID, string LocationCode, string SelectionFormular)
        {
            InitializeComponent();
            iReportID = ReportID;
            strSelectionFormular = SelectionFormular;
            strLocationCode = LocationCode;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public frmReportViewer(int ReportID, string LocationCode, string SelectionFormular, System.Object[,] arrParameter)
        {
            InitializeComponent();

            iReportID = ReportID;
            strSelectionFormular = SelectionFormular;
            strLocationCode = LocationCode;

            arrParamFields = new object[arrParameter.GetLength(0) - 1, 2];
            arrParamFields = arrParameter;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #endregion

        #region Pannel Move
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoadReportDeta()
        {
            oReportMaster = cReportMaster.GetReports(iReportID);
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            LoadReportDeta();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //cReportDocument.FileName = Application.StartupPath + "\\Reports\\" + oReportMaster.ReportName;
            cReportDocument.FileName = @"E:\WOXZONE RMS\RMS2\RMS\Reports\" + oReportMaster.ReportName;
            cReportDocument.RecordSelectionFormula = strSelectionFormular;
            crystalReportViewer.ReportSource = cReportDocument;
        }


        private void PassParemeterFields(System.Object[,] arrParameter)
        {
            for (int i = 0; i <= arrParameter.GetLength(0) - 1; i++)
            {
                cParameterField = new ParameterField();
                cParameterField.Name = arrParameter[i, 0].ToString();

                cParameterDiscreteValue = new ParameterDiscreteValue();
                cParameterDiscreteValue.Value = arrParameter[i, 1].ToString();
                cParameterField.CurrentValues.Add(cParameterDiscreteValue);

                cParameterFields.Add(cParameterField);
                crystalReportViewer.ParameterFieldInfo = cParameterFields;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
