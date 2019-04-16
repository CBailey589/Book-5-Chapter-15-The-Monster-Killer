using System;

namespace myApp
{
    public class Ghast : Monster, IKilledByWater, IKilledByFire
    {
        public Ghast(string name)
        {
            Type = "Ghast";
            Name = name;
        }
        public void Burn()
        {
            Console.WriteLine($"The {Type} {Name} is engulfed in flames!");
        }
        public void Douse()
        {
            Console.WriteLine($"The {Type} {Name} drowns in Holy Water!");
        }
    }
}