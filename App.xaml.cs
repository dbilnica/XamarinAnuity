using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Anuita
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage mainPage= new MainPage();
            mainPage.BindingContext = new ViewModel();
            MainPage = mainPage;
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
