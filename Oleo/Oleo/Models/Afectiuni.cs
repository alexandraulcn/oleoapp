using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Oleo.Models
{
    public class Afectiuni
    {
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public string Recomandari { get; set; }
        public string Aplicare { get; set; }

    }
}
