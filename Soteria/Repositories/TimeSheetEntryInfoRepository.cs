using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Soteria.Models;

namespace Soteria.Repositories
{
    public class TimeSheetEntryInfoRepository
    {
        private ObservableCollection<TimeSheetEntryInfo> timeSheetInfoCollection;
        public ObservableCollection<TimeSheetEntryInfo> TimeSheetEntryInfoCollection
        {
            get { return timeSheetInfoCollection; }
            set { this.timeSheetInfoCollection = value; }
        }

        public List<string> WorkingHours
        {
            get
            {
                return new List<string>
                {
                    "09:00",
                    "10:00",
                    "11:00",
                    "12:00",
                    "13:00",
                    "14:00",
                    "15:00",
                    "16:00",
                    "17:00"
                };
            }
        }

        public TimeSheetEntryInfoRepository()
        {
            timeSheetInfoCollection = new ObservableCollection<TimeSheetEntryInfo>();
            this.GenerateTimeSheets();
        }

        private void GenerateTimeSheets()
        {
            timeSheetInfoCollection.Add(new TimeSheetEntryInfo() { Id= "1001", Day = "Saturday", Date = "04 May 2019", Start = "09:00", Finish = "17:00" });
            timeSheetInfoCollection.Add(new TimeSheetEntryInfo() { Id = "1002", Day = "Sunday", Date = "05 May 2019", Start = "09:00", Finish = "17:00" });
            timeSheetInfoCollection.Add(new TimeSheetEntryInfo() { Id = "1003", Day = "Monday", Date = "06 May 2019", Start = "09:00", Finish = "17:00" });
            timeSheetInfoCollection.Add(new TimeSheetEntryInfo() { Id = "1004", Day = "Tuesday", Date = "07 May 2019", Start = "09:00" });
            timeSheetInfoCollection.Add(new TimeSheetEntryInfo() { Id = "1005", Day = "Wednesday", Date = "08 May 2019" });
            timeSheetInfoCollection.Add(new TimeSheetEntryInfo() { Id = "1006", Day = "Thursday", Date = "09 May 2019" });
            timeSheetInfoCollection.Add(new TimeSheetEntryInfo() { Id = "1007", Day = "Friday", Date = "10 May 2019" });
        }

        public static IEnumerable<DateTime> Daily(DayOfWeek startDayOfWeek = DayOfWeek.Saturday, DateTime? checkDay = null)
        {
            var computerDate = checkDay ?? DateTime.UtcNow;
            var days = startDayOfWeek - computerDate.DayOfWeek;
            var startDate = computerDate.AddDays(days);

            for (var i = 0; i < 7; i++)
            {
                yield return startDate.AddDays(i).Date;
            }
        }
    }
}
