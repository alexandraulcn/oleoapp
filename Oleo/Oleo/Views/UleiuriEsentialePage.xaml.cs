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
    public partial class UleiuriEsentialePage : ContentPage
    {
        public UleiuriEsentialePage()
        {
            InitializeComponent();
            
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string uleiNume = (e.CurrentSelection.FirstOrDefault() as Ulei).Nume;
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"uleidetalii?nume={uleiNume}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/bears/beardetails?name={bearName}");

        }
    }
}