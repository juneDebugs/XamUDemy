using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Runtime.InteropServices.WindowsRuntime;

namespace XamUDemy.MarkupExtensions
{
    [ContentProperty("ResourceID")]

    public class EmbeddedImage : IMarkupExtension
    {
        public string ResourceID { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrWhiteSpace(ResourceID))
                return null;

            return ImageSource.FromResource(ResourceID);
        }
    }
}
