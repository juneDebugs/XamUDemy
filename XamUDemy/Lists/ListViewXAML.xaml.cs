using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Lists
{
    public partial class ListViewXAML : ContentPage
    {
        public ListViewXAML()
        {
            InitializeComponent();

            var names = new List<string>
            {
                "Eminem",
                "Jimmy",
                "Dr. Dre"
            };


        }
    }
}
