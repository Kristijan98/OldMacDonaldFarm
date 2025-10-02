using OldMacDonaldFarm.Models;
using OldMacDonaldFarm.Utils;

namespace OldMacDonaldFarm.Services
{
    public static class UserInputFarm
    {
        public static void Run()
        {
            Console.WriteLine("=== User Input Version ===\n");

            var animals = new List<IAnimal>();

            Console.Write("How many animals do you want to add? ");
            if (!int.TryParse(Console.ReadLine(), out int count))
                count = 1;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter animal name #{i + 1}: ");
                string? name = Console.ReadLine() ?? "unknown";

                Console.Write($"Enter sound for {name}: ");
                string? sound = Console.ReadLine() ?? "???";

                animals.Add(new CustomAnimal(name, sound));
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(VerseBuilder.BuildVerseStrings(animal.Name, animal.Sound));
                Console.WriteLine();
            }
        }
    }
}
