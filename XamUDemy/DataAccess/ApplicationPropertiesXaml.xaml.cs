using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.DataAccess
{
    public partial class ApplicationPropertiesXaml : ContentPage
    {
        //To have this available Project-Wide, 
        //we need to put this into the Application Class (App.Xaml)
        private const string TitleKey = "Name";
        private const string NotificationsEnabledKey = "NotificationsEnabled";

		//Notice that we only have ONE Event handler for TWO handles
		void OnChange(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
			//Since we set everything in the Application Class we can refactor this code

			//Application.Current.Properties[TitleKey] = title.Text;
			//This is for EntryCell

			//Application.Current.Properties[NotificationsEnabledKey] = notifacationsEnabled.On;
			//This is for the switchCell

			//Application.Current.SavePropertiesAsync();
			//This will save the current Properties BEFORE it goes into sleepmode.
			//Usually, Properties get updated after the app goes into sleepmode.
			//This is best for "Transient Data" or Long Text (i.e. Email, Notes, Messages)


			//This is the refactored code
			var app = Application.Current as App;
            app.Title = title.Text;
            app.NotificationsEnabled = notifacationsEnabled.On;
        }


        public ApplicationPropertiesXaml()
        {
            InitializeComponent();

			//Since we set everything in the Application Class we can refactor this code

			//if (Application.Current.Properties.ContainsKey(TitleKey))

			//title.Text = Application.Current.Properties[TitleKey].ToString();
			//This Property, "Name", returns an object so...
			//we need to include ToString

			//if (Application.Current.Properties.ContainsKey(NotificationsEnabledKey))
			//notifacationsEnabled.On = (bool)Application.Current.Properties[NotificationsEnabledKey];

			//This is the refactored code
			var app = Application.Current as App;
            title.Text = app.Title;
            notifacationsEnabled.On = app.NotificationsEnabled;
        }
    }
}
