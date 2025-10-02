using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonaldFarm.Models
{
    public interface IAnimal
    {
        string Name { get; }
        string Sound { get; }
    }

    public class Cow : IAnimal {
        public string Name => "cow"; 
        public string Sound => "moo"; 
    }

    public class Dog : IAnimal {
        public string Name => "dog"; 
        public string Sound => "woof"; 
    }

    public class Cat : IAnimal {
        public string Name => "cat";
        public string Sound => "meow"; 
    }
    public class Pig : IAnimal {
        public string Name => "pig";
        public string Sound => "oink"; 
    }

    public class Duck : IAnimal { 
        public string Name => "duck";
        public string Sound => "quack"; 
    }

    // Additional animals for Q2
    public class Sheep : IAnimal {
        public string Name => "sheep"; 
        public string Sound => "baa"; 
    }

    public class Horse : IAnimal {
        public string Name => "horse";
        public string Sound => "neigh";
    }

    public class Chicken : IAnimal {
        public string Name => "chicken"; 
        public string Sound => "cluck";
    }

    public class Goat : IAnimal {
        public string Name => "goat";
        public string Sound => "bleat"; 
    }

    public class Frog : IAnimal {
        public string Name => "frog";
        public string Sound => "ribbit";
    }

    // User-defined animal
    public class CustomAnimal : IAnimal
    {
        public string Name { get; }
        public string Sound { get; }

        public CustomAnimal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
    }

}

