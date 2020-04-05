using System;
using System.Collections.Generic;
using System.Text;

namespace KinoEF.Models
{
    class Kino
    {
        public int Id { get; set; }
        public string NazwaKina { get; set; }
        public Adres Adres { get; set; }
        public virtual ICollection<Sala> Sale { get; set; }
    }
}
