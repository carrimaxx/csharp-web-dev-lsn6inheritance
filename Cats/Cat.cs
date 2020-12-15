using System;

namespace Cats
{
    public class Cat
    {
        public bool Tired { get; set; } = false;
        public bool Hungry { get; set; } = false;
        public double Weight { get; set; }
        public string Family { get; } = "Felidae";

        public Cat()
        {
            Weight = 13.0;
        }
        public Cat(double weight)
        {
            Weight = weight;
        }

        // On this line, add a no-argument constructor

        public void Sleep()
        {
            Tired = false;
            Hungry = true;
        }

        public void Eat()
        {
            if (!Hungry)
            {
                Tired = true;
            }

            Hungry = false;
        }

        public virtual string Noise() //add virtual if to be override
        {
            return "Meow!";
        }

        public virtual string Play()
        {
            return "Time to annoy the dog!";
        }

    }
}
