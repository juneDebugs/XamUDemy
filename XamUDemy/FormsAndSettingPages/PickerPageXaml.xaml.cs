using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.FormsAndSettingPages
{
    public partial class PickerPageXaml : ContentPage
    {
        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var contactMethod = contactMethods.Items[contactMethods.SelectedIndex];
            DisplayAlert("Selection", contactMethod, "OK");
        }

        public PickerPageXaml()
        {
            InitializeComponent();
        }
    }
}
