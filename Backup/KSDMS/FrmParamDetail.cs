 
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
    public partial class FrmParamDetail : Form
    {
        int SaveAction;
        public double DblParamID;
        public FrmParamDetail()
        {
            InitializeComponent();
        }

        private void FrmParamDetail_Load(object sender, EventArgs e)
        { 
            PnlData.Enabled = false;
            SaveAction = 0;
            GlobalFunction.Fn_GetButtons("C", PnlButton);
            Fn_GetParamName(); 
        }
        private void Fn_GetParamName()
        {
            ClassParamMaster CPM = new ClassParamMaster();
            CPM.SLNO = DblParamID.ToString();
            CPM.Fn_DataView();
            LblName.Text = CPM.ParamName.Trim();
            TxtShort.MaxLength = CPM.CodeLen;
            if (CPM.IsDefValue.Trim() == "N") { label1.Visible = false; TxtValue.Visible = false; }
        
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PnlData.Enabled = true;
            TxtShort.Enabled = true;
            TxtShort.Focus();
            ChkActive.Checked = true;
            GlobalFunction.Fn_GetButtons("A", PnlButton);
            SaveAction = 1;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ClassParamDetails DptM = new ClassParamDetails();
            string StrActive = "N";
            if (ChkActive.Checked == true) { StrActive = "Y"; }

            DptM.ParamID = DblParamID.ToString();
            DptM.SLNO = TxtID.Text;
            DptM.Action = SaveAction;
            DptM.PDetailCode = TxtShort.Text;
            DptM.PDetailName = TxtName.Text;
            DptM.PDefValue = Convert.ToDouble(TxtValue.Text);
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
            TxtValue.Text = "0";
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
            if (MessageBox.Show("Delete?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            SaveAction = 3;
            ClassParamDetails DptM = new ClassParamDetails();
            string StrActive = "N";
            if (ChkActive.Checked == true) { StrActive = "Y"; }

            DptM.ParamID = DblParamID.ToString();
            DptM.SLNO = TxtID.Text;
            DptM.Action = SaveAction;
            DptM.PDetailCode = TxtShort.Text;
            DptM.PDetailName = TxtName.Text;
            DptM.PDefValue = Convert.ToDouble(TxtValue.Text);
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
            GlobalFunction.Fn_GetButtons("D", PnlButton);
            SaveAction = 0;
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            PnlData.Enabled = false;
            GlobalFunction.Fn_GetButtons("V", PnlButton);

            FrmPopUp FrmP = new FrmPopUp();
            FrmP.HelpSQL = "Select PDetailID as [000,SLNO], PDetailName as [200,Name], PDetailCode as [100,Short]from ParamDetail Where ParamID=" + DblParamID + "";
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
            ClassParamDetails DptM = new ClassParamDetails();
            DptM.SLNO = TxtID.Text;
            DptM.Fn_DataView();
            TxtShort.Text = DptM.PDetailCode;
            TxtName.Text = DptM.PDetailName;
            TxtValue.Text = DptM.PDefValue.ToString();
            TxtLastDate.Text = DptM.LastDt.ToString(GlobalFunction.L_DateTimeFormat);
            if (DptM.IsActive == "Y") { ChkActive.Checked = true; }
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

        private void TxtValue_KeyPress(object sender, KeyPressEventArgs e)
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
