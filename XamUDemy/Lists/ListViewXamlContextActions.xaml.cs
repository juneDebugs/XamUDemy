using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamUDemy.Models;

namespace XamUDemy.Lists
{
    public partial class ListViewXamlContextActions : ContentPage
    {
		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			//This is how you disable Selections
			listView.SelectedItem = null;

			//var contact = e.SelectedItem as Contact;
			//DisplayAlert("Selected", contact.Name, "OK");
		}

		void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var contact = e.Item as Contact;
			DisplayAlert("Tapped", contact.Name, "OK");
		}

        public ListViewXamlContextActions()
		{
			InitializeComponent();

			listView.ItemsSource = new List<Contact>{
				new Contact { Name = "Eminem", ImageURL = "http://lorempixel.com/100/100/people/1"},
				new Contact { Name = "Jordan", ImageURL = "http://lorempixel.com/100/100/people/2",
					Status= "Hey, let's talk!"},
			};

		}
	}
}