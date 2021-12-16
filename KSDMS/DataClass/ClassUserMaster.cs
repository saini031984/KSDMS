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
    class ClassUserMaster
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
        //LMaxNo
        private string _LMaxNo;
        public string LMaxNo
        {
            get
            {
                return _LMaxNo;
            }
            set
            {
                _LMaxNo = value;
            }
        }
        private string _LoginID;
        public string LoginID
        {
            get
            {
                return _LoginID;
            }
            set
            {
                _LoginID = value;
            }
        }
        private string _LocationID;
        public string LocationID
        {
            get
            {
                return _LocationID;
            }
            set
            {
                _LocationID = value;
            }
        }
        private string _LastName;
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }
        private string _MiddleName;
        public string MiddleName
        {
            get
            {
                return _MiddleName;
            }
            set
            {
                _MiddleName = value;
            }
        }
        private string _FirstName;
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }
        private string _Password;
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }
        private string _NewPassword;
        public string NewPassword
        {
            get
            {
                return _NewPassword;
            }
            set
            {
                _NewPassword = value;
            }
        }

        private string _DouaneCode;
        public string DouaneCode
        {
            get
            {
                return _DouaneCode;
            }
            set
            {
                _DouaneCode = value;
            }
        }

        private string _eMail;
        public string eMail
        {
            get
            {
                return _eMail;
            }
            set
            {
                _eMail = value;
            }
        }
        private string _DeptID;
        public string DeptID
        {
            get
            {
                return _DeptID;
            }
            set
            {
                _DeptID = value;
            }
        }
        private string _UserRole;
        public string UserRole
        {
            get
            {
                return _UserRole;
            }
            set
            {
                _UserRole = value;
            }
        }
        private string _GroupID;
        public string GroupID
        {
            get
            {
                return _GroupID;
            }
            set
            {
                _GroupID = value;
            }
        }
        private string _LangKnow;
        public string LangKnow
        {
            get
            {
                return _LangKnow;
            }
            set
            {
                _LangKnow = value;
            }
        }
        public void Fn_Val(ref String StrMsg)
        {
            StrMsg = "";
            if (_LoginID == "") { StrMsg = "LoginID can not be Blank"; }
            if (_FirstName == "") { StrMsg = "First Name can not be Blank"; }
            if (_LocationID == "") { StrMsg = "Location can not be Blank"; }
            if (_DeptID == "") { StrMsg = "Department can not be Blank"; }
            if (_DouaneCode == "") { StrMsg = "Douane code can not be Blank"; }
            //


        }
        public void Fn_UserName()
        {
            SQL = "Select LastName, FirstName from UsersMaster Where UserID=@UserID";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@UserID", _SLNO.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                _LastName = dtC.Rows[0]["LastName"].ToString();
                _FirstName = dtC.Rows[0]["FirstName"].ToString();

            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();

        }
        public void Fn_DataView()
        {
            SQL = "Select * from UsersMaster Where UserID=@UserID";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@UserID", _SLNO.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                _LoginID = dtC.Rows[0]["LoginID"].ToString();
                _Password = dtC.Rows[0]["Password"].ToString();
                _LocationID = dtC.Rows[0]["LocationID"].ToString();
                _LastName = dtC.Rows[0]["LastName"].ToString();
                _FirstName = dtC.Rows[0]["FirstName"].ToString();
                _MiddleName = dtC.Rows[0]["MiddleName"].ToString();
                _eMail = dtC.Rows[0]["eMail"].ToString();
                _DeptID = dtC.Rows[0]["DeptID"].ToString();
                _UserRole = dtC.Rows[0]["UserRole"].ToString();
                _GroupID = dtC.Rows[0]["GroupID"].ToString();
                _LangKnow = dtC.Rows[0]["LangKnow"].ToString();
                _DouaneCode = dtC.Rows[0]["DouaneCode"].ToString();

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
        private void Fn_GetLoginID()
        {
            ClassLocation ClLoc = new ClassLocation();

            string LocShort = ClLoc.Fn_GetLocShort(_LocationID);
            string MaxCont = "0";

            SQL = "Select IsNull((Max(LMaxNo)),0)+1 as MCT from UsersMaster Where LocationID=@LocationID";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@LocationID", _LocationID.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                MaxCont = dtC.Rows[0]["MCT"].ToString();
                _LMaxNo = dtC.Rows[0]["MCT"].ToString();
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();

            if (MaxCont.Trim().Length == 1) { _LoginID = LocShort + "000000" + MaxCont.Trim(); }
            if (MaxCont.Trim().Length == 2) { _LoginID = LocShort + "00000" + MaxCont.Trim(); }
            if (MaxCont.Trim().Length == 3) { _LoginID = LocShort + "0000" + MaxCont.Trim(); }
            if (MaxCont.Trim().Length == 4) { _LoginID = LocShort + "000" + MaxCont.Trim(); }
            if (MaxCont.Trim().Length == 5) { _LoginID = LocShort + "00" + MaxCont.Trim(); }
            if (MaxCont.Trim().Length == 6) { _LoginID = LocShort + "0" + MaxCont.Trim(); }
            if (MaxCont.Trim().Length == 7) { _LoginID = LocShort + MaxCont.Trim(); }
        }
        public void Fn_Save(ref String StrMsg)
        {
            string RetMsg1 = "";
            if (_Action == 1)
            {
                Fn_GetLoginID();
            }
            Fn_Val(ref RetMsg1);
            if (RetMsg1 != "")
            { StrMsg = RetMsg1; return; }
            Conn.ConnectionString = ConStr;
            if (Conn.State == ConnectionState.Closed) { Conn.Open(); }
            if (_Action == 1)
            {
                SQL = "INSERT INTO UsersMaster(LMaxNo,LoginID,DouaneCode,LocationID,LastName,MiddleName,FirstName,Password,eMail,DeptID,UserRole,GroupID,IsActive,UpdateBy,LastDate,LangKnow) " +
                    " Values (@LMaxNo,@LoginID,@DouaneCode,@LocationID,@LastName,@MiddleName,@FirstName,@Password,@eMail,@DeptID,@UserRole,@GroupID,@IsActive,@UpdateBy,@LastDate,@LangKnow)";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@LoginID", _LoginID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LocationID", _LocationID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LastName", _LastName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@DouaneCode", _DouaneCode.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LMaxNo", _LMaxNo.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@MiddleName", _MiddleName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@FirstName", _FirstName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@Password", _Password.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@eMail", _eMail.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@DeptID", _DeptID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@UserRole", _UserRole.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@GroupID", _GroupID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LangKnow", LangKnow.Trim().Replace("'", ""));

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
                SQL = "Update UsersMaster SET LocationID=@LocationID,DouaneCode=@DouaneCode,LastName=@LastName,MiddleName=@MiddleName,FirstName=@FirstName,Password=@Password,eMail=@eMail," +
                    " DeptID=@DeptID,UserRole=@UserRole,GroupID=@GroupID, " +
                    " IsActive=@IsActive,UpdateBy=@UpdateBy,LastDate=@LastDate,LangKnow=@LangKnow " +
                    " Where UserID=@UserID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@UserID", _SLNO.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@LocationID", _LocationID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LastName", _LastName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LangKnow", _LangKnow.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@DouaneCode", _DouaneCode.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@MiddleName", _MiddleName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@FirstName", _FirstName.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@Password", _Password.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@eMail", _eMail.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@DeptID", _DeptID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@UserRole", _UserRole.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@GroupID", _GroupID.Trim().Replace("'", ""));

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
                SQL = "DELETE FROM UsersMaster Where UserID=@UserID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@UserID", _SLNO.Trim().Replace("'", ""));

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }
        }
        public void Fn_Login(string StrLoginID, string StrPW, ref string StrMsg)
        {
            StrMsg = "";
            string Db_Pw = "";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            string StrVer = Fn_GetVerInfo();
            if (StrVer == "N")
            {
                StrMsg = "The software version is obsolete. Please contact system Admin for new EXE";
                Conn.Close();
                return;
            }
            SQL = "Select UserID,Password,FirstName,MiddleName,LastName,LocationID,LocName,LocShort,LangKnow,RegionID,LocType,UserRole,CountName,CountID from QryUserMaster Where LoginID=@LoginID And IsActive='Y'";
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@LoginID", StrLoginID.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                Db_Pw = dtC.Rows[0]["Password"].ToString().Trim();
                if (Db_Pw == StrPW)
                {
                    GlobalFunction.L_LoginID = dtC.Rows[0]["UserID"].ToString().Trim();
                    GlobalFunction.L_LoginName = dtC.Rows[0]["FirstName"].ToString().Trim() + " " + dtC.Rows[0]["MiddleName"].ToString().Trim() + " " + dtC.Rows[0]["LastName"].ToString().Trim();
                    GlobalFunction.L_LocationID = dtC.Rows[0]["LocationID"].ToString().Trim();
                    GlobalFunction.L_LocationName = dtC.Rows[0]["LocName"].ToString().Trim();
                    GlobalFunction.L_LocationShort = dtC.Rows[0]["LocShort"].ToString().Trim();
                    GlobalFunction.L_LangKnow = dtC.Rows[0]["LangKnow"].ToString().Trim();
                    GlobalFunction.L_Zone = dtC.Rows[0]["RegionID"].ToString().Trim();
                    GlobalFunction.L_LocationType = dtC.Rows[0]["LocType"].ToString().Trim();
                    GlobalFunction.L_IsAdmin = dtC.Rows[0]["UserRole"].ToString().Trim();
                    GlobalFunction.L_LocationCountry = dtC.Rows[0]["CountID"].ToString().Trim();
                    GlobalFunction.L_LocationCountryNm = dtC.Rows[0]["CountName"].ToString().Trim();

                   
                }
                else
                {
                    StrMsg = "Password Not Match!";
                }
            }
            else
            {
                StrMsg = "User Not Match!";
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();


            Conn.Close();
 
        }
        public string Fn_GetVerInfo()
        {
            string strRet = "Y";
            int FV1 = 1;
            int MV1 = 1;
            int LV1 = 1;

            int FV = 0;
            int MV = 0;
            int LV = 0;

            SQL = "Select Top 1 * from SoftVer Where IsActive='Y' Order By SLNo DESC";
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                FV = Convert.ToInt16(dtC.Rows[0]["FV"].ToString().Trim());
                MV = Convert.ToInt16(dtC.Rows[0]["MV"].ToString().Trim());
                LV = Convert.ToInt16(dtC.Rows[0]["LV"].ToString().Trim());

            }
            else
            { strRet = "N"; }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            if (FV > FV1) { strRet = "N"; }
            if (MV > MV1) { strRet = "N"; }
            if (LV > LV1) { strRet = "N"; }
            GlobalFunction.L_SoftVer = FV.ToString() + ":" + MV.ToString() + ":" + LV.ToString();
            return strRet;
        }
        public void Fn_ChangePassword(string StrOldPw, string StrNewPW, ref string StrMsg)
        {
            StrMsg = "";
            SQL = "Select Password from UsersMaster Where UserID=@UserID ";
            string Db_Pw = "";
            Conn.ConnectionString = ConStr;
            Conn.Open();

            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@UserID", GlobalFunction.L_LoginID.Trim());
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                Db_Pw = dtC.Rows[0]["Password"].ToString().Trim();
                if (Db_Pw != StrOldPw)
                {
                    StrMsg = "Old Password Not Match!";
                }
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            if (StrMsg == "")
            {
                SQL = "Update UsersMaster Set Password=@Password Where UserID=@UserID ";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@UserID", GlobalFunction.L_LoginID.Trim());
                Com.Parameters.AddWithValue("@Password", StrNewPW.Trim().Replace("'", ""));
                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();

            }
            Conn.Close();

        }
    }
}
