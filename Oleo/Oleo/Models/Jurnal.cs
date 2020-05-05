using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Oleo.Models
{
    public class Jurnal
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Ulei1 { get; set; }
        public string Ulei2 { get; set; }
        public string Ulei3 { get; set; }
        public int Cant1 { get; set; }
        public int Cant2 { get; set; }
        public int Cant3 { get; set; }
        public string Carrier { get; set; }
        public int CantCarrier { get; set; }
        public string Utilizare { get; set; }

    }
}

