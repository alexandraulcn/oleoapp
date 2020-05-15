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
                Nume = "Lamâie",
                Descriere = "w",
                Proprietati = "s",
                Indicatii = "s",
                Aplicare = "s",
                Atentie = "s"
            });

            Oils.Add(new Oil
            {
                Nume = "Mentă",
                Descriere = "w",
                Proprietati = "s",
                Indicatii = "s",
                Aplicare = "s",
                Atentie = "s"
            });

            Oils.Add(new Oil
            {
                Nume = "Busuioc"
            });

            Oils.Add(new Oil
            {
                Nume = "Arbore de ceai"
            });
        }
    }
}

