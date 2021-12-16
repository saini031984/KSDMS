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
    public partial class FrmVisaType : Form
    {
        int SaveAction;
        public FrmVisaType()
        {
            InitializeComponent();
        }

        private void FrmVisaType_Load(object sender, EventArgs e)
        {
            PnlData.Enabled = false;
            SaveAction = 0;
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            ClassVisaType DptM = new ClassVisaType();
            string StrActive = "N";
            if (ChkActive.Checked == true) { StrActive = "Y"; }

            DptM.SLNO = TxtID.Text;
            DptM.Action = SaveAction;
            DptM.CShort = TxtShort.Text;
            DptM.CName = TxtName.Text;
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
            TxtShort.Enabled = true;
            SaveAction = 0;
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
            GlobalFunction.Fn_GetButtons("V", PnlButton);

            FrmPopUp FrmP = new FrmPopUp();
            FrmP.HelpSQL = "Select VTypeID as [000,SLNO], VisaTNm as [200,Name], VisaTShort as [100,Short]from VisaType";
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
            ClassVisaType DptM = new ClassVisaType();
            DptM.SLNO = TxtID.Text;
            DptM.Fn_DataView();
            TxtShort.Text = DptM.CShort;
            TxtName.Text = DptM.CName;
            TxtLastDate.Text = DptM.LastDt.ToString(GlobalFunction.L_DateTimeFormat);
            if (DptM.IsActive.Trim() == "Y") { ChkActive.Checked = true; }
            TxtShort.Enabled = false;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
