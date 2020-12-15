using System;

namespace Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseCat garfield = new HouseCat("Garfield", 12.5);
            garfield.Eat();
            Console.WriteLine(garfield.Tired);

            HouseCat mingming = new HouseCat("Mingming");
            Console.WriteLine(mingming.Weight);

            HouseCat purry = new HouseCat(13.5);
            Console.WriteLine(purry.Weight);
            Console.WriteLine(purry.Play());
            purry.Eat();
            Console.WriteLine(purry.Play());

            Cat suki = new HouseCat("Suki", 8);
            Console.WriteLine(suki.Noise());
            Console.WriteLine((suki as HouseCat).IsSatisfied());


        }
    }
}
