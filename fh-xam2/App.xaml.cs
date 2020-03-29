using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using fh_xam2.Services;
using fh_xam2.Views;

namespace fh_xam2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
