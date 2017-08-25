using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.FormsAndSettingPages
{
    public partial class PickerWithNavigationXaml : ContentPage
    {
        void Handle_Tapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ContactMethodsPage());
        }

        public PickerWithNavigationXaml()
        {
            InitializeComponent();
        }
    }
}
