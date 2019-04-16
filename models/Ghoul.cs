using System;

namespace myApp
{
    public class Ghoul : Monster, IKilledBySilver, IKilledByWater
    {
        public Ghoul(string name) {
            Type = "Ghoul";
            Name = name;
        }
        public void Douse() {
            Console.WriteLine($"The {Type} {Name} drowns in Holy Water!");
        }
        public void Stab() {
            Console.WriteLine($"The {Type} {Name} drowns in its own blood!");
        }
    }
}