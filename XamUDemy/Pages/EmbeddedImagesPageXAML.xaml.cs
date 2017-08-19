using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Pages
{
    public partial class EmbeddedImagesPageXAML : ContentPage
    {
        public EmbeddedImagesPageXAML()
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource("XamUDemy.Images.jordan.png");
        }
    }
}
