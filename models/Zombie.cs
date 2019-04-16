using System;

namespace myApp
{
    public class Zombie : Monster, IKilledByFire
    {
        public Zombie(string name)
        {
            Type = "Zombie";
            Name = name;
        }
        public void Burn()
        {
            Console.WriteLine($"The {Type} {Name} is engulfed in flames!");
        }
    }
}