using System.ComponentModel.DataAnnotations;

namespace Model_validation
{
    public class User
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Range(1, 100)]
        public int Age { get; set; }
    }
}
