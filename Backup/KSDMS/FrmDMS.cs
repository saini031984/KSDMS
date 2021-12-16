using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using KSDMS.DataClass; 
 
namespace KSDMS
{
    public partial class FrmDMS : Form
    {
        public string StrVisaID;
        public string StrAppNo;
        public string StrSrNo;
        public string StrUpload;
        public FrmDMS()
        {
            InitializeComponent();
        }

        private void FrmDMS_Load(object sender, EventArgs e)
        {
            TxtSrNo.Text = StrSrNo;
            TxtAppNo.Text = StrAppNo;
            Fn_Combo();
            Fn_FillGrid();
            if (StrUpload == "N") { BtnUpload.Visible = false; }
            
        }
        private void Fn_Combo()
        {

            string SQL = "Select 0 as SLNO, 'Add On Document' as DocName Union Select SLNO, DocName from VisaDoc Where VTypeID=(Select VisaType from VisaApp Where VisaID=" + StrVisaID + ")";
            ClassCommenDataLayer RecDir = new ClassCommenDataLayer();
            CmbFileType.DataSource = RecDir.DL_DataViewSQLNew(SQL);
            CmbFileType.DisplayMember = "DocName";
            CmbFileType.ValueMember = "SLNO";
        
        }
        private void Fn_FillGrid()
        {
            string SQL = "Select SLNO,FileName,FileType from Visafiles Where VisaID=" + StrVisaID + "";
            ClassCommenDataLayer RecDir = new ClassCommenDataLayer();
            GVPending.DataSource = RecDir.DL_DataViewSQLNew(SQL);
            GVPending.Columns[0].Visible = false;
            GVPending.Columns[1].Width = 250;
            GVPending.Columns[2].Width = 120; 
        
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            TxtFilePath.Text = openFileDialog1.FileName;
            
        }
      
        private void BtnUpload_Click(object sender, EventArgs e)
        {
            if (TxtFileName.Text.Trim() == "")
            {
                MessageBox.Show("Enter File Name", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TxtFilePath.Text.Trim() == "")
            {
                MessageBox.Show("Select File ", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TxtID.Text.Trim() == "")
            {
                if (MessageBox.Show("Save?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                if (MessageBox.Show("Update File?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            
            }
            ClassDMS DMS = new ClassDMS();
            DMS.databaseFileUpload(TxtFilePath.Text, StrVisaID, TxtFileName.Text, TxtID.Text);
            Fn_Clear();
            Fn_FillGrid();
        }
        private void Fn_Clear()
        {
            TxtFileName.Text = "";
            TxtFilePath.Text = "";
            TxtID.Text = "";
            CmdShow.Enabled = false;
        }
      

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Fn_Clear();
        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            if (TxtID.Text.Trim() == "")
            {
                MessageBox.Show("Select File ", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ClassDMS DMS = new ClassDMS();
            string StrExt = "";
            DMS.databaseFileRead(TxtID.Text.Trim(), ref StrExt);

            System.Diagnostics.Process.Start(StrExt);
            Application.DoEvents();
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GVPending_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtID.Text = GVPending.CurrentRow.Cells[0].Value.ToString();
            TxtFileName.Text = GVPending.CurrentRow.Cells[1].Value.ToString();
            CmdShow.Enabled = true;
            if (TxtFileName.Text.Trim() == "Add On Document")
            {
                TxtFileName.Enabled = true;
            }
            else
            {
                TxtFileName.Enabled = false;
            }
        }

        private void CmbFileType_Leave(object sender, EventArgs e)
        {
            if (CmbFileType.SelectedIndex == 0)
            {
                TxtFileName.Enabled = true;
                if (TxtFileName.Text.Trim() != "")
                {
                    TxtFileName.Text = CmbFileType.Text.Trim();
                }
            }
            else
            {
                TxtFileName.Enabled = false;
                TxtFileName.Text = CmbFileType.Text.Trim();
            }
        }

        private void TxtFileName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void GVPending_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtID.Text = GVPending.CurrentRow.Cells[0].Value.ToString();
            TxtFileName.Text = GVPending.CurrentRow.Cells[1].Value.ToString();
            CmdShow.Enabled = true;
            if (TxtFileName.Text.Trim() == "Add On Document")
            {
                TxtFileName.Enabled = true;
            }
            else
            {
                TxtFileName.Enabled = false;
            }
        }

      
      
    }
}
