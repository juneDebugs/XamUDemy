using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamUDemy.Interface;
using SQLite;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.CompilerServices;

namespace XamUDemy.DataAccess
{
    //The INotifyProperyChanged sends message to the subscriber (this case listView)
    //Then listView implements changes (i.e. UPDATE in this case)
    //ObservableCollection has INotifyPropertyChanged interface built-in
    public class Recipe : INotifyPropertyChanged
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        private string _name;

        [MaxLength(255)]
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (_name == value)
                    return;

                _name = value;

                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public partial class RecipeSQLite : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Recipe> _recipes;

        public RecipeSQLite()
        {
            InitializeComponent();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<Recipe>();

            var recipes = await _connection.Table<Recipe>().ToListAsync();
            _recipes = new ObservableCollection<Recipe>(recipes);
            recipesListView.ItemsSource = _recipes;

            base.OnAppearing();
        }

        async void OnAdd(object sender, System.EventArgs e)
        {
            var recipe = new Recipe { Name = "Recipe" + DateTime.Now.Ticks };
            await _connection.InsertAsync(recipe);

            _recipes.Add(recipe);
        }

        async void OnUpdate(object sender, System.EventArgs e)
        {
            var recipe = _recipes[0];
            recipe.Name += "UPDATED";

            await _connection.UpdateAsync(recipe);
        }

        async void OnDelete(object sender, System.EventArgs e)
        {
            var recipe = _recipes[0];

            await _connection.DeleteAsync(recipe);

            _recipes.Remove(recipe);
        }
    }
}
