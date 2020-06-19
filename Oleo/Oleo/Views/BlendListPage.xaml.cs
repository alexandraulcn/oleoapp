using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Oleo.Models;
using Oleo.Data;
using Oleo.Services;
using Oleo.ViewModels;

namespace Oleo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlendListPage : ContentPage
    {
        public BlendListPage()
        {
            InitializeComponent();

            var blendingJournal = new SQLiteBlendingJournal(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();
            ViewModel = new BlendListViewModel(blendingJournal, pageService);
        }

        protected override void OnAppearing()
        {
            ViewModel.LoadDataCommand.Execute(null);
            base.OnAppearing();
        }

        private void OnBlendSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ViewModel.SelectBlendCommand.Execute(e.SelectedItem);
        }

        public BlendListViewModel ViewModel
        {
            get { return BindingContext as BlendListViewModel; }
            set { BindingContext = value; }
        }

    }
}