using Oleo.ViewModels;
using Rg.Plugins.Popup.Pages;
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
    public partial class IngredientePopUp 
    {
        public IngredientePopUp()
        {
            InitializeComponent();

            BindingContext = new OilPickerViewModel();
            
           
        }

    }
}