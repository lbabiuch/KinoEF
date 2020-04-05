using System;
using System.Collections.Generic;
using System.Text;

namespace KinoEF.Models
{
    class Miejsce
    {
        public int IdMiejsca { get; set; }
        public int Rzad { get; set; }
        public int Numer { get; set; }
        public virtual Sala Sala { get; set; }
        public virtual ICollection<Bilet> Bilety { get; set; }
    }
}
