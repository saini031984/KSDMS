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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDMS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TxtFileName = new System.Windows.Forms.TextBox();
            this.TxtFilePath = new System.Windows.Forms.TextBox();
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
            this.GvNewFiles = new System.Windows.Forms.DataGridView();
            this.Txtdocfilename = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pbar1 = new System.Windows.Forms.ProgressBar();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.btnscan = new System.Windows.Forms.Button();
            this.CmdExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BtnDeleteFILE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVPending)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvNewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // BtnUpload
            // 
            this.BtnUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpload.BackgroundImage")));
            this.BtnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnUpload.Location = new System.Drawing.Point(87, 105);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(81, 61);
            this.BtnUpload.TabIndex = 49;
            this.BtnUpload.UseVisualStyleBackColor = true;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // CmdShow
            // 
            this.CmdShow.Enabled = false;
            this.CmdShow.Location = new System.Drawing.Point(166, 105);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(81, 61);
            this.CmdShow.TabIndex = 51;
            this.CmdShow.Text = "Show";
            this.CmdShow.UseVisualStyleBackColor = true;
            this.CmdShow.Visible = false;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // GVPending
            // 
            this.GVPending.AllowUserToAddRows = false;
            this.GVPending.AllowUserToDeleteRows = false;
            this.GVPending.AllowUserToResizeColumns = false;
            this.GVPending.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GVPending.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GVPending.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GVPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVPending.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GVPending.Location = new System.Drawing.Point(13, 66);
            this.GVPending.Name = "GVPending";
            this.GVPending.ReadOnly = true;
            this.GVPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVPending.Size = new System.Drawing.Size(435, 159);
            this.GVPending.TabIndex = 458;
            this.GVPending.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVPending_CellContentClick);
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
            this.TxtID.Location = new System.Drawing.Point(171, 144);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(66, 21);
            this.TxtID.TabIndex = 467;
            this.TxtID.Visible = false;
            // 
            // CmdClear
            // 
            this.CmdClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdClear.BackgroundImage")));
            this.CmdClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CmdClear.Location = new System.Drawing.Point(253, 105);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(77, 61);
            this.CmdClear.TabIndex = 468;
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GVPending);
            this.panel1.Controls.Add(this.XLShort);
            this.panel1.Controls.Add(this.XLName);
            this.panel1.Controls.Add(this.TxtAppNo);
            this.panel1.Controls.Add(this.TxtSrNo);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 657);
            this.panel1.TabIndex = 469;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.BtnDeleteFILE);
            this.panel2.Controls.Add(this.GvNewFiles);
            this.panel2.Controls.Add(this.Txtdocfilename);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.pbar1);
            this.panel2.Controls.Add(this.lbDevices);
            this.panel2.Controls.Add(this.btnscan);
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
            this.panel2.Location = new System.Drawing.Point(13, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 381);
            this.panel2.TabIndex = 470;
            // 
            // GvNewFiles
            // 
            this.GvNewFiles.AllowUserToAddRows = false;
            this.GvNewFiles.AllowUserToDeleteRows = false;
            this.GvNewFiles.AllowUserToResizeColumns = false;
            this.GvNewFiles.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GvNewFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GvNewFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GvNewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvNewFiles.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GvNewFiles.Location = new System.Drawing.Point(8, 183);
            this.GvNewFiles.Name = "GvNewFiles";
            this.GvNewFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvNewFiles.Size = new System.Drawing.Size(411, 126);
            this.GvNewFiles.TabIndex = 476;
            this.GvNewFiles.Visible = false;
            this.GvNewFiles.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GvNewFiles_RowHeaderMouseDoubleClick);
            // 
            // Txtdocfilename
            // 
            this.Txtdocfilename.Location = new System.Drawing.Point(138, 288);
            this.Txtdocfilename.Name = "Txtdocfilename";
            this.Txtdocfilename.Size = new System.Drawing.Size(66, 21);
            this.Txtdocfilename.TabIndex = 474;
            this.Txtdocfilename.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(31, 255);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 56);
            this.listBox1.TabIndex = 473;
            this.listBox1.Visible = false;
            // 
            // pbar1
            // 
            this.pbar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbar1.Location = new System.Drawing.Point(99, 352);
            this.pbar1.Name = "pbar1";
            this.pbar1.Size = new System.Drawing.Size(318, 10);
            this.pbar1.TabIndex = 472;
            this.pbar1.UseWaitCursor = true;
            this.pbar1.Visible = false;
            // 
            // lbDevices
            // 
            this.lbDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.Location = new System.Drawing.Point(19, -111);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(312, 56);
            this.lbDevices.TabIndex = 471;
            this.lbDevices.Visible = false;
            // 
            // btnscan
            // 
            this.btnscan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnscan.BackgroundImage")));
            this.btnscan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnscan.Location = new System.Drawing.Point(4, 105);
            this.btnscan.Name = "btnscan";
            this.btnscan.Size = new System.Drawing.Size(81, 61);
            this.btnscan.TabIndex = 470;
            this.btnscan.UseVisualStyleBackColor = true;
            this.btnscan.Click += new System.EventHandler(this.btnscan_Click);
            // 
            // CmdExit
            // 
            this.CmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CmdExit.Image = ((System.Drawing.Image)(resources.GetObject("CmdExit.Image")));
            this.CmdExit.Location = new System.Drawing.Point(336, 104);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(81, 61);
            this.CmdExit.TabIndex = 469;
            this.CmdExit.UseVisualStyleBackColor = true;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(472, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 615);
            this.groupBox2.TabIndex = 470;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Document View";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 17);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(874, 595);
            this.webBrowser1.TabIndex = 1;
            // 
            // BtnDeleteFILE
            // 
            this.BtnDeleteFILE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteFILE.BackgroundImage")));
            this.BtnDeleteFILE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDeleteFILE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnDeleteFILE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteFILE.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteFILE.Image")));
            this.BtnDeleteFILE.Location = new System.Drawing.Point(176, 108);
            this.BtnDeleteFILE.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDeleteFILE.Name = "BtnDeleteFILE";
            this.BtnDeleteFILE.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnDeleteFILE.Size = new System.Drawing.Size(61, 56);
            this.BtnDeleteFILE.TabIndex = 471;
            this.BtnDeleteFILE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDeleteFILE.UseVisualStyleBackColor = true;
            this.BtnDeleteFILE.Click += new System.EventHandler(this.BtnDeleteFILE_Click);
            // 
            // FrmDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1362, 660);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDMS";
            this.Text = "EDMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDMS_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDMS_FormClosed);
            this.Load += new System.EventHandler(this.FrmDMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVPending)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvNewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnscan;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ProgressBar pbar1;
        private System.Windows.Forms.ListBox lbDevices;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txtdocfilename;
        private System.Windows.Forms.DataGridView GvNewFiles;
        private System.Windows.Forms.WebBrowser webBrowser1;
        internal System.Windows.Forms.Button BtnDeleteFILE;
    }
}