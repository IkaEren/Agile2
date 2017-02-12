using System.ComponentModel.DataAnnotations;

namespace AgileData
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ActivityName { get; set; }
    }
}
