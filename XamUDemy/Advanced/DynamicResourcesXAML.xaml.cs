using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Advanced
{
    public partial class DynamicResourcesXAML : ContentPage
    {

        public DynamicResourcesXAML()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Resources["buttonBackgroundColor"] = Color.HotPink;
        }
    }
}
