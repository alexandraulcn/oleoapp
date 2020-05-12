using System;
using System.Text;
using SQLite;


namespace Oleo.Models
{
    public class Blend
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Ulei1 { get; set; }
        public string Ulei2 { get; set; }
        public string Ulei3 { get; set; }
        public string Cant1 { get; set; }
        public string Cant2 { get; set; }
        public string Cant3 { get; set; }
        public string Utilizare { get; set; }

        public Blend()
        {

        }
    }
}

