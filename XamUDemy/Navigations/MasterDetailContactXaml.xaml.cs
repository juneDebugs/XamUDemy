using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamUDemy.Models;

namespace XamUDemy.Navigations
{
    public partial class MasterDetailContactXaml : ContentPage
    {
        //Async and Await for SelectedItem
        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var contact = e.SelectedItem as Contact;

            await Navigation.PushAsync(new MasterDetailXaml(contact));
            listView.SelectedItem = null;
        }

        public MasterDetailContactXaml()
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
