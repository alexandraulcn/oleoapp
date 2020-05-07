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
using System.Threading.Tasks;

namespace Oleo
{
    class BlendListViewModel
    {
        
        public ICommand AddBlendCommand => new Command(AddBlend);
        public ICommand RemoveBlendCommand => new Command(RemoveBlend);
        public ICommand UpdateBlendCommand => new Command(UpdateBlend);
        public ObservableCollection<Blend> Blends { get; set; }
        public string BlendNume { get; set; }
        public string SelectedBlend { get; set; }

        public BlendListViewModel()
        {
            
            Blends = new ObservableCollection<Blend>();
            Blends.Add(new Blend
            {
                BlendNume = "Easy Breath",
                Ulei1 = "peppermint",
                Cant1 = "3",
                Ulei2 = "eucalyptus",
                Cant2 = "2",
                Ulei3 = "R.C.",
                Cant3 = "5",
                Utilizare = "aplicare in zona plamanilor"
            });

            MessagingCenter.Subscribe<AddOrEditBlendPage, Blend>(this, "AddOrEditBlend", 
                (page, blend) => 
                {
                    if(blend.BlendId == 0)
                    {
                        blend.BlendId = Blends.Count + 1;
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

        public void AddBlend()
        {
           // Blends.Add(BlendNume);
        }

        public void RemoveBlend()
        {
           // Blends.Remove(SelectedBlend);
        }

        public void UpdateBlend()
        {
            //int newIndex = Blends.IndexOf(SelectedBlend);
            //Blends.Remove(SelectedBlend);

            //Blends.Add(BlendNume);
            //int oldIndex = Blends.IndexOf(BlendNume);

            //Blends.Move(oldIndex, newIndex);
        }
    }
}
