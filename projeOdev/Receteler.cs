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

namespace projeOdev
{
    public partial class Receteler : Form
    {
        public Receteler()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost;port=5432; user ID = postgres; password=1453; Database=mbys");


        private void ReceteViewbyNo_Click(object sender, EventArgs e)
        {
            string sorgu = "select hasta.tcno,hasta.hastaadi,hasta.hastasoyadi,ilac.ilacadi,ilac.tipi," +
                "yazilanilaclar.ilackutu,recete.receteno from recete \r\ninner join yazilanilaclar on " +
                "yazilanilaclar.receteno = recete.receteNo\r\ninner join ilac on ilac.barkodno=yazilanilaclar" +
                ".barkodno\r\ninner join hasta on hasta.tcno=recete.tcno\r\nwhere " +
                "recete.receteno="+Convert.ToInt16(mskdtxtReceteNo.Text);
            DataSet dt = new DataSet();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sorgu, connection);
            adap.Fill(dt);
            dataRecete.DataSource = dt.Tables[0];
        }

        private void btnReceteViewAll_Click(object sender, EventArgs e)
        {
            string sorgu = "select recete.receteno,hasta.tcno,hasta.hastaadi,hasta.hastasoyadi,ilac.ilacadi,ilac.tipi," +
                "yazilanilaclar.ilackutu from recete \r\ninner join yazilanilaclar on " +
                "yazilanilaclar.receteno = recete.receteNo\r\ninner join ilac on ilac.barkodno=yazilanilaclar." +
                "barkodno\r\ninner join hasta on hasta.tcno=recete.tcno\r\norder by recete.receteno\r\n";
            DataSet dt = new DataSet();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sorgu, connection);
            adap.Fill(dt);
            dataRecete.DataSource = dt.Tables[0];
        }

        private void ReceteViewbyTC_Click(object sender, EventArgs e)
        {
            string sorgu = "select hasta.tcno,hasta.hastaadi,hasta.hastasoyadi,ilac.ilacadi,ilac.tipi," +
                "yazilanilaclar.ilackutu,recete.receteno from recete \r\ninner join yazilanilaclar on " +
                "yazilanilaclar.receteno = recete.receteNo\r\ninner join ilac on ilac.barkodno=yazilanilaclar." +
                "barkodno\r\ninner join hasta on hasta.tcno=recete.tcno\r\nwhere recete.tcno" +
                "='"+mskdtxtboxHastaTC.Text+"'"+"\r\norder by recete.receteno\r\n";
            DataSet dt = new DataSet();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sorgu, connection);
            adap.Fill(dt);
            dataRecete.DataSource = dt.Tables[0];
        }

        private void HastaViewbyIlac_Click(object sender, EventArgs e)
        {
            string sorgu = "select hasta.tcno,hasta.hastaadi,hasta.hastasoyadi,recete.receteno,muayene." +
                "muayenetarihi from hasta inner join recete on recete.tcno=hasta.tcno inner join muayene " +
                "on muayene.receteno=recete.receteno\r\nwhere hasta.tcno in (select muayene.tcno from " +
                "muayene\r\nwhere muayene.receteno in (select yazilanilaclar.receteno from yazilanilaclar" +
                "\r\nwhere yazilanilaclar.barkodno=" + Convert.ToInt32(mskdtxtboxİlacNo.Text)+")) order by " +
                "hasta.tcno,muayene.muayenetarihi,recete.receteno";
            DataSet dt = new DataSet();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sorgu, connection);
            adap.Fill(dt);
            dataRecete.DataSource = dt.Tables[0];
        }
    }
}
