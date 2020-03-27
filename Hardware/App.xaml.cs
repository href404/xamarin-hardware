﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Hardware.Views;

namespace Hardware
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new AppInfoView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
