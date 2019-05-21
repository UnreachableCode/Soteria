namespace Soteria.Models
{
    public class TimeSheetEntryInfo
    {
        public string Id { get; set; }
        public string Day { get; set; }
        public string Date { get; set; }
        public string Start { get; set; }
        public string Finish { get; set; }
        public string Break { get; set; }
        public int Hours { get; set; }


        public string JobLocation { get; set; }
        public string JobNumber { get; set; }
    }
}
