using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KSDMS.DataClass;
using System.Diagnostics;
 
namespace KSDMS
{
    public partial class FrmWelcome : Form
    {
        private int childFormNumber = 0; 
        ClassUserPermissions MP = new ClassUserPermissions();
        string FormNm = "";
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            ClassMenu LL = new ClassMenu();
            LL.Fn_MenuItems(menuStrip1, this.Name, this.Name);
            statusStrip.Items[0].Text = "Ver : " + GlobalFunction.L_SoftVer;
            statusStrip.Items[1].Text = "Welcome " + GlobalFunction.L_LoginName;
            statusStrip.Items[2].Text = "Location : " + GlobalFunction.L_LocationName;
            statusStrip.Items[3].Text = GlobalFunction.Fn_GetCurrentDateTime().ToString("dd-MMM-yyyy HH:mm:ss");

            timer1.Interval = 1000;
            timer1.Start();
            this.Text = FormNm;
            Fn_MenuPerMissions();
            if (GlobalFunction.L_LoginID.Trim() != "1")
            {
                MnuUserParamMaster.Visible = false;
                MnuPassport.Visible = false;

            }
            if ((GlobalFunction.L_IsAdmin.Trim() != "1") && (GlobalFunction.L_IsAdmin.Trim() != "2"))
            {
                MnuAdminUserMaster.Visible = false;
                MnuAdminPermissions.Visible = false;
            }
        }
        private void Fn_MenuPerMissions()
        {
            string StrContText = "";
           
             
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item.Tag.ToString().Trim() != "F")
                {
                    MP.MenuID = item.Name.Trim();
                    MP.Fn_chkMenuPermit();
                    if (MP.IsAllow.Trim() == "N")
                    { item.Visible = false; }
                    else
                    {
                        item.Visible = true;
                        StrContText = GlobalFunction.Fn_ConverName(this.Name, item.Name);
                        // StrContText = LL.Fn_GetContTextForForm(this.Name, item.Name);
                        //
                        if (StrContText.Trim() != "") { item.Text = StrContText; }
                        Fn_MenuPerMissionsSub(item);
                    }
                }

            }

        }
        private void Fn_MenuPerMissionsSub(ToolStripMenuItem item)
        {
            string StrContTextSub = "";
            foreach (ToolStripItem subitem in item.DropDownItems)
            {
                if (subitem is ToolStripMenuItem)
                {

                    MP.MenuID = subitem.Name.Trim();
                    MP.Fn_chkMenuPermit();
                    if (MP.IsAllow.Trim() == "N")
                    { subitem.Visible = false; }
                    else
                    {
                        subitem.Visible = true;
                        Fn_MenuPerMissionsSub((ToolStripMenuItem)subitem);
                        StrContTextSub = GlobalFunction.Fn_ConverName(this.Name, subitem.Name);
                        // StrContTextSub = LL.Fn_GetContTextForForm(this.Name, subitem.Name);
                        if (StrContTextSub.Trim() != "") { subitem.Text = StrContTextSub; }
                    }

                }
            }
        }
     
        private void processMenuItems(ToolStripMenuItem item)
        {
            string StrSubItemName = "";
            string StrSubItemText = "";
            string StrSubContText = "";

            foreach (ToolStripItem subitem in item.DropDownItems)
            {
                if (subitem is ToolStripMenuItem)
                {
                    StrSubItemName = subitem.Name.ToString();
                    StrSubItemText = subitem.Text.ToString();
                  //  StrSubContText = LL.Fn_GetContTextForForm(this.Name, StrSubItemName);
                    if (StrSubContText.Trim() != "") { subitem.Text = StrSubContText; }

                    processMenuItems((ToolStripMenuItem)subitem);

                }
            }
        }
        private void FrmWelcome_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }
        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MnuAdminUserMaster_Click(object sender, EventArgs e)
        {
            FrmUserMaster childForm = new FrmUserMaster();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "User Master ";
            childForm.Show();
        }

        private void MnuUserParamMaster_Click(object sender, EventArgs e)
        {
            FrmParamMaster childForm = new FrmParamMaster();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Param Master ";
            childForm.Show();
        }

        private void MnuMastersCountry_Click(object sender, EventArgs e)
        {
            FrmCountryMaster childForm = new FrmCountryMaster();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Country Master ";
            childForm.Show();
        }

        private void MnuMasterVisaType_Click(object sender, EventArgs e)
        {
            FrmVisaType childForm = new FrmVisaType();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Visa Type ";
            childForm.Show();
        }

        private void MnuMasterVisaDock_Click(object sender, EventArgs e)
        {
            FrmVisaDoc childForm = new FrmVisaDoc();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Visa Docs";
            childForm.Show();
        }

        private void FrmWelcome_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MnuVisaReception_Click(object sender, EventArgs e)
        {
            FrmVisa childForm = new FrmVisa();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.IntVisaStatus = 0;
            childForm.Text = "Visa Reception";
            childForm.Show();
        }
        private void MnuVisaAssessment_Click(object sender, EventArgs e)
        {
            FrmVisa childForm = new FrmVisa();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.IntVisaStatus = 1;
            childForm.Text = "Visa Assessment";
            childForm.Show();
        }

        private void MnuVisaStickerPrinting_Click(object sender, EventArgs e)
        {
            FrmVisa childForm = new FrmVisa();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.IntVisaStatus = 2;
            childForm.Text = "Sticker Printing";
            childForm.Show();
        }
        private void MnuVisaStatusUpdate_Click(object sender, EventArgs e)
        {
            FrmVisa childForm = new FrmVisa();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.IntVisaStatus = 3;
            childForm.Text = "Final Approval";
            childForm.Show();
        }
        private void MnuVisaFileUpload_Click(object sender, EventArgs e)
        {
            FrmVisa childForm = new FrmVisa();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.IntVisaStatus = 4;
            childForm.Text = "Visa File Upload";
            childForm.Show();
        }
        private void MnuMasterInitial_Click(object sender, EventArgs e)
        {
            FrmParamDetail childForm = new FrmParamDetail();
            childForm.MdiParent = this;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Param Detail";
            childForm.DblParamID = 2;
            childForm.Show();
        }

        private void MnuMaritalStatusMaster_Click(object sender, EventArgs e)
        {
            FrmParamDetail childForm = new FrmParamDetail();
            childForm.MdiParent = this;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Param Detail";
            childForm.DblParamID = 1;
            childForm.Show();
        }

   

        private void showFIlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFind childForm = new FrmFind();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage; 
            childForm.Text = "Visa Search";
            childForm.Show();
        }

    

        private void MnuVisaDirectEntry_Click(object sender, EventArgs e)
        {
            FrmVisaDirectEntry childForm = new FrmVisaDirectEntry();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.IntVisaStatus = 4;
            childForm.Text = "Visa Direct Entry";
            childForm.Show();
        }

 

        private void MnuDMSReport_Click(object sender, EventArgs e)
        {

            FrmReportShow childForm = new FrmReportShow();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Report Visa";
            childForm.RptTYpe = 1;
            childForm.Show();  
          
        }

        private void MnuOccupationMaster_Click(object sender, EventArgs e)
        {
            FrmParamDetail childForm = new FrmParamDetail();
            childForm.MdiParent = this;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Param Detail";
            childForm.DblParamID = 8;
            childForm.Show();
        }

        private void MnuAdminPermissions_Click(object sender, EventArgs e)
        {
            FrmUserPermissions childForm = new FrmUserPermissions();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "User Permissions";
            childForm.Show(); 
        }

        private void MnuPassportPassportDirectEntry_Click(object sender, EventArgs e)
        {
            FrmPassportDirectNew childForm = new FrmPassportDirectNew();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Passport Direct Entry";
            childForm.Show();
        }

        private void MnuOccupationMasterPassportRenewType_Click(object sender, EventArgs e)
        {
            FrmParamDetail childForm = new FrmParamDetail();
            childForm.MdiParent = this;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Param Detail";
            childForm.DblParamID = 9;
            childForm.Show();
        }

        private void MnuKinRelationType_Click(object sender, EventArgs e)
        {
            FrmParamDetail childForm = new FrmParamDetail();
            childForm.MdiParent = this;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Param Detail";
            childForm.DblParamID = 10;
            childForm.Show();
        }

        private void MnuLocationMaster_Click(object sender, EventArgs e)
        {
            FrmLocation childForm = new FrmLocation();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Location Master ";
            childForm.Show();
        }

        private void MnuContinentMaster_Click(object sender, EventArgs e)
        {
            FrmParamDetail childForm = new FrmParamDetail();
            childForm.MdiParent = this;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Param Detail";
            childForm.DblParamID = 11;
            childForm.Show();
        }

        private void MnuDMSPassportFIles_Click(object sender, EventArgs e)
        { 
            FrmRptPassport childForm = new FrmRptPassport();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Passport Search";
            childForm.Show();
        }

        private void MnuDMSPassportReports_Click(object sender, EventArgs e)
        {
            FrmReportShow childForm = new FrmReportShow();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Report Passport";
            childForm.RptTYpe = 2;
            childForm.Show();
        }

        private void MnuPassportReciption_Click(object sender, EventArgs e)
        {
            FRmPassportNew childForm = new FRmPassportNew();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.IntVisaStatus = 0;
            childForm.Text = "Passport Reception";
            childForm.Show();
        }
        private void MnuPassportAssessment_Click(object sender, EventArgs e)
        {
            FRmPassportNew childForm = new FRmPassportNew();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.IntVisaStatus = 1;
            childForm.Text = "Passport App. Assessment";
            childForm.Show();
        }
     

        private void MnuPassportIssueNewPassport_Click(object sender, EventArgs e)
        {
            FRmPassportNew childForm = new FRmPassportNew();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.IntVisaStatus = 2;
            childForm.Text = "Passport Production";
            childForm.Show();
        }
        private void MnuPassportUploadDocument_Click(object sender, EventArgs e)
        {
            FRmPassportNew childForm = new FRmPassportNew();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.IntVisaStatus = 3;
            childForm.Text = "Passport Upload Document";
            childForm.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTest childForm = new FrmTest();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage; 
            childForm.Text = "Passport Approval";
            childForm.Show();
        }

        private void MnuVisaDirectUpdate_Click(object sender, EventArgs e)
        {
            FrmVisaUpdate childForm = new FrmVisaUpdate();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.IntVisaStatus = 2;
            childForm.Text = "Visa Upadate";
            childForm.Show();
        }

        private void MnuPassportPassportUpdate_Click(object sender, EventArgs e)
        {
            FrmPassportUpdate1 childForm = new FrmPassportUpdate1();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.Text = "Passport Update";
            childForm.Show();
        } 


    }
}
