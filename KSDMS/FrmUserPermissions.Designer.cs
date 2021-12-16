namespace KSDMS
{
    partial class FrmUserPermissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserPermissions));
            this.PnlData = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlSubMenu = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PnlSubPermissions = new System.Windows.Forms.Panel();
            this.TxtEditDays = new System.Windows.Forms.TextBox();
            this.labelEditDays = new System.Windows.Forms.Label();
            this.ChkSubEdit = new System.Windows.Forms.CheckBox();
            this.ChkSubAddNew = new System.Windows.Forms.CheckBox();
            this.ChkSubView = new System.Windows.Forms.CheckBox();
            this.GVLang = new System.Windows.Forms.DataGridView();
            this.LblSubMenuName = new System.Windows.Forms.Label();
            this.LblSubMenuText = new System.Windows.Forms.Label();
            this.ChkSubAllowed = new System.Windows.Forms.CheckBox();
            this.LblMainMenuText = new System.Windows.Forms.Label();
            this.LblMainMenuName = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.ChkMainMenu = new System.Windows.Forms.CheckBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GVControls = new System.Windows.Forms.DataGridView();
            this.PnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlSubMenu.SuspendLayout();
            this.PnlSubPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVLang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVControls)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlData
            // 
            this.PnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PnlData.Controls.Add(this.pictureBox2);
            this.PnlData.Controls.Add(this.pictureBox1);
            this.PnlData.Controls.Add(this.PnlSubMenu);
            this.PnlData.Controls.Add(this.LblMainMenuText);
            this.PnlData.Controls.Add(this.LblMainMenuName);
            this.PnlData.Controls.Add(this.TxtID);
            this.PnlData.Controls.Add(this.label1);
            this.PnlData.Controls.Add(this.TxtName);
            this.PnlData.Controls.Add(this.label27);
            this.PnlData.Controls.Add(this.ChkMainMenu);
            this.PnlData.Controls.Add(this.BtnExit);
            this.PnlData.Controls.Add(this.GVControls);
            this.PnlData.Location = new System.Drawing.Point(12, 12);
            this.PnlData.Name = "PnlData";
            this.PnlData.Size = new System.Drawing.Size(954, 549);
            this.PnlData.TabIndex = 2;
            this.PnlData.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(460, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 451;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 450;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PnlSubMenu
            // 
            this.PnlSubMenu.Controls.Add(this.BtnSave);
            this.PnlSubMenu.Controls.Add(this.PnlSubPermissions);
            this.PnlSubMenu.Controls.Add(this.GVLang);
            this.PnlSubMenu.Controls.Add(this.LblSubMenuName);
            this.PnlSubMenu.Controls.Add(this.LblSubMenuText);
            this.PnlSubMenu.Controls.Add(this.ChkSubAllowed);
            this.PnlSubMenu.Location = new System.Drawing.Point(515, 75);
            this.PnlSubMenu.Name = "PnlSubMenu";
            this.PnlSubMenu.Size = new System.Drawing.Size(415, 471);
            this.PnlSubMenu.TabIndex = 449;
            this.PnlSubMenu.Visible = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSave.Location = new System.Drawing.Point(293, 334);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnSave.Size = new System.Drawing.Size(61, 36);
            this.BtnSave.TabIndex = 452;
            this.BtnSave.Text = "&Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PnlSubPermissions
            // 
            this.PnlSubPermissions.Controls.Add(this.TxtEditDays);
            this.PnlSubPermissions.Controls.Add(this.labelEditDays);
            this.PnlSubPermissions.Controls.Add(this.ChkSubEdit);
            this.PnlSubPermissions.Controls.Add(this.ChkSubAddNew);
            this.PnlSubPermissions.Controls.Add(this.ChkSubView);
            this.PnlSubPermissions.Location = new System.Drawing.Point(19, 373);
            this.PnlSubPermissions.Name = "PnlSubPermissions";
            this.PnlSubPermissions.Size = new System.Drawing.Size(380, 95);
            this.PnlSubPermissions.TabIndex = 0;
            this.PnlSubPermissions.Visible = false;
            // 
            // TxtEditDays
            // 
            this.TxtEditDays.Location = new System.Drawing.Point(229, 61);
            this.TxtEditDays.MaxLength = 100;
            this.TxtEditDays.Name = "TxtEditDays";
            this.TxtEditDays.Size = new System.Drawing.Size(71, 21);
            this.TxtEditDays.TabIndex = 455;
            this.TxtEditDays.Click += new System.EventHandler(this.TxtEditDays_Click);
            // 
            // labelEditDays
            // 
            this.labelEditDays.AutoSize = true;
            this.labelEditDays.Location = new System.Drawing.Point(151, 64);
            this.labelEditDays.Name = "labelEditDays";
            this.labelEditDays.Size = new System.Drawing.Size(61, 13);
            this.labelEditDays.TabIndex = 456;
            this.labelEditDays.Text = "Edit Days";
            // 
            // ChkSubEdit
            // 
            this.ChkSubEdit.AutoSize = true;
            this.ChkSubEdit.Location = new System.Drawing.Point(13, 60);
            this.ChkSubEdit.Name = "ChkSubEdit";
            this.ChkSubEdit.Size = new System.Drawing.Size(97, 17);
            this.ChkSubEdit.TabIndex = 454;
            this.ChkSubEdit.Text = "Edit Records";
            this.ChkSubEdit.UseVisualStyleBackColor = true;
            this.ChkSubEdit.Click += new System.EventHandler(this.ChkSubEdit_Click);
            // 
            // ChkSubAddNew
            // 
            this.ChkSubAddNew.AutoSize = true;
            this.ChkSubAddNew.Location = new System.Drawing.Point(13, 37);
            this.ChkSubAddNew.Name = "ChkSubAddNew";
            this.ChkSubAddNew.Size = new System.Drawing.Size(136, 17);
            this.ChkSubAddNew.TabIndex = 453;
            this.ChkSubAddNew.Text = "Add New Records ?";
            this.ChkSubAddNew.UseVisualStyleBackColor = true;
            this.ChkSubAddNew.Click += new System.EventHandler(this.ChkSubAddNew_Click);
            // 
            // ChkSubView
            // 
            this.ChkSubView.AutoSize = true;
            this.ChkSubView.Location = new System.Drawing.Point(13, 14);
            this.ChkSubView.Name = "ChkSubView";
            this.ChkSubView.Size = new System.Drawing.Size(113, 17);
            this.ChkSubView.TabIndex = 452;
            this.ChkSubView.Text = "View Records ?";
            this.ChkSubView.UseVisualStyleBackColor = true;
            this.ChkSubView.Click += new System.EventHandler(this.ChkSubView_Click);
            // 
            // GVLang
            // 
            this.GVLang.AllowUserToAddRows = false;
            this.GVLang.AllowUserToDeleteRows = false;
            this.GVLang.AllowUserToResizeColumns = false;
            this.GVLang.AllowUserToResizeRows = false;
            this.GVLang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GVLang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVLang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVLang.Location = new System.Drawing.Point(19, 3);
            this.GVLang.Name = "GVLang";
            this.GVLang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVLang.Size = new System.Drawing.Size(381, 316);
            this.GVLang.TabIndex = 2;
            this.GVLang.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVLang_RowHeaderMouseClick);
            this.GVLang.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVLang_RowHeaderMouseDoubleClick);
            // 
            // LblSubMenuName
            // 
            this.LblSubMenuName.AutoSize = true;
            this.LblSubMenuName.Location = new System.Drawing.Point(16, 322);
            this.LblSubMenuName.Name = "LblSubMenuName";
            this.LblSubMenuName.Size = new System.Drawing.Size(51, 13);
            this.LblSubMenuName.TabIndex = 451;
            this.LblSubMenuName.Text = "User ID";
            // 
            // LblSubMenuText
            // 
            this.LblSubMenuText.AutoSize = true;
            this.LblSubMenuText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubMenuText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblSubMenuText.Location = new System.Drawing.Point(16, 335);
            this.LblSubMenuText.Name = "LblSubMenuText";
            this.LblSubMenuText.Size = new System.Drawing.Size(112, 18);
            this.LblSubMenuText.TabIndex = 450;
            this.LblSubMenuText.Text = "Menu Name";
            // 
            // ChkSubAllowed
            // 
            this.ChkSubAllowed.AutoSize = true;
            this.ChkSubAllowed.Location = new System.Drawing.Point(19, 356);
            this.ChkSubAllowed.Name = "ChkSubAllowed";
            this.ChkSubAllowed.Size = new System.Drawing.Size(80, 17);
            this.ChkSubAllowed.TabIndex = 449;
            this.ChkSubAllowed.Text = "Allowed ?";
            this.ChkSubAllowed.UseVisualStyleBackColor = true;
            this.ChkSubAllowed.CheckStateChanged += new System.EventHandler(this.ChkSubAllowed_CheckedChanged);
            this.ChkSubAllowed.Click += new System.EventHandler(this.ChkSubAllowed_Click);
            // 
            // LblMainMenuText
            // 
            this.LblMainMenuText.AutoSize = true;
            this.LblMainMenuText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMainMenuText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblMainMenuText.Location = new System.Drawing.Point(397, 102);
            this.LblMainMenuText.Name = "LblMainMenuText";
            this.LblMainMenuText.Size = new System.Drawing.Size(112, 18);
            this.LblMainMenuText.TabIndex = 448;
            this.LblMainMenuText.Text = "Menu Name";
            this.LblMainMenuText.Visible = false;
            // 
            // LblMainMenuName
            // 
            this.LblMainMenuName.AutoSize = true;
            this.LblMainMenuName.Location = new System.Drawing.Point(378, 75);
            this.LblMainMenuName.Name = "LblMainMenuName";
            this.LblMainMenuName.Size = new System.Drawing.Size(51, 13);
            this.LblMainMenuName.TabIndex = 447;
            this.LblMainMenuName.Text = "User ID";
            this.LblMainMenuName.Visible = false;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(131, 23);
            this.TxtID.MaxLength = 100;
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(140, 21);
            this.TxtID.TabIndex = 444;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 445;
            this.label1.Text = "User ID";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(131, 48);
            this.TxtName.MaxLength = 100;
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(323, 21);
            this.TxtName.TabIndex = 441;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(20, 48);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(70, 13);
            this.label27.TabIndex = 442;
            this.label27.Text = "User Name";
            // 
            // ChkMainMenu
            // 
            this.ChkMainMenu.AutoSize = true;
            this.ChkMainMenu.Location = new System.Drawing.Point(400, 131);
            this.ChkMainMenu.Name = "ChkMainMenu";
            this.ChkMainMenu.Size = new System.Drawing.Size(80, 17);
            this.ChkMainMenu.TabIndex = 41;
            this.ChkMainMenu.Text = "Allowed ?";
            this.ChkMainMenu.UseVisualStyleBackColor = true;
            this.ChkMainMenu.Visible = false;
            this.ChkMainMenu.CheckStateChanged += new System.EventHandler(this.ChkMainMenu_CheckedChanged);
            this.ChkMainMenu.Click += new System.EventHandler(this.ChkMainMenu_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnExit.Location = new System.Drawing.Point(858, 16);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnExit.Size = new System.Drawing.Size(72, 59);
            this.BtnExit.TabIndex = 40;
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GVControls
            // 
            this.GVControls.AllowUserToAddRows = false;
            this.GVControls.AllowUserToDeleteRows = false;
            this.GVControls.AllowUserToResizeColumns = false;
            this.GVControls.AllowUserToResizeRows = false;
            this.GVControls.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GVControls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVControls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVControls.Location = new System.Drawing.Point(18, 75);
            this.GVControls.Name = "GVControls";
            this.GVControls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVControls.Size = new System.Drawing.Size(354, 455);
            this.GVControls.TabIndex = 1;
            this.GVControls.Visible = false;
            this.GVControls.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVControls_RowHeaderMouseClick);
            this.GVControls.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVControls_RowHeaderMouseDoubleClick);
            // 
            // FrmUserPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 569);
            this.Controls.Add(this.PnlData);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmUserPermissions";
            this.Text = "FrmUserPermissions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserPermissions_Load);
            this.PnlData.ResumeLayout(false);
            this.PnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlSubMenu.ResumeLayout(false);
            this.PnlSubMenu.PerformLayout();
            this.PnlSubPermissions.ResumeLayout(false);
            this.PnlSubPermissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVLang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVControls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlData;
        private System.Windows.Forms.Panel PnlSubMenu;
        internal System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Panel PnlSubPermissions;
        private System.Windows.Forms.TextBox TxtEditDays;
        private System.Windows.Forms.Label labelEditDays;
        private System.Windows.Forms.CheckBox ChkSubEdit;
        private System.Windows.Forms.CheckBox ChkSubAddNew;
        private System.Windows.Forms.CheckBox ChkSubView;
        private System.Windows.Forms.DataGridView GVLang;
        private System.Windows.Forms.Label LblSubMenuName;
        private System.Windows.Forms.Label LblSubMenuText;
        private System.Windows.Forms.CheckBox ChkSubAllowed;
        private System.Windows.Forms.Label LblMainMenuText;
        private System.Windows.Forms.Label LblMainMenuName;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox ChkMainMenu;
        internal System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView GVControls;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}