using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
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
            if (SLNO.Trim() == "") { SLNO = "0"; }
            string FileExt = Path.GetExtension(varFilePath);
            SQL = "PrcSaveImageRetFileSystem";
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.CommandType = CommandType.StoredProcedure;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@SLNO", SLNO.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@VisaID", VisaID.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@FileType", FileExt.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@FileName", FileName.Trim().Replace("'", ""));
            Com.Parameters.Add("@FilePath", SqlDbType.VarBinary, file.Length).Value = file;
            Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID); 
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
            Conn.Close();
             
             

           
        }
        public Boolean Fn_ValFrwd(string varID)
        {
            Boolean SSRet = false; 
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            SQL = "Select FileName from VisaFiles Where  VisaID = @varID";
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@varID", varID.Trim().Replace("'", ""));
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
            
            Conn.Close();
            return SSRet;
        }
        public Boolean Fn_ValRej(string varID)
        {
            Boolean SSRet = false;
            //VisaCancelRes(VisaID
            SQL = "Select VisaID from VisaCancelRes Where  VisaID = @varID";
            Conn.ConnectionString = ConStr;
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@varID", varID.Trim().Replace("'", ""));
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
        public void databaseFileUploadPassport(string varFilePath, string VisaID, string FileName, string SLNO)
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
            if (SLNO.Trim() == "") { SLNO = "0"; }
            SQL = "PrcSaveImageRetFilePassportFiles";
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.CommandType = CommandType.StoredProcedure;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@SLNO", SLNO.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@PassportID", VisaID.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@FileType", FileExt.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@FileName", FileName.Trim().Replace("'", ""));
            Com.Parameters.Add("@FilePath", SqlDbType.VarBinary, file.Length).Value = file;
            Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
            Conn.Close();

            //if (SLNO.Trim() == "")
            //{
            //    SQL = "Insert Into PassportFiles(PassportID,FileType,FileName,FilePath,UpdateBy,LastDate ) " +
            //       " Values(@VisaID,@FileType,@FileName,@FilePath,@UpdateBy,@LastDate )";
            //    Com.Connection = Conn;
            //    Com.CommandText = SQL;
            //    Com.Parameters.Clear();
            //    Com.Parameters.AddWithValue("@VisaID", VisaID.Trim().Replace("'", ""));
            //    Com.Parameters.AddWithValue("@FileType", FileExt.Trim().Replace("'", ""));
            //    Com.Parameters.AddWithValue("@FileName", FileName.Trim().Replace("'", ""));
            //    Com.Parameters.Add("@FilePath", SqlDbType.VarBinary, file.Length).Value = file;
            //    Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
            //    Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());

            //}
            //else
            //{
            //    SQL = "Update PassportFiles Set FileType=@FileType,FileName=@FileName," +
            //        " FilePath=@FilePath,UpdateBy=@UpdateBy,LastDate=@LastDate  " +
            //     " Where SLNO=@SLNO ";
            //    Com.Connection = Conn;
            //    Com.CommandText = SQL;
            //    Com.Parameters.Clear();
            //    Com.Parameters.AddWithValue("@SLNO", SLNO.Trim().Replace("'", ""));
            //    Com.Parameters.AddWithValue("@FileType", FileExt.Trim().Replace("'", ""));
            //    Com.Parameters.AddWithValue("@FileName", FileName.Trim().Replace("'", ""));
            //    Com.Parameters.Add("@FilePath", SqlDbType.VarBinary, file.Length).Value = file;
            //    Com.Parameters.AddWithValue("@UpdateBy", GlobalFunction.L_LoginID);
            //    Com.Parameters.AddWithValue("@LastDate", GlobalFunction.Fn_GetCurrentDateTime());

            //}

            //Com.ExecuteNonQuery();
            //Com.Parameters.Clear();
            //Com.Dispose();
           // Conn.Close();



        }



        public void databasevisaFileDelete( string VisaID,  string SLNO)
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            SQL = "PrcRomoveImageRetFileSystem";
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.CommandType = CommandType.StoredProcedure;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@SLNO", SLNO.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@VisaID", VisaID.Trim().Replace("'", ""));
           
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
            Conn.Close();
        }
        public void databasePassportFileDelete(string VisaID, string SLNO)
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            SQL = "PrcRomoveImageRetFileSystemPassport";
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.CommandType = CommandType.StoredProcedure;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@SLNO", SLNO.Trim().Replace("'", ""));
            Com.Parameters.AddWithValue("@VisaID", VisaID.Trim().Replace("'", ""));

            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
            Conn.Close();
        }



        public Boolean Fn_ValFrwdPassport(string varID)
        {
            Boolean SSRet = false;
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            SQL = "Select FileName from PassportFiles Where  PassportID = @varID";
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@varID", varID.Trim().Replace("'", ""));
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

            Conn.Close();
            return SSRet;
        }
        public void databaseFileReadPassport(string varID, ref string varPathToNewLocation)
        {
            try
            {
                string FileNm = "";
                string FileExt = "";
                string FolderNm = "";
                if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
                SQL = "Select FileType,FileName, FolderNm from PassportFiles Where  SLNO = @varID";
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
                    FolderNm = dtC.Rows[0]["FolderNm"].ToString();
                }
                Com.Dispose();
                DataAdapter.Dispose();
                Com.Parameters.Clear();
                dtC.Clear();
                varPathToNewLocation = @"C:\AA\" + FileNm.Trim() + FileExt.Trim();
                string path = Application.StartupPath;
                string myDirPath = path + "\\DMS\\";

                string SQLExc = "(SELECT * FROM OPENROWSET(BULK N'" + FolderNm.Trim() + "P_" + varID.Trim() + FileExt + "', SINGLE_BLOB) as imagefile)";


                varPathToNewLocation = myDirPath + FileNm.Trim() + FileExt.Trim();
                using (var sqlQuery = new SqlCommand(@SQLExc, Conn))
                { 
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
            catch
            { Conn.Close(); }
        }
        public MemoryStream databaseFileReadPassport(string varID)
        {
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            MemoryStream memoryStream = new MemoryStream();
            //using (var varConnection = Locale.sqlConnectOneTime(Locale.sqlDataConnectionDetails))
            using (var sqlQuery = new SqlCommand(@"SELECT FilePath as RaportPlik FROM PassportFiles WHERE SLNO = @varID", Conn))
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
        public  void databaseFileRead(string varID,ref string varPathToNewLocation)
        {
            try
            {
                string FileNm = "";
                string FileExt = "";
                string FolderNm = "";
                if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
                SQL = "Select FileType,FileName,FolderNm from VisaFiles Where  SLNO = @varID";
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
                    FolderNm = dtC.Rows[0]["FolderNm"].ToString();
                }
                Com.Dispose();
                DataAdapter.Dispose();
                Com.Parameters.Clear();
                dtC.Clear();
                string path = Application.StartupPath;
                string myDirPath = path + "\\DMS\\";
                string SQLExc = "(SELECT * FROM OPENROWSET(BULK N'" + FolderNm.Trim() + "V_" + varID.Trim() + FileExt + "', SINGLE_BLOB) as imagefile)";


                varPathToNewLocation = myDirPath + FileNm.Trim() + FileExt.Trim();
                using (var sqlQuery = new SqlCommand(@SQLExc, Conn))
                { 
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
            catch
            { Conn.Close(); }
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
        public void Fn_ScaneFilesAddNew(string FilePath)
        {
            string CompNm = System.Environment.MachineName.ToString();
            SQL = "Insert Into ScaneFiles(CompName,FIleNm,FilePath) " +
                " Values(@CompName,'',@FIlePath)";
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@CompName", CompNm.Trim().Replace("'", "`"));
            Com.Parameters.AddWithValue("@FIlePath", FilePath.Trim().Replace("'", "`"));

            Com.CommandText = SQL;
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
            Conn.Close();

        }
        public void Fn_ScaneFilesDelete()
        {
            string CompNm = System.Environment.MachineName.ToString();
            SQL = "Delete from ScaneFiles Where CompName=@CompName";
            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            Com.Connection = Conn;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@CompName", CompNm.Trim().Replace("'", "`"));

            Com.CommandText = SQL;
            Com.ExecuteNonQuery();
            Com.Parameters.Clear();
            Com.Dispose();
            Conn.Close();
        }



        public void Fn_checkstatus(string varID,  ref string filestatus)
        {

            if (Conn.State == ConnectionState.Closed) { Conn.ConnectionString = ConStr; Conn.Open(); }
            SQL = "Select visastatus from Visaapp Where  VisaID = @varID";
            Com.Connection = Conn;
            Com.CommandText = SQL;
            Com.Parameters.Clear();
            Com.Parameters.AddWithValue("@varID", varID.Trim().Replace("'", ""));
            DataAdapter.SelectCommand = Com;
            DataAdapter.Fill(dtC);
            if (dtC.Rows.Count > 0)
            {
                filestatus = dtC.Rows[0]["visastatus"].ToString();
                //FileNm = dtC.Rows[0]["FileName"].ToString();
                //FolderNm = dtC.Rows[0]["FolderNm"].ToString();
            }
            Com.Dispose();
            DataAdapter.Dispose();
            Com.Parameters.Clear();
            dtC.Clear();

        }
    }

}
