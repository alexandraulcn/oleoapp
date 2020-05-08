using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Oleo.Models;


namespace Oleo.Service
{
    class BlendService
    {
        public ObservableCollection<Blend> Blends { get; set; }
        public BlendService()
        {
            Blends = new ObservableCollection<Blend>();
            InitializeBlendService();
        }

        public void InitializeBlendService()
        {
            Blends.Add(new Blend
            {
               BlendId = 1,
               BlendNume = "Easy Breath",
               Ulei1 = "peppermint",
               Cant1 = "3",
               Ulei2 = "eucalyptus",
               Cant2 = "2",
               Ulei3 = "R.C.",
               Cant3 = "5",
               Utilizare = "aplicare in zona plamanilor"
            });
        }

        public async Task<bool> AddBlendAsync(Blend blend)
        {
            Blends.Add(blend);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateBlendsAsync(Blend blend)
        {
            Blend blendToEdit = Blends.Where(ble => ble.BlendId == blend.BlendId).FirstOrDefault();

            int newIndex = Blends.IndexOf(blendToEdit);
            Blends.Remove(blendToEdit);

            Blends.Add(blend);
            int oldIndex = Blends.IndexOf(blend);

            Blends.Move(oldIndex, newIndex);

            return await Task.FromResult(true);
        }
    }
}
