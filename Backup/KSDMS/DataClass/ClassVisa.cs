 
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

    class ClassVisa
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

        private string _StrSrNo;
        public string StrSrNo
        {
            get
            {
                return _StrSrNo;
            }
            set
            {
                _StrSrNo = value;
            }
        }
        private double _SrNo;
        public double SrNo
        {
            get
            {
                return _SrNo;
            }
            set
            {
                _SrNo = value;
            }
        }
        private DateTime _RegDt;
        public DateTime RegDt
        {
            get
            {
                return _RegDt;
            }
            set
            {
                _RegDt = value;
            }
        }
        private DateTime _AppDt;
        public DateTime AppDt
        {
            get
            {
                return _AppDt;
            }
            set
            {
                _AppDt = value;
            }
        }
        private DateTime _PIssDt;
        public DateTime PIssDt
        {
            get
            {
                return _PIssDt;
            }
            set
            {
                _PIssDt = value;
            }
        }
        private DateTime _PExpDt;
        public DateTime PExpDt
        {
            get
            {
                return _PExpDt;
            }
            set
            {
                _PExpDt = value;
            }
        }
        private DateTime _DOB;
        public DateTime DOB
        {
            get
            {
                return _DOB;
            }
            set
            {
                _DOB = value;
            }
        }
        //VisaDT

        private DateTime _VisaDT;
        public DateTime VisaDT
        {
            get
            {
                return _VisaDT;
            }
            set
            {
                _VisaDT = value;
            }
        }

        private string _VisaType;
        public string VisaType
        {
            get
            {
                return _VisaType;
            }
            set
            {
                _VisaType = value;
            }
        }
        private string _NoOfEnt;
        public string NoOfEnt
        {
            get
            {
                return _NoOfEnt;
            }
            set
            {
                _NoOfEnt = value;
            }
        }
        private string _AppNoStr;
        public string AppNoStr
        {
            get
            {
                return _AppNoStr;
            }
            set
            {
                _AppNoStr = value;
            }
        }
        private string _PasportNo;
        public string PasportNo
        {
            get
            {
                return _PasportNo;
            }
            set
            {
                _PasportNo = value;
            }
        }
        private string _PIssLocation;
        public string PIssLocation
        {
            get
            {
                return _PIssLocation;
            }
            set
            {
                _PIssLocation = value;
            }
        }
        private int _PIssCountry;
        public int PIssCountry
        {
            get
            {
                return _PIssCountry;
            }
            set
            {
                _PIssCountry = value;
            }
        }
        private string _PerNm;
        public string PerNm
        {
            get
            {
                return _PerNm;
            }
            set
            {
                _PerNm = value;
            }
        }
        private string _FirstNm;
        public string FirstNm
        {
            get
            {
                return _FirstNm;
            }
            set
            {
                _FirstNm = value;
            }
        }
        private string _MidNm;
        public string MidNm
        {
            get
            {
                return _MidNm;
            }
            set
            {
                _MidNm = value;
            }
        }
        private string _LastNm;
        public string LastNm
        {
            get
            {
                return _LastNm;
            }
            set
            {
                _LastNm = value;
            }
        }
        private string _Gender;
        public string Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
            }
        }
        private string _MarStatus;
        public string MarStatus
        {
            get
            {
                return _MarStatus;
            }
            set
            {
                _MarStatus = value;
            }
        }
        //AppNation
        private string _AppNation;
        public string AppNation
        {
            get
            {
                return _AppNation;
            }
            set
            {
                _AppNation = value;
            }
        }
        private string _PlaceOfBirth;
        public string PlaceOfBirth
        {
            get
            {
                return _PlaceOfBirth;
            }
            set
            {
                _PlaceOfBirth = value;
            }
        }
        private string _ResAdd1;
        public string ResAdd1
        {
            get
            {
                return _ResAdd1;
            }
            set
            {
                _ResAdd1 = value;
            }
        }
        private string _ResAdd2;
        public string ResAdd2
        {
            get
            {
                return _ResAdd2;
            }
            set
            {
                _ResAdd2 = value;
            }
        }
        private string _ResAdd3;
        public string ResAdd3
        {
            get
            {
                return _ResAdd3;
            }
            set
            {
                _ResAdd3 = value;
            }
        }
        private string _ContactNo;
        public string ContactNo
        {
            get
            {
                return _ContactNo;
            }
            set
            {
                _ContactNo = value;
            }
        }
       

        public void Fn_Val(ref String StrMsg)
        {
            StrMsg = "";
            //if (_CName == "") { StrMsg = "Name can not be Blank"; }
            //if (_CShort == "") { StrMsg = "Short can not be Blank"; }
           
        }
        public void Fn_DataView()
        {
            SQL = "Select * from VisaApp Where VisaID=@VisaID";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@VisaID", _SLNO.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                _StrSrNo = dtC.Rows[0]["RegNoStr"].ToString();
                _RegDt = Convert.ToDateTime(dtC.Rows[0]["RegDt"].ToString());
                _AppDt = Convert.ToDateTime(dtC.Rows[0]["AppDt"].ToString());
                _PIssDt = Convert.ToDateTime(dtC.Rows[0]["PIssDt"].ToString());
                _PExpDt = Convert.ToDateTime(dtC.Rows[0]["PExpDt"].ToString());
                _DOB = Convert.ToDateTime(dtC.Rows[0]["DOB"].ToString());
                _VisaType = dtC.Rows[0]["VisaType"].ToString();
                _NoOfEnt = dtC.Rows[0]["NoOfEnt"].ToString();
                _AppNoStr = dtC.Rows[0]["AppNoStr"].ToString();
                _PasportNo = dtC.Rows[0]["PasportNo"].ToString();
                _PIssLocation = dtC.Rows[0]["PIssLocation"].ToString();
                _PIssCountry =Convert.ToInt16(dtC.Rows[0]["PIssCountry"].ToString());
                _PerNm = dtC.Rows[0]["PerNm"].ToString();
                _FirstNm = dtC.Rows[0]["FirstNm"].ToString();
                _MidNm = dtC.Rows[0]["MidNm"].ToString();
                _LastNm = dtC.Rows[0]["LastNm"].ToString();
                _Gender = dtC.Rows[0]["Gender"].ToString();
                _MarStatus = dtC.Rows[0]["MarStatus"].ToString();
                _AppNation = dtC.Rows[0]["AppNation"].ToString();
                _PlaceOfBirth = dtC.Rows[0]["PlaceOfBirth"].ToString();
                _ResAdd1 = dtC.Rows[0]["ResAdd1"].ToString();
                _ResAdd2 = dtC.Rows[0]["ResAdd2"].ToString();
                _ResAdd3 = dtC.Rows[0]["ResAdd3"].ToString();
                _ContactNo = dtC.Rows[0]["ContactNo"].ToString();

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
        public void Fn_SendFrwd(string StrVisaID, int IntStatus)
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            if (IntStatus == 0)
            {
                SQL = "Update VisaApp SET  VisaStatus=VisaStatus+1, RecpBy=@RecpBy,RecpDt=@RecpDt " +
                       " Where VisaID=@VisaID";
            }
            if (IntStatus == 1)
            {
                SQL = "Update VisaApp SET  VisaStatus=VisaStatus+1, DocUpBy=@RecpBy,DocDt=@RecpDt " +
                       " Where VisaID=@VisaID";
            }
            if (IntStatus == 2)
            {
                SQL = "Update VisaApp SET  VisaStatus=VisaStatus+1, StatusUpBy=@RecpBy,StatusUpDT=@RecpDt " +
                       " Where VisaID=@VisaID";
            }
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@VisaID", StrVisaID.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@RecpBy", GlobalFunction.L_LoginID);
            Com.Parameters.AddWithValue("@RecpDt", GlobalFunction.Fn_GetCurrentDateTime());
            Com.CommandText = SQL;
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
            Conn.Close();
        }
        public void Fn_SendBack(string StrVisaID, int IntStatus)
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            if (IntStatus == 1)
            {
                SQL = "Update VisaApp SET  VisaStatus=VisaStatus+1, DocUpBy=0 " +
                       " Where VisaID=@VisaID";
            }
            if (IntStatus == 2)
            {
                SQL = "Update VisaApp SET  VisaStatus=VisaStatus+1, StatusUpBy=0 " +
                       " Where VisaID=@VisaID";
            }
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@VisaID", StrVisaID.Trim().Replace("'", ""));
            Com.CommandText = SQL;
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
            Conn.Close();
        }
        public void Fn_VisaStatusUpdate(string V_VisaID, string V_VisaNo, string V_VisaDays,DateTime V_VDt, string V_VisaStatus)
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            SQL = "Update VisaApp SET  " +
                        " VisaPosition=@VisaPosition,StatusUpBy=@UpdateBy,StatusUpDT=@LastDate," +
                        " VisaNo=@VisaNo,VisaDT=@VisaDT,VisaForTime=@VisaForTime," +
                        " UpdateBy=@UpdateBy,LastDate=@LastDate " +
                        " Where VisaID=@VisaID";
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@VisaID", V_VisaID.Trim().Replace("'", ""));


            Com.Parameters.AddWithValue("@VisaPosition", V_VisaStatus.Trim().Replace("'", ""));

            Com.Parameters.AddWithValue("@VisaNo", V_VisaNo.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@VisaDT", V_VDt);
            Com.Parameters.AddWithValue("@VisaForTime", V_VisaDays);
             
            Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
            Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());

            Com.CommandText = SQL;
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
            Conn.Close();
        }
        public void Fn_Save(ref String StrMsg)
        {
            string RetMsg = "";
            Fn_Val(ref RetMsg);
            if (RetMsg != "")
            { StrMsg = RetMsg; return; }
            if (_Action == 1) { Fn_GetNo(); }

            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            if (_Action == 1)
            {


                SQL = "INSERT INTO VisaApp(LoactionID,RegNoInt,RegNoStr,FinYear," +
                    " RegDt,VisaType,NoOfEnt,AppNoStr,AppDt," +
                    " PasportNo,PIssDt,PExpDt,PIssLocation,PIssCountry," +
                    " PerNm,FirstNm,MidNm,LastNm,Gender,MarStatus,DOB,AppNation," +
                    " PlaceOfBirth,ResAdd1,ResAdd2,ResAdd3,ContactNo,VisaStatus," +
                    " IsActive,UpdateBy,LastDate) " +
                    " Values (@LoactionID,@RegNoInt,@RegNoStr,@FinYear," +
                    " @RegDt,@VisaType,@NoOfEnt,@AppNoStr,@AppDt," +
                    " @PasportNo,@PIssDt,@PExpDt,@PIssLocation,@PIssCountry," +
                    " @PerNm,@FirstNm,@MidNm,@LastNm,@Gender,@MarStatus,@DOB,@AppNation," +
                    " @PlaceOfBirth,@ResAdd1,@ResAdd2,@ResAdd3,@ContactNo,@VisaStatus," +
                    " @IsActive,@UpdateBy,@LastDate) ";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@LoactionID", GlobalFunction.L_LocationID);
                Com.Parameters.AddWithValue("@RegNoInt", _SrNo); 
                Com.Parameters.AddWithValue("@RegNoStr", _StrSrNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@RegDt", _RegDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@FinYear", GlobalFunction.Fn_GetFinYear().ToString());
                Com.Parameters.AddWithValue("@VisaType", _VisaType.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NoOfEnt", _NoOfEnt.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@AppNoStr", _AppNoStr.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@AppDt", _AppDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@PasportNo", _PasportNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PIssDt", _PIssDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@PExpDt", _PExpDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@PIssLocation", _PIssLocation.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PIssCountry", _PIssCountry);
                Com.Parameters.AddWithValue("@PerNm", _PerNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@FirstNm", _FirstNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@MidNm", _MidNm.Trim().Replace("'", ""));               
                Com.Parameters.AddWithValue("@LastNm", _LastNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@Gender", _Gender.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@MarStatus", _MarStatus.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@DOB", _DOB.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@PlaceOfBirth", _PlaceOfBirth.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@AppNation", _AppNation.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ResAdd1", _ResAdd1.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ResAdd2", _ResAdd2.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ResAdd3", _ResAdd3.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContactNo", _ContactNo.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@VisaStatus", "0" );

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
                SQL = "Update VisaApp SET  " +
                    " VisaType=@VisaType,NoOfEnt=@NoOfEnt,AppNoStr=@AppNoStr,AppDt=@AppDt," +
                    " PasportNo=@PasportNo,PIssDt=@PIssDt,PExpDt=@PExpDt,PIssLocation=@PIssLocation,PIssCountry=@PIssCountry," +
                    " PerNm=@PerNm,FirstNm=@FirstNm,MidNm=@MidNm,LastNm=@LastNm,Gender=@Gender,MarStatus=@MarStatus,DOB=@DOB,AppNation=@AppNation," +
                    " PlaceOfBirth=@PlaceOfBirth,ResAdd1=@ResAdd1,ResAdd2=@ResAdd2,ResAdd3=@ResAdd3,ContactNo=@ContactNo," +
                    " IsActive=@IsActive,UpdateBy=@UpdateBy,LastDate=@LastDate " +
                    " Where VisaID=@VisaID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VisaID", _SLNO.Trim().Replace("'", ""));


                Com.Parameters.AddWithValue("@AppNoStr", _AppNoStr.Trim().Replace("'", "")); 

                Com.Parameters.AddWithValue("@VisaType", _VisaType.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NoOfEnt", _NoOfEnt.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@RAppNoStr", _AppNoStr.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@AppDt", _AppDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@PasportNo", _PasportNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PIssDt", _PIssDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@PExpDt", _PExpDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@PIssLocation", _PIssLocation.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PIssCountry", _PIssCountry);
                Com.Parameters.AddWithValue("@PerNm", _PerNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@FirstNm", _FirstNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@MidNm", _MidNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LastNm", _LastNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@Gender", _Gender.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@MarStatus", _MarStatus.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@DOB", _DOB.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@PlaceOfBirth", _PlaceOfBirth.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@AppNation", _AppNation.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ResAdd1", _ResAdd1.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ResAdd2", _ResAdd2.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ResAdd3", _ResAdd3.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContactNo", _ContactNo.Trim().Replace("'", ""));

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
                SQL = "DELETE FROM VissApp Where VisaID=@VisaID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VisaID", _SLNO.Trim().Replace("'", ""));

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }
            Conn.Close();
        }

        public DataView DV_RetDptList()
        {
            SQL = "Select 0 as VisaID, ' Select' as VisaTNm Union Select VisaID, VisaTNm from VisaApp Where IsActive='Y' order By VisaTNm";
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
            SQL = "Select VisaID, VisaTNm from VisaApp Where IsActive='Y' order By VisaTNm";
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
        public void Fn_SaveDoc(string D_SLNO, string D_VisaID, string D_SrNo, string D_DocName, string D_IsActive)
        {
            Conn.ConnectionString = ConStr;
            if (Conn.State == ConnectionState.Closed) { Conn.Open(); }
            if (D_SLNO == "")
            {
                SQL = "INSERT INTO VisaDoc(VisaID,SrNo,DocName,IsActive,UpdateBy,LastDate) " +
                    " Values (@VisaID,@SrNo,@DocName,@IsActive,@UpdateBy,@LastDate)";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@SrNo", D_SrNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@VisaID", D_VisaID.Trim().Replace("'", ""));
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
                       " Where SLNO=@VisaID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VisaID", D_SLNO.Trim().Replace("'", ""));
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
            SQL = "Select SLNO, SrNo,DocName,IsActive from VisaDOC Where VisaID=@VisaID order By SrNo";
            DataView DVMG = new DataView();
            DataSet dsMG = new DataSet();
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@VisaID", MSLNO.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dsMG);
            DVMG.Table = dsMG.Tables[0];
            Com.Dispose();
            DataAdapter.Dispose();
            Conn.Close();
            return DVMG;
        }

        public void Fn_GetNo()
        {

            string LocShort = GlobalFunction.L_LocationShort;
            string MaxCont = "0";
            string StrFrom = "P";
            string FinYear = GlobalFunction.Fn_GetFinYear().ToString();

            SQL = "Select IsNull((Max(RegNoInt)),0)+1 as MCT from VisaApp Where LoactionID=@LocationID and FinYear=@FinYear";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@LocationID", GlobalFunction.L_LocationID.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@FinYear", FinYear);
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                MaxCont = dtC.Rows[0]["MCT"].ToString();
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();

            _SrNo = Convert.ToInt64(MaxCont);
            if (MaxCont.Trim().Length == 1) { _StrSrNo = LocShort + FinYear + StrFrom + "000000" + MaxCont.Trim(); }
            if (MaxCont.Trim().Length == 2) { _StrSrNo = LocShort + FinYear + StrFrom + "00000" + MaxCont.Trim(); }
            if (MaxCont.Trim().Length == 3) { _StrSrNo = LocShort + FinYear + StrFrom + "0000" + MaxCont.Trim(); }
            if (MaxCont.Trim().Length == 4) { _StrSrNo = LocShort + FinYear + StrFrom + "000" + MaxCont.Trim(); }
            if (MaxCont.Trim().Length == 5) { _StrSrNo = LocShort + FinYear + StrFrom + "00" + MaxCont.Trim(); }
            if (MaxCont.Trim().Length == 6) { _StrSrNo = LocShort + FinYear + StrFrom + "0" + MaxCont.Trim(); }
            if (MaxCont.Trim().Length == 7) { _StrSrNo = LocShort + FinYear + StrFrom + "" + MaxCont.Trim(); }
        }
    }
}
