using Oleo.Models;
using Oleo.Views;
using Oleo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Oleo.ViewModels
{
    public class BlendDetailViewModel
    {
        private readonly IBlendingJournal _blendingJournal;
        private readonly IPageService _pageService;
        public Blend Blend { get; private set; }
        public ICommand LoadDataCommand { get; private set; }
        public ICommand AddBlendCommand { get; private set; }
        public ICommand SelectBlendCommand { get; private set; }
        public ICommand UpdateBlendCommand { get; private set; }
        public ICommand DeleteBlendCommand { get; private set; }
        public ObservableCollection<BlendViewModel> Blends { get; private set; }
            = new ObservableCollection<BlendViewModel>();

        public BlendDetailViewModel(BlendViewModel viewModel, IBlendingJournal blendingJournal, PageService pageService)
        {
            if (viewModel == null)
                throw new ArgumentNullException(nameof(viewModel));

            UpdateBlendCommand = new Command<BlendViewModel>(async b => await UpdateBlend(b));

            DeleteBlendCommand = new Command<BlendViewModel>(async b => await DeleteBlend(b));

            _pageService = pageService;
            _blendingJournal = blendingJournal;

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

            MessagingCenter.Subscribe<AddOrEditBlendViewModel, Blend>
            (this, Events.BlendUpdated, OnBlendUpdated);
        }

        private void OnBlendUpdated(AddOrEditBlendViewModel source, Blend blend)
        {
            var blendInList = Blends.Single(b => b.ID == blend.ID);

            blendInList.ID = blend.ID;
            blendInList.Nume = blend.Nume;
            blendInList.Ulei1 = blend.Ulei1;
            blendInList.Ulei2 = blend.Ulei2;
            blendInList.Ulei3 = blend.Ulei3;
            blendInList.Cant1 = blend.Cant1;
            blendInList.Cant2 = blend.Cant2;
            blendInList.Cant3 = blend.Cant3;
            blendInList.Descriere = blend.Descriere;

        }

        private async Task UpdateBlend(BlendViewModel blend)
        {
            await _pageService.PushAsync(new AddOrEditBlendPage(blend));
        }

        private async Task DeleteBlend(BlendViewModel blendViewModel)
        {
            if (await _pageService.DisplayAlert("Avertizare", $"Sunteti sigur ca doriti sa stergeti blendul {blendViewModel.Nume}?", "Da", "Nu"))
            {
                Blends.Remove(blendViewModel);

                var blend = await _blendingJournal.GetBlend(blendViewModel.ID);
                await _blendingJournal.DeleteBlend(blend);
            }
        }
    }
}
