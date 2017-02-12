using System.ComponentModel.DataAnnotations;

namespace AgileData
{
    public class Facility
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Venue Venue { get; set; }

        [Required]
        public decimal PeakRate { get; set; }
        [Required]
        public decimal NonPeakRate { get; set; }

        public Activity Activity { get; set; }

    }
}
