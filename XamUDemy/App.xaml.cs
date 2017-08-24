using Xamarin.Forms;
using XamUDemy.Pages;
using XamUDemy.Layouts;
using XamUDemy.Lists;
using XamUDemy.Navigations;
using XamUDemy.DataAccess;
using XamUDemy.FormsAndSettingPages;

namespace XamUDemy
{
    public partial class App : Application
    {
		private const string TitleKey = "Name";
        private const string NotificationsEnabledKey = "NotificationsEnabled";

        public App()
        {
            InitializeComponent();

            MainPage = new TableViewXaml();

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

        //This exposes the Properties of the Application Settings
        //See ApplicationProperties
        public string Title
        {
            get
            {
                if (Properties.ContainsKey(TitleKey))
                    return Properties[TitleKey].ToString();

                return "";
            }

            set
            {
                Properties[TitleKey] = value;
            }
        }

        public bool NotificationsEnabled
        {
            get
            {
                if (Properties.ContainsKey(NotificationsEnabledKey))
                    return (bool)Properties[NotificationsEnabledKey];

                return false;
            }

            set
            {
                Properties[NotificationsEnabledKey] = value;   
            }

        }

    }
}
