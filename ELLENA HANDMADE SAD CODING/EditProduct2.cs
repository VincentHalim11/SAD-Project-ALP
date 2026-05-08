using ELLENA_HANDMADE_SAD_CODING.Resources;
using MySql.Data.MySqlClient;
using System;
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
    public partial class EditProduct2 : Form
    {
        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable product= new DataTable();
        DataGridViewRow selectedRow;
        DataGridViewRow selectedRow2;
        DataGridViewRow selectedRow3;
        string role;
        string query;
        string query2;
        string id;
        string harga;
        string stok;
        string pisah;


        public EditProduct2(MySqlConnection konek, string peran)
        {
            InitializeComponent();
            connect = konek;
            role = peran;
        }
        private void EditProduct2_Load(object sender, EventArgs e)
        {
            try
            {
 
                query = "SELECT dp.ID_DETAIL_PRODUK AS Detail_id,p.Id_Produk AS ID,p.Nama_Produk,dp.Warna_Produk,dp.Ukuran_Produk AS Size,p.Jenis_produk AS Jenis,dp.Stok_Produk AS Stok,CONCAT('Rp.',FORMAT(dp.Harga_Produk,2)) AS 'Harga Produk'\r\nFROM produk AS p\r\nLEFT JOIN detail_produk AS dp\r\nON p.ID_PRODUK = dp.ID_PRODUK\r\n ORDER BY 2;";
                command = new MySqlCommand(query, connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(product);
                dgv_edit.DataSource = product;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btn_confirmEditproduct2_Click(object sender, EventArgs e)
        {
            try
            {
                selectedRow = dgv_edit.SelectedRows[0];
                id = selectedRow.Cells["Detail_id"].Value.ToString();

                query2 = $"UPDATE detail_produk\r\nSET stok_produk = {nud_stok.Text}, Harga_produk = {int.Parse(tb_priceEditproduct2.Text)}\r\nWHERE id_detail_produk = {id}";
                command = new MySqlCommand(query2, connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(product);
                MessageBox.Show("Berhasil Update Produk");
                refresh();

                this.Hide();
                ListBarangMenu main = new ListBarangMenu(connect, role);
                main.ShowDialog();
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
          
            
        }

        private void btn_backEditproduct2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListBarangMenu main = new ListBarangMenu(connect, role);
            main.ShowDialog();
            this.Close();
        }
        
        private void refresh()
        {
            tb_priceEditproduct2.Clear();
            nud_stok.ResetText();
        }

        private void dgv_edit_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                selectedRow2 = dgv_edit.SelectedRows[0];
                harga = selectedRow2.Cells["Harga Produk"].Value.ToString();


                selectedRow3 = dgv_edit.SelectedRows[0];
                stok = selectedRow3.Cells["Stok"].Value.ToString();

                harga = harga.Replace("Rp.", "").Trim();
                harga = harga.Replace(".00","").Trim();
                harga = harga.Replace(",","").Trim();
              

                tb_priceEditproduct2.Text = harga;
                nud_stok.Text = stok;
               
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void tb_priceEditproduct2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
