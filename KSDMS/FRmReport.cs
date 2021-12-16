using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KSDMS.DataClass;
namespace KSDMS
{
    public partial class FRmReport : Form
    {
        public FRmReport()
        {
            InitializeComponent();
        }

        private void FRmReport_Load(object sender, EventArgs e)
        {
            Fn_SHowReport();
        }
        private void Fn_SHowReport()
        {
            
            //String StrSQL = "";
            //ClassReport CR = new ClassReport();
            //CR.Fn_ShowReportVisa(StrSQL);
            //CrystalReport1 Rpt = new CrystalReport1();
            //int L;
            //for (L = 0; L < Rpt.DataDefinition.FormulaFields.Count; L++)
            //{
            //    //if (Rpt.DataDefinition.FormulaFields[L].Name == "CompNm")
            //    //{
            //    //    Rpt.DataDefinition.FormulaFields[L].Text = "'" + GlobalFunction.L_ReportFilter + "'";
            //    //}

            //}
            //Rpt.SetDataSource(CR.R_Ds.Tables[0]);
            //Rpt.Section3.Dispose();
            //RptVeiw.ReportSource = Rpt;
            //RptVeiw.Refresh();
        }
    }
}
