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
    public partial class JurnalPage : ContentPage
    {
        public JurnalPage()
        {
            InitializeComponent();
            BindingContext = new JurnalPageViewModel();
            
        }

        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var myblends = e.Item as Jurnal;
            await Navigation.PushAsync(new JurnalPageDetail(myblends.Nume, myblends.Ulei1, myblends.Ulei2, myblends.Ulei3,
                myblends.Cant1, myblends.Cant2, myblends.Cant3, myblends.Carrier, myblends.CantCarrier, myblends.Utilizare));
        }
    }
}