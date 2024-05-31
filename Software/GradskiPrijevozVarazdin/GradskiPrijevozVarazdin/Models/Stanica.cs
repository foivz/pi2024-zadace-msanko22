using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradskiPrijevozVarazdin.Models
{
    public class Stanica
    {
        public int BrStanice { get; set; }
        public string NazivAdresaStanice { get; set; }
        public string Opis { get; set; }
        public int BrPeronaNaStanici { get; set; }
        public string Linija { get; set; }
        public int Kapacitet { get; set; }
        public string Zaposlenik {  get; set; }

        public override string ToString()
        {
            return NazivAdresaStanice + " " + Linija;
        }

    }
}
