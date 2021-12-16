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
    public partial class FrmUserPermissions : Form
    {
        string StrAllow;
        public FrmUserPermissions()
        {
            InitializeComponent();
        }

        private void FrmUserPermissions_Load(object sender, EventArgs e)
        {
            //GlobalFunction.Fn_ChkForm(this, PnlData);
            //GlobalFunction.Fn_ChkForm(this, PnlSubMenu);
            //GlobalFunction.Fn_ChkForm(this, PnlSubPermissions);

            //GlobalFunction.Fn_NameLabel(PnlSubMenu, this);
            //GlobalFunction.Fn_NameLabel(PnlData, this);
            //GlobalFunction.Fn_NameLabel(PnlSubPermissions, this);
        }
        private void Fn_ShowControl()
        {
            ClassUserPermissions CLB = new ClassUserPermissions();
            GVControls.DataSource = CLB.DV_GetMainMenu(TxtID.Tag.ToString());
            int Wd = (GVControls.Width - 30) / 100;
            GVControls.Columns[0].Visible = false;
            GVControls.Columns[1].Width = Wd * 90;
            GVControls.Columns[2].Width = Wd * 10;

            int I = 0;
            string StrLang = "";
            for (I = 0; I < GVControls.Rows.Count - 1; I++)
            {
                StrLang = Fn_ChangeLangText(GVControls.Rows[I].Cells[0].Value.ToString().Trim());
                if (StrLang != "")
                {
                    GVControls.Rows[I].Cells[1].Value = StrLang;
                }
            }

            Wd = (GVControls.Width - 30) / 100;
            GVControls.Columns[0].Visible = false;
            GVControls.Columns[1].Width = Wd * 90;
            GVControls.Columns[2].Width = Wd * 10;
        }
        private string Fn_ChangeLangText(string StrItemName)
        {
           //ClassLang LL = new ClassLang();
            string StrRet = "";
           // StrRet = LL.Fn_GetContTextForForm("FrmWelcome", StrItemName);
            return StrRet;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GVControls_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Fn_ShowControlSubMenu()
        {
            GVLang.Visible = true;
            ClassUserPermissions CLB = new ClassUserPermissions();
            GVLang.DataSource = CLB.DV_GetSubMenu(LblMainMenuName.Text.Trim(), TxtID.Tag.ToString());
            int Wd = (GVLang.Width - 30) / 100;
            GVLang.Columns[0].Visible = false;
            GVLang.Columns[1].Width = Wd * 90;
            GVLang.Columns[2].Width = Wd * 10;
            int I = 0;
            string StrLang = "";
            for (I = 0; I < GVLang.Rows.Count - 1; I++)
            {
                StrLang = Fn_ChangeLangText(GVLang.Rows[I].Cells[0].Value.ToString().Trim());
                if (StrLang != "")
                {
                    GVLang.Rows[I].Cells[1].Value = StrLang;
                }

            }
            try
            {
                ChkSubAllowed.Checked = false;
                LblSubMenuName.Tag = GVLang.CurrentRow.Index.ToString();
                LblSubMenuName.Text = GVLang.CurrentRow.Cells[0].Value.ToString().Trim();
                LblSubMenuText.Text = GVLang.CurrentRow.Cells[1].Value.ToString().Trim();
                if (GVLang.CurrentRow.Cells[2].Value.ToString().Trim() == "Y") { ChkSubAllowed.Checked = true; }
                ClassUserPermissions CL = new ClassUserPermissions();
                CL.UserID = TxtID.Tag.ToString();
                CL.MenuID = LblSubMenuName.Text.Trim();
                CL.Fn_DataView();
                ChkSubView.Checked = false;
                ChkSubAddNew.Checked = false;
                ChkSubEdit.Checked = false;
                if (CL.IsView.Trim() == "Y") { ChkSubView.Checked = true; }
                if (CL.IsAddNew.Trim() == "Y") { ChkSubAddNew.Checked = true; }
                if (CL.IsEdit.Trim() == "Y") { ChkSubEdit.Checked = true; }
                TxtEditDays.Text = CL.EditDays.ToString();
            }
            catch
            { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Fn_PopupUser();
        }
        private void Fn_PopupUser()
        {
            FrmPopUp FrmP = new FrmPopUp();
            string SQL = "";
            SQL = "Select UserID as [000,SLNO], LastName + ' ' + MiddleName + ' ' + FirstName as [200,UserName], LoginID as [100,LoginID], " +
                " DeptShort as [100,DeptShort] , LocName as [100,LocName], LocType as [100,LocType] from QryUserMaster Where IsActive='Y' ";
            if (GlobalFunction.L_LoginID.Trim() != "1")
            {
                if (GlobalFunction.L_LocationType.Trim() == "Post")
                {
                    SQL = SQL + " And LocationID=" + GlobalFunction.L_LocationID + " ";
                }
                if (GlobalFunction.L_LocationType.Trim() == "Region Office")
                {
                    SQL = SQL + " And RegionID=" + GlobalFunction.L_Zone + " ";
                }
            }

            FrmP.HelpSQL = SQL;
            FrmP.HelpSearch = "[200,UserName]";
            FrmP.ShowDialog();
            TxtID.Tag = FrmP.HelpSLNO;
            TxtName.Text = FrmP.HelpText;
            TxtID.Text = FrmP.HelpResult[2];
            if (TxtID.Text.Trim() == "") { return; }
            Fn_ShowControl();
            GVControls.Visible = true;
            ChkMainMenu.Visible = true;
            LblMainMenuText.Visible = true;

            ChkMainMenu.Checked = false;
            LblMainMenuName.Tag = "0";
            LblMainMenuName.Text = GVControls.Rows[0].Cells[0].Value.ToString().Trim();
            LblMainMenuText.Text = GVControls.Rows[0].Cells[1].Value.ToString().Trim();
            if (GVControls.Rows[0].Cells[2].Value.ToString().Trim() == "Y") { ChkMainMenu.Checked = true; }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Fn_PopupUser();
        }

        private void ChkMainMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkMainMenu.Checked == true)
            { PnlSubMenu.Visible = true; Fn_ShowControlSubMenu(); }
            else
            { PnlSubMenu.Visible = false; }
        }

        private void ChkMainMenu_Click(object sender, EventArgs e)
        {
            string StrAllow = "N";
            string StrIsAddNew = "N";
            string StrIsView = "N";
            string StrIsEdit = "N";
            int IntEditDays = 0;
            int IntCurrentRow = Convert.ToInt16(LblMainMenuName.Tag);
            if (ChkMainMenu.Checked == true) { StrAllow = "Y"; }
            ClassUserPermissions UP = new ClassUserPermissions();
            UP.MenuType = 1;
            UP.UserID = TxtID.Tag.ToString().Trim();
            UP.MenuID = LblMainMenuName.Text.Trim();
            UP.IsAllow = StrAllow;
            UP.IsAddNew = StrIsAddNew;
            UP.IsView = StrIsView;
            UP.IsEdit = StrIsEdit;
            UP.EditDays = IntEditDays;
            string StrRet = "";
            UP.Fn_Save(ref StrRet);
            if (StrRet.Trim() == "") { GVControls.Rows[IntCurrentRow].Cells[2].Value = StrAllow; }





        }

        private void GVControls_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ChkSubAllowed_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSubAllowed.Checked == true)
            { PnlSubPermissions.Visible = true; }
            else
            { PnlSubPermissions.Visible = false; }
        }

        private void GVControls_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ChkMainMenu.Checked = false;
            LblMainMenuName.Tag = GVControls.CurrentRow.Index.ToString();
            LblMainMenuName.Text = GVControls.CurrentRow.Cells[0].Value.ToString().Trim();
            LblMainMenuText.Text = GVControls.CurrentRow.Cells[1].Value.ToString().Trim();
            if (GVControls.CurrentRow.Cells[2].Value.ToString().Trim() == "Y") { ChkMainMenu.Checked = true; }

        }

        private void GVLang_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ChkSubAllowed_Click(object sender, EventArgs e)
        {
            Fn_SaveSubMenu();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save?", GlobalFunction.A_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Fn_SaveSubMenu();
        }
        private void Fn_SaveSubMenu()
        {
            string StrAllow = "N";
            string StrIsAddNew = "N";
            string StrIsView = "N";
            string StrIsEdit = "N";
            int IntEditDays = 0;
            int IntCurrentRow = Convert.ToInt16(LblSubMenuName.Tag);
            if (ChkSubAllowed.Checked == true) { StrAllow = "Y"; }
            if (ChkSubAddNew.Checked == true) { StrIsAddNew = "Y"; }
            if (ChkSubView.Checked == true) { StrIsView = "Y"; }
            if (ChkSubEdit.Checked == true) { StrIsEdit = "Y"; }
            if (TxtEditDays.Text.Trim() != "") { IntEditDays = Convert.ToInt16(TxtEditDays.Text); }

            ClassUserPermissions UP = new ClassUserPermissions();
            UP.MenuType = 2;
            UP.UserID = TxtID.Tag.ToString().Trim();
            UP.MenuID = LblSubMenuName.Text.Trim();
            UP.IsAllow = StrAllow;
            UP.IsAddNew = StrIsAddNew;
            UP.IsView = StrIsView;
            UP.IsEdit = StrIsEdit;
            UP.EditDays = IntEditDays;
            string StrRet = "";
            UP.Fn_Save(ref StrRet);
            if (StrRet.Trim() == "") { GVLang.Rows[IntCurrentRow].Cells[2].Value = StrAllow; }
        }
        private void GVLang_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            ChkSubAllowed.Checked = false;
            LblSubMenuName.Tag = GVLang.CurrentRow.Index.ToString();
            LblSubMenuName.Text = GVLang.CurrentRow.Cells[0].Value.ToString().Trim();
            LblSubMenuText.Text = GVLang.CurrentRow.Cells[1].Value.ToString().Trim();
            if (GVLang.CurrentRow.Cells[2].Value.ToString().Trim() == "Y") { ChkSubAllowed.Checked = true; }
            ClassUserPermissions CL = new ClassUserPermissions();
            CL.UserID = TxtID.Tag.ToString();
            CL.MenuID = LblSubMenuName.Text.Trim();
            CL.Fn_DataView();
            ChkSubView.Checked = false;
            ChkSubAddNew.Checked = false;
            ChkSubEdit.Checked = false;
            if (CL.IsView.Trim() == "Y") { ChkSubView.Checked = true; }
            if (CL.IsAddNew.Trim() == "Y") { ChkSubAddNew.Checked = true; }
            if (CL.IsEdit.Trim() == "Y") { ChkSubEdit.Checked = true; }
            TxtEditDays.Text = CL.EditDays.ToString();

        }

        private void ChkSubView_Click(object sender, EventArgs e)
        {
            Fn_SaveSubMenu();
        }

        private void ChkSubAddNew_Click(object sender, EventArgs e)
        {
            Fn_SaveSubMenu();
        }

        private void ChkSubEdit_Click(object sender, EventArgs e)
        {
            Fn_SaveSubMenu();
        }

        private void TxtEditDays_Click(object sender, EventArgs e)
        {

        }

        private void TxtEditDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEditDays_KeyPress(object sender, KeyPressEventArgs e)
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
