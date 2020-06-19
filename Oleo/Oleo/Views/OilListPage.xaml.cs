using Oleo.Models;
using Oleo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

        async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            string oilNume = (e.Item as Oil).Nume;

            await Shell.Current.GoToAsync($"oildetails?nume={oilNume}");

        }
    }
}