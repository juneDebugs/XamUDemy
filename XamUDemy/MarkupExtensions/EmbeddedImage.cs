using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamUDemy.MarkupExtensions
{
    public class EmbeddedImage : IMarkupExtension
    {
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return ImageSource.FromResource("XamUDemy.Images.jordan.png");
        }
    }
}
