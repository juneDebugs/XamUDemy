using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.DataAccess
{
    public partial class ApplicationPropertiesXaml : ContentPage
    {
        //Notice that we only have ONE Event handler

        void OnChange(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            //This is for EntryCell
            Application.Current.Properties["Name"] = title.Text;

            //This is for the switchCell
            Application.Current.Properties["NotificationsEnabled"] = title.Text;
        }

        public ApplicationPropertiesXaml()
        {
            InitializeComponent();
        }
    }
}
