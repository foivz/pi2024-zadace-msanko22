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
            cboLinija2.SelectedItem = odabranaStanica.Linija.ToString();
            txtKapacitet.Text = odabranaStanica.Kapacitet.ToString();
            cboZaposlenik2.SelectedItem = odabranaStanica.Zaposlenik.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StanicaRepository.Izmjena(txtAdresa.Text, txtOpis.Text, txtBrPerona.Text, cboLinija2.SelectedItem.ToString(), txtKapacitet.Text, cboZaposlenik2.SelectedItem.ToString(), odabranaStanica.BrStanice);
            Close();
        }
    }
}
