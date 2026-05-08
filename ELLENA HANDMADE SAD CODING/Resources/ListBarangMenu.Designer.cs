namespace ELLENA_HANDMADE_SAD_CODING.Resources
{
    partial class ListBarangMenu
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
            this.btn_backtomenu = new System.Windows.Forms.Button();
            this.dgv_listproduk = new System.Windows.Forms.DataGridView();
            this.btn_editproduk = new System.Windows.Forms.Button();
            this.btn_addproduk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listproduk)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backtomenu
            // 
            this.btn_backtomenu.BackColor = System.Drawing.Color.Thistle;
            this.btn_backtomenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_backtomenu.Location = new System.Drawing.Point(12, 48);
            this.btn_backtomenu.Name = "btn_backtomenu";
            this.btn_backtomenu.Size = new System.Drawing.Size(184, 37);
            this.btn_backtomenu.TabIndex = 57;
            this.btn_backtomenu.Text = "Back";
            this.btn_backtomenu.UseVisualStyleBackColor = false;
            this.btn_backtomenu.Click += new System.EventHandler(this.btn_backtomenu_Click);
            // 
            // dgv_listproduk
            // 
            this.dgv_listproduk.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgv_listproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listproduk.Location = new System.Drawing.Point(255, 73);
            this.dgv_listproduk.Name = "dgv_listproduk";
            this.dgv_listproduk.ReadOnly = true;
            this.dgv_listproduk.RowHeadersWidth = 62;
            this.dgv_listproduk.RowTemplate.Height = 28;
            this.dgv_listproduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listproduk.Size = new System.Drawing.Size(461, 315);
            this.dgv_listproduk.TabIndex = 58;
            // 
            // btn_editproduk
            // 
            this.btn_editproduk.BackColor = System.Drawing.Color.Thistle;
            this.btn_editproduk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_editproduk.Location = new System.Drawing.Point(514, 424);
            this.btn_editproduk.Name = "btn_editproduk";
            this.btn_editproduk.Size = new System.Drawing.Size(202, 52);
            this.btn_editproduk.TabIndex = 62;
            this.btn_editproduk.Text = "Edit";
            this.btn_editproduk.UseVisualStyleBackColor = false;
            this.btn_editproduk.Click += new System.EventHandler(this.btn_editproduk_Click);
            // 
            // btn_addproduk
            // 
            this.btn_addproduk.BackColor = System.Drawing.Color.Thistle;
            this.btn_addproduk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addproduk.Location = new System.Drawing.Point(255, 424);
            this.btn_addproduk.Name = "btn_addproduk";
            this.btn_addproduk.Size = new System.Drawing.Size(202, 52);
            this.btn_addproduk.TabIndex = 61;
            this.btn_addproduk.Text = "Add";
            this.btn_addproduk.UseVisualStyleBackColor = false;
            this.btn_addproduk.Click += new System.EventHandler(this.btn_addproduk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 41);
            this.label1.TabIndex = 64;
            this.label1.Text = "List Data Produk";
            // 
            // ListBarangMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELLENA_HANDMADE_SAD_CODING.Properties.Resources.Menu_Utama__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1115, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_editproduk);
            this.Controls.Add(this.btn_addproduk);
            this.Controls.Add(this.dgv_listproduk);
            this.Controls.Add(this.btn_backtomenu);
            this.DoubleBuffered = true;
            this.Name = "ListBarangMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBarangMenu";
            this.Load += new System.EventHandler(this.ListBarangMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listproduk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_backtomenu;
        private System.Windows.Forms.DataGridView dgv_listproduk;
        private System.Windows.Forms.Button btn_editproduk;
        private System.Windows.Forms.Button btn_addproduk;
        private System.Windows.Forms.Label label1;
    }
}