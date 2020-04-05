using System;
using System.Collections.Generic;
using System.Text;

namespace KinoEF.Models
{
    class Sala
    {
        public int IdSali { get; set; }
        public string NazwaSali { get; set; }
        public int LiczbaMiejsc { get; set; }
        public virtual Kino Kino { get; set; }
        public ICollection<Miejsce> Miejsca { get; set; }
    }
}
