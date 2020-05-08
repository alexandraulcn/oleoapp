using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Oleo.Models;
using Oleo.ViewModels;

namespace Oleo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OilListPage : ContentPage
    {
        public OilListPage()
        {
            InitializeComponent();
            BindingContext = new OilListViewModel();
        }

        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as Oil;
            await Navigation.PushAsync(new OilDetailPage(mydetails.Nume, mydetails.Descriere, mydetails.Proprietati,mydetails.Indicatii, mydetails.Aplicare, mydetails.Atentie));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}