using System;

namespace myApp
{
    public class Vampire : Monster, IKilledBySilver, IKilledByFire
    {
        public Vampire(string name) {
            Type = "Vampire";
            Name = name;
        }
        public void Burn() {
            Console.WriteLine($"The {Type} {Name} is engulfed in flames!");
        }
        public void Stab() {
            Console.WriteLine($"The {Type} {Name} drowns in its own blood!");
        }
    }
}