namespace KSDMS
{
    partial class FrmPopUp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GV = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.PnlBtn = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.SuspendLayout();
            // 
            // GV
            // 
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GV.Location = new System.Drawing.Point(6, 63);
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new System.Drawing.Size(742, 257);
            this.GV.TabIndex = 5;
            this.GV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GV_CellMouseDoubleClick);
            this.GV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GV_KeyPress);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(3, 37);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(745, 21);
            this.TxtSearch.TabIndex = 4;
            this.TxtSearch.AcceptsTabChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // PnlBtn
            // 
            this.PnlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PnlBtn.Location = new System.Drawing.Point(3, 0);
            this.PnlBtn.Name = "PnlBtn";
            this.PnlBtn.Size = new System.Drawing.Size(746, 31);
            this.PnlBtn.TabIndex = 3;
            // 
            // FrmPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(753, 326);
            this.Controls.Add(this.GV);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.PnlBtn);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "FrmPopUp";
            this.Text = "FrmPopUp";
            this.Load += new System.EventHandler(this.FrmPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Panel PnlBtn;
    }
}