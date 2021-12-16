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
    class ClassLocation
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
        private string _LShort;
        public string LShort
        {
            get
            {
                return _LShort;
            }
            set
            {
                _LShort = value;
            }
        }
        private string _LName;
        public string LName
        {
            get
            {
                return _LName;
            }
            set
            {
                _LName = value;
            }
        }
        private string _LType;
        public string LType
        {
            get
            {
                return _LType;
            }
            set
            {
                _LType = value;
            }
        }
        private string _RegionID;
        public string RegionID
        {
            get
            {
                return _RegionID;
            }
            set
            {
                _RegionID = value;
            }
        }
        private string _LAdd;
        public string LAdd
        {
            get
            {
                return _LAdd;
            }
            set
            {
                _LAdd = value;
            }
        }
        private string _LArea;
        public string LArea
        {
            get
            {
                return _LArea;
            }
            set
            {
                _LArea = value;
            }
        }
        private string _LZip;
        public string LZip
        {
            get
            {
                return _LZip;
            }
            set
            {
                _LZip = value;
            }
        }
        private string _LPhone;
        public string LPhone
        {
            get
            {
                return _LPhone;
            }
            set
            {
                _LPhone = value;
            }
        }
        private int _LocationLevel;
        public int LocationLevel
        {
            get
            {
                return _LocationLevel;
            }
            set
            {
                _LocationLevel = value;
            }
        }
        public string Fn_GetLocShort(string StrID)
        {
            string StrRet = "";
            SQL = "Select LocShort from LocationMAster Where LocationID=@LocationID";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@LocationID", StrID.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                StrRet = dtC.Rows[0]["LocShort"].ToString(); ;
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();

            return StrRet;

        }
        public void Fn_Val(ref String StrMsg)
        {
            StrMsg = "";
            if (_LName == "") { StrMsg = "Location Name can not be Blank"; }
            if (_LShort == "") { StrMsg = "Code can not be Blank"; }

            if (_Action == 1)
            {
                if (_LShort.Trim().Length < 3)
                {
                    StrMsg = "Location Short must be of three car.";
                }
                SQL = "Select LocShort from LocationMAster Where LocShort=@LShort";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@LShort", _LShort.Trim().Replace("'", ""));
                DataAdapter.SelectCommand = Com;
                DataAdapter.Fill(dtC);
                if (dtC.Rows.Count > 0)
                {
                    StrMsg = "Location Short In Database";
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
            SQL = "Select * from LocationMAster Where LocationID=@LocID";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@LocID", _SLNO.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                _LShort = dtC.Rows[0]["LocShort"].ToString();
                _LName = dtC.Rows[0]["LocName"].ToString();
                _LType = dtC.Rows[0]["LocType"].ToString();
                _LAdd = dtC.Rows[0]["LocAddress"].ToString();
                _LArea = dtC.Rows[0]["LocArea"].ToString();
                _LZip = dtC.Rows[0]["LocZip"].ToString();
                _LPhone = dtC.Rows[0]["LocPhone"].ToString();
                _RegionID = dtC.Rows[0]["RegionID"].ToString();
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


                SQL = "INSERT INTO LocationMaster(LocShort,RegionID,LocType,LocName,LocAddress,LocArea,LocZip,LocPhone,IsActive,UpdateBy,LastDate) " +
                    " Values (@LocShort,@RegionID,@LocType,@LocName,@LocAddress,@LocArea,@LocZip,@LocPhone,@IsActive,@UpdateBy,@LastDate)";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@LocShort", _LShort.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LocName", _LName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LocType", _LType.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@RegionID", _RegionID.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@LocAddress", _LAdd.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LocArea", _LArea.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LocZip", _LZip.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LocPhone", _LPhone.Trim().Replace("'", ""));

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
                SQL = "Update LocationMaster SET LocName=@LocName,LocType=@LocType,RegionID=@RegionID,LocAddress=@LocAddress,LocArea=@LocArea,LocZip=@LocZip,LocPhone=@LocPhone," +
                    " IsActive=@IsActive,UpdateBy=@UpdateBy,LastDate=@LastDate " +
                    " Where LocationID=@LocationID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@LocationID", _SLNO.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LocName", _LName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LocType", _LType.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@RegionID", _RegionID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LocAddress", _LAdd.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LocArea", _LArea.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LocZip", _LZip.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LocPhone", _LPhone.Trim().Replace("'", ""));

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
                SQL = "DELETE FROM LocationMaster Where LocationID=@LocationID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@LocationID", _SLNO.Trim().Replace("'", ""));

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }
        }

        public DataView DV_RetLocList()
        {
            SQL = "Select 0 as LocationID, ' Select' as LocName Union Select LocationID, LocName from LocationMaster Where IsActive='Y'";
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
            SQL = SQL + " Order By LocName";
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
        public DataView DV_RetLocListOnlyZone()
        {
            SQL = "Select 0 as LocationID, ' Select' as LocName Union Select LocationID, LocName from LocationMaster Where IsActive='Y'  ";
            if (GlobalFunction.L_LoginID.Trim() != "1")
            {
                if (GlobalFunction.L_LocationType.Trim() == "Post")
                {
                    SQL = SQL + " And LocationID=" + GlobalFunction.L_LocationID + " ";
                }
                SQL = SQL + " And RegionID=" + GlobalFunction.L_Zone + " ";

            }
            SQL = SQL + " Order By LocName";
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
