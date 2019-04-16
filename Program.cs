using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");
            Console.WriteLine(VonRimmersmark);

            Vampire Dracula = new Vampire("Dracula");
            Mummy Mark = new Mummy("Mark");
            Ghoul Gary = new Ghoul("Gary");
            Ghast Greg = new Ghast("Greg");
            Wight Whitney = new Wight("Whitney");
            Demon Daryl = new Demon("Daryl");
            Zombie Zed = new Zombie("Zed");

            VonRimmersmark.WieldSilver(Dracula);
            VonRimmersmark.Ignite(Mark);
            VonRimmersmark.SplashWater(Gary);
            VonRimmersmark.Ignite(Greg);
            VonRimmersmark.WieldSilver(Whitney);
            VonRimmersmark.SplashWater(Daryl);
            VonRimmersmark.Ignite(Zed);
        }
    }
}
