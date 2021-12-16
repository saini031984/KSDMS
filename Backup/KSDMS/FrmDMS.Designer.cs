namespace KSDMS
{
    partial class FrmDMS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.TxtFilePath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.CmdShow = new System.Windows.Forms.Button();
            this.GVPending = new System.Windows.Forms.DataGridView();
            this.XLName = new System.Windows.Forms.Label();
            this.XLShort = new System.Windows.Forms.Label();
            this.TxtSrNo = new System.Windows.Forms.TextBox();
            this.TxtAppNo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.CmbFileType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.CmdClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CmdExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVPending)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TxtFileName
            // 
            this.TxtFileName.Location = new System.Drawing.Point(113, 34);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(304, 21);
            this.TxtFileName.TabIndex = 0;
            this.TxtFileName.TextChanged += new System.EventHandler(this.TxtFileName_TextChanged);
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.Location = new System.Drawing.Point(121, 67);
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.ReadOnly = true;
            this.TxtFilePath.Size = new System.Drawing.Size(273, 21);
            this.TxtFilePath.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::KSDMS.Properties.Resources._2;
            this.pictureBox1.Image = global::KSDMS.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(400, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnUpload
            // 
            this.BtnUpload.Location = new System.Drawing.Point(82, 105);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(83, 33);
            this.BtnUpload.TabIndex = 49;
            this.BtnUpload.Text = "Upload";
            this.BtnUpload.UseVisualStyleBackColor = true;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // CmdShow
            // 
            this.CmdShow.Enabled = false;
            this.CmdShow.Location = new System.Drawing.Point(171, 105);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(83, 31);
            this.CmdShow.TabIndex = 51;
            this.CmdShow.Text = "Show";
            this.CmdShow.UseVisualStyleBackColor = true;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // GVPending
            // 
            this.GVPending.AllowUserToAddRows = false;
            this.GVPending.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GVPending.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GVPending.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GVPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVPending.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GVPending.Location = new System.Drawing.Point(14, 70);
            this.GVPending.Name = "GVPending";
            this.GVPending.ReadOnly = true;
            this.GVPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVPending.Size = new System.Drawing.Size(435, 159);
            this.GVPending.TabIndex = 458;
            this.GVPending.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVPending_CellContentDoubleClick);
            this.GVPending.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVPending_RowHeaderMouseDoubleClick);
            // 
            // XLName
            // 
            this.XLName.AutoSize = true;
            this.XLName.Location = new System.Drawing.Point(14, 50);
            this.XLName.Name = "XLName";
            this.XLName.Size = new System.Drawing.Size(92, 13);
            this.XLName.TabIndex = 460;
            this.XLName.Text = "Application No.";
            // 
            // XLShort
            // 
            this.XLShort.AutoSize = true;
            this.XLShort.Location = new System.Drawing.Point(14, 26);
            this.XLShort.Name = "XLShort";
            this.XLShort.Size = new System.Drawing.Size(39, 13);
            this.XLShort.TabIndex = 459;
            this.XLShort.Text = "Sr.No";
            // 
            // TxtSrNo
            // 
            this.TxtSrNo.Location = new System.Drawing.Point(175, 18);
            this.TxtSrNo.Name = "TxtSrNo";
            this.TxtSrNo.ReadOnly = true;
            this.TxtSrNo.Size = new System.Drawing.Size(273, 21);
            this.TxtSrNo.TabIndex = 461;
            // 
            // TxtAppNo
            // 
            this.TxtAppNo.Location = new System.Drawing.Point(175, 44);
            this.TxtAppNo.Name = "TxtAppNo";
            this.TxtAppNo.ReadOnly = true;
            this.TxtAppNo.Size = new System.Drawing.Size(273, 21);
            this.TxtAppNo.TabIndex = 462;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 13);
            this.label20.TabIndex = 464;
            this.label20.Text = "Select File Name";
            // 
            // CmbFileType
            // 
            this.CmbFileType.FormattingEnabled = true;
            this.CmbFileType.Location = new System.Drawing.Point(113, 8);
            this.CmbFileType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbFileType.Name = "CmbFileType";
            this.CmbFileType.Size = new System.Drawing.Size(304, 21);
            this.CmbFileType.TabIndex = 463;
            this.CmbFileType.Leave += new System.EventHandler(this.CmbFileType_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 465;
            this.label1.Text = "File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 466;
            this.label2.Text = "Select Upload File";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(10, 104);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(66, 21);
            this.TxtID.TabIndex = 467;
            this.TxtID.Visible = false;
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(260, 105);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(83, 31);
            this.CmdClear.TabIndex = 468;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.XLShort);
            this.panel1.Controls.Add(this.GVPending);
            this.panel1.Controls.Add(this.XLName);
            this.panel1.Controls.Add(this.TxtAppNo);
            this.panel1.Controls.Add(this.TxtSrNo);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 394);
            this.panel1.TabIndex = 469;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CmdExit);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.CmdClear);
            this.panel2.Controls.Add(this.CmbFileType);
            this.panel2.Controls.Add(this.TxtID);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.BtnUpload);
            this.panel2.Controls.Add(this.TxtFileName);
            this.panel2.Controls.Add(this.CmdShow);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtFilePath);
            this.panel2.Location = new System.Drawing.Point(17, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 147);
            this.panel2.TabIndex = 470;
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(349, 104);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(83, 31);
            this.CmdExit.TabIndex = 469;
            this.CmdExit.Text = "Exit";
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // FrmDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 405);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDMS";
            this.Text = "FrmDMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVPending)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TxtFileName;
        private System.Windows.Forms.TextBox TxtFilePath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.Button CmdShow;
        private System.Windows.Forms.DataGridView GVPending;
        private System.Windows.Forms.Label XLName;
        private System.Windows.Forms.Label XLShort;
        private System.Windows.Forms.TextBox TxtSrNo;
        private System.Windows.Forms.TextBox TxtAppNo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox CmbFileType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Panel panel2;
    }
}