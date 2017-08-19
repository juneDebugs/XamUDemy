using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamUDemy.Models;

namespace XamUDemy.Lists
{
    public partial class ListViewXAML : ContentPage
    {
        public ListViewXAML()
        {
            InitializeComponent();

            //This is how you hard code a listView 
            //var names = new List<string>
            //{
            //    "Eminem",
            //    "Jimmy",
            //    "Dr. Dre"
            //};

            //listView.ItemsSource = names;

            listView.ItemsSource = new List<Contact>{
                new Contact { Name = "Eminem", ImageURL = "http://lorempixel.com/100/100/people/1"},
                new Contact { Name = "Jordan", ImageURL = "http://lorempixel.com/100/100/people/2",
                    Status= "Hey, let's talk!"},
            };


        }
    }
}
