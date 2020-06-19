using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Oleo.Models;

namespace Oleo.ViewModels
{
    public class OilPickerViewModel: BaseViewModel
    {
        public List<Ingredient> Ingredients { get; set; }
        public OilPickerViewModel()
        {
            Ingredients = GetIngredients().OrderBy(t => t.Value).ToList();
        }

        public List<Ingredient> GetIngredients()
        {
            var ingredients = new List<Ingredient>()
            {
                new Ingredient(){Key = 1, Value = "Lămâie"},
                new Ingredient(){Key = 2, Value = "Mentă"},
                new Ingredient(){Key = 3, Value = "Busuioc"},
                new Ingredient(){Key = 4, Value = "Portocală"},
                new Ingredient(){Key = 5, Value = "Piper negru" },
                new Ingredient(){Key = 6, Value = "Lemn de cedru" },
                new Ingredient(){Key = 7, Value = "Mușețel roman" },
                new Ingredient(){Key = 8, Value = "Scorțișoară" },
                new Ingredient(){Key = 9, Value = "Cuișoare" },
                new Ingredient(){Key = 10, Value = "Copaiba" },
                new Ingredient(){Key = 11, Value = "Elemi" },
                new Ingredient(){Key = 12, Value = "Eucalipt globulus" },
                new Ingredient(){Key = 13, Value = "Eucalipt radiata" },
                new Ingredient(){Key = 14, Value = "Fenicul" },
                new Ingredient(){Key = 15, Value = "Tămâie" },
                new Ingredient(){Key = 16, Value = "Ghimbir" },
                new Ingredient(){Key = 17, Value = "Grapefruit" },
                new Ingredient(){Key = 18, Value = "Cimbru" },
                new Ingredient(){Key = 19, Value = "Iasomie" },
                new Ingredient(){Key = 20, Value = "Lavanda" },
                new Ingredient(){Key = 21, Value = "Lemongrass" },
                new Ingredient(){Key = 22, Value = "Arbore de ceai" },
                new Ingredient(){Key = 23, Value = "Nucșoară" },
                new Ingredient(){Key = 24, Value = "Portocală" },
                new Ingredient(){Key = 25, Value = "Oregano" },
                new Ingredient(){Key = 26, Value = "Pin" },
                new Ingredient(){Key = 27, Value = "Palo Santo" },
                new Ingredient(){Key = 28, Value = "Paciuli" },
                new Ingredient(){Key = 29, Value = "Trandafir" },
                new Ingredient(){Key = 30, Value = "Rozmarin" },
                new Ingredient(){Key = 31, Value = "Mentă verde" },
                new Ingredient(){Key = 32, Value = "Ylang Ylang" },
                new Ingredient(){Key = 33, Value = "Purification" },
                new Ingredient(){Key = 34, Value = "Cocos" },
                new Ingredient(){Key = 35, Value = "Migdale" },
                new Ingredient(){Key = 36, Value = "R.C." }
            };

            return ingredients;
        }
        
    }
}
