using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model_validation_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User { Id = "123456", Name = "Tom", Age = -22 };
            Validate(user1);
            Console.WriteLine();

            var user2 = new User { Id = "d3io", Name = "Alice", Age = 33 };
            Validate(user2);

            Console.Read();
        }

        private static void Validate(User user)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("User '{0}' is Valid", user.Name);
            }
        }
    }
}
