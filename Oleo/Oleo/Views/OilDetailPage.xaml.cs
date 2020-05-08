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
    public partial class OilDetailPage : ContentPage
    {
        public OilDetailPage(string Nume, string Descriere, string Proprietati,string Indicatii, string Aplicare, string Atentie)
        {
            InitializeComponent();

            NumeOil.Text = Nume;
            DescriereOil.Text = Descriere;
            ProprietatiOil.Text = Proprietati;
            IndicatiiOil.Text = Indicatii;
            AplicareOil.Text = Aplicare;
            AtentieOil.Text = Atentie;

        }
    }
}