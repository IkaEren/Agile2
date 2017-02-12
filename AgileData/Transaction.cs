using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileData
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Member Booker { get; set; }

        [Required]
        public List<Booking> Bookings { get; set; }

        public DateTime TransactionTime { get; set; }
    }
}
