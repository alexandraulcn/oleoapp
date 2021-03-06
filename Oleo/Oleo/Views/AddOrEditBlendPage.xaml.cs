﻿using Oleo.Models;
using Oleo.Data;
using Oleo.Services;
using Oleo.ViewModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Oleo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddOrEditBlendPage : ContentPage
    {
        public AddOrEditBlendPage(BlendViewModel viewModel)
        {
            

            InitializeComponent();
            
            var blendingJournal = new SQLiteBlendingJournal(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();
            Title = (viewModel.Nume == null) ? "Blend nou" : "Modifică blend";
            BindingContext = new AddOrEditBlendViewModel(viewModel ?? new BlendViewModel(), blendingJournal, pageService);
            
        }

        private void ShowPopup(object o, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new IngredientePopUp());
        }

    }
}