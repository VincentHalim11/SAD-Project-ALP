using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ELLENA_HANDMADE_SAD_CODING
{
    public partial class Form1 : Form
    {
        public MySqlConnection connect = new MySqlConnection("SERVER=localhost; UID=root; PWD= prodotaggwp1; DATABASE=subsift5_db_b2");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable role = new DataTable();
        string peg_id;
        string query;

        public Form1()
        {
            InitializeComponent();
        }

        public class pengguna
        {
            public static string username { get; set; }
        }

        private void btn_LoginLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand();

                cmd.Connection = connect;
                cmd.CommandText = "SELECT fChecklogin('"+ tb_UsernameLogin.Text +"', '" + tb_PasswordLogin.Text + "')";
                


                connect.Open();
                peg_id = (string)cmd.ExecuteScalar();
                connect.Close();

                query = $"SELECT ROLE_PEGAWAI\r\nFROM pegawai\r\nWHERE USERNAME_PEGAWAI = '{tb_UsernameLogin.Text}';";

                cmd = new MySqlCommand(query,connect);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(role);       

                if (peg_id.Equals(""))
                {
                    MessageBox.Show("Login GAGAL. Cek Kembali Username / Password !");
                    tb_UsernameLogin.Focus();
                }
                else
                {
                    pengguna.username = tb_UsernameLogin.Text;
                    MessageBox.Show("Login Berhasil");
                    this.Hide();
                    MenuUtama main = new MenuUtama(connect, role.Rows[0][0].ToString());
                    main.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_eyelogin_Click(object sender, EventArgs e)
        {
            if ( tb_PasswordLogin.PasswordChar == '*')
            {
                btn_hide.BringToFront();
                tb_PasswordLogin.PasswordChar = '\0';
            }

            
        }
        private void btn_unhide_Click(object sender, EventArgs e)
        {
            if (tb_PasswordLogin.PasswordChar == '\0')
            {
                btn_eyelogin.BringToFront();
                tb_PasswordLogin.PasswordChar = '*';
            }
        }

        private void tb_PasswordLogin_TextChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}
