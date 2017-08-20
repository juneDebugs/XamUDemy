using System;

using Xamarin.Forms;

namespace XamUDemy.Models
{
    public class SearchGroup : ContentPage
    {
        public SearchGroup()
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

