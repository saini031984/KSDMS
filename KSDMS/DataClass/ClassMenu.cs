using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;

namespace KSDMS.DataClass
{
    class ClassMenu
    {
        string ConStr = GlobalFunction.ConStr;
        string SQL;
        SqlConnection Conn = new SqlConnection();
        SqlCommand Com = new SqlCommand();
        SqlDataAdapter DataAdapter = new SqlDataAdapter();
        DataTable dtC = new DataTable();
        DataSet Ds = new DataSet();
        DataTable Dt = new DataTable("DTabel");

        private string _SLNO;
        public string SLNO
        {
            get
            {
                return _SLNO;
            }
            set
            {
                _SLNO = value;
            }
        }

        public void Fn_MenuItems(MenuStrip menuStrip, string FormID, string StrFormName)
        {
            string StrItemName = "";
            string StrItemText = "";
            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                StrItemName = item.Name.ToString();
                StrItemText = item.Text.ToString();
                Fn_InsertControlsInDB(StrFormName, 4, StrItemName, StrItemText);
                processMenuItems(item, StrFormName);
            }
        }
        private void processMenuItems(ToolStripMenuItem item, string StrFormName)
        {
            string StrSubItemName = "";
            string StrSubItemText = "";

            foreach (ToolStripItem subitem in item.DropDownItems)
            {
                if (subitem is ToolStripMenuItem)
                {
                    StrSubItemName = subitem.Name.ToString();
                    StrSubItemText = subitem.Text.ToString();
                    Fn_InsertControlsMenuInDB(StrFormName, 5, StrSubItemName, StrSubItemText, item.Name);
                    processMenuItems((ToolStripMenuItem)subitem, StrFormName);

                }
            }
        }

        public void Fn_CheckControlsInMnu(MenuStrip PN, string FormID, string StrFormName)
        {
            string MnuName = "";
            string MnuText = "";
            Fn_InsertControlsInDB(StrFormName, 0, StrFormName, "Welcome");
            PN.Items.OfType<ToolStripItem>().ToList().ForEach(item =>
            {

                MnuName = item.Name.ToString();
                MnuText = item.Text.ToString();
                Fn_InsertControlsInDB(StrFormName, 4, MnuName, MnuText);

            });
        }
        private void Fn_InsertControlsMenuInDB(string FormName, int ContType, string ContName, string ContText, string PName)
        {
            Conn.ConnectionString = ConStr;
            Conn.Open();

            string BContSLNO = "0";

            SQL = "Select ContID from LangAssets Where FormName=@FormName and ContType=@ContType and ContName=@ContName";
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@FormName", FormName.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@ContType", ContType);
            Com.Parameters.AddWithValue("@ContName", ContName.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                BContSLNO = dtC.Rows[0]["ContID"].ToString().Trim();
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();

            if (BContSLNO == "0")
            {


                SQL = "INSERT INTO LangAssets(ContType,FormName,ContName,ContText,MainMenuNm,UpdateBy,LastDate) " +
                        " Values (@ContType,@FormName,@ContName,@ContText,@MainMenuNm,@UpdateBy,@LastDate)";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@ContType", ContType);
                Com.Parameters.AddWithValue("@FormName", FormName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContName", ContName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@MainMenuNm", PName.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@ContText", ContText.Trim().Replace("'", "").Replace("&", ""));
                Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
                Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();

                SQL = "Select ContID from LangAssets Where FormName=@FormName and ContType=@ContType and ContName=@ContName";
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@FormName", FormName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContType", ContType);
                Com.Parameters.AddWithValue("@ContName", ContName.Trim().Replace("'", ""));
                DataAdapter.SelectCommand = Com;
                DataAdapter.Fill(dtC);
                if (dtC.Rows.Count > 0)
                {
                    _SLNO = dtC.Rows[0]["ContID"].ToString().Trim();
                }
                Com.Dispose();
                DataAdapter.Dispose();
                Com.Parameters.Clear();
                dtC.Clear();
            }
            else
            {
                _SLNO = BContSLNO;
                SQL = "Update LangAssets SET ContText=@ContText,UpdateBy=@UpdateBy,LastDate=@LastDate " +
                    " Where ContID=@ContID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@ContID", BContSLNO.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@ContText", ContText.Trim().Replace("'", "").Replace("&", ""));

                Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
                Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }

            Conn.Close();

        }
        private void Fn_InsertControlsInDB(string FormName, int ContType, string ContName, string ContText)
        {
            Conn.ConnectionString = ConStr;
            Conn.Open();

            string BContSLNO = "0";

            SQL = "Select ContID from LangAssets Where FormName=@FormName and ContType=@ContType and ContName=@ContName";
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@FormName", FormName.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@ContType", ContType);
            Com.Parameters.AddWithValue("@ContName", ContName.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                BContSLNO = dtC.Rows[0]["ContID"].ToString().Trim();
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();

            if (BContSLNO == "0")
            {


                SQL = "INSERT INTO LangAssets(ContType,FormName,ContName,ContText,UpdateBy,LastDate) " +
                        " Values (@ContType,@FormName,@ContName,@ContText,@UpdateBy,@LastDate)";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@ContType", ContType);
                Com.Parameters.AddWithValue("@FormName", FormName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContName", ContName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContText", ContText.Trim().Replace("'", "").Replace("&", ""));
                Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
                Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());
                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();

                SQL = "Select ContID from LangAssets Where FormName=@FormName and ContType=@ContType and ContName=@ContName";
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@FormName", FormName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContType", ContType);
                Com.Parameters.AddWithValue("@ContName", ContName.Trim().Replace("'", ""));
                DataAdapter.SelectCommand = Com;
                DataAdapter.Fill(dtC);
                if (dtC.Rows.Count > 0)
                {
                    _SLNO = dtC.Rows[0]["ContID"].ToString().Trim();
                }
                Com.Dispose();
                DataAdapter.Dispose();
                Com.Parameters.Clear();
                dtC.Clear();
            }
            else
            {
                _SLNO = BContSLNO;
                SQL = "Update LangAssets SET ContText=@ContText,UpdateBy=@UpdateBy,LastDate=@LastDate " +
                    " Where ContID=@ContID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@ContID", BContSLNO.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContText", ContText.Trim().Replace("'", "").Replace("&", ""));
                Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
                Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());
                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }

            Conn.Close();

        }
       
    }
}
