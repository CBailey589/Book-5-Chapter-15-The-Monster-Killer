using System;

namespace myApp
{
    public class Wight : Monster, IKilledBySilver
    {
        public Wight(string name) {
            Type = "Wight";
            Name = name;
        }
        public void Stab() {
            Console.WriteLine($"The {Type} {Name} drowns in its own blood!");
        }
    }
}