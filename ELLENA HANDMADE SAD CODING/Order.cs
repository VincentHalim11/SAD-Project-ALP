using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ELLENA_HANDMADE_SAD_CODING.Order;

namespace ELLENA_HANDMADE_SAD_CODING
{
    public partial class Order : Form
    {
        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        Dictionary<string,product> produkt = new Dictionary<string, product>();
        string query;
        string role;
   
        


        public Order(MySqlConnection konek,string peran)
        {
            InitializeComponent();
            connect = konek;
            role = peran;
            

        }

       
        public class product
        {
            public string nama { get; set; }
            public Image gambar { get; set; }
            public int harga { get; set; }
            public static product SelectedProduct { get; set; }

            public product(string heibt,int price ,Image picture)
            {
               nama = heibt;
               gambar = picture;
               harga = price;

            }
        }

        private void Order_Load(object sender, EventArgs e)
        {

            try
            {
                produkt.Add("pb_OrderCascade", new product("Easyly Cascade", 42000, pb_OrderCascade.Image));
                produkt.Add("pb_OrderBreeze", new product("Easyly Breeze", 42000, pb_OrderBreeze.Image));
                produkt.Add("pb_OrderNoir", new product("Easyly Noir", 42000, pb_OrderNoir.Image));
                produkt.Add("pb_OrderSerena", new product("Easyly Serena", 42000, pb_OrderSerena.Image));
                produkt.Add("pb_OrderVelaria", new product("Easyly Velaria", 42000, pb_OrderVelaria.Image));
                produkt.Add("pb_OrderVelour", new product("Easyly Velour", 42000, pb_OrderVelour.Image));


                produkt.Add("pb_OrderRaven", new product("Leica Raven", 46000, pb_OrderRaven.Image));
                produkt.Add("pb_OrderSolstice", new product("Leica Solstice", 46000, pb_OrderSolstice.Image));
                produkt.Add("pb_OrderSwift", new product("Leica Swift", 46000, pb_OrderSwift.Image));


                produkt.Add("pb_OrderCeleste", new product("Trice Celeste", 35000, pb_OrderCeleste.Image));
                produkt.Add("pb_OrderEcho", new product("Trice Echo", 35000, pb_OrderEcho.Image));
                produkt.Add("pb_OrderEmber", new product("Trice Ember", 35000, pb_OrderEmber.Image));
                produkt.Add("pb_OrderLunaire", new product("Trice Lunaire", 35000, pb_OrderLunaire.Image));


                produkt.Add("pb_OrderCimmerian", new product("Cimmerian", 46000, pb_OrderCimmerian.Image));
                produkt.Add("pb_OrderEclat", new product("Eclat", 46000, pb_OrderEclat.Image));
                produkt.Add("pb_OrderUmbra", new product("Umbra", 46000, pb_OrderUmbra.Image));
                produkt.Add("pb_OrderReverie", new product("Reverie", 46000, pb_OrderReverie.Image));
                produkt.Add("pb_OrderAmour", new product("Amour", 52000, pb_OrderAmour.Image));
                produkt.Add("pb_OrderAveline", new product("Aveline", 58000, pb_OrderAveline.Image));
                produkt.Add("pb_OrderEnchante", new product("Enchante", 52000, pb_OrderEnchante.Image));
                produkt.Add("pb_OrderLustre", new product("Lustre", 58000, pb_OrderLustre.Image));
                produkt.Add("pb_OrderPetaluna", new product("Petaluna", 58000, pb_OrderPetaluna.Image));
                produkt.Add("pb_OrderSolara", new product("Soalara", 58000, pb_OrderSolara.Image));


                pb_OrderCascade.Click += picturebox_click;
                pb_OrderBreeze.Click += picturebox_click;
                pb_OrderNoir.Click += picturebox_click;
                pb_OrderSerena.Click += picturebox_click;
                pb_OrderVelaria.Click += picturebox_click;
                pb_OrderVelour.Click += picturebox_click;

                pb_OrderRaven.Click += picturebox_click;
                pb_OrderSolstice.Click += picturebox_click;
                pb_OrderSwift.Click += picturebox_click;

                pb_OrderCeleste.Click += picturebox_click;
                pb_OrderEcho.Click += picturebox_click;
                pb_OrderEmber.Click += picturebox_click;
                pb_OrderLunaire.Click += picturebox_click;

                pb_OrderCimmerian.Click += picturebox_click;
                pb_OrderEclat.Click += picturebox_click;
                pb_OrderUmbra.Click += picturebox_click;
                pb_OrderReverie.Click += picturebox_click;
                pb_OrderAmour.Click += picturebox_click;
                pb_OrderAveline.Click += picturebox_click;
                pb_OrderEnchante.Click += picturebox_click;
                pb_OrderLustre.Click += picturebox_click;
                pb_OrderPetaluna.Click += picturebox_click;
                pb_OrderSolara.Click += picturebox_click;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            this.Visible = true;

            
        }

        private void btn_backOrder_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                MenuUtama utama = new MenuUtama(connect, role);
                utama.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        private void picturebox_click(object sender, EventArgs e)
        {
            try
            {
                PictureBox clickedPicture = sender as PictureBox;

                if (clickedPicture != null && produkt.ContainsKey(clickedPicture.Name))
                {
                    product.SelectedProduct = produkt[clickedPicture.Name];

                    this.Visible = false;
                    //this.Hide();
                    DetailPemesanan dpesan = new DetailPemesanan(connect, role);
                    dpesan.ShowDialog();
                    //this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
          
        }
    }
}
