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
    public partial class JurnalPageDetail : ContentPage
    {
        public JurnalPageDetail(string Nume, string Ulei1, string Ulei2, string Ulei3, string Cant1, string Cant2, string Cant3, string Carrier, string CantCarrier, string Utilizare)
        {
            InitializeComponent();

            NumeJurnal.Text = Nume;
            Ulei1Jurnal.Text = Ulei1;
            Ulei2Jurnal.Text = Ulei2;
            Ulei3Jurnal.Text = Ulei3;
            Cant1Jurnal.Text = Cant1;
            Cant2Jurnal.Text = Cant2;
            Cant3Jurnal.Text = Cant3;
            CarrierJurnal.Text = Carrier;
            CantCarrierJurnal.Text = CantCarrier;
            UtilizareJurnal.Text = Utilizare;
        }
    }
}