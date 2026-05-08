using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ELLENA_HANDMADE_SAD_CODING.Resources
{
    public partial class Userlist : Form
    {
        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        string queryshow;
        string queryremove;
        string role;
        string id;
        public Userlist(MySqlConnection uselis_con,string peran)
        {
            InitializeComponent();
            connect = uselis_con;
            role = peran;

        }
        private void Userlist_Load(object sender, EventArgs e)
        {
            queryshow = "SELECT ID_PEGAWAI,NAMA_PEGAWAI,USERNAME_PEGAWAI,ROLE_PEGAWAI\r\nFROM pegawai\r\nWHERE PEGAWAI_AVAILABLE = 1;";
            command = new MySqlCommand(queryshow,connect);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(dt);
            dgv_listuser.DataSource = dt;

            




        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                AddUser user = new AddUser(connect,role);
                user.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btn_backuserlist_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                MenuUtama menu = new MenuUtama(connect,role);
                menu.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgv_listuser.SelectedRows[0];
                id = selectedRow.Cells["ID_PEGAWAI"].Value.ToString();

                queryremove = $"UPDATE PEGAWAI\r\nSET PEGAWAI_AVAILABLE = 0,PEGAWAI_KELUAR = current_timestamp()\r\nWHERE id_pegawai = '{id}';";
                command = new MySqlCommand(queryremove, connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
                dgv_listuser.DataSource = dt;
                MessageBox.Show($"ID {id} telah dinon aktifkan");

                



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
