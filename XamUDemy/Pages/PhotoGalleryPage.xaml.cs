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
                Uri = new Uri(String.Format("http://google.com/{0}", _currentImagedId)),
                CachingEnabled = false
            };
        }

        void Previous_Clicked(object sender, System.EventArgs e)
        {
            _currentImagedId--;
            if
                (_currentImagedId == 0)
                _currentImagedId = 10;

            LoadImage();
        }

        void Next_Clicked(object sender, System.EventArgs e)
        {
            _currentImagedId++;
            if
                (_currentImagedId == 11)
                _currentImagedId = 1;

            LoadImage();
        }
    }
}
