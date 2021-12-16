using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KSDMS.DataClass;

namespace KSDMS
{
    public partial class FrmPopUp : Form
    {
        public string HelpSQL;
        public string HelpSearch;
        public string HelpText;
        public string HelpSLNO;
        //Array  AA =new Array();
        public string[] HelpResult = new string[20];

        string SQL;
        SqlConnection Conn = new SqlConnection();
        SqlCommand Com = new SqlCommand();
        SqlDataAdapter DataAdapter = new SqlDataAdapter();
        DataTable dtC = new DataTable();
        DataSet Ds = new DataSet();
        DataTable Dt = new DataTable("DTabel");

        DataView DVMG = new DataView();
        DataSet dsMG = new DataSet();

        RadioButton RdSelect;
        int RDTop;
        int RdLeft;
        public FrmPopUp()
        {
            InitializeComponent();
        }

        private void FrmPopUp_Load(object sender, EventArgs e)
        {
            
            Conn.ConnectionString = GlobalFunction.ConStr;
            //Conn.Open();
            HelpText = "";
            HelpSLNO = "";
            Fn_FillGrid(HelpSQL);
            fn_SetWidth();
            fn_AddFilterBtn();
            TxtSearch.Focus();
        }
        private void Fn_FillGrid(string DTSQL)
        {
            GV.DataSource = DL_DataView();

        }
        private DataView DL_DataView()
        {

            DataSet dsMG = new DataSet();
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = HelpSQL;
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dsMG);
            DVMG.Table = dsMG.Tables[0];
            Com.Dispose();
            DataAdapter.Dispose();
            Conn.Close();
            return DVMG;

        }
        private void fn_SetWidth()
        {
            double colWidth = 0;
            double TotWd = 0;
            string ColNm = "";
            string ColNmN = "";
            int I;
            for (I = 0; I < GV.ColumnCount; I++)
            {
                ColNm = GV.Columns[I].Name.Trim();
                GV.Columns[I].Tag = "[" + GV.Columns[I].Name.Trim() + "]";
                ColNmN = ColNm.Substring(4, ColNm.Length - 4);
                GV.Columns[I].HeaderText = ColNmN;
                colWidth = Convert.ToDouble(ColNm.Substring(0, 3));
                if (colWidth == 0)
                { GV.Columns[I].Visible = false; }
                else
                {
                    GV.Columns[I].Width = Convert.ToInt16(colWidth);
                    TotWd = TotWd + colWidth;
                }

            }

            if (TotWd < 700)
            {
                this.Width = Convert.ToInt16(TotWd + 100);
                PnlBtn.Width = Convert.ToInt16(TotWd + 70);
                TxtSearch.Width = Convert.ToInt16(TotWd + 70);
                GV.Width = Convert.ToInt16(TotWd + 70);
            }

        }
        private void fn_AddFilterBtn()
        {
            int I = 0;
            RDTop = 0;
            RdLeft = 5;
            for (I = 1; I < GV.ColumnCount; I++)
            {
                if (GV.Columns[I].Visible == true)
                {
                    fn_AddnewBtn(GV.Columns[I].HeaderText.Trim(), GV.Columns[I].Tag.ToString().Trim());
                }

            }

        }

        private void fn_AddnewBtn(string btnNm, string BtnTag)
        {
            RdSelect = new RadioButton();
            RdSelect.Text = btnNm;
            RdSelect.Tag = BtnTag;
            RdSelect.Top = RDTop;
            RdSelect.Left = RdLeft;
            RdSelect.Width = 80;
            RdLeft = RdLeft + 80;
            if (BtnTag == HelpSearch) { RdSelect.Checked = true; }
            PnlBtn.Controls.Add(RdSelect);
            this.RdSelect.Click += new System.EventHandler(this.BtnMain_Click);

            PnlBtn.Controls.Add(RdSelect);

        }
        private void BtnMain_Click(object sender, System.EventArgs e)
        {
            RadioButton BtnSender = (RadioButton)sender;
            String OrdSLNO = BtnSender.Tag.ToString();
            HelpSearch = OrdSLNO;
            TxtSearch.Text = "";
            TxtSearch.Focus();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DVMG.RowFilter = "" + HelpSearch + " Like '%" + TxtSearch.Text.Trim() + "%'";
            GV.DataSource = DVMG;
            GV.Refresh();
        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            int K = e.KeyChar;
            int J = 0;
            if (K == 13)
            {
                HelpSLNO = GV.Rows[0].Cells[0].Value.ToString();
                HelpText = GV.Rows[0].Cells[1].Value.ToString();
                for (J = 1; J < GV.ColumnCount; J++)
                {
                    HelpResult[J] = GV.Rows[0].Cells[J].Value.ToString();
                }
                this.Close();
            }
        }

        private void GV_KeyPress(object sender, KeyPressEventArgs e)
        {
            int K = e.KeyChar;
            int J = 0;
            int F = 0;
            int RN = GV.CurrentRow.Index;
            if (RN == (GV.Rows.Count - 1))
            { F = RN; }
            else if (RN > 0) { F = RN - 1; }
            if (K == 13)
            {
                HelpSLNO = GV.Rows[F].Cells[0].Value.ToString();
                HelpText = GV.Rows[F].Cells[1].Value.ToString();
                for (J = 1; J < GV.ColumnCount; J++)
                {
                    HelpResult[J] = GV.CurrentRow.Cells[J].Value.ToString();
                }
                this.Close();
            }
        }


        private void GV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void GV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int J = 0;

            HelpSLNO = GV.CurrentRow.Cells[0].Value.ToString();
            HelpText = GV.CurrentRow.Cells[1].Value.ToString();
            for (J = 1; J < GV.ColumnCount; J++)
            {
                HelpResult[J] = GV.CurrentRow.Cells[J].Value.ToString();
            }
            this.Close();
        }

        private void FrmPopUp_Scroll(object sender, ScrollEventArgs e)
        {
            TxtSearch.Focus();
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            string STRK = e.KeyCode.ToString().Trim();
            if (STRK == "Down") { GV.Focus(); }
        }

    }
}
