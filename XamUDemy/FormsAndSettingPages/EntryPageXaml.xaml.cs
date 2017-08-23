using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.FormsAndSettingPages
{
    public partial class EntryPageXaml : ContentPage
    {
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            label.Text = e.NewTextValue;
        }

		//This is how to link the event handler to the label
		//void Handle_Completed(object sender, System.EventArgs e)
		//{
		//    label.Text = "Done";
		//}

		public EntryPageXaml()
        {
            InitializeComponent();
        }
    }
}
