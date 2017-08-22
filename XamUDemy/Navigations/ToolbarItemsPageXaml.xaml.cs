using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Navigations
{
    public partial class ToolbarItemsPageXaml : ContentPage
    {
        void Handle_Activated(object sender, System.EventArgs e)
        {
            DisplayAlert("Activated", "Toolbar Item Activated", "OK");
        }

        public ToolbarItemsPageXaml()
        {
            InitializeComponent();
        }
    }
}
