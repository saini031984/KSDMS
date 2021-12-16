 
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

    class ClassPassport
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
        private double _EnrolmentNo;
        public double EnrolmentNo
        {
            get
            {
                return _EnrolmentNo;
            }
            set
            {
                _EnrolmentNo = value;
            }
        }
        private string _AppID;
        public string AppID
        {
            get
            {
                return _AppID;
            }
            set
            {
                _AppID = value;
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

        private double _ReqType;
        public double ReqType
        {
            get
            {
                return _ReqType;
            }
            set
            {
                _ReqType = value;
            }
        }
        private string _RefNo;
        public string RefNo
        {
            get
            {
                return _RefNo;
            }
            set
            {
                _RefNo = value;
            }
        }
        private DateTime _RefDate;
        public DateTime RefDate
        {
            get
            {
                return _RefDate;
            }
            set
            {
                _RefDate = value;
            }
        }
        private double _RefAmt;
        public double RefAmt
        {
            get
            {
                return _RefAmt;
            }
            set
            {
                _RefAmt = value;
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

        private string _LegGard;
        public string LegGard
        {
            get
            {
                return _LegGard;
            }
            set
            {
                _LegGard = value;
            }
        }
        private string _MotherNm;
        public string MotherNm
        {
            get
            {
                return _MotherNm;
            }
            set
            {
                _MotherNm = value;
            }
        }
        private string _SpouseNm;
        public string SpouseNm
        {
            get
            {
                return _SpouseNm;
            }
            set
            {
                _SpouseNm = value;
            }
        }

        private string _ContPhone;
        public string ContPhone
        {
            get
            {
                return _ContPhone;
            }
            set
            {
                _ContPhone = value;
            }
        }
        private string _ContEmail;
        public string ContEmail
        {
            get
            {
                return _ContEmail;
            }
            set
            {
                _ContEmail = value;
            }
        }
        private string _ContAdd1;
        public string ContAdd1
        {
            get
            {
                return _ContAdd1;
            }
            set
            {
                _ContAdd1 = value;
            }
        }
        private string _ContAdd2;
        public string ContAdd2
        {
            get
            {
                return _ContAdd2;
            }
            set
            {
                _ContAdd2 = value;
            }
        }
        private string _ContCity;
        public string ContCity
        {
            get
            {
                return _ContCity;
            }
            set
            {
                _ContCity = value;
            }
        }
        private string _ContState;
        public string ContState
        {
            get
            {
                return _ContState;
            }
            set
            {
                _ContState = value;
            }
        }
        private double _ContCountry;
        public double ContCountry
        {
            get
            {
                return _ContCountry;
            }
            set
            {
                _ContCountry = value;
            }
        }
        private string _ContLGA;
        public string ContLGA
        {
            get
            {
                return _ContLGA;
            }
            set
            {
                _ContLGA = value;
            }
        }
        private string _ContDist;
        public string ContDist
        {
            get
            {
                return _ContDist;
            }
            set
            {
                _ContDist = value;
            }
        }
        private string _ContPin;
        public string ContPin
        {
            get
            {
                return _ContPin;
            }
            set
            {
                _ContPin = value;
            }
        }
        //VisaDT


        private string _NewPassportNo;
        public string NewPassportNo
        {
            get
            {
                return _NewPassportNo;
            }
            set
            {
                _NewPassportNo = value;
            }
        }
        private DateTime _NewIssueDt;
        public DateTime NewIssueDt
        {
            get
            {
                return _NewIssueDt;
            }
            set
            {
                _NewIssueDt = value;
            }
        }
        private DateTime _NewExpDt;
        public DateTime NewExpDt
        {
            get
            {
                return _NewExpDt;
            }
            set
            {
                _NewExpDt = value;
            }
        }
        private int _NewProcessCount;
        public int NewProcessCount
        {
            get
            {
                return _NewProcessCount;
            }
            set
            {
                _NewProcessCount = value;
            }
        }
        private string _NewProcessEmbassy;
        public string NewProcessEmbassy
        {
            get
            {
                return _NewProcessEmbassy;
            }
            set
            {
                _NewProcessEmbassy = value;
            }
        }

        private string _NewPerNm;
        public string NewPerNm
        {
            get
            {
                return _NewPerNm;
            }
            set
            {
                _NewPerNm = value;
            }
        }
        private string _NewFNm;
        public string NewFNm
        {
            get
            {
                return _NewFNm;
            }
            set
            {
                _NewFNm = value;
            }
        }
        private string _NewMNm;
        public string NewMNm
        {
            get
            {
                return _NewMNm;
            }
            set
            {
                _NewMNm = value;
            }
        }
        private string _NewLNm;
        public string NewLNm
        {
            get
            {
                return _NewLNm;
            }
            set
            {
                _NewLNm = value;
            }
        }
        private string _NewGender;
        public string NewGender
        {
            get
            {
                return _NewGender;
            }
            set
            {
                _NewGender = value;
            }
        }
        private string _NewMarStatus;
        public string NewMarStatus
        {
            get
            {
                return _NewMarStatus;
            }
            set
            {
                _NewMarStatus = value;
            }
        }
        private DateTime _NewDOB;
        public DateTime NewDOB
        {
            get
            {
                return _NewDOB;
            }
            set
            {
                _NewDOB = value;
            }
        }

        private string _NewLegGad;
        public string NewLegGad
        {
            get
            {
                return _NewLegGad;
            }
            set
            {
                _NewLegGad = value;
            }
        }
        private string _NewMontherNm;
        public string NewMontherNm
        {
            get
            {
                return _NewMontherNm;
            }
            set
            {
                _NewMontherNm = value;
            }
        }
        private string _NewSpouseNm;
        public string NewSpouseNm
        {
            get
            {
                return _NewSpouseNm;
            }
            set
            {
                _NewSpouseNm = value;
            }
        }

        private string _NigAdd1;
        public string NigAdd1
        {
            get
            {
                return _NigAdd1;
            }
            set
            {
                _NigAdd1 = value;
            }
        }
        private string _NigAdd2;
        public string NigAdd2
        {
            get
            {
                return _NigAdd2;
            }
            set
            {
                _NigAdd2 = value;
            }
        }
        private string _NigCity;
        public string NigCity
        {
            get
            {
                return _NigCity;
            }
            set
            {
                _NigCity = value;
            }
        }
        private double _NigCountry;
        public double NigCountry
        {
            get
            {
                return _NigCountry;
            }
            set
            {
                _NigCountry = value;
            }
        }
        private string _NigState;
        public string NigState
        {
            get
            {
                return _NigState;
            }
            set
            {
                _NigState = value;
            }
        }
        private string _NigLGA;
        public string NigLGA
        {
            get
            {
                return _NigLGA;
            }
            set
            {
                _NigLGA = value;
            }
        }
        private string _NigDist;
        public string NigDist
        {
            get
            {
                return _NigDist;
            }
            set
            {
                _NigDist = value;
            }
        }
        private string _NigPin;
        public string NigPin
        {
            get
            {
                return _NigPin;
            }
            set
            {
                _NigPin = value;
            }
        }

        private string _KinNm;
        public string KinNm
        {
            get
            {
                return _KinNm;
            }
            set
            {
                _KinNm = value;
            }
        }
        private string _KinRel;
        public string KinRel
        {
            get
            {
                return _KinRel;
            }
            set
            {
                _KinRel = value;
            }
        }
        private string _KinContNo;
        public string KinContNo
        {
            get
            {
                return _KinContNo;
            }
            set
            {
                _KinContNo = value;
            }
        }
        private string _KinAdd1;
        public string KinAdd1
        {
            get
            {
                return _KinAdd1;
            }
            set
            {
                _KinAdd1 = value;
            }
        }
        private string _KinAdd2;
        public string KinAdd2
        {
            get
            {
                return _KinAdd2;
            }
            set
            {
                _KinAdd2 = value;
            }
        }
        private string _KinCity;
        public string KinCity
        {
            get
            {
                return _KinCity;
            }
            set
            {
                _KinCity = value;
            }
        }
        private double _KinCountry;
        public double KinCountry
        {
            get
            {
                return _KinCountry;
            }
            set
            {
                _KinCountry = value;
            }
        }
        private string _KinState;
        public string KinState
        {
            get
            {
                return _KinState;
            }
            set
            {
                _KinState = value;
            }
        }
        private string _KinLGA;
        public string KinLGA
        {
            get
            {
                return _KinLGA;
            }
            set
            {
                _KinLGA = value;
            }
        }
        private string _KinDist;
        public string KinDist
        {
            get
            {
                return _KinDist;
            }
            set
            {
                _KinDist = value;
            }
        }
        private string _KinPin;
        public string KinPin
        {
            get
            {
                return _KinPin;
            }
            set
            {
                _KinPin = value;
            }
        }

        private string _PPosition;
        public string PPosition
        {
            get
            {
                return _PPosition;
            }
            set
            {
                _PPosition = value;
            }
        }
        private string _EntryType;
        public string EntryType
        {
            get
            {
                return _EntryType;
            }
            set
            {
                _EntryType = value;
            }
        }
        private int _PStatus;
        public int PStatus
        {
            get
            {
                return _PStatus;
            }
            set
            {
                _PStatus = value;
            }
        }

        // Rejection of Passport

        private string _RSLNO;
        public string RSLNO
        {
            get
            {
                return _RSLNO;
            }
            set
            {
                _RSLNO = value;
            }
        }
        private string _RMLNO;
        public string RMLNO
        {
            get
            {
                return _RMLNO;
            }
            set
            {
                _RMLNO = value;
            }
        }
        private string _RSrNo;
        public string RSrNo
        {
            get
            {
                return _RSrNo;
            }
            set
            {
                _RSrNo = value;
            }
        }
        private string _RWhy;
        public string RWhy
        {
            get
            {
                return _RWhy;
            }
            set
            {
                _RWhy = value;
            }
        }
        private string _RIsActive;
        public string RIsActive
        {
            get
            {
                return _RIsActive;
            }
            set
            {
                _RIsActive = value;
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
            SQL = "Select * from PassportApp Where PassportID=@PassportID";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@PassportID", _SLNO.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                _StrSrNo = dtC.Rows[0]["RegNoStr"].ToString();
                _RegDt = Convert.ToDateTime(dtC.Rows[0]["RegDt"].ToString());
                _ReqType = Convert.ToDouble(dtC.Rows[0]["ReqType"].ToString());
                _RefNo =  dtC.Rows[0]["RefNo"].ToString() ;
                _RefDate = Convert.ToDateTime(dtC.Rows[0]["RefDate"].ToString());
                _RefAmt = Convert.ToDouble(dtC.Rows[0]["RefAmt"].ToString());
                //AppNoStr
                _AppID = dtC.Rows[0]["AppNoStr"].ToString();
                _AppDt = Convert.ToDateTime(dtC.Rows[0]["AppDt"].ToString());
                _EnrolmentNo = Convert.ToDouble(dtC.Rows[0]["EnrolmentNo"].ToString());
                _PasportNo = dtC.Rows[0]["PasportNo"].ToString();
                _PIssDt = Convert.ToDateTime(dtC.Rows[0]["PIssDt"].ToString());
                _PExpDt = Convert.ToDateTime(dtC.Rows[0]["PExpDt"].ToString());
                _PIssCountry = Convert.ToInt16(dtC.Rows[0]["PIssCountry"].ToString());

                _PerNm = dtC.Rows[0]["PerNm"].ToString();
                _FirstNm = dtC.Rows[0]["FirstNm"].ToString();
                _MidNm = dtC.Rows[0]["MidNm"].ToString();
                _LastNm = dtC.Rows[0]["LastNm"].ToString();
                _Gender = dtC.Rows[0]["Gender"].ToString();
                _MarStatus = dtC.Rows[0]["MarStatus"].ToString();
                _DOB = Convert.ToDateTime(dtC.Rows[0]["DOB"].ToString());
                
                _LegGard = dtC.Rows[0]["LegGard"].ToString();
                _MotherNm = dtC.Rows[0]["MotherNm"].ToString();
                _SpouseNm = dtC.Rows[0]["SpouseNm"].ToString();

                _ContPhone = dtC.Rows[0]["ContPhone"].ToString();
                _ContEmail = dtC.Rows[0]["ContEmail"].ToString();
                _ContAdd1 = dtC.Rows[0]["ContAdd1"].ToString();
                _ContAdd2 = dtC.Rows[0]["ContAdd2"].ToString();
                _ContCity = dtC.Rows[0]["ContCity"].ToString();
                _ContState = dtC.Rows[0]["ContState"].ToString();
                _ContLGA = dtC.Rows[0]["ContLGA"].ToString();
                _ContDist = dtC.Rows[0]["ContDist"].ToString();
                _ContCountry = Convert.ToInt16(dtC.Rows[0]["ContCountry"].ToString());
                _ContPin = dtC.Rows[0]["ContPin"].ToString();

                _NewPassportNo = dtC.Rows[0]["NewPassportNo"].ToString();
                _NewIssueDt = Convert.ToDateTime(dtC.Rows[0]["NewIssueDt"].ToString());
                _NewExpDt = Convert.ToDateTime(dtC.Rows[0]["NewExpDt"].ToString());
                _NewProcessCount = Convert.ToInt16(dtC.Rows[0]["NewProcessCount"].ToString());
                _NewProcessEmbassy = dtC.Rows[0]["NewProcessEmbassy"].ToString();

                _NewPerNm = dtC.Rows[0]["NewPerNm"].ToString();
                _NewFNm = dtC.Rows[0]["NewFNm"].ToString();
                _NewMNm = dtC.Rows[0]["NewMNm"].ToString();
                _NewLNm = dtC.Rows[0]["NewLNm"].ToString();
                _NewGender = dtC.Rows[0]["NewGender"].ToString();
                _NewMarStatus = dtC.Rows[0]["NewMarStatus"].ToString();
                _NewDOB = Convert.ToDateTime(dtC.Rows[0]["NewDOB"].ToString());

                _NewLegGad = dtC.Rows[0]["NewLegGad"].ToString();
                _NewMontherNm = dtC.Rows[0]["NewMontherNm"].ToString();
                _NewSpouseNm = dtC.Rows[0]["NewSpouseNm"].ToString();

                _NigAdd1 = dtC.Rows[0]["NigAdd1"].ToString();
                _NigAdd2 = dtC.Rows[0]["NigAdd2"].ToString();
                _NigCity = dtC.Rows[0]["NigCity"].ToString();
                _NigState = dtC.Rows[0]["NigState"].ToString();
                _NigCountry = Convert.ToInt16(dtC.Rows[0]["NigCountry"].ToString());
                _NigLGA = dtC.Rows[0]["NigLGA"].ToString();
                _NigDist = dtC.Rows[0]["NigDist"].ToString();
                _NigPin = dtC.Rows[0]["NigPin"].ToString();

                _KinNm = dtC.Rows[0]["KinNm"].ToString();
                _KinRel = dtC.Rows[0]["KinRel"].ToString();
                _KinContNo = dtC.Rows[0]["KinContNo"].ToString();
                _KinAdd1 = dtC.Rows[0]["KinAdd1"].ToString();
                _KinAdd2 = dtC.Rows[0]["KinAdd2"].ToString();
                _KinCity = dtC.Rows[0]["KinCity"].ToString();
                _KinState = dtC.Rows[0]["KinState"].ToString();
                _KinCountry = Convert.ToInt16(dtC.Rows[0]["KinCountry"].ToString());
                _KinLGA = dtC.Rows[0]["KinLGA"].ToString();
                _KinDist = dtC.Rows[0]["KinDist"].ToString();
                _KinPin = dtC.Rows[0]["KinPin"].ToString();

                _PPosition = dtC.Rows[0]["PPosition"].ToString().Trim();
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
        public Boolean Fn_CheckAppNo(string FindAppNo, string PassportID)
        {
            Boolean BolRet = false;
            if (PassportID.Trim() == "")
            {
                SQL = "Select  AppNoStr  from PassportApp Where AppNoStr=@AppNoStr order By PassportID Desc";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@AppNoStr", FindAppNo.Trim().Replace("'", ""));
            }
            else
            {
                SQL = "Select    AppNoStr  from PassportApp Where AppNoStr=@AppNoStr and PassportID!=@PassportID order By PassportID Desc";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@AppNoStr", FindAppNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PassportID", PassportID.Trim().Replace("'", ""));

            }
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                BolRet = true;

            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();
            return BolRet; 
        }
        public Boolean Fn_CheckRefNo(string FindRefNo, string PassportID)
        {
            Boolean BolRet = false;
            if (PassportID.Trim() == "")
            {
                SQL = "Select  PassportID  from PassportApp Where RefNo=@RefNo order By PassportID Desc";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@RefNo", FindRefNo.Trim().Replace("'", ""));
            }
            else
            {
                SQL = "Select    PassportID  from PassportApp Where RefNo=@RefNo and PassportID!=@PassportID order By PassportID Desc";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@RefNo", FindRefNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PassportID", PassportID.Trim().Replace("'", ""));

            }
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                BolRet = true;

            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();
            return BolRet;
            //VisaPosition,VisaNo ,VisaDT  ,VisaForTime= ,
        }
        public Boolean Fn_CheckNewPassportNo(string FindNewPassportNo, string PassportID)
        {
            Boolean BolRet = false;
            if (PassportID.Trim() == "")
            {
                SQL = "Select  NewPassportNo  from PassportApp Where NewPassportNo=@NewPassportNo and NewPassportNo is not null order By PassportID Desc";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@NewPassportNo", FindNewPassportNo.Trim().Replace("'", ""));
            }
            else
            {
                SQL = "Select    NewPassportNo  from PassportApp Where NewPassportNo=@NewPassportNo and PassportID!=@PassportID and NewPassportNo is not null order By PassportID Desc";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@NewPassportNo", FindNewPassportNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PassportID", PassportID.Trim().Replace("'", ""));

            }
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                BolRet = true;

            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();
            return BolRet;
            //VisaPosition,VisaNo ,VisaDT  ,VisaForTime= ,
        }
        public Boolean Fn_CheckNewEnrolmentNo(string FindEnrolmentNo, string PassportID)
        {
            Boolean BolRet = false;
            if (PassportID.Trim() == "")
            {
                SQL = "Select  EnrolmentNo  from PassportApp Where EnrolmentNo=@EnrolmentNo   order By PassportID Desc";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@EnrolmentNo", FindEnrolmentNo.Trim().Replace("'", ""));
            }
            else
            {
                SQL = "Select    NewPassportNo  from PassportApp Where EnrolmentNo=@EnrolmentNo and PassportID!=@PassportID   order By PassportID Desc";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@EnrolmentNo", FindEnrolmentNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PassportID", PassportID.Trim().Replace("'", ""));

            }
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                BolRet = true;

            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();
            return BolRet;
            //VisaPosition,VisaNo ,VisaDT  ,VisaForTime= ,
        }
        public void Fn_SendFrwdDirect(string StrVisaID, int IntStatus)
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            
                SQL = "Update PassportApp SET  PStatus=3, RecpBy=@RecpBy,RecpDt=@RecpDt, DocUpBy=@RecpBy,DocDt=@RecpDt, StatusUpBy=@RecpBy,StatusUpDT=@RecpDt " +
                       " Where PassportID=@PassportID";
             
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@PassportID", StrVisaID.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@RecpBy", GlobalFunction.L_LoginID);
            Com.Parameters.AddWithValue("@RecpDt", GlobalFunction.Fn_GetCurrentDateTime());
            Com.CommandText = SQL;
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
            Conn.Close();
        }
        public void Fn_SendFrwd(string StrVisaID, int IntStatus, int VApp)
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            if (IntStatus == 0)
            {
                SQL = "Update PassportApp SET  PStatus=1, RecpBy=@RecpBy,RecpDt=@RecpDt " +
                       " Where PassportID=@PassportID";
            }
            if (IntStatus == 1)
            {
                if (VApp == 1)
                {
                    SQL = "Update PassportApp SET  PStatus=2, StatusUpBy=@RecpBy,StatusUpDT=@RecpDt, PPosition='A' " +
                           " Where PassportID=@PassportID";
                }
                if (VApp == 2)
                {
                    SQL = "Update PassportApp SET  PStatus=3, StatusUpBy=@RecpBy,StatusUpDT=@RecpDt, PPosition='R' " +
                           " Where PassportID=@PassportID";
                }
            }
            if (IntStatus == 2)
            {
                SQL = "Update PassportApp SET  PStatus=3, PPrd=@RecpBy,PPrdDt=@RecpDt " +
                       " Where PassportID=@PassportID";
            }
            if (IntStatus == 3)
            {
                SQL = "Update PassportApp SET  PStatus=4, DocUpBy=@RecpBy,DocDt=@RecpDt " +
                       " Where PassportID=@PassportID";
            }
           
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@PassportID", StrVisaID.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@RecpBy", GlobalFunction.L_LoginID);
            Com.Parameters.AddWithValue("@RecpDt", GlobalFunction.Fn_GetCurrentDateTime());
            Com.CommandText = SQL;
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
            Conn.Close();
        }
        public void Fn_SendBack(string StrVisaID, int IntStatus,  int VApp)
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            if (IntStatus == 1)
            {
                SQL = "Update PassportApp SET  PStatus=0, RecpBy=0 " +
                       " Where PassportID=@PassportID";
            }
            if (IntStatus == 2)
            {
                SQL = "Update PassportApp SET  PStatus=1, StatusUpBy=0, PPosition='P' " +
                       " Where PassportID=@PassportID";
            }
            if (IntStatus == 3)
            {
                if (VApp == 1)
                {
                    SQL = "Update PassportApp SET  PStatus=2, PPrd=0 " +
                           " Where PassportID=@PassportID";
                }
                if (VApp == 2)
                {
                    SQL = "Update PassportApp SET  PStatus=1, StatusUpBy=0, PPosition='P'  " +
                          " Where PassportID=@PassportID";
                }
            }
            if (IntStatus == 4)
            {
                SQL = "Update PassportApp SET  PStatus=3, DocUpBy=0 " +
                       " Where PassportID=@PassportID";
            }
            
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@PassportID", StrVisaID.Trim().Replace("'", ""));
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


                SQL = "INSERT INTO PassportApp(LoactionID,RegNoInt,RegNoStr,FinYear," +
                    " RegDt,ReqType,RefNo,RefDate,RefAmt," +
                    " AppNoStr,AppDt,PasportNo,PIssDt,PExpDt,PIssCountry, " +
                    " PerNm,FirstNm,MidNm,LastNm,Gender,MarStatus,DOB,LegGard,MotherNm,SpouseNm," +
                    " ContPhone,ContEmail,ContAdd1,ContAdd2,ContCity,ContState,ContCountry,ContPin,ContLGA,ContDist," +
                    " NewPassportNo, NewIssueDt,NewExpDt,NewProcessCount,NewProcessEmbassy," +
                    " NewPerNm,NewFNm,NewMNm,NewLNm,NewGender,NewMarStatus,NewDOB,NewLegGad,NewMontherNm,NewSpouseNm," +
                    " NigAdd1,NigAdd2,NigCity,NigCountry,NigState,NigLGA,NigDist,NigPin," +
                    " KinNm,KinRel,KinContNo,KinAdd1,KinAdd2,KinCity,KinCountry,KinState,KinLGA,KinDist,KinPin," +
                    " IsActive,UpdateBy,LastDate,EntryType,PPosition,EnrolmentNo) " +
                    " Values (@LoactionID,@RegNoInt,@RegNoStr,@FinYear," +
                    " @RegDt,@ReqType,@RefNo,@RefDate,@RefAmt," +
                    " @AppNoStr,@AppDt,@PasportNo,@PIssDt,@PExpDt,@PIssCountry, " +
                    " @PerNm,@FirstNm,@MidNm,@LastNm,@Gender,@MarStatus,@DOB,@LegGard,@MotherNm,@SpouseNm," +
                    " @ContPhone,@ContEmail,@ContAdd1,@ContAdd2,@ContCity,@ContState,@ContCountry,@ContPin,@ContLGA,@ContDist," +
                    " @NewPassportNo, @NewIssueDt,@NewExpDt,@NewProcessCount,@NewProcessEmbassy," +
                    " @NewPerNm,@NewFNm,@NewMNm,@NewLNm,@NewGender,@NewMarStatus,@NewDOB,@NewLegGad,@NewMontherNm,@NewSpouseNm," +
                    " @NigAdd1,@NigAdd2,@NigCity,@NigCountry,@NigState,@NigLGA,@NigDist,@NigPin," +
                    " @KinNm,@KinRel,@KinContNo,@KinAdd1,@KinAdd2,@KinCity,@KinCountry,@KinState,@KinLGA,@KinDist,@KinPin," +
                    " @IsActive,@UpdateBy,@LastDate,@EntryType,@PPosition,@EnrolmentNo) ";
                Com.Connection = Conn;
                Com.Parameters.Clear();



                Com.Parameters.AddWithValue("@EntryType", _EntryType);
                Com.Parameters.AddWithValue("@LoactionID", GlobalFunction.L_LocationID);
                Com.Parameters.AddWithValue("@RegNoInt", _SrNo); 
                Com.Parameters.AddWithValue("@RegNoStr", _StrSrNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@RegDt", _RegDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@FinYear", GlobalFunction.Fn_GetFinYear().ToString());

                Com.Parameters.AddWithValue("@ReqType", _ReqType);
                Com.Parameters.AddWithValue("@RefNo", _RefNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@RefDate", _RefDate.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@RefAmt", _RefAmt.ToString("0.00"));

                Com.Parameters.AddWithValue("@AppNoStr", _AppID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@AppDt", _AppDt.ToString("dd/MMM/yyyy"));

                Com.Parameters.AddWithValue("@PasportNo", _PasportNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PIssDt", _PIssDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@PExpDt", _PExpDt.ToString("dd/MMM/yyyy")); 
                Com.Parameters.AddWithValue("@PIssCountry", _PIssCountry);

                Com.Parameters.AddWithValue("@PerNm", _PerNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@FirstNm", _FirstNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@MidNm", _MidNm.Trim().Replace("'", ""));               
                Com.Parameters.AddWithValue("@LastNm", _LastNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@Gender", _Gender.Trim().Replace("'", ""));  
                Com.Parameters.AddWithValue("@MarStatus", _MarStatus.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@DOB", _DOB.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@LegGard", _LegGard.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@MotherNm", _MotherNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@SpouseNm", _SpouseNm.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@ContPhone", _ContPhone.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContEmail", _ContEmail.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContAdd1", _ContAdd1.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContAdd2", _ContAdd2.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContCity", _ContCity.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContState", _ContState.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContCountry", _ContCountry);
                Com.Parameters.AddWithValue("@ContPin", _ContPin.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContLGA", _ContLGA.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContDist", _ContDist.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@NewPassportNo", _NewPassportNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewIssueDt", _NewIssueDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@NewExpDt", _NewExpDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@NewProcessCount", _NewProcessCount);
                Com.Parameters.AddWithValue("@NewProcessEmbassy", _NewProcessEmbassy.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@NewPerNm", _NewPerNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewFNm", _NewFNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewMNm", _NewMNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewLNm", _NewLNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewGender", _NewGender.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewMarStatus", _NewMarStatus.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewDOB", _NewDOB.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@NewLegGad", _NewLegGad.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewMontherNm", _NewMontherNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewSpouseNm", _NewSpouseNm.Trim().Replace("'", ""));


                Com.Parameters.AddWithValue("@NigAdd1", _NigAdd1.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NigAdd2", _NigAdd2.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NigCity", _NigCity.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NigState", _NigState.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NigCountry", _NigCountry);
                Com.Parameters.AddWithValue("@NigLGA", _NigLGA.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NigDist", _NigDist.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NigPin", _NigPin.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@KinNm", _KinNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinRel", _KinRel.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinContNo", _KinContNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinAdd1", _KinAdd1.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinAdd2", _KinAdd2.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinCity", _KinCity.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinState", _KinState.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinCountry", _KinCountry);
                Com.Parameters.AddWithValue("@KinLGA", _KinLGA.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinDist", _KinDist.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinPin", _KinPin.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@PPosition", _PPosition.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@EnrolmentNo", _EnrolmentNo);
                //" RcptNo,RcptDt,RcptAmt,NCopmNm,NCompAdd1,NCompAdd2,NCompCnt,EnrolmentNo"
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
                SQL = "Update PassportApp SET  " +
                    " RegDt=@RegDt,ReqType=@ReqType,RefNo=@RefNo,RefDate=@RefDate,RefAmt=@RefAmt," +
                    " AppNoStr=@AppNoStr,AppDt=@AppDt,PasportNo=@PasportNo,PIssDt=@PIssDt,PExpDt=@PExpDt,PIssCountry=@PIssCountry, " +
                    " PerNm=@PerNm,FirstNm=@FirstNm,MidNm=@MidNm,LastNm=@LastNm,Gender=@Gender,MarStatus=@MarStatus,DOB=@DOB,LegGard=@LegGard,MotherNm=@MotherNm,SpouseNm=@SpouseNm," +
                    " ContPhone=@ContPhone,ContEmail=@ContEmail,ContAdd1=@ContAdd1,ContAdd2=@ContAdd2,ContCity=@ContCity,ContState=@ContState,ContCountry=@ContCountry,ContPin=@ContPin,ContLGA=@ContLGA,ContDist=@ContDist," +
                    " NewPassportNo=@NewPassportNo, NewIssueDt=@NewIssueDt,NewExpDt=@NewExpDt,NewProcessCount=@NewProcessCount,NewProcessEmbassy=@NewProcessEmbassy," +
                    " NewPerNm=@NewPerNm,NewFNm=@NewFNm,NewMNm=@NewMNm,NewLNm=@NewLNm,NewGender=@NewGender,NewMarStatus=@NewMarStatus,NewDOB=@NewDOB,NewLegGad=@NewLegGad,NewMontherNm=@NewMontherNm,NewSpouseNm=@NewSpouseNm," +
                    " NigAdd1=@NigAdd1,NigAdd2=@NigAdd2,NigCity=@NigCity,NigCountry=@NigCountry,NigState=@NigState,NigLGA=@NigLGA,NigDist=@NigDist,NigPin=@NigPin," +
                    " KinNm=@KinNm,KinRel=@KinRel,KinContNo=@KinContNo,KinAdd1=@KinAdd1,KinAdd2=@KinAdd2,KinCity=@KinCity,KinCountry=@KinCountry,KinState=@KinState,KinLGA=@KinLGA,KinDist=@KinDist,KinPin=@KinPin," +
                    " IsActive=@IsActive,UpdateBy=@UpdateBy,LastDate=@LastDate, PPosition=@PPosition, EnrolmentNo=@EnrolmentNo " +
                    " Where PassportID=@PassportID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@PassportID", _SLNO.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@RegDt", _RegDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@ReqType", _ReqType);
                Com.Parameters.AddWithValue("@RefNo", _RefNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@RefDate", _RefDate.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@RefAmt", _RefAmt.ToString("0.00"));

                Com.Parameters.AddWithValue("@AppNoStr", _AppID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@AppDt", _AppDt.ToString("dd/MMM/yyyy"));

                Com.Parameters.AddWithValue("@PasportNo", _PasportNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PIssDt", _PIssDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@PExpDt", _PExpDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@PIssCountry", _PIssCountry);

                Com.Parameters.AddWithValue("@PerNm", _PerNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@FirstNm", _FirstNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@MidNm", _MidNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@LastNm", _LastNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@Gender", _Gender.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@MarStatus", _MarStatus.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@DOB", _DOB.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@LegGard", _LegGard.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@MotherNm", _MotherNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@SpouseNm", _SpouseNm.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@ContPhone", _ContPhone.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContEmail", _ContEmail.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContAdd1", _ContAdd1.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContAdd2", _ContAdd2.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContCity", _ContCity.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContState", _ContState.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContCountry", _ContCountry);
                Com.Parameters.AddWithValue("@ContPin", _ContPin.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContLGA", _ContLGA.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContDist", _ContDist.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@NewPassportNo", _NewPassportNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewIssueDt", _NewIssueDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@NewExpDt", _NewExpDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@NewProcessCount", _NewProcessCount);
                Com.Parameters.AddWithValue("@NewProcessEmbassy", _NewProcessEmbassy.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@NewPerNm", _NewPerNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewFNm", _NewFNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewMNm", _NewMNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewLNm", _NewLNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewGender", _NewGender.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewMarStatus", _NewMarStatus.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewDOB", _NewDOB.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@NewLegGad", _NewLegGad.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewMontherNm", _NewMontherNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NewSpouseNm", _NewSpouseNm.Trim().Replace("'", ""));


                Com.Parameters.AddWithValue("@NigAdd1", _NigAdd1.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NigAdd2", _NigAdd2.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NigCity", _NigCity.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NigState", _NigState.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NigCountry", _NigCountry);
                Com.Parameters.AddWithValue("@NigLGA", _NigLGA.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NigDist", _NigDist.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NigPin", _NigPin.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@KinNm", _KinNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinRel", _KinRel.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinContNo", _KinContNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinAdd1", _KinAdd1.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinAdd2", _KinAdd2.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinCity", _KinCity.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinState", _KinState.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinCountry", _KinCountry);
                Com.Parameters.AddWithValue("@KinLGA", _KinLGA.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinDist", _KinDist.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@KinPin", _KinPin.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@EnrolmentNo", _EnrolmentNo);

                Com.Parameters.AddWithValue("@IsActive", _IsActive.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
                Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());

                Com.Parameters.AddWithValue("@PPosition", _PPosition.Trim().Replace("'", ""));

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }
            else if (_Action == 3)
            {
                SQL = "DELETE FROM VissApp Where PassportID=@PassportID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@PassportID", _SLNO.Trim().Replace("'", ""));
                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }
            Conn.Close();
        }
        public Boolean Fn_PassportView(string FindPasportNo)
        {
            Boolean BolRet = false;
            SQL = "Select Top 1 PassportID from PassportApp Where PasportNo=@PasportNo order By PassportID Desc";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@PasportNo", FindPasportNo.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);

            if (dtC.Rows.Count > 0)
            {
                BolRet = true;
                _SLNO = dtC.Rows[0]["PassportID"].ToString();
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();
            return BolRet;
            //VisaPosition,VisaNo ,VisaDT  ,VisaForTime= ,
        }
        public DataView DV_RetDptList()
        {
            SQL = "Select 0 as PassportID, ' Select' as VisaTNm Union Select PassportID, VisaTNm from PassportApp Where IsActive='Y' order By VisaTNm";
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
            SQL = "Select PassportID, VisaTNm from PassportApp Where IsActive='Y' order By VisaTNm";
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
                SQL = "INSERT INTO VisaDoc(PassportID,SrNo,DocName,IsActive,UpdateBy,LastDate) " +
                    " Values (@PassportID,@SrNo,@DocName,@IsActive,@UpdateBy,@LastDate)";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@SrNo", D_SrNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@PassportID", D_VisaID.Trim().Replace("'", ""));
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
                       " Where SLNO=@PassportID";
                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@PassportID", D_SLNO.Trim().Replace("'", ""));
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
            SQL = "Select SLNO, SrNo,DocName,IsActive from VisaDOC Where PassportID=@PassportID order By SrNo";
            DataView DVMG = new DataView();
            DataSet dsMG = new DataSet();
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@PassportID", MSLNO.Trim().Replace("'", ""));
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

            SQL = "Select IsNull((Max(RegNoInt)),0)+1 as MCT from PassportApp Where LoactionID=@LocationID and FinYear=@FinYear";
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
        public void Fn_SavePassportRej()
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            if (_RSLNO.Trim() == "")
            {
                SQL = "Insert PassportCancelRes(PassportID,SrNo,CanRes,IsActive,UpdateBy,LastDate) Values " +
                    "(@PassportID,@SrNo,@CanRes,@IsActive,@UpdateBy,@LastDate)";

                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@PassportID", _RMLNO.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@SrNo", _RSrNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@CanRes", _RWhy.Trim().Replace("'", "")); 

                Com.Parameters.AddWithValue("@IsActive", _RIsActive.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
                Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime()); 

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            }
            else
            {
                SQL = "Update PassportCancelRes Set   " +
                        " SrNo=@SrNo,CanRes=@CanRes,IsActive=@IsActive,UpdateBy=@UpdateBy,LastDate=@LastDate " +
                        " Where SLNO=@SLNO";

                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@SLNO", _RSLNO.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@SrNo", _RSrNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@CanRes", _RWhy.Trim().Replace("'", "")); 

                Com.Parameters.AddWithValue("@IsActive", _RIsActive.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
                Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime()); 

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
            
            }
            Conn.Close();
        }
        public Boolean Fn_PassportRej(string varID)
        {
            Boolean SSRet = false;
            //VisaCancelRes(VisaID
            SQL = "Select PassportID from PassportCancelRes Where  PassportID = @PassportID";
            Conn.ConnectionString = ConStr;
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@PassportID", varID.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                SSRet = true;
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            return SSRet;
        }
        public DataView DV_RetGridViewPassport()
        {
            SQL = "Select SLNO,SrNo,CanRes,IsActive from PassportCancelRes Where PassportID=@PassportID order By SrNo";
            DataView DVMG = new DataView();
            DataSet dsMG = new DataSet();
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@PassportID", _RMLNO.Trim().Replace("'", ""));
            Com.CommandText = SQL;
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dsMG);
            DVMG.Table = dsMG.Tables[0];
            Com.Dispose();
            DataAdapter.Dispose();
            Conn.Close();
            return DVMG;

        }
        public void Fn_DataViewRej()
        {
            SQL = "Select * from PassportCancelRes Where SLNO=@SLNO";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@SLNO", _RSLNO.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                _RSrNo = dtC.Rows[0]["SrNo"].ToString();
                _RWhy =  dtC.Rows[0]["CanRes"].ToString();
                 
                _RIsActive = dtC.Rows[0]["IsActive"].ToString();
                _UpdBy = dtC.Rows[0]["UpdateBy"].ToString();
                _LastDt = Convert.ToDateTime(dtC.Rows[0]["LastDate"].ToString());

            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();
        } 
    }
}
