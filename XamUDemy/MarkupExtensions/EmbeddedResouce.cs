using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace XamUDemy
{
    [ContentProperty("ResouceID")]
    public class EmbeddedResouce : IMarkupExtension
    {
        public string ResourceID { get; private set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ResourceID))
                return null;
            
            return ImageSource.FromResource(ResourceID);
        }
    }
}
