using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Reflection;
using XamUDemy.Models;

namespace XamUDemy.Services
{
    public class SearchService
    {
        private List<Search> _searches = new List<Search>
        {
            new Search
            {
              Id = 1,
                Location = "West Hollywood, CA, United States",
                CheckIn = new DateTime(2017, 1, 8),
                CheckOut= new DateTime(2017, 7, 8)
            },

			new Search
			{
			  Id = 2,
				Location = "Santa Monica, CA, United States",
				CheckIn = new DateTime(2017, 1, 8),
				CheckOut= new DateTime(2017, 7, 8)
			},

        };




    }
}

