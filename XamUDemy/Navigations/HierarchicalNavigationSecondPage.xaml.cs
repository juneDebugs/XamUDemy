using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Navigations
{
    public partial class HierarchicalNavigationSecondPage : ContentPage
    {

        public HierarchicalNavigationSecondPage()
        {
            InitializeComponent();
        }
		
        async void Handle_Clicked(object sender, System.EventArgs e)
		{
            await Navigation.PopAsync();
		}
    }
}
