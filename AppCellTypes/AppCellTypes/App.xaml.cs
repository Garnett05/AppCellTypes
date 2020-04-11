using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCellTypes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Master.MasterPage();
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
