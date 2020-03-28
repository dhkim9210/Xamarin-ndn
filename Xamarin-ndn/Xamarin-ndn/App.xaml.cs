using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_ndn.Services;
using Xamarin_ndn.Views;

namespace Xamarin_ndn
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
