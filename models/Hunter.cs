using System;
using System.Collections.Generic;

namespace myApp
{
    public class Hunter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> Weapons { get; } = new List<string>() {
        "Silver", "Fire", "Holy Water"
    };

        public Hunter(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public void SplashWater(IKilledByWater taco)
        {
            taco.Douse();  // Kills with holy water
        }

        public void Ignite(IKilledByFire taco)
        {
            taco.Burn();  // Kills with fire
        }

        public void WieldSilver(IKilledBySilver taco)
        {
            taco.Stab();   // Stabs with silver knife
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} kills monsters with the following weapons: {String.Join(", ", Weapons)}";
        }
    }
}