using System;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;

namespace XamUDemy.Models
{
    public class SearchGroup : ObservableCollection<Search>
    {
        public string Title { get; set; }

        public SearchGroup(string title, IEnumerable<Search> searches = null)
            :base(searches)
        {
            Title = Title;
        }
    }
}

