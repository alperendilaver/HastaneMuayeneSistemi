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
    public partial class MuayeneListesi : Form
    {
        public MuayeneListesi()
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localhost;port=5432; user ID = postgres; password=1453; Database=mbys");

        private void MuayeneListesi_Load(object sender, EventArgs e)
        {
            
            string sorgu = "select muayene.tcno,hasta.hastaadi,hasta.hastasoyadi,muayene.muayenetarihi," +
                "muayene.sikayet,muayene.tani,muayene.tedavi,muayene.receteno from muayene inner join hasta " +
                "on hasta.tcno=muayene.tcno order by muayenetarihi";
            DataSet dt = new DataSet();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sorgu, connection);
            adap.Fill(dt);
            dataMuayeneler.DataSource = dt.Tables[0];

        }
    }
}
