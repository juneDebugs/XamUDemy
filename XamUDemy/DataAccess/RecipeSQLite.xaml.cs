using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamUDemy.Interface;
using SQLite;

namespace XamUDemy.DataAccess
{
    public class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }
    }

    public partial class RecipeSQLite : ContentPage
    {
        public RecipeSQLite()
        {
            InitializeComponent();

            var connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            connection.CreateTableAsync<Recipe>();
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
