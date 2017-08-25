using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.FormsAndSettingPages
{
    public partial class ContactMethodsPage : ContentPage
    {
        public ContactMethodsPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<string>
            {
                "None",
                "Email",
                "SMS"
            };
        }
    }
}
