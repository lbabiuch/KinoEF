using System;
using System.Collections.Generic;
using System.Text;

namespace KinoEF.Models
{
    class Adres
    {
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public int Numer { get; set; }
        public string NumerTel { get; set; }
        public string Email { get; set; }
        public int IdKina { get; set; }
        public virtual Kino Kino { get; set; }
    }
}
