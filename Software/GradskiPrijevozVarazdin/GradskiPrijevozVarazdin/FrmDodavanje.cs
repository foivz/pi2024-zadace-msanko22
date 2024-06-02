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
    public partial class FrmDodavanje : Form
    {
        public FrmDodavanje()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmDodavanje_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StanicaRepository.Dodaj(txtAdresa.Text, txtOpis.Text, txtBrPerona.Text, cboLinija.SelectedItem.ToString(), txtKapacitet.Text,cboZaposlenik.SelectedItem.ToString());
            Close();
        }

        private void txtZaposlenik_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboLinija_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
