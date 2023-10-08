using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace projeOdev
{
    public partial class HastaKaydet : Form
    {
        public HastaKaydet()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost;port=5432; user ID = postgres; password=1453; Database=mbys");

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
           
                bool medenidurum;
                if (radioEvli.Checked)
                    medenidurum = true;

                else
                    medenidurum = false;

                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand("insert into hasta values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connection);
                command.Parameters.AddWithValue("@p1", mskdtxtboxTC.Text);
                command.Parameters.AddWithValue("@p2", txtboxAd.Text);
                command.Parameters.AddWithValue("@p3", txtboxSoyad.Text);
                command.Parameters.AddWithValue("@p4", txtboxDogumYeri.Text);
                command.Parameters.AddWithValue("@p5", dateDogum.Value);
                command.Parameters.AddWithValue("@p6", medenidurum);
                command.Parameters.AddWithValue("@p7", txtboxAdres.Text);

                command.ExecuteNonQuery();
                connection.Close();

            MessageBox.Show("Hasta Başarı İle Eklendi Muayene Edebilirsiniz");
            mskdtxtboxTC.Text = "";
            txtboxAd.Text = "";
            txtboxSoyad.Text = "";
            txtboxDogumYeri.Text = "";
            txtboxAdres.Text = "";
            mskdtxtboxTC.Focus();


        }
    }
}
