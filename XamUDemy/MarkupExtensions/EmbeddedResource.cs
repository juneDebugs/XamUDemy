using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace XamUDemy
{
    //[ContentProperty("ResourceID")]
    public class EmbeddedResource : IMarkupExtension
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
