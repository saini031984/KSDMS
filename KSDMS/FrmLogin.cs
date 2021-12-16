using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using KSDMS.DataClass;

namespace KSDMS
{
    public partial class FrmLogin : Form
    {
        ClassUserMaster CLUM = new ClassUserMaster();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {


            GlobalFunction.Fn_GetCulture();

            GlobalFunction.L_DateFormat = "dd/MMM/yyyy";
            GlobalFunction.L_DateTimeFormat = "dd/MMM/yyyy HH:mm";
            string SS = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            string BB = CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern;
            string CC = CultureInfo.CurrentCulture.CompareInfo.Name;


            SS = SS + " " + BB + " " + CC;

            //TxtLoginID.Text = "Admin";
            //TxtPassword.Text = "BSK";

        }
        private void TxtCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Boolean Fn_Val()
        {
            Boolean BolRet = true;
            if (string.IsNullOrEmpty(this.TxtLoginID.Text.Trim()))
            {
                MessageBox.Show("Please, Enter Username", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLoginID.Select();
                BolRet = false;
            }

            if (string.IsNullOrEmpty(this.TxtPassword.Text.Trim()))
            {
                MessageBox.Show("Please, Enter Password", GlobalFunction.A_Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPassword.Select();
                BolRet = false;
            }
            return BolRet;
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            // GlobalFunction.ConStr = System.Configuration.ConfigurationSettings.AppSettings["connectionString"];
            //  GlobalFunction.ConStr = @"Data Source=BSKALA\SQLEXPRESS;Initial Catalog=DMS;Integrated Security=True";
            // GlobalFunction.ConStr = "server=192.168.1.6;database=DouanTestDB;uid=sa;pwd=ks2211"; 
            // GlobalFunction.ConStr = "server=kserpsolution.com,1533;database=KSDB;uid=KSAdmin;pwd=rohiTK2211#";
            // GlobalFunction.ConStr = "server=sql2501.shared-servers.com,1087;database=senegal;uid=KSAdmin;pwd=rohiTK2211#";
           //  GlobalFunction.ConStr = @"Server=DELL-PC\SQLEXPRESS;Database=DMS;Integrated Security=True";
            GlobalFunction.ConStr = @"server=NIGSERVER,1433;database=DMSNEW;uid=sa;pwd=ks@1234";
            // GlobalFunction.ConStr = @"server=DELL-PC\SQLEXPRESS;database=DMS;uid=sa;pwd=ksds@123";
            //GlobalFunction.ConStr = @"Server=SURENDRA-SAINI\SQLEXPRESS;Database=DMS;Integrated Security=True";
            //  GlobalFunction.ConStr = @"Server=admin\SQLEXPRESS;Database=DMS;Integrated Security=True";
            //  GlobalFunction.ConStr = @"server=DATABASESERVER\SQLEXPRESS;database=DMS;uid=sa;pwd=ksds@123";
            //   GlobalFunction.ConStr = @"server=admin\SQLEXPRESS;database=DMS;uid=sa;pwd=ks@123";
            GlobalFunction.A_Name = "KS EDMS";

            if (Fn_Val() == false)
            {
                return;
            }

            ClassUserMaster CLUM = new ClassUserMaster();
            string StrMsgRet = "";
            CLUM.Fn_Login(TxtLoginID.Text, TxtPassword.Text, ref StrMsgRet);

            if (StrMsgRet == "")
            {

                GlobalFunction.Fn_FillLangTab();
                FrmWelcome FrmNew = new FrmWelcome();
                FrmNew.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(StrMsgRet, GlobalFunction.A_Name, MessageBoxButtons.OK);
                return;
            }

        }

        private void PnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlLogin_Paint_1(object sender, PaintEventArgs e)
        {


        }
    }
}
