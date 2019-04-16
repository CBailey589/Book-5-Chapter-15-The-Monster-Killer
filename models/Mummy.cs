using System;

namespace myApp
{
    public class Mummy : Monster, IKilledByFire
    {
        public Mummy(string name) {
            Type = "Mummy";
            Name = name;
        }
        public void Burn() {
            Console.WriteLine($"The {Type} {Name} is engulfed in flames!");
        }
    }
}