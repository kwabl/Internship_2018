﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyBookTry
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewPageBookTry : ContentPage
	{
		public NewPageBookTry ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "We have handled the click event", "Great!");
        }
    }
}