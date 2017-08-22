using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Navigations
{
    public partial class ModalSecondPage : ContentPage
    {
        public ModalSecondPage()
        {
            InitializeComponent();
        }

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PopModalAsync();
		}

		//This prevents Android and Windows phone to use the physical "Back" Button
		protected override bool OnBackButtonPressed()
		{
			return true;
		}
	
    }
}
