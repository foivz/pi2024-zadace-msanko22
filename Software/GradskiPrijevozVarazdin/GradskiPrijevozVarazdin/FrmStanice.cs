using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GradskiPrijevozVarazdin.Repositories;
using GradskiPrijevozVarazdin.Models;


namespace GradskiPrijevozVarazdin
{
    public partial class FrmStanice : Form
    {
        public FrmStanice()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stanica odabranaStanica = dgvStanice.CurrentRow.DataBoundItem as Stanica;
            FrmIzmjena frmIzmjena = new FrmIzmjena(odabranaStanica);
            frmIzmjena.ShowDialog();
            ShowStanice();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_msanko22_DB", "PI2324_msanko22_User", "G$wLxj;}");
            ShowStanice();
        }
        private void ShowStanice()
        {
            List<Stanica> stanice = StanicaRepository.GetStanice();
            dgvStanice.DataSource = stanice;
            
        }

        private void dataGridViewStanice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText =textBox2.Text.Trim();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var stanica = StanicaRepository.Pretrazi(searchText);
                dgvStanice.DataSource = stanica;
            }
            else
            {
                ShowStanice();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stanica odabranastnica = dgvStanice.CurrentRow.DataBoundItem as Stanica;
            DialogResult result = MessageBox.Show("Želite li obrisati stanicu?", "Brisanje stanice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                StanicaRepository.Brisi(odabranastnica.BrStanice);
                MessageBox.Show("Stanica je uspješno obrisana!", "Uspješno brisanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowStanice();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDodavanje frmDodavanje = new FrmDodavanje();
            frmDodavanje.ShowDialog();
            ShowStanice() ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
