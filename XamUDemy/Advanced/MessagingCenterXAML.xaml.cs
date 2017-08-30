using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Advanced
{
    public partial class MessagingCenterXAML : ContentPage
    {
        public MessagingCenterXAML()
        {
            InitializeComponent();
        }

        void OnClick(object sender, System.EventArgs e)
        {
            var page = new TargetPageXAML();
            page.SliderValueChanged += OnSliderValueChanged;
            Navigation.PushAsync(page);
        }

        private void OnSliderValueChanged(object source, double newValue)
        {
            label.Text = newValue.ToString();
        }
    }
}
