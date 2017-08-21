using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Navigations
{
    public partial class ModalFirstPage : ContentPage
    {
        public ModalFirstPage()
        {
            InitializeComponent();
        }

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new HierarchicalNavigationSecondPage());
		}

    }
}
