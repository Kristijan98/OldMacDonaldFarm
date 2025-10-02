using OldMacDonaldFarm.Models;
using OldMacDonaldFarm.Utils;

namespace OldMacDonaldFarm.Services
{
    public static class PolymorphicFarm
    {
        public static void Run(int animalCount)
        {
            Console.WriteLine($"=== Polymorphic Version ({animalCount} Animals) ===\n");

            var animals = new List<IAnimal>
            {
                new Cow(),
                new Dog(),
                new Cat(),
                new Pig(),
                new Duck(),
                new Sheep(),
                new Horse(),
                new Chicken(),
                new Goat(),
                new Frog()
            };

            foreach (var animal in animals.Take(animalCount))
            {
                Console.WriteLine(VerseBuilder.BuildVerseStrings(animal.Name, animal.Sound));
                Console.WriteLine();
            }
        }
    }
}
