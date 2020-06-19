using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Oleo.Models;
using Oleo.ViewModels;
using Oleo.Data;

namespace Oleo.Views
{
    [QueryProperty("Nume", "nume")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OilDetailPage : ContentPage
    {
        public string Nume
        {
            set
            {
                BindingContext = OilData.Oils.FirstOrDefault(o => o.Nume == Uri.UnescapeDataString(value));
            }
        }

        public OilDetailPage() 
        { 
            InitializeComponent();
        }

    }
}