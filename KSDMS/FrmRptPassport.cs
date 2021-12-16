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
    public partial class FrmRptPassport : Form
    {
        string SQLFind;
        string StrSearch;
        public FrmRptPassport()
        {
            InitializeComponent();
        }

        private void FrmRptPassport_Load(object sender, EventArgs e)
        {
            SQLFind = "";
            StrSearch = "";
            Fn_FillCombo();
        }
        private void Fn_Find()
        {
            StrSearch = "";
            SQLFind = " SELECT PassportApp.PassportID, PassportApp.NewIssueDt as IssueDt, PassportApp.NewProcessEmbassy as Embassy, PassportApp.NewPassportNo as PassportNo,  " +
            " PassportApp.NewLNm + ' ' + PassportApp.NewFNm + ' ' + PassportApp.NewMNm as AppNm,  PassportApp.NewGender as Gender, " +
            " PassportApp.NigAdd1 + ' ' + PassportApp.NigAdd2  + ' ' +  PassportApp.NigCity  + ' ' +  " +
            " PassportApp.NigState  + ' ' +  PassportApp.NigLGA  + ' ' +  PassportApp.NigDist  + ' ' +  PassportApp.NigPin as Address, PassportApp.RefAmt as AMT, " +
            " PassportApp.EnrolmentNo, PassportApp.AppNoStr as AppID, PassportApp.RefNo, ParamDetail.PDetailName as Remarks " +
            " FROM PassportApp INNER JOIN " +
            " ParamDetail ON PassportApp.ReqType = ParamDetail.PDetailID " +
            " Where PassportApp.NewIssueDt>='" + DtFrom.Value.ToString("dd/MMM/yyyy") + "' " +
                      " And PassportApp.NewIssueDt<='" + DtTo.Value.ToString("dd/MMM/yyyy") + "' "; 
             
            if (TxtFAppNo.Text.Trim() != "") { SQLFind = SQLFind + " And PassportApp.AppNoStr  Like '%" + TxtFAppNo.Text.Trim() + "%'"; StrSearch= StrSearch + ", APPLIACTION ID : " + TxtFAppNo.Text.Trim() + "" ; }
            if (TxtFPasportNo.Text.Trim() != "") { SQLFind = SQLFind + " And ((PassportApp.NewPassportNo  Like '%" + TxtFPasportNo.Text.Trim() + "%' ) OR (PassportApp.PasportNo  Like '%" + TxtFPasportNo.Text.Trim() + "%' ))"; StrSearch = StrSearch + ", PASSPORT NO. : " + TxtFPasportNo.Text.Trim() + ""; }
            if (TxtFEnlomentNo.Text.Trim() != "") { SQLFind = SQLFind + " And PassportApp.EnrolmentNo  Like '%" + TxtFEnlomentNo.Text.Trim() + "%'"; StrSearch = StrSearch + ", ENROLMENT NO. : " + TxtFEnlomentNo.Text.Trim() + ""; }
            if (CmbFReqType.SelectedValue.ToString().Trim() != "0")
            {
                SQLFind = SQLFind + " And PassportApp.ReqType=" + CmbFReqType.SelectedValue.ToString().Trim() + "";
                StrSearch = StrSearch + ", REQUEST TYPE : " + CmbFReqType.Text.Trim() + "";
            }
            if (TxtFName.Text.Trim() != "") { SQLFind = SQLFind + " And PassportApp.NewLNm + ' ' + PassportApp.NewFNm + ' ' + PassportApp.NewMNm   Like '%" + TxtFName.Text.Trim() + "%'"; StrSearch = StrSearch + ", NAME : " + TxtFName.Text.Trim() + ""; }


            SQLFind = SQLFind + "Order BY PassportApp.NewPassportNo asc";



            ClassCommenDataLayer RecDir = new ClassCommenDataLayer();
            GVPending.DataSource = RecDir.DL_DataViewSQLNew(SQLFind);
            GVPending.Columns[0].Visible = false;
            GVPending.Columns[1].Width = 100;
            GVPending.Columns[2].Width = 100;
            GVPending.Columns[3].Width = 100;
            GVPending.Columns[4].Width = 270;
            GVPending.Columns[5].Width = 50;
            GVPending.Columns[6].Visible = false;
            GVPending.Columns[7].Width = 100;
            GVPending.Columns[8].Width = 100;
            GVPending.Columns[9].Width = 100;
            GVPending.Columns[10].Width = 100;
            GVPending.Columns[11].Width = 100; 
        }
        private void Fn_FillCombo()
        {
            ClassParamDetails PD = new ClassParamDetails();
            CmbReqType.DataSource = PD.DV_RetParamDetailList("9");
            CmbReqType.DisplayMember = "PDetailName";
            CmbReqType.ValueMember = "PDetailID";

            CmbFReqType.DataSource = PD.DV_RetParamDetailList("9");
            CmbFReqType.DisplayMember = "PDetailName";
            CmbFReqType.ValueMember = "PDetailID";

            CmbKinRel.DataSource = PD.DV_RetParamDetailList("10");
            CmbKinRel.DisplayMember = "PDetailName";
            CmbKinRel.ValueMember = "PDetailID";

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

            CmbNewInitial.DataSource = PD.DV_RetParamDetailList("2");
            CmbNewInitial.DisplayMember = "PDetailName";
            CmbNewInitial.ValueMember = "PDetailID";

            CmbNewMartStatus.DataSource = PD.DV_RetParamDetailList("1");
            CmbNewMartStatus.DisplayMember = "PDetailName";
            CmbNewMartStatus.ValueMember = "PDetailID";

            CmbNewGender.Items.Add("Select");
            CmbNewGender.Items.Add("Male");
            CmbNewGender.Items.Add("Female");
            CmbNewGender.SelectedIndex = 0;


            CmbStatus.Items.Add("Pending");
            CmbStatus.Items.Add("Approved");
            CmbStatus.Items.Add("Rejected");
            CmbStatus.SelectedIndex = 1;




        }
        private void Fn_DataView()
        {
            ChkActive.Checked = false;
            ClassPassport DptM = new ClassPassport();
            DptM.SLNO = TxtID.Text;
            DptM.Fn_DataView();

            TxtSrNo.Text = DptM.StrSrNo;

            DtRegDt.Value = DptM.RegDt;
            CmbReqType.SelectedValue = DptM.ReqType;
            TxtRefNo.Text = DptM.RefNo.Trim();
            DtRcpDt.Value = DptM.RefDate;
            TxtRcptAmt.Text = DptM.RefAmt.ToString("0.00");
            TxtEnrolmentNo.Text = DptM.EnrolmentNo.ToString();


            TxtAppNo.Text = DptM.AppID.Trim();
            DtAppDt.Value = DptM.AppDt;
            TxtPassNo.Text = DptM.PasportNo.Trim();
            DtPIssueDt.Value = DptM.PIssDt;
            DtPExpDt.Value = DptM.PExpDt;
            TxtIssGov.Tag = DptM.PIssCountry.ToString();

            CmbIntial.SelectedValue = DptM.PerNm.Trim();
            TxtFNm.Text = DptM.FirstNm.Trim();
            TxtMNm.Text = DptM.MidNm.Trim();
            TxtLNm.Text = DptM.LastNm.Trim();
            CmbSex.Text = "";
            CmbSex.Text = DptM.Gender.Trim();
            CmbMStatus.SelectedValue = DptM.MarStatus.Trim();
            DtDOB.Value = DptM.DOB;
            TxtLGur.Text = DptM.LegGard.Trim();
            TxtMotherNm.Text = DptM.MotherNm.Trim();
            TxtSpouseNm.Text = DptM.SpouseNm.Trim();



            TxtCotPhone.Text = DptM.ContPhone.Trim();
            TxtContEmail.Text = DptM.ContEmail.Trim();
            TxtContAdd1.Text = DptM.ContAdd1.Trim();
            TxtContAdd2.Text = DptM.ContAdd2.Trim();
            TxtContCountry.Tag = DptM.ContCountry.ToString();
            TxtContCity.Text = DptM.ContCity.Trim();
            TxtContState.Text = DptM.ContState.Trim();
            TxtContPOstCode.Text = DptM.ContPin.Trim();
            TxtContLGA.Text = DptM.ContLGA.Trim();
            TxtContDist.Text = DptM.ContDist.Trim();

            //      " NewPassportNo, NewIssueDt,NewExpDt,NewProcessCount,NewProcessEmbassy," +
            TxtNewPassportNo.Text = DptM.NewPassportNo.Trim();
            DtNewIssue.Value = DptM.NewIssueDt;
            DtNewExp.Value = DptM.NewExpDt;
            TxtNewProcCount.Tag = DptM.NewProcessCount.ToString();
            TxtNewEmbassy.Text = DptM.NewProcessEmbassy.Trim();

            //      " NewPerNm,NewFNm,NewMNm,NewLNm,NewGender,NewMarStatus,NewDOB,NewLegGad,NewMontherNm,NewSpouseNm," +

            CmbNewInitial.SelectedValue = DptM.NewPerNm.Trim();
            TxtNewFNm.Text = DptM.NewFNm.Trim();
            TxtNewMNm.Text = DptM.NewMNm.Trim();
            TxtNewLNm.Text = DptM.NewLNm.Trim();
            CmbNewGender.Text = "";
            CmbNewGender.Text = DptM.NewGender.Trim();
            CmbNewMartStatus.SelectedValue = DptM.NewMarStatus.ToString();
            DtNewDOB.Value = DptM.NewDOB;
            TxtNewLegGar.Text = DptM.NewLegGad.Trim();
            TxtNewMotherNm.Text = DptM.NewMontherNm.Trim();
            TxtNewSpouseNm.Text = DptM.NewSpouseNm.Trim();

            //      " NigAdd1,NigAdd2,NigCity,NigCountry,NigState,NigLGA,NigDist,NigPin," +

            TxtNigAdd1.Text = DptM.NigAdd1.Trim();
            TxtNigAdd2.Text = DptM.NigAdd2.Trim();
            TxtNigCountry.Tag = DptM.NigCountry.ToString();
            TxtNigCIty.Text = DptM.NigCity.Trim();
            TxtNigState.Text = DptM.NigState.Trim();
            TxtNigPostCode.Text = DptM.NigPin.Trim();
            TxtNigLGA.Text = DptM.NigLGA.Trim();
            TxtNigDistrict.Text = DptM.NigDist.Trim();

            //      " KinNm,KinRel,KinContNo,KinAdd1,KinAdd2,KinCity,KinCountry,KinState,KinLGA,KinDist,KinPin," +

            TxtKinNm.Text = DptM.KinNm.Trim();
            CmbKinRel.SelectedValue = DptM.KinRel.Trim();
            TxtKinContactNo.Text = DptM.KinContNo.Trim();
            TxtKinAdd1.Text = DptM.KinAdd1.Trim();
            TxtKinAdd2.Text = DptM.KinAdd2.Trim();
            TxtKinCountry.Tag = DptM.KinCountry.ToString();
            TxtKinCity.Text = DptM.KinCity.Trim();
            TxtKinState.Text = DptM.KinState.Trim();
            TxtKinLGA.Text = DptM.KinLGA.Trim();
            TxtKinDistrict.Text = DptM.KinDist.Trim();
            TxtKinPostCode.Text = DptM.KinPin.Trim();

            if (DptM.PPosition.Trim() == "P") { CmbStatus.SelectedIndex = 0; }
            if (DptM.PPosition.Trim() == "A") { CmbStatus.SelectedIndex = 1; }
            if (DptM.PPosition.Trim() == "R") { CmbStatus.SelectedIndex = 2; }

            TxtLastDate.Text = DptM.LastDt.ToString(GlobalFunction.L_DateTimeFormat);
            if (DptM.IsActive.Trim() == "Y") { ChkActive.Checked = true; }
            TxtSrNo.Enabled = false;

            ClassCountry CT = new ClassCountry();

            if ((TxtIssGov.Tag.ToString().Trim() != "") && (TxtIssGov.Tag.ToString().Trim() != "0"))
            {
                CT.SLNO = TxtIssGov.Tag.ToString().Trim();
                CT.Fn_DataView();
                TxtIssGov.Text = CT.CName.Trim();
            }

            if ((TxtNewProcCount.Tag.ToString().Trim() != "") && (TxtNewProcCount.Tag.ToString().Trim() != "0"))
            {
                CT.SLNO = TxtNewProcCount.Tag.ToString().Trim();
                CT.Fn_DataView();
                TxtNewProcCount.Text = CT.CName.Trim();
            }
            if ((TxtContCountry.Tag.ToString().Trim() != "") && (TxtContCountry.Tag.ToString().Trim() != "0"))
            {
                CT.SLNO = TxtContCountry.Tag.ToString().Trim();
                CT.Fn_DataView();
                TxtContCountry.Text = CT.CName.Trim();
            }
            if ((TxtNigCountry.Tag.ToString().Trim() != "") && (TxtNigCountry.Tag.ToString().Trim() != "0"))
            {
                CT.SLNO = TxtNigCountry.Tag.ToString().Trim();
                CT.Fn_DataView();
                TxtNigCountry.Text = CT.CName.Trim();
            }
            if ((TxtKinCountry.Tag.ToString().Trim() != "") && (TxtKinCountry.Tag.ToString().Trim() != "0"))
            {
                CT.SLNO = TxtKinCountry.Tag.ToString().Trim();
                CT.Fn_DataView();
                TxtKinCountry.Text = CT.CName.Trim();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (TxtID.Text.Trim() == "") { return; }
            FrmDMSPassport FDM = new FrmDMSPassport();
            FDM.StrVisaID1 = TxtID.Text.Trim();
            FDM.StrAppNo1 = TxtAppNo.Text.Trim();
            FDM.StrSrNo1 = TxtSrNo.Text.Trim();
            FDM.StrUpload1 = "N";
            FDM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fn_Find();
        }

        private void GVPending_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtID.Text = GVPending.CurrentRow.Cells[0].Value.ToString();
            Fn_DataView();
            tabControl1.SelectedIndex = 1;
        }

        private void TxtFEnlomentNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            String allowedChars = "1234567890.-";
            int II = e.KeyChar;
            if ((allowedChars.IndexOf(e.KeyChar) == -1) && (II != 8))
            {
                e.Handled = true;
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ClassReport CLR = new ClassReport();
            //RptMonthDetail
            //RptMonthSum
            string StrRptTital = "RETURNS OF PASSPORT FROM DATE " + DtFrom.Value.ToString("dd/MMM/yyyy") + " TO " + DtTo.Value.ToString("dd/MMM/yyyy") + " ";
            if (StrSearch != "")
            { StrRptTital = StrRptTital + " " + StrSearch; }
            CLR.Fn_AddReportType(StrRptTital, "RptMonthDetailPassport", SQLFind);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "Report.EXE";
            Process.Start(startInfo);
        }

       
    }
}
