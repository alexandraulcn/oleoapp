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
        public void SaveButton_Clicked(object sender, EventArgs e)
        {
            bool isNumeEmpty = string.IsNullOrEmpty(numeEntry.Text);
            bool isCant1Empty = string.IsNullOrEmpty(cant1Entry.Text);
            bool isCant2Empty = string.IsNullOrEmpty(cant2Entry.Text);
            bool isCant3Empty = string.IsNullOrEmpty(cant3Entry.Text);
            bool isDescriereEmpty = string.IsNullOrEmpty(descriereEntry.Text);

            if (isNumeEmpty == true || isCant1Empty == true || ulei1Picker.SelectedItem == null || isCant2Empty == true || ulei2Picker.SelectedItem== null
                || isCant3Empty == true || ulei3Picker.SelectedItem == null || isDescriereEmpty == true)
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

                    if (rowsAdded > 0)
                        DisplayAlert("Succes", "Blend inserat cu succes", "Ok");
                    else
                        DisplayAlert("Eroare", "Blendul nu a putut fi salvat", ":(");
                }

                Navigation.PopAsync();
            }
                

        }
    }
}