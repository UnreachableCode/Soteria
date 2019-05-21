using System.ComponentModel.DataAnnotations;

namespace Soteria.Models
{
    public class TimeSheetEntry
    {
        [Required]
        public string ID { get; set; }

        [Required]
        public string Day { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string Start { get; set; }

        [Required]
        public string Finish { get; set; }

        public int Hours { get; set; }

        [Required]
        public string JobLocation { get; set; }

        [Required]
        public string JobNumber { get; set; }
    }
}
