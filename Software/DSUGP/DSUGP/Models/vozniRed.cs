using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSUGP.Models
{
    internal class vozniRed
    {
        public int Id_vozni_red { get; set; }
        public int Id_linije { get; set; }
        public int Id_stanice { get; set; }
        public int Id_vozni_park { get; set; }
        public string Naziv_stanice { get; set; }
        public string Naziv_linije { get; set; }
        public string Naziv_vozila { get; set; }
    }
}