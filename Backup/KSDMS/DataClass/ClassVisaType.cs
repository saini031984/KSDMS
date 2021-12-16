using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Diagnostics; 

namespace KSDMS.DataClass
{
     
    class ClassVisaType
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
        private string _IsActive;
        public string IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                _IsActive = value;
            }
        }
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
        private string _CShort;
        public string CShort
        {
            get
            {
                return _CShort;
            }
            set
            {
                _CShort = value;
            }
        }
        private string _CName;
        public string CName
        {
            get
            {
                return _CName;
            }
            set
            {
                _CName = value;
            }
        }
        public void Fn_Val(ref String StrMsg)
        {
            StrMsg = "";
            if (_CName == "") { StrMsg = "Name can not be Blank"; }
            if (_CShort == "") { StrMsg = "Short can not be Blank"; }
            if (_Action == 1)
            {
                SQL = "Select VisaTShort from VisaType Where VisaTShort=@VisaTShort";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VisaTShort", _CShort.Trim().Replace("'", ""));
                DataAdapter.SelectCommand = Com;
                DataAdapter.Fill(dtC);
                if (dtC.Rows.Count > 0)
                {
                    StrMsg = "Short In Database";
                }
                Com.Dispose();
                DataAdapter.Dispose();
                Com.Parameters.Clear();
                dtC.Clear();
                Conn.Close();
            }
        }
        public void Fn_DataView()
        {
            SQL = "Select * from VisaType Where VTypeID=@VTypeID";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@VTypeID", _SLNO.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                _CShort = dtC.Rows[0]["VisaTShort"].ToString();
                _CName = dtC.Rows[0]["VisaTNm"].ToString();
                _IsActive = dtC.Rows[0]["IsActive"].ToString();
                _UpdBy = dtC.Rows[0]["UpdateBy"].ToString();
                _LastDt = Convert.ToDateTime(dtC.Rows[0]["LastDate"].ToString());
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();

        }
        public void Fn_Save(ref String StrMsg)
        {
            string RetMsg = "";
            Fn_Val(ref RetMsg);
            if (RetMsg != "")
            { StrMsg = RetMsg; return; }
            Conn.ConnectionString = ConStr;
            if (Conn.State == ConnectionState.Closed) { Conn.Open(); }
            if (_Action == 1)
            {


                SQL = "INSERT INTO VisaType(VisaTShort,VisaTNm,IsActive,UpdateBy,LastDate) " +
                    " Values (@VisaTShort,@VisaTNm,@IsActive,@UpdateBy,@LastDate)";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VisaTShort", _CShort.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@VisaTNm", _CName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@IsActive", _IsActive.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
                Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }
            else if (_Action == 2)
            {
                SQL = "Update VisaType SET VisaTNm=@VisaTNm,IsActive=@IsActive,UpdateBy=@UpdateBy,LastDate=@LastDate " +
                    " Where VTypeID=@VTypeID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VTypeID", _SLNO.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@VisaTNm", _CName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@IsActive", _IsActive.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
                Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }
            else if (_Action == 3)
            {
                SQL = "DELETE FROM VisaType Where VTypeID=@VTypeID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VTypeID", _SLNO.Trim().Replace("'", ""));

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }
        }

        public DataView DV_RetDptList()
        {
            SQL = "Select 0 as VTypeID, ' Select' as VisaTNm Union Select VTypeID, VisaTNm from VisaType Where IsActive='Y' order By VisaTNm";
            DataView DVMG = new DataView();
            DataSet dsMG = new DataSet();
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dsMG);
            DVMG.Table = dsMG.Tables[0];
            Com.Dispose();
            DataAdapter.Dispose();
            Conn.Close();
            return DVMG;

        }

        public DataView DV_RetGridView()
        {
            SQL = "Select VTypeID, VisaTNm from VisaType Where IsActive='Y' order By VisaTNm";
            DataView DVMG = new DataView();
            DataSet dsMG = new DataSet();
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dsMG);
            DVMG.Table = dsMG.Tables[0];
            Com.Dispose();
            DataAdapter.Dispose();
            Conn.Close();
            return DVMG;

        }
        public void Fn_SaveDoc(string D_SLNO,string D_VTypeID,string D_SrNo,string D_DocName,string D_IsActive)
        {
            Conn.ConnectionString = ConStr;
            if (Conn.State == ConnectionState.Closed) { Conn.Open(); }
            if (D_SLNO == "")
            {
                SQL = "INSERT INTO VisaDoc(VTypeID,SrNo,DocName,IsActive,UpdateBy,LastDate) " +
                    " Values (@VTypeID,@SrNo,@DocName,@IsActive,@UpdateBy,@LastDate)";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@SrNo", D_SrNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@VTypeID", D_VTypeID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@DocName", D_DocName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@IsActive", D_IsActive.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
                Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }
            else
            {
                SQL = "Update VisaDoc SET SrNo=@SrNo,@DocName=@DocName,IsActive=@IsActive,UpdateBy=@UpdateBy,LastDate=@LastDate " +
                       " Where SLNO=@VTypeID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VTypeID", D_SLNO.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@SrNo", D_SrNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@DocName", D_DocName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@IsActive", D_IsActive.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
                Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            
            }
            Conn.Close();
        }
        public DataView DV_RetGridDocs(string MSLNO)
        {
            SQL = "Select SLNO, SrNo,DocName,IsActive from VisaDOC Where VTypeID=@VTypeID order By SrNo";
            DataView DVMG = new DataView();
            DataSet dsMG = new DataSet();
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@VTypeID", MSLNO.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dsMG);
            DVMG.Table = dsMG.Tables[0];
            Com.Dispose();
            DataAdapter.Dispose();
            Conn.Close();
            return DVMG;
        }
    }
}
