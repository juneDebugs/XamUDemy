using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamUDemy.Models;
using System.Collections.ObjectModel;

namespace XamUDemy.Lists
{
    public partial class ListViewXamlContextActions : ContentPage
    {
        //ObervableCollection has the delete capablity built-in
        private ObservableCollection<Contact> _contacts;

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        void Call_Clicked(object sender, System.EventArgs e)
        {
            //These are Event Handlers
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        public ListViewXamlContextActions()
        {
            InitializeComponent();

			//listView.ItemsSource = new List<Contact>{
            _contacts = new ObservableCollection<Contact>{
                new Contact { Name = "Eminem", ImageURL = "http://lorempixel.com/100/100/people/1"},
                new Contact { Name = "Jordan", ImageURL = "http://lorempixel.com/100/100/people/2",
                    Status= "Hey, let's talk!"},
            };

            listView.ItemsSource = _contacts;
        }
    }
}