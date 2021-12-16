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
    public partial class FrmParamMaster : Form
    {
        int SaveAction;
        public FrmParamMaster()
        {
            InitializeComponent();
        }

        private void FrmParamMaster_Load(object sender, EventArgs e)
        {
            PnlData.Enabled = false;
            SaveAction = 0;
            GlobalFunction.Fn_GetButtons("C", PnlButton);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TxtCodeLen.Enabled = true;
            TxtCodeLen.Focus();
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
            ClassParamMaster DptM = new ClassParamMaster();
            string StrActive = "N";
            string StrDefValue = "N";
            if (ChkActive.Checked == true) { StrActive = "Y"; }
            if (ChkDefValue.Checked == true) { StrDefValue = "Y"; }

            DptM.SLNO = TxtID.Text;
            DptM.ParamName = TxtName.Text;
            DptM.Action = SaveAction;
            DptM.CodeLen = Convert.ToInt16(TxtCodeLen.Text);
            DptM.IsDefValue = StrDefValue;
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
            TxtCodeLen.Enabled = true;
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
            FrmP.HelpSQL = "Select ParamID as [100,SLNO], ParamName as [200,Name] from ParamMaster";
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
            ChkDefValue.Checked = false;
            ClassParamMaster DptM = new ClassParamMaster();
            DptM.SLNO = TxtID.Text;
            DptM.Fn_DataView();

            TxtName.Text = DptM.ParamName;
            TxtCodeLen.Text = DptM.CodeLen.ToString();

            TxtLastDate.Text = DptM.LastDt.ToString(GlobalFunction.L_DateTimeFormat);
            if (DptM.IsActive.Trim() == "Y") { ChkActive.Checked = true; }
            if (DptM.IsDefValue.Trim() == "Y") { ChkDefValue.Checked = true; }

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

        private void TxtShort_KeyPress(object sender, KeyPressEventArgs e)
        {
            String allowedChars = "1234567890.-";
            int II = e.KeyChar;
            if ((allowedChars.IndexOf(e.KeyChar) == -1) && (II != 8))
            {
                e.Handled = true;
            }
        }

        private void TxtCodeLen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
