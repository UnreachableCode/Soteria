using System.Collections.ObjectModel;
using Soteria.Models;

namespace Soteria.Repositories
{
    public class TimeSheetInfoRepository
    {
        private ObservableCollection<TimeSheetInfo> timeSheetInfoCollection;
        public ObservableCollection<TimeSheetInfo> TimeSheetInfoCollection
        {
            get { return timeSheetInfoCollection; }
            set { this.timeSheetInfoCollection = value; }
        }

        public TimeSheetInfoRepository()
        {
            timeSheetInfoCollection = new ObservableCollection<TimeSheetInfo>();
            this.GenerateTimeSheets();
        }

        private void GenerateTimeSheets()
        {
            timeSheetInfoCollection.Add(new TimeSheetInfo() { Id= "1001", JobLocation= "HV - Adrian Barrett" });
            timeSheetInfoCollection.Add(new TimeSheetInfo() { Id = "1002", JobLocation = "LV - Scott Mills" });
            timeSheetInfoCollection.Add(new TimeSheetInfo() { Id = "1003", JobLocation = "LV - Kevin McLaughlin" });
            timeSheetInfoCollection.Add(new TimeSheetInfo() { Id = "1004", JobLocation = "LV - Chris Mac" });
        }
    }
}
