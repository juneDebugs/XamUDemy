using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;


namespace XamUDemy.FormsAndSettingPages
{
    public class ContactMethod
    {
		public int Id { get; set; }
        public string Name { get; set; }      
    }


    public partial class PickerPageXaml : ContentPage
    {
        private IList<ContactMethod> _contactMethods;
        //Created this PRIVATE Field so that we don't have to call this METHOD Twice
        
        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var name = contactMethods.Items[contactMethods.SelectedIndex];
            _contactMethods.Single(cm => cm.Name == name);

            DisplayAlert("Selection", name, "OK");
        }

        public PickerPageXaml()
        {
            InitializeComponent();

            _contactMethods = GetContactMethods();

            //foreach (var method in _contactMethods)
                //picker.Items.Add(method.Name);
        }

        // This is where you point your Database to for DATA
        //Here we are just hardcoding it in
        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod {Id= 1, Name= "SMS"},
                new ContactMethod {Id= 2, Name= "Email"}
            };
        }
    }
}
