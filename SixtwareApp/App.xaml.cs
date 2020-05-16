using SixtwareApp.Clases;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SixtwareApp
{
    public partial class App : Application
    {
        public App()
        {
           Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjU3ODU2QDMxMzgyZTMxMmUzMEpXZUgweWRmeGdhbWk1UlQwUHBncG0vMVFOQ0thcHBGT0x2QTJrNmdveU09");
            InitializeComponent();
            

            MainPage = new NavigationPage(new Login());
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
