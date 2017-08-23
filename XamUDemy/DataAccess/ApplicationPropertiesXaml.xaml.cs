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
            Application.Current.Properties["NotificationsEnabled"] = notifacationsEnabled.On;

			//Application.Current.SavePropertiesAsync();
			//This will save the current Properties BEFORE it goes into sleepmode.
			//Usually, Properties get updated after the app goes into sleepmode.
			//This is best for "Transient Data" or Long Text (i.e. Email, Notes, Messages)
		}


        public ApplicationPropertiesXaml()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("Name"))
            //This Property, "Name", returns an object so...
            //we need to include ToString
            title.Text = Application.Current.Properties["Name"].ToString();

            if (Application.Current.Properties.ContainsKey("NotificationsEnabled"))
                notifacationsEnabled.On = (bool)Application.Current.Properties["NotificationsEnabled"];

        }
    }
}
