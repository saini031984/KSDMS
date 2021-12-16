using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Globalization;
using KSDMS.DataClass;

namespace KSDMS.DataClass
{
    public static class GlobalFunction
    {

        public static string L_LoginID;
        public static string L_LoginName;
        public static string L_LocationID;
        public static string L_LocationName;
        public static string L_LocationShort;
        public static string L_LocationCountry;
        public static string L_LocationCountryNm;
        public static string L_Zone;
        public static string L_LocationType;
        public static string L_LangKnow;
        public static string L_DateFormat;
        public static string L_DateTimeFormat;
        public static string L_SoftVer;
        public static string L_IsAdmin;
        public static string ConStr;
        public static string ConStrWeb;
        public static string A_Name;
        public static string L_ReportFilter;
        public static DataTable GL_DT = new DataTable();
        public static DataView GL_DVMG = new DataView();
        public static DataSet GL_DataSet = new DataSet();

        public static DataTable GL_DTMEnuPermit = new DataTable();

        // DataTable Dt = new DataTable("DTabel");

        public static void Fn_GetButtons(string ST, Panel PN)
        {
            ClassButtons BTN = new ClassButtons();
            BTN.Fn_Buttons(ST, PN);
        }
        public static void Fn_ClearForm(Panel PN)
        {
            List<Control> cleanControls = new List<Control>();
            foreach (Control ctr in PN.Controls)
            {
                if (ctr is TextBox) { ctr.Text = ""; ctr.Tag = ""; }
            }
        }
        public static void Fn_SetBackGround(Panel PN)
        {
           // PN.BackColor = Color.Transparent;
            List<Control> cleanControls = new List<Control>();
            foreach (Control ctr in PN.Controls)
            {
                if (ctr is Panel) { ctr.BackColor = Color.Transparent; }
                if (ctr is Panel) { ctr.BackgroundImage = PN.BackgroundImage; }
                if (ctr is Label) { ctr.BackColor = Color.Transparent; }
             }
        }
        public static string toText(string format, long value)
        {
            string str_value = Convert.ToString(value);
            int f_length = format.Length - str_value.Length;
            try { long tmp = Convert.ToInt64(format); if (f_length < 0)throw new Exception("invalid format length."); }
            catch { MessageBox.Show("invalid format, must be like '0000'"); return Convert.ToString(value); }
            string sub = format.Substring(0, f_length);
            return sub + str_value;
        }
        public static string NumbetToWordsCurrency(double Number)
        {
            string StrRet = "";
            string StrNN = Number.ToString("0.00");
            string StrFNum = StrNN.Substring(0, StrNN.Length - 3);
            string StrFSNum = StrNN.Substring(StrNN.Length - 2, 2);

            StrRet = NumberToWords(Convert.ToInt64(StrFNum)) + " CFA";

            if (Convert.ToInt64(StrFSNum) > 0)
            {
                StrRet = StrRet + " & " + NumberToWords(Convert.ToInt64(StrFSNum)) + " Franc";
            }
            StrRet = StrRet + " Only";
            return StrRet;

        }
        public static string NumberToWordsFrench(Int64 number)
        {

            if (number == 0)
                return "zero";
            
            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));
            string words = "";
            if ((number / 10000000) > 0)
            {
                words += NumberToWords(number / 10000000) + " dix millions ";
                number %= 10000000;
            }

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " un million ";
                number %= 1000000;
            }

            if ((number / 100000) > 0)
            {
                words += NumberToWords(number / 100000) + " cent mille ";
                number %= 100000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " mille ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " cent ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "et ";

                var unitsMap = new[] { "zero", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "zeize", "dixsept", "dix huit", "dixneuf" };
                var tensMap = new[] { "zero", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante dix", "quatre vingt", "quatre vingt dix" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }
            ////if (words.Trim().Length > 2)
            ////{
            ////    if (words.Trim().Substring(0, 2) == "un")
            ////    {
            ////        words = words.Trim().Substring(2, words.Trim().Length-2);
            ////    }

            ////    if (words.Trim() == "dix un million") { words = "dix million"; }
            ////}
            ////if (words.Trim().Length > 6)
            ////{
            ////    if ((words.Trim().Contains("un") == true) && (words.Trim().Contains("un million")==false))
            ////    {
            ////        words = words.Trim().Replace("un", " ");
            ////    } 
            ////}
            return words;
        }
        public static string NumberToWords(Int64 number)
        {
            return NumberToWordsFrench(number);
            if (L_LangKnow == "2")
            {
                return NumberToWordsFrench(number);
            }

            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 100000) > 0)
            {
                words += NumberToWords(number / 100000) + " Lac ";
                number %= 100000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
        public static int Fn_GetFinYear()
        {
            int IntRet = Convert.ToInt16(Fn_GetCurrentDateTime().ToString("yyyy"));

            return IntRet;
        }
        public static DateTime Fn_GetCurrentDateTime()
        {
            DateTime CurtDateTime = DateTime.Now;

            return CurtDateTime;
        } 
        public static double Fn_GetSenegalCurrency(double DblNum)
        {
            double DblRet = DblNum;

            //string StrTotalVal = DblNum.ToString("0.00");
            //StrTotalVal = StrTotalVal.Substring(0, StrTotalVal.Length - 3);

            //double DblTotal = Convert.ToDouble(StrTotalVal);
            //string StrLastDigit = StrTotalVal.Substring(StrTotalVal.Length - 1, 1);
            //double DblLastDigit = Convert.ToDouble(StrLastDigit);

            //if (DblLastDigit == 1) { DblTotal = DblTotal + 4; }
            //if (DblLastDigit == 2) { DblTotal = DblTotal + 3; }
            //if (DblLastDigit == 3) { DblTotal = DblTotal + 2; }
            //if (DblLastDigit == 4) { DblTotal = DblTotal + 1; }

            //if (DblLastDigit == 6) { DblTotal = DblTotal + 4; }
            //if (DblLastDigit == 7) { DblTotal = DblTotal + 3; }
            //if (DblLastDigit == 8) { DblTotal = DblTotal + 2; }
            //if (DblLastDigit == 9) { DblTotal = DblTotal + 1; }

            //DblRet = DblTotal;
            return DblRet;

        }
        public static void Popup_CountryList(TextBox TT)
        {
            FrmPopUp FrmP = new FrmPopUp();
            FrmP.HelpSQL = "Select CountID as [000,SLNO], CountName as [200,Name], CountShort  as [100,Code] from GeoCountryMaster Order By CountName";
            FrmP.HelpSearch = "[200,Name]";
            FrmP.ShowDialog();
            TT.Tag = FrmP.HelpSLNO;
            TT.Text = FrmP.HelpText;
        }
        public static void Popup_ParamDetail(TextBox TT, string ParamID)
        {
            FrmPopUp FrmP = new FrmPopUp();
            FrmP.HelpSQL = "Select PDetailID as [000,SLNO], PDetailName as [200,Name], PDetailCode  as [100,Code] from ParamDetail Where IsActive='Y' and ParamID=" + ParamID + " Order By PDetailName";
            FrmP.HelpSearch = "[200,Name]";
            FrmP.ShowDialog();
            TT.Tag = FrmP.HelpSLNO;
            TT.Text = FrmP.HelpText;

        }
        public static void Popup_LocationList(TextBox TT)
        {
            FrmPopUp FrmP = new FrmPopUp();
            FrmP.HelpSQL = "Select LocationID as [000,SLNO], LocName as [200,Name], LocShort  as [100,Code] from LocationMaster Where IsActive='Y'  Order By LocName";
            FrmP.HelpSearch = "[200,Name]";
            FrmP.ShowDialog();
            TT.Tag = FrmP.HelpSLNO;
            TT.Text = FrmP.HelpText;

        }
        public static string GF_GetParamName(string TT)
        {
            string StrRet = "";
            ClassParamDetails CLP = new ClassParamDetails();
            CLP.SLNO = TT;
            CLP.Fn_DataView();
            StrRet = CLP.PDetailName;

            return StrRet;

        }
        public static void Fn_GetCulture()
        {
            string Cult = CultureInfo.CurrentCulture.Name;
            string CultUI = CultureInfo.CurrentUICulture.Name;

            //Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            //Thread.CurrentThread.


        }
        public static void Fn_RecordLock(string StrRecordID, string StrRecordType, string DLock, ref string StrRet)
        {
            string RetStr = "";
            if (StrRecordID == "") { return; }
            ClassDocumentLock CL23 = new ClassDocumentLock();
            CL23.Fn_CheckLock(StrRecordType, StrRecordID, DLock, ref RetStr);
            StrRet = RetStr;

        }
        public static void Fn_FillLangTab()
        {
            SqlConnection Conn = new SqlConnection();



            Conn.ConnectionString = ConStr;
            Conn.Open();

            string SQL = "SELECT  LangAssets.ContName,LangAssetsName.ContText,LangAssets.FormName  FROM LangAssets INNER JOIN " +
                "LangAssetsName ON  LangAssets.ContID =  LangAssetsName.ContID " +
                " Where  LangAssetsName.LangID=2  ";
            SqlDataAdapter daAuthors = new SqlDataAdapter(SQL, Conn);
            daAuthors.FillSchema(GL_DataSet, SchemaType.Source);
            daAuthors.Fill(GL_DataSet);
            Conn.Close();
            GL_DT = GL_DataSet.Tables[0];

            Fn_FillPermitTable();
        }
        private static void Fn_FillPermitTable()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConStr;
            Conn.Open();
            string SQL = "Select IsAllow,MenuID from MnuPermissions Where UserID=" + GlobalFunction.L_LoginID + "";
            SqlDataAdapter daAuthors = new SqlDataAdapter(SQL, Conn);
            daAuthors.FillSchema(GL_DataSet, SchemaType.Source);
            daAuthors.Fill(GL_DataSet);
            Conn.Close();
            GL_DTMEnuPermit = GL_DataSet.Tables[0];
            ////  GL_DTMEnuPermit

        }
        public static string Fn_ConverName(string FormName, string ContName)
        {
            string StrRet = "";


            Application.DoEvents();
            if (L_LangKnow != "1")
            {
                DataRow[] result = GL_DT.Select("ContName ='" + ContName.Trim().Replace("'", "") + "' And FormName='" + FormName.Trim().Replace("'", "") + "'");

                foreach (DataRow row in result)
                {
                    StrRet = row["ContText"].ToString();
                }
            }

            return StrRet;
            Application.DoEvents();
        }
        //public static void Fn_NameLabel(Panel PP, Form FF)
        //{
        //    string StrFormName = FF.Name.ToString();
        //    string StrContName = "";
        //    string StrContText = "";

        //    ClassLang LL = new ClassLang();
        //    StrContText = LL.Fn_GetContTextForForm(StrFormName, StrFormName);
        //    if (StrContText.Trim() != "") { FF.Text = StrContText; }
        //    List<Control> cleanControls = new List<Control>();
        //    foreach (Control ctr in PP.Controls)
        //    {
        //        StrContName = ctr.Name.ToString();
        //        StrContText = "";
        //        if (StrContName.ToUpper().StartsWith("X")) { StrContText = LL.Fn_GetContTextForForm(StrFormName, StrContName); }
        //        if (StrContName.ToUpper().StartsWith("BTN")) { StrContText = LL.Fn_GetContTextForForm(StrFormName, StrContName); }
        //        if (StrContName.ToUpper().StartsWith("CHK")) { StrContText = LL.Fn_GetContTextForForm(StrFormName, StrContName); }
        //        if (StrContName.ToUpper().StartsWith("LA")) { StrContText = LL.Fn_GetContTextForForm(StrFormName, StrContName); }
        //        if (StrContText.Trim() != "") { ctr.Text = StrContText; }
        //    }
        //}

    }
}
