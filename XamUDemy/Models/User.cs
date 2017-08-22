using System;

using Xamarin.Forms;

namespace XamUDemy.Models
{
    public class User 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string ImageUrl
        {
            get { return $"http://lorempixel.com/200/200/people/{Id}"; }
        }
    }
}

