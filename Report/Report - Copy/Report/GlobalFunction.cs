using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Report
{
    public static class GlobalFunction
    {
        private static string _connectionstr = "";
        public static string connectionstr
        {
            get { return _connectionstr; }
            set { _connectionstr = value; }
        }
        private static string _SQLStr = "";
        public static string SQLStr
        {
            get { return _SQLStr; }
            set { _SQLStr = value; }
        }
        private static string _StrReportType = "";
        public static string idfpath
        {
            get { return _StrReportType; }
            set { _StrReportType = value; }
        }
    }
}
