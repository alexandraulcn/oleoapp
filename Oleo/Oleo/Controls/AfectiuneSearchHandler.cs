using Oleo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Oleo.Controls
{
    public class AfectiuneSearchHandler : SearchHandler
    {
        public IList<Afectiune> Afectiuni { get; set; }
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
                ItemsSource = Afectiuni
                    .Where(a => a.Denumire.ToLower().Contains(newValue.ToLower()))
                    .ToList<Afectiune>();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            string afectiuneDenumire = (item as Afectiune).Denumire;

            await Shell.Current.GoToAsync($"afectiunedetails?denumire={afectiuneDenumire}");
        }

        string GetNavigationTarget()
        {
            return (Shell.Current as AppShell).Routes.FirstOrDefault(route => route.Value.Equals(SelectedItemNavigationTarget)).Key;
        }
    }
}
