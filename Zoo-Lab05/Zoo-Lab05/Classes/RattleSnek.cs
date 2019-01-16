using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Lab05.Classes
{
    public class RattleSnek : Reptile
    {
        public override bool IsPredator
        {
           get { return true; }
           set { }
        }
        

        public override int Limbs
        {
            get { return 0; }
        }

        public RattleSnek()
        {
            WorthCalories = 1000;
            IsEgg = true;
        }

        public override string Move()
        {
            if (IsEgg)
            {
                Hatch();
                return "RattleSnek hatched";
            }
            Console.WriteLine("Slither slither");
            return "Rattlesnek moved";
        }
        

        public void Rattle()
        {
            Console.WriteLine("Rattle rattle");
        }
    }
}
