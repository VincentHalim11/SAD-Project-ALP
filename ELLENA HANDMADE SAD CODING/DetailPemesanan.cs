using ELLENA_HANDMADE_SAD_CODING.Resources;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ELLENA_HANDMADE_SAD_CODING.Order;




namespace ELLENA_HANDMADE_SAD_CODING
{
    public partial class DetailPemesanan : Form
    {
        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable idcus = new DataTable();
        DataTable idpega = new DataTable();
        DataTable idnota = new DataTable();
        DataTable warnaproduk = new DataTable();
        DataTable ukuranproduk = new DataTable();
        DataTable idproduk = new DataTable();
        DataTable hargatotal = new DataTable();
        string query;
        string pelanggan;
        string role;
        string nom;
        string address;
        string telepon;
        string userPegawai;
        string id_pegawai;
        string id_customer;
        string id_nota;
        string id_produk;
        string detnot;
        int preis;
        int beli;
        int total;
        
       
       

        public DetailPemesanan(MySqlConnection konek, string peran)
        {
            InitializeComponent();
            
            this.connect = konek;
            this.role = peran;

            this.nom = product.SelectedProduct.nama;
            this.preis = product.SelectedProduct.harga;

           
        }

        private void DetailPemesanan_Load(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(Customer.customers_name.nama_customer))
                {
                    pelanggan = Customer.customers_name.nama_customer;
                    address = Customer.customers_name.alamat;
                    telepon = Customer.customers_name.nomor;
                }

                if(!string.IsNullOrEmpty(Form1.pengguna.username))
                {
                    userPegawai = Form1.pengguna.username;
                }

                if (product.SelectedProduct != null)
                {
                    lbl_ProductNameDetailPemesanan.Text = product.SelectedProduct.nama;
                    pb_DetailPemesanan.Image = product.SelectedProduct.gambar;
                }

                
               
                ukuran();
                warna();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           

        }

        private void btn_confirmDetailPemesanan_Click(object sender, EventArgs e)
        {
            try
            {
                if(cb_ukuran.Text != "" && cb_warna.Text != "" && int.Parse(nud_quantity.Text) != 0)
                {
                    beli = int.Parse(nud_quantity.Text);
                    set_id_cus();
                    set_id_peg();


                    produkid();
                    id_bon();
                    ril_id_detai();
                    MessageBox.Show($"{id_nota} id_customer: {id_customer}, id_pegawai: {id_pegawai}, {detnot}");
                    insert_to_detail();
                    update_total();
                    MessageBox.Show($"Nota berhasil dibuat");
                }
                else
                {
                    MessageBox.Show($"Isi yang penuh");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_backDetailPemesanan_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Order utama = new Order(connect, role);
                utama.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
            
        }

        

        private void set_id_cus()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                query = $"SELECT id_customer\r\nFROM customer\r\nWHERE NAMA_CUSTOMER = '{pelanggan}' AND NO_TELEPON_CUSTOMER = '{telepon}';";
                command = new MySqlCommand(query, connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(idcus);


                id_customer = idcus.Rows[0][0].ToString();
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

        private void set_id_peg()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                string query_peg = $"SELECT id_pegawai\r\nFROM pegawai\r\nWHERE USERNAME_PEGAWAI = '{userPegawai}' ";
                command = new MySqlCommand(query_peg, connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(idpega);

                id_pegawai = idpega.Rows[0][0].ToString();
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

        //private void detail_nota()
        //{

        //    try
        //    {
        //        if (connect.State != ConnectionState.Open)
        //        {
        //            connect.Open();
        //        }

        //        command = new MySqlCommand();
        //        command.Connection = connect;
        //        command.CommandText = "pTambahNota";
        //        command.CommandType = CommandType.StoredProcedure;

        //        command.Parameters.AddWithValue("@p_id_pegawai", id_pegawai);
        //        command.Parameters.AddWithValue("@p_id_customer", id_customer);
        //        command.Parameters.AddWithValue("@p_alamat_pengiriman", address);
        //        command.Parameters.AddWithValue("@p_biaya_ongkir", 0);
        //        command.Parameters.AddWithValue("@p_diskon", 0);
        //        command.Parameters.AddWithValue("@p_metode_bayar", '-');
        //        command.Parameters.AddWithValue("@p_total_bayar", preis * beli);

              
        //        command.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        if (connect.State == ConnectionState.Open)
        //        {
        //            connect.Close();
        //        }
        //    }
        //}

        private void id_bon()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                string query = "SELECT ID_NOTA \r\nFROM NOTA \r\nORDER BY ID_NOTA DESC\r\nLIMIT 1;";

                command = new MySqlCommand(query, connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(idnota);


                id_nota = idnota.Rows[0][0].ToString();

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

        private void ril_id_detai()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                command = new MySqlCommand();
                command.Connection = connect;
                command.CommandText = $"SELECT fGenIDDetailNota('{id_nota}')";

                detnot = (string)command.ExecuteScalar();
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

        private void warna()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string querry = $"SELECT dp.warna_produk \r\nFROM detail_produk as dp\r\nLEFT JOIN produk as p\r\nON dp.ID_PRODUK = p.ID_PRODUK\r\nWHERE p.NAMA_PRODUK = '{nom}'\r\nGROUP BY 1;";
                command = new MySqlCommand(querry, connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(warnaproduk);

                foreach (DataRow row in warnaproduk.Rows)
                {
                    cb_warna.Items.Add(row["warna_produk"].ToString());
                }
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

        private void ukuran()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string query = $"SELECT dp.ukuran_produk\r\nFROM detail_produk as dp\r\nLEFT JOIN produk as p\r\nON dp.ID_PRODUK = p.ID_PRODUK\r\nWHERE p.NAMA_PRODUK = '{nom}'\r\n GROUP BY 1;";
                command = new MySqlCommand(query, connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(ukuranproduk);

                foreach (DataRow row in ukuranproduk.Rows)
                {
                    cb_ukuran.Items.Add(row["ukuran_produk"].ToString());
                }
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

        private void produkid()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string query = $"SELECT ID_PRODUK\r\nFROM produk\r\nWHERE NAMA_PRODUK = '{nom}';";
                command = new MySqlCommand(query, connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(idproduk);

                id_produk = idproduk.Rows[0][0].ToString();
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

        private void insert_to_detail()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                total = preis * beli;
                command = new MySqlCommand();
                command.Connection = connect;
                command.CommandText = $"INSERT INTO detail_nota (ID_DETAIL_NOTA,ID_NOTA,ID_PRODUK,quantity,ukuran,harga_satuan,Harga_total)\r\nVALUE(@ID_DETAIL_NOTA,@ID_NOTA,@ID_PRODUK,@quantity,@ukuran,@harga_satuan,@Harga_total)";

                command.Parameters.AddWithValue("@ID_DETAIL_NOTA", detnot);
                command.Parameters.AddWithValue("@ID_NOTA", id_nota);
                command.Parameters.AddWithValue("@ID_PRODUK", id_produk);
                command.Parameters.AddWithValue("@quantity", beli);
                command.Parameters.AddWithValue("@ukuran", cb_ukuran.Text);
                command.Parameters.AddWithValue("@harga_satuan", preis);
                command.Parameters.AddWithValue("@Harga_total", total);

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

        private void update_stok()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                command = new MySqlCommand();
                command.Connection = connect;
                command.CommandText = $"UPDATE detail_produk\r\nSET stok = stok - @jumlah\r\n WHERE id_produk = @idbarang;";

                command.Parameters.AddWithValue("@jumlah", beli);
                command.Parameters.AddWithValue("@idbarang", id_produk);

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

        //private void harga_all()
        //{
        //    string query = $"UPDATE nota\r\nSET TOTAL_BAYAR = {(preis * beli)}+TOTAL_BAYAR\r\nWHERE ID_NOTA = {id_nota}";
        //    command = new MySqlCommand(query, connect);
        //    adapter = new MySqlDataAdapter(command);
        //    adapter.Fill(hargatotal);
        //}
        private void update_total()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                string query = $"UPDATE nota SET TOTAL_BAYAR = {(preis * beli)} + TOTAL_BAYAR WHERE ID_NOTA = @id_nota";
                command = new MySqlCommand(query, connect);
                command.Parameters.AddWithValue("@id_nota", id_nota);

               
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
    }
}
