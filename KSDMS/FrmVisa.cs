
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
    public partial class FrmVisa : Form
    {
        int SaveAction;
        public int IntVisaStatus;
        public FrmVisa()
        {
            InitializeComponent();
        }

        private void FrmVisa_Load(object sender, EventArgs e)
        {
            if (IntVisaStatus == 0)
            {
                CmdBack.Visible = false;
                XLHead.Text = "Visa Reception";
            }
            if (IntVisaStatus == 1)
            {
                BtnAdd.Visible = false;
                BtnSave.Visible = false;
                PnlStatus.Visible = true;
                XLHead.Text = "Visa  Assessment";
            }
            if (IntVisaStatus == 2)
            {
                BtnAdd.Visible = false;
                BtnSave.Visible = false;
                PnlStatus.Visible = true;
                PnlStatus.Enabled = false;
                PnlApproval.Visible = true;
                XLHead.Text = "Sticker Printing";
            }
            if (IntVisaStatus == 3)
            {

                BtnAdd.Visible = false;
                BtnSave.Visible = false;
                PnlStatus.Visible = true;
                PnlStatus.Enabled = false;
                PnlApproval.Visible = true;
                PnlApproval.Enabled = false;
                XLHead.Text = "Final Approval";
                BtnEdit.Visible = false;
            }
            if (IntVisaStatus == 4)
            {
                BtnUpload.Visible = true;
                BtnRegister.Visible = true;
                BtnSave.Visible = false;
                XLHead.Text = "Document Uploading";
                PnlStatus.Visible = true;
                PnlStatus.Enabled = false;
                PnlApproval.Visible = true;
                PnlApproval.Enabled = false;
                BtnAdd.Visible = false;
                BtnEdit.Visible = false;
                BtnUpload.Enabled = true;
            }
            PnlData.Enabled = false;
            SaveAction = 0;
            GlobalFunction.Fn_GetButtons("C", PnlButton);


            Fn_FillCombo();
        }
        private void Fn_FillCombo()
        {
            ClassVisaType VT = new ClassVisaType();
            CmbVisaType.DataSource = VT.DV_RetDptList();
            CmbVisaType.DisplayMember = "VisaTNm";
            CmbVisaType.ValueMember = "VTypeID";


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
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TxtSrNo.Enabled = true;
            TxtSrNo.Focus();
            PnlData.Enabled = true;
            GlobalFunction.Fn_GetButtons("A", PnlButton);
            SaveAction = 1;

            ClassVisa PP = new ClassVisa();
            PP.Fn_GetNo();
            TxtSrNo.Text = PP.StrSrNo;
            TxtAppNo.Text = PP.StrSrNo;
            DtRegDt.Value = GlobalFunction.Fn_GetCurrentDateTime();
            DtAppDt.Value = GlobalFunction.Fn_GetCurrentDateTime();
        }
        private void Fn_StatusUPdate()
        {
            if (TxtID.Text.Trim() == "") { return; }
            //if (MessageBox.Show("Update Status?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //{
            //    return;
            //}
            ClassVisa DptM = new ClassVisa();
            if (CmbStatus.SelectedIndex == 0)
            {
                TxtNoOfMoths.Text = "0";
                TxtVisaNo.Text = "";
                DptM.Fn_VisaStatusUpdate(TxtID.Text.Trim(), TxtVisaNo.Text.Trim(), TxtNoOfMoths.Text.Trim(), DtApp.Value, "P");
            }
            if (CmbStatus.SelectedIndex == 1)
            {
                TxtNoOfMoths.Text = "0";
                DptM.Fn_VisaStatusUpdate(TxtID.Text.Trim(), TxtVisaNo.Text.Trim(), TxtNoOfMoths.Text.Trim(), DtApp.Value, "A");
            }
            else
            {
                TxtNoOfMoths.Text = "0";
                TxtVisaNo.Text = "";
                DptM.Fn_VisaStatusUpdate(TxtID.Text.Trim(), TxtVisaNo.Text.Trim(), TxtNoOfMoths.Text.Trim(), DtApp.Value, "R");
            }

            //if (CmbStatus.SelectedIndex != 0)
            //{
            //    DptM.Fn_SendFrwd(TxtID.Text, IntVisaStatus);
            //}
            //Fn_Clear();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {

            Fn_Save();


        }
        private Boolean Fn_Val()
        {
            Boolean BB = true;
            if (CmbVisaType.SelectedValue.ToString().Trim() == "0")
            {
                MessageBox.Show("Select Visa Type", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BB = false;
                CmbVisaType.Focus();
            }
            if (TxtAppNo.Text.Trim() == "")
            {
                MessageBox.Show("Enter Application No", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtAppNo.Focus();
                BB = false;
            }
            if (TxtPassNo.Text.Trim() == "")
            {
                MessageBox.Show("Enter Passport No", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPassNo.Focus();
                BB = false;
            }
            if (TxtOccupation.Text.Trim() == "")
            {
                MessageBox.Show("Enter Issueing place", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtOccupation.Focus();
                BB = false;
            }
            if (TxtIssGov.Text.Trim() == "")
            {
                MessageBox.Show("Select Issuing Government", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtIssGov.Focus();
                BB = false;
            }
            if (CmbIntial.SelectedValue.ToString().Trim() == "0")
            {
                MessageBox.Show("Select Initial Type", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BB = false;
                CmbIntial.Focus();
            }
            if (TxtFNm.Text.Trim() == "")
            {
                MessageBox.Show("Enter First Name", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtFNm.Focus();
                BB = false;
            }
            if (TxtLNm.Text.Trim() == "")
            {
                MessageBox.Show("Enter Last Name", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLNm.Focus();
                BB = false;
            }
            if (CmbMStatus.SelectedValue.ToString().Trim() == "0")
            {
                MessageBox.Show("Select Marital Status", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BB = false;
                CmbMStatus.Focus();
            }
            if (CmbSex.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Select Sexs", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BB = false;
                CmbSex.Focus();
            }
            if (TxtNationlity.Text.Trim() == "")
            {
                MessageBox.Show("Select Nationality", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNationlity.Focus();
                BB = false;
            }
            if (TxtNCompNm.Text.Trim() == "")
            {
                MessageBox.Show("Enter Address", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtAdd1.Focus();
                BB = false;
            }
            if (TxtNContactNo.Text.Trim() == "")
            {
                MessageBox.Show("Enter Contact Number", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtContactNo.Focus();
                BB = false;
            }

            if (TxtRefNo.Text.Trim() == "")
            {
                MessageBox.Show("Enter Reference No.", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtRefNo.Focus();
                BB = false;
            }

            ClassVisa DptM = new ClassVisa();
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
            if ((CmbStatus.SelectedIndex == 1) && (DptM.Fn_CheckVisaNo(TxtVisaNo.Text.Trim(), TxtID.Text.Trim()) == true))
            {
                MessageBox.Show("Visa No. Already in Database", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BB = false;
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

            ClassVisa DptM = new ClassVisa();
            string StrActive = "N";
            string StrNoInt = "Single";
            if (ChkActive.Checked == true) { StrActive = "Y"; }
            if (RdMultiple.Checked == true) { StrNoInt = "Multiple"; }

            DptM.SLNO = TxtID.Text;
            DptM.Action = SaveAction;
            DptM.RegDt = DtRegDt.Value;
            DptM.VisaType = CmbVisaType.SelectedValue.ToString();
            DptM.NoOfEnt = StrNoInt;
            DptM.AppNoStr = TxtAppNo.Text.Trim();
            DptM.AppDt = DtAppDt.Value;
            DptM.PIssDt = DtPIssueDt.Value;
            DptM.PExpDt = DtPExpDt.Value;
            DptM.DOB = DtDOB.Value;
            DptM.PasportNo = TxtPassNo.Text.Trim();
            DptM.PIssLocation = TxtOccupation.Text.Trim();
            DptM.PIssCountry = Convert.ToInt16(TxtIssGov.Tag.ToString());
            DptM.PerNm = CmbIntial.SelectedValue.ToString();
            DptM.FirstNm = TxtFNm.Text.Trim();
            DptM.MidNm = TxtMNm.Text.Trim();
            DptM.LastNm = TxtLNm.Text.Trim();
            DptM.Gender = CmbSex.Text.Trim();
            DptM.MarStatus = CmbMStatus.SelectedValue.ToString();
            DptM.PlaceOfBirth = TxtPBirth.Text.Trim();
            DptM.AppNation = TxtNationlity.Tag.ToString();
            DptM.ResAdd1 = TxtAdd1.Text.Trim();
            DptM.ResAdd2 = TxtAdd2.Text.Trim();
            DptM.ResAdd3 = TxtAdd3.Text.Trim();
            DptM.ContactNo = TxtContactNo.Text.Trim();
            DptM.RefNo = TxtRefNo.Text.Trim();
            DptM.STJVisaNo = TxtSTVisaNo.Text.Trim();
            DptM.STRCompNm = TxtSTCompNm.Text.Trim();
            DptM.STRAdd1 = TxtSTAdd1.Text.Trim();
            DptM.STRAdd2 = TxtSTAdd2.Text.Trim();
            DptM.STREQP = TxtSTEQP.Text.Trim();
            DptM.STRFromDt = DtStToDt.Value;
            DptM.StrToDt = DtStToDt.Value;
            DptM.Occupation = Convert.ToDouble(TxtOccupation.Tag.ToString());
            if (TxtStMonth.Text.Trim() == "") { TxtStMonth.Text = "0"; }
            if (TxtStYear.Text.Trim() == "") { TxtStYear.Text = "0"; }
            DptM.StrNoMn = Convert.ToInt16(TxtStMonth.Text.Trim());
            DptM.StrNoYear = Convert.ToInt16(TxtStYear.Text.Trim());
            DptM.STRRefNo = TxtSTRefNo.Text.Trim();
            DptM.VisaStatus = IntVisaStatus;
            //RefNo, STJVisaNo,STRCompNm,STRAdd1,STRAdd2,STREQP,STRRefNo,STRFromDt,StrToDt,StrNoMn,StrNoYear

            if (TxtRcptAmt.Text.Trim() == "") { TxtRcptAmt.Text = "0.00"; }
            DptM.RcptNo = TxtRefNo.Text.Trim();
            DptM.RcptDt = DtRcpDt.Value;
            DptM.RcptAmt = Convert.ToDouble(TxtRcptAmt.Text.Trim());
            DptM.NCopmNm = TxtNCompNm.Text.Trim();
            DptM.NCompAdd1 = TxtNAdd1.Text.Trim();
            DptM.NCompAdd2 = TxtNAdd2.Text.Trim();
            DptM.NCompCnt = TxtNContactNo.Text.Trim();

            //" RcptNo,RcptDt,RcptAmt,NCopmNm,NCompAdd1,NCompAdd2,NCompCnt,"
            DptM.IsActive = StrActive;
            DptM.EntryType = "N";
            //RefNo, STJVisaNo,STRCompNm,STRAdd1,STRAdd2,STREQP,STRRefNo,STRFromDt,StrToDt,StrNoMn,StrNoYear

            DptM.IsActive = StrActive;

            string StrRet = "";
            DptM.Fn_Save(ref StrRet);

            if (StrRet == "")
            {
                PnlData.Enabled = false;
                GlobalFunction.Fn_GetButtons("S", PnlButton);
                ChkActive.Checked = true;
                if (IntVisaStatus != 2)
                {
                    Fn_Clear();
                }
            }
            else
            {
                MessageBox.Show(StrRet, GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Fn_Clear()
        {
            GlobalFunction.Fn_ClearForm(PnlData);
            GlobalFunction.Fn_ClearForm(PnlApproval);
            GlobalFunction.Fn_ClearForm(PnlSTR);
            DtStToDt.Value = DateTime.Now;
            DtStFromDt.Value = DateTime.Now;
            //PnlSTR
            CmbStatus.SelectedIndex = 0;
            TxtSrNo.Enabled = true;
            SaveAction = 0;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            PnlData.Enabled = true;
            PnlApproval.Enabled = true;
            GlobalFunction.Fn_GetButtons("E", PnlButton);
            SaveAction = 2;

            if (IntVisaStatus == 0)
            {
                TxtAppNo.Focus();
            }
            if (IntVisaStatus == 1)
            {
                CmbStatus.Focus();
            }
            if (IntVisaStatus == 2)
            {
                TxtVisaNo.Focus();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            PnlData.Enabled = false;
            GlobalFunction.Fn_GetButtons("D", PnlButton);
            SaveAction = 0;
        }

        private void BtnView_Click(object sender, EventArgs e)
        {


            FrmPopUp FrmP = new FrmPopUp();
            FrmP.HelpSQL = "Select VisaID as [000,SLNO], FirstNm + ' ' + MidNm + ' ' + LastNm as [200,Name],RegNoStr as [150,RegNo]," +
                " AppNoStr as [150,AppNo], PasportNo as [100,PasportNo] " +
                " from VisaApp Where VisaStatus=" + IntVisaStatus + "   Order By VisaID";
            FrmP.HelpSearch = "[100,PasportNo]";
            FrmP.ShowDialog();
            TxtID.Text = FrmP.HelpSLNO;


            if (TxtID.Text.Trim() == "")
            {

                MessageBox.Show("No Data Selected", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveAction = 0;
            PnlData.Enabled = false;
            GlobalFunction.Fn_GetButtons("V", PnlButton);
            Fn_DataView();

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
            if (DptM.VisaPosition.Trim() == "A") { CmbStatus.SelectedIndex = 1; }
            if (DptM.VisaPosition.Trim() == "R") { CmbStatus.SelectedIndex = 2; TxtNoOfMoths.Text = "0"; }
            if (DptM.VisaPosition.Trim() == "A")
            {
                try
                {
                    TxtVisaNo.Text = DptM.VisaNo;
                    TxtNoOfMoths.Text = DptM.VisaForTime;
                    DtApp.Value = DptM.VisaDT1;
                }
                catch { }

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
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PnlData.Enabled = false;
            SaveAction = 0;
            Fn_Clear();
            PnlSTR.Visible = false;
            GlobalFunction.Fn_GetButtons("C", PnlButton);
            PnlApproval.Enabled = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GlobalFunction.Popup_CountryList(TxtIssGov);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GlobalFunction.Popup_CountryList(TxtNationlity);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (TxtID.Text.Trim() == "") { return; }


            if (IntVisaStatus == 1)
            {
                if (CmbStatus.SelectedIndex == 0)
                {
                    MessageBox.Show("You are not allowed to register Visa Application, Still Visa status is pending.", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (CmbStatus.SelectedIndex == 2)
                {
                    ClassDMS DMS = new ClassDMS();
                    if (DMS.Fn_ValRej(TxtID.Text.Trim()) == false)
                    {
                        MessageBox.Show("Please enter why visa rejected, before Registration.", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        Fn_StatusUPdate();
                    }
                }


            }

            if (IntVisaStatus == 2)
            {
                if (TxtVisaNo.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter Visa Number, before Registration.", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                { TxtNoOfMoths.Text = "0"; Fn_StatusUPdate(); }
            }


            if (IntVisaStatus == 4)
            {
                ClassDMS DMS = new ClassDMS();
                if (DMS.Fn_ValFrwd(TxtID.Text.Trim()) == false)
                {
                    MessageBox.Show("There is No File uploaded in this Application. Please upload files first", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (MessageBox.Show("Register?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            ClassVisa DptM = new ClassVisa();
            DptM.Fn_SendFrwd(TxtID.Text, IntVisaStatus, CmbStatus.Text.Trim());

            Fn_Clear();
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            if (IntVisaStatus == 0) { return; }
            if (TxtID.Text.Trim() == "") { return; }
            if (MessageBox.Show("Want To Send Back?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ClassVisa DptM = new ClassVisa();
            DptM.Fn_SendBack(TxtID.Text, IntVisaStatus, CmbStatus.Text.Trim());
            Fn_Clear();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            if (IntVisaStatus == 0) { return; }
            if (TxtID.Text.Trim() == "") { return; }
            FrmDMS FDM = new FrmDMS();
            FDM.StrVisaID = TxtID.Text.Trim();
            FDM.StrAppNo = TxtAppNo.Text.Trim();
            FDM.StrSrNo = TxtSrNo.Text.Trim();
            FDM.ShowDialog();

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

        private void TxtStMonth_Leave(object sender, EventArgs e)
        {
            Fn_GetLstDt();
        }

        private void Fn_GetLstDt()
        {
            if (TxtStMonth.Text.Trim() == "") { TxtStMonth.Text = "0"; }
            if (TxtStYear.Text.Trim() == "") { TxtStYear.Text = "0"; }

            int ItMN = Convert.ToInt16(TxtStMonth.Text);
            int ItYr = Convert.ToInt16(TxtStYear.Text);
            DateTime DDTT = DtStFromDt.Value;
            DDTT = DDTT.AddMonths(ItMN).AddYears(ItYr);
            DtStToDt.Value = DDTT;
        }

        private void TxtStYear_Leave(object sender, EventArgs e)
        {
            Fn_GetLstDt();
        }

        private void DtStFromDt_Leave(object sender, EventArgs e)
        {
            Fn_GetLstDt();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GlobalFunction.Popup_ParamDetail(TxtOccupation, "8");
        }

        private void TxtIssGov_Enter(object sender, EventArgs e)
        {
            if (TxtIssGov.Text.Trim() == "")
            {
                GlobalFunction.Popup_CountryList(TxtIssGov);
                if (TxtNationlity.Text.Trim() == "")
                {
                    TxtNationlity.Text = TxtIssGov.Text;
                    TxtNationlity.Tag = TxtIssGov.Tag.ToString().Trim();
                }
            }
        }

        private void TxtOccupation_Enter(object sender, EventArgs e)
        {
            if (TxtOccupation.Text.Trim() == "")
            {
                GlobalFunction.Popup_ParamDetail(TxtOccupation, "8");
            }
        }

        private void TxtNationlity_Enter(object sender, EventArgs e)
        {
            if (TxtNationlity.Text.Trim() == "")
            { GlobalFunction.Popup_CountryList(TxtNationlity); }
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

        private void TxtPassNo_Leave(object sender, EventArgs e)
        {
            if (TxtPassNo.Text.Trim() == "") { return; }
            ClassVisa DptM = new ClassVisa();
            if (DptM.Fn_PassportView(TxtPassNo.Text.Trim()) == true)
            {
                DtPExpDt.Value = DptM.PExpDt;
                DtPIssueDt.Value = DptM.PIssDt;
                DtDOB.Value = DptM.DOB;
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

                ClassCountry CT = new ClassCountry();
                CT.SLNO = TxtIssGov.Tag.ToString().Trim();
                CT.Fn_DataView();
                TxtIssGov.Text = CT.CName.Trim();

                CT.SLNO = TxtNationlity.Tag.ToString().Trim();
                CT.Fn_DataView();
                TxtNationlity.Text = CT.CName.Trim();
            }
        }

        private void TxtSTVisaNo_Leave(object sender, EventArgs e)
        {
            if (TxtSTVisaNo.Text.Trim() == "") { return; }
            ClassVisa DptM = new ClassVisa();

            if (DptM.Fn_VisaView(TxtSTVisaNo.Text.Trim()) == true) ;
            {

                TxtSTCompNm.Text = DptM.STRCompNm;
                TxtSTAdd1.Text = DptM.STRAdd1;
                TxtSTAdd2.Text = DptM.STRAdd2;
                TxtSTEQP.Text = DptM.STREQP;
                TxtSTRefNo.Text = DptM.STRRefNo;
                TxtStMonth.Text = DptM.StrNoMn.ToString();
                TxtStYear.Text = DptM.StrNoYear.ToString();
                DtStFromDt.Value = DptM.STRFromDt;
                DtStToDt.Value = DptM.StrToDt;
            }
        }

        private void CmdReject_Click(object sender, EventArgs e)
        {
            FrmVisaRej RR = new FrmVisaRej();
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

        private void PnlSTR_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (TxtSTCompNm.Text.Trim() == "")
            {
                TxtSTCompNm.Text = TxtNCompNm.Text.Trim();
                TxtSTAdd1.Text = TxtNAdd1.Text.Trim();
                TxtSTAdd2.Text = TxtNAdd2.Text.Trim();
            }
        }

        private void TxtVisaNo_Leave(object sender, EventArgs e)
        {
            if (TxtVisaNo.Text.Trim() == "") { return; }
            ClassVisa DptM = new ClassVisa();
            if (DptM.Fn_CheckVisaNo(TxtVisaNo.Text.Trim(), TxtID.Text.Trim()) == true)
            {
                MessageBox.Show("Visa No. Already in Database", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtVisaNo.Focus();
            }
        }
    }
}
