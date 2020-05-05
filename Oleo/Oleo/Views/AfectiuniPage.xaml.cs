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
    public partial class AfectiuniPage : ContentPage
    {
        public AfectiuniPage()
        {
            InitializeComponent();
            BindingContext = new AfectiuniPageViewModel();
        }

        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as Afectiuni;
            await Navigation.PushAsync(new AfectiuniPageDetail(mydetails.Denumire, mydetails.Descriere,mydetails.Recomandari,mydetails.Aplicare));
        }
    }
}