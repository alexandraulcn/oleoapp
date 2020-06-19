using Oleo.Data;
using Oleo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Oleo.ViewModels
{
   
    class AfectiuneDetailViewModel: BaseViewModel
    {
        public string AfectiuneDenumire
        {
            set
            {
                Afectiune afectiune = AfectiuneData.Afectiuni.FirstOrDefault(a => a.Denumire == Uri.UnescapeDataString(value));

                if (afectiune != null)
                {
                    Denumire =afectiune.Denumire;
                    Descriere = afectiune.Descriere;
                    Recomandari = afectiune.Recomandari;
                    Aplicare = afectiune.Aplicare;
                    OnPropertyChanged("Denumire");
                    OnPropertyChanged("Descriere");
                    OnPropertyChanged("Recomandari");
                    OnPropertyChanged("Aplicare");
                }
            }
        }

        public string Denumire { get; set; }
        public string Descriere { get; private set; }
        public string Recomandari { get; private set; }
        public string Aplicare { get; private set; }


       
    }
}
