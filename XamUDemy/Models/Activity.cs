using System;
using Xamarin.Forms;

namespace XamUDemy.Models
{
    public class Activity 
    {
		public int UserId { get; set; }
		public string Description { get; set; }

		public string ImageUrl
		{
			get { return $"http://lorempixel.com/100/100/people/{UserId}"; }
		}

    }
}

