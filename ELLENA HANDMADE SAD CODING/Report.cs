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
    public partial class Report : Form
    {
        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable laporan = new DataTable();
        string role;
        string query;
        string tanggal;
        public Report(MySqlConnection con, string peran)
        {
            InitializeComponent();
            connect = con;
            role = peran;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            dtp_now.CustomFormat = "dd-MM-yyyy";
            dtp_filter.CustomFormat = "dd-MM-yyyy";

            dtp_filter.Text = tanggal;

            if(dtp_filter.Enabled == false)
            {
                query = "SELECT ID_nota,DATE_FORMAT(tanggal_transaksi, '%d-%m-%Y') AS Tanggal_transaksi,CONCAT('Rp.',FORMAT(total_bayar,2)) AS Tanggal_Transaksi,status_bayar\r\nFROM nota;";
                command = new MySqlCommand(query, connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(laporan);
                dgv_report.DataSource = laporan;
            }
            else if (dtp_filter.Enabled == true)
            {
                query = $"SELECT ID_nota,DATE_FORMAT(tanggal_transaksi, '%d/%m/%Y') AS Tanggal_transaksi,CONCAT('Rp.',FORMAT(total_bayar,2)) AS Tanggal_Transaksi,status_bayar\r\nFROM nota WHERE TANGGAL_TRANSAKSI = {tanggal} ;";
                command = new MySqlCommand(query, connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(laporan);
                dgv_report.DataSource = laporan;
            }
            
        }

        private void btn_backreport_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuUtama first = new MenuUtama(connect,role);
            first.ShowDialog();
            this.Close();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            if (dtp_filter.Enabled == false)
            {
                dtp_filter.Enabled = true;
            }
            else
            {
                dtp_filter.Enabled = false;
            }
        }
    }
}
