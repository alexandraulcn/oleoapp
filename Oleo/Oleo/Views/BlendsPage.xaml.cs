using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Oleo.Models;

namespace Oleo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlendsPage : ContentPage
    {
        public BlendsPage()
        {
            InitializeComponent();
        }

        private void NewBlendToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddBlend());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Blend>();
                var blends = conn.Table<Blend>().ToList();

                BlendListView.ItemsSource = blends;
            }
        }

        private void BlendListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedBlend = BlendListView.SelectedItem as Blend;
            if (selectedBlend != null)
            {
                Navigation.PushAsync(new BlendDetailPage(selectedBlend));
            }
        }

        
    }
}