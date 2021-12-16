using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace KSDMS.DataClass
{
    class ClassDMS
    {
        string ConStr = GlobalFunction.ConStr;
        string SQL;
        SqlConnection Conn = new SqlConnection();
        SqlCommand Com = new SqlCommand();
        SqlDataAdapter DataAdapter = new SqlDataAdapter();
        DataTable dtC = new DataTable();
        DataSet Ds = new DataSet();
        DataTable Dt = new DataTable("DTabel");
        public void databaseFileUpload(string varFilePath, string VisaID, string FileName, string SLNO)
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            byte[] file;
            using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }
            string FileExt = Path.GetExtension(varFilePath);
            if (SLNO.Trim() == "")
            {
                SQL = "Insert Into VisaFiles(VisaID,FileType,FileName,FilePath,UpdateBy,LastDate ) " +
                   " Values(@VisaID,@FileType,@FileName,@FilePath,@UpdateBy,@LastDate )";
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@VisaID", VisaID.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@FileType", FileExt.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@FileName", FileName.Trim().Replace("'", ""));
                Com.Parameters.Add("@FilePath", SqlDbType.VarBinary, file.Length).Value = file;
                Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
                Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());

            }
            else
            {
                SQL = "Update VisaFiles Set FileType=@FileType,FileName=@FileName," +
                    " FilePath=@FilePath,UpdateBy=@UpdateBy,LastDate=@LastDate  " +
                 " Where SLNO=@SLNO ";
                Com.Connection = Conn;
                Com.CommandText = SQL;
                Com.Parameters.Clear();
                Com.Parameters.AddWithValue("@SLNO", SLNO.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@FileType", FileExt.Trim().Replace("'", ""));
                Com.Parameters.AddWithValue("@FileName", FileName.Trim().Replace("'", ""));
                Com.Parameters.Add("@FilePath", SqlDbType.VarBinary, file.Length).Value = file;
                Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
                Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());
            
            }
            
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
            Conn.Close();
             

           
        }
        public  void databaseFileRead(string varID,ref string varPathToNewLocation)
        {
             
            string FileNm = "";
            string FileExt = "";
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            SQL = "Select FileType,FileName from VisaFiles Where  SLNO = @varID";
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@varID", varID.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                FileExt = dtC.Rows[0]["FileType"].ToString();
                FileNm = dtC.Rows[0]["FileName"].ToString();
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();
            varPathToNewLocation = @"C:\AA\" + FileNm.Trim() + FileExt.Trim();
            using (var sqlQuery = new SqlCommand(@"SELECT FilePath as RaportPlik FROM VisaFiles WHERE SLNO = @varID", Conn))
            {
                sqlQuery.Parameters.AddWithValue("@varID", varID);
                using (var sqlQueryResult = sqlQuery.ExecuteReader())
                    if (sqlQueryResult != null)
                    {
                        sqlQueryResult.Read();
                        var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                        sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                        using (var fs = new FileStream(varPathToNewLocation, FileMode.Create, FileAccess.Write))
                            fs.Write(blob, 0, blob.Length);
                    }
            }
            Conn.Close();
        }
        public  MemoryStream databaseFileRead(string varID)
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            MemoryStream memoryStream = new MemoryStream();
            //using (var varConnection = Locale.sqlConnectOneTime(Locale.sqlDataConnectionDetails))
            using (var sqlQuery = new SqlCommand(@"SELECT FilePath as RaportPlik FROM VisaFiles WHERE SLNO = @varID", Conn))
            {
                sqlQuery.Parameters.AddWithValue("@varID", varID);
                using (var sqlQueryResult = sqlQuery.ExecuteReader())
                    if (sqlQueryResult != null)
                    {
                        sqlQueryResult.Read();
                        var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                        sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                        //using (var fs = new MemoryStream(memoryStream, FileMode.Create, FileAccess.Write)) {
                        memoryStream.Write(blob, 0, blob.Length);
                        //}
                    }
            }
            Conn.Close();
            return memoryStream;
        }
        public  int databaseFilePut(MemoryStream fileToPut)
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            int varID = 0;
            byte[] file = fileToPut.ToArray();
            const string preparedCommand = @"
                                INSERT INTO [dbo].[Raporty]
                                           ([RaportPlik])
                                     VALUES
                                           (@File)
                                    SELECT [RaportID] FROM [dbo].[Raporty]
                        WHERE [RaportID] = SCOPE_IDENTITY()
                                ";
            //using (var varConnection = Locale.sqlConnectOneTime(Locale.sqlDataConnectionDetails))
            using (var sqlWrite = new SqlCommand(preparedCommand, Conn))
            {
                sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;

                using (var sqlWriteQuery = sqlWrite.ExecuteReader())
                    while (sqlWriteQuery != null && sqlWriteQuery.Read())
                    {
                        varID = sqlWriteQuery["RaportID"] is int ? (int)sqlWriteQuery["RaportID"] : 0;
                    }
            }
            return varID;
        }
    }

}
