using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace Report
{
    public partial class Form1 : Form
    {
        public string InputSQL="";
        public string InputReportType = "";
        public string InputReportTitle = "";
        public Form1()
        {
            InitializeComponent();
            
        }
     
        
        private void Form1_Load(object sender, EventArgs e)
        {
            RptVeiw.Width = this.Width - 20;
            RptVeiw.Height = this.Height - 40;

            ClassReport CLR = new ClassReport();
            CLR.Fn_GetReportType(ref InputReportType,ref InputReportTitle, ref InputSQL);
            if (InputSQL.ToString().Trim() == "")
            {
                MessageBox.Show("Not Allow to Open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
           
            
            Fn_GetReport();
            
        }
       
        private void Fn_GetReport()
        {
            if (InputReportType == "RptMonthDetail")
            { Fn_SHowDetailReport(); }
            else if (InputReportType == "RptMonthSum")
            { Fn_SHowSumReport(); }
            else if (InputReportType == "RptMonthDetailPassport")
            { Fn_SHowDetailReportPassport(); }
        }
       
        private void Fn_SHowDetailReport()
        {
             
            ClassReport CR = new ClassReport();
             

            CR.Fn_ShowReportVisa(InputSQL);
            CrystalReport1 Rpt = new CrystalReport1();
            int L;
            for (L = 0; L < Rpt.DataDefinition.FormulaFields.Count; L++)
            {
                if (Rpt.DataDefinition.FormulaFields[L].Name == "ReportTitle")
                {
                    Rpt.DataDefinition.FormulaFields[L].Text = "'" + InputReportTitle + "'";
                }

            }
            try
            {
                Rpt.SetDataSource(CR.R_Ds.Tables[0]); 
                RptVeiw.ReportSource = Rpt;
                RptVeiw.Refresh();
            }
            catch
            {
                MessageBox.Show("No Data", "KS EDMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Fn_SHowDetailReportPassport()
        {

            ClassReport CR = new ClassReport();

            CR.Fn_ShowReportPassport(InputSQL);
            RptPassport Rpt = new RptPassport();
            int L;
            for (L = 0; L < Rpt.DataDefinition.FormulaFields.Count; L++)
            {
                if (Rpt.DataDefinition.FormulaFields[L].Name == "ReportTitle")
                {
                    Rpt.DataDefinition.FormulaFields[L].Text = "'" + InputReportTitle + "'";
                }

            }
            try
            {
                Rpt.SetDataSource(CR.R_Ds.Tables[0]);
                RptVeiw.ReportSource = Rpt;
                RptVeiw.Refresh();
            }
            catch
            {
                MessageBox.Show("No Data", "KS EDMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Fn_SHowSumReport()
        {
           
            ClassReport CR = new ClassReport();
           
            CR.Fn_ShowReportVisaSum(InputSQL);
            RptSum Rpt = new RptSum();
            int L;
            for (L = 0; L < Rpt.DataDefinition.FormulaFields.Count; L++)
            {
                if (Rpt.DataDefinition.FormulaFields[L].Name == "ReportTitle")
                {
                    Rpt.DataDefinition.FormulaFields[L].Text = "'" + InputReportTitle + "'";
                }

            }
            try
            {
                Rpt.SetDataSource(CR.R_Ds.Tables[0]); 
                RptVeiw.ReportSource = Rpt;
                RptVeiw.Refresh();
            }
            catch
            {
                MessageBox.Show("No Data", "KS EDMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RptVeiw_Load(object sender, EventArgs e)
        {

        }

     

      
 
    }
}
