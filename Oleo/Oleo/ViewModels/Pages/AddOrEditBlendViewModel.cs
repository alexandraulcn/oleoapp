using Oleo.Models;
using Oleo.Services;
using Oleo.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace Oleo.ViewModels
{
    public class AddOrEditBlendViewModel
    {
        private readonly IBlendingJournal _blendingJournal;
        private readonly IPageService _pageService;
        public Blend Blend { get; private set; }
        public ICommand SaveCommand { get; set; }

        public AddOrEditBlendViewModel(BlendViewModel viewModel, IBlendingJournal blendingJournal, IPageService pageService)
        {
            if (viewModel == null)
                throw new ArgumentNullException(nameof(viewModel));

            _pageService = pageService;
            _blendingJournal = blendingJournal;
            SaveCommand = new Command(async () => await Save());
            Blend = new Blend
            {
                ID = viewModel.ID,
                Nume = viewModel.Nume,
                Cant1 = viewModel.Cant1,
                Ulei1 = viewModel.Ulei1,
                Cant2 = viewModel.Cant2,
                Ulei2 = viewModel.Ulei2,
                Cant3 = viewModel.Cant3,
                Ulei3 = viewModel.Ulei3,
                Descriere = viewModel.Descriere
            };
        }

        public async Task Save()
        {
            if (   String.IsNullOrWhiteSpace(Blend.Nume)
                || String.IsNullOrWhiteSpace(Blend.Ulei1)
                || String.IsNullOrWhiteSpace(Blend.Cant1)
                || String.IsNullOrWhiteSpace(Blend.Cant2)
                || String.IsNullOrWhiteSpace(Blend.Cant3)
                || String.IsNullOrWhiteSpace(Blend.Ulei2)
                || String.IsNullOrWhiteSpace(Blend.Ulei3)
                || String.IsNullOrWhiteSpace(Blend.Descriere))
            {
                await _pageService.DisplayAlert("Câmpuri goale", "Vă rugăm completați toate câmpurile.", "OK");
                return;
            }
            if (Blend.ID == 0)
            {
                await _blendingJournal.AddBlend(Blend);
                MessagingCenter.Send(this, Events.BlendAdded, Blend);
            }
            else
            {
                await _blendingJournal.UpdateBlend(Blend);
                MessagingCenter.Send(this, Events.BlendUpdated, Blend);
            }
            await _pageService.PopAsync();
        }



    }
}