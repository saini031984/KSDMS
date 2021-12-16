using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.SharpZipLib;
using PdfSharp.Drawing;
 

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
            loadscandevices();
            Fn_btnFileDeletestatus();
            if (StrUpload == "N") { BtnUpload.Visible = false; btnscan.Visible = false; }
            Fn_DeleteFiles();
          
            
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
          //this.docBrowser1.LoadDocument(this.openFileDialog1.FileName);
          //File.Open(StrExt, 0);
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
           // docBrowser1.LoadDocument("");
      
            Fn_DeleteFiles();
        }
      

        private void CmdClear_Click(object sender, EventArgs e)
        {
            Fn_Clear();
        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            //Fn_ShowFile();
            //System.Diagnostics.Process.Start(StrExt);
            //Application.DoEvents();
         
        }





        private void Fn_ShowFile()
        {

            if (TxtID.Text.Trim() == "")
            {
                MessageBox.Show("Select File ", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ClassDMS DMS = new ClassDMS();
            string StrExt = "";
            DMS.databaseFileRead(TxtID.Text.Trim(), ref StrExt);
            this.webBrowser1.Navigate(StrExt);
           // this.docBrowser1.LoadDocument(StrExt);
        }
        private void CmdExit_Click(object sender, EventArgs e)
        {
           // docBrowser1.LoadDocument("");
            Fn_DeleteFiles();
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
            Fn_DeleteFiles();
            Fn_ShowFile();
           
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
            Fn_DeleteFiles();
            Fn_ShowFile();
            
        }


        void loadscandevices()
        {
            List<string> devices = WIAScanner.GetDevices();

            foreach (string device in devices)
            {
                lbDevices.Items.Add(device);
            }

            if (lbDevices.Items.Count == 0)
            {
                //MessageBox.Show("You do not have any WIA devices.");
                //  btnscan.Enabled = false;
            }
            else
            {
                if (lbDevices.Items.Count > 1)
                {
                    lbDevices.Visible = true;
                }
                lbDevices.SelectedIndex = 0;
                btnscan.Enabled = true;
            }
            //GVPending.CurrentCell = GVPending.Rows[0].Cells[1];
        }

        private void pbar(string activity)
        {
            try
            {
                if (activity == "start")
                {
                    Cursor.Current = Cursors.WaitCursor;
                    pbar1.Visible = true;
                    pbar1.Style = ProgressBarStyle.Marquee;
                    Application.DoEvents();
                }
                else
                {
                    pbar1.Visible = false;
                    Cursor.Current = Cursors.No;
                    pbar1.Style = ProgressBarStyle.Blocks;
                    pbar1.Value = 0;
                    Application.DoEvents();
                }

            }
            catch (Exception ex) { }
        }
        private void btnscan_Click(object sender, EventArgs e)
        {
            ScaneDocs(); 

        }
        private void Fn_DeleteFiles()
        {
            string path = Application.StartupPath;
            string myDirPath = path + "\\DMS\\";

            //string myDirPath = @"C:\DMS\";

            System.IO.DirectoryInfo myDirInfo = new DirectoryInfo(myDirPath);

            foreach (FileInfo file in myDirInfo.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch(Exception E)
                {
                    // MessageBox.Show(E.ToString(), GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
            }
        }

        private void FrmDMS_FormClosed(object sender, FormClosedEventArgs e)
        {
       
        }

        private void FrmDMS_FormClosing(object sender, FormClosingEventArgs e)
        {
           // docBrowser1.LoadDocument("");
            Fn_DeleteFiles();
        }

        private void ScaneDocs()
        {
            ClassDMS DMS = new ClassDMS();
            DMS.Fn_ScaneFilesDelete();
            string A_FN = "";
            int PNO = 0;
            Fn_DeleteFiles();
            string docpath = "";
            string varPathToNewLocation = "";
            pbar("start");
            try
            {
                List<Image> images = WIAScanner.Scan((string)lbDevices.SelectedItem);
                foreach (Image image in images)
                {
 
                    string path = Application.StartupPath;
                    string myDirPath = path + "\\DMS\\";

                    this.TxtFilePath.Text = myDirPath + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".pdf";
                    DMS.Fn_ScaneFilesAddNew(this.TxtFilePath.Text);
                    // add a new document and a new page
                    PdfDocument doc = new PdfDocument();
                    PdfPage page = doc.AddPage();

                    // draw image on the page
                 
                        XGraphics gfx = XGraphics.FromPdfPage(page);
                        XImage ximage = XImage.FromGdiPlusImage(image);
                        gfx.DrawImage(ximage, 0, 0);
                 
                 
                    PNO = PNO + 1;
                    // save PDF to file
                    varPathToNewLocation = TxtFilePath.Text.Trim();
                    doc.Save(varPathToNewLocation);
                    doc.Close();

                }
                Fn_FillScaneGrid();
                 
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                this.Txtdocfilename.Text = "";
            }
            pbar("end");
            varPathToNewLocation = TxtFilePath.Text.Trim();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScaneDocs();
        }
        private void Fn_FillScaneGrid()
        {
            string CompNm = System.Environment.MachineName.ToString();
            string SQL = "Select SLNO,FIleNm,FilePath from ScaneFiles Where CompName='" + CompNm + "' Order By SLNO";
            ClassCommenDataLayer RecDir = new ClassCommenDataLayer();
            GvNewFiles.DataSource = RecDir.DL_DataViewSQLNew(SQL);
            GvNewFiles.Columns[0].Visible = false;
            GvNewFiles.Columns[1].Width = 220;
            GvNewFiles.Columns[2].Width = 150;


                    string docpath = "";
                    string varPathToNewLocation = "";
                    int PNO = 0;

                    string path = Application.StartupPath;
                    string myDirPath = path + "\\DMS\\";
                    this.TxtFilePath.Text = myDirPath +"Final_" + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".pdf";
                    
                    // add a new document and a new page
                    PdfDocument doc = new PdfDocument();
                    PdfPage page = doc.AddPage();

                    // draw image on the page
                    for (PNO = 0;PNO<GvNewFiles.Rows.Count;PNO++)
                    {
                        if (PNO == 0)
                        {
                            
                            XGraphics gfx = XGraphics.FromPdfPage(page);
                            XImage ximage = XImage.FromFile(GvNewFiles.Rows[PNO].Cells[2].Value.ToString().Trim());
                            
                            gfx.DrawImage(ximage, 0, 0);
                        }
                        else
                        {
                            PdfPage page2 = doc.InsertPage(PNO);
                            XGraphics gfx2 = XGraphics.FromPdfPage(page2);
                            XImage ximage2 = XImage.FromFile(GvNewFiles.Rows[PNO].Cells[2].Value.ToString().Trim());
                            gfx2.DrawImage(ximage2, 0, 0);
                        
                        }



                        

                    }
                    // save PDF to file
                    varPathToNewLocation = TxtFilePath.Text.Trim();
            
                    doc.Save(varPathToNewLocation);
                    doc.Close();
 

        }

        private void GVPending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GvNewFiles_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string SS = GvNewFiles.CurrentRow.Cells[2].Value.ToString().Trim();
            //docBrowser1.LoadDocument(SS);
            this.webBrowser1.Navigate(SS);
            //docBrowser1.Refresh();
        }
        private void Fn_AddPageToNewPDF()
        {
        
        }

        private void BtnDeleteFILE_Click(object sender, EventArgs e)
        {
             
                if (MessageBox.Show("Save?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    ClassDMS DMS = new ClassDMS();
                    DMS.databasevisaFileDelete(StrVisaID, TxtID.Text);
                    Fn_Clear();
                    Fn_FillGrid();
                }
             
        }

        private void Fn_btnFileDeletestatus()
        {
          
            ClassDMS DMS = new ClassDMS();
            string Strstatus = "0";

            DMS.Fn_checkstatus(StrVisaID, ref Strstatus);
            if (Strstatus == "3") { BtnDeleteFILE.Visible = false; }
            else { BtnDeleteFILE.Visible = true; }

             
            
        }


        
    
    }
}
