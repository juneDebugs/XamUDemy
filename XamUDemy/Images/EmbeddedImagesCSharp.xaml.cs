using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy
{
    public partial class EmbeddedImagesCSharp : ContentPage
    {
        public EmbeddedImagesCSharp()
        {
            InitializeComponent();

            //EmbeddedImaged in C#
            image.Source = ImageSource.FromResource("XamUDemy.Images.jordan.png");
        }
    }
}
