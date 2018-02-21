using System;

namespace Inheritance_and_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            var dog = new Dog();
            var snake = new Snake();

            var animals = new Animal[] { cat, dog, snake };

            foreach (var animal in animals)
            {
                Console.WriteLine("Type: {0}, IsMammal: {1}",
                                  animal.GetType().Name,
                                  animal.IsMammal);

                var catAnimal = animal as Cat;
                if (catAnimal != null)
                {
                    catAnimal.Meow();
                }

                var dogAnimal = animal as Dog;
                if (dogAnimal != null)
                {
                    dogAnimal.Fetch();
                }

                var csnakeAnimal = animal as Snake;
                if (csnakeAnimal != null)
                {
                    csnakeAnimal.ShedSkin();
                }
            }
        }
    }
}
