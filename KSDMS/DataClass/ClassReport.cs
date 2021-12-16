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
    class ClassReport
    {
        string ConStr = GlobalFunction.ConStr;
        string SQL;
        SqlConnection Conn = new SqlConnection();
        SqlCommand Com = new SqlCommand();
        SqlDataAdapter DataAdapter = new SqlDataAdapter();
        DataTable dtC = new DataTable();

        SqlConnection Conn1 = new SqlConnection();
        SqlCommand Com1 = new SqlCommand();
        SqlDataAdapter DataAdapter1 = new SqlDataAdapter();
        DataTable dtC1 = new DataTable();

        DataSet Ds = new DataSet();
        DataTable Dt = new DataTable("DTabel");
        public DataTable R_Tab = new DataTable();
        public DataSet R_Ds = new DataSet();
        public DataTable R_TabTax = new DataTable();
        public DataSet R_DsTax = new DataSet();
        public SqlDataReader R_Dr;
        string R_StrTaxCode;
        string R_StrTaxName;
        string R_StrTaxRate;
        string R_StrTaxAmt;

        public void Dt_ShowData(string R_SQL)
        {

            Conn.ConnectionString = ConStr;
            if (Conn.State == ConnectionState.Closed) { Conn.Open(); }

            Com.Connection = Conn;


            Com.CommandText = R_SQL;
            SqlDataAdapter dscmd = new SqlDataAdapter(R_SQL, Conn);
            dscmd.Fill(R_Ds, "Product");
            Conn.Close();

        }
        public void Fn_AddReportType(string RptTitle, string RptType, string RptSQL)
        {
            string CompNm=System.Environment.MachineName.ToString();
            SQL = "Insert Into PrintReport(CompName,RptType,RptTitle,RptSQL) " +
                " Values(@CompName,@RptType,@RptTitle,@RptSQL)";
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
               Com.Connection = Conn;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@CompName", CompNm.Trim().Replace("'", "`"));
                Com.Parameters.AddWithValue("@RptType", RptType.Trim().Replace("'", "`"));
                Com.Parameters.AddWithValue("@RptTitle", RptTitle.Trim().Replace("'", "`"));
                Com.Parameters.AddWithValue("@RptSQL", RptSQL.Trim().Replace("'", "`"));

                Com.CommandText = SQL;
                Com.ExecuteNonQuery();
                Com.Parameters.Clear();
                Com.Dispose();
                Conn.Close();
        
        }
        private void Fn_CreateTampTable()
        {
            SQL = "CREATE table #ReportTab(SLNO numeric(18, 0), Db1 numeric(18, 5), Db2 numeric(18, 5), Db3 numeric(18, 5), Db4 numeric(18, 5), Db5 numeric(18, 5)," +
                    " Db6 numeric(18, 5), Db7 numeric(18, 5),Db8 numeric(18, 5),Db9 numeric(18, 5),Db10 numeric(18, 5)," +
                    " Str1 varchar(1000),Str2 varchar(100),Str3 varchar(1000),Str4 varchar(1000),Str5 varchar(1000), " +
                    " Str6 varchar(1000),Str7 varchar(100),Str8 varchar(1000),Str9 varchar(1000),Str10 varchar(1000), " +
                    " Str11 varchar(1000),Str12 varchar(100),Str13 varchar(1000),Str14 varchar(1000),Str15 varchar(1000), " +
                    " Str16 varchar(1000),Str17 varchar(100),Str18 varchar(1000),Str19 varchar(1000),Str20 varchar(1000), " +
                    " Dt1 datetime,Dt2 datetime,Dt3 datetime,Dt4 datetime,Dt5 datetime, " +
                    " Dt6 datetime,Dt7 datetime,Dt8 datetime,Dt9 datetime,Dt10 datetime); ";

            Com.CommandText = SQL;
            Com.Connection = Conn;
            Com.ExecuteNonQuery();
            Com.Dispose();

        }

        public void Fn_ShowReportVisa(string StrReqSQL)
        {
            string StrName = "";
            string StrDetail = "";

            StrReqSQL = "SELECT ParamDetail.PDetailName as FN, VisaApp.FirstNm, VisaApp.MidNm, VisaApp.LastNm,VisaApp.Gender, GeoCountryMaster.CountName as StrNation," +
                " VisaApp.VisaNo,VisaApp.VisaDT,IsNull(VisaApp.RcptAmt,0) as RcptAmt,VisaApp.PasportNo,VisaType.VisaTNm," +
                " VisaApp.VisaID, GeoCountryMaster.CountName, VisaType.VisaTNm, VisaApp.AppNoStr, VisaApp.AppDt, VisaApp.PasportNo, VisaApp.NoOfEnt,VisaApp.RefNo," +
            " VisaApp.STRCompNm, VisaApp.STRAdd1, VisaApp.STRAdd2, VisaApp.STREQP, VisaApp.STRRefNo, VisaApp.STRFromDt, " +
            " VisaApp.StrToDt, VisaApp.StrNoMn, VisaApp.StrNoYear, VisaApp.EntryType, VisaApp.RcptNo, VisaApp.RcptDt, VisaApp.RcptAmt, " +
            " VisaApp.NCopmNm, VisaApp.NCompAdd1, VisaApp.NCompAdd2, VisaApp.NCompCnt " +
            " FROM VisaApp INNER JOIN " +
            " GeoCountryMaster ON VisaApp.PIssCountry = GeoCountryMaster.CountID LEFT OUTER JOIN " +
            " ParamDetail ON VisaApp.PerNm = ParamDetail.PDetailID LEFT OUTER JOIN " +
            " VisaType ON VisaApp.VisaType = VisaType.VTypeID ";

            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            Fn_CreateTampTable();
            string SQlInsert = "";
            int I = 0;
            SQL = StrReqSQL;
            Com.Connection = Conn;
            Com.CommandText = SQL;
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            for (I = 0; I < dtC.Rows.Count; I++)
            {
                StrName = dtC.Rows[I]["FN"].ToString() + " " + dtC.Rows[I]["FirstNm"].ToString() + " " + dtC.Rows[I]["MidNm"].ToString() + " " + dtC.Rows[I]["LastNm"].ToString();



                SQlInsert = SQlInsert + " INSERT INTO #ReportTab (SLNO," +
                    "Dt1," +
                    " Db1," +
                    " Str1,Str2,Str3,Str4,Str5,Str6,Str7,Str8,Str9,Str10) VALUES(" +
                    "" + (I + 1).ToString() + ",";

                SQlInsert = SQlInsert + "'" + dtC.Rows[I]["VisaDT"].ToString() + "',";
                //PntAmt
                SQlInsert = SQlInsert + "" + dtC.Rows[I]["RcptAmt"].ToString() + ",";

                SQlInsert = SQlInsert + "'" + dtC.Rows[I]["VisaNo"].ToString() + "'," +
                    "'" + dtC.Rows[I]["PasportNo"].ToString() + "'," +
                    "'" + StrName + "'," +
                    "'" + dtC.Rows[I]["Gender"].ToString() + "'," +
                    "'" + StrDetail + "'," +
                    "'" + dtC.Rows[I]["VisaTNm"].ToString() + "'," +
                    "'" + dtC.Rows[I]["StrNation"].ToString() + "'," +
                    "'" + dtC.Rows[I]["AppNoStr"].ToString() + "'," +
                    "'" + dtC.Rows[I]["NoOfEnt"].ToString() + "'," +
                    "'" + dtC.Rows[I]["RefNo"].ToString() + "'" +
                    ")";


            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();


            if (SQlInsert != "")
            {
                Com.CommandText = SQlInsert;
                Com.Connection = Conn;
                Com.ExecuteNonQuery();
                Com.Dispose();

                SQL = "Select * from #ReportTab";
                SqlDataAdapter dscmd = new SqlDataAdapter(SQL, Conn);
                dscmd.Fill(R_Ds, "Product");


            }



            Conn.Close();
        }

      
        //public void Fn_ShowReportGraphDaily(string StrSQL)
        //{
        //    Conn.ConnectionString = ConStr;
        //    if (Conn.State == ConnectionState.Closed) { Conn.Open(); }
        //    Fn_CreateTampTable();
        //    string SQlInsert = "";
        //    int I = 0;
        //    Com.Connection = Conn;
        //    Com.CommandText = StrSQL;
        //    DataAdapter.SelectCommand = Com;
        //    DataAdapter.Fill(dtC);
        //    for (I = 0; I < dtC.Rows.Count; I++)
        //    {

        //        SQlInsert = SQlInsert + " INSERT INTO #ReportTab ( " +
        //            "Str1,  Dbl1 ) VALUES(" +
        //            "'" + dtC.Rows[I]["RecvDt1"].ToString() + "'," +
        //            "" + dtC.Rows[I]["GTot"].ToString() + " );";


        //    }
        //    Com.Dispose();
        //    DataAdapter.Dispose();
        //    Com.Parameters.Clear();
        //    dtC.Clear();

        //    if (SQlInsert != "")
        //    {
        //        Com.CommandText = SQlInsert;
        //        Com.Connection = Conn;
        //        Com.ExecuteNonQuery();
        //        Com.Dispose();

        //        SQL = "Select * from #ReportTab";
        //        SqlDataAdapter dscmd = new SqlDataAdapter(SQL, Conn);
        //        dscmd.Fill(R_Ds, "Product");


        //    }



        //    Conn.Close();
        //}

    }
}
