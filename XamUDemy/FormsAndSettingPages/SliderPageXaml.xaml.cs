using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.FormsAndSettingPages
{
    public partial class SliderPageXaml : ContentPage
    {
        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            //Two Properties
            //1) e.OldValue
            //2) e.NewValue
        }

        public SliderPageXaml()
        {
            InitializeComponent();
        }
    }
}
