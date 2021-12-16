namespace KSDMS
{
    partial class FrmReportShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportShow));
            this.PnlData = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbMonth = new System.Windows.Forms.ComboBox();
            this.RdSum = new System.Windows.Forms.RadioButton();
            this.RdDetail = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.CmbYear = new System.Windows.Forms.ComboBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.PnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlData
            // 
            this.PnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PnlData.Controls.Add(this.label1);
            this.PnlData.Controls.Add(this.CmbMonth);
            this.PnlData.Controls.Add(this.RdSum);
            this.PnlData.Controls.Add(this.RdDetail);
            this.PnlData.Controls.Add(this.label20);
            this.PnlData.Controls.Add(this.CmbYear);
            this.PnlData.Controls.Add(this.BtnExit);
            this.PnlData.Controls.Add(this.BtnPrint);
            this.PnlData.Controls.Add(this.shapeContainer1);
            this.PnlData.Location = new System.Drawing.Point(8, 5);
            this.PnlData.Name = "PnlData";
            this.PnlData.Size = new System.Drawing.Size(486, 118);
            this.PnlData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Month";
            // 
            // CmbMonth
            // 
            this.CmbMonth.FormattingEnabled = true;
            this.CmbMonth.Location = new System.Drawing.Point(231, 30);
            this.CmbMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(93, 21);
            this.CmbMonth.TabIndex = 60;
            // 
            // RdSum
            // 
            this.RdSum.AutoSize = true;
            this.RdSum.Location = new System.Drawing.Point(231, 66);
            this.RdSum.Name = "RdSum";
            this.RdSum.Size = new System.Drawing.Size(81, 17);
            this.RdSum.TabIndex = 58;
            this.RdSum.Text = "Summary";
            this.RdSum.UseVisualStyleBackColor = true;
            // 
            // RdDetail
            // 
            this.RdDetail.AutoSize = true;
            this.RdDetail.Checked = true;
            this.RdDetail.Location = new System.Drawing.Point(54, 66);
            this.RdDetail.Name = "RdDetail";
            this.RdDetail.Size = new System.Drawing.Size(58, 17);
            this.RdDetail.TabIndex = 57;
            this.RdDetail.TabStop = true;
            this.RdDetail.Text = "Detail";
            this.RdDetail.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 59;
            this.label20.Text = "Year";
            // 
            // CmbYear
            // 
            this.CmbYear.FormattingEnabled = true;
            this.CmbYear.Location = new System.Drawing.Point(54, 27);
            this.CmbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(93, 21);
            this.CmbYear.TabIndex = 56;
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnExit.Location = new System.Drawing.Point(416, 4);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnExit.Size = new System.Drawing.Size(70, 56);
            this.BtnExit.TabIndex = 54;
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPrint.BackgroundImage")));
            this.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPrint.Location = new System.Drawing.Point(345, 4);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnPrint.Size = new System.Drawing.Size(71, 56);
            this.BtnPrint.TabIndex = 55;
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(486, 118);
            this.shapeContainer1.TabIndex = 62;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(6, 4);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(335, 106);
            // 
            // FrmReportShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 129);
            this.Controls.Add(this.PnlData);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmReportShow";
            this.Text = "FrmReportShow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportShow_Load);
            this.PnlData.ResumeLayout(false);
            this.PnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlData;
        internal System.Windows.Forms.Button BtnExit;
        internal System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbMonth;
        private System.Windows.Forms.RadioButton RdSum;
        private System.Windows.Forms.RadioButton RdDetail;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox CmbYear;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}