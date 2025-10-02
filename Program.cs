
using OldMacDonaldFarm.Services;
using OldMacDonaldFarm.Utils;
namespace OldMacDonaldFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Old MacDonald Farm ===");

                Console.WriteLine("1. Question 1 - Data Driven");
                Console.WriteLine("2. Question 1 - Polymorphic");
                Console.WriteLine("3. Question 2 - Add 10 Animals (Polymorphic)");
                Console.WriteLine("4. Question 3 - User Input");
                Console.WriteLine("5. Question 4 - Macedonian Version (read from file)");

                Console.WriteLine("6. Show Diagram - Data Driven");
                Console.WriteLine("7. Show Diagram - Polymorphic");

                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DataDrivenFarm.Run();
                        break;

                    case "2":
                        PolymorphicFarm.Run(5); // 5 animals only
                        break;
                    case "3":
                        PolymorphicFarm.Run(10); // 10 animals
                        break;
                    case "4":
                        UserInputFarm.Run();
                        break;
                    case "5":
                        Question4Service.DisplayQuestion4Answer();
                        break;

                    case "6":
                        ImageViewer.Show("Resources/Diagram_Solution1_Data_Driven.jpg");
                        break;
                    case "7":
                        ImageViewer.Show("Resources/Diagram_Solution2_Polymorphic.jpg");
                        break;

                    case "8":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress Enter to return to menu...");
                    Console.ReadLine();
                }
            }
        }
    }
}
