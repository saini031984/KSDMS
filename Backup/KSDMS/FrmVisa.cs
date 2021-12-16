 
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
            if (IntVisaStatus == 0) { CmdBack.Visible = false; }
            if (IntVisaStatus == 1) 
            {
                BtnUpload.Visible = true;
                BtnAdd.Visible = false;
                BtnSave.Visible = false;
            }
            if (IntVisaStatus == 2)
            {
                BtnUpload.Visible = true;
                BtnRegister.Visible = false;
                PnlApproval.Left = PnlData.Left;
                PnlData.Top = PnlApproval.Height+50;
                PnlApproval.Width = PnlData.Width;
                PnlApproval.Visible = true;
                BtnAdd.Visible = false;
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
            CmbSex.Items.Add("Mail");
            CmbSex.Items.Add("Femail");
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
            if (MessageBox.Show("Update Status?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ClassVisa DptM = new ClassVisa();
            if (CmbStatus.SelectedIndex == 0)
            {
                TxtNoOfMoths.Text = "0";
                TxtVisaNo.Text = "";
                DptM.Fn_VisaStatusUpdate(TxtID.Text.Trim(), TxtVisaNo.Text.Trim(), TxtNoOfMoths.Text.Trim(), DtApp.Value,"P");
            }
            if (CmbStatus.SelectedIndex == 1)
            {
                if (TxtNoOfMoths.Text.Trim() == "")
                {
                    return;
                }
                if (TxtVisaNo.Text.Trim() == "")
                {
                    return;
                }
                DptM.Fn_VisaStatusUpdate(TxtID.Text.Trim(), TxtVisaNo.Text.Trim(), TxtNoOfMoths.Text.Trim(), DtApp.Value, "A");
            }
            else
            {
                TxtNoOfMoths.Text = "0";
                TxtVisaNo.Text = "";
                DptM.Fn_VisaStatusUpdate(TxtID.Text.Trim(), TxtVisaNo.Text.Trim(), TxtNoOfMoths.Text.Trim(), DtApp.Value, "R");
            }
          
            if (CmbStatus.SelectedIndex !=0)
            {
                DptM.Fn_SendFrwd(TxtID.Text, IntVisaStatus);
            }
            Fn_Clear();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IntVisaStatus == 2)
            {
                Fn_StatusUPdate();
            }
            else
            {
                Fn_Save();
            }
            
        }
        private void Fn_Save()
        {
            if (MessageBox.Show("Save?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

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
            DptM.PIssLocation = TxtIssuePlace.Text.Trim();
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


            DptM.IsActive = StrActive;

            string StrRet = "";
            DptM.Fn_Save(ref StrRet);

            if (StrRet == "")
            {
                PnlData.Enabled = false;
                GlobalFunction.Fn_GetButtons("S", PnlButton);
                ChkActive.Checked = true;
                Fn_Clear();
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
            FrmP.HelpSQL = "Select VisaID as [000,SLNO], FirstNm + ' ' + MidNm + ' ' + LastNm as [200,Name],RegNoStr as [150,RegNo]," +
                " AppNoStr as [150,AppNo], PasportNo as [100,PasportNo] " +
                " from VisaApp Where VisaStatus=" + IntVisaStatus + " Order By VisaID";
            FrmP.HelpSearch = "[200,Name]";
            FrmP.ShowDialog();
            TxtID.Text = FrmP.HelpSLNO;
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
            TxtIssuePlace.Text = DptM.PIssLocation;
            TxtIssGov.Tag = DptM.PIssCountry.ToString();

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
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PnlData.Enabled = false;
            SaveAction = 0;
            Fn_Clear();
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
            if (MessageBox.Show("Register?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ClassVisa DptM = new ClassVisa();
            DptM.Fn_SendFrwd(TxtID.Text,IntVisaStatus);
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
            DptM.Fn_SendBack(TxtID.Text, IntVisaStatus);
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
 
      

     

   

   
    }
}
