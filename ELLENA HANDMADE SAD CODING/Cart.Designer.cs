namespace ELLENA_HANDMADE_SAD_CODING
{
    partial class Cart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_backCart = new System.Windows.Forms.Button();
            this.lbl_CartCart = new System.Windows.Forms.Label();
            this.dgv_Cart = new System.Windows.Forms.DataGridView();
            this.lbl_DetailCustomerCart = new System.Windows.Forms.Label();
            this.tb_AddressCart = new System.Windows.Forms.TextBox();
            this.lbl_AddressCart = new System.Windows.Forms.Label();
            this.tb_PhoneNumberCart = new System.Windows.Forms.TextBox();
            this.lbl_PhoneNumberCart = new System.Windows.Forms.Label();
            this.tb_NameCart = new System.Windows.Forms.TextBox();
            this.lbl_NameCart = new System.Windows.Forms.Label();
            this.lbl_PaymentMetodeCart = new System.Windows.Forms.Label();
            this.tb_ShippingFeeCart = new System.Windows.Forms.TextBox();
            this.lbl_ShippingfeeCart = new System.Windows.Forms.Label();
            this.tb_TotalProductCart = new System.Windows.Forms.TextBox();
            this.lbl_TotalProductCart = new System.Windows.Forms.Label();
            this.lbl_CostCart = new System.Windows.Forms.Label();
            this.btn_confirmCart = new System.Windows.Forms.Button();
            this.cb_Cart = new System.Windows.Forms.ComboBox();
            this.tb_TotalCostCart = new System.Windows.Forms.TextBox();
            this.lbl_TotalCostCart = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cart)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backCart
            // 
            this.btn_backCart.BackColor = System.Drawing.Color.Thistle;
            this.btn_backCart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_backCart.Location = new System.Drawing.Point(35, 65);
            this.btn_backCart.Name = "btn_backCart";
            this.btn_backCart.Size = new System.Drawing.Size(142, 48);
            this.btn_backCart.TabIndex = 54;
            this.btn_backCart.Text = "Back";
            this.btn_backCart.UseVisualStyleBackColor = false;
            this.btn_backCart.Click += new System.EventHandler(this.btn_backCart_Click);
            // 
            // lbl_CartCart
            // 
            this.lbl_CartCart.AutoSize = true;
            this.lbl_CartCart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CartCart.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CartCart.Location = new System.Drawing.Point(639, -1);
            this.lbl_CartCart.Name = "lbl_CartCart";
            this.lbl_CartCart.Size = new System.Drawing.Size(72, 54);
            this.lbl_CartCart.TabIndex = 53;
            this.lbl_CartCart.Text = "Cart";
            // 
            // dgv_Cart
            // 
            this.dgv_Cart.AllowUserToResizeColumns = false;
            this.dgv_Cart.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Tomato;
            this.dgv_Cart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Cart.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgv_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cart.Location = new System.Drawing.Point(264, 43);
            this.dgv_Cart.Name = "dgv_Cart";
            this.dgv_Cart.ReadOnly = true;
            this.dgv_Cart.RowHeadersVisible = false;
            this.dgv_Cart.RowHeadersWidth = 62;
            this.dgv_Cart.RowTemplate.Height = 28;
            this.dgv_Cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cart.Size = new System.Drawing.Size(839, 254);
            this.dgv_Cart.TabIndex = 55;
            this.dgv_Cart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Cart_CellClick);
            // 
            // lbl_DetailCustomerCart
            // 
            this.lbl_DetailCustomerCart.AutoSize = true;
            this.lbl_DetailCustomerCart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DetailCustomerCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DetailCustomerCart.Location = new System.Drawing.Point(302, 368);
            this.lbl_DetailCustomerCart.Name = "lbl_DetailCustomerCart";
            this.lbl_DetailCustomerCart.Size = new System.Drawing.Size(185, 29);
            this.lbl_DetailCustomerCart.TabIndex = 56;
            this.lbl_DetailCustomerCart.Text = "Detail Customer";
            // 
            // tb_AddressCart
            // 
            this.tb_AddressCart.Location = new System.Drawing.Point(505, 472);
            this.tb_AddressCart.Name = "tb_AddressCart";
            this.tb_AddressCart.Size = new System.Drawing.Size(150, 26);
            this.tb_AddressCart.TabIndex = 62;
            // 
            // lbl_AddressCart
            // 
            this.lbl_AddressCart.AutoSize = true;
            this.lbl_AddressCart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AddressCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddressCart.Location = new System.Drawing.Point(305, 472);
            this.lbl_AddressCart.Name = "lbl_AddressCart";
            this.lbl_AddressCart.Size = new System.Drawing.Size(120, 29);
            this.lbl_AddressCart.TabIndex = 61;
            this.lbl_AddressCart.Text = "Address : ";
            // 
            // tb_PhoneNumberCart
            // 
            this.tb_PhoneNumberCart.Location = new System.Drawing.Point(505, 440);
            this.tb_PhoneNumberCart.Name = "tb_PhoneNumberCart";
            this.tb_PhoneNumberCart.Size = new System.Drawing.Size(150, 26);
            this.tb_PhoneNumberCart.TabIndex = 60;
            // 
            // lbl_PhoneNumberCart
            // 
            this.lbl_PhoneNumberCart.AutoSize = true;
            this.lbl_PhoneNumberCart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PhoneNumberCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhoneNumberCart.Location = new System.Drawing.Point(305, 440);
            this.lbl_PhoneNumberCart.Name = "lbl_PhoneNumberCart";
            this.lbl_PhoneNumberCart.Size = new System.Drawing.Size(194, 29);
            this.lbl_PhoneNumberCart.TabIndex = 59;
            this.lbl_PhoneNumberCart.Text = "Phone Number : ";
            // 
            // tb_NameCart
            // 
            this.tb_NameCart.Enabled = false;
            this.tb_NameCart.Location = new System.Drawing.Point(505, 408);
            this.tb_NameCart.Name = "tb_NameCart";
            this.tb_NameCart.Size = new System.Drawing.Size(150, 26);
            this.tb_NameCart.TabIndex = 58;
            // 
            // lbl_NameCart
            // 
            this.lbl_NameCart.AutoSize = true;
            this.lbl_NameCart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NameCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameCart.Location = new System.Drawing.Point(305, 408);
            this.lbl_NameCart.Name = "lbl_NameCart";
            this.lbl_NameCart.Size = new System.Drawing.Size(96, 29);
            this.lbl_NameCart.TabIndex = 57;
            this.lbl_NameCart.Text = "Name : ";
            // 
            // lbl_PaymentMetodeCart
            // 
            this.lbl_PaymentMetodeCart.AutoSize = true;
            this.lbl_PaymentMetodeCart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PaymentMetodeCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PaymentMetodeCart.Location = new System.Drawing.Point(662, 511);
            this.lbl_PaymentMetodeCart.Name = "lbl_PaymentMetodeCart";
            this.lbl_PaymentMetodeCart.Size = new System.Drawing.Size(212, 29);
            this.lbl_PaymentMetodeCart.TabIndex = 67;
            this.lbl_PaymentMetodeCart.Text = "Payment Metode : ";
            // 
            // tb_ShippingFeeCart
            // 
            this.tb_ShippingFeeCart.Location = new System.Drawing.Point(887, 444);
            this.tb_ShippingFeeCart.Name = "tb_ShippingFeeCart";
            this.tb_ShippingFeeCart.Size = new System.Drawing.Size(150, 26);
            this.tb_ShippingFeeCart.TabIndex = 66;
            this.tb_ShippingFeeCart.Text = "0";
            this.tb_ShippingFeeCart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ShippingFeeCart_KeyPress);
            // 
            // lbl_ShippingfeeCart
            // 
            this.lbl_ShippingfeeCart.AutoSize = true;
            this.lbl_ShippingfeeCart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ShippingfeeCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShippingfeeCart.Location = new System.Drawing.Point(662, 440);
            this.lbl_ShippingfeeCart.Name = "lbl_ShippingfeeCart";
            this.lbl_ShippingfeeCart.Size = new System.Drawing.Size(176, 29);
            this.lbl_ShippingfeeCart.TabIndex = 65;
            this.lbl_ShippingfeeCart.Text = "Shipping Fee : ";
            // 
            // tb_TotalProductCart
            // 
            this.tb_TotalProductCart.Location = new System.Drawing.Point(887, 412);
            this.tb_TotalProductCart.Name = "tb_TotalProductCart";
            this.tb_TotalProductCart.Size = new System.Drawing.Size(150, 26);
            this.tb_TotalProductCart.TabIndex = 64;
            // 
            // lbl_TotalProductCart
            // 
            this.lbl_TotalProductCart.AutoSize = true;
            this.lbl_TotalProductCart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalProductCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalProductCart.Location = new System.Drawing.Point(662, 408);
            this.lbl_TotalProductCart.Name = "lbl_TotalProductCart";
            this.lbl_TotalProductCart.Size = new System.Drawing.Size(175, 29);
            this.lbl_TotalProductCart.TabIndex = 63;
            this.lbl_TotalProductCart.Text = "Total Product : ";
            // 
            // lbl_CostCart
            // 
            this.lbl_CostCart.AutoSize = true;
            this.lbl_CostCart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CostCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CostCart.Location = new System.Drawing.Point(661, 368);
            this.lbl_CostCart.Name = "lbl_CostCart";
            this.lbl_CostCart.Size = new System.Drawing.Size(62, 29);
            this.lbl_CostCart.TabIndex = 69;
            this.lbl_CostCart.Text = "Cost";
            // 
            // btn_confirmCart
            // 
            this.btn_confirmCart.BackColor = System.Drawing.Color.Thistle;
            this.btn_confirmCart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_confirmCart.Location = new System.Drawing.Point(887, 571);
            this.btn_confirmCart.Name = "btn_confirmCart";
            this.btn_confirmCart.Size = new System.Drawing.Size(150, 36);
            this.btn_confirmCart.TabIndex = 70;
            this.btn_confirmCart.Text = "Confirm";
            this.btn_confirmCart.UseVisualStyleBackColor = false;
            this.btn_confirmCart.Click += new System.EventHandler(this.btn_confirmCart_Click);
            // 
            // cb_Cart
            // 
            this.cb_Cart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Cart.FormattingEnabled = true;
            this.cb_Cart.Items.AddRange(new object[] {
            "C",
            "T"});
            this.cb_Cart.Location = new System.Drawing.Point(887, 513);
            this.cb_Cart.Name = "cb_Cart";
            this.cb_Cart.Size = new System.Drawing.Size(150, 28);
            this.cb_Cart.TabIndex = 71;
            // 
            // tb_TotalCostCart
            // 
            this.tb_TotalCostCart.Location = new System.Drawing.Point(887, 481);
            this.tb_TotalCostCart.Name = "tb_TotalCostCart";
            this.tb_TotalCostCart.Size = new System.Drawing.Size(150, 26);
            this.tb_TotalCostCart.TabIndex = 73;
            // 
            // lbl_TotalCostCart
            // 
            this.lbl_TotalCostCart.AutoSize = true;
            this.lbl_TotalCostCart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalCostCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalCostCart.Location = new System.Drawing.Point(662, 477);
            this.lbl_TotalCostCart.Name = "lbl_TotalCostCart";
            this.lbl_TotalCostCart.Size = new System.Drawing.Size(141, 29);
            this.lbl_TotalCostCart.TabIndex = 72;
            this.lbl_TotalCostCart.Text = "Total Cost : ";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Thistle;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.Location = new System.Drawing.Point(493, 315);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(150, 36);
            this.btn_add.TabIndex = 74;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Thistle;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete.Location = new System.Drawing.Point(724, 315);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 36);
            this.btn_delete.TabIndex = 75;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELLENA_HANDMADE_SAD_CODING.Properties.Resources.Menu_Utama__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1115, 628);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_TotalCostCart);
            this.Controls.Add(this.lbl_TotalCostCart);
            this.Controls.Add(this.cb_Cart);
            this.Controls.Add(this.btn_confirmCart);
            this.Controls.Add(this.lbl_CostCart);
            this.Controls.Add(this.lbl_PaymentMetodeCart);
            this.Controls.Add(this.tb_ShippingFeeCart);
            this.Controls.Add(this.lbl_ShippingfeeCart);
            this.Controls.Add(this.tb_TotalProductCart);
            this.Controls.Add(this.lbl_TotalProductCart);
            this.Controls.Add(this.tb_AddressCart);
            this.Controls.Add(this.lbl_AddressCart);
            this.Controls.Add(this.tb_PhoneNumberCart);
            this.Controls.Add(this.lbl_PhoneNumberCart);
            this.Controls.Add(this.tb_NameCart);
            this.Controls.Add(this.lbl_NameCart);
            this.Controls.Add(this.lbl_DetailCustomerCart);
            this.Controls.Add(this.dgv_Cart);
            this.Controls.Add(this.btn_backCart);
            this.Controls.Add(this.lbl_CartCart);
            this.DoubleBuffered = true;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_backCart;
        private System.Windows.Forms.Label lbl_CartCart;
        private System.Windows.Forms.DataGridView dgv_Cart;
        private System.Windows.Forms.Label lbl_DetailCustomerCart;
        private System.Windows.Forms.TextBox tb_AddressCart;
        private System.Windows.Forms.Label lbl_AddressCart;
        private System.Windows.Forms.TextBox tb_PhoneNumberCart;
        private System.Windows.Forms.Label lbl_PhoneNumberCart;
        private System.Windows.Forms.TextBox tb_NameCart;
        private System.Windows.Forms.Label lbl_NameCart;
        private System.Windows.Forms.Label lbl_PaymentMetodeCart;
        private System.Windows.Forms.TextBox tb_ShippingFeeCart;
        private System.Windows.Forms.Label lbl_ShippingfeeCart;
        private System.Windows.Forms.TextBox tb_TotalProductCart;
        private System.Windows.Forms.Label lbl_TotalProductCart;
        private System.Windows.Forms.Label lbl_CostCart;
        private System.Windows.Forms.Button btn_confirmCart;
        private System.Windows.Forms.ComboBox cb_Cart;
        private System.Windows.Forms.TextBox tb_TotalCostCart;
        private System.Windows.Forms.Label lbl_TotalCostCart;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Timer timer1;
    }
}