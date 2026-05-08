using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ELLENA_HANDMADE_SAD_CODING.Form1;


namespace ELLENA_HANDMADE_SAD_CODING.Resources
{
    public partial class Customer : Form
    {

        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable idcus = new DataTable();
        DataTable idpega = new DataTable();
        string query;
        string role;
        string genId;
        string id_customer;
        string id_pegawai;
        string userpegawai;

        public Customer(MySqlConnection konek, string peran)
        {
            InitializeComponent();
            connect = konek;
            role = peran;
            
        }

        public class customers_name
        {   
            public static string nama_customer { get; set; }
            public static string alamat { get; set; }
            public static string nomor { get; set; }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pengguna.username))
            {
                userpegawai = pengguna.username;
            }


            txt_phone.MaxLength = 12;
            
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                cekcustomer();
                set_id_peg();
                set_id_cus();
                querry();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                MenuUtama menu = new MenuUtama(connect, role);
                menu.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cekcustomer()
        {
            try
            {
                if(txt_nama.Text != "" && txt_phone.Text != "" && txt_shipping.Text != "" )
                {
                    if (txt_phone.Text.Length < 12)
                    {
                        MessageBox.Show("ERROR : Masukkan Nomor telepon dengan benar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        customers_name.nama_customer = txt_nama.Text;
                        customers_name.alamat = txt_shipping.Text;
                        customers_name.nomor = txt_phone.Text;

                        command = new MySqlCommand();
                        command.Connection = connect;
                        command.CommandText = "pTambahCustomer";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@p_nama_customer", txt_nama.Text);
                        command.Parameters.AddWithValue("@p_nomor_telepon", txt_phone.Text);

                        connect.Open();
                        command.ExecuteNonQuery();

                       
                        this.Hide();
                        Order pesen = new Order(connect, role);
                        pesen.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("ERROR : Semua kotak harus terisi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void querry()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                command = new MySqlCommand();
                command.Connection = connect;
                command.CommandText = "pTambahNota";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_id_pegawai", id_pegawai);
                command.Parameters.AddWithValue("@p_id_customer", id_customer);
                command.Parameters.AddWithValue("@p_alamat_pengiriman", customers_name.alamat);
                command.Parameters.AddWithValue("@p_biaya_ongkir", 0);
                command.Parameters.AddWithValue("@p_diskon", 0);
                command.Parameters.AddWithValue("@p_metode_bayar", '-');

                // Parameter INOUT untuk p_total_bayar
                MySqlParameter totalBayarParam = new MySqlParameter("@p_total_bayar", MySqlDbType.Int32);
                totalBayarParam.Direction = ParameterDirection.InputOutput;
                totalBayarParam.Value = 0; // Menentukan nilai awal sebagai 0
                command.Parameters.Add(totalBayarParam);


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

        private void set_id_cus()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                query = $"SELECT id_customer\r\nFROM customer\r\nWHERE NAMA_CUSTOMER = '{customers_name.nama_customer}' AND NO_TELEPON_CUSTOMER = '{customers_name.nomor}';";
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

                string query_peg = $"SELECT id_pegawai\r\nFROM pegawai\r\nWHERE USERNAME_PEGAWAI = '{userpegawai}' ";
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
    }

   
}
