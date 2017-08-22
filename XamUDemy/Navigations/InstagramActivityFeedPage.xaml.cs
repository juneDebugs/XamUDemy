using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Navigations
{
    public partial class InstagramActivityFeedPage : ContentPage
    {
        private ActivityService _service = new ActivityService();


        public InstagramActivityFeedPage()
        {
            InitializeComponent();

            activityFeed.ItemsSource = _service.GetActivities();
        }

        void OnActivitySelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {


        }


    }
}
