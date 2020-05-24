using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RTM_FRONT_END.Services;
using RTM_FRONT_END.Views;

namespace RTM_FRONT_END
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
