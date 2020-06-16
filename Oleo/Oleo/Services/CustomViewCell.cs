using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Xamarin.Forms;

namespace Oleo
{
    public class CustomViewCell: ViewCell
    {
      
            public static readonly BindableProperty SelectedItemBackgroundColorProperty =
                BindableProperty.Create("SelectedItemBackgroundColor",
                                        typeof(Color),
                                        typeof(CustomViewCell),
                                        Color.Default);

            public Color SelectedItemBackgroundColor
        {
            get { return (Color)GetValue(SelectedItemBackgroundColorProperty); }

            set { SetValue(SelectedItemBackgroundColorProperty, value); }
        }
        
    }
}
