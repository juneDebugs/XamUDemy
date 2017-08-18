using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy
{
    public partial class EmbeddedImages : ContentPage
    {
        public EmbeddedImages()
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource("XamUDemy.ResourceImages.jordan.png");
        }
    }
}
