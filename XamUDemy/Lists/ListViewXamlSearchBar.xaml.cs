using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamUDemy.Models;
using System.Linq;

namespace XamUDemy.Lists
{
    public partial class ListViewXamlSearchBar : ContentPage
    {
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }

        // List<Contact> GetContacts(string searchText= null)
        //IEnumerable is the dataType for Item Source

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>
            {
                new Contact { Name = "Eminem", ImageURL = "http://lorempixel.com/100/100/people/1"},
                new Contact { Name = "Jordan", ImageURL = "http://lorempixel.com/100/100/people/2",
                    Status= "Hey, let's talk!"},
            };

            //Search is Empty or WhiteSpace then return All Contacts
            if (string.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(x => x.Name.StartsWith(searchText));
        }

        public ListViewXamlSearchBar()
        {
            InitializeComponent();

            listView.ItemsSource = GetContacts();
        }
    }
}
