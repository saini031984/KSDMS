namespace KSDMS
{
    partial class FrmParamMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParamMaster));
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtCodeLen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLastDate = new System.Windows.Forms.TextBox();
            this.PnlButton = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.ChkDefValue = new System.Windows.Forms.CheckBox();
            this.PnlData = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.PnlButton.SuspendLayout();
            this.PnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(126, 54);
            this.TxtName.MaxLength = 100;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(351, 21);
            this.TxtName.TabIndex = 1;
            // 
            // TxtCodeLen
            // 
            this.TxtCodeLen.Location = new System.Drawing.Point(126, 81);
            this.TxtCodeLen.MaxLength = 2;
            this.TxtCodeLen.Name = "TxtCodeLen";
            this.TxtCodeLen.Size = new System.Drawing.Size(62, 21);
            this.TxtCodeLen.TabIndex = 2;
            this.TxtCodeLen.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code Length";
            // 
            // TxtLastDate
            // 
            this.TxtLastDate.Location = new System.Drawing.Point(331, 27);
            this.TxtLastDate.Name = "TxtLastDate";
            this.TxtLastDate.Size = new System.Drawing.Size(122, 21);
            this.TxtLastDate.TabIndex = 1;
            this.TxtLastDate.Visible = false;
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
            this.PnlButton.Location = new System.Drawing.Point(2, 2);
            this.PnlButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.Size = new System.Drawing.Size(493, 61);
            this.PnlButton.TabIndex = 34;
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
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "&Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Location = new System.Drawing.Point(395, 85);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(82, 17);
            this.ChkActive.TabIndex = 4;
            this.ChkActive.Text = "Is Active?";
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // ChkDefValue
            // 
            this.ChkDefValue.AutoSize = true;
            this.ChkDefValue.Location = new System.Drawing.Point(239, 83);
            this.ChkDefValue.Name = "ChkDefValue";
            this.ChkDefValue.Size = new System.Drawing.Size(107, 17);
            this.ChkDefValue.TabIndex = 3;
            this.ChkDefValue.Text = "Is Def. Value?";
            this.ChkDefValue.UseVisualStyleBackColor = true;
            // 
            // PnlData
            // 
            this.PnlData.Controls.Add(this.ChkDefValue);
            this.PnlData.Controls.Add(this.label1);
            this.PnlData.Controls.Add(this.ChkActive);
            this.PnlData.Controls.Add(this.TxtName);
            this.PnlData.Controls.Add(this.TxtCodeLen);
            this.PnlData.Controls.Add(this.label3);
            this.PnlData.Controls.Add(this.label2);
            this.PnlData.Controls.Add(this.TxtLastDate);
            this.PnlData.Controls.Add(this.TxtID);
            this.PnlData.Location = new System.Drawing.Point(2, 64);
            this.PnlData.Name = "PnlData";
            this.PnlData.Size = new System.Drawing.Size(493, 119);
            this.PnlData.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(18, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Param Master";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(331, 0);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(122, 21);
            this.TxtID.TabIndex = 0;
            this.TxtID.Visible = false;
            // 
            // FrmParamMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 188);
            this.Controls.Add(this.PnlButton);
            this.Controls.Add(this.PnlData);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmParamMaster";
            this.Text = "FrmParamMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmParamMaster_Load);
            this.PnlButton.ResumeLayout(false);
            this.PnlData.ResumeLayout(false);
            this.PnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtCodeLen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLastDate;
        internal System.Windows.Forms.Panel PnlButton;
        internal System.Windows.Forms.Button BtnExit;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnView;
        internal System.Windows.Forms.Button BtnDelete;
        internal System.Windows.Forms.Button BtnEdit;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.CheckBox ChkDefValue;
        private System.Windows.Forms.Panel PnlData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtID;
    }
}