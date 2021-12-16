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
    class ClassDocumentLock
    {
        string ConStr = GlobalFunction.ConStr;
        string SQL;
        SqlConnection Conn = new SqlConnection();
        SqlCommand Com = new SqlCommand();
        SqlDataAdapter DataAdapter = new SqlDataAdapter();
        DataTable dtC = new DataTable();
        DataSet Ds = new DataSet();
        DataTable Dt = new DataTable("DTabel");

        private void Fn_UpdateLock(string StrRecordType, string StrRecordID, string StrLock)
        {
            SQL = "Update DocumentLock Set ScreenLock=@ScreenLock,LastDate=@LastDate,UserID=@UserID,ComputeName=@ComputeName " +
                " Where RecordType=@RecordType and RecordID=@RecordID";
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@RecordType", StrRecordType.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@RecordID", StrRecordID.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@ScreenLock", StrLock.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@ComputeName", System.Net.Dns.GetHostName());
            Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());
            Com.Parameters.AddWithValue("@UserID", GlobalFunction.L_LoginID);

            Com.CommandText = SQL;
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
        }
        private void Fn_InsertLock(string StrRecordType, string StrRecordID, string StrLock)
        {
            SQL = "Insert Into DocumentLock  (ScreenLock,LastDate,UserID,RecordType,RecordID,ComputeName) Values " +
                "(@ScreenLock,@LastDate,@UserID,@RecordType,@RecordID,@ComputeName) ";
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@RecordType", StrRecordType.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@RecordID", StrRecordID.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@ScreenLock", StrLock.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@ComputeName", System.Net.Dns.GetHostName());
            Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());
            Com.Parameters.AddWithValue("@UserID", GlobalFunction.L_LoginID);

            Com.CommandText = SQL;
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
        }
        public void Fn_CheckLock(string StrRecordType, string StrRecordID, string StrLock, ref string StrRet)
        {
            StrRet = "";
            string StrClinMachineName = System.Net.Dns.GetHostName();

            string StrUserID = "";
            string StrCompNm = System.Net.Dns.GetHostName().Trim();
            DateTime DtLastUpdate = GlobalFunction.Fn_GetCurrentDateTime();
            DateTime DtCurrent = GlobalFunction.Fn_GetCurrentDateTime();
            Conn.ConnectionString = ConStr;
            Conn.Open();
            if (StrLock == "O")
            {
                Fn_UpdateLock(StrRecordType, StrRecordID, "N");
            }
            else
            {

                string StrDocLock = "N";
                string StrIsRecord = "N";
                SQL = "Select * from DocumentLock Where RecordType=@StrRecordType And RecordID=@RecordID";
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@StrRecordType", StrRecordType.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@RecordID", StrRecordID.Trim().Replace("'", ""));
                DataAdapter.SelectCommand = Com;
                DataAdapter.Fill(dtC);
                if (dtC.Rows.Count > 0)
                {
                    StrIsRecord = "Y";
                    DtLastUpdate = Convert.ToDateTime(dtC.Rows[0]["LastDate"].ToString());
                    StrDocLock = dtC.Rows[0]["ScreenLock"].ToString();
                    StrUserID = dtC.Rows[0]["UserID"].ToString();
                    StrCompNm = dtC.Rows[0]["ComputeName"].ToString().Trim();
                }
                Com.Dispose();
                DataAdapter.Dispose();
                Com.Parameters.Clear();
                dtC.Clear();
                if (StrIsRecord == "N")
                { Fn_InsertLock(StrRecordType, StrRecordID, "Y"); }
                else
                {
                    if (StrDocLock == "N")
                    { Fn_UpdateLock(StrRecordType, StrRecordID, "Y"); }
                    else
                    {
                        double TimeDiff = DtCurrent.Subtract(DtLastUpdate).TotalMinutes;
                        if ((StrClinMachineName != StrCompNm) && (TimeDiff < 15))
                        {
                            StrRet = "En cours de traitement par  " + StrCompNm + "." + " Location " + GlobalFunction.L_LocationName;
                        }

                    }

                }
            }
            Conn.Close();


        }
    }
}
