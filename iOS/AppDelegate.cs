using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using ImageCircle.Forms.Plugin.iOS;
using UIKit;

namespace XamUDemy.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            //This line kicks off Xamarin.Forms
            global::Xamarin.Forms.Forms.Init();

            //This line kicks off the ImageCircle Renderer
            ImageCircleRenderer.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
