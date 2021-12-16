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
    class ClassParamDetails
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

        private string _ParamID;
        public string ParamID
        {
            get
            {
                return _ParamID;
            }
            set
            {
                _ParamID = value;
            }
        }

        private string _PDetailCode;
        public string PDetailCode
        {
            get
            {
                return _PDetailCode;
            }
            set
            {
                _PDetailCode = value;
            }
        }
        private string _PDetailName;
        public string PDetailName
        {
            get
            {
                return _PDetailName;
            }
            set
            {
                _PDetailName = value;
            }
        }
        private double _PDefValue;
        public double PDefValue
        {
            get
            {
                return _PDefValue;
            }
            set
            {
                _PDefValue = value;
            }
        }
        public void Fn_Val(ref String StrMsg)
        {
            StrMsg = "";
            if (_PDetailName == "") { StrMsg = "Name can not be Blank"; }
            if (_PDetailCode == "") { StrMsg = "Code can not be Blank"; }
            if (_Action == 1)
            {
                SQL = "Select PDetailCode from ParamDetail Where PDetailCode=@PDetailCode And ParamID=@ParamID";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@PDetailCode", _PDetailCode.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ParamID", _ParamID.Trim().Replace("'", ""));
                DataAdapter.SelectCommand = Com;
                DataAdapter.Fill(dtC);
                if (dtC.Rows.Count > 0)
                {
                    StrMsg = "Code In Database";
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
            SQL = "Select * from ParamDetail Where PDetailID=@PDetailID";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@PDetailID", _SLNO.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                _PDetailCode = dtC.Rows[0]["PDetailCode"].ToString();
                _PDetailName = dtC.Rows[0]["PDetailName"].ToString();
                _PDefValue = Convert.ToDouble(dtC.Rows[0]["PDefValue"].ToString());
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


                SQL = "INSERT INTO ParamDetail(ParamID,PDetailCode,PDetailName,PDefValue,IsActive,UpdateBy,LastDate) " +
                    " Values (@ParamID,@PDetailCode,@PDetailName,@PDefValue,@IsActive,@UpdateBy,@LastDate)";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@ParamID", _ParamID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PDetailCode", _PDetailCode.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PDetailName", _PDetailName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PDefValue", _PDefValue);
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
                SQL = "Update ParamDetail SET PDetailName=@PDetailName,PDefValue=@PDefValue,IsActive=@IsActive,UpdateBy=@UpdateBy,LastDate=@LastDate " +
                    " Where PDetailID=@PDetailID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@PDetailID", _SLNO.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PDetailName", _PDetailName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PDefValue", _PDefValue);
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
                SQL = "DELETE FROM ParamDetail Where PDetailID=@PDetailID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@PDetailID", _SLNO.Trim().Replace("'", ""));

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }
        }

        public DataView DV_RetParamDetailList(string StrParamID)
        {
            SQL = "Select 0 as PDetailID, ' Select' as PDetailName Union Select PDetailID, PDetailName from ParamDetail Where IsActive='Y' And ParamID=@ParamID order By PDetailName";
            DataView DVMG = new DataView();
            DataSet dsMG = new DataSet();
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@ParamID", StrParamID.Trim().Replace("'", ""));
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
