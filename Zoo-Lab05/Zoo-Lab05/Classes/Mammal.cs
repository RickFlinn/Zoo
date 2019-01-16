using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Lab05.Classes
{
    public abstract class Mammal : Animal
    {
        public override bool IsWarmBlooded
        {
            get { return true; }
        }

        public override int Limbs
        {
            get { return 4; }
        }

        public virtual string RearYoung(Mammal[] offspring, int calories)
        {
            Console.WriteLine($"{GetType().ToString()} helps their offspring survive!");
            foreach(Mammal child in offspring)
            {
                WorthCalories -= calories;
                child.WorthCalories += calories * 2;
            }
            return "Wow, look how they've grown!";
        }
    }
}
