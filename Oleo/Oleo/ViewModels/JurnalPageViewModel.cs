using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Oleo.Models;

namespace Oleo.ViewModels
{
    public class JurnalPageViewModel
    {
        public ObservableCollection<Jurnal> JurnalList { get; set; }

        public JurnalPageViewModel()
        {
            JurnalList = new ObservableCollection<Jurnal>();
            JurnalList.Add(new Jurnal
            {
                Nume = "Easy Breath",
                Ulei1 = "peppermint",
                Cant1 = "3",
                Ulei2 = "eucalyptus",
                Cant2= "2",
                Ulei3="R.C.",
                Cant3="5",
                Carrier="ulei de migdale",
                CantCarrier="8",
                Utilizare="aplicare in zona plamanilor"
            });
        }
    }
}
