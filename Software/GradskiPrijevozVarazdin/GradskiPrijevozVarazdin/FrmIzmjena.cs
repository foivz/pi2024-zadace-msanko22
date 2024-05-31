using GradskiPrijevozVarazdin.Models;
using GradskiPrijevozVarazdin.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradskiPrijevozVarazdin
{
    public partial class FrmIzmjena : Form
    {
        private Stanica odabranaStanica;
        public FrmIzmjena(Stanica odabranaStanica)
        {
            InitializeComponent();
            this.odabranaStanica = odabranaStanica;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmIzmjena_Load(object sender, EventArgs e)
        {
            txtAdresa.Text = odabranaStanica.NazivAdresaStanice;
            txtOpis.Text = odabranaStanica.Opis;
            txtBrPerona.Text=odabranaStanica.BrPeronaNaStanici.ToString();
            txtLinija.Text = odabranaStanica.Linija;
            txtKapacitet.Text = odabranaStanica.Kapacitet.ToString();
            txtZaposlenik.Text = odabranaStanica.Zaposlenik;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StanicaRepository.Izmjena(txtAdresa.Text, txtOpis.Text, txtBrPerona.Text, txtLinija.Text, txtKapacitet.Text, txtZaposlenik.Text, odabranaStanica.BrStanice);
            Close();
        }
    }
}
