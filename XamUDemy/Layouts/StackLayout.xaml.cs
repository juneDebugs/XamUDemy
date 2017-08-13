using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Layouts
{
    public partial class StackLayout : ContentPage
    {
        
        public StackLayout()
        {
            InitializeComponent();

            slider.Value = 0.5;

            if (Device.OS == TargetPlatform.iOS)
                //Thickness= Left, Top, Right, Bottom
                Padding = new Thickness(0, 20, 0, 0);
            else if (Device.OS == TargetPlatform.Android)
                Padding = new Thickness(10, 20, 0, 0);

            Padding = Device.OnPlatform(
                iOS: new Thickness(0,20,0,0),
                Android: new Thickness(10,20,0,0)
            );
        }
        //No more need for event handler because of Binding Context

		//void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		//{
        //  label.Text = String.Format("Value is {0:F2}", e.NewValue);
		//}
    }
}
