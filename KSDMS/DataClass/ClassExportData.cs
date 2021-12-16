using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
namespace KSDMS.DataClass
{
    class ClassExportData
    {
        string ConStr = GlobalFunction.ConStr;
        string SQL;
        SqlConnection Conn = new SqlConnection();
        SqlCommand Com = new SqlCommand();
        SqlDataAdapter DataAdapter = new SqlDataAdapter(); 
        DataSet Ds = new DataSet(); 
        public void Fn_ExportData(string SQLExport)
        {
            SQLExport = "SELECT ParamDetail.PDetailName as FN, VisaApp.FirstNm, VisaApp.MidNm, VisaApp.LastNm,VisaApp.Gender, GeoCountryMaster.CountName as StrNation," +
                   " VisaApp.VisaNo,VisaApp.VisaDT,IsNull(VisaApp.RcptAmt,0) as RcptAmt,VisaApp.PasportNo,VisaType.VisaTNm," +
                   " VisaApp.VisaID, GeoCountryMaster.CountName, VisaType.VisaTNm, VisaApp.AppNoStr, VisaApp.AppDt, VisaApp.PasportNo, VisaApp.NoOfEnt,VisaApp.RefNo," +
               " VisaApp.STRCompNm, VisaApp.STRAdd1, VisaApp.STRAdd2, VisaApp.STREQP, VisaApp.STRRefNo, VisaApp.STRFromDt, " +
               " VisaApp.StrToDt, VisaApp.StrNoMn, VisaApp.StrNoYear, VisaApp.EntryType, VisaApp.RcptNo, VisaApp.RcptDt, VisaApp.RcptAmt, " +
               " VisaApp.NCopmNm, VisaApp.NCompAdd1, VisaApp.NCompAdd2, VisaApp.NCompCnt " +
               " FROM VisaApp INNER JOIN " +
               " GeoCountryMaster ON VisaApp.PIssCountry = GeoCountryMaster.CountID LEFT OUTER JOIN " +
               " ParamDetail ON VisaApp.PerNm = ParamDetail.PDetailID LEFT OUTER JOIN " +
               " VisaType ON VisaApp.VisaType = VisaType.VTypeID ";

            //Microsoft.Office.Interop.Excel.ApplicationClass ExcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
            //Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
        }
    }
}
