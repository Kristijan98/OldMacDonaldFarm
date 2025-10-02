using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonaldFarm.Utils
{
    public static class Question4Service
    {
        public static void DisplayQuestion4Answer()
        {
            string path = Path.Combine("Resources", "Question4.txt");

            if (File.Exists(path))
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("\n=== Question 4 - Macedonian Version ===\n");
                string text = File.ReadAllText(path, System.Text.Encoding.UTF8);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Answer file not found.");
            }
        }
    }
}
