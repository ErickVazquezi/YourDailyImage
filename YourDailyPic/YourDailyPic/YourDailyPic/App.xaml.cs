using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YourDailyPic.Services;
using YourDailyPic.Views;
using PexelsDotNetSDK.Api;
using PexelsDotNetSDK.Models;

namespace YourDailyPic
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
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
