using System;
using System.Collections.Generic;

using Xamarin.Forms;

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
		public ConsumingRESTful()
		{
			InitializeComponent();
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
