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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        }
    }
}
