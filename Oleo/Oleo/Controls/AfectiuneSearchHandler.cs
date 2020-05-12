using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oleo.Models;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Oleo.Controls
{ 
    
    public class AfectiuneSearchHandler: SearchHandler
    {
        public ObservableCollection<Afectiune> Afectiuni;
        
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
                    .Where(afe => afe.Denumire.ToLower().Contains(newValue.ToLower()))
                    .ToList<Afectiune>();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            await Task.Delay(1000);

            await Shell.Current.GoToAsync($"afectiunedetails ? denumire ={ ((Afectiune)item).Denumire}");
        }
    }
}
