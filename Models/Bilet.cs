using System;
using System.Collections.Generic;
using System.Text;

namespace KinoEF.Models
{
    class Bilet
    {
        public int IdBiletu { get; set; }
        public double Cena { get; set; }
        public virtual Miejsce Miejsce { get; set; }
        public virtual Seans Seans { get; set; }
    }
}
