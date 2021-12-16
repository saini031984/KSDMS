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
    public partial class FrmUserMaster : Form
    {
        int SaveAction;
        public FrmUserMaster()
        {
            InitializeComponent();
        }

        private void FrmUserMaster_Load(object sender, EventArgs e)
        {
            PnlData.Enabled = true;
            SaveAction = 0;

            Fn_FillCombo();
            GlobalFunction.Fn_GetButtons("C", PnlButton); 
            Fn_Clear();
        }
        private void Fn_FillCombo()
        {
            ClassDepartmentMaster UserM = new ClassDepartmentMaster();
            CmbDpt.DataSource = UserM.DV_RetDptList();
            CmbDpt.DisplayMember = "DeptName";
            CmbDpt.ValueMember = "DeptID";

            ClassLocation LocM = new ClassLocation();
            CmbLocation.DataSource = LocM.DV_RetLocList();
            CmbLocation.DisplayMember = "LocName";
            CmbLocation.ValueMember = "LocationID";

            ClassUserRoll UserRoll = new ClassUserRoll();
            CmbRoll.DataSource = UserRoll.DV_RetRollList();
            CmbRoll.DisplayMember = "RollType";
            CmbRoll.ValueMember = "RollID";

            //ClassLangMaster LangM = new ClassLangMaster();
            //CmbLanguage.DataSource = LangM.DV_RetLanList();
            //CmbLanguage.DisplayMember = "LangName";
            //CmbLanguage.ValueMember = "LangID";

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TxtCode.Enabled = true;
            TxtCode.Focus();
            PnlData.Enabled = true;
            GlobalFunction.Fn_GetButtons("A", PnlButton);
            SaveAction = 1;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ClassUserMaster UserM = new ClassUserMaster();
            string StrActive = "N";
            if (ChkActive.Checked == true) { StrActive = "Y"; }

            UserM.SLNO = TxtID.Text;
            UserM.Action = SaveAction;

            UserM.LoginID = TxtCode.Text;
            UserM.FirstName = TxtFName.Text;
            UserM.MiddleName = TxtMName.Text;
            UserM.LastName = TxtLName.Text;
            UserM.Password = TxtPassword.Text;
            UserM.eMail = TxtEmail.Text;
            UserM.GroupID = "0";
            UserM.DouaneCode = TxtDouneCode.Text.ToUpper();
            UserM.DeptID = CmbDpt.SelectedValue.ToString();
            UserM.LangKnow = "1";
            UserM.LocationID = CmbLocation.SelectedValue.ToString();
            UserM.UserRole = CmbRoll.SelectedValue.ToString();

            UserM.IsActive = StrActive;

            string StrRet = "";
            UserM.Fn_Save(ref StrRet);

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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            PnlData.Enabled = true;
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
            string SQL = "";
            GlobalFunction.Fn_GetButtons("V", PnlButton);

            FrmPopUp FrmP = new FrmPopUp();
            SQL = "Select UserID as [000,SLNO], LastName + ' ' + MiddleName + ' ' + FirstName as [200,UserName], LoginID as [100,LoginID], " +
                " DeptShort as [100,DeptShort] , LocName as [100,LocName], LocType as [100,LocType] from QryUserMaster Where UserID<>0 ";
            if (GlobalFunction.L_LoginID.Trim() != "1")
            {
                if (GlobalFunction.L_LocationType.Trim() == "Post")
                {
                    SQL = SQL + " And LocationID=" + GlobalFunction.L_LocationID + " ";
                }
                if (GlobalFunction.L_LocationType.Trim() == "Region Office")
                {
                    SQL = SQL + " And RegionID=" + GlobalFunction.L_Zone + " ";
                }
            }
            FrmP.HelpSQL = SQL;
            FrmP.HelpSearch = "[200,UserName]";
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
            ClassUserMaster UserM = new ClassUserMaster();
            UserM.SLNO = TxtID.Text;
            UserM.Fn_DataView();

            TxtCode.Text = UserM.LoginID;
            TxtFName.Text = UserM.FirstName;
            TxtMName.Text = UserM.MiddleName;
            TxtLName.Text = UserM.LastName;
            TxtDouneCode.Text = UserM.DouaneCode.Trim();
            TxtPassword.Text = UserM.Password;
            TxtRePassword.Text = UserM.Password;
            TxtEmail.Text = UserM.eMail;

            CmbDpt.SelectedValue = UserM.DeptID;
            CmbRoll.SelectedValue = UserM.UserRole;
            CmbLocation.SelectedValue = UserM.LocationID;
            CmbLanguage.SelectedValue = UserM.LangKnow;


            TxtLastDate.Text = UserM.LastDt.ToString(GlobalFunction.L_DateTimeFormat);
            if (UserM.IsActive == "Y") { ChkActive.Checked = true; }
            TxtCode.Enabled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PnlData.Enabled = false;
            SaveAction = 0;
            Fn_Clear();
            GlobalFunction.Fn_GetButtons("C", PnlButton);
        }
        private void Fn_Clear()
        {
            GlobalFunction.Fn_ClearForm(PnlData);
            TxtCode.Enabled = false;
            SaveAction = 0;
            CmbDpt.SelectedIndex = 0;
            CmbLocation.SelectedIndex = 0;
            CmbRoll.SelectedIndex = 0;
           // CmbLanguage.SelectedIndex = 0;
            ChkActive.Checked = true;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


    }
 
