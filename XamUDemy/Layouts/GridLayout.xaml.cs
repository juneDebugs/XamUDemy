using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Layouts
{
    public partial class GridLayout : ContentPage
    {
        public GridLayout()
        {
            InitializeComponent();

            var grid = new Grid
            {
                RowSpacing = 20,
                ColumnSpacing = 40
            };

            grid.Children.Add(new Label { Text = "Label 1" }, 0, 0);
            Grid.SetRowSpan();


        }
    }
}
