using System;

namespace Cats
{
    public class HouseCat : Cat
    {
        public string Name { get; set; }
        public string Species { get; } = "Felis catus";

        public HouseCat(string name)
        {
            Name = name;
        }

        public HouseCat(double weight) : base(weight)
        {
            // This is all there is to this constructor! But a bad one, below example is better
        }
        public HouseCat(string name, double weight) : base(weight)
        {
            Name = name;
        }

        // On this line, write a constructor that uses the no-arg constructor in the Cat class.

        public bool IsSatisfied()
        {
            return !Hungry && !Tired;
        }

        public override string Noise()
        {
            if(IsSatisfied())
            {
                return "Hello, my name is " + Name + "!";
            }
            else
            {
                return base.Noise(); // TODO : STUDY THIS!
            }
        }

        public string Purr()
        {
            return "I'm a housecat";
        }

        public override string Play()
        {
            if (!IsSatisfied())
            {
                return base.Play();
            }
            else
            {
                return "Nope, I just want to chill.";
            }
        }
    }
}
