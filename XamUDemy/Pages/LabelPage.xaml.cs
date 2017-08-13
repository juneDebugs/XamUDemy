using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Pages
{
    public partial class LabelPage : ContentPage
    {
        public LabelPage()
        {
            InitializeComponent();

            //This shows how you can create a label in both C# and XAML
            Content = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Do More"
            };
        }
    }
}
