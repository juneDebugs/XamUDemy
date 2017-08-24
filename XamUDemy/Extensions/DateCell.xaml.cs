using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Extensions
{
    public partial class DateCell : ViewCell
    {
        public string Label { get; set; }

        public DateCell()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}
