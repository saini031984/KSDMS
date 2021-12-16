using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Report
{
    public partial class FrmReport : Form
    {
        public string InputSQL = "";
        public string InputReportType = "";
        public string InputReportTitle = "";
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            RptVeiw.Width = this.Width;
            RptVeiw.Height = this.Height;
            if (InputSQL.ToString().Trim() == "")
            {
                MessageBox.Show("Not Allow to Open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            Fn_ReportType();
        }
        private void Fn_ReportType()
        {
            if (InputReportType == "RptDetailMonthReport")
            { Fn_SHowDetailReport(); }
            else if (InputReportType == "RptSumMonthReport")
            { Fn_SHowDetailReport(); }
        }
        private void Fn_SHowDetailReport() 
        {
           // StrSQL = "SELECT ParamDetail.PDetailName as FN, VisaApp.FirstNm, VisaApp.MidNm, VisaApp.LastNm,VisaApp.Gender, GeoCountryMaster.CountName as StrNation," +
           //    " VisaApp.VisaNo,VisaApp.VisaDT,IsNull(VisaApp.RcptAmt,0) as RcptAmt,VisaApp.PasportNo,VisaType.VisaTNm," +
           //    " VisaApp.VisaID, GeoCountryMaster.CountName, VisaType.VisaTNm, VisaApp.AppNoStr, VisaApp.AppDt, VisaApp.PasportNo, VisaApp.NoOfEnt,VisaApp.RefNo," +
           //    " VisaApp.VisaType,IsNull(VisaApp.NCopmNm,'') as NCopmNm ,IsNull(VisaApp.NCompAdd1,'') as NCompAdd1, " +
           //    " IsNull(VisaApp.NCompAdd2,'') as NCompAdd2,IsNull(VisaApp.NCompCnt,'') as NCompCnt," +
           //    " IsNull(VisaApp.STJVisaNo,'') as STJVisaNo, IsNull(VisaApp.STRCompNm,'') as STRCompNm, " +
           //    " IsNull(VisaApp.STRAdd1,'') as STRAdd1, IsNUll(VisaApp.STRAdd2,'') as STRAdd2, IsNull(VisaApp.STREQP,'') as STREQP," +
           //    " IsNUll(VisaApp.STRRefNo,'') as STRRefNo, IsNull(VisaApp.STRFromDt,'01-Jan-1900') as STRFromDt, " +
           //" IsNull(VisaApp.StrToDt,'01-Jan-1900') as StrToDt, IsNull(VisaApp.StrNoMn,0) as StrNoMn, " +
           //" IsNull(VisaApp.StrNoYear,0) as StrNoYear  " +
           //" FROM VisaApp INNER JOIN " +
           //" GeoCountryMaster ON VisaApp.PIssCountry = GeoCountryMaster.CountID LEFT OUTER JOIN " +
           //" ParamDetail ON VisaApp.PerNm = ParamDetail.PDetailID LEFT OUTER JOIN " +
           //" VisaType ON VisaApp.VisaType = VisaType.VTypeID " +
           //" Where Month(VisaApp.VisaDT) = " + CmbMonth.SelectedIndex + " " +
           //" And Year(VisaApp.VisaDT) = " + CmbYear.Text.Trim() + " " +
           //" Order By VisaType.VisaTNm,VisaApp.VisaID,VisaApp.VisaDT";
            ClassReport CR = new ClassReport();
            CR.Fn_ShowReportVisa(InputSQL);
            CrystalReport1 Rpt = new CrystalReport1();
            int L;
            for (L = 0; L < Rpt.DataDefinition.FormulaFields.Count; L++)
            {
                if (Rpt.DataDefinition.FormulaFields[L].Name == "ReportTitle")
                {
                    Rpt.DataDefinition.FormulaFields[L].Text = "'" + InputReportTitle + "'";
                }

            }
            try
            {
                Rpt.SetDataSource(CR.R_Ds.Tables[0]);
                RptVeiw.ReportSource = Rpt;
                RptVeiw.Refresh();
            }
            catch
            {
                MessageBox.Show("No Data", "KS EDMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Fn_SHowSumReport()
        {
          
          
           // StrSQL = "SELECT VisaType.VisaTNm, IsNull((Count(VisaApp.VisaType)),0) as CT, IsNull((Sum(VisaApp.RcptAmt)),0) as AMT   " +
           //" FROM VisaApp INNER JOIN " +
           //" GeoCountryMaster ON VisaApp.PIssCountry = GeoCountryMaster.CountID LEFT OUTER JOIN " +
           //" ParamDetail ON VisaApp.PerNm = ParamDetail.PDetailID LEFT OUTER JOIN " +
           //" VisaType ON VisaApp.VisaType = VisaType.VTypeID " +
           //" Where Month(VisaApp.VisaDT) = " + CmbMonth.SelectedIndex + " " +
           //" And Year(VisaApp.VisaDT) = " + CmbYear.Text.Trim() + " " +
           //" Group By VisaType.VisaTNm ";
            ClassReport CR = new ClassReport();
            CR.Fn_ShowReportVisaSum(InputSQL);
            RptSum Rpt = new RptSum();
            int L;
            for (L = 0; L < Rpt.DataDefinition.FormulaFields.Count; L++)
            {
                if (Rpt.DataDefinition.FormulaFields[L].Name == "ReportTitle")
                {
                    Rpt.DataDefinition.FormulaFields[L].Text = "'" + InputReportTitle + "'";
                }

            }
            try
            {
                Rpt.SetDataSource(CR.R_Ds.Tables[0]);
                RptVeiw.ReportSource = Rpt;
                RptVeiw.Refresh();
            }
            catch
            {
                MessageBox.Show("No Data", "KS EDMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
