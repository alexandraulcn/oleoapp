using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SQLite;
using Oleo.Models;

namespace Oleo.ViewModels
{
    class OilListViewModel
    {
        public List<Oil> Oils { get; set; }
        public OilListViewModel()
        {
            Oils = new List<Oil>();
            /*Oils.Add(new Oil
            {
                Nume = "",
                Descriere = "",
                Proprietati = "",
                Indicatii = "",
                Aplicare = "",
                Atentie = ""
            })*/

            Oils.Add(new Oil
            {
                Nume = "Lamaie",
                Descriere = "w",
                Proprietati = "s",
                Indicatii = "s",
                Aplicare = "s",
                Atentie = "s"
            });

            Oils.Add(new Oil
            {
                Nume = "Peppermint",
                Descriere = "w",
                Proprietati = "s",
                Indicatii = "s",
                Aplicare = "s",
                Atentie = "s"
            });
        }
    }
}

