namespace KSDMS
{
    partial class FrmVisaDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisaDoc));
            this.GvVisaType = new System.Windows.Forms.DataGridView();
            this.GvVisaDocks = new System.Windows.Forms.DataGridView();
            this.PnlButton = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.PnlData = new System.Windows.Forms.Panel();
            this.LblFor = new System.Windows.Forms.Label();
            this.XLHead = new System.Windows.Forms.Label();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtShort = new System.Windows.Forms.TextBox();
            this.XLName = new System.Windows.Forms.Label();
            this.XLShort = new System.Windows.Forms.Label();
            this.TxtLastDate = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GvVisaType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvVisaDocks)).BeginInit();
            this.PnlButton.SuspendLayout();
            this.PnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // GvVisaType
            // 
            this.GvVisaType.AllowUserToAddRows = false;
            this.GvVisaType.AllowUserToDeleteRows = false;
            this.GvVisaType.AllowUserToResizeColumns = false;
            this.GvVisaType.AllowUserToResizeRows = false;
            this.GvVisaType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GvVisaType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GvVisaType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvVisaType.Location = new System.Drawing.Point(12, 3);
            this.GvVisaType.Name = "GvVisaType";
            this.GvVisaType.RowHeadersWidth = 30;
            this.GvVisaType.RowTemplate.Height = 20;
            this.GvVisaType.RowTemplate.ReadOnly = true;
            this.GvVisaType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvVisaType.Size = new System.Drawing.Size(281, 409);
            this.GvVisaType.TabIndex = 16;
            this.GvVisaType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvVisaType_CellContentClick);
            this.GvVisaType.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvVisaType_CellContentDoubleClick);
            this.GvVisaType.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GvVisaType_RowHeaderMouseDoubleClick);
            // 
            // GvVisaDocks
            // 
            this.GvVisaDocks.AllowUserToAddRows = false;
            this.GvVisaDocks.AllowUserToDeleteRows = false;
            this.GvVisaDocks.AllowUserToResizeColumns = false;
            this.GvVisaDocks.AllowUserToResizeRows = false;
            this.GvVisaDocks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GvVisaDocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GvVisaDocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvVisaDocks.Location = new System.Drawing.Point(299, 196);
            this.GvVisaDocks.Name = "GvVisaDocks";
            this.GvVisaDocks.RowHeadersWidth = 30;
            this.GvVisaDocks.RowTemplate.Height = 20;
            this.GvVisaDocks.RowTemplate.ReadOnly = true;
            this.GvVisaDocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvVisaDocks.Size = new System.Drawing.Size(587, 216);
            this.GvVisaDocks.TabIndex = 17;
            this.GvVisaDocks.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvVisaDocks_CellContentDoubleClick);
            this.GvVisaDocks.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GvVisaDocks_RowHeaderMouseDoubleClick);
            // 
            // PnlButton
            // 
            this.PnlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PnlButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlButton.Controls.Add(this.BtnExit);
            this.PnlButton.Controls.Add(this.BtnCancel);
            this.PnlButton.Controls.Add(this.BtnView);
            this.PnlButton.Controls.Add(this.BtnDelete);
            this.PnlButton.Controls.Add(this.BtnEdit);
            this.PnlButton.Controls.Add(this.BtnSave);
            this.PnlButton.Controls.Add(this.BtnAdd);
            this.PnlButton.Location = new System.Drawing.Point(302, 3);
            this.PnlButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.Size = new System.Drawing.Size(584, 61);
            this.PnlButton.TabIndex = 36;
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(367, 3);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnExit.Size = new System.Drawing.Size(73, 56);
            this.BtnExit.TabIndex = 78;
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancel.BackgroundImage")));
            this.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(306, 3);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnCancel.Size = new System.Drawing.Size(61, 56);
            this.BtnCancel.TabIndex = 77;
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnView
            // 
            this.BtnView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnView.BackgroundImage")));
            this.BtnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnView.Image = ((System.Drawing.Image)(resources.GetObject("BtnView.Image")));
            this.BtnView.Location = new System.Drawing.Point(245, 3);
            this.BtnView.Margin = new System.Windows.Forms.Padding(0);
            this.BtnView.Name = "BtnView";
            this.BtnView.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnView.Size = new System.Drawing.Size(61, 56);
            this.BtnView.TabIndex = 76;
            this.BtnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Visible = false;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(184, 3);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnDelete.Size = new System.Drawing.Size(61, 56);
            this.BtnDelete.TabIndex = 75;
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEdit.BackgroundImage")));
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(123, 3);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnEdit.Size = new System.Drawing.Size(61, 56);
            this.BtnEdit.TabIndex = 74;
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(62, 3);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnSave.Size = new System.Drawing.Size(61, 56);
            this.BtnSave.TabIndex = 73;
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.BackgroundImage")));
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(1, 3);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnAdd.Size = new System.Drawing.Size(61, 56);
            this.BtnAdd.TabIndex = 72;
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // PnlData
            // 
            this.PnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PnlData.Controls.Add(this.LblFor);
            this.PnlData.Controls.Add(this.XLHead);
            this.PnlData.Controls.Add(this.ChkActive);
            this.PnlData.Controls.Add(this.TxtName);
            this.PnlData.Controls.Add(this.TxtShort);
            this.PnlData.Controls.Add(this.XLName);
            this.PnlData.Controls.Add(this.XLShort);
            this.PnlData.Controls.Add(this.TxtLastDate);
            this.PnlData.Controls.Add(this.TxtID);
            this.PnlData.Location = new System.Drawing.Point(302, 70);
            this.PnlData.Name = "PnlData";
            this.PnlData.Size = new System.Drawing.Size(584, 120);
            this.PnlData.TabIndex = 35;
            // 
            // LblFor
            // 
            this.LblFor.AutoSize = true;
            this.LblFor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LblFor.Location = new System.Drawing.Point(208, 3);
            this.LblFor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFor.Name = "LblFor";
            this.LblFor.Size = new System.Drawing.Size(27, 25);
            this.LblFor.TabIndex = 9;
            this.LblFor.Text = "*";
            // 
            // XLHead
            // 
            this.XLHead.AutoSize = true;
            this.XLHead.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.XLHead.Location = new System.Drawing.Point(21, 3);
            this.XLHead.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.XLHead.Name = "XLHead";
            this.XLHead.Size = new System.Drawing.Size(177, 25);
            this.XLHead.TabIndex = 8;
            this.XLHead.Text = "Visa Docks for";
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Location = new System.Drawing.Point(463, 52);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(82, 17);
            this.ChkActive.TabIndex = 7;
            this.ChkActive.Text = "Is Active?";
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(79, 75);
            this.TxtName.MaxLength = 100;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(496, 21);
            this.TxtName.TabIndex = 6;
            // 
            // TxtShort
            // 
            this.TxtShort.Location = new System.Drawing.Point(78, 41);
            this.TxtShort.MaxLength = 3;
            this.TxtShort.Name = "TxtShort";
            this.TxtShort.Size = new System.Drawing.Size(72, 21);
            this.TxtShort.TabIndex = 5;
            this.TxtShort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtShort_KeyPress);
            // 
            // XLName
            // 
            this.XLName.AutoSize = true;
            this.XLName.Location = new System.Drawing.Point(23, 83);
            this.XLName.Name = "XLName";
            this.XLName.Size = new System.Drawing.Size(40, 13);
            this.XLName.TabIndex = 4;
            this.XLName.Text = "Name";
            // 
            // XLShort
            // 
            this.XLShort.AutoSize = true;
            this.XLShort.Location = new System.Drawing.Point(23, 49);
            this.XLShort.Name = "XLShort";
            this.XLShort.Size = new System.Drawing.Size(39, 13);
            this.XLShort.TabIndex = 3;
            this.XLShort.Text = "Sr.No";
            // 
            // TxtLastDate
            // 
            this.TxtLastDate.Location = new System.Drawing.Point(433, 25);
            this.TxtLastDate.Name = "TxtLastDate";
            this.TxtLastDate.Size = new System.Drawing.Size(142, 21);
            this.TxtLastDate.TabIndex = 1;
            this.TxtLastDate.Visible = false;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(433, 3);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(142, 21);
            this.TxtID.TabIndex = 0;
            this.TxtID.Visible = false;
            // 
            // FrmVisaDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 431);
            this.Controls.Add(this.PnlButton);
            this.Controls.Add(this.PnlData);
            this.Controls.Add(this.GvVisaDocks);
            this.Controls.Add(this.GvVisaType);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmVisaDoc";
            this.Text = "FrmVisaDoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVisaDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvVisaType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvVisaDocks)).EndInit();
            this.PnlButton.ResumeLayout(false);
            this.PnlData.ResumeLayout(false);
            this.PnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GvVisaType;
        private System.Windows.Forms.DataGridView GvVisaDocks;
        internal System.Windows.Forms.Panel PnlButton;
        private System.Windows.Forms.Panel PnlData;
        private System.Windows.Forms.Label XLHead;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtShort;
        private System.Windows.Forms.Label XLName;
        private System.Windows.Forms.Label XLShort;
        private System.Windows.Forms.TextBox TxtLastDate;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblFor;
        internal System.Windows.Forms.Button BtnExit;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnView;
        internal System.Windows.Forms.Button BtnDelete;
        internal System.Windows.Forms.Button BtnEdit;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button BtnAdd;
    }
}