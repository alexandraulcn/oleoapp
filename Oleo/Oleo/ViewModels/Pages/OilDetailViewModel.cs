using Oleo.Data;
using Oleo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Oleo.ViewModels
{
    [QueryProperty("OilNume", "nume")]
    class OilDetailViewModel : BaseViewModel
    {
        public string OilNume
        {
            set
            {
                Oil oil = OilData.Oils.FirstOrDefault(o => o.Nume == Uri.UnescapeDataString(value));

                if (oil != null)
                {
                    Nume = oil.Nume;
                    Descriere = oil.Descriere;
                    Proprietati = oil.Proprietati;
                    Indicatii = oil.Indicatii;
                    Aplicare = oil.Aplicare;
                    Atentie = oil.Atentie;

                    OnPropertyChanged("Nume");
                    OnPropertyChanged("Descriere");
                    OnPropertyChanged("Proprietati");
                    OnPropertyChanged("Indicatii");
                    OnPropertyChanged("Aplicare");
                    OnPropertyChanged("Atentie");
                }
            }
        }

        public string Nume { get; set; }
        public string Descriere { get; private set; }
        public string Proprietati { get; private set; }
        public string Indicatii { get; private set; }
        public string Aplicare { get; private set; }
        public string Atentie { get; private set; }

    }
}
