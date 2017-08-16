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

            var layout = new Xamarin.Forms.AbsoluteLayout();

            var aquaBox = new BoxView { Color = Color.Aqua };
            layout.Children.Add(aquaBox,
                                new Rectangle(0, 0, 1, 1),
                                AbsoluteLayoutFlags.All);

            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0, 0, 1, 1));
            Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(aquaBox, AbsoluteLayoutFlags.HeightProportional);

            Content = layout;
        }
    }
}
