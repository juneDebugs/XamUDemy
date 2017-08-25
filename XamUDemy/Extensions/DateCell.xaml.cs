using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Extensions
{
    public partial class DateCell : ViewCell
    {
        //This is called Bindable Infrastructure for Xamarin.Forms
        public static readonly BindableProperty LabelProperty =
            BindableProperty.Create("Label", typeof(string), typeof(DateCell));

        public string Label 
        { 
            get
            {
                return (string)GetValue(LabelProperty);
            }

            set
            {
                SetValue(LabelProperty, value);
            }
        }

        public DateCell()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}
