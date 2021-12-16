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
    class ClassUserPermissions
    {
        string ConStr = GlobalFunction.ConStr;
        string SQL;
        SqlConnection Conn = new SqlConnection();
        SqlCommand Com = new SqlCommand();
        SqlDataAdapter DataAdapter = new SqlDataAdapter();
        DataTable dtC = new DataTable();
        DataSet Ds = new DataSet();
        DataTable Dt = new DataTable("DTabel");
        private int _Action;
        public int Action
        {
            get
            {
                return _Action;
            }
            set
            {
                _Action = value;
            }
        }
        private string _UpdBy;
        public string UpdBy
        {
            get
            {
                return _UpdBy;
            }
            set
            {
                _UpdBy = value;
            }
        }
        private DateTime _LastDt;
        public DateTime LastDt
        {
            get
            {
                return _LastDt;
            }
            set
            {
                _LastDt = value;
            }
        }
        private int _MenuType;
        public int MenuType
        {
            get
            {
                return _MenuType;
            }
            set
            {
                _MenuType = value;
            }
        }
        private string _UserID;
        public string UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                _UserID = value;
            }
        }
        private string _MenuID;
        public string MenuID
        {
            get
            {
                return _MenuID;
            }
            set
            {
                _MenuID = value;
            }
        }
        private string _IsAllow;
        public string IsAllow
        {
            get
            {
                return _IsAllow;
            }
            set
            {
                _IsAllow = value;
            }
        }
        private string _IsAddNew;
        public string IsAddNew
        {
            get
            {
                return _IsAddNew;
            }
            set
            {
                _IsAddNew = value;
            }
        }
        private string _IsView;
        public string IsView
        {
            get
            {
                return _IsView;
            }
            set
            {
                _IsView = value;
            }
        }
        private string _IsEdit;
        public string IsEdit
        {
            get
            {
                return _IsEdit;
            }
            set
            {
                _IsEdit = value;
            }
        }
        private int _EditDays;
        public int EditDays
        {
            get
            {
                return _EditDays;
            }
            set
            {
                _EditDays = value;
            }
        }
        public void Fn_Val(ref String StrMsg)
        {
            StrMsg = "";
            if (_UserID == "") { StrMsg = "User can not be Blank"; }
            if (_MenuID == "") { StrMsg = "Select Menu to Update"; }

        }
        public void Fn_Save(ref String StrMsg)
        {
            string RetMsg = "";
            Fn_Val(ref RetMsg);
            if (RetMsg != "")
            { StrMsg = RetMsg; return; }
            _Action = 1;
            SQL = "Select UserID from MnuPermissions Where UserID=@UserID And MenuID=@MenuID";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@UserID", _UserID.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@MenuID", _MenuID.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                _Action = 2;
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            if (_Action == 1)
            {
                SQL = "Insert Into MnuPermissions (MenuType,UserID,MenuID,IsAllow,IsAddNew,IsView,IsEdit,EditDays,UpdateBy,LastDate)" +
                    " Values (@MenuType,@UserID,@MenuID,@IsAllow,@IsAddNew,@IsView,@IsEdit,@EditDays,@UpdateBy,@LastDate)";
            }
            else
            {
                SQL = "Update MnuPermissions Set MenuType=@MenuType,IsAllow=@IsAllow,IsAddNew=@IsAddNew,IsView=@IsView,IsEdit=@IsEdit,EditDays=@EditDays,UpdateBy=@UpdateBy,LastDate=@LastDate" +
                        " Where UserID=@UserID And MenuID=@MenuID";
            }
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@MenuType", _MenuType);
            Com.Parameters.AddWithValue("@UserID", _UserID.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@MenuID", _MenuID.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@IsAllow", _IsAllow.Trim().Replace("'", ""));

            Com.Parameters.AddWithValue("@IsAddNew", _IsAddNew.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@IsView", _IsView.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@IsEdit", _IsEdit.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@EditDays", _EditDays);

            Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
            Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());

            Com.CommandText = SQL;
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
            Conn.Close();
        }
        public void Fn_DataView()
        {
            _IsAllow = "N";
            _IsAddNew = "N";
            _IsView = "N";

            _IsEdit = "N";
            _EditDays = 0;

            Conn.ConnectionString = ConStr;
            SQL = "Select * from MnuPermissions Where UserID=@UserID And MenuID=@MenuID";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@UserID", _UserID.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@MenuID", _MenuID.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                _IsAllow = dtC.Rows[0]["IsAllow"].ToString();
                _IsAddNew = dtC.Rows[0]["IsAddNew"].ToString();
                _IsView = dtC.Rows[0]["IsView"].ToString();

                _IsEdit = dtC.Rows[0]["IsEdit"].ToString();
                _EditDays = Convert.ToInt16(dtC.Rows[0]["EditDays"].ToString());
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();
        }
        public DataView DV_GetMainMenu(string StrUserID)
        {
            SQL = "Select LG.ContName,   LG.ContText, IsNull((Select IsAllow from MnuPermissions Where MenuID=LG.ContName and UserID=@UserID),'N') as IsAllow " +
                  " from LangAssets as LG  Where LG.FormName='FrmWelcome' and LG.ContType=4 Order By LG.ContID";
            DataView DVMG = new DataView();
            DataSet dsMG = new DataSet();
            Conn.ConnectionString = ConStr;
            if (Conn.State == ConnectionState.Closed) { Conn.Open(); }
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@UserID", StrUserID.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dsMG);
            DVMG.Table = dsMG.Tables[0];
            Com.Dispose();
            DataAdapter.Dispose();
            Conn.Close();
            return DVMG;
        }
        public DataView DV_GetSubMenu(string StrUnder, string StrUserID)
        {
            SQL = "Select LG.ContName,   LG.ContText, IsNull((Select IsAllow from MnuPermissions Where MenuID=LG.ContName and UserID=@UserID),'N') as IsAllow " +
              " from LangAssets as LG  Where LG.FormName='FrmWelcome' and MainMenuNm=@MainMenuNm Order By LG.ContID";

            DataView DVMG = new DataView();
            DataSet dsMG = new DataSet();
            Conn.ConnectionString = ConStr;
            if (Conn.State == ConnectionState.Closed) { Conn.Open(); }
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@UserID", StrUserID.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@MainMenuNm", StrUnder.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dsMG);
            DVMG.Table = dsMG.Tables[0];
            Com.Dispose();
            DataAdapter.Dispose();
            Conn.Close();
            return DVMG;
        }
        private void Fn_SavePermissions()
        {


        }
        public void Fn_chkMenuPermit()
        {

            _IsAllow = "N";
            //Conn.ConnectionString = ConStr;
            //SQL = "Select IsAllow from MnuPermissions Where UserID=@UserID And MenuID=@MenuID";
            //Conn.ConnectionString = ConStr;
            //Conn.Open();
            //Com.Connection = Conn;
            //Com.CommandText = SQL;
            //Com.Parameters.Clear();
            //Com.Parameters.AddWithValue("@UserID", GlobalFunction.L_LoginID);
            //Com.Parameters.AddWithValue("@MenuID", _MenuID.Trim().Replace("'", ""));
            //DataAdapter.SelectCommand = Com;
            //DataAdapter.Fill(dtC);
            //if (dtC.Rows.Count > 0)
            //{
            //    _IsAllow = dtC.Rows[0]["IsAllow"].ToString(); 
            //}
            //Com.Dispose();
            //DataAdapter.Dispose();
            //Com.Parameters.Clear();
            //dtC.Clear();
            //Conn.Close(); 

            string StrRet = "";



            DataRow[] result = GlobalFunction.GL_DTMEnuPermit.Select("MenuID ='" + _MenuID.Trim().Replace("'", "") + "'");

            foreach (DataRow row in result)
            {
                _IsAllow = row["IsAllow"].ToString();
            }



        }
    }
}
