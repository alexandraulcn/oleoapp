using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Oleo.Models;
using Oleo.Service;
using Oleo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Oleo

{
    class BlendListViewModel : INotifyPropertyChanged
    {
        BlendService blendService;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Blend> _blends;
        public ObservableCollection<Blend> Blends
        {
            get { return _blends; }
            set { _blends = value; OnPropertChanged(); }
        }

        public string BlendNume { get; set; }
        public string SelectedBlend { get; set; }
        private bool _isBusy;
        private bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; OnPropertChanged(); }
        }
        
        public BlendListViewModel()
        {
            blendService = new BlendService();
            
            MessagingCenter.Subscribe<AddOrEditBlendPage, Blend>(this, "AddOrEditBlend", 
                (page, blend) => 
                {
                    if(blend.BlendId == 0)
                    {
                        blend.BlendId = Blends.Count +1;
                        Blends.Add(blend);
                    }
                    else
                    {
                        Blend blendToEdit = Blends.Where(ble => ble.BlendId == blend.BlendId).FirstOrDefault();

                        int newIndex = Blends.IndexOf(blendToEdit);
                        Blends.Remove(blendToEdit);

                        Blends.Add(blend);
                        int oldIndex = Blends.IndexOf(blend);

                        Blends.Move(oldIndex, newIndex);
                    }
                   
                });

        }
       
    }
}
