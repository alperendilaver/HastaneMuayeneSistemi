using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projeOdev
{
    public partial class Muayene : Form
    {
        public Muayene()
        {
            InitializeComponent();
        }
        
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost;port=5432; user ID = postgres; password=1453; Database=mbys");

        private void muayeneClear()
        {
            seciliilaclar.Clear();
            seciliilacKutu.Clear();
            txtboxEklenenIlaclar.Text = "";
            mskdtxtIlacNo.Text = "";
            cmbboxKutu.Text = "";
            mskdtxtboxMTC.Text = "";
            txtboxSikayet.Text = "";
            txtBoxTanı.Text = "";
            txtBoxTedavi.Text = "";
            
            mskdtxtboxMTC.Focus();
        }
        private bool ayniIlacKontrol(List<short> ilacListe)
        {
            short temp;
            for (int i = 0; i < ilacListe.Count; i++)
            {
                for (int j = i + 1; j < ilacListe.Count; j++)
                {
                    temp = ilacListe[i];
                    if (ilacListe[j] == temp)
                        return false;
                }
            }
            return true;
        }

        short i = 0;


        List<short> seciliilaclar = new List<short>();
        List<short> seciliilacKutu = new List<short>();


        private void Muayene_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from ilac";
            DataSet dt = new DataSet();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sorgu, connection);
            adap.Fill(dt);
            dataIlaclar.DataSource = dt.Tables[0];
        }
              
        private void btnTedaviKaydet_Click(object sender, EventArgs e)
        {
           
            Random random = new Random();
            int value = random.Next(1000, 9999);
            
            if (seciliilaclar.Count != 0)
                txtboxReceteNo.Text = value.ToString();
            else
                txtboxReceteNo.Text = "0";
            
            

            try
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("insert into muayene values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
                command.Parameters.AddWithValue("@p1", mskdtxtboxMTC.Text);
                command.Parameters.AddWithValue("@p2", dateMuayene.Value);
                command.Parameters.AddWithValue("@p3", txtboxSikayet.Text);
                command.Parameters.AddWithValue("@p4", txtBoxTanı.Text);
                command.Parameters.AddWithValue("@p5", txtBoxTedavi.Text);
                command.Parameters.AddWithValue("@p6", Convert.ToInt32(txtboxReceteNo.Text));
                command.ExecuteNonQuery();
                connection.Close();

                /*recete tablosuna gerekli verileri ekler*/
                connection.Open();
                NpgsqlCommand command3 = new NpgsqlCommand("insert into recete values (@p1,@p2)", connection);
                command3.Parameters.AddWithValue("@p1", mskdtxtboxMTC.Text);
                command3.Parameters.AddWithValue("@p2", value);
                command3.ExecuteNonQuery();
                connection.Close();


                /*yazilan ilaclar tablosuna gerekli verileri ekler*/
                for (int j = 0; j < seciliilaclar.Count; j++)
                {
                    connection.Open();
                    NpgsqlCommand command5 = new NpgsqlCommand("insert into yazilanilaclar values (@p1,@p2,@p3)", connection);
                    command5.Parameters.AddWithValue("@p1", value);
                    command5.Parameters.AddWithValue("@p2", Convert.ToInt32(seciliilaclar[j]));
                    command5.Parameters.AddWithValue("@p3", Convert.ToInt32(seciliilacKutu[j]));
                    command5.ExecuteNonQuery();
                    connection.Close();
                }
                muayeneClear();
            }
            catch 
            {
                
            }

            
            
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (mskdtxtIlacNo.MaskCompleted && cmbboxKutu.SelectedIndex != -1)
            {
                string sorgu = "select ilacadi from ilac where barkodno = " + Convert.ToInt32(mskdtxtIlacNo.Text);

                seciliilaclar.Add(Convert.ToInt16(mskdtxtIlacNo.Text));
                seciliilacKutu.Add(Convert.ToInt16(cmbboxKutu.Text));
                if (ayniIlacKontrol(seciliilaclar))
                {
                    string ilaclar = "";

                    if (i < 5)
                    {
                        

                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

                        NpgsqlDataReader rdr = command.ExecuteReader();

                        while (rdr.Read())
                        {
                            ilaclar += rdr[0].ToString();
                        }

                        rdr.Close();

                        connection.Close();
                        txtboxEklenenIlaclar.Text += ilaclar + " " + cmbboxKutu.SelectedItem.ToString() + "  ";
                        i++;

                    }
                    else
                        MessageBox.Show("En Fazla 5 İlaç Eklenebilir");
                }
                else { 
                    MessageBox.Show("Aynı ilaç seçilemez");
                    seciliilaclar.RemoveAt(seciliilaclar.Count - 1);
                }
            }
            else
                MessageBox.Show("İlac No ve Kutu Sayısını Doğru Giriniz");

            
        }


        private void btnIlacTemizle_Click(object sender, EventArgs e)
        {
            txtboxEklenenIlaclar.Text = "";
            seciliilaclar.Clear();
            seciliilacKutu.Clear();
            mskdtxtIlacNo.Clear();
            cmbboxKutu.Text = "";
            i = 0;
        }
    }
}
