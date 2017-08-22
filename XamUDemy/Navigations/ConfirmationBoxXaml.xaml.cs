using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Navigations
{
    public partial class ConfirmationBoxXaml : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");
            if (response)
                await DisplayAlert("Done", "Your response will be saved", "OK");
                //await here does not matter because there is no code after this line
                //If we had more code, then we have to await
        }

        public ConfirmationBoxXaml()
        {
            InitializeComponent();
        }
    }
}
