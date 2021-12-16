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
        private void Fn_Search()
        {
            if ((TxtFAppNo.Text.Trim() == "") && (TxtFSrNo.Text.Trim() == "") && (TxtFVisaNo.Text.Trim() == "") && (TxtFPasportNo.Text.Trim() == ""))
            {
                return;
            }

            string SQL = "Select VisaID,RegNoStr,AppNoStr,PasportNo,VisaNo,VisaPosition,VisaStatus," +
                " FirstNm + ' ' + MidNm + ' ' + LastNm as Name from VisaApp Where VisaID<>0";
            if (TxtFAppNo.Text.Trim() != "")
            {
                SQL = SQL + " And AppNoStr Like '%" + TxtFAppNo.Text.Trim() + "%'";
            }
            if (TxtFSrNo.Text.Trim() != "")
            {
                SQL = SQL + " And RegNoStr Like '%" + TxtFSrNo.Text.Trim() + "%'";
            }
            if (TxtFVisaNo.Text.Trim() != "")
            {
                SQL = SQL + " And VisaNo Like '%" + TxtFVisaNo.Text.Trim() + "%'";
            }
            if (TxtFPasportNo.Text.Trim() != "")
            {
                SQL = SQL + " And PasportNo Like '%" + TxtFPasportNo.Text.Trim() + "%'";
            }
            ClassCommenDataLayer RecDir = new ClassCommenDataLayer();
            GVPending.DataSource = RecDir.DL_DataViewSQLNew(SQL);
            GVPending.Columns[0].Visible = false;
            GVPending.Columns[1].Width = 130;
            GVPending.Columns[2].Width = 130;
            GVPending.Columns[3].Width = 150;
            GVPending.Columns[4].Width = 150;
            GVPending.Columns[5].Width = 50;
            GVPending.Columns[6].Width = 50;
            GVPending.Columns[7].Width = 150; 

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
    }
}
