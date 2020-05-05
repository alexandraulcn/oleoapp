using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Oleo.Models;
using Oleo.Data;

namespace Oleo.Controls
{
    public class OilSearchHandler : SearchHandler
    {
        public IList<Ulei> Uleiuri { get; set; }
        public Type SelectedItemNavigationTarget { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = Uleiuri
                    .Where(ulei => ulei.Nume.ToLower().Contains(newValue.ToLower()))
                    .ToList<Ulei>();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            await Task.Delay(1000);

            ShellNavigationState state = (App.Current.MainPage as Shell).CurrentState;
            
            await Shell.Current.GoToAsync($"{GetNavigationTarget()}?nume={((Ulei)item).Nume}");
        }

        string GetNavigationTarget()
        {
            return (Shell.Current as AppShell).Routes.FirstOrDefault(route => route.Value.Equals(SelectedItemNavigationTarget)).Key;
        }
    }
}


