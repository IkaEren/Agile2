using System;
using System.ComponentModel.DataAnnotations;

namespace AgileData
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Facility Facility { get; set; }

        [Required]
        public DateTime BookingTime { get; set; }

        [Required]
        public Transaction Transaction { get; set; }
    }
}
