namespace KSDMS
{
    partial class FRmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RptVeiw = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // RptVeiw
            // 
            this.RptVeiw.ActiveViewIndex = -1;
            this.RptVeiw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RptVeiw.DisplayGroupTree = false;
            this.RptVeiw.Location = new System.Drawing.Point(-1, 0);
            this.RptVeiw.Name = "RptVeiw";
            this.RptVeiw.SelectionFormula = "";
            this.RptVeiw.ShowGroupTreeButton = false;
            this.RptVeiw.Size = new System.Drawing.Size(1094, 505);
            this.RptVeiw.TabIndex = 2;
            this.RptVeiw.ViewTimeSelectionFormula = "";
            // 
            // FRmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 538);
            this.Controls.Add(this.RptVeiw);
            this.Name = "FRmReport";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RptVeiw;

    }
}