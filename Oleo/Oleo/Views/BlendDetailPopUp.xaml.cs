using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Oleo.Models;
using SQLite;
using System.IO;
using Oleo.ViewModels;
using Oleo.Data;
using Oleo.Services;

namespace Oleo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlendDetailPopUp
    {
        
        public BlendDetailPopUp(BlendViewModel viewModel)
        { 
            InitializeComponent();
            
            var blendingJournal = new SQLiteBlendingJournal(DependencyService.Get<ISQLiteDb>());
            var pageService = new PageService();
            
            ViewModel = new BlendDetailViewModel(viewModel, blendingJournal, pageService);
            BindingContext = new BlendDetailViewModel(viewModel ?? new BlendViewModel(), blendingJournal, pageService);
           
        }

        public BlendDetailViewModel ViewModel
        {
            get { return BindingContext as BlendDetailViewModel; }
            set { BindingContext = value; }
        }



    }
}