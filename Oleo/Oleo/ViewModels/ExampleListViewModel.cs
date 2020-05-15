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
                Nume = "BREATHE EASY",
                Ulei1 = "R.C",
                Cant1 = "4",
                Ulei2 = "Eucalyptus",
                Cant2 = "5",
                Ulei3 = "Purification",
                Cant3 = "6"

            });
        }
    }
}
