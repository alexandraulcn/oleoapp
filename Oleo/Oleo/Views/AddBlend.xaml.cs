using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Oleo.Models;
using SQLite;
using Oleo.ViewModels;

namespace Oleo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddBlend : ContentPage
    {
        public AddBlend()
        {
            InitializeComponent();
            BindingContext = new OilPickerViewModel();
           
            
        }
        void SaveButton_Clicked(object sender, EventArgs e)
        {
            
            if (numeEntry.Text == null || cant1Entry.Text == null || ulei1Picker.SelectedItem == null || cant2Entry.Text == null || ulei2Picker.SelectedItem== null
                || cant3Entry.Text == null || ulei3Picker.SelectedItem == null || descriereEntry.Text == null)
            {
                DisplayAlert("Campuri goale!", "Va rugam completati toate campurile.", "Ok");
            }
            else
            {
                Blend blend = new Blend()
                {
                    Nume = numeEntry.Text,
                    Cant1 = cant1Entry.Text,
                    Ulei1 = ulei1Entry.Text,
                    Cant2 = cant2Entry.Text,
                    Ulei2 = ulei2Entry.Text,
                    Cant3 = cant3Entry.Text,
                    Ulei3 = ulei3Entry.Text,
                    Descriere = descriereEntry.Text
                };

                using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
                {
                    conn.CreateTable<Blend>();
                    int rowsAdded = conn.Insert(blend);
                }

                Navigation.PopAsync();
            }
                

        }
    }
}