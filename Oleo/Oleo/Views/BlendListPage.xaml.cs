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
    public partial class BlendListPage : ContentPage
    {
        public BlendListPage()
        {
            InitializeComponent();

        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddOrEditBlendPage());
        }

        private void TapGestureRecognizer_Tapped_Edit(object sender, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;

            Blend blend = ((BlendListViewModel)BindingContext).Blends.Where(ble => ble.BlendId == (int)tappedEventArgs.Parameter).FirstOrDefault();

            Navigation.PushAsync(new AddOrEditBlendPage(blend));
        }

        private void TapGestureRecognizer_Tapped_Remove(object sender, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;

            Blend blend = ((BlendListViewModel)BindingContext).Blends.Where(ble => ble.BlendId == (int)tappedEventArgs.Parameter).FirstOrDefault();
            ((BlendListViewModel)BindingContext).Blends.Remove(blend);
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new BlendDetailPage((Blend)e.SelectedItem));
        }


    }
}