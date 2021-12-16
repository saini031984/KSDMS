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
    public partial class FrmLocation : Form
    {
        int SaveAction;
        public FrmLocation()
        {
            InitializeComponent();
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {

            //GlobalFunction.Fn_ChkForm(this, PnlData);
            //GlobalFunction.Fn_ChkForm(this, PnlButton);
            PnlData.Enabled = true;
            SaveAction = 0;
            GlobalFunction.Fn_GetButtons("C", PnlButton);
            Fn_FillCombo();

            CmbType.SelectedIndex = 0;
            //GlobalFunction.Fn_NameLabel(PnlButton, this);
            //GlobalFunction.Fn_NameLabel(PnlData, this);

            PnlData.Enabled = false;
            GlobalFunction.Fn_GetButtons("V", PnlButton);


            TxtID.Text = "1";
          
            SaveAction = 0;
            PnlData.Enabled = false;
            GlobalFunction.Fn_GetButtons("V", PnlButton);
            Fn_DataView();
        }

        private void Fn_FillCombo()
        {
            CmbType.Items.Add("Select");
            CmbType.Items.Add("Embassy"); 

            ClassParamDetails UserM = new ClassParamDetails();
            CmbRegion.DataSource = UserM.DV_RetParamDetailList("11");
            CmbRegion.ValueMember = "PDetailID";
            CmbRegion.DisplayMember = "PDetailName";
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Trim()=="")
            {
                MessageBox.Show("Enter Name", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            if (CmbType.SelectedIndex == 0)
            {
                MessageBox.Show("Select Location Type", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CmbRegion.SelectedIndex == 0)
            {
                MessageBox.Show("Select Under Region", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TxtCountry.Text.Trim() == "")
            {
                MessageBox.Show("Select Country Name", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Save?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ClassLocation LocM = new ClassLocation();
            string StrActive = "N";
            if (ChkActive.Checked == true) { StrActive = "Y"; }

            LocM.SLNO = TxtID.Text;
            LocM.Action = SaveAction;
            LocM.LShort = TxtShort.Text;
            LocM.LName = TxtName.Text;
            LocM.RegionID = CmbRegion.SelectedValue.ToString();
            LocM.LType = CmbType.Text;
            LocM.LAdd = TxtAdd.Text;
            LocM.LArea = TxtArea.Text;
            LocM.LZip = TxtZip.Text;
            LocM.LPhone = TxtPhone.Text;
            LocM.CityNm = TxtCity.Text;
            LocM.CountryNm = Convert.ToInt16(TxtCountry.Tag);

            LocM.IsActive = StrActive;

            string StrRet = "";
            LocM.Fn_Save(ref StrRet);

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
            TxtShort.Enabled = true;
            SaveAction = 0;
            CmbType.SelectedIndex = 0;
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
            TxtID.Text = "1";

            SaveAction = 0;
            PnlData.Enabled = false;
            GlobalFunction.Fn_GetButtons("V", PnlButton);
            Fn_DataView();
        }
        private void Fn_DataView()
        {
            ChkActive.Checked = false;
            ClassLocation LocM = new ClassLocation();
            LocM.SLNO = TxtID.Text;
            LocM.Fn_DataView();
            TxtShort.Text = LocM.LShort;
            TxtName.Text = LocM.LName;

            CmbRegion.SelectedValue = LocM.RegionID.ToString();
            CmbType.Text = LocM.LType;
            TxtAdd.Text = LocM.LAdd;
            TxtArea.Text = LocM.LArea;
            TxtZip.Text = LocM.LZip;
            TxtPhone.Text = LocM.LPhone;
            TxtCity.Text = LocM.CityNm.Trim();
            TxtCountry.Tag = LocM.CountryNm.ToString();

            TxtLastDate.Text = LocM.LastDt.ToString(GlobalFunction.L_DateTimeFormat);
            if (LocM.IsActive == "Y") { ChkActive.Checked = true; }
            TxtShort.Enabled = false;

           

            if ((TxtCountry.Tag.ToString().Trim() != "") && (TxtCountry.Tag.ToString().Trim() != "0"))
            {
                ClassCountry CT = new ClassCountry();
                CT.SLNO = TxtCountry.Tag.ToString().Trim();
                CT.Fn_DataView();
                TxtCountry.Text = CT.CName.Trim();
                
            }
            
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PnlData.Enabled = false;
            SaveAction = 0;
            Fn_Clear();
            GlobalFunction.Fn_GetButtons("C", PnlButton);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TxtShort.Enabled = true;
            TxtShort.Focus();
            PnlData.Enabled = true;
            GlobalFunction.Fn_GetButtons("A", PnlButton);
            SaveAction = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GlobalFunction.Popup_CountryList(TxtCountry);
        }

        private void TxtCountry_Enter(object sender, EventArgs e)
        {
            if (TxtCountry.Text.Trim() == "")
            {
                GlobalFunction.Popup_CountryList(TxtCountry);
            }
        }
    }
}
