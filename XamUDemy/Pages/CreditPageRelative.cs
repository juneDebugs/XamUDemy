using System;

using Xamarin.Forms;

namespace XamUDemy.Pages
{
    public class CreditPageRelative : ContentPage
    {
        public CreditPageRelative()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

