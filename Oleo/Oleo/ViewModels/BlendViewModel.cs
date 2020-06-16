using Oleo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Oleo.ViewModels
{
    public class BlendViewModel : BaseViewModel
    {
        public int ID { get; set; }
        public BlendViewModel() { }
        public BlendViewModel(Blend blend)
        {
            ID = blend.ID;
            _nume = blend.Nume;
            _ulei1 = blend.Ulei1;
            _ulei2 = blend.Ulei2;
            _ulei3 = blend.Ulei3;
            _cant1 = blend.Cant1;
            _cant2 = blend.Cant2;
            _cant3 = blend.Cant3;
            _descriere = blend.Descriere;
        }

        private string _nume;
        public string Nume
        {
            get { return _nume; }
            set
            {
                SetValue(ref _nume, value);
            }
        }

        private string _ulei1;
        public string Ulei1
        {
            get { return _ulei1; }
            set
            { 
                SetValue(ref _ulei1, value);
            }
        }
        private string _ulei2;
        public string Ulei2
        {
            get { return _ulei2; }
            set
            {
                SetValue(ref _ulei2, value);
            }
        }

        private string _ulei3;
        public string Ulei3
        {
            get { return _ulei3; }
            set
            {
                SetValue(ref _ulei3, value);
            }
        }

        private string _cant1;
        public string Cant1
        {
            get { return _cant1; }
            set
            {
                SetValue(ref _cant1, value);
            }
        }

        private string _cant2;
        public string Cant2
        {
            get { return _cant2; }
            set
            {
                SetValue(ref _cant2, value);
            }
        }
        private string _cant3;
        public string Cant3
        {
            get { return _cant3; }
            set
            {
                SetValue(ref _cant3, value);
            }
        }

        private string _descriere;
        public string Descriere
        {
            get { return _descriere; }
            set
            {
                SetValue(ref _descriere, value);
            }
        }
    }
}
