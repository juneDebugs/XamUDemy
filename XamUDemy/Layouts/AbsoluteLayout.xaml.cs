using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Layouts
{
    public partial class AbsoluteLayout : ContentPage
    {
        public AbsoluteLayout()
        {
            InitializeComponent();

            var layout = new AbsoluteLayout();
            Content = layout;

            var aquaBox = new BoxView { Color = Color.Aqua };
            layout.Children.Add(aquaBox,
                                new Rectangle(0, 0, 1, 1),
                                AbsoluteLayoutFlags.All);

            AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(aquaBox, AbsoluteLayoutFlags.HeightProportional);
        }
    }
}
