using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestScheduler
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mzc0MjI2QDMxMzgyZTM0MmUzMEViRUYwRFhTRzlNN0xhVVBRZkF3ekFTOUkvSkZya2NVVWhGS1dUUXpNbGs9;Mzc0MjI3QDMxMzgyZTM0MmUzMEJRdG55cVVneE9DN2Yya3BRanI3Y2ZUUU5oVkwrWTdyVWFiVHZPZlAxaUk9");

            InitializeComponent();

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
