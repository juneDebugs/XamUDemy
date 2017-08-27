using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.DataAccess
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public partial class RecipeSQLite : ContentPage
    {
        public RecipeSQLite()
        {
            InitializeComponent();
        }

		void OnAdd(object sender, System.EventArgs e)
		{
			
		}

        void OnUpdate(object sender, System.EventArgs e)
        {
            
        }

        void OnDelete(object sender, System.EventArgs e)
        {
            
        }
    }
}
