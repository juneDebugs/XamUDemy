using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
namespace XamUDemy
{
    public class EmbeddedResouce : IMarkupExtension
    {
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return ImageSource.FromResource(ResourceID);
        }


    }
}
