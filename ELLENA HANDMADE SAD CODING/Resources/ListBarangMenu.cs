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

namespace ELLENA_HANDMADE_SAD_CODING.Resources
{
    public partial class ListBarangMenu : Form
    {
        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable barang = new DataTable();
        string role;
        string query;
        public ListBarangMenu(MySqlConnection sambung,string peran)
        {
            InitializeComponent();
            connect = sambung;
            role = peran;
        }

        private void ListBarangMenu_Load(object sender, EventArgs e)
        {
            query = "SELECT p.Id_Produk AS ID,p.Nama_Produk,dp.Warna_Produk,dp.Ukuran_Produk AS Size,p.Jenis_produk AS Jenis,dp.Stok_Produk AS Stok,CONCAT('Rp.',FORMAT(dp.Harga_Produk,2)) AS 'Harga Produk'\r\nFROM produk AS p\r\nLEFT JOIN detail_produk AS dp\r\nON p.ID_PRODUK = dp.ID_PRODUK;";
            command = new MySqlCommand(query,connect);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(barang);
            dgv_listproduk.DataSource = barang;
        }

        private void btn_backtomenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuUtama main = new MenuUtama(connect,role);
            main.ShowDialog();
            this.Close();
        }

        private void btn_editproduk_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProduct2 edit = new EditProduct2(connect, role);
            edit.ShowDialog();
            this.Close();
        }

        private void btn_addproduk_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct produkbaru = new AddProduct(connect,role);
            produkbaru.ShowDialog();
            this.Close();
        }
    }
}
