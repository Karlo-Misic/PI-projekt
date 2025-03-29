using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSUGP.Models
{
    internal class Zaposlenik : Osoba
    {
        public int Id_zaposlenik { get; set; }
        public string KorIme { get; set; }
        public string Lozinka { get; set; }
    }
}