using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamUDemy.MarkupExtensions
{
    public class EmbeddedImage : IMarkupExtension
    {
        public string ResourceID { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return ImageSource.FromResource(ResourceID);
        }
    }
}
