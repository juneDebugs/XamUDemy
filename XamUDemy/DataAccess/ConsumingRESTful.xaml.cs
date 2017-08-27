using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace XamUDemy.DataAccess
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public partial class ConsumingRESTful : ContentPage
    {
        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        //To consumer RESTful (web) services we need to create a new INSTANCE of HttpClient 
        private HttpClient _client = new HttpClient();

        private ObservableCollection<Post> _posts;

		public ConsumingRESTful()
		{
			InitializeComponent();
		}

        protected override async void OnAppearing()
        {
            //Here we are sending a GET request to this endpoint to get the LIST of ALL POSTS
            var content= await _client.GetStringAsync(Url);

            //Deserialize the string
            var posts = JsonConvert.DeserializeObject<List<Post>>(content);

            //Intialize ObservableCollection
            _posts = new ObservableCollection<Post>(posts);
            postsListVIew.ItemSource = _posts;

            base.OnAppearing();
        }

        void OnDelete(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        void OnUpdate(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        void OnAdd(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
