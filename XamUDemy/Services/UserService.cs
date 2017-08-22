using System;

using Xamarin.Forms;

namespace XamUDemy.Services
{
    public class UserService : ContentPage
    {
        public UserService()
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

