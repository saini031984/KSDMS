 
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
        private string _VisaPosition;
        public string VisaPosition
        {
            get
            {
                return _VisaPosition;
            }
            set
            {
                _VisaPosition = value;
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
        //EntryType,VisaPosition,VisaNo=@VisaNo,VisaDT=@VisaDT,VisaForTime=@VisaForTime,
        private string _VisaNo;
        public string VisaNo
        {
            get
            {
                return _VisaNo;
            }
            set
            {
                _VisaNo = value;
            }
        }
        private string _VisaForTime;
        public string VisaForTime
        {
            get
            {
                return _VisaForTime;
            }
            set
            {
                _VisaForTime = value;
            }
        }
        private DateTime _VisaDT1;
        public DateTime VisaDT1
        {
            get
            {
                return _VisaDT1;
            }
            set
            {
                _VisaDT1 = value;
            }
        }
        private DateTime _STRFromDt;
        public DateTime STRFromDt
        {
            get
            {
                return _STRFromDt;
            }
            set
            {
                _STRFromDt = value;
            }
        }
        private DateTime _StrToDt;
        public DateTime StrToDt
        {
            get
            {
                return _StrToDt;
            }
            set
            {
                _StrToDt = value;
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
        private string _STJVisaNo;
        public string STJVisaNo
        {
            get
            {
                return _STJVisaNo;
            }
            set
            {
                _STJVisaNo = value;
            }
        }
        private string _STRCompNm;
        public string STRCompNm
        {
            get
            {
                return _STRCompNm;
            }
            set
            {
                _STRCompNm = value;
            }
        }
        private string _STRAdd1;
        public string STRAdd1
        {
            get
            {
                return _STRAdd1;
            }
            set
            {
                _STRAdd1 = value;
            }
        }
        private string _STRAdd2;
        public string STRAdd2
        {
            get
            {
                return _STRAdd2;
            }
            set
            {
                _STRAdd2 = value;
            }
        }
        private string _STREQP;
        public string STREQP
        {
            get
            {
                return _STREQP;
            }
            set
            {
                _STREQP = value;
            }
        }
        private string _STRRefNo;
        public string STRRefNo
        {
            get
            {
                return _STRRefNo;
            }
            set
            {
                _STRRefNo = value;
            }
        }
        private int _StrNoMn;
        public int StrNoMn
        {
            get
            {
                return _StrNoMn;
            }
            set
            {
                _StrNoMn = value;
            }
        }
        private int _StrNoYear;
        public int StrNoYear
        {
            get
            {
                return _StrNoYear;
            }
            set
            {
                _StrNoYear = value;
            }
        }
        private int _VisaStatus;
        public int VisaStatus
        {
            get
            {
                return _VisaStatus;
            }
            set
            {
                _VisaStatus = value;
            }
        }

        private string _RcptNo;
        public string RcptNo
        {
            get
            {
                return _RcptNo;
            }
            set
            {
                _RcptNo = value;
            }
        }
        private DateTime _RcptDt;
        public DateTime RcptDt
        {
            get
            {
                return _RcptDt;
            }
            set
            {
                _RcptDt = value;
            }
        }
        private double _RcptAmt;
        public double RcptAmt
        {
            get
            {
                return _RcptAmt;
            }
            set
            {
                _RcptAmt = value;
            }
        }
        private string _NCopmNm;
        public string NCopmNm
        {
            get
            {
                return _NCopmNm;
            }
            set
            {
                _NCopmNm = value;
            }
        }
        private string _NCompAdd1;
        public string NCompAdd1
        {
            get
            {
                return _NCompAdd1;
            }
            set
            {
                _NCompAdd1 = value;
            }
        }
        private string _NCompAdd2;
        public string NCompAdd2
        {
            get
            {
                return _NCompAdd2;
            }
            set
            {
                _NCompAdd2 = value;
            }
        }
        private string _NCompCnt;
        public string NCompCnt
        {
            get
            {
                return _NCompCnt;
            }
            set
            {
                _NCompCnt = value;
            }
        }
        private double _Occupation;
        public double Occupation
        {
            get
            {
                return _Occupation;
            }
            set
            {
                _Occupation = value;
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
        //Occupation
        //RcptNo,RcptDt,RcptAmt,NCopmNm,NCompAdd1,NCompAdd2,NCompCnt
        //VisaStatus,RefNo, STJVisaNo,STRCompNm,STRAdd1,STRAdd2,STREQP,STRRefNo,STRFromDt,StrToDt,StrNoMn,StrNoYear
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
                _VisaPosition= dtC.Rows[0]["VisaPosition"].ToString().Trim();
                _Occupation = Convert.ToDouble(dtC.Rows[0]["Occupation"].ToString().Trim());
                _RefNo = dtC.Rows[0]["RefNo"].ToString().Trim();
                _STJVisaNo = dtC.Rows[0]["STJVisaNo"].ToString().Trim();
                _STRCompNm = dtC.Rows[0]["STRCompNm"].ToString().Trim();
                _STRAdd1 = dtC.Rows[0]["STRAdd1"].ToString().Trim();
                _STRAdd2 = dtC.Rows[0]["STRAdd2"].ToString().Trim();
                _STREQP = dtC.Rows[0]["STREQP"].ToString().Trim();
                _STRRefNo = dtC.Rows[0]["STRRefNo"].ToString().Trim();

                _STRFromDt = Convert.ToDateTime(dtC.Rows[0]["STRFromDt"].ToString().Trim());
                _StrToDt = Convert.ToDateTime(dtC.Rows[0]["StrToDt"].ToString().Trim());
                _StrNoMn = Convert.ToInt16(dtC.Rows[0]["StrNoMn"].ToString().Trim());
                _StrNoYear = Convert.ToInt16(dtC.Rows[0]["StrNoYear"].ToString().Trim());

                _RcptNo = dtC.Rows[0]["RcptNo"].ToString().Trim();
                _RcptDt = Convert.ToDateTime(dtC.Rows[0]["RcptDt"].ToString().Trim());
                _RcptAmt = Convert.ToDouble(dtC.Rows[0]["RcptAmt"].ToString().Trim());
                _NCopmNm = dtC.Rows[0]["NCopmNm"].ToString().Trim();
                _NCompAdd1 = dtC.Rows[0]["NCompAdd1"].ToString().Trim();
                _NCompAdd2 = dtC.Rows[0]["NCompAdd2"].ToString().Trim();
                _NCompCnt = dtC.Rows[0]["NCompCnt"].ToString().Trim();


                //RcptNo,RcptDt,RcptAmt,NCopmNm,NCompAdd1,NCompAdd2,NCompCnt
                //RefNo, STJVisaNo,STRCompNm,STRAdd1,STRAdd2,STREQP,STRRefNo,STRFromDt,StrToDt,StrNoMn,StrNoYear
                if (VisaPosition == "A")
                {
                    _VisaNo = dtC.Rows[0]["VisaNo"].ToString().Trim();
                    try
                    {
                        _VisaForTime = dtC.Rows[0]["VisaForTime"].ToString().Trim();
                        _VisaDT1 = Convert.ToDateTime(dtC.Rows[0]["VisaDT"].ToString().Trim());
                        
                    }
                    catch { }
                
                }
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();
            //VisaPosition,VisaNo ,VisaDT  ,VisaForTime= ,
        }
        public Boolean Fn_PassportView(string FindPasportNo)
        {
            Boolean BolRet = false;
            SQL = "Select Top 1 * from VisaApp Where PasportNo=@PasportNo order By VisaID Desc";
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
                _SLNO = dtC.Rows[0]["VisaID"].ToString();
                _PIssDt = Convert.ToDateTime(dtC.Rows[0]["PIssDt"].ToString());
                _PExpDt = Convert.ToDateTime(dtC.Rows[0]["PExpDt"].ToString());
                _DOB = Convert.ToDateTime(dtC.Rows[0]["DOB"].ToString());   
                _PIssLocation = dtC.Rows[0]["PIssLocation"].ToString();
                _PIssCountry = Convert.ToInt16(dtC.Rows[0]["PIssCountry"].ToString());
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
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();
            return BolRet;
            //VisaPosition,VisaNo ,VisaDT  ,VisaForTime= ,
        }
        public Boolean Fn_VisaView(string FindVisaNo)
        {
            Boolean BolRet = false;
            SQL = "Select Top 1 STRCompNm,STRAdd1,STRAdd2,STREQP,STRRefNo,STRFromDt,StrToDt,StrNoMn,StrNoYear from VisaApp Where VisaNo=@VisaNo order By VisaID Desc";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@VisaNo", FindVisaNo.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                BolRet = true;
                _STRCompNm = dtC.Rows[0]["STRCompNm"].ToString().Trim();
                _STRAdd1 = dtC.Rows[0]["STRAdd1"].ToString().Trim();
                _STRAdd2 = dtC.Rows[0]["STRAdd2"].ToString().Trim();
                _STREQP = dtC.Rows[0]["STREQP"].ToString().Trim();
                _STRRefNo = dtC.Rows[0]["STRRefNo"].ToString().Trim();

                _STRFromDt = Convert.ToDateTime(dtC.Rows[0]["STRFromDt"].ToString().Trim());
                _StrToDt = Convert.ToDateTime(dtC.Rows[0]["StrToDt"].ToString().Trim());
                _StrNoMn = Convert.ToInt16(dtC.Rows[0]["StrNoMn"].ToString().Trim());
                _StrNoYear = Convert.ToInt16(dtC.Rows[0]["StrNoYear"].ToString().Trim());
                
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();
            return BolRet;
            //VisaPosition,VisaNo ,VisaDT  ,VisaForTime= ,
        }
        public Boolean Fn_CheckVisaNo(string FindVisaNo, string VisaID)
        {
            Boolean BolRet = false;
            if (VisaID.Trim() == "")
            {
                SQL = "Select  STRCompNm  from VisaApp Where VisaNo=@VisaNo order By VisaID Desc";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VisaNo", FindVisaNo.Trim().Replace("'", ""));
            }
            else
            {
                SQL = "Select    STRCompNm  from VisaApp Where VisaNo=@VisaNo and VisaID!=@VisaID order By VisaID Desc";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VisaNo", FindVisaNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@VisaID", VisaID.Trim().Replace("'", ""));
            
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
        public Boolean Fn_CheckAppNo(string FindVisaNo, string VisaID)
        {
            Boolean BolRet = false;
            if (VisaID.Trim() == "")
            {
                SQL = "Select  STRCompNm  from VisaApp Where AppNoStr=@VisaNo order By VisaID Desc";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VisaNo", FindVisaNo.Trim().Replace("'", ""));
            }
            else
            {
                SQL = "Select    STRCompNm  from VisaApp Where AppNoStr=@VisaNo and VisaID!=@VisaID order By VisaID Desc";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VisaNo", FindVisaNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@VisaID", VisaID.Trim().Replace("'", ""));

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
        public Boolean Fn_CheckRefNo(string FindVisaNo, string VisaID)
        {
            Boolean BolRet = false;
            if (VisaID.Trim() == "")
            {
                SQL = "Select  STRCompNm  from VisaApp Where RefNo=@VisaNo order By VisaID Desc";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VisaNo", FindVisaNo.Trim().Replace("'", ""));
            }
            else
            {
                SQL = "Select    STRCompNm  from VisaApp Where RefNo=@VisaNo and VisaID!=@VisaID order By VisaID Desc";
                Conn.ConnectionString = ConStr;
                Conn.Open();
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VisaNo", FindVisaNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@VisaID", VisaID.Trim().Replace("'", ""));

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

            SQL = "Update VisaApp SET  VisaStatus=5, RecpBy=@RecpBy, RecpDt=@RecpDt, DocUpBy=@RecpBy,DocDt=@RecpDt, AsBy=@RecpBy, AsDt=@RecpDt, " +
                "   StBy=@RecpBy, StDt=@RecpDt,StatusUpBy=@RecpBy, StatusUpDT=@RecpDt " +
                       " Where VisaID=@VisaID";
            
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
        public void Fn_SendFrwd(string StrVisaID, int IntStatus, string VisaStatus)
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            if (IntStatus == 0)
            {
                SQL = "Update VisaApp SET  VisaStatus=1, RecpBy=@RecpBy,RecpDt=@RecpDt " +
                       " Where VisaID=@VisaID";
            }
            if (IntStatus == 1)
            {
                if (VisaStatus == "Approved")
                {
                    SQL = "Update VisaApp SET  VisaStatus=2, AsBy=@RecpBy,AsDt=@RecpDt,VisaPosition='A' " +
                           " Where VisaID=@VisaID";
                }
                else
                {
                    SQL = "Update VisaApp SET  VisaStatus=4, AsBy=@RecpBy,AsDt=@RecpDt,VisaPosition='R' " +
                               " Where VisaID=@VisaID";
                }
            }

            if (IntStatus == 2)
            {
                SQL = "Update VisaApp SET  VisaStatus=3, StBy=@RecpBy,StDt=@RecpDt " +
                       " Where VisaID=@VisaID";
            }
           
            if (IntStatus == 3)
            {
                SQL = "Update VisaApp SET  VisaStatus=4, StatusUpBy=@RecpBy,StatusUpDT=@RecpDt " +
                       " Where VisaID=@VisaID";
            }
            if (IntStatus == 4)
            {
                SQL = "Update VisaApp SET  VisaStatus=5, DocUpBy=@RecpBy,DocDt=@RecpDt " +
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
        public void Fn_SendBack(string StrVisaID, int IntStatus, string VisaStatus)
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            if (IntStatus == 1)
            {
                SQL = "Update VisaApp SET  VisaStatus=0, RecpBy=0 " +
                       " Where VisaID=@VisaID";
            }
            if (IntStatus == 2)
            {
                SQL = "Update VisaApp SET  VisaStatus=1, AsBy=0,VisaPosition='P'  " +
                       " Where VisaID=@VisaID";
            }
            if (IntStatus == 3)
            {
                SQL = "Update VisaApp SET  VisaStatus=2, StBy=1 " +
                       " Where VisaID=@VisaID";
            }
            if (IntStatus == 4)
            {
                if (VisaStatus == "Approved")
                {
                    SQL = "Update VisaApp SET  VisaStatus=3, StatusUpBy=0  " +
                       " Where VisaID=@VisaID";
                }
                else
                {
                    SQL = "Update VisaApp SET  VisaStatus=1,AsBy=0,VisaPosition='P'  " +
                           " Where VisaID=@VisaID";
                }
                
            }
            if (IntStatus == 5)
            {
                SQL = "Update VisaApp SET  VisaStatus=4, DocUpBy=0 " +
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
                    " PasportNo,PIssDt,PExpDt,PIssLocation,PIssCountry,Occupation, " +
                    " PerNm,FirstNm,MidNm,LastNm,Gender,MarStatus,DOB,AppNation," +
                    " PlaceOfBirth,ResAdd1,ResAdd2,ResAdd3,ContactNo,VisaStatus," +
                    " RefNo, STJVisaNo,STRCompNm,STRAdd1,STRAdd2,STREQP,STRRefNo,STRFromDt,StrToDt,StrNoMn,StrNoYear,EntryType," +
                    " RcptNo,RcptDt,RcptAmt,NCopmNm,NCompAdd1,NCompAdd2,NCompCnt," +
                    " IsActive,UpdateBy,LastDate) " +
                    " Values (@LoactionID,@RegNoInt,@RegNoStr,@FinYear," +
                    " @RegDt,@VisaType,@NoOfEnt,@AppNoStr,@AppDt," +
                    " @PasportNo,@PIssDt,@PExpDt,@PIssLocation,@PIssCountry,@Occupation, " +
                    " @PerNm,@FirstNm,@MidNm,@LastNm,@Gender,@MarStatus,@DOB,@AppNation," +
                    " @PlaceOfBirth,@ResAdd1,@ResAdd2,@ResAdd3,@ContactNo,@VisaStatus," +
                    " @RefNo, @STJVisaNo,@STRCompNm,@STRAdd1,@STRAdd2,@STREQP,@STRRefNo,@STRFromDt,@StrToDt,@StrNoMn,@StrNoYear,@EntryType," +
                    " @RcptNo,@RcptDt,@RcptAmt,@NCopmNm,@NCompAdd1,@NCompAdd2,@NCompCnt, " +
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
                Com.Parameters.AddWithValue("@Occupation", _Occupation);

                Com.Parameters.AddWithValue("@MarStatus", _MarStatus.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@DOB", _DOB.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@PlaceOfBirth", _PlaceOfBirth.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@AppNation", _AppNation.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ResAdd1", _ResAdd1.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ResAdd2", _ResAdd2.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ResAdd3", _ResAdd3.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContactNo", _ContactNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@EntryType", _EntryType.Trim().Replace("'", ""));
                //EntryType Com.Parameters.AddWithValue("@VisaStatus", "0" );

                Com.Parameters.AddWithValue("@STRFromDt", _STRFromDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@StrToDt", _StrToDt.ToString("dd/MMM/yyyy"));

                Com.Parameters.AddWithValue("@RefNo", _RefNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@STJVisaNo", _STJVisaNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@STRCompNm", _STRCompNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@STRAdd1", _STRAdd1.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@STRAdd2", _STRAdd2.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@STREQP", _STREQP.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@STRRefNo", _STRRefNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@StrNoMn", _StrNoMn);
                Com.Parameters.AddWithValue("@StrNoYear", _StrNoYear);
                Com.Parameters.AddWithValue("@VisaStatus", _VisaStatus);
                //RefNo, STJVisaNo,STRCompNm,STRAdd1,STRAdd2,STREQP,STRRefNo,STRFromDt,StrToDt,StrNoMn,StrNoYear

                Com.Parameters.AddWithValue("@RcptNo", _RcptNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@RcptDt", _RcptDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@RcptAmt", _RcptAmt);
                Com.Parameters.AddWithValue("@NCopmNm", _NCopmNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NCompAdd1", _NCompAdd1.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NCompAdd2", _NCompAdd2.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NCompCnt", _NCompCnt.Trim().Replace("'", ""));
                //" RcptNo,RcptDt,RcptAmt,NCopmNm,NCompAdd1,NCompAdd2,NCompCnt,"
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
                    " PasportNo=@PasportNo,PIssDt=@PIssDt,PExpDt=@PExpDt,PIssLocation=@PIssLocation,PIssCountry=@PIssCountry,Occupation=@Occupation," +
                    " PerNm=@PerNm,FirstNm=@FirstNm,MidNm=@MidNm,LastNm=@LastNm,Gender=@Gender,MarStatus=@MarStatus,DOB=@DOB,AppNation=@AppNation," +
                    " PlaceOfBirth=@PlaceOfBirth,ResAdd1=@ResAdd1,ResAdd2=@ResAdd2,ResAdd3=@ResAdd3,ContactNo=@ContactNo," +
                    " RefNo=@RefNo, STJVisaNo=@STJVisaNo,STRCompNm=@STRCompNm,STRAdd1=@STRAdd1,STRAdd2=@STRAdd2," +
                    " STREQP=@STREQP,STRRefNo=@STRRefNo,STRFromDt=@STRFromDt,StrToDt=@StrToDt,StrNoMn=@StrNoMn,StrNoYear=@StrNoYear, " +
                    " RcptNo=@RcptNo,RcptDt=@RcptDt,RcptAmt=@RcptAmt,NCopmNm=@NCopmNm,NCompAdd1=@NCompAdd1,NCompAdd2=@NCompAdd2,NCompCnt=@NCompCnt, " +
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
                Com.Parameters.AddWithValue("@Occupation", _Occupation);
                Com.Parameters.AddWithValue("@MarStatus", _MarStatus.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@DOB", _DOB.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@PlaceOfBirth", _PlaceOfBirth.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@AppNation", _AppNation.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ResAdd1", _ResAdd1.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ResAdd2", _ResAdd2.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ResAdd3", _ResAdd3.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@ContactNo", _ContactNo.Trim().Replace("'", ""));

                Com.Parameters.AddWithValue("@STRFromDt", _STRFromDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@StrToDt", _StrToDt.ToString("dd/MMM/yyyy"));

                Com.Parameters.AddWithValue("@RefNo", _RefNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@STJVisaNo", _STJVisaNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@STRCompNm", _STRCompNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@STRAdd1", _STRAdd1.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@STRAdd2", _STRAdd2.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@STREQP", _STREQP.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@STRRefNo", _STRRefNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@StrNoMn", _StrNoMn);
                Com.Parameters.AddWithValue("@StrNoYear", _StrNoYear);

                Com.Parameters.AddWithValue("@RcptNo", _RcptNo.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@RcptDt", _RcptDt.ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@RcptAmt", _RcptAmt);
                Com.Parameters.AddWithValue("@NCopmNm", _NCopmNm.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NCompAdd1", _NCompAdd1.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NCompAdd2", _NCompAdd2.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@NCompCnt", _NCompCnt.Trim().Replace("'", ""));

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
        public void Fn_SaveVisaRej()
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            if (_RSLNO.Trim() == "")
            {
                SQL = "Insert VisaCancelRes(VisaID,SrNo,CanRes,IsActive,UpdateBy,LastDate) Values " +
                    "(@VisaID,@SrNo,@CanRes,@IsActive,@UpdateBy,@LastDate)";

                Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VisaID", _RMLNO.Trim().Replace("'", ""));
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
                SQL = "Update VisaCancelRes Set   " +
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

        public DataView DV_RetGridViewVisa()
        {
            SQL = "Select SLNO,SrNo,CanRes,IsActive from VisaCancelRes Where VisaID=@VisaID order By SrNo";
            DataView DVMG = new DataView();
            DataSet dsMG = new DataSet();
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@VisaID", _RMLNO.Trim().Replace("'", ""));
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
            SQL = "Select * from VisaCancelRes Where SLNO=@SLNO";
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
                _RWhy = dtC.Rows[0]["CanRes"].ToString();

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
