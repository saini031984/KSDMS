 
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
    public partial class FrmVisaRej : Form
    {
        int SaveAction;
        public string D_MSLNO;
        public string D_AppID;
        public FrmVisaRej()
        {
            InitializeComponent();
        }

        private void FrmVisaRej_Load(object sender, EventArgs e)
        {
            if (D_MSLNO == null)
            {
                this.Close();
                return;
            }
            else
            {
                LblFor.Tag = D_MSLNO;
                LblFor.Text = D_AppID;
            
            }
            PnlData.Enabled = true;
            SaveAction = 0;
            GlobalFunction.Fn_GetButtons("C", PnlButton);

            Fn_FillGrid(); 
             

             
        }
        private void Fn_FillGrid()
        {
            ClassVisa PP = new ClassVisa();
            PP.RMLNO = LblFor.Tag.ToString().Trim();
            GvWhy.DataSource = PP.DV_RetGridViewVisa();
            GvWhy.Refresh();
            GvWhy.Columns[0].Visible = false;
            GvWhy.Columns[1].Width = 100;
            GvWhy.Columns[2].Width = 500;
            GvWhy.Columns[3].Width = 100;
        }
        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtWhy.Text.Trim()=="")
            {
                MessageBox.Show("Enter Why", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TxtSrNo.Text.Trim() == "")
            {
                MessageBox.Show("Enter Sr.No", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClassVisa LocM = new ClassVisa();
            string StrActive = "N";
            if (ChkActive.Checked == true) { StrActive = "Y"; }

            LocM.RMLNO = LblFor.Tag.ToString().Trim(); 
            LocM.RSLNO = TxtID.Text.Trim(); 
            LocM.RSrNo= TxtSrNo.Text;
            LocM.RWhy = TxtWhy.Text;           

            LocM.RIsActive = StrActive;

             
            LocM.Fn_SaveVisaRej();

             
                PnlData.Enabled = false;
                GlobalFunction.Fn_GetButtons("S", PnlButton);
                ChkActive.Checked = true;
                Fn_Clear();
                Fn_FillGrid(); 
        }
        private void Fn_Clear()
        {
            GlobalFunction.Fn_ClearForm(PnlData);
            TxtSrNo.Enabled = true;
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
            TxtID.Text = "1";

            SaveAction = 0;
            PnlData.Enabled = false;
            GlobalFunction.Fn_GetButtons("V", PnlButton);
            Fn_DataView();
        }
        private void Fn_DataView()
        {
            ChkActive.Checked = false;
            ClassVisa LocM = new ClassVisa();
            LocM.RSLNO = TxtID.Text;
            LocM.Fn_DataViewRej();
            TxtSrNo.Text = LocM.RSrNo;
            TxtWhy.Text = LocM.RWhy;             

            TxtLastDate.Text = LocM.LastDt.ToString(GlobalFunction.L_DateTimeFormat);
            if (LocM.IsActive == "Y") { ChkActive.Checked = true; }
            TxtSrNo.Enabled = false;

            
            
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
            TxtSrNo.Enabled = true;
            TxtSrNo.Focus();
            PnlData.Enabled = true;
            GlobalFunction.Fn_GetButtons("A", PnlButton);
            SaveAction = 1;
            ChkActive.Checked = true;
        }

        private void GvWhy_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtID.Text = GvWhy.CurrentRow.Cells[0].Value.ToString().Trim();
            
            DataView();
        }
        private void DataView()
        {

            PnlData.Enabled = false;
            GlobalFunction.Fn_GetButtons("V", PnlButton);
            ChkActive.Checked = false;
            ClassPassport CP = new ClassPassport();
            CP.RSLNO = TxtID.Text;
            CP.Fn_DataViewRej();
            TxtSrNo.Text = CP.RSrNo;
            TxtWhy.Text = CP.RWhy; 
            TxtLastDate.Text = CP.LastDt.ToString(GlobalFunction.L_DateTimeFormat);
            if (CP.RIsActive == "Y") { ChkActive.Checked = true; }
           
        }
     
       

        
    }
}
