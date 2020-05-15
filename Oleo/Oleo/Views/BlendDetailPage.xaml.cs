using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Oleo.Models;
using SQLite;

namespace Oleo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlendDetailPage : ContentPage
    {
        Blend selectedBlend;
        public BlendDetailPage(Blend selectedBlend)
        { 
            InitializeComponent();

            this.selectedBlend = selectedBlend;

            NumeBlend.Text = selectedBlend.Nume;
            Ulei1Blend.Text = selectedBlend.Ulei1;
            Ulei2Blend.Text = selectedBlend.Ulei2;
            Ulei3Blend.Text = selectedBlend.Ulei3;
            Cant1Blend.Text = selectedBlend.Cant1;
            Cant2Blend.Text = selectedBlend.Cant2;
            Cant3Blend.Text = selectedBlend.Cant3;
            DescriereBlend.Text = selectedBlend.Descriere;
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Blend>();
                int rows = conn.Delete(selectedBlend);

                if (rows < 0)
                    DisplayAlert("Eroare","Stergerea nu a putut fi realizata", "Ok");
            }

            Navigation.PopAsync();
        }
    }
}