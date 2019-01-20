using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Lab05.Classes
{
    public class MegaHamster : Mammal
    {
        public override bool IsPredator
        {
            get
            {
                if (WorthCalories > 1000)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            set { }
        }

        public MegaHamster()
        {
            WorthCalories = 500;
        }

        public MegaHamster(int sizeInCalories)
        {
            WorthCalories = sizeInCalories;
        }

        public string Roar()
        {
            string rar;

            if (IsPredator)
            {
                rar = "ROARRRRARRHAAHGHAHGAHGHA";
                
            } else
            {
                rar = "Squeak!";
            }

            Console.WriteLine(rar);
            WorthCalories += 251;

            return rar;
        }

        public override string Move()
        {
            if (IsPredator)
            {
                Console.WriteLine("*Sprints faster than your eyes can track*");
            } else
            {
                Console.WriteLine("*Runs around on floor inside ball*");
            }
            return "MegaHamster moved";
        }

        public override string RearYoung(Mammal[] offspring, int calories)
        {
            try
            {
                bool willEat = false;
                foreach(Mammal babyHamster in offspring)
                {
                    if (willEat)
                    {
                        Devour(babyHamster);
                        Console.WriteLine("Sorry kid. They don't call us HAMsters for nothing.");
                    } else
                    {
                        babyHamster.WorthCalories += calories;
                        WorthCalories -= calories / 2;
                        Console.WriteLine("The hamsters are growing stronger...");
                    }
                    willEat = !willEat;
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return "Hamsters raised. Or eaten.";
        }

    }
}
