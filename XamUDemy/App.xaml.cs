﻿using Xamarin.Forms;
using XamUDemy.Pages;
using XamUDemy.Layouts;
using XamUDemy.Lists;
using XamUDemy.Navigations;
using XamUDemy.DataAccess;

namespace XamUDemy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ApplicationPropertiesXaml();

            //new NavigationPage(new MasterDetailContactXaml());

            //MainPage = new NavigationPage(new HierarchicalNavigationFirstPage())
            //{
            //    BarBackgroundColor = Color.Aqua,
            //    BarTextColor = Color.Black
            //};
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
