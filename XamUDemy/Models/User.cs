using System;

using Xamarin.Forms;

namespace XamUDemy.Models
{
    public class User : ContentPage
    {
        public User()
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

