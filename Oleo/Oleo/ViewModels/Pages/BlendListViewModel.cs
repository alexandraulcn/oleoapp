using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Oleo.Models;
using Oleo.Data;
using Oleo.Services;
using Oleo.Views;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;

namespace Oleo.ViewModels
{
    public class BlendListViewModel : BaseViewModel
    {
        private BlendViewModel _selectedBlend;
        private IBlendingJournal _blendingJournal;
        private PageService _pageService;

        private bool _isDataLoaded;

        public ObservableCollection<BlendViewModel> Blends { get; private set; }
            = new ObservableCollection<BlendViewModel>();

        public BlendViewModel SelectedBlend
        {
            get { return _selectedBlend; }
            set { SetValue(ref _selectedBlend, value); }
        }

        public ICommand LoadDataCommand { get; private set; }
        public ICommand AddBlendCommand { get; private set; }
        public ICommand SelectBlendCommand { get; private set; }
        public ICommand UpdateBlendCommand { get; private set; }
        public ICommand DeleteBlendCommand { get; private set; }

        public BlendListViewModel(IBlendingJournal blendingJournal, PageService pageService)
        {
            _blendingJournal = blendingJournal;
            _pageService = pageService;

            LoadDataCommand = new Command(async () => await LoadData());
            AddBlendCommand = new Command(async () => await AddBlend());
            SelectBlendCommand = new Command<BlendViewModel>(async b => await SelectBlend(b));
            UpdateBlendCommand = new Command<BlendViewModel>(async b => await UpdateBlend(b));
            DeleteBlendCommand = new Command<BlendViewModel>(async b => await DeleteBlend(b));

            MessagingCenter.Subscribe<AddOrEditBlendViewModel, Blend>
                (this, Events.BlendAdded, OnBlendAdded);

            MessagingCenter.Subscribe<AddOrEditBlendViewModel, Blend>
            (this, Events.BlendUpdated, OnBlendUpdated);
        }

        private void OnBlendAdded(AddOrEditBlendViewModel source, Blend blend)
        {
            Blends.Add(new BlendViewModel(blend));
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
        private async Task LoadData()
        {
            if (_isDataLoaded)
                return;

            _isDataLoaded = true;
            var blends = await _blendingJournal.GetBlendsAsync();
            foreach (var blend in blends)
                Blends.Add(new BlendViewModel(blend));
        }

        private async Task AddBlend()
        {
            await _pageService.PushAsync(new AddOrEditBlendPage(new BlendViewModel()));
        }

        private async Task SelectBlend(BlendViewModel blend)
        {
            if (blend == null)
                return;

            SelectedBlend = null;
            await PopupNavigation.Instance.PushAsync(new BlendDetailPopUp(blend));
            
        }

        private async Task UpdateBlend(BlendViewModel blend)
        {
            await _pageService.PushAsync(new AddOrEditBlendPage(blend));
        }

        private async Task DeleteBlend(BlendViewModel blendViewModel)
        {
            if (await _pageService.DisplayAlert("Avertizare", $"Sunteți sigur că doriți să ștergeți blendul {blendViewModel.Nume}?", "Da", "Nu"))
            {
                Blends.Remove(blendViewModel);

                var blend = await _blendingJournal.GetBlend(blendViewModel.ID);
                await _blendingJournal.DeleteBlend(blend);
            }
        }

    }
}
