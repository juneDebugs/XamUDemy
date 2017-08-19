using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Net.Http;

namespace XamUDemy.Pages
{
    public partial class PhotoGalleryPage : ContentPage
    {
        private int _currentImagedId = 1;

        public PhotoGalleryPage()
        {
            InitializeComponent();

            _currentImagedId = 1;

            LoadImage();
        }

        void LoadImage()
        {
            image.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorepixel.com/1920/1080/city/{0}", _currentImagedId)),
                CachingEnabled = false
            };
        }





    }
}
