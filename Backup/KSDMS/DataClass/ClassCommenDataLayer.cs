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

    class ClassCommenDataLayer
    {
        string ConStr = GlobalFunction.ConStr;
        string SQL;
        SqlConnection Conn = new SqlConnection();
        SqlCommand Com = new SqlCommand();
        SqlDataAdapter DataAdapter = new SqlDataAdapter();
        DataTable dtC = new DataTable();
        DataSet Ds = new DataSet();
        DataTable Dt = new DataTable("DTabel");
        public DataView DL_DataViewSQLNew(string SQLNN)
        {
            SQL = SQLNN;
            DataView DVMG = new DataView();
            DataSet dsMG = new DataSet();
            Conn.ConnectionString = ConStr;
            if (Conn.State == ConnectionState.Closed) { Conn.Open(); }
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
        public string Fn_WorkDone(int StrLoc)
        {
            string StrRet = "";
            Conn.ConnectionString = ConStr;
            Conn.Open();
            Com.Connection = Conn;

            Com.Parameters.Clear();
            if (StrLoc == 0)
            {
                SQL = "Select IsNull((Count(RecvID)),0) as CT, IsNull((Sum(TotalPayable)),0) as AMT from ReceiveDirectMaster " +
                    " Where IsActive='Y' and  ReceptionDt>=@RecvDT1 And ReceptionDt<=@RecvDT2  and ReceptionID=@ReceptionID";
                Com.Parameters.AddWithValue("@ReceptionID", GlobalFunction.L_LoginID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@RecvDT1", GlobalFunction.Fn_GetCurrentDateTime().ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@RecvDT2", GlobalFunction.Fn_GetCurrentDateTime().AddDays(1).ToString("dd/MMM/yyyy"));
            }
            if (StrLoc == 1)
            {
                SQL = "Select IsNull((Count(RecvID)),0) as CT, IsNull((Sum(TotalPayable)),0) as AMT from ReceiveDirectMaster " +
                    " Where IsActive='Y' and  AccountDt>=@RecvDT1 And AccountDt<=@RecvDT2 and RStatus>3 and LocationID=@LocationID ";
                Com.Parameters.AddWithValue("@RecvDT1", GlobalFunction.Fn_GetCurrentDateTime().ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@RecvDT2", GlobalFunction.Fn_GetCurrentDateTime().AddDays(1).ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@LocationID", GlobalFunction.L_LocationID);
            }
            if (StrLoc == 2)
            {
                SQL = "Select IsNull((Count(RecvID)),0) as CT, IsNull((Sum(TotalPayable)),0) as AMT from ReceiveDirectMaster " +
                    " Where IsActive='Y' and  AccountDt>=@RecvDT1 And AccountDt<=@RecvDT2 and RStatus>3 and LocationID=@LocationID ";
                Com.Parameters.AddWithValue("@RecvDT1", GlobalFunction.Fn_GetCurrentDateTime().ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@RecvDT2", GlobalFunction.Fn_GetCurrentDateTime().AddDays(1).ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@LocationID", GlobalFunction.L_LocationID);
            }
            if (StrLoc == 3)
            {
                SQL = "Select IsNull((Count(RecvID)),0) as CT, IsNull((Sum(TotalPayable)),0) as AMT from ReceiveDirectMaster " +
                    " Where IsActive='Y' and  AccountDt>=@RecvDT1 And AccountDt<=@RecvDT2  and AccountID=@ReceptionID and  RStatus>3  ";
                Com.Parameters.AddWithValue("@ReceptionID", GlobalFunction.L_LoginID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@RecvDT1", GlobalFunction.Fn_GetCurrentDateTime().ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@RecvDT2", GlobalFunction.Fn_GetCurrentDateTime().AddDays(1).ToString("dd/MMM/yyyy"));
            }
            if (StrLoc == 4)
            {
                SQL = "Select IsNull((Count(RecvID)),0) as CT, IsNull((Sum(TotalPayable)),0) as AMT from ReceiveDirectMaster " +
                    " Where IsActive='Y' and  PrintDt>=@RecvDT1 And PrintDt<=@RecvDT2  and PrintID=@ReceptionID  and RStatus>3";
                Com.Parameters.AddWithValue("@ReceptionID", GlobalFunction.L_LoginID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@RecvDT1", GlobalFunction.Fn_GetCurrentDateTime().ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@RecvDT2", GlobalFunction.Fn_GetCurrentDateTime().AddDays(1).ToString("dd/MMM/yyyy"));
            }
            if (StrLoc == 5)
            {
                SQL = "Select IsNull((Count(RecvID)),0) as CT, IsNull((Sum(TotalPayable)),0) as AMT from ReceiveDirectMaster " +
                    " Where IsActive='Y' and  AccountDt>=@RecvDT1 And AccountDt<=@RecvDT2  and Upload=@ReceptionID  and RStatus>3";
                Com.Parameters.AddWithValue("@ReceptionID", GlobalFunction.L_LoginID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@RecvDT1", GlobalFunction.Fn_GetCurrentDateTime().ToString("dd/MMM/yyyy"));
                Com.Parameters.AddWithValue("@RecvDT2", GlobalFunction.Fn_GetCurrentDateTime().AddDays(1).ToString("dd/MMM/yyyy"));
            }

            Com.CommandText = SQL;
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                StrRet = "Total Count : " + Convert.ToDouble(dtC.Rows[0]["CT"].ToString()).ToString("000");
                StrRet = StrRet + ", Total Amount : " + Convert.ToDouble(dtC.Rows[0]["AMT"].ToString()).ToString();
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            Conn.Close();
            return StrRet;

        }

    }
}
