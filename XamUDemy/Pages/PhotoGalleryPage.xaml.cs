using System;
using System.Collections.Generic;

using Xamarin.Forms;

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







    }
}
