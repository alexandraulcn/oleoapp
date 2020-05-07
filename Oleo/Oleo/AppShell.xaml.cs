using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Oleo.Views;

namespace Oleo
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        
       


        public AppShell()
        {
            InitializeComponent();
            
            BindingContext = this;
        }

        

        void OnNavigating(object sender, ShellNavigatingEventArgs e)
        {
        }

        void OnNavigated(object sender, ShellNavigatedEventArgs e)
        {
        }


    }
}
