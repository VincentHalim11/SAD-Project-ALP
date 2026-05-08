using ELLENA_HANDMADE_SAD_CODING.Resources;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELLENA_HANDMADE_SAD_CODING
{
    public partial class AddProduct : Form
    {
        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        string role;
        string queryproduk;
        string querydetail;
        string idproduk;
      
        public AddProduct(MySqlConnection konek,string role)
        {
            InitializeComponent();
            this.role = role;
            connect = konek;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void btn_backAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                ListBarangMenu menu = new ListBarangMenu(connect, role);
                menu.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        private void btn_confirmAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string generatedId = idnya();
                produk();

                // Check if the ID was generated successfully
                if (!string.IsNullOrEmpty(generatedId))
                {
                    // Then, insert into the detail_produk table
                    detail_produk();
                   
                }
                else
                {
                    MessageBox.Show("Gagal menghasilkan ID produk.");
                }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_confirmdetail_Click(object sender, EventArgs e)
        {

        }

        private string idnya()
        {
            string generatedId = string.Empty;
            try
            {
                command = new MySqlCommand();
                command.Connection = connect;
                command.CommandText = "SELECT fGenIDProduk(@JENIS_PRODUK)";

                command.Parameters.AddWithValue("@JENIS_PRODUK", cb_tipe.Text);

                connect.Open();
                generatedId = command.ExecuteScalar().ToString(); // Use ExecuteScalar to get the generated ID

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return generatedId; 
        }

        private void produk()
        {
            try
            {
                string generatedid = idnya();
                idproduk = generatedid;

                command = new MySqlCommand();
                command.Connection = connect;
                command.CommandText = "INSERT INTO produk (ID_PRODUK,NAMA_PRODUK,JENIS_PRODUK)\r\nVALUES (@ID_PRODUK,@NAMA_PRODUK,@JENIS_PRODUK)";

                
                command.Parameters.AddWithValue("@ID_PRODUK", generatedid);
                command.Parameters.AddWithValue("@NAMA_PRODUK", tb_ProductNameAddProduct.Text);
                command.Parameters.AddWithValue("@JENIS_PRODUK", cb_tipe.Text);

                connect.Open() ;
                command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }


        }

        private void detail_produk()
        {
            try
            {
                

                command = new MySqlCommand();
                command.Connection = connect;
                command.CommandText = "INSERT INTO detail_produk(ID_PRODUK,WARNA_PRODUK,UKURAN_PRODUK,STOK_PRODUK,HARGA_PRODUK)\r\nVALUES(@ID_PRODUK, @WARNA_PRODUK,@UKURAN_PRODUK,@STOK_PRODUK,@HARGA_PRODUK);";

                MessageBox.Show(idproduk);
                command.Parameters.AddWithValue("@ID_PRODUK", idproduk);
                command.Parameters.AddWithValue("@WARNA_PRODUK", tb_colourAddProduct.Text.ToUpper());
                command.Parameters.AddWithValue("@UKURAN_PRODUK", tb_sizeAddProduct.Text);
                command.Parameters.AddWithValue("@STOK_PRODUK", tb_stockAddProduct.Text);
                command.Parameters.AddWithValue("@HARGA_PRODUK", tb_priceAddProduct.Text);

                connect.Open();
                command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }

        }

        private void tb_priceAddProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_stockAddProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_sizeAddProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
    }
}
