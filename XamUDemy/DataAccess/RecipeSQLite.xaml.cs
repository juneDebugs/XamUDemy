using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamUDemy.Interface;
using SQLite;
using System.Collections.ObjectModel;

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
        private SQLiteAsyncConnection _connection;
        public ObservableCollection<Recipe> _recipes;

        public RecipeSQLite()
        {
            InitializeComponent();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected override async void OnAppearing()
        {
			await _connection.CreateTableAsync<Recipe>();
			
			var recipes= await _connection.Table<Recipe>().ToListAsync();
            _recipes = new ObservableCollection<Recipe>(recipes);
            recipesListView.ItemsSource = recipes;

            base.OnAppearing();
        }

		async void OnAdd(object sender, System.EventArgs e)
		{
            var recipe = new Recipe { Name = "Recipe" + DateTime.Now.Ticks };
            await _connection.InsertAsync(recipe);
		}

        void OnUpdate(object sender, System.EventArgs e)
        {
            
        }

        void OnDelete(object sender, System.EventArgs e)
        {
            
        }
    }
}
