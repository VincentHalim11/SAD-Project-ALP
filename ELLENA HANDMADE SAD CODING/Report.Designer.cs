namespace ELLENA_HANDMADE_SAD_CODING
{
    partial class Report
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
            this.lbl_reportreport = new System.Windows.Forms.Label();
            this.btn_backreport = new System.Windows.Forms.Button();
            this.lbl_filterreport = new System.Windows.Forms.Label();
            this.dgv_report = new System.Windows.Forms.DataGridView();
            this.dtp_now = new System.Windows.Forms.DateTimePicker();
            this.dtp_filter = new System.Windows.Forms.DateTimePicker();
            this.btn_filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_reportreport
            // 
            this.lbl_reportreport.AutoSize = true;
            this.lbl_reportreport.BackColor = System.Drawing.Color.Transparent;
            this.lbl_reportreport.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reportreport.Location = new System.Drawing.Point(12, 22);
            this.lbl_reportreport.Name = "lbl_reportreport";
            this.lbl_reportreport.Size = new System.Drawing.Size(77, 41);
            this.lbl_reportreport.TabIndex = 11;
            this.lbl_reportreport.Text = "Report";
            // 
            // btn_backreport
            // 
            this.btn_backreport.BackColor = System.Drawing.Color.Thistle;
            this.btn_backreport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_backreport.Location = new System.Drawing.Point(19, 66);
            this.btn_backreport.Name = "btn_backreport";
            this.btn_backreport.Size = new System.Drawing.Size(93, 37);
            this.btn_backreport.TabIndex = 16;
            this.btn_backreport.Text = "Back";
            this.btn_backreport.UseVisualStyleBackColor = false;
            this.btn_backreport.Click += new System.EventHandler(this.btn_backreport_Click);
            // 
            // lbl_filterreport
            // 
            this.lbl_filterreport.AutoSize = true;
            this.lbl_filterreport.BackColor = System.Drawing.Color.Transparent;
            this.lbl_filterreport.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filterreport.Location = new System.Drawing.Point(272, 15);
            this.lbl_filterreport.Name = "lbl_filterreport";
            this.lbl_filterreport.Size = new System.Drawing.Size(101, 54);
            this.lbl_filterreport.TabIndex = 17;
            this.lbl_filterreport.Text = "Filter : ";
            // 
            // dgv_report
            // 
            this.dgv_report.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgv_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_report.Location = new System.Drawing.Point(346, 88);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.ReadOnly = true;
            this.dgv_report.RowHeadersWidth = 62;
            this.dgv_report.RowTemplate.Height = 28;
            this.dgv_report.Size = new System.Drawing.Size(695, 396);
            this.dgv_report.TabIndex = 19;
            // 
            // dtp_now
            // 
            this.dtp_now.Enabled = false;
            this.dtp_now.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_now.Location = new System.Drawing.Point(903, 28);
            this.dtp_now.Name = "dtp_now";
            this.dtp_now.Size = new System.Drawing.Size(138, 26);
            this.dtp_now.TabIndex = 20;
            this.dtp_now.Visible = false;
            // 
            // dtp_filter
            // 
            this.dtp_filter.Enabled = false;
            this.dtp_filter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_filter.Location = new System.Drawing.Point(367, 28);
            this.dtp_filter.Name = "dtp_filter";
            this.dtp_filter.Size = new System.Drawing.Size(149, 26);
            this.dtp_filter.TabIndex = 21;
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.Thistle;
            this.btn_filter.Location = new System.Drawing.Point(533, 28);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(51, 26);
            this.btn_filter.TabIndex = 22;
            this.btn_filter.Text = "ON";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELLENA_HANDMADE_SAD_CODING.Properties.Resources.Menu_Utama__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1115, 628);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.dtp_filter);
            this.Controls.Add(this.dtp_now);
            this.Controls.Add(this.dgv_report);
            this.Controls.Add(this.lbl_filterreport);
            this.Controls.Add(this.btn_backreport);
            this.Controls.Add(this.lbl_reportreport);
            this.DoubleBuffered = true;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_reportreport;
        private System.Windows.Forms.Button btn_backreport;
        private System.Windows.Forms.Label lbl_filterreport;
        private System.Windows.Forms.DataGridView dgv_report;
        private System.Windows.Forms.DateTimePicker dtp_now;
        private System.Windows.Forms.DateTimePicker dtp_filter;
        private System.Windows.Forms.Button btn_filter;
    }
}