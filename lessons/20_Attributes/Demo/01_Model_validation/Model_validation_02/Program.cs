using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model_validation_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input name:");
            var name = Console.ReadLine();

            Console.WriteLine("Input age:");
            var age = int.Parse(Console.ReadLine());

            var user = new User { Name = name, Age = age };

            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);

            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }

            Console.ReadLine();
        }
    }
}
