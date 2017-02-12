using System.ComponentModel.DataAnnotations;

namespace AgileData
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(35)]
        public string FirstName { get; set; }

        [MaxLength(35)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public decimal? Balance { get; set; }
    }
}
