using System;
using System.Collections.Generic;
using System.Text;
using Zoo_Lab05.Interfaces;

namespace Zoo_Lab05.Classes
{
    public class Crocilligator : Reptile, ISwim
    {
        public override bool IsPredator { get => true; set { } }
        public override int Limbs { get => 4; }

        public Crocilligator()
        {
            WorthCalories = 10000;
            IsEgg = true;
        }

        public override string Move()
        {
            if (IsEgg)
            {
                Hatch();
                Console.WriteLine("Crocilligator Hatched!");
                return "Crocilligator hatched";
            }
            Console.WriteLine("Don't mind me, I'm just a floating log.");
            return "Crocilligator moved";
        }
        

        public override void Devour(Animal prey)
        {
            Console.WriteLine("I'll try spinning! That's a neat trick");
            WorthCalories += prey.WorthCalories;
            prey.WorthCalories = 0;
        }

        public string Swim()
        {
            Console.WriteLine("Croc can swim");
            return "Splish splash!";
        }
    }
}
