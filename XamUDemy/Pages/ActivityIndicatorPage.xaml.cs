using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Pages
{
    public partial class ActivityIndicatorPage : ContentPage
    {
        public ActivityIndicatorPage()
        {
            InitializeComponent();
			//Dirty Way
			//var imageSource= (UriImageSource) ImageSource.FromUri(new Uri("http://..."));

			//Cleaner Way
			var imageSource = new UriImageSource { Uri = new Uri("hhttp://lorempixel.com/1920/1080/sports/7/") };


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
            image.Source = "http://lorempixel.com/1920/1080/sports/7/";

            //ActivityIndicator.BindingContext = image;
            //ActivityIndicator.SetBinding(ActivityIndicator.IsVisibleProperty, nameof(image.IsLoading));
            //ActivityIndicator.SetBinding(ActivityIndicator.IsRunningProperty, nameof(image.IsLoading));
        }
    }
}
