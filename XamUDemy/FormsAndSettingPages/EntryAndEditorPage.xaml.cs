using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.FormsAndSettingPages
{
    public partial class EntryAndEditorPage : ContentPage
    {
        void Handle_Completed(object sender, System.EventArgs e)
        {
            label.Text = "Done";
        }

        public EntryAndEditorPage()
        {
            InitializeComponent();
        }
    }
}
