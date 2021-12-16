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
    public partial class FrmVisaDoc : Form
    {
        int SaveAction;
        public FrmVisaDoc()
        {
            InitializeComponent();
        }

        private void FrmVisaDoc_Load(object sender, EventArgs e)
        {
            Fn_GetVisaType();
            PnlData.Enabled = false; 
            GlobalFunction.Fn_GetButtons("C", PnlButton);
        }
        void Fn_GetVisaType()
        { 
            ClassVisaType VT = new ClassVisaType();
            GvVisaType.DataSource = VT.DV_RetGridView();
            GvVisaType.Columns[0].Visible = false;
            GvVisaType.Columns[1].Width = GvVisaType.Width-35;

        
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PnlData.Enabled = false; 
            Fn_Clear();
            GlobalFunction.Fn_GetButtons("C", PnlButton);
        }
        private void Fn_Clear()
        {
            GlobalFunction.Fn_ClearForm(PnlData);
            TxtShort.Enabled = true; 
        }

        private void GvVisaType_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LblFor.Tag = GvVisaType.CurrentRow.Cells[0].Value.ToString();
            LblFor.Text = GvVisaType.CurrentRow.Cells[1].Value.ToString();
            Fn_GetDocs();
            PnlData.Enabled = false;
            Fn_Clear();
            GlobalFunction.Fn_GetButtons("C", PnlButton);
        }
        private void Fn_GetDocs()
        {
            //SLNO, SrNo,DocName,IsActive

            ClassVisaType VT = new ClassVisaType();
            GvVisaDocks.DataSource = VT.DV_RetGridDocs(LblFor.Tag.ToString());
            GvVisaDocks.Columns[0].Visible = false;
            GvVisaDocks.Columns[1].Width = 50;
            GvVisaDocks.Columns[2].Width = 400;
            GvVisaDocks.Columns[3].Width = 80;
            GvVisaDocks.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            GvVisaDocks.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (LblFor.Tag.ToString().Trim() == "")
            {
                return;
            }
            TxtShort.Enabled = true;
            TxtShort.Focus();
            PnlData.Enabled = true;
            GlobalFunction.Fn_GetButtons("A", PnlButton);
            SaveAction = 1;
            ChkActive.Checked = true;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtShort.Text.Trim() == "")
            {
                MessageBox.Show("Enter Sr.No", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtShort.Focus();
                return;
            }
            if (TxtName.Text.Trim() == "")
            {
                MessageBox.Show("Enter Dock Type", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtName.Focus();
                return;
            }
            if (MessageBox.Show("Save?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            ClassVisaType DptM = new ClassVisaType();
            string StrActive = "N";
            if (ChkActive.Checked == true) { StrActive = "Y"; }

            DptM.Fn_SaveDoc(TxtID.Text, LblFor.Tag.ToString(), TxtShort.Text, TxtName.Text, StrActive);
            DptM.SLNO = TxtID.Text;
            DptM.Action = SaveAction;
            DptM.CShort = TxtShort.Text;
            DptM.CName = TxtName.Text;
            DptM.IsActive = StrActive;

            Fn_GetDocs();
            Fn_Clear();
            
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
            PnlData.Enabled = false;
            GlobalFunction.Fn_GetButtons("V", PnlButton);
            SaveAction = 0;
            ChkActive.Checked = false;
            TxtID.Text = GvVisaDocks.CurrentRow.Cells[0].Value.ToString();
            TxtShort.Text = GvVisaDocks.CurrentRow.Cells[1].Value.ToString();
            TxtName.Text = GvVisaDocks.CurrentRow.Cells[2].Value.ToString();            
            if (GvVisaDocks.CurrentRow.Cells[3].Value.ToString().Trim() == "Y") { ChkActive.Checked = true; }
           // TxtShort.Enabled = false;
        }

        private void GvVisaDocks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Fn_DataView();
        }

        private void GvVisaType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GvVisaType_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            LblFor.Tag = GvVisaType.CurrentRow.Cells[0].Value.ToString();
            LblFor.Text = GvVisaType.CurrentRow.Cells[1].Value.ToString();
            Fn_GetDocs();
            PnlData.Enabled = false;
            Fn_Clear();
            GlobalFunction.Fn_GetButtons("C", PnlButton);
        }

        private void GvVisaDocks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Fn_DataView();
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
    }
}
