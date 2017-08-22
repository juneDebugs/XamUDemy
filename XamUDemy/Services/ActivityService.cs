using System;

using Xamarin.Forms;

namespace XamUDemy.Services
{
    public class ActivityService : ContentPage
    {
        public ActivityService()
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

