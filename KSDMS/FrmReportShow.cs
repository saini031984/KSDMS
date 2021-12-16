using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KSDMS.DataClass;
using System.Diagnostics;

namespace KSDMS
{
    public partial class FrmReportShow : Form
    {
        public int RptTYpe;
        public FrmReportShow()
        {
            InitializeComponent();
        }

     

        private void FrmReportShow_Load(object sender, EventArgs e)
        {
            Fn_FIllCombo();
        }
        private void Fn_FIllCombo()
        {

            CmbMonth.Items.Add("Select");
            CmbMonth.Items.Add("JAN");
            CmbMonth.Items.Add("FAB");
            CmbMonth.Items.Add("MAR");
            CmbMonth.Items.Add("APR");
            CmbMonth.Items.Add("MAY");
            CmbMonth.Items.Add("JUN");
            CmbMonth.Items.Add("JUL");
            CmbMonth.Items.Add("AUG");
            CmbMonth.Items.Add("SEP");
            CmbMonth.Items.Add("OCT");
            CmbMonth.Items.Add("NOV");
            CmbMonth.Items.Add("DEC");

            CmbMonth.SelectedIndex = 0;

            int I = 0;

            for (I=2000;I<2021;I++)
            {

                CmbYear.Items.Add(I.ToString());
            
            }
            CmbYear.Text = DateTime.Now.ToString("yyyy");
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            string StrSQL = "";
            ClassReport CLR = new ClassReport();
            if (RptTYpe == 1)
            {
                if (RdSum.Checked == true)
                {
                    StrSQL = "SELECT VisaType.VisaTNm, IsNull((Count(VisaApp.VisaType)),0) as CT, IsNull((Sum(VisaApp.RcptAmt)),0) as AMT   " +
                 " FROM VisaApp INNER JOIN " +
                 " GeoCountryMaster ON VisaApp.PIssCountry = GeoCountryMaster.CountID LEFT OUTER JOIN " +
                 " ParamDetail ON VisaApp.PerNm = ParamDetail.PDetailID LEFT OUTER JOIN " +
                 " VisaType ON VisaApp.VisaType = VisaType.VTypeID " +
                 " Where  VisaApp.Visaposition<>'P'  And Month(VisaApp.VisaDT) =" + CmbMonth.SelectedIndex.ToString() + " " +
                 " And Year(VisaApp.VisaDT) =" + CmbYear.Text.Trim() + " " +
                 " Group By VisaType.VisaTNm ";
                    string StrRptTital = "MONTHLY RETURNS OF VISA FOR " + CmbMonth.Text.Trim() + "-" + CmbYear.Text.Trim() + " ";
                    CLR.Fn_AddReportType(StrRptTital, "RptMonthSum", StrSQL);
                }
                else
                {

                    StrSQL = "SELECT ParamDetail.PDetailName as FN, VisaApp.FirstNm, VisaApp.MidNm, VisaApp.LastNm,VisaApp.Gender, GeoCountryMaster.CountName as StrNation," +
                 " VisaApp.VisaNo,VisaApp.VisaDT,IsNull(VisaApp.RcptAmt,0) as RcptAmt,VisaApp.PasportNo,VisaType.VisaTNm," +
                 " VisaApp.VisaID, GeoCountryMaster.CountName, VisaType.VisaTNm, VisaApp.AppNoStr, VisaApp.AppDt, VisaApp.PasportNo, VisaApp.NoOfEnt,VisaApp.RefNo," +
                 " VisaApp.VisaType,IsNull(VisaApp.NCopmNm,'') as NCopmNm ,IsNull(VisaApp.NCompAdd1,'') as NCompAdd1, " +
                 " IsNull(VisaApp.NCompAdd2,'') as NCompAdd2,IsNull(VisaApp.NCompCnt,'') as NCompCnt," +
                 " IsNull(VisaApp.STJVisaNo,'') as STJVisaNo, IsNull(VisaApp.STRCompNm,'') as STRCompNm, " +
                 " IsNull(VisaApp.STRAdd1,'') as STRAdd1, IsNUll(VisaApp.STRAdd2,'') as STRAdd2, IsNull(VisaApp.STREQP,'') as STREQP," +
                 " IsNUll(VisaApp.STRRefNo,'') as STRRefNo, IsNull(VisaApp.STRFromDt,'01-Jan-1900') as STRFromDt, " +
                 " IsNull(VisaApp.StrToDt,'01-Jan-1900') as StrToDt, IsNull(VisaApp.StrNoMn,0) as StrNoMn, " +
                 " IsNull(VisaApp.StrNoYear,0) as StrNoYear  " +
                 " FROM VisaApp INNER JOIN " +
                 " GeoCountryMaster ON VisaApp.PIssCountry = GeoCountryMaster.CountID LEFT OUTER JOIN " +
                 " ParamDetail ON VisaApp.PerNm = ParamDetail.PDetailID LEFT OUTER JOIN " +
                 " VisaType ON VisaApp.VisaType = VisaType.VTypeID " +
                 " Where VisaApp.Visaposition<>'P' And Month(VisaApp.VisaDT) =" + CmbMonth.SelectedIndex.ToString() + " " +
                 " And Year(VisaApp.VisaDT) =" + CmbYear.Text.Trim() + " " +
                 " Order By VisaApp.VisaDT, VisaApp.VisaNo";
                    string StrRptTital = "MONTHLY RETURNS OF VISA FOR " + CmbMonth.Text.Trim() + "-" + CmbYear.Text.Trim() + " ";
                    CLR.Fn_AddReportType(StrRptTital, "RptMonthDetail", StrSQL);
                }

            }
            else if (RptTYpe == 2)
            {
                if (RdSum.Checked == true)
                {
                    StrSQL = " SELECT ParamDetail.PDetailName as VisaTNm, Count(ParamDetail.PDetailName) as CT, IsNull((Sum(PassportApp.RefAmt)),0) as AMT    " + 
                    " FROM PassportApp INNER JOIN " +
                    " ParamDetail ON PassportApp.ReqType = ParamDetail.PDetailID " +
                    " Where Month(PassportApp.NewIssueDt) =" + CmbMonth.SelectedIndex.ToString() + " " +
                    " And Year(PassportApp.NewIssueDt) =" + CmbYear.Text.Trim() + " And PassportApp.PStatus='4' " +
                    " GROUP BY ParamDetail.PDetailName";

                    string StrRptTital = "MONTHLY RETURNS OF PASSPORT FOR " + CmbMonth.Text.Trim() + "-" + CmbYear.Text.Trim() + " ";
                    CLR.Fn_AddReportType(StrRptTital, "RptMonthSum", StrSQL);
                }
                else
                {

                    

                    StrSQL = "SELECT PassportApp.PassportID, PassportApp.NewIssueDt as IssueDt, PassportApp.NewProcessEmbassy as Embassy, PassportApp.NewPassportNo as PassportNo,  " +
                    " PassportApp.NewLNm + ' ' + PassportApp.NewFNm + ' ' + PassportApp.NewMNm as AppNm,  PassportApp.NewGender as Gender, " +
                    " PassportApp.NigAdd1 + ' ' + PassportApp.NigAdd2  + ' ' +  PassportApp.NigCity  + ' ' +  " +
                    " PassportApp.NigState  + ' ' +  PassportApp.NigLGA  + ' ' +  PassportApp.NigDist  + ' ' +  PassportApp.NigPin as Address, PassportApp.RefAmt as AMT, " +
                    " PassportApp.EnrolmentNo, PassportApp.AppNoStr as AppID, PassportApp.RefNo, ParamDetail.PDetailName as Remarks " +
                    " FROM PassportApp INNER JOIN " +
                    " ParamDetail ON PassportApp.ReqType = ParamDetail.PDetailID " +
                    " Where Month(PassportApp.NewIssueDt) =" + CmbMonth.SelectedIndex.ToString() + " " +
                    " And Year(PassportApp.NewIssueDt) =" + CmbYear.Text.Trim() + "  And PassportApp.PStatus='4' " +
                    " Order BY PassportApp.NewPassportNo";
                    string StrRptTital = "MONTHLY RETURNS OF PASSPORT FOR " + CmbMonth.Text.Trim() + "-" + CmbYear.Text.Trim() + " ";
                    CLR.Fn_AddReportType(StrRptTital, "RptMonthDetailPassport", StrSQL);
                }
            
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "Report.EXE";
            Process.Start(startInfo);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
