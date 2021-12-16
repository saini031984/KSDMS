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
            statusStrip.Items[0].Text = "Ver : " + GlobalFunction.L_SoftVer;
            statusStrip.Items[1].Text = "Welcome " + GlobalFunction.L_LoginName;
            statusStrip.Items[2].Text = "Location : " + GlobalFunction.L_LocationName;
            statusStrip.Items[3].Text = GlobalFunction.Fn_GetCurrentDateTime().ToString("dd-MMM-yyyy HH:mm:ss");

            timer1.Interval = 1000;
            timer1.Start();
            this.Text = FormNm;

           // Fn_MenuPerMissions();
        }
        private void Fn_MenuPerMissions()
        {
            string StrContText = "";
            if (GlobalFunction.L_LoginID.Trim() == "1") { return; }
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

        private void MnuVisaFileUpload_Click(object sender, EventArgs e)
        {
            FrmVisa childForm = new FrmVisa();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.IntVisaStatus = 1;
            childForm.Text = "Visa File Upload";
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

        private void MnuVisaStatusUpdate_Click(object sender, EventArgs e)
        {
            FrmVisa childForm = new FrmVisa();
            childForm.MdiParent = this;
            childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            childForm.BackgroundImage = this.BackgroundImage;
            childForm.IntVisaStatus = 2;
            childForm.Text = "Visa Status";
            childForm.Show();
        }
 

      





    }
}
