using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model_Validation_04
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User { Id = "", Name = "Tom", Age = -22 };
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
                Console.WriteLine("Пользователь прошел валидацию");
            }
        }
    }
}
