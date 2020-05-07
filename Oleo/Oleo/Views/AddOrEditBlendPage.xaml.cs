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
    public partial class AddOrEditBlendPage : ContentPage
    {
        public AddOrEditBlendPage(Blend blend = null)
        {
            InitializeComponent();
            if(blend != null)
            {
                ((AddOrEditBlendViewModel)BindingContext).Blend = blend;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Blend blend = ((AddOrEditBlendViewModel)BindingContext).Blend;
            MessagingCenter.Send(this, "AddOrEditBlend", blend);
            Navigation.PopAsync();
        }
    }
}