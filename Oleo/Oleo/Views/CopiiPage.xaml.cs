using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Oleo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CopiiPage : ContentPage
    {
        public CopiiPage()
        {
            InitializeComponent();
        }

        public void OnButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DiluarePage());
        }
    }
}