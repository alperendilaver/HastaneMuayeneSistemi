namespace projeOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hastaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaKaydet hastaKaydet = new HastaKaydet();
            hastaKaydet.Show();
            hastaKaydet.MdiParent= this;

        }

        private void muayeneEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Muayene muayene = new Muayene();
            muayene.MdiParent = this;
            muayene.Show();
        }

        private void reçeteRaporlarýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receteler receteler = new Receteler();
            receteler.MdiParent = this;
            receteler.Show();
        }

        private void muayeneListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneListesi muayeneListesi = new MuayeneListesi();
            muayeneListesi.MdiParent = this;
            muayeneListesi.Show();  
        }
    }
}