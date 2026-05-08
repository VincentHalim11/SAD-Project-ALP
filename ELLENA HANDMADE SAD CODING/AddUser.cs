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
using System.Windows.Input;

namespace ELLENA_HANDMADE_SAD_CODING
{
    public partial class AddUser : Form
    {
        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        string jam;
        string query;
        string role;
        public AddUser(MySqlConnection adduser_connect,string peran)
        {
            InitializeComponent();
            connect = adduser_connect;
            role = peran; 
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            tb_notelp.MaxLength = 12;
        }
        private void btn_SignUpadduser_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_role.Text != string.Empty && tb_namauser.Text != string.Empty && tb_notelp.Text != string.Empty && tb_usernameadduser.Text != string.Empty && tb_passwordadduser.Text != string.Empty)
                {
                    if (tb_passwordadduser.Text == tb_currentpassadduser.Text)
                    {
                        if(tb_email.Text.Contains("@gmail.com"))
                        {
                            command = new MySqlCommand();
                            command.Connection = connect;
                            command.CommandText = "INSERT INTO PEGAWAI (ROLE_PEGAWAI,NAMA_PEGAWAI,EMAIL_PEGAWAI,NO_TELEPON_PEGAWAI,USERNAME_PEGAWAI,PASSWORD_PEGAWAI) VALUES" +
                                "(@ROLE_PEGAWAI,@NAMA_PEGAWAI,@EMAIL_PEGAWAI,@NO_TELEPON_PEGAWAI,@USERNAME_PEGAWAI,@PASSWORD_PEGAWAI)";

                            command.Parameters.AddWithValue("@ROLE_PEGAWAI", cb_role.Text);
                            command.Parameters.AddWithValue("@NAMA_PEGAWAI", tb_namauser.Text);
                            command.Parameters.AddWithValue("@NO_TELEPON_PEGAWAI", tb_notelp.Text);
                            command.Parameters.AddWithValue("@USERNAME_PEGAWAI", tb_usernameadduser.Text);
                            command.Parameters.AddWithValue("@PASSWORD_PEGAWAI", tb_passwordadduser.Text);
                            command.Parameters.AddWithValue("@EMAIL_PEGAWAI", tb_email.Text);

                            connect.Open();
                            command.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("berhasil input data");
                            hilang();

                            this.Hide();
                            Userlist user = new Userlist(connect, role);
                            user.ShowDialog();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Penulisan email kurang tepat","Eror",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("password harus sama","error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }


                    

                   

                }
                else
                {
                    MessageBox.Show("Message Box harus terisi semua", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            jam = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void tb_notelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void hilang()
        {
            cb_role.Text = "";
            tb_namauser.Clear();
            tb_notelp.Clear();
            tb_usernameadduser.Clear();
            tb_passwordadduser.Clear();
            tb_currentpassadduser.Clear();
        }

       
    }
}
