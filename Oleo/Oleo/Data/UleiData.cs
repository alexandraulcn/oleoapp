using System;
using System.Collections.Generic;
using System.Text;
using Oleo.Models;

namespace Oleo.Data
{
    public static class UleiData
    {
        public static IList<Ulei> Uleiuri { get; private set; }
        static UleiData()
        {
            Uleiuri = new List<Ulei>();
            Uleiuri.Add(new Ulei
            {
                Nume = "Lamaie",
                Descriere = "Se compune din 68% d-limonene",
                Proprietati = "sursa vitamine",
                Indicatii = "probleme diverse",
                Aplicare = "A",
                Atentie = "a"
            });
        }
     }
}
