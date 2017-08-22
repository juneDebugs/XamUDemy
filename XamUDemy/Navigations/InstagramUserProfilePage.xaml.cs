using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamUDemy.Services;

namespace XamUDemy.Navigations
{
    public partial class InstagramUserProfilePage : ContentPage
    {
        private UserService _service = new UserService();

        public InstagramUserProfilePage(int userId)
        {
            BindingContext = _service.GetUser(userId);

            InitializeComponent();
        }
    }
}
