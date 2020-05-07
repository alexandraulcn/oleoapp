using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Oleo.Models;


namespace Oleo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlendDetailPage : ContentPage
    {
        public BlendDetailPage(Blend blend = null)
        {
            InitializeComponent();

            if( blend != null)
                ((BlendDetailViewModel)BindingContext).Blend = blend;
        }
    }
}