using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Pages
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //Cleaner Way
            var imageSource = new UriImageSource { Uri = new Uri("http://...") };

            //DirtyWay
            //var imageSource= (UriImageSource) ImageSource.FromUri(new Uri("http://..."));

            //ImageSource Properties

            //CachingEnabled is a Bool and is automatically enabled
            imageSource.CachingEnabled = false;



        }
    }
}
