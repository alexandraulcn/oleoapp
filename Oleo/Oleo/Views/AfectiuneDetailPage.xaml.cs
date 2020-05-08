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
    public partial class AfectiuneDetailPage : ContentPage
    {
        public AfectiuneDetailPage(string Denumire, string Descriere, string Recomandari, string Aplicare)
        {
            InitializeComponent();

            DenumireAfectiune.Text = Denumire;
            DescriereAfectiune.Text = Descriere;
            RecomandariAfectiune.Text = Recomandari;
            AplicareAfectiune.Text = Aplicare;
            
        }
    }
}