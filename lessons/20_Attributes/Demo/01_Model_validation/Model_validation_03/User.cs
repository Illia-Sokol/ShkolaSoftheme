using System.ComponentModel.DataAnnotations;

namespace Model_validation_03
{
    [UserValidation]
    public class User
    {
        [Required]
        public string Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int Age { get; set; }
    }
}
