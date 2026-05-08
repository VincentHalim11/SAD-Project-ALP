namespace ELLENA_HANDMADE_SAD_CODING.Resources
{
    partial class Userlist
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
            this.btn_backuserlist = new System.Windows.Forms.Button();
            this.dgv_listuser = new System.Windows.Forms.DataGridView();
            this.lbl_ProductNameDetailPemesanan = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_adduser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listuser)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backuserlist
            // 
            this.btn_backuserlist.BackColor = System.Drawing.Color.Thistle;
            this.btn_backuserlist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_backuserlist.Location = new System.Drawing.Point(29, 43);
            this.btn_backuserlist.Name = "btn_backuserlist";
            this.btn_backuserlist.Size = new System.Drawing.Size(164, 48);
            this.btn_backuserlist.TabIndex = 56;
            this.btn_backuserlist.Text = "Back";
            this.btn_backuserlist.UseVisualStyleBackColor = false;
            this.btn_backuserlist.Click += new System.EventHandler(this.btn_backuserlist_Click);
            // 
            // dgv_listuser
            // 
            this.dgv_listuser.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgv_listuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listuser.Location = new System.Drawing.Point(285, 78);
            this.dgv_listuser.Name = "dgv_listuser";
            this.dgv_listuser.ReadOnly = true;
            this.dgv_listuser.RowHeadersWidth = 62;
            this.dgv_listuser.RowTemplate.Height = 28;
            this.dgv_listuser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listuser.Size = new System.Drawing.Size(790, 325);
            this.dgv_listuser.TabIndex = 57;
            // 
            // lbl_ProductNameDetailPemesanan
            // 
            this.lbl_ProductNameDetailPemesanan.AutoSize = true;
            this.lbl_ProductNameDetailPemesanan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ProductNameDetailPemesanan.Font = new System.Drawing.Font("Javanese Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductNameDetailPemesanan.Location = new System.Drawing.Point(586, 11);
            this.lbl_ProductNameDetailPemesanan.Name = "lbl_ProductNameDetailPemesanan";
            this.lbl_ProductNameDetailPemesanan.Size = new System.Drawing.Size(146, 64);
            this.lbl_ProductNameDetailPemesanan.TabIndex = 58;
            this.lbl_ProductNameDetailPemesanan.Text = "User List";
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Thistle;
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_remove.Location = new System.Drawing.Point(385, 460);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(176, 58);
            this.btn_remove.TabIndex = 59;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_adduser
            // 
            this.btn_adduser.BackColor = System.Drawing.Color.Thistle;
            this.btn_adduser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_adduser.Location = new System.Drawing.Point(733, 460);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(205, 58);
            this.btn_adduser.TabIndex = 60;
            this.btn_adduser.Text = "Add";
            this.btn_adduser.UseVisualStyleBackColor = false;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // Userlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELLENA_HANDMADE_SAD_CODING.Properties.Resources.Menu_Utama__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1115, 628);
            this.Controls.Add(this.btn_adduser);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lbl_ProductNameDetailPemesanan);
            this.Controls.Add(this.dgv_listuser);
            this.Controls.Add(this.btn_backuserlist);
            this.DoubleBuffered = true;
            this.Name = "Userlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Userlist";
            this.Load += new System.EventHandler(this.Userlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_backuserlist;
        private System.Windows.Forms.DataGridView dgv_listuser;
        private System.Windows.Forms.Label lbl_ProductNameDetailPemesanan;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_adduser;
    }
}