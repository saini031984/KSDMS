using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Diagnostics; 

namespace Report
{
    class ClassReport
    {
        // string ConStr = @"Server=DELL-PC\SQLEXPRESS;Database=DMS; Integrated Security=True";
       string ConStr = @"server=NIGSERVER\SQLEXPRESS;database=DMSNEW;uid=sa;pwd=ksds@123";
      // string ConStr = "server=127.0.0.1;database=DMS;uid=sa;pwd=tech";
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
        public void Fn_GetReportType(ref string StrRptType, ref string StrRptTitle, ref string StrRptSQL)
        {
            string StrCompNm = System.Environment.MachineName.ToString().Trim();
            StrRptType = "";
            StrRptTitle = "";
            StrRptSQL = "";

            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            SQL = "Select Top 1 * from PrintReport Where CompName=@CompName Order By SLNO DESC";
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@CompName", StrCompNm.Trim().Replace("'", "`"));
            Com.CommandText = SQL;
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count>0)
            {
                StrRptType = dtC.Rows[0]["RptType"].ToString().Trim().Replace("`", "'");
                StrRptTitle = dtC.Rows[0]["RptTitle"].ToString().Trim().Replace("`", "'");
                StrRptSQL = dtC.Rows[0]["RptSQL"].ToString().Trim().Replace("`", "'");

            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();


            SQL = "Delete from PrintReport Where CompName=@CompName ";
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@CompName", StrCompNm.Trim().Replace("'", "`"));
            Com.CommandText = SQL;
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
            Conn.Close();


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
        public void Fn_ShowReportPassport(string StrReqSQL)
        {
            string StrName = "";
            string StrDetail = "";



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

                SQlInsert = SQlInsert + " INSERT INTO #ReportTab (SLNO,Db1,Db2," +
                    "Dt1," +
                    " Str1,Str2,Str3,Str4,Str5,Str6,Str7,Str8,Str9) VALUES(";

                SQlInsert = SQlInsert + "" + dtC.Rows[I]["PassportID"].ToString() + ",";
                SQlInsert = SQlInsert + "" + (I+1).ToString()+ ",";
                SQlInsert = SQlInsert + "" + dtC.Rows[I]["AMT"].ToString() + ",";
                //PntAmt
                SQlInsert = SQlInsert + "'" + dtC.Rows[I]["IssueDt"].ToString() + "',";

                SQlInsert = SQlInsert + "'" + dtC.Rows[I]["Embassy"].ToString() + "'," +
                    "'" + dtC.Rows[I]["PassportNo"].ToString() + "'," +
                    "'" + dtC.Rows[I]["AppNm"].ToString() + "'," +
                    "'" + dtC.Rows[I]["Gender"].ToString() + "'," +
                    "'" + dtC.Rows[I]["Address"].ToString() + "'," +
                    "'" + dtC.Rows[I]["EnrolmentNo"].ToString() + "'," +
                    "'" + dtC.Rows[I]["AppID"].ToString() + "'," +
                    "'" + dtC.Rows[I]["RefNo"].ToString() + "'," +
                    "'" + dtC.Rows[I]["Remarks"].ToString() + "'" +
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
        public void Fn_ShowReportVisa(string StrReqSQL)
        {
            string StrName = "";
            string StrDetail = "";

            

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
                StrName = dtC.Rows[I]["LastNm"].ToString().Trim().ToUpper() + " " + dtC.Rows[I]["FirstNm"].ToString().Trim().ToUpper() + " " + dtC.Rows[I]["MidNm"].ToString().Trim().ToUpper();


                if (dtC.Rows[I]["VisaType"].ToString().Trim() == "2")
                {
                    StrDetail = dtC.Rows[I]["STRCompNm"].ToString().Trim().ToUpper() + " " + dtC.Rows[I]["STRAdd1"].ToString().Trim().ToUpper() + " " + dtC.Rows[I]["STRAdd2"].ToString().Trim().ToUpper() + " EQP-" + dtC.Rows[I]["STREQP"].ToString().Trim().ToUpper();
                    StrDetail = StrDetail + " REF:" + dtC.Rows[I]["STRRefNo"].ToString().Trim();
                    StrDetail = StrDetail + " DT " +Convert.ToDateTime(dtC.Rows[I]["STRFromDt"].ToString().Trim()).ToString("dd-MMM-yyyy");
                    StrDetail = StrDetail + " FOR " + dtC.Rows[I]["StrNoYear"].ToString().Trim() + " YRS";
                    StrDetail = StrDetail + " W.E.F. " + Convert.ToDateTime(dtC.Rows[I]["StrToDt"].ToString().Trim()).ToString("dd-MMM-yyyy");
                }
                else if (dtC.Rows[I]["VisaType"].ToString().Trim() == "3")
                {
                    StrDetail = "STR VISA No." + dtC.Rows[I]["STJVisaNo"].ToString().Trim().ToUpper();
                    StrDetail = StrDetail + dtC.Rows[I]["STRCompNm"].ToString().Trim().ToUpper() + " " + dtC.Rows[I]["STRAdd1"].ToString().Trim().ToUpper() + " " + dtC.Rows[I]["STRAdd2"].ToString().Trim().ToUpper() + " EQP-" + dtC.Rows[I]["STREQP"].ToString().Trim().ToUpper();
                    StrDetail = StrDetail + " REF:" + dtC.Rows[I]["STRRefNo"].ToString().Trim();
                    StrDetail = StrDetail + " DT " + Convert.ToDateTime(dtC.Rows[I]["STRFromDt"].ToString().Trim()).ToString("dd-MMM-yyyy");
                    StrDetail = StrDetail + " FOR " + dtC.Rows[I]["StrNoYear"].ToString().Trim() + " YRS";
                    StrDetail = StrDetail + " W.E.F. " + Convert.ToDateTime(dtC.Rows[I]["StrToDt"].ToString().Trim()).ToString("dd-MMM-yyyy");
                }
                else
                {
                    StrDetail = dtC.Rows[I]["NCopmNm"].ToString().Trim().ToUpper() + " " + dtC.Rows[I]["NCompAdd1"].ToString().Trim().ToUpper() + " " + dtC.Rows[I]["NCompAdd2"].ToString().Trim().ToUpper() + " " + dtC.Rows[I]["NCompCnt"].ToString().Trim().ToUpper();
                }
                SQlInsert = SQlInsert + " INSERT INTO #ReportTab (SLNO," +
                    "Dt1," +
                    " Db1," +
                    " Str1,Str2,Str3,Str4,Str5,Str6,Str7,Str8,Str9,Str10) VALUES(" +
                    "" + (I+1).ToString() + ",";

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
        public void Fn_ShowReportVisaSum(string StrReqSQL)
        {
            string StrName = "";
            string StrDetail = "";



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
                
                SQlInsert = SQlInsert + " INSERT INTO #ReportTab (" +
                    " Db1,Db2," +
                    " Str1) VALUES(" +
                    "" + dtC.Rows[I]["CT"].ToString() + "," +
                    "" + dtC.Rows[I]["AMT"].ToString() + "," +
                    "'" + dtC.Rows[I]["VisaTNm"].ToString() + "'" + 
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
