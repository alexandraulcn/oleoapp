using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Oleo.ViewModels;
using Oleo.Models;

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
            var mydetails = e.Item as Afectiune;
            await Navigation.PushAsync(new AfectiuneDetailPage(mydetails.Denumire, mydetails.Descriere,mydetails.Recomandari,mydetails.Aplicare));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}