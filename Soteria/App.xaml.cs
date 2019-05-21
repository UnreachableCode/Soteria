using System;
using Soteria.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Soteria
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("OTU3NzdAMzEzNzJlMzEyZTMwRmdGZVpMdmphWTVOb1oySGpyeVhIeUQ5eUR5elA4QVY4SjR5aGo1WmVuOD0=");

            var timeSheetEntryPage = new TimeSheetEntryPage();
            var navigationPage = new NavigationPage(timeSheetEntryPage)
            {
                BarBackgroundColor = Color.FromRgb(48, 46, 49)
            };

            NavigationPage.SetTitleIcon(timeSheetEntryPage, "customerLogo.png");
            MainPage = new MainTabbedPage();
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
