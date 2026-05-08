using ELLENA_HANDMADE_SAD_CODING.Resources;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELLENA_HANDMADE_SAD_CODING
{
    public partial class Cart : Form
    {
        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable Einkaufswagen = new DataTable();
        Pen pen = new Pen(Color.Black, 2);
        string ttime;
        string role;
        string query;
        string idnota;

        Point mulai = new Point(50, 230);
        Point mari = new Point(450, 230);

        Point mulai2 = new Point(50, 400);
        Point mari2 = new Point(450, 400);
        public Cart(MySqlConnection konek, string peran)
        {
            InitializeComponent();
            timer1.Start();
            connect = konek;
            role = peran;
        }

        private void btn_confirmCart_Click(object sender, EventArgs e)
        {
            try
            {
                confirm_pesanan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            try
            {
                query = "SELECT c.Nama_Customer AS 'Customer',n.ID_NOTA AS 'ID Nota',p.NAMA_PRODUK AS 'Nama Produk',dn.UKURAN AS 'Ukuran',dn.QUANTITY AS 'Jumlah',dn.HARGA_TOTAL AS 'TOTAL',n.ALAMAT_PENGIRIMAN 'Alamat',c.NO_TELEPON_CUSTOMER AS 'No Telepon'\r\nFROM produk AS p\r\nLEFT JOIN detail_nota AS dn\r\nON p.ID_PRODUK = dn.ID_PRODUK\r\nLEFT JOIN nota AS n\r\nON dn.ID_NOTA = n.ID_NOTA\r\nLEFT JOIN customer AS c\r\nON c.ID_CUSTOMER = n.ID_CUSTOMER\r\nWHERE STATUS_BAYAR = \"PENDING\";\r\n";
                command = new MySqlCommand(query,connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(Einkaufswagen);
                dgv_Cart.DataSource = Einkaufswagen;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_backCart_Click(object sender, EventArgs e)
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Order pelanggan = new Order(connect, role);
                pelanggan.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgv_Cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 )
                {
                    DataGridViewRow row = this.dgv_Cart.Rows[e.RowIndex];
                    tb_NameCart.Text = row.Cells["customer"].Value.ToString();
                    tb_PhoneNumberCart.Text = row.Cells["No Telepon"].Value.ToString();
                    tb_AddressCart.Text = row.Cells["Alamat"].Value.ToString();
                    tb_TotalProductCart.Text = row.Cells["Jumlah"].Value.ToString();
                    tb_TotalCostCart.Text = row.Cells["TOTAL"].Value.ToString();
                    idnota = row.Cells["ID Nota"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void print()
        {
            try
            {

                int width = 500, height = 1000;
                using (Bitmap bitmap = new Bitmap(width, height))
                {

                    // Create a Graphics object to draw on the Bitmap
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        // Fill the background with white color
                        graphics.Clear(Color.White);

                        // Draw line
                        graphics.DrawLine(pen, mulai, mari);
                        graphics.DrawLine(pen, mulai2, mari2);

                        // Draw some text
                        using (Font font = new Font("Arial", 25, FontStyle.Bold))
                        {
                            graphics.DrawString("Ellena Handmade", font, Brushes.Black, new PointF(100, 20));

                        }

                        using (Font font = new Font("Arial", 15, FontStyle.Bold))
                        {
                            graphics.DrawString("Total : Rp. 10.500.000", font, Brushes.Black, new PointF(270, 425));

                        }




                        using (Font jln = new Font("Arial", 15))
                        {
                            graphics.DrawString("Dusun Mojosantren RT.10 RW.03,", jln, Brushes.Black, new PointF(90, 60));
                            graphics.DrawString("Kecamatan Krian,Sidoarjo", jln, Brushes.Black, new PointF(110, 85));
                            graphics.DrawString("Hp:", jln, Brushes.Black, new PointF(120, 110));
                            graphics.DrawString("No Nota : ", jln, Brushes.Black, new PointF(50, 140));
                            graphics.DrawString("Kasir : ", jln, Brushes.Black, new PointF(50, 164));
                            graphics.DrawString(ttime, jln, Brushes.Black, new PointF(50, 190));


                            // pesanan
                            graphics.DrawString("1", jln, Brushes.Black, new PointF(50, 270));
                            graphics.DrawString("Sepatu Air Jordan", jln, Brushes.Black, new PointF(95, 270));
                            graphics.DrawString("Rp. 10.000.000", jln, Brushes.Black, new PointF(310, 270));


                            graphics.DrawString("2", jln, Brushes.Black, new PointF(50, 310));
                            graphics.DrawString("RTX 4090", jln, Brushes.Black, new PointF(95, 310));
                            graphics.DrawString("Rp. 500.000", jln, Brushes.Black, new PointF(310, 310));

                            graphics.DrawString("~Terima kasih sudah berbelanja~", jln, Brushes.Black, new PointF(90, 460));

                        }
                    }

                    // Define the base path and filename
                    string basePath = @"D:\Kuliah\Semester 3\New folder\";
                    string baseFileName = "image";
                    string fileExtension = ".png";

                    // Initialize the file index
                    int fileIndex = 1;
                    string outputPath;

                    // Generate a unique filename
                    do
                    {
                        // Construct the filename
                        outputPath = Path.Combine(basePath, $"{baseFileName}{(fileIndex == 1 ? "" : fileIndex.ToString())}{fileExtension}");
                        fileIndex++;
                    } while (File.Exists(outputPath));

                    // Save the Bitmap as a PNG file
                    bitmap.Save(outputPath, ImageFormat.Png);

                    // Inform the user that the image has been saved
                    MessageBox.Show($"Image saved as {outputPath}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ttime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void tb_ShippingFeeCart_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void metode_bayar()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                command = new MySqlCommand();
                command.Connection = connect;
                command.CommandText = "pUpdateMetodeBayar";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_id_nota",idnota);
                command.Parameters.AddWithValue("@p_metode_bayar",cb_Cart.Text);

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

        private void confirm_pesanan()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                if (int.Parse(tb_ShippingFeeCart.Text) > 0 )
                {
                    //command = new MySqlCommand();
                    //command.Connection = connect;
                    //command.CommandText = "";

                    //command.Parameters.AddWithValue("@p_id_nota", idnota);
                    //command.Parameters.AddWithValue("@p_metode_bayar", cb_Cart.Text);

                    //command.ExecuteNonQuery();
                    MessageBox.Show("berhasil");
                }
                else
                {
                    MessageBox.Show("Textbox tidak boleh kosong");
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

    }
}
