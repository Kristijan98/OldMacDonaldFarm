using OldMacDonaldFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonaldFarm.Utils
{
    public static class VerseBuilder
    {
      
        public static string BuildVerseStrings(string animal, string sound)
        {
            return
                $@"Old MacDonald had a farm, E-I-E-I-O,
                And on that farm he had a {animal}, E-I-E-I-O,
                With a {sound} {sound} here,
                And a {sound} {sound} there,
                Here a {sound}, there a {sound},
                Everywhere a {sound} {sound},
                Old MacDonald had a farm, E-I-E-I-O.";
        }
    }
}

