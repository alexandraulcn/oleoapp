using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Oleo.Models;
using Oleo.Data;

namespace Oleo.Views
{
    [QueryProperty("Denumire", "denumire")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AfectiuneDetailPage : ContentPage
    {
        public string Denumire 
        {
            set
            {
                BindingContext = AfectiuneData.Afectiuni.FirstOrDefault(a => a.Denumire == Uri.UnescapeDataString(value));
            }
        }
        public AfectiuneDetailPage()
        {
            InitializeComponent();
           

        }
    }
}