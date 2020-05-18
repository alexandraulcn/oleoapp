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
            var _container = BindingContext as AfectiuneListViewModel;
            AfectiuniListView.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                AfectiuniListView.ItemsSource = _container.Afectiuni;
            else
                AfectiuniListView.ItemsSource = _container.Afectiuni.Where(i => i.Denumire.ToLower().StartsWith(e.NewTextValue.ToLower()));
            AfectiuniListView.EndRefresh();


        }

        
    }
}