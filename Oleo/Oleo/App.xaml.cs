using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Oleo.Views;
using System.IO;


namespace Oleo
{
    public partial class App : Application
    {
        public static string FilePath;
        public App(string filePath)
        {
            InitializeComponent();

            MainPage = new AppShell();

            FilePath = filePath;
            

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
