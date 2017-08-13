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
        }

		//void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		//{
  //          label.Text = String.Format("Value is {0:F2}", e.NewValue);
		//}
    }
}
