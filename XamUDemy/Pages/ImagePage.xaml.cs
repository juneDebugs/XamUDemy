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
			//Dirty Way
			//var imageSource= (UriImageSource) ImageSource.FromUri(new Uri("http://..."));

			//Cleaner Way
			var imageSource = new UriImageSource { Uri = new Uri("http://...") };


            //ImageSource Properties

            //CachingEnabled is a Bool 
            //Default is automatically enabled
            //Need to set this to false if you want to dynamically change images
            imageSource.CachingEnabled = false;

            //CacheValidity sets how long the cache is valid
            //Default is 24hours
            //This is how to change the time-span
            imageSource.CacheValidity = TimeSpan.FromHours(1);
            //This is 1hr timeSpan

            //Setting imageSource to image.Source object 
            image.Source = imageSource;
            image.Source = "http://...";
        }
    }
}
