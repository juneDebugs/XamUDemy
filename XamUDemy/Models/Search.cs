﻿using System;

using Xamarin.Forms;
using System.Diagnostics.Contracts;

namespace XamUDemy.Models
{
    public class Search
    {
        public int Id { get; set; }
        public string Locaation { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string Period
        {
            get
            {
                return String.Format("{0}-{1}",
                    CheckIn.ToString("MMM d, yyyy"),
                    CheckOut.ToString("MMM d, yyyy"));
            }

        }

    }
}

