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
    class ClassDepartmentMaster
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
        private string _DShort;
        public string DShort
        {
            get
            {
                return _DShort;
            }
            set
            {
                _DShort = value;
            }
        }
        private string _DName;
        public string DName
        {
            get
            {
                return _DName;
            }
            set
            {
                _DName = value;
            }
        }
        public void Fn_Val(ref String StrMsg)
        {
            StrMsg = "";
            if (_DName == "") { StrMsg = "Department Name can not be Blank"; }
            if (_DShort == "") { StrMsg = "Department Short can not be Blank"; }
            if (_Action == 1)
            {
                SQL = "Select DeptShort from DeptMAster Where DeptShort=@DeptShort";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@DeptShort", _DShort.Trim().Replace("'", ""));
                DataAdapter.SelectCommand = Com;
                DataAdapter.Fill(dtC);
                if (dtC.Rows.Count > 0)
                {
                    StrMsg = "Department Short In Database";
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
            SQL = "Select * from DeptMAster Where DeptID=@DeptID";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@DeptID", _SLNO.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                _DShort = dtC.Rows[0]["DeptShort"].ToString();
                _DName = dtC.Rows[0]["DeptName"].ToString();
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


                SQL = "INSERT INTO DEPTMASTER(DeptShort,DeptName,IsActive,UpdateBy,LastDate) " +
                    " Values (@DeptShort,@DeptName,@IsActive,@UpdateBy,@LastDate)";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@DeptShort", _DShort.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@DeptName", _DName.Trim().Replace("'", ""));
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
                SQL = "Update DEPTMASTER SET DeptName=@DeptName,IsActive=@IsActive,UpdateBy=@UpdateBy,LastDate=@LastDate " +
                    " Where DeptID=@DeptID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@DeptID", _SLNO.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@DeptName", _DName.Trim().Replace("'", ""));
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
                SQL = "DELETE FROM DEPTMASTER Where DeptID=@DeptID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@DeptID", _SLNO.Trim().Replace("'", ""));

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }
        }

        public DataView DV_RetDptList()
        {
            SQL = "Select 0 as DeptID, ' Select' as DeptName Union Select DeptID, DeptName from DeptMAster Where IsActive='Y' order By DeptName";
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
