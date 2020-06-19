using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Oleo.ViewModels;
using Oleo.Models;
using Oleo.Data;

namespace Oleo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AfectiuneListPage : ContentPage
    {
        public AfectiuneListPage()
        {
            InitializeComponent();
            BindingContext = new AfectiuneListViewModel();
        }

        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            string afectiuneDenumire = (e.Item as Afectiune).Denumire;

            await Shell.Current.GoToAsync($"afectiunedetails?denumire={afectiuneDenumire}");

        }

    }
}