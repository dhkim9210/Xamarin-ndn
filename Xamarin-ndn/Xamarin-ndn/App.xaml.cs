using System;
using Xamarin;
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
            //mainpage를 navigationpage로 지정
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
