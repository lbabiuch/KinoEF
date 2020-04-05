using System;
using System.Collections.Generic;
using System.Text;

namespace KinoEF.Models
{
    class Seans
    {
        public int IdSeansu { get; set; }
        public string NazwaSeansu { get; set; }
        public DateTime Data { get; set; }
        public DateTime Godzina { get; set; }
        public virtual ICollection<Bilet> Bilety { get; set; }
    }
}
