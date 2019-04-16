using System;

namespace myApp
{
    public class Demon : Monster, IKilledBySilver, IKilledByFire, IKilledByWater
    {
        public Demon(string name)
        {
            Type = "Demon";
            Name = name;
        }
        public void Douse()
        {
            Console.WriteLine($"The {Type} {Name} drowns in Holy Water!");
        }
        public void Stab()
        {
            Console.WriteLine($"The {Type} {Name} drowns in its own blood!");
        }
        public void Burn()
        {
            Console.WriteLine($"The {Type} {Name} is engulfed in flames!");
        }
    }
}