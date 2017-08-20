using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Reflection;
using XamUDemy.Models;
using System.Linq;

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

        public IEnumerable<Search> GetRecentSearches(string filter = null)
        {
            if (String.IsNullOrWhiteSpace(filter))
                return _searches;

            return _searches.Where(x => x.Location.StartsWith(filter, StringComparison.CurrentCultureIgnoreCase));
        }

        public void DeleteSearch(int searchId)
        {
            _searches.Remove(_searches.Single(x => x.Id == searchId));
        }

    }
}

