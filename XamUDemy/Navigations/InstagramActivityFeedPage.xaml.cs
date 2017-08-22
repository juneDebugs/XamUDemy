using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamUDemy.Models;
using XamUDemy.Services;

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
            if (e.SelectedItem == null)
                return;

            var activity = e.SelectedItem as Activity;

            activityFeed.SelectedItem = null;

            Navigation.PushAsync(new InstagramUserProfilePage(activity.UserId));
        }
    }
}
