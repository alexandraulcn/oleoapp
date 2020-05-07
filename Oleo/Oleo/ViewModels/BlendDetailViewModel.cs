using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Oleo.Models;

namespace Oleo
{
    class BlendDetailViewModel: INotifyPropertyChanged
    {
        private Blend _blend;
        public Blend Blend
        {
            get { return _blend; }
            set { _blend = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
