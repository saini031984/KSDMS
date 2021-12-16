namespace Report
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.RptVeiw = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dMSDataSet = new Report.DMSDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMSDataSet)).BeginInit();
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
            this.RptVeiw.Size = new System.Drawing.Size(1286, 490);
            this.RptVeiw.TabIndex = 2;
            this.RptVeiw.ViewTimeSelectionFormula = "";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dMSDataSet;
            this.bindingSource1.Position = 0;
            // 
            // dMSDataSet
            // 
            this.dMSDataSet.DataSetName = "DMSDataSet";
            this.dMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1287, 515);
            this.Controls.Add(this.RptVeiw);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RptVeiw;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DMSDataSet dMSDataSet;

    }
}

