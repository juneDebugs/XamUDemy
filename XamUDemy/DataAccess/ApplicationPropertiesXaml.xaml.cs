using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.DataAccess
{
    public partial class ApplicationPropertiesXaml : ContentPage
    {
        //To have this available Project-Wide, 
        //we need to put this into the Application Class (App.Xaml)
        //private const string TitleKey = "Name";
        //private const string NotificationsEnabledKey = "NotificationsEnabled";

		#region 2ndWay
		//Notice that we only have ONE Event handler for TWO handles
		//void OnChange(object sender, Xamarin.Forms.ToggledEventArgs e)
        //{
            #region 1stWay
            //Application.Current.Properties[TitleKey] = title.Text;
            //This is for EntryCell

            //Application.Current.Properties[NotificationsEnabledKey] = notifacationsEnabled.On;
            //This is for the switchCell

            //Application.Current.SavePropertiesAsync();
            //This will save the current Properties BEFORE it goes into sleepmode.
            //Usually, Properties get updated after the app goes into sleepmode.
            //This is best for "Transient Data" or Long Text (i.e. Email, Notes, Messages)
            #endregion

           
            //var app = Application.Current as App;
            //app.Title = title.Text;
            //app.NotificationsEnabled = notifacationsEnabled.On;

        //}
		#endregion
		public ApplicationPropertiesXaml()
        {
            InitializeComponent();

            #region 1stWay
            //if (Application.Current.Properties.ContainsKey(TitleKey))

            //title.Text = Application.Current.Properties[TitleKey].ToString();
            //This Property, "Name", returns an object so...
            //we need to include ToString

            //if (Application.Current.Properties.ContainsKey(NotificationsEnabledKey))
            //notifacationsEnabled.On = (bool)Application.Current.Properties[NotificationsEnabledKey];
            #endregion

            #region 2ndWay
            //This is the refactored code
            //var app = Application.Current as App;
            //title.Text = app.Title;
            //notifacationsEnabled.On = app.NotificationsEnabled;
            #endregion

            //This object is now the SOURCE of the data binding
            //Since we have a {Binding Title} and {Binding NotificationsEnabled}
            //THUS, we no longer need the EventHandlers: Data Binding will do all the syncronization
            BindingContext = Application.Current;
        }
    }
}
