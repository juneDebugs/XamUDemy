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

            var label = new Label { Text = "Label 1" };
            grid.Children.Add(label, 0, 0);
            Grid.SetRowSpan(label, 2);
            Grid.SetColumnSpan(label, 2);

            //Not used that often
            Grid.SetRow(label, 0);
            Grid.SetColumn(label, 0);

        }
    }
}
