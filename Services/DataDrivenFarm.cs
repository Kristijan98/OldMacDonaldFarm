using OldMacDonaldFarm.Utils;

namespace OldMacDonaldFarm.Services
{
    public static class DataDrivenFarm
    {
        public static void Run()
        {
            var animals = new Dictionary<string, string>
            {
                { "cow", "moo" },
                { "dog", "woof" },
                { "cat", "meow" },
                { "pig", "oink" },
                { "duck", "quack" }
            };

            Console.WriteLine("=== Data Driven Version ===\n");
            foreach (var animal in animals)
            {
                Console.WriteLine(VerseBuilder.BuildVerseStrings(animal.Key, animal.Value));
                Console.WriteLine();
            }
        }

 
    }
}
