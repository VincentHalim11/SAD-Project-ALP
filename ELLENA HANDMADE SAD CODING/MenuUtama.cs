using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ELLENA_HANDMADE_SAD_CODING.Resources;
using MySql.Data.MySqlClient;

namespace ELLENA_HANDMADE_SAD_CODING
{
    public partial class MenuUtama : Form
    {
        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable detail = new DataTable();
        string role;
        string query;
        public MenuUtama(MySqlConnection menu_connect,string peran)
        {
            InitializeComponent();
            connect = menu_connect;
            role = peran;
        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {
            try
            {
                
                query = "SELECT * FROM VNota;";
                command = new MySqlCommand(query, connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(detail);
                dgv_menuutama.DataSource = detail;


                if (role.ToUpper() == "OWNER")
                {
                    btn_AddUsermenuutama.Enabled = true;
                    btn_AddUsermenuutama.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong");
            }
            
        }

        private void btn_reportmenuutama_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Report rep = new Report(connect,role);
                rep.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_ordermenuutama_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Customer cus = new Customer (connect, role);
                cus.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_produkmenuutama_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                ListBarangMenu menubarang = new ListBarangMenu(connect, role);
                menubarang.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_cartmenuutama_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Cart keranjang = new Cart(connect, role);
                keranjang.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_LogOutmenuutama_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form1 log = new Form1();
                log.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btn_AddUsermenuutama_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Userlist uselist = new Userlist(connect,role);
                uselist.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_jam.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
