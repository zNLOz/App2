﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
        }

        private async void BtnBack(object Btn, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}