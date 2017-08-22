using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamUDemy.Models;

namespace XamUDemy.Navigations
{
    public partial class MasterContactPageXaml : ContentPage
    {
        //Async and Await for SelectedItem
        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new MasterDetailPageXaml(contact));

            listView.SelectedItem = null;
        }

        public MasterContactPageXaml()
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
