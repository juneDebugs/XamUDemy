using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.FormsAndSettingPages
{
    public partial class SwitchPageXaml : ContentPage
    {
        #region Don't need EventHandler since we are BINDING
        //void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        //{
        //    label.IsVisible = e.Value;
        //}
        #endregion
        public SwitchPageXaml()
        {
            InitializeComponent();

            BindingContext = Application.Current;
        }
    }
}
