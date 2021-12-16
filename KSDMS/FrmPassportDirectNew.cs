using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KSDMS.DataClass;

namespace KSDMS
{
    public partial class FrmPassportDirectNew : Form
    {
        int SaveAction;
        public int IntVisaStatus;
        public FrmPassportDirectNew()
        {
            InitializeComponent();
        }

        private void FrmPassportDirectNew_Load(object sender, EventArgs e)
        {
            GlobalFunction.Fn_SetBackGround(PnlButton);
            GlobalFunction.Fn_SetBackGround(PnlData);
            CmdBack.Visible = false; 

            PnlData.Enabled = false;
            SaveAction = 0;
            GlobalFunction.Fn_GetButtons("C", PnlButton);
            Fn_FillCombo();
        }
        private void Fn_FillCombo()
        {
            ClassParamDetails PD = new ClassParamDetails();
            CmbReqType.DataSource = PD.DV_RetParamDetailList("9");
            CmbReqType.DisplayMember = "PDetailName";
            CmbReqType.ValueMember = "PDetailID";

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
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TxtSrNo.Enabled = true;
            TxtSrNo.Focus();
            PnlData.Enabled = true;
            GlobalFunction.Fn_GetButtons("A", PnlButton);
            SaveAction = 1;

            ClassPassport PP = new ClassPassport();
            PP.Fn_GetNo();
            TxtSrNo.Text = PP.StrSrNo;
            TxtAppNo.Text = PP.StrSrNo;
            ChkActive.Checked = true;
            DtRegDt.Value = GlobalFunction.Fn_GetCurrentDateTime();
            DtAppDt.Value = GlobalFunction.Fn_GetCurrentDateTime();
            BtnRegister.Visible = false;
            TxtAppNo.Focus();
            TxtIssGov.Tag = "0";
            TxtContCountry.Tag = "0";
            TxtNewProcCount.Tag = "0";
            TxtNigCountry.Tag = "0";
            TxtKinCountry.Tag = "0";
            TxtNewEmbassy.Text = GlobalFunction.L_LocationName;
            TxtNewProcCount.Tag = GlobalFunction.L_LocationCountry;
            TxtNewProcCount.Text = GlobalFunction.L_LocationCountryNm;

                
        }
      
        private void BtnSave_Click(object sender, EventArgs e)
        {



            Fn_Save();




        }
        private Boolean Fn_Val()
        {
            Boolean BB = true;
            if (CmbReqType.SelectedValue.ToString().Trim() == "0")
            {
                MessageBox.Show("Select Request Type", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BB = false;
                CmbReqType.Focus();
            }
            if (TxtAppNo.Text.Trim() == "")
            {
                MessageBox.Show("Enter Application No", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtAppNo.Focus();
                BB = false;
            }
            if (TxtRcptAmt.Text.Trim() == "")
            {
                MessageBox.Show("Enter Amount", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtRcptAmt.Focus();
                BB = false;
            }
            if (TxtEnrolmentNo.Text.Trim() == "")
            {
                MessageBox.Show("Enter Enrolment Number", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtEnrolmentNo.Focus();
                BB = false;
            }
            if ((TxtPassNo.Text.Trim() == "") &&   (CmbReqType.SelectedValue.ToString().Trim() != "64"))           
            {
                MessageBox.Show("Enter Passport No", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPassNo.Focus();
                BB = false;
            }

            if ((TxtIssGov.Text.Trim() == "") && (CmbReqType.SelectedValue.ToString().Trim() != "64")) 
            {
                MessageBox.Show("Select Issuing Government", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtIssGov.Focus();
                BB = false;
            }
            if ((CmbIntial.SelectedValue.ToString().Trim() == "0") && (CmbReqType.SelectedValue.ToString().Trim() != "64")) 
            {
                MessageBox.Show("Select Initial Type", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BB = false;
                CmbIntial.Focus();
            }
            if ((TxtFNm.Text.Trim() == "") && (CmbReqType.SelectedValue.ToString().Trim() != "64")) 
            {
                MessageBox.Show("Enter First Name", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtFNm.Focus();
                BB = false;
            }
            if ((TxtLNm.Text.Trim() == "") && (CmbReqType.SelectedValue.ToString().Trim() != "64")) 
            {
                MessageBox.Show("Enter Last Name", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLNm.Focus();
                BB = false;
            }
            if ((CmbMStatus.SelectedValue.ToString().Trim() == "0") && (CmbReqType.SelectedValue.ToString().Trim() != "64")) 
            {
                MessageBox.Show("Select Marital Status", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BB = false;
                CmbMStatus.Focus();
            }
            if ((CmbSex.Text.ToString().Trim() == "Select") && (CmbReqType.SelectedValue.ToString().Trim() != "64")) 
            {
                MessageBox.Show("Select Sexs", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BB = false;
                CmbSex.Focus();
            }
            if ((TxtLGur.Text.Trim() == "") && (CmbReqType.SelectedValue.ToString().Trim() != "64"))
            {
                MessageBox.Show("Select Legal Guardian", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLGur.Focus();
                BB = false;
            }
            if ((TxtMotherNm.Text.Trim() == "") && (CmbReqType.SelectedValue.ToString().Trim() != "64")) 
            {
                MessageBox.Show("Select Mother's Name", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtMotherNm.Focus();
                BB = false;
            }

            if ((TxtContAdd1.Text.Trim() == "") && (CmbReqType.SelectedValue.ToString().Trim() != "64")) 
            {
                MessageBox.Show("Enter Address", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCotPhone.Focus();
                BB = false;
            }
          
            if (CmbStatus.SelectedIndex == 1)
            {
                if (TxtNewPassportNo.Text.Trim() == "")
                {
                    MessageBox.Show("Enter New Passport No", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNewPassportNo.Focus();
                    BB = false;
                }
                if (TxtNewProcCount.Text.Trim() == "")
                {
                    MessageBox.Show("Enter process country", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNewProcCount.Focus();
                    BB = false;
                }
                if (TxtNewEmbassy.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Embassy Name", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNewEmbassy.Focus();
                    BB = false;
                }
                if  (CmbNewInitial.SelectedValue.ToString().Trim() == "0")  
                {
                    MessageBox.Show("Select new initial type", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BB = false;
                    CmbNewInitial.Focus();
                }
                if (TxtNewFNm.Text.Trim() == "")  
                {
                    MessageBox.Show("Enter First NAme", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNewFNm.Focus();
                    BB = false;
                }
                if (TxtNewLNm.Text.Trim() == "")  
                {
                    MessageBox.Show("Enter Last Name", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNewLNm.Focus();
                    BB = false;
                }
                if ( CmbNewMartStatus.SelectedValue.ToString().Trim() == "0") 
                {
                    MessageBox.Show("Select Marital Status", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BB = false;
                    CmbNewMartStatus.Focus();
                }
                if (CmbNewGender.Text.ToString().Trim() == "Select")  
                {
                    MessageBox.Show("Select Sexs", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BB = false;
                    CmbNewGender.Focus();
                }
                if (TxtNewLegGar.Text.Trim() == "") 
                {
                    MessageBox.Show("Select Legal Guardian", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNewLegGar.Focus();
                    BB = false;
                }
                if (TxtNewMotherNm.Text.Trim() == "")  
                {
                    MessageBox.Show("Select Mother's Name", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNewMotherNm.Focus();
                    BB = false;
                }

            }

            ClassPassport DptM = new ClassPassport();
            if (DptM.Fn_CheckAppNo(TxtAppNo.Text.Trim(), TxtID.Text.Trim()) == true)
            {
                MessageBox.Show("Application No. Already in Database", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BB = false;
            }
            if (DptM.Fn_CheckRefNo(TxtRefNo.Text.Trim(), TxtID.Text.Trim()) == true)
            {
                MessageBox.Show("Ref. No. Already in Database", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BB = false;
            }
            if (DptM.Fn_CheckNewEnrolmentNo(TxtEnrolmentNo.Text.Trim(), TxtID.Text.Trim()) == true)
            {
                MessageBox.Show("Enrolmet No. Already in Database", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BB = false;
            }
            if (CmbStatus.SelectedIndex == 1)
            {
                if (DptM.Fn_CheckNewPassportNo(TxtNewPassportNo.Text.Trim(), TxtID.Text.Trim()) == true)
                {
                    MessageBox.Show("New Passport No Already in Database", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BB = false;
                }
            }

            return BB;
        }
        private void Fn_Save()
        {
            if (MessageBox.Show("Save?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (Fn_Val() == false) { return; }

            ClassPassport DptM = new ClassPassport();
            string StrActive = "N"; 
            if (ChkActive.Checked == true) { StrActive = "Y"; }  

            DptM.SLNO = TxtID.Text;
            DptM.Action = SaveAction;
            DptM.EntryType = "D";
            DptM.RegDt = DtRegDt.Value;
            DptM.EnrolmentNo = Convert.ToDouble(TxtEnrolmentNo.Text);
            DptM.ReqType = Convert.ToDouble(CmbReqType.SelectedValue.ToString());
            DptM.RefNo = TxtRefNo.Text.Trim();
            DptM.RefDate = DtRcpDt.Value;
            DptM.RefAmt = Convert.ToDouble(TxtRcptAmt.Text.Trim());

            DptM.AppID = TxtAppNo.Text.Trim();
            DptM.AppDt = DtAppDt.Value;
            DptM.PasportNo = TxtPassNo.Text.Trim();
            DptM.PIssDt = DtPIssueDt.Value;
            DptM.PExpDt = DtPExpDt.Value;
            DptM.PIssCountry = Convert.ToInt16(TxtIssGov.Tag.ToString());
             
            DptM.PerNm = CmbIntial.SelectedValue.ToString();
            DptM.FirstNm = TxtFNm.Text.Trim();
            DptM.MidNm = TxtMNm.Text.Trim();
            DptM.LastNm = TxtLNm.Text.Trim();
            DptM.Gender = CmbSex.Text.Trim();
            DptM.MarStatus = CmbMStatus.SelectedValue.ToString();
            DptM.DOB = DtDOB.Value;
            DptM.LegGard = TxtLGur.Text.Trim();
            DptM.MotherNm = TxtMotherNm.Text.Trim();
            DptM.SpouseNm = TxtSpouseNm.Text.Trim();

            

            DptM.ContPhone = TxtCotPhone.Text.Trim();
            DptM.ContEmail = TxtContEmail.Text.ToString();
            DptM.ContAdd1 = TxtContAdd1.Text.Trim();
            DptM.ContAdd2 = TxtContAdd2.Text.Trim();
            DptM.ContCountry = Convert.ToInt16(TxtContCountry.Tag.ToString());
            DptM.ContCity = TxtContCity.Text.Trim();
            DptM.ContState = TxtContState.Text.Trim();
            DptM.ContPin = TxtContPOstCode.Text.Trim();
            DptM.ContLGA = TxtContLGA.Text.Trim();
            DptM.ContDist = TxtContDist.Text.Trim();
             
            DptM.NewPassportNo = TxtNewPassportNo.Text.Trim();
            DptM.NewIssueDt = DtNewIssue.Value;
            DptM.NewExpDt = DtNewExp.Value;
            DptM.NewProcessCount = Convert.ToInt16(TxtNewProcCount.Tag.ToString());
            DptM.NewProcessEmbassy = TxtNewEmbassy.Text.Trim();
             

            DptM.NewPerNm = CmbNewInitial.SelectedValue.ToString();
            DptM.NewFNm = TxtNewFNm.Text.Trim();
            DptM.NewMNm = TxtNewMNm.Text.Trim();
            DptM.NewLNm = TxtNewLNm.Text.Trim();
            DptM.NewGender = CmbNewGender.Text.Trim();
            DptM.NewMarStatus = CmbNewMartStatus.SelectedValue.ToString();
            DptM.NewDOB = DtNewDOB.Value;
            DptM.NewLegGad = TxtNewLegGar.Text.Trim();
            DptM.NewMontherNm = TxtNewMotherNm.Text.Trim();
            DptM.NewSpouseNm = TxtNewSpouseNm.Text.Trim();
             

            DptM.NigAdd1 = TxtNigAdd1.Text.Trim();
            DptM.NigAdd2 = TxtNigAdd2.Text.Trim();
            DptM.NigCountry = Convert.ToInt16(TxtNigCountry.Tag.ToString());
            DptM.NigCity = TxtNigCIty.Text.Trim();
            DptM.NigState = TxtNigState.Text.Trim();
            DptM.NigPin = TxtNigPostCode.Text.Trim();
            DptM.NigLGA = TxtNigLGA.Text.Trim();
            DptM.NigDist = TxtNigDistrict.Text.Trim();
             

            DptM.KinNm = TxtKinNm.Text.Trim();
            DptM.KinRel = CmbKinRel.SelectedValue.ToString();
            DptM.KinContNo = TxtKinContactNo.Text.Trim();
            DptM.KinAdd1 = TxtKinAdd1.Text.Trim();
            DptM.KinAdd2 = TxtKinAdd2.Text.Trim();
            DptM.KinCountry = Convert.ToInt16(TxtKinCountry.Tag.ToString());
            DptM.KinCity = TxtKinCity.Text.Trim();
            DptM.KinState = TxtKinState.Text.Trim();
            DptM.KinLGA = TxtKinLGA.Text.Trim();
            DptM.KinDist = TxtKinDistrict.Text.Trim();
            DptM.KinPin = TxtKinPostCode.Text.Trim();

            string PPosition = "P";
            if (CmbStatus.SelectedIndex == 0) { PPosition = "P"; }
            if (CmbStatus.SelectedIndex == 1) { PPosition = "A"; }
            if (CmbStatus.SelectedIndex == 2) { PPosition = "R"; }
            DptM.PPosition = PPosition;

            DptM.IsActive = StrActive;

            string StrRet = "";
            DptM.Fn_Save(ref StrRet);

            if (StrRet == "")
            {
                PnlData.Enabled = false;
                GlobalFunction.Fn_GetButtons("S", PnlButton);
                ChkActive.Checked = true;
                if (TxtID.Text.Trim() == "")
                {

                    if (DptM.Fn_PassportView(TxtPassNo.Text.Trim()) == true)
                    {
                        TxtID.Text = DptM.SLNO;                       
                        BtnUpload.Enabled = true;
                    }


                }
                
            }
            else
            {
                MessageBox.Show(StrRet, GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Fn_Clear()
        {
            GlobalFunction.Fn_ClearForm(PnlOldPassport);
            GlobalFunction.Fn_ClearForm(PnlNewPassport);
            GlobalFunction.Fn_ClearForm(PnlPerDedails);
            GlobalFunction.Fn_ClearForm(PnlContact);
            GlobalFunction.Fn_ClearForm(PanNewPerDedails);
            GlobalFunction.Fn_ClearForm(PnlNig);
            GlobalFunction.Fn_ClearForm(PnlKin); 
            GlobalFunction.Fn_ClearForm(PnlData);
            
            //PnlSTR
            CmbStatus.SelectedIndex = 0;
            TxtSrNo.Enabled = true;
            SaveAction = 0;
            BtnUpload.Enabled = false; 
            CmbStatus.SelectedIndex = 1;
            BtnRegister.Visible = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            PnlData.Enabled = true;
            GlobalFunction.Fn_GetButtons("E", PnlButton);
            SaveAction = 2;
            BtnUpload.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            PnlData.Enabled = false;
            GlobalFunction.Fn_GetButtons("D", PnlButton);
            SaveAction = 0;
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            PnlData.Enabled = false;
            GlobalFunction.Fn_GetButtons("V", PnlButton);

            FrmPopUp FrmP = new FrmPopUp();
            FrmP.HelpSQL = "Select PassportID as [000,SLNO], FirstNm + ' ' + MidNm + ' ' + LastNm as [200,Name],RegNoStr as [150,RegNo]," +
                " AppNoStr as [150,AppNo], PasportNo as [100,PasportNo] " +
                " from PassportApp Where PStatus < 3 and EntryType='D' Order By PassportID";
            FrmP.HelpSearch = "[200,Name]";
            FrmP.ShowDialog();
            TxtID.Text = FrmP.HelpSLNO;


            if (TxtID.Text.Trim() == "")
            {

                MessageBox.Show("No Data Selected", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BtnUpload.Enabled = true;
            SaveAction = 0;
            PnlData.Enabled = false;
            GlobalFunction.Fn_GetButtons("V", PnlButton);
            Fn_DataView();
            Fn_CheckUpload();

        }
        private void Fn_DataView()
        {
            ChkActive.Checked = false;
            ClassPassport DptM = new ClassPassport();
            DptM.SLNO = TxtID.Text;
            DptM.Fn_DataView();

            TxtSrNo.Text = DptM.StrSrNo;

            DtRegDt.Value = DptM.RegDt ;
            CmbReqType.SelectedValue = DptM.ReqType;
            TxtRefNo.Text = DptM.RefNo.Trim();
            DtRcpDt.Value = DptM.RefDate;
            TxtRcptAmt.Text = DptM.RefAmt.ToString("0.00");
            TxtEnrolmentNo.Text = DptM.EnrolmentNo.ToString();

            TxtAppNo.Text = DptM.AppID.Trim();
            DtAppDt.Value = DptM.AppDt ;
            TxtPassNo.Text = DptM.PasportNo.Trim();
            DtPIssueDt.Value = DptM.PIssDt   ;
            DtPExpDt.Value = DptM.PExpDt  ;
            TxtIssGov.Tag = DptM.PIssCountry.ToString();

            CmbIntial.SelectedValue = DptM.PerNm.Trim();
            TxtFNm.Text = DptM.FirstNm.Trim();
            TxtMNm.Text = DptM.MidNm.Trim();
            TxtLNm.Text = DptM.LastNm.Trim();
            CmbSex.Text="";
            CmbSex.Text = DptM.Gender.Trim();
            CmbMStatus.SelectedValue = DptM.MarStatus.Trim();
            DtDOB.Value = DptM.DOB  ;
            TxtLGur.Text = DptM.LegGard.Trim();
            TxtMotherNm.Text = DptM.MotherNm.Trim();
            TxtSpouseNm.Text = DptM.SpouseNm.Trim();



            TxtCotPhone.Text = DptM.ContPhone.Trim();
            TxtContEmail.Text = DptM.ContEmail.Trim();
            TxtContAdd1.Text = DptM.ContAdd1.Trim();
            TxtContAdd2.Text = DptM.ContAdd2.Trim();
            TxtContCountry.Tag=DptM.ContCountry.ToString();
            TxtContCity.Text = DptM.ContCity.Trim();
            TxtContState.Text = DptM.ContState.Trim();
            TxtContPOstCode.Text = DptM.ContPin.Trim();
            TxtContLGA.Text = DptM.ContLGA.Trim();
            TxtContDist.Text = DptM.ContDist.Trim();

            //      " NewPassportNo, NewIssueDt,NewExpDt,NewProcessCount,NewProcessEmbassy," +
            TxtNewPassportNo.Text = DptM.NewPassportNo.Trim();
            DtNewIssue.Value = DptM.NewIssueDt ;
            DtNewExp.Value = DptM.NewExpDt ;
            TxtNewProcCount.Tag = DptM.NewProcessCount.ToString();
            TxtNewEmbassy.Text = DptM.NewProcessEmbassy.Trim();

            //      " NewPerNm,NewFNm,NewMNm,NewLNm,NewGender,NewMarStatus,NewDOB,NewLegGad,NewMontherNm,NewSpouseNm," +

            CmbNewInitial.SelectedValue = DptM.NewPerNm.Trim();
            TxtNewFNm.Text = DptM.NewFNm.Trim();
            TxtNewMNm.Text = DptM.NewMNm.Trim();
            TxtNewLNm.Text = DptM.NewLNm.Trim();
            CmbNewGender.Text="";
            CmbNewGender.Text = DptM.NewGender.Trim();
            CmbNewMartStatus.SelectedValue = DptM.NewMarStatus.ToString();
            DtNewDOB.Value = DptM.NewDOB ;
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
            TxtKinCountry.Tag= DptM.KinCountry.ToString();
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PnlData.Enabled = false;
            SaveAction = 0;
            Fn_Clear();
            GlobalFunction.Fn_GetButtons("C", PnlButton);

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GlobalFunction.Popup_CountryList(TxtIssGov);
            CmbIntial.Focus();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GlobalFunction.Popup_CountryList(TxtContCountry);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            
            
            if (TxtID.Text.Trim() == "") { return; }
            ClassDMS DMS = new ClassDMS();


            if (DMS.Fn_ValFrwdPassport(TxtID.Text.Trim()) == false)
            {
                MessageBox.Show("There is No File uploaded in this Application. Please upload files first", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Register?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }



            ClassPassport DptM = new ClassPassport();
            DptM.Fn_SendFrwdDirect(TxtID.Text, IntVisaStatus);
            Fn_Clear();
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            if (IntVisaStatus == 0) { return; }
            if (TxtID.Text.Trim() == "") { return; }
            if (MessageBox.Show("Register?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ClassVisa DptM = new ClassVisa();
            DptM.Fn_SendBack(TxtID.Text, IntVisaStatus, CmbStatus.Text.Trim());
            Fn_Clear();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
           // if (IntVisaStatus == 0) { return; }
            if (TxtID.Text.Trim() == "") { return; }
            FrmDMSPassport FDM = new FrmDMSPassport();
            FDM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            FDM.BackgroundImage = this.BackgroundImage;
            FDM.Text = "EDMS";
            FDM.StrVisaID1 = TxtID.Text.Trim();
            FDM.StrAppNo1 = TxtAppNo.Text.Trim();
            FDM.StrSrNo1 = TxtSrNo.Text.Trim();
            FDM.ShowDialog();
            Fn_CheckUpload();
        }

        private void TxtVisaNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNoOfMoths_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNoOfMoths_KeyPress(object sender, KeyPressEventArgs e)
        {
            String allowedChars = "1234567890.-";
            int II = e.KeyChar;
            if ((allowedChars.IndexOf(e.KeyChar) == -1) && (II != 8))
            {
                e.Handled = true;
            }
        }

        private void CmbVisaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((CmbReqType.SelectedValue.ToString().Trim() == "2") || (CmbReqType.SelectedValue.ToString().Trim() == "3"))
            {
                PnlNig.Visible = true;
                if (CmbReqType.SelectedValue.ToString().Trim() == "3")
                {
                    LblStj.Visible = true;
                    LblStjVisaNo.Visible = true;
                    TxtNigAdd1.Visible = true;
                }
                else
                {
                    LblStj.Visible = false;
                    LblStjVisaNo.Visible = false;
                    TxtNigAdd1.Visible = false;
                }
            }
            else
            {   }
        }

    

        private void TxtPassNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassNo_Leave(object sender, EventArgs e)
        {
            if (TxtPassNo.Text.Trim() == "") { return; }
            ClassVisa DptM = new ClassVisa();
            if (DptM.Fn_PassportView(TxtPassNo.Text.Trim()) == true)
            {
                DtPExpDt.Value = DptM.PExpDt;
                DtPIssueDt.Value = DptM.PIssDt;
                DtDOB.Value = DptM.DOB;
                TxtLGur.Text = DptM.PIssLocation;
                TxtIssGov.Tag = DptM.PIssCountry.ToString();
                CmbSex.Text = "";
                CmbIntial.SelectedValue = DptM.PerNm;
                CmbSex.SelectedText = DptM.Gender;
                CmbMStatus.SelectedValue = DptM.MarStatus;
                TxtFNm.Text = DptM.FirstNm;
                TxtMNm.Text = DptM.MidNm;
                TxtLNm.Text = DptM.LastNm;
                TxtMotherNm.Tag = DptM.AppNation;
                TxtPBirth.Text = DptM.PlaceOfBirth;
                TxtKinNm.Text = DptM.ResAdd1;
                TxtKinContactNo.Text = DptM.ResAdd2;
                TxtKinAdd1.Text = DptM.ResAdd3;
                TxtKinAdd2.Text = DptM.ContactNo;

                ClassCountry CT = new ClassCountry();
                CT.SLNO = TxtIssGov.Tag.ToString().Trim();
                CT.Fn_DataView();
                TxtIssGov.Text = CT.CName.Trim();

                CT.SLNO = TxtMotherNm.Tag.ToString().Trim();
                CT.Fn_DataView();
                TxtMotherNm.Text = CT.CName.Trim();
            }
        }

        private void TxtSTVisaNo_Leave(object sender, EventArgs e)
        {
            if (TxtNigAdd1.Text.Trim() == "") { return; }
            ClassVisa DptM = new ClassVisa();

            if (DptM.Fn_VisaView(TxtNigAdd1.Text.Trim()) == true) ;
            {

                TxtNigAdd2.Text = DptM.STRCompNm;
                TxtNigCIty.Text = DptM.STRAdd1;
                TxtNigCountry.Text = DptM.STRAdd2;
                TxtNigLGA.Text = DptM.STREQP;
                TxtNigDistrict.Text = DptM.STRRefNo;
                TxtNigPostCode.Text = DptM.StrNoMn.ToString(); 
            }




        }

        private void TxtIssGov_Enter(object sender, EventArgs e)
        {
            if (TxtIssGov.Text.Trim() == "")
            {
                GlobalFunction.Popup_CountryList(TxtIssGov);
                CmbIntial.Focus();
            }
        }

        private void TxtNationlity_Enter(object sender, EventArgs e)
        {
            if (TxtMotherNm.Text.Trim() == "")
            { GlobalFunction.Popup_CountryList(TxtMotherNm); }
        }

  

        private void FrmVisaDirectEntry_Activated(object sender, EventArgs e)
        {
            Fn_CheckUpload();
        }
        public void Fn_CheckUpload()
        {
            BtnRegister.Visible = false;
            ClassDMS DMS = new ClassDMS();
            if (TxtID.Text.Trim() == "") { return; }
            if (DMS.Fn_ValFrwdPassport(TxtID.Text.Trim()) == false)
            {
                BtnRegister.Visible = false;
            }
            else
            { BtnRegister.Visible = true; }
        }
         

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GlobalFunction.Popup_CountryList(TxtNigCountry);
        }

        private void TxtIssuePlace_Enter(object sender, EventArgs e)
        {
            if (TxtLGur.Text.Trim() == "")
            {
                GlobalFunction.Popup_ParamDetail(TxtLGur, "8");
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            GlobalFunction.Popup_CountryList(TxtNewProcCount);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GlobalFunction.Popup_CountryList(TxtKinCountry);
        }

        private void CmbStatus_Leave(object sender, EventArgs e)
        {
            try
            {
                TxtPassNo.Focus();
            }
            catch { }
        }

        private void TxtSpouseNm_Leave(object sender, EventArgs e)
        {
            try
            {
                TxtCotPhone.Focus();
            }
            catch{}
        }

        private void TxtContPOstCode_Leave(object sender, EventArgs e)
        {
            try
            {
                TxtNewPassportNo.Focus();
            }
            catch { }
        }

        private void TxtNewSpouseNm_Leave(object sender, EventArgs e)
        {
            try
            {
                TxtNigAdd1.Focus();
            }
            catch { }
        }

        private void TxtNigPostCode_Leave(object sender, EventArgs e)
        {
            try
            {
                TxtKinNm.Focus();
            }
            catch { }
        }

      

        private void TxtNewEmbassy_Leave(object sender, EventArgs e)
        {
            try
            {
                CmbNewInitial.Focus();
            }
            catch { }
        }

        private void TxtKinPostCode_Leave(object sender, EventArgs e)
        {
            try
            {
                BtnSave.Focus();
            }
            catch { }
        }

        private void rectangleShape5_DoubleClick(object sender, EventArgs e)
        {
            if (TxtNewLNm.Text.Trim() == "") 
            { 
                TxtNewLNm.Text = TxtLNm.Text.Trim();
                DtNewDOB.Value = DtDOB.Value;
                CmbNewInitial.SelectedValue = CmbIntial.SelectedValue;
                CmbNewMartStatus.SelectedValue = CmbMStatus.SelectedValue;
                CmbNewGender.Text = "";
                CmbNewGender.Text = CmbSex.Text;
            }
            if (TxtNewMNm.Text.Trim() == "") { TxtNewMNm.Text = TxtMNm.Text.Trim(); }
            if (TxtNewFNm.Text.Trim() == "") { TxtNewFNm.Text = TxtFNm.Text.Trim(); }
            if (TxtNewLegGar.Text.Trim() == "") { TxtNewLegGar.Text = TxtLGur.Text.Trim(); }
            if (TxtNewMotherNm.Text.Trim() == "") { TxtNewMotherNm.Text = TxtMotherNm.Text.Trim(); }
            if (TxtNewSpouseNm.Text.Trim() == "") { TxtNewSpouseNm.Text = TxtSpouseNm.Text.Trim(); }
            if (TxtNewPBirth.Text.Trim() == "") { TxtNewPBirth.Text = TxtPBirth.Text.Trim(); }
        }

        private void TxtContCountry_Enter(object sender, EventArgs e)
        {
            if (TxtContCountry.Text.Trim() == "") { GlobalFunction.Popup_CountryList(TxtContCountry); }
        }

        private void TxtNewProcCount_Enter(object sender, EventArgs e)
        {
            if (TxtNewProcCount.Text.Trim() == "") { GlobalFunction.Popup_CountryList(TxtNewProcCount); }
        }

        private void TxtNigCountry_Enter(object sender, EventArgs e)
        {
            if (TxtNigCountry.Text.Trim() == "") { GlobalFunction.Popup_CountryList(TxtNigCountry); }
        }

        private void TxtKinCountry_Enter(object sender, EventArgs e)
        {
            if (TxtKinCountry.Text.Trim() == "") { GlobalFunction.Popup_CountryList(TxtKinCountry); }
        }

        private void CmbReqType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbReqType.SelectedValue.ToString().Trim() == "64")
            {
                PnlOldPassport.Visible = false;
                PnlPerDedails.Visible = false;
                TxtIssGov.Tag = "0";
            }
            else
            {
                PnlOldPassport.Visible = true;
                PnlPerDedails.Visible = true;
            }
        }

        private void rectangleShape6_DoubleClick(object sender, EventArgs e)
        {
            if (TxtNigAdd1.Text.Trim() == "")
            {
                TxtNigAdd1.Text = TxtContAdd1.Text;
                TxtNigAdd2.Text = TxtContAdd2.Text;
                TxtNigCIty.Text = TxtContCity.Text;
                TxtNigCountry.Text = TxtContCountry.Text;
                TxtNigCountry.Tag = TxtContCountry.Tag;
                TxtNigState.Text = TxtContState.Text;
                TxtNigPostCode.Text = TxtContPOstCode.Text;
            }
        }

        private void rectangleShape7_DoubleClick(object sender, EventArgs e)
        {
            if (TxtKinAdd1.Text.Trim() == "")
            {
                TxtKinAdd1.Text = TxtContAdd1.Text;
                TxtKinAdd2.Text = TxtContAdd2.Text;
                TxtKinCity.Text = TxtContCity.Text;
                TxtKinCountry.Text = TxtContCountry.Text;
                TxtKinCountry.Tag = TxtContCountry.Tag;
                TxtKinState.Text = TxtContState.Text;
                TxtKinPostCode.Text = TxtContPOstCode.Text;
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

        }

        private void TxtRcptAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            String allowedChars = "1234567890.-";
            int II = e.KeyChar;
            if ((allowedChars.IndexOf(e.KeyChar) == -1) && (II != 8))
            {
                e.Handled = true;
            }
        }

        private void TxtEnrolmentNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            String allowedChars = "1234567890.-";
            int II = e.KeyChar;
            if ((allowedChars.IndexOf(e.KeyChar) == -1) && (II != 8))
            {
                e.Handled = true;
            }
        }

        private void CmdReject_Click(object sender, EventArgs e)
        {
            FrmPassportReject RR = new FrmPassportReject();
            RR.D_AppID = TxtAppNo.Text.Trim();
            RR.D_MSLNO = TxtID.Text.Trim();
            RR.ShowDialog();

        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbStatus.SelectedIndex == 2)
            {
                CmdReject.Visible = true;
            }
            else
            { CmdReject.Visible = false; }
        }

    

   
 
    }
}
