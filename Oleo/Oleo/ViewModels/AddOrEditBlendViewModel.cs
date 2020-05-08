using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Oleo.Models;
using Oleo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


namespace Oleo.ViewModels
{
     public class AddOrEditBlendViewModel: INotifyPropertyChanged
    {
        private Blend _blend;

        public Blend Blend 
        {
            get { return _blend; }
            set { _blend = value; OnPropertyChanged(); }
        }

        public AddOrEditBlendViewModel()
        {
            Blend = new Blend();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
