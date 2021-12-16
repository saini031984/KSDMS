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
    class ClassParamMaster
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

        private string _ParamName;
        public string ParamName
        {
            get
            {
                return _ParamName;
            }
            set
            {
                _ParamName = value;
            }
        }
        private string _IsDefValue;
        public string IsDefValue
        {
            get
            {
                return _IsDefValue;
            }
            set
            {
                _IsDefValue = value;
            }
        }
        private int _CodeLen;
        public int CodeLen
        {
            get
            {
                return _CodeLen;
            }
            set
            {
                _CodeLen = value;
            }
        }
        public void Fn_Val(ref String StrMsg)
        {
            StrMsg = "";
            if (_ParamName == "") { StrMsg = "Name can not be Blank"; }
            if (_CodeLen == 0) { StrMsg = "Enter Code Length"; }

        }
        public void Fn_DataView()
        {
            SQL = "Select * from ParamMaster Where ParamID=@ParamID";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@ParamID", _SLNO.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                _IsDefValue = dtC.Rows[0]["IsDefValue"].ToString();
                _ParamName = dtC.Rows[0]["ParamName"].ToString();
                _CodeLen = Convert.ToInt16(dtC.Rows[0]["CodeLen"].ToString());
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
            string RetMsg1 = "";
            Fn_Val(ref RetMsg1);
            if (RetMsg1 != "")
            { StrMsg = RetMsg1; return; }
            Conn.ConnectionString = ConStr;
            if (Conn.State == ConnectionState.Closed) { Conn.Open(); }
            if (_Action == 1)
            {


                SQL = "INSERT INTO ParamMaster(IsDefValue,ParamName,CodeLen,IsActive,UpdateBy,LastDate) " +
                    " Values (@IsDefValue,@ParamName,@CodeLen,@IsActive,@UpdateBy,@LastDate)";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@ParamName", _ParamName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@IsDefValue", _IsDefValue.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@CodeLen", _CodeLen);
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
                SQL = "Update ParamMaster SET ParamName=@ParamName,IsDefValue=@IsDefValue,CodeLen=@CodeLen," +
                    " IsActive=@IsActive,UpdateBy=@UpdateBy,LastDate=@LastDate " +
                    " Where ParamID=@ParamID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@ParamID", _SLNO.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ParamName", _ParamName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@IsDefValue", _IsDefValue.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@CodeLen", _CodeLen);
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
                SQL = "DELETE FROM ParamMaster Where ParamID=@ParamID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@ParamID", _SLNO.Trim().Replace("'", ""));

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }
        }

        public DataView DV_RetUnitList()
        {
            SQL = "Select 0 as ParamID, ' Select' as ParamName Union Select ParamID, ParamName from ParamMaster Where IsActive='Y' order By ParamName";
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


    }
}
