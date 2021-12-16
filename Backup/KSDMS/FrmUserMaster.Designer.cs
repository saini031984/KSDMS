namespace KSDMS
{
    partial class FrmUserMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserMaster));
            this.TxtDouneCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CmbLanguage = new System.Windows.Forms.ComboBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.PnlButton = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtRePassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.PnlData = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbRoll = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbDpt = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtFName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtMName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbLocation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.TxtLName = new System.Windows.Forms.TextBox();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLastDate = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.PnlButton.SuspendLayout();
            this.PnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtDouneCode
            // 
            this.TxtDouneCode.Location = new System.Drawing.Point(424, 50);
            this.TxtDouneCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtDouneCode.MaxLength = 10;
            this.TxtDouneCode.Name = "TxtDouneCode";
            this.TxtDouneCode.Size = new System.Drawing.Size(195, 21);
            this.TxtDouneCode.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(342, 49);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Number";
            // 
            // CmbLanguage
            // 
            this.CmbLanguage.FormattingEnabled = true;
            this.CmbLanguage.Location = new System.Drawing.Point(424, 160);
            this.CmbLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbLanguage.Name = "CmbLanguage";
            this.CmbLanguage.Size = new System.Drawing.Size(198, 21);
            this.CmbLanguage.TabIndex = 9;
            this.CmbLanguage.Visible = false;
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnExit.Location = new System.Drawing.Point(503, 2);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnExit.Size = new System.Drawing.Size(71, 56);
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
            this.BtnPrint.Location = new System.Drawing.Point(431, 2);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnPrint.Size = new System.Drawing.Size(71, 56);
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
            this.PnlButton.Location = new System.Drawing.Point(1, 1);
            this.PnlButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.Size = new System.Drawing.Size(656, 61);
            this.PnlButton.TabIndex = 33;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancel.BackgroundImage")));
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.Location = new System.Drawing.Point(360, 2);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnCancel.Size = new System.Drawing.Size(71, 56);
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
            this.BtnView.Location = new System.Drawing.Point(290, 2);
            this.BtnView.Margin = new System.Windows.Forms.Padding(0);
            this.BtnView.Name = "BtnView";
            this.BtnView.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnView.Size = new System.Drawing.Size(71, 56);
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
            this.BtnDelete.Location = new System.Drawing.Point(218, 2);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnDelete.Size = new System.Drawing.Size(71, 56);
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
            this.BtnEdit.Location = new System.Drawing.Point(147, 2);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnEdit.Size = new System.Drawing.Size(71, 56);
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
            this.BtnSave.Location = new System.Drawing.Point(76, 2);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnSave.Size = new System.Drawing.Size(71, 56);
            this.BtnSave.TabIndex = 13;
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
            this.BtnAdd.Size = new System.Drawing.Size(71, 56);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "&Add New ";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(342, 162);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Language";
            this.label12.Visible = false;
            // 
            // TxtRePassword
            // 
            this.TxtRePassword.Location = new System.Drawing.Point(429, 188);
            this.TxtRePassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtRePassword.MaxLength = 100;
            this.TxtRePassword.Name = "TxtRePassword";
            this.TxtRePassword.PasswordChar = '*';
            this.TxtRePassword.Size = new System.Drawing.Size(193, 21);
            this.TxtRePassword.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Re Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(101, 187);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPassword.MaxLength = 100;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(193, 21);
            this.TxtPassword.TabIndex = 10;
            // 
            // PnlData
            // 
            this.PnlData.Controls.Add(this.TxtDouneCode);
            this.PnlData.Controls.Add(this.label13);
            this.PnlData.Controls.Add(this.CmbLanguage);
            this.PnlData.Controls.Add(this.label12);
            this.PnlData.Controls.Add(this.TxtRePassword);
            this.PnlData.Controls.Add(this.label7);
            this.PnlData.Controls.Add(this.TxtPassword);
            this.PnlData.Controls.Add(this.label6);
            this.PnlData.Controls.Add(this.CmbRoll);
            this.PnlData.Controls.Add(this.label5);
            this.PnlData.Controls.Add(this.CmbDpt);
            this.PnlData.Controls.Add(this.label11);
            this.PnlData.Controls.Add(this.TxtFName);
            this.PnlData.Controls.Add(this.label10);
            this.PnlData.Controls.Add(this.TxtMName);
            this.PnlData.Controls.Add(this.label9);
            this.PnlData.Controls.Add(this.CmbLocation);
            this.PnlData.Controls.Add(this.label8);
            this.PnlData.Controls.Add(this.TxtEmail);
            this.PnlData.Controls.Add(this.label4);
            this.PnlData.Controls.Add(this.ChkActive);
            this.PnlData.Controls.Add(this.TxtLName);
            this.PnlData.Controls.Add(this.TxtCode);
            this.PnlData.Controls.Add(this.label3);
            this.PnlData.Controls.Add(this.label2);
            this.PnlData.Controls.Add(this.label1);
            this.PnlData.Controls.Add(this.TxtLastDate);
            this.PnlData.Controls.Add(this.TxtID);
            this.PnlData.Location = new System.Drawing.Point(1, 63);
            this.PnlData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlData.Name = "PnlData";
            this.PnlData.Size = new System.Drawing.Size(656, 223);
            this.PnlData.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Password";
            // 
            // CmbRoll
            // 
            this.CmbRoll.FormattingEnabled = true;
            this.CmbRoll.Location = new System.Drawing.Point(424, 135);
            this.CmbRoll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbRoll.Name = "CmbRoll";
            this.CmbRoll.Size = new System.Drawing.Size(198, 21);
            this.CmbRoll.TabIndex = 8;
            this.CmbRoll.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "User Roll";
            this.label5.Visible = false;
            // 
            // CmbDpt
            // 
            this.CmbDpt.FormattingEnabled = true;
            this.CmbDpt.Location = new System.Drawing.Point(424, 110);
            this.CmbDpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbDpt.Name = "CmbDpt";
            this.CmbDpt.Size = new System.Drawing.Size(198, 21);
            this.CmbDpt.TabIndex = 7;
            this.CmbDpt.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(342, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Grade";
            this.label11.Visible = false;
            // 
            // TxtFName
            // 
            this.TxtFName.Location = new System.Drawing.Point(101, 134);
            this.TxtFName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtFName.MaxLength = 100;
            this.TxtFName.Name = "TxtFName";
            this.TxtFName.Size = new System.Drawing.Size(193, 21);
            this.TxtFName.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 134);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "First Name";
            // 
            // TxtMName
            // 
            this.TxtMName.Location = new System.Drawing.Point(101, 107);
            this.TxtMName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtMName.MaxLength = 100;
            this.TxtMName.Name = "TxtMName";
            this.TxtMName.Size = new System.Drawing.Size(193, 21);
            this.TxtMName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mid. Name";
            // 
            // CmbLocation
            // 
            this.CmbLocation.FormattingEnabled = true;
            this.CmbLocation.Location = new System.Drawing.Point(424, 83);
            this.CmbLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbLocation.Name = "CmbLocation";
            this.CmbLocation.Size = new System.Drawing.Size(198, 21);
            this.CmbLocation.TabIndex = 6;
            this.CmbLocation.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Location";
            this.label8.Visible = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(101, 161);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(193, 21);
            this.TxtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Location = new System.Drawing.Point(537, 25);
            this.ChkActive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(82, 17);
            this.ChkActive.TabIndex = 12;
            this.ChkActive.Text = "Is Active?";
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // TxtLName
            // 
            this.TxtLName.Location = new System.Drawing.Point(99, 80);
            this.TxtLName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtLName.MaxLength = 100;
            this.TxtLName.Name = "TxtLName";
            this.TxtLName.Size = new System.Drawing.Size(195, 21);
            this.TxtLName.TabIndex = 2;
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(99, 46);
            this.TxtCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCode.MaxLength = 2;
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(195, 21);
            this.TxtCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Master";
            // 
            // TxtLastDate
            // 
            this.TxtLastDate.Location = new System.Drawing.Point(467, 23);
            this.TxtLastDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtLastDate.Name = "TxtLastDate";
            this.TxtLastDate.Size = new System.Drawing.Size(141, 21);
            this.TxtLastDate.TabIndex = 1;
            this.TxtLastDate.Visible = false;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(467, 7);
            this.TxtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(141, 21);
            this.TxtID.TabIndex = 0;
            this.TxtID.Visible = false;
            // 
            // FrmUserMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 290);
            this.Controls.Add(this.PnlButton);
            this.Controls.Add(this.PnlData);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmUserMaster";
            this.Text = "FrmUserMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUserMaster_Load);
            this.PnlButton.ResumeLayout(false);
            this.PnlData.ResumeLayout(false);
            this.PnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDouneCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CmbLanguage;
        internal System.Windows.Forms.Button BtnExit;
        internal System.Windows.Forms.Button BtnPrint;
        internal System.Windows.Forms.Panel PnlButton;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnView;
        internal System.Windows.Forms.Button BtnDelete;
        internal System.Windows.Forms.Button BtnEdit;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtRePassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Panel PnlData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbRoll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbDpt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtFName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtMName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.TextBox TxtLName;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLastDate;
        private System.Windows.Forms.TextBox TxtID;

    }
}