using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model_Validation_04
{
    public class User : IValidatableObject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.Name))
                errors.Add(new ValidationResult("Не указано имя"));

            if (string.IsNullOrWhiteSpace(this.Id))
                errors.Add(new ValidationResult("Не указан идентификатор пользователя"));

            if (this.Age < 1 || this.Age > 100)
                errors.Add(new ValidationResult("Недопустимый возраст"));

            return errors;
        }
    }
}