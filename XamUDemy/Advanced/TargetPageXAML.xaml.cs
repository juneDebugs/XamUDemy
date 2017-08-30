using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Advanced
{
    public partial class TargetPageXAML : ContentPage
    {
        public event EventHandler<double> SliderValueChanged;

        public TargetPageXAML()
        {
            InitializeComponent();
        }

        void Handle_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            MessagingCenter.Send(this, "SliderValueChanged", e.NewValue);

            //SliderValueChanged?.Invoke(this, e.NewValue);
        }
    }
}
