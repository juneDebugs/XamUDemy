using System;

using Xamarin.Forms;

namespace XamUDemy.Models
{
    public class Activity : ContentPage
    {
        public Activity()
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

