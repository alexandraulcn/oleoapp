using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Oleo.Models;

namespace Oleo.ViewModels
{
    class OilListViewModel
    {
        public ObservableCollection<Oil> Oils { get; set; }
        public OilListViewModel()
        {
            Oils = new ObservableCollection<Oil>();
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

