namespace KSDMS
{
    partial class FrmLogin
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
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCancel = new System.Windows.Forms.Button();
            this.CmdLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLoginID = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.PnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLogin
            // 
            this.PnlLogin.Controls.Add(this.label1);
            this.PnlLogin.Controls.Add(this.TxtCancel);
            this.PnlLogin.Controls.Add(this.CmdLogin);
            this.PnlLogin.Controls.Add(this.label2);
            this.PnlLogin.Controls.Add(this.TxtLoginID);
            this.PnlLogin.Controls.Add(this.TxtPassword);
            this.PnlLogin.Location = new System.Drawing.Point(12, 12);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(304, 126);
            this.PnlLogin.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login ID";
            // 
            // TxtCancel
            // 
            this.TxtCancel.Location = new System.Drawing.Point(192, 90);
            this.TxtCancel.Name = "TxtCancel";
            this.TxtCancel.Size = new System.Drawing.Size(83, 24);
            this.TxtCancel.TabIndex = 4;
            this.TxtCancel.Text = "Cancel";
            this.TxtCancel.UseVisualStyleBackColor = true;
            this.TxtCancel.Click += new System.EventHandler(this.TxtCancel_Click);
            // 
            // CmdLogin
            // 
            this.CmdLogin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdLogin.Location = new System.Drawing.Point(89, 90);
            this.CmdLogin.Name = "CmdLogin";
            this.CmdLogin.Size = new System.Drawing.Size(83, 24);
            this.CmdLogin.TabIndex = 3;
            this.CmdLogin.Text = "Login";
            this.CmdLogin.UseVisualStyleBackColor = true;
            this.CmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // TxtLoginID
            // 
            this.TxtLoginID.Location = new System.Drawing.Point(89, 28);
            this.TxtLoginID.Name = "TxtLoginID";
            this.TxtLoginID.Size = new System.Drawing.Size(186, 20);
            this.TxtLoginID.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(89, 56);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(186, 20);
            this.TxtPassword.TabIndex = 2;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 151);
            this.Controls.Add(this.PnlLogin);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TxtCancel;
        private System.Windows.Forms.Button CmdLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLoginID;
        private System.Windows.Forms.TextBox TxtPassword;
    }
}

