using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSUGP.Models
{
    internal class VoznaLinija
    {
        public int Id_linija { get; set; }
        public string Naziv_linije { get; set; }
        public string Prva_stanica { get; set; }
        public string Zadnja_stanica { get; set; }
        public string Vrijeme_pocetka { get; set; }
        public string Vrijeme_zavrsetka { get; set; }
    }
}
