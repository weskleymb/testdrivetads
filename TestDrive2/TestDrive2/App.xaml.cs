﻿using TestDrive2.Views;
using Xamarin.Forms;

namespace TestDrive2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Listagem());
            MainPage = new MestreDetalhe();
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
    }
}
