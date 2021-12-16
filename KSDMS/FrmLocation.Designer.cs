namespace KSDMS
{
    partial class FrmLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocation));
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.CmbRegion = new System.Windows.Forms.ComboBox();
            this.XLAddress = new System.Windows.Forms.Label();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.PnlData = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.XLType = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.XLPhone = new System.Windows.Forms.Label();
            this.TxtZip = new System.Windows.Forms.TextBox();
            this.XLZip = new System.Windows.Forms.Label();
            this.TxtArea = new System.Windows.Forms.TextBox();
            this.XLArea = new System.Windows.Forms.Label();
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtShort = new System.Windows.Forms.TextBox();
            this.XLName = new System.Windows.Forms.Label();
            this.XLShort = new System.Windows.Forms.Label();
            this.XLHead = new System.Windows.Forms.Label();
            this.TxtLastDate = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.PnlButton = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.PnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbType
            // 
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Location = new System.Drawing.Point(129, 98);
            this.CmbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(150, 21);
            this.CmbType.TabIndex = 17;
            // 
            // CmbRegion
            // 
            this.CmbRegion.FormattingEnabled = true;
            this.CmbRegion.Location = new System.Drawing.Point(393, 98);
            this.CmbRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbRegion.Name = "CmbRegion";
            this.CmbRegion.Size = new System.Drawing.Size(217, 21);
            this.CmbRegion.TabIndex = 19;
            // 
            // XLAddress
            // 
            this.XLAddress.AutoSize = true;
            this.XLAddress.Location = new System.Drawing.Point(24, 130);
            this.XLAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XLAddress.Name = "XLAddress";
            this.XLAddress.Size = new System.Drawing.Size(53, 13);
            this.XLAddress.TabIndex = 8;
            this.XLAddress.Text = "Address";
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Location = new System.Drawing.Point(540, 54);
            this.ChkActive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(82, 17);
            this.ChkActive.TabIndex = 7;
            this.ChkActive.Text = "Is Active?";
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // PnlData
            // 
            this.PnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PnlData.Controls.Add(this.pictureBox1);
            this.PnlData.Controls.Add(this.TxtCity);
            this.PnlData.Controls.Add(this.label3);
            this.PnlData.Controls.Add(this.TxtCountry);
            this.PnlData.Controls.Add(this.label2);
            this.PnlData.Controls.Add(this.CmbRegion);
            this.PnlData.Controls.Add(this.label1);
            this.PnlData.Controls.Add(this.CmbType);
            this.PnlData.Controls.Add(this.XLType);
            this.PnlData.Controls.Add(this.TxtPhone);
            this.PnlData.Controls.Add(this.XLPhone);
            this.PnlData.Controls.Add(this.TxtZip);
            this.PnlData.Controls.Add(this.XLZip);
            this.PnlData.Controls.Add(this.TxtArea);
            this.PnlData.Controls.Add(this.XLArea);
            this.PnlData.Controls.Add(this.TxtAdd);
            this.PnlData.Controls.Add(this.XLAddress);
            this.PnlData.Controls.Add(this.ChkActive);
            this.PnlData.Controls.Add(this.TxtName);
            this.PnlData.Controls.Add(this.TxtShort);
            this.PnlData.Controls.Add(this.XLName);
            this.PnlData.Controls.Add(this.XLShort);
            this.PnlData.Controls.Add(this.XLHead);
            this.PnlData.Controls.Add(this.TxtLastDate);
            this.PnlData.Controls.Add(this.TxtID);
            this.PnlData.Location = new System.Drawing.Point(7, 68);
            this.PnlData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlData.Name = "PnlData";
            this.PnlData.Size = new System.Drawing.Size(629, 234);
            this.PnlData.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(588, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(129, 176);
            this.TxtCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCity.MaxLength = 100;
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(165, 21);
            this.TxtCity.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "City";
            // 
            // TxtCountry
            // 
            this.TxtCountry.Location = new System.Drawing.Point(393, 175);
            this.TxtCountry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCountry.MaxLength = 100;
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.ReadOnly = true;
            this.TxtCountry.Size = new System.Drawing.Size(201, 21);
            this.TxtCountry.TabIndex = 13;
            this.TxtCountry.Enter += new System.EventHandler(this.TxtCountry_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Continent Name";
            // 
            // XLType
            // 
            this.XLType.AutoSize = true;
            this.XLType.Location = new System.Drawing.Point(24, 103);
            this.XLType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XLType.Name = "XLType";
            this.XLType.Size = new System.Drawing.Size(35, 13);
            this.XLType.TabIndex = 16;
            this.XLType.Text = "Type";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(393, 202);
            this.TxtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPhone.MaxLength = 100;
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(217, 21);
            this.TxtPhone.TabIndex = 15;
            // 
            // XLPhone
            // 
            this.XLPhone.AutoSize = true;
            this.XLPhone.Location = new System.Drawing.Point(302, 210);
            this.XLPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XLPhone.Name = "XLPhone";
            this.XLPhone.Size = new System.Drawing.Size(42, 13);
            this.XLPhone.TabIndex = 14;
            this.XLPhone.Text = "Phone";
            // 
            // TxtZip
            // 
            this.TxtZip.Location = new System.Drawing.Point(129, 202);
            this.TxtZip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtZip.MaxLength = 100;
            this.TxtZip.Name = "TxtZip";
            this.TxtZip.Size = new System.Drawing.Size(165, 21);
            this.TxtZip.TabIndex = 14;
            // 
            // XLZip
            // 
            this.XLZip.AutoSize = true;
            this.XLZip.Location = new System.Drawing.Point(24, 212);
            this.XLZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XLZip.Name = "XLZip";
            this.XLZip.Size = new System.Drawing.Size(25, 13);
            this.XLZip.TabIndex = 12;
            this.XLZip.Text = "Zip";
            // 
            // TxtArea
            // 
            this.TxtArea.Location = new System.Drawing.Point(129, 150);
            this.TxtArea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtArea.MaxLength = 100;
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.Size = new System.Drawing.Size(480, 21);
            this.TxtArea.TabIndex = 11;
            // 
            // XLArea
            // 
            this.XLArea.AutoSize = true;
            this.XLArea.Location = new System.Drawing.Point(24, 157);
            this.XLArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XLArea.Name = "XLArea";
            this.XLArea.Size = new System.Drawing.Size(34, 13);
            this.XLArea.TabIndex = 10;
            this.XLArea.Text = "Area";
            // 
            // TxtAdd
            // 
            this.TxtAdd.Location = new System.Drawing.Point(129, 124);
            this.TxtAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAdd.MaxLength = 100;
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(480, 21);
            this.TxtAdd.TabIndex = 9;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(129, 72);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtName.MaxLength = 100;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(480, 21);
            this.TxtName.TabIndex = 6;
            // 
            // TxtShort
            // 
            this.TxtShort.Location = new System.Drawing.Point(129, 46);
            this.TxtShort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtShort.MaxLength = 3;
            this.TxtShort.Name = "TxtShort";
            this.TxtShort.Size = new System.Drawing.Size(90, 21);
            this.TxtShort.TabIndex = 5;
            // 
            // XLName
            // 
            this.XLName.AutoSize = true;
            this.XLName.Location = new System.Drawing.Point(24, 76);
            this.XLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XLName.Name = "XLName";
            this.XLName.Size = new System.Drawing.Size(40, 13);
            this.XLName.TabIndex = 4;
            this.XLName.Text = "Name";
            // 
            // XLShort
            // 
            this.XLShort.AutoSize = true;
            this.XLShort.Location = new System.Drawing.Point(24, 49);
            this.XLShort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XLShort.Name = "XLShort";
            this.XLShort.Size = new System.Drawing.Size(38, 13);
            this.XLShort.TabIndex = 3;
            this.XLShort.Text = "Short";
            // 
            // XLHead
            // 
            this.XLHead.AutoSize = true;
            this.XLHead.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.XLHead.Location = new System.Drawing.Point(11, 7);
            this.XLHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.XLHead.Name = "XLHead";
            this.XLHead.Size = new System.Drawing.Size(198, 25);
            this.XLHead.TabIndex = 2;
            this.XLHead.Text = "Location Master";
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
            this.PnlButton.Location = new System.Drawing.Point(7, 1);
            this.PnlButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlButton.Name = "PnlButton";
            this.PnlButton.Size = new System.Drawing.Size(629, 61);
            this.PnlButton.TabIndex = 31;
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(368, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnExit.Size = new System.Drawing.Size(73, 56);
            this.BtnExit.TabIndex = 89;
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
            this.BtnCancel.Location = new System.Drawing.Point(307, 0);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnCancel.Size = new System.Drawing.Size(61, 56);
            this.BtnCancel.TabIndex = 88;
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
            this.BtnView.Location = new System.Drawing.Point(246, 0);
            this.BtnView.Margin = new System.Windows.Forms.Padding(0);
            this.BtnView.Name = "BtnView";
            this.BtnView.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnView.Size = new System.Drawing.Size(61, 56);
            this.BtnView.TabIndex = 87;
            this.BtnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(185, 0);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnDelete.Size = new System.Drawing.Size(61, 56);
            this.BtnDelete.TabIndex = 86;
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
            this.BtnEdit.Location = new System.Drawing.Point(124, 0);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnEdit.Size = new System.Drawing.Size(61, 56);
            this.BtnEdit.TabIndex = 85;
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
            this.BtnSave.Location = new System.Drawing.Point(63, 0);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnSave.Size = new System.Drawing.Size(61, 56);
            this.BtnSave.TabIndex = 84;
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
            this.BtnAdd.Location = new System.Drawing.Point(2, 0);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnAdd.Size = new System.Drawing.Size(61, 56);
            this.BtnAdd.TabIndex = 83;
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 314);
            this.Controls.Add(this.PnlData);
            this.Controls.Add(this.PnlButton);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmLocation";
            this.Text = "FrmLocation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            this.PnlData.ResumeLayout(false);
            this.PnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.ComboBox CmbRegion;
        private System.Windows.Forms.Label XLAddress;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.Panel PnlData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label XLType;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label XLPhone;
        private System.Windows.Forms.TextBox TxtZip;
        private System.Windows.Forms.Label XLZip;
        private System.Windows.Forms.TextBox TxtArea;
        private System.Windows.Forms.Label XLArea;
        private System.Windows.Forms.TextBox TxtAdd;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtShort;
        private System.Windows.Forms.Label XLName;
        private System.Windows.Forms.Label XLShort;
        private System.Windows.Forms.Label XLHead;
        private System.Windows.Forms.TextBox TxtLastDate;
        private System.Windows.Forms.TextBox TxtID;
        internal System.Windows.Forms.Panel PnlButton;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button BtnExit;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnView;
        internal System.Windows.Forms.Button BtnDelete;
        internal System.Windows.Forms.Button BtnEdit;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button BtnAdd;
    }
}