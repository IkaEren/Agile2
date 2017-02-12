using System.ComponentModel.DataAnnotations;

namespace AgileData
{
    public class Venue
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Addresss { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

    }
}