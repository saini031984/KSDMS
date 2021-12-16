namespace KSDMS
{
    partial class FrmCountryMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCountryMaster));
            this.PnlData = new System.Windows.Forms.Panel();
            this.XLHead = new System.Windows.Forms.Label();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtShort = new System.Windows.Forms.TextBox();
            this.XLName = new System.Windows.Forms.Label();
            this.XLShort = new System.Windows.Forms.Label();
            this.TxtLastDate = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.PnlButton = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.PnlData.SuspendLayout();
            this.PnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlData
            // 
            this.PnlData.Controls.Add(this.XLHead);
            this.PnlData.Controls.Add(this.ChkActive);
            this.PnlData.Controls.Add(this.TxtName);
            this.PnlData.Controls.Add(this.TxtShort);
            this.PnlData.Controls.Add(this.XLName);
            this.PnlData.Controls.Add(this.XLShort);
            this.PnlData.Controls.Add(this.TxtLastDate);
            this.PnlData.Controls.Add(this.TxtID);
            this.PnlData.Location = new System.Drawing.Point(1, 70);
            this.PnlData.Name = "PnlData";
            this.PnlData.Size = new System.Drawing.Size(563, 120);
            this.PnlData.TabIndex = 31;
            // 
            // XLHead
            // 
            this.XLHead.AutoSize = true;
            this.XLHead.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.XLHead.Location = new System.Drawing.Point(18, 3);
            this.XLHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XLHead.Name = "XLHead";
            this.XLHead.Size = new System.Drawing.Size(192, 25);
            this.XLHead.TabIndex = 8;
            this.XLHead.Text = "Country Master";
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Location = new System.Drawing.Point(456, 57);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(82, 17);
            this.ChkActive.TabIndex = 7;
            this.ChkActive.Text = "Is Active?";
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(127, 80);
            this.TxtName.MaxLength = 100;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(433, 21);
            this.TxtName.TabIndex = 6;
            // 
            // TxtShort
            // 
            this.TxtShort.Location = new System.Drawing.Point(126, 46);
            this.TxtShort.MaxLength = 3;
            this.TxtShort.Name = "TxtShort";
            this.TxtShort.Size = new System.Drawing.Size(62, 21);
            this.TxtShort.TabIndex = 5;
            // 
            // XLName
            // 
            this.XLName.AutoSize = true;
            this.XLName.Location = new System.Drawing.Point(20, 83);
            this.XLName.Name = "XLName";
            this.XLName.Size = new System.Drawing.Size(40, 13);
            this.XLName.TabIndex = 4;
            this.XLName.Text = "Name";
            // 
            // XLShort
            // 
            this.XLShort.AutoSize = true;
            this.XLShort.Location = new System.Drawing.Point(20, 49);
            this.XLShort.Name = "XLShort";
            this.XLShort.Size = new System.Drawing.Size(38, 13);
            this.XLShort.TabIndex = 3;
            this.XLShort.Text = "Short";
            // 
            // TxtLastDate
            // 
            this.TxtLastDate.Location = new System.Drawing.Point(432, 25);
            this.TxtLastDate.Name = "TxtLastDate";
            this.TxtLastDate.Size = new System.Drawing.Size(122, 21);
            this.TxtLastDate.TabIndex = 1;
            this.TxtLastDate.Visible = false;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(432, 3);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(122, 21);
            this.TxtID.TabIndex = 0;
            this.TxtID.Visible = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEdit.BackgroundImage")));
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEdit.Location = new System.Drawing.Point(126, 2);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnEdit.Size = new System.Drawing.Size(61, 56);
            this.BtnEdit.TabIndex = 34;
            this.BtnEdit.Text = "&Edit";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Location = new System.Drawing.Point(187, 2);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnDelete.Size = new System.Drawing.Size(61, 56);
            this.BtnDelete.TabIndex = 35;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSave.Location = new System.Drawing.Point(65, 2);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnSave.Size = new System.Drawing.Size(61, 56);
            this.BtnSave.TabIndex = 33;
            this.BtnSave.Text = "&Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnView
            // 
            this.BtnView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnView.BackgroundImage")));
            this.BtnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnView.Location = new System.Drawing.Point(248, 2);
            this.BtnView.Margin = new System.Windows.Forms.Padding(0);
            this.BtnView.Name = "BtnView";
            this.BtnView.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnView.Size = new System.Drawing.Size(61, 56);
            this.BtnView.TabIndex = 36;
            this.BtnView.Text = "&View";
            this.BtnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancel.BackgroundImage")));
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.Location = new System.Drawing.Point(309, 2);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnCancel.Size = new System.Drawing.Size(61, 56);
            this.BtnCancel.TabIndex = 37;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPrint.BackgroundImage")));
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPrint.Location = new System.Drawing.Point(370, 2);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnPrint.Size = new System.Drawing.Size(61, 56);
            this.BtnPrint.TabIndex = 38;
            this.BtnPrint.Text = "&Print";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Visible = false;
            // 
            // PnlButton
            // 
            this.PnlButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlButton.Controls.Add(this.BtnExit);
            this.PnlButton.Controls.Add(this.BtnPrint);
            this.PnlButton.Controls.Add(this.BtnCancel);
            this.PnlButton.Controls.Add(this.BtnView);
            this.PnlButton.Controls.Add(this.BtnDelete);
            this.PnlButton.Controls.Add(this.BtnEdit);
            this.PnlButton.Controls.Add(this.BtnSave);
            this.PnlButton.Controls.Add(this.BtnAdd);
            this.PnlButton.Location = new System.Drawing.Point(1, 3);
            this.PnlButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.Size = new System.Drawing.Size(562, 61);
            this.PnlButton.TabIndex = 32;
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnExit.Location = new System.Drawing.Point(431, 2);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnExit.Size = new System.Drawing.Size(61, 56);
            this.BtnExit.TabIndex = 39;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.BackgroundImage")));
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAdd.Location = new System.Drawing.Point(4, 2);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnAdd.Size = new System.Drawing.Size(61, 56);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "&Add New ";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // FrmCountryMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 200);
            this.Controls.Add(this.PnlData);
            this.Controls.Add(this.PnlButton);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmCountryMaster";
            this.Text = "Country Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCountryMaster_Load);
            this.PnlData.ResumeLayout(false);
            this.PnlData.PerformLayout();
            this.PnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlData;
        private System.Windows.Forms.Label XLHead;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtShort;
        private System.Windows.Forms.Label XLName;
        private System.Windows.Forms.Label XLShort;
        private System.Windows.Forms.TextBox TxtLastDate;
        private System.Windows.Forms.TextBox TxtID;
        internal System.Windows.Forms.Button BtnEdit;
        internal System.Windows.Forms.Button BtnDelete;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button BtnView;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Panel PnlButton;
        internal System.Windows.Forms.Button BtnExit;
        internal System.Windows.Forms.Button BtnAdd;

    }
}