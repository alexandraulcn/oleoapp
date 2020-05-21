using System;
using System.Collections.Generic;
using System.Text;
using Oleo.Models;


namespace Oleo.ViewModels
{
    class ExampleListViewModel
    {
        public List<Example> Examples { get; set; }
        public ExampleListViewModel()
        {
            Examples = new List<Example>();
            Examples.Add(new Example
            {
                Nume = "RESPIRĂ UȘOR",
                Ulei1 = "R.C",
                Cant1 = "4",
                Ulei2 = "Eucalyptus",
                Cant2 = "5",
                Ulei3 = "Purification",
                Cant3 = "6"

            });

            Examples.Add(new Example
            {
                Nume = "ADIO MIROSURI",
                Ulei1 = "Lemongrass",
                Cant1 = "4",
                Ulei2 = "Lemon",
                Cant2 = "3",
                Ulei3 = "Purification",
                Cant3 = "3"

            });

            Examples.Add(new Example
            {
                Nume = "STARE DE BINE",
                Ulei1 = "Lavanda",
                Cant1 = "4",
                Ulei2 = "Salvie",
                Cant2 = "3",
                Ulei3 = "Rozmarin",
                Cant3 = "3"

            });
            Examples.Add(new Example
            {
                Nume = "ENERGIE",
                Ulei1 = "Portocală",
                Cant1 = "3",
                Ulei2 = "Peppermint",
                Cant2 = "3",
                Ulei3 = "Cocos",
                Cant3 = "2"

            });

            Examples.Add(new Example
            {
                Nume = "FOCUS",
                Ulei1 = "Rozmarin",
                Cant1 = "3",
                Ulei2 = "Patchouli",
                Cant2 = "3",
                Ulei3 = "Lămâie",
                Cant3 = "3"

            });
            Examples.Add(new Example
            {
                Nume = "CALM",
                Ulei1 = "Tămâie",
                Cant1 = "5",
                Ulei2 = "Peace & Calming",
                Cant2 = "5",
                Ulei3 = "Cocos",
                Cant3 = "3"

            });
            Examples.Add(new Example
            {
                Nume = "BOOST IMUNITAR",
                Ulei1 = "Thieves",
                Cant1 = "5",
                Ulei2 = "Lămâie",
                Cant2 = "3",
                Ulei3 = "Purification",
                Cant3 = "3"

            });

        }
    }
}
