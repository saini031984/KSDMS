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
    public partial class FrmFind : Form
    {
        public FrmFind()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFind_Load(object sender, EventArgs e)
        {
            Fn_FillCombo();
            Fn_Search();
        }
        private void Fn_FillCombo()
        {
            string StrFromDT = DateTime.Now.ToString("dd/MMM/yyyy");

             DtTo.Value = Convert.ToDateTime(StrFromDT);
             StrFromDT = "01-" + DateTime.Now.ToString("MMM/yyyy");
             DtFrom.Value = Convert.ToDateTime(StrFromDT);
            ClassVisaType VT = new ClassVisaType();
            CmbVisaType.DataSource = VT.DV_RetDptList();
            CmbVisaType.DisplayMember = "VisaTNm";
            CmbVisaType.ValueMember = "VTypeID";

            CmbFVisaType.DataSource = VT.DV_RetDptList();
            CmbFVisaType.DisplayMember = "VisaTNm";
            CmbFVisaType.ValueMember = "VTypeID";

            CmbFVisaType.SelectedValue = "0";

            ClassParamDetails PD = new ClassParamDetails();
            CmbIntial.DataSource = PD.DV_RetParamDetailList("2");
            CmbIntial.DisplayMember = "PDetailName";
            CmbIntial.ValueMember = "PDetailID";

            CmbMStatus.DataSource = PD.DV_RetParamDetailList("1");
            CmbMStatus.DisplayMember = "PDetailName";
            CmbMStatus.ValueMember = "PDetailID";

            CmbSex.Items.Add("Select");
            CmbSex.Items.Add("Male");
            CmbSex.Items.Add("Female");
            CmbSex.SelectedIndex = 0;

            CmbStatus.Items.Add("Pending");
            CmbStatus.Items.Add("Approved");
            CmbStatus.Items.Add("Rejected");
            CmbStatus.SelectedIndex = 0; 

        }
        private void Fn_Search()
        {
         
 


            string SQL = "SELECT VisaApp.VisaID, VisaApp.VisaDT, VisaApp.VisaNo,VisaApp.PasportNo," +
                " ParamDetail.PDetailName  + ' ' + VisaApp.FirstNm + ' ' + VisaApp.MidNm + ' ' + VisaApp.LastNm as ExpatriateName, " +
                " VisaApp.Gender,VisaType.VisaTNm as VisaType, GeoCountryMaster.CountName as CountryNm,IsNull(VisaApp.RcptAmt,0) as RcptAmt," +
                " VisaApp.AppNoStr as AppID,VisaApp.RefNo,VisaApp.NoOfEnt " +
        " FROM VisaApp INNER JOIN " +
        " GeoCountryMaster ON VisaApp.PIssCountry = GeoCountryMaster.CountID LEFT OUTER JOIN " +
        " ParamDetail ON VisaApp.PerNm = ParamDetail.PDetailID LEFT OUTER JOIN " +
        " VisaType ON VisaApp.VisaType = VisaType.VTypeID " +
        " Where VisaApp.VisaDT>='" + DtFrom.Value.ToString("dd/MMM/yyyy") + "' and VisaApp.VisaDT<='" + DtTo.Value.ToString("dd/MMM/yyyy") + "'";
           
            if (TxtFAppNo.Text.Trim() != "")
            {
                SQL = SQL + " And VisaApp.AppNoStr Like '%" + TxtFAppNo.Text.Trim() + "%'";
            }
            if (TxtFSrNo.Text.Trim() != "")
            {
                SQL = SQL + " And VisaApp.RegNoStr Like '%" + TxtFSrNo.Text.Trim() + "%'";
            }
            if (TxtFVisaNo.Text.Trim() != "")
            {
                SQL = SQL + " And VisaApp.VisaNo Like '%" + TxtFVisaNo.Text.Trim() + "%'";
            }
            if (TxtFPasportNo.Text.Trim() != "")
            {
                SQL = SQL + " And VisaApp.PasportNo Like '%" + TxtFPasportNo.Text.Trim() + "%'";
            }

            if (TxtFName.Text.Trim() != "")
            {
                SQL = SQL + " And ((VisaApp.FirstNm Like '%" + TxtFName.Text.Trim() + "%' Or VisaApp.MidNm Like '%" + TxtFName.Text.Trim() + "%' Or VisaApp.LastNm Like '%" + TxtFName.Text.Trim() + "%')) ";
            }

            if (CmbFVisaType.SelectedValue.ToString().Trim() != "0")
            {
                SQL = SQL + " And VisaApp.VisaType=" + CmbFVisaType.SelectedValue.ToString().Trim() + " ";
            }
            if (RdSUnderProcess.Checked == true)
            {
                SQL = SQL + " And VisaApp.VisaStatus<=3";            
            }
            if (RdSApproved.Checked == true)
            {
                SQL = SQL + " And VisaApp.VisaPosition='A'";
            }
            if (RdSRejected.Checked == true)
            {
                SQL = SQL + " And VisaApp.VisaPosition='R'";
            }
            ClassCommenDataLayer RecDir = new ClassCommenDataLayer();
            GVPending.DataSource = RecDir.DL_DataViewSQLNew(SQL);
            GVPending.Columns[0].Visible = false;
            GVPending.Columns[1].Width = 100;
            GVPending.Columns[2].Width = 80;
            GVPending.Columns[3].Width = 80;
            GVPending.Columns[4].Width = 250;
            GVPending.Columns[5].Width = 50;
            GVPending.Columns[6].Width = 100;
            GVPending.Columns[7].Width = 100;
            GVPending.Columns[8].Width = 100;
            GVPending.Columns[9].Width = 100;
            GVPending.Columns[10].Width = 100;
            GVPending.Columns[11].Width = 100; 

        }
        private void Fn_DataView()
        {
            ChkActive.Checked = false;
            ClassVisa DptM = new ClassVisa();
            DptM.SLNO = TxtID.Text;
            DptM.Fn_DataView();
            TxtSrNo.Text = DptM.StrSrNo;
            DtRegDt.Value = DptM.RegDt;
            CmbVisaType.SelectedValue = DptM.VisaType;
            RdSingle.Checked = true;
            if (DptM.NoOfEnt.Trim() == "Multiple") { RdMultiple.Checked = true; }
            TxtAppNo.Text = DptM.AppNoStr;
            DtAppDt.Value = DptM.AppDt;
            DtPExpDt.Value = DptM.PExpDt;
            DtPIssueDt.Value = DptM.PIssDt;
            DtDOB.Value = DptM.DOB;
            TxtPassNo.Text = DptM.PasportNo;
            TxtOccupation.Text = DptM.PIssLocation;
            TxtIssGov.Tag = DptM.PIssCountry.ToString();
            CmbSex.Text = "";
            CmbIntial.SelectedValue = DptM.PerNm;
            CmbSex.SelectedText = DptM.Gender;
            CmbMStatus.SelectedValue = DptM.MarStatus;

            TxtFNm.Text = DptM.FirstNm;
            TxtMNm.Text = DptM.MidNm;
            TxtLNm.Text = DptM.LastNm;
            TxtNationlity.Tag = DptM.AppNation;
            TxtPBirth.Text = DptM.PlaceOfBirth;
            TxtAdd1.Text = DptM.ResAdd1;
            TxtAdd2.Text = DptM.ResAdd2;
            TxtAdd3.Text = DptM.ResAdd3;
            TxtContactNo.Text = DptM.ContactNo;

            TxtRefNo.Text = DptM.RefNo;
            TxtSTVisaNo.Text = DptM.STJVisaNo;
            TxtSTCompNm.Text = DptM.STRCompNm;
            TxtSTAdd1.Text = DptM.STRAdd1;
            TxtSTAdd2.Text = DptM.STRAdd2;
            TxtSTEQP.Text = DptM.STREQP;
            TxtSTRefNo.Text = DptM.STRRefNo;
            TxtStMonth.Text = DptM.StrNoMn.ToString();
            TxtStYear.Text = DptM.StrNoYear.ToString();
            DtStFromDt.Value = DptM.STRFromDt;
            DtStToDt.Value = DptM.StrToDt;

            TxtRcptNo.Text = DptM.RcptNo;
            DtRcpDt.Value = DptM.RegDt;
            TxtRcptAmt.Text = DptM.RcptAmt.ToString("0.00");
            TxtNCompNm.Text = DptM.NCopmNm;
            TxtNAdd1.Text = DptM.NCompAdd1;
            TxtNAdd2.Text = DptM.NCompAdd2;
            TxtNContactNo.Text = DptM.NCompCnt;
            TxtOccupation.Tag = DptM.Occupation.ToString();

            CmbStatus.SelectedIndex = 0;
            DtApp.Value = DateTime.Now;
            TxtVisaNo.Text = "";
            TxtNoOfMoths.Text = "";
            if (DptM.VisaPosition.Trim() != "P")
            {
                DtApp.Value = DptM.VisaDT1;
                TxtVisaNo.Text = DptM.VisaNo;
                TxtNoOfMoths.Text = DptM.VisaForTime;
                if (DptM.VisaPosition.Trim() == "A") { CmbStatus.SelectedIndex = 1; }
                if (DptM.VisaPosition.Trim() == "R") { CmbStatus.SelectedIndex = 2; TxtNoOfMoths.Text = ""; }
            }


            TxtLastDate.Text = DptM.LastDt.ToString(GlobalFunction.L_DateTimeFormat);
            if (DptM.IsActive.Trim() == "Y") { ChkActive.Checked = true; }
            TxtSrNo.Enabled = false;

            ClassCountry CT = new ClassCountry();
            CT.SLNO = TxtIssGov.Tag.ToString().Trim();
            CT.Fn_DataView();
            TxtIssGov.Text = CT.CName.Trim();

            CT.SLNO = TxtNationlity.Tag.ToString().Trim();
            CT.Fn_DataView();
            TxtNationlity.Text = CT.CName.Trim();

            if (TxtOccupation.Tag.ToString().Trim() != "") { TxtOccupation.Text = GlobalFunction.GF_GetParamName(TxtOccupation.Tag.ToString()); }
            ////////ChkActive.Checked = false;
            ////////ClassVisa DptM = new ClassVisa();
            ////////DptM.SLNO = TxtID.Text;
            ////////DptM.Fn_DataView();
            ////////TxtSrNo.Text = DptM.StrSrNo;
            ////////DtRegDt.Value = DptM.RegDt;
            ////////CmbVisaType.SelectedValue = DptM.VisaType;
            ////////RdSingle.Checked = true;
            ////////if (DptM.NoOfEnt.Trim() == "Multiple") { RdMultiple.Checked = true; }
            ////////TxtAppNo.Text = DptM.AppNoStr;
            ////////DtAppDt.Value = DptM.AppDt;
            ////////DtPExpDt.Value = DptM.PExpDt;
            ////////DtPIssueDt.Value = DptM.PIssDt;
            ////////DtDOB.Value = DptM.DOB;
            ////////TxtPassNo.Text = DptM.PasportNo;
            ////////TxtIssuePlace.Text = DptM.PIssLocation;
            ////////TxtIssGov.Tag = DptM.PIssCountry.ToString();
            ////////CmbSex.Text = "";
            ////////CmbIntial.SelectedValue = DptM.PerNm;
            ////////CmbSex.SelectedText = DptM.Gender;
            ////////CmbMStatus.SelectedValue = DptM.MarStatus;

            ////////TxtFNm.Text = DptM.FirstNm;
            ////////TxtMNm.Text = DptM.MidNm;
            ////////TxtLNm.Text = DptM.LastNm;
            ////////TxtNationlity.Tag = DptM.AppNation;
            ////////TxtPBirth.Text = DptM.PlaceOfBirth;
            ////////TxtAdd1.Text = DptM.ResAdd1;
            ////////TxtAdd2.Text = DptM.ResAdd2;
            ////////TxtAdd3.Text = DptM.ResAdd3;
            ////////TxtContactNo.Text = DptM.ContactNo;

            ////////TxtRefNo.Text = DptM.RefNo;
            ////////TxtSTVisaNo.Text = DptM.STJVisaNo;
            ////////TxtSTCompNm.Text = DptM.STRCompNm;
            ////////TxtSTAdd1.Text = DptM.STRAdd1;
            ////////TxtSTAdd2.Text = DptM.STRAdd2;
            ////////TxtSTEQP.Text = DptM.STREQP;
            ////////TxtSTRefNo.Text = DptM.STRRefNo;
            ////////TxtStMonth.Text = DptM.StrNoMn.ToString();
            ////////TxtStYear.Text = DptM.StrNoYear.ToString();
            ////////DtStFromDt.Value = DptM.STRFromDt;
            ////////DtStToDt.Value = DptM.StrToDt;

            ////////TxtRcptNo.Text = DptM.RcptNo;
            ////////DtRcpDt.Value = DptM.RegDt;
            ////////TxtRcptAmt.Text = DptM.RcptAmt.ToString("0.00");
            ////////TxtNCompNm.Text = DptM.NCopmNm;
            ////////TxtNAdd1.Text = DptM.NCompAdd1;
            ////////TxtNAdd2.Text = DptM.NCompAdd2;
            ////////TxtNContactNo.Text = DptM.NCompCnt;


            ////////CmbStatus.SelectedIndex = 0;
            ////////DtApp.Value = DateTime.Now;
            ////////TxtVisaNo.Text = "";
            ////////TxtNoOfMoths.Text = "";
            ////////if (DptM.VisaPosition.Trim() != "P")
            ////////{
            ////////    DtApp.Value = DptM.VisaDT1;
            ////////    TxtVisaNo.Text = DptM.VisaNo;
            ////////    TxtNoOfMoths.Text = DptM.VisaForTime;
            ////////    if (DptM.VisaPosition.Trim() == "A") { CmbStatus.SelectedIndex = 1; }
            ////////    if (DptM.VisaPosition.Trim() == "R") { CmbStatus.SelectedIndex = 2; TxtNoOfMoths.Text = ""; }
            ////////}


            ////////TxtLastDate.Text = DptM.LastDt.ToString(GlobalFunction.L_DateTimeFormat);
            ////////if (DptM.IsActive.Trim() == "Y") { ChkActive.Checked = true; }
            ////////TxtSrNo.Enabled = false;

            ////////ClassCountry CT = new ClassCountry();
            ////////CT.SLNO = TxtIssGov.Tag.ToString().Trim();
            ////////CT.Fn_DataView();
            ////////TxtIssGov.Text = CT.CName.Trim();

            ////////CT.SLNO = TxtNationlity.Tag.ToString().Trim();
            ////////CT.Fn_DataView();
            ////////TxtNationlity.Text = CT.CName.Trim();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            Fn_Search();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

        }

        private void GVPending_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtID.Text = GVPending.CurrentRow.Cells[0].Value.ToString();
            Fn_DataView();
            tabControl1.SelectedIndex = 1;
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            
            if (TxtID.Text.Trim() == "") { return; }
            FrmDMS FDM = new FrmDMS();
            FDM.StrVisaID = TxtID.Text.Trim();
            FDM.StrAppNo = TxtAppNo.Text.Trim();
            FDM.StrSrNo = TxtSrNo.Text.Trim();
            FDM.StrUpload = "N";
            FDM.ShowDialog();

        }

        private void PnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GVPending_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtID.Text = GVPending.CurrentRow.Cells[0].Value.ToString();
            Fn_DataView();
            tabControl1.SelectedIndex = 1;
        }

        private void CmbVisaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((CmbVisaType.SelectedValue.ToString().Trim() == "2") || (CmbVisaType.SelectedValue.ToString().Trim() == "3"))
            {
                PnlSTR.Visible = true;
                if (CmbVisaType.SelectedValue.ToString().Trim() == "3")
                {
                    LblStj.Visible = true;
                    LblStjVisaNo.Visible = true;
                    TxtSTVisaNo.Visible = true;
                }
                else
                {
                    LblStj.Visible = false;
                    LblStjVisaNo.Visible = false;
                    TxtSTVisaNo.Visible = false;
                }
            }
            else
            { PnlSTR.Visible = false; }
        }

        private void BtnPrint_Click_1(object sender, EventArgs e)
        {
            string StrSQL = "";
            string StrSearch = "";
         //   StrSQL = "SELECT VisaType.VisaTNm, IsNull((Count(VisaApp.VisaType)),0) as CT, IsNull((Sum(VisaApp.RcptAmt)),0) as AMT   " +
         //" FROM VisaApp INNER JOIN " +
         //" GeoCountryMaster ON VisaApp.PIssCountry = GeoCountryMaster.CountID LEFT OUTER JOIN " +
         //" ParamDetail ON VisaApp.PerNm = ParamDetail.PDetailID LEFT OUTER JOIN " +
         //" VisaType ON VisaApp.VisaType = VisaType.VTypeID " +
         //" Where Month(VisaApp.VisaDT) =04 " +
         //" And Year(VisaApp.VisaDT) = 2014 " +
         //" Group By VisaType.VisaTNm ";

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
         " Where VisaApp.VisaDT >='" + DtFrom.Value.ToString("dd/MMM/yyyy") + "' " +
         " And VisaApp.VisaDT <='" + DtTo.Value.ToString("dd/MMM/yyyy") + "' ";


            if (TxtFAppNo.Text.Trim() != "")
            {
                StrSQL = StrSQL + " And VisaApp.AppNoStr Like '%" + TxtFAppNo.Text.Trim() + "%'";
                StrSearch = StrSearch + "App No. =" + TxtFAppNo.Text.Trim() + " ";
            }
            if (TxtFSrNo.Text.Trim() != "")
            {
                StrSQL = StrSQL + " And VisaApp.RegNoStr Like '%" + TxtFSrNo.Text.Trim() + "%'";
                StrSearch = StrSearch + "Reg. No. =" + TxtFAppNo.Text.Trim() + " ";
            }
            if (TxtFVisaNo.Text.Trim() != "")
            {
                StrSQL = StrSQL + " And VisaApp.VisaNo Like '%" + TxtFVisaNo.Text.Trim() + "%'";
                StrSearch = StrSearch + "Visa No. =" + TxtFAppNo.Text.Trim() + " ";
            }
            if (TxtFPasportNo.Text.Trim() != "")
            {
                StrSQL = StrSQL + " And VisaApp.PasportNo Like '%" + TxtFPasportNo.Text.Trim() + "%'";
                StrSearch = StrSearch + "Passport No. =" + TxtFAppNo.Text.Trim() + " ";
            }
            if (CmbFVisaType.SelectedValue.ToString().Trim() != "0")
            {
                StrSQL = StrSQL + " And VisaApp.VisaType=" + CmbFVisaType.SelectedValue.ToString().Trim() + " ";
                StrSearch = StrSearch + "Visa Type =" + CmbFVisaType.Text.Trim() + " ";
            }
            if (TxtFName.Text.Trim() != "")
            {
                StrSQL = StrSQL + " And ((VisaApp.FirstNm Like '%" + TxtFName.Text.Trim() + "%' Or VisaApp.MidNm Like '%" + TxtFName.Text.Trim() + "%' Or VisaApp.LastNm Like '%" + TxtFName.Text.Trim() + "%')) ";
                StrSearch = StrSearch + "Name =" + TxtFName.Text.Trim() + " ";
            }

            if (RdSUnderProcess.Checked == true)
            {
                StrSQL = StrSQL + " And VisaApp.VisaStatus<3";
            }
            if (RdSApproved.Checked == true)
            {
                StrSQL = StrSQL + " And VisaApp.VisaPosition='A'";
            }
            if (RdSRejected.Checked == true)
            {
                StrSQL = StrSQL + " And VisaApp.VisaPosition='R'";
            }

            StrSQL = StrSQL + " Order By VisaApp.VisaDT, VisaApp.VisaNo";


            ClassReport CLR = new ClassReport();
            //RptMonthDetail
            //RptMonthSum
            string StrRptTital = "RETURNS OF VISA FROM DATE " + DtFrom.Value.ToString("dd/MMM/yyyy") + " TO " + DtTo.Value.ToString("dd/MMM/yyyy") + " ";
            if (StrSearch != "")
            { StrRptTital = StrRptTital + " " + StrSearch; }
            CLR.Fn_AddReportType(StrRptTital, "RptMonthDetail", StrSQL);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "Report.EXE";
            Process.Start(startInfo);
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbStatus.SelectedIndex == 1)
            {
                label25.Visible = true;
                label26.Visible = true;
                TxtVisaNo.Visible = true;
                TxtNoOfMoths.Visible = true;
            }
            else
            {
                label25.Visible = false;
                label26.Visible = false;
                TxtVisaNo.Visible = false;
                TxtNoOfMoths.Visible = false;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtID.Text.Trim() == "") { tabControl1.SelectedIndex = 0; }
        }
    }
}
