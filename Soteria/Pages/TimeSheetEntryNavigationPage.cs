using System;

using Xamarin.Forms;

namespace Soteria.Pages
{
    public class TimeSheetEntryNavigationPage : NavigationPage
    {
        public TimeSheetEntryNavigationPage()
        {
            var timeSheetEntryPage = new TimeSheetEntryPage();
            SetTitleIcon(timeSheetEntryPage, "customerLogo.png");
            page = timeSheetEntryPage;
        }
    }
}

