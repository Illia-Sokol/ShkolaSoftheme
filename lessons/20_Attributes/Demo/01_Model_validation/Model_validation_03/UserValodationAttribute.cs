using System.ComponentModel.DataAnnotations;

namespace Model_validation_03
{
    public class UserValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var user = value as User;
            if (user != null && user.Name == "Alice" && user.Age == 33)
            {
                ErrorMessage = "Name should not be 'Alice' with age equals to 33";
                return false;
            }

            return true;
        }
    }
}
