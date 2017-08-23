// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace XamUDemy.Helpers
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters. 
	/// </summary>
	public static class Settings
	{
        
		private static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

        //public static Settings Instance{

        //    get{
        //        return _instance;
        //    }

        //}

		#region Setting Constants

		private const string SettingsKey = "settings_key";
		private static readonly string SettingsDefault = string.Empty;

		#endregion


		public static string GeneralSettings
		{
			get
			{
				return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
			}
			set
			{
				AppSettings.AddOrUpdateValue(SettingsKey, value);
			}
		}

        public static string TitleKey = nameof(TitleKey);
		public static string Title
		{
			get
			{
                return AppSettings.GetValueOrDefault(TitleKey, "");			
			}

			set
			{
				AppSettings.AddOrUpdateValue(TitleKey,value);
			}
		}


        public static string NotificationsEnabledKey = nameof(NotificationsEnabledKey);
		public static bool NotificationsEnabled 
		{
			get
			{
                return AppSettings.GetValueOrDefault(NotificationsEnabledKey, false);
			}

			set
			{
                AppSettings.AddOrUpdateValue(NotificationsEnabledKey, value);
			}

		}



	}
}