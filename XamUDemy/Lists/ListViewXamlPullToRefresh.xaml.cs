using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamUDemy.Models;

namespace XamUDemy.Lists
{
    public partial class ListViewXamlPullToRefresh : ContentPage
    {
        List<Contact> GetContacts()
        {
            //RealWorld: This is where we would call for a remote service
            //This demo has just a hard-coded string
            return new List<Contact> 
            {
                new Contact { Name = "Eminem", ImageURL = "http://lorempixel.com/100/100/people/1"},
                new Contact { Name = "Jordan", ImageURL = "http://lorempixel.com/100/100/people/2",
                    Status= "Hey, let's talk!"},
            };
        }


        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            listView.ItemsSource = GetContacts();

            listView.EndRefresh();
        }

        public ListViewXamlPullToRefresh()
        {
            InitializeComponent();
            {
                listView.ItemsSource = GetContacts();
            };
        }
    }
}
