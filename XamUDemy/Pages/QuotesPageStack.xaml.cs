using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamUDemy.Pages
{
    public partial class QuotesPageStack : ContentPage
    {
        private int _index = 0;
        private string[] _quotes = new string[]
        {
            "Do More",
            "Never Quit",
            "I'm Hungry"
        };

        public QuotesPageStack()
        {
            InitializeComponent();
            currentQuote.Text = _quotes[_index];
        }

		void Handle_Clicked(object sender, System.EventArgs e)
		{
            _index++;
            if (_index >= _quotes.Length)
                _index = 0;

            currentQuote.Text = _quotes[_index];
		}
    }
}
