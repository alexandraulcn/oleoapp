using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Oleo.Views;
using System.IO;
using System.Reflection;

[assembly: ExportFont("Merriweather-Bold.ttf", Alias = "Bold")]
[assembly: ExportFont("Merriweather-BoldItalic.ttf", Alias = "BoldItalic")]
[assembly: ExportFont("Merriweather-Italic.ttf", Alias = "Italic")]
[assembly: ExportFont("Merriweather-LightItalic.ttf", Alias = "LightItalic")]
[assembly: ExportFont("Merriweather-Regular.ttf", Alias = "Regular")]
namespace Oleo
{
    public partial class App : Application
    {
       
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

           
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
