using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Lab05.Classes
{
    public abstract class Animal
    {
        public abstract bool IsPredator { get; set; }
        public abstract bool IsWarmBlooded { get;}
        public virtual int WorthCalories { get; set; }
        public abstract int Limbs { get; }
        public bool IsAnimal { get => true; }

        public virtual string Move()
        {
            return "Animal moved";
        }

        public virtual string Devour(Animal prey)
        {
            if (IsPredator)
            {
                Console.WriteLine("Nom nom nom");
                WorthCalories += prey.WorthCalories;
                prey.WorthCalories = 0;
            }
            return "gottem";
        }

        public abstract string GetClass();
    }
}
