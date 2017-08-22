using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Navigations
{
    public partial class ActionSheetXaml : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var response = await DisplayActionSheet("Nike", "Cancel", "Delete", "Buy Shoe", "Call Jordan", "Copy Link");

            DisplayAlert("Response", response, "OK");
        }

        public ActionSheetXaml()
        {
            InitializeComponent();
        }
    }
}
