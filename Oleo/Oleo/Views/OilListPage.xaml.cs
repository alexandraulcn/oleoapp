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
            var viewModel = e.Item as Oil;
            await Navigation.PushAsync(new OilDetailPage(viewModel.Nume, viewModel.Descriere, viewModel.Proprietati, viewModel.Indicatii, viewModel.Aplicare, viewModel.Atentie));
        }


        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _container = BindingContext as OilListViewModel;
            OilListView.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                OilListView.ItemsSource = _container.Oils;
            else
                OilListView.ItemsSource = _container.Oils.Where(i => i.Nume.ToLower().StartsWith(e.NewTextValue.ToLower()));
            OilListView.EndRefresh();


        }

      
    }
}