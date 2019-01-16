using System;
using System.Collections.Generic;
using System.Text;
using Zoo_Lab05.Interfaces;

namespace Zoo_Lab05.Classes
{
    public class LizardWizard : Reptile, IFly
    {
        public override bool IsPredator { get => false; set => Console.WriteLine("He will never abandon his peaceful ways"); }

        public override int Limbs { get => 5; }

        public LizardWizard()
        {
            IsEgg = true;
            WorthCalories = 1;
        }

        public override string Move()
        {
            Console.WriteLine("Wizard teleportation! bzzzzzhzhzhzhzhhzhz");
            return "LizardWizard moved";
        }

        public string Fly()
        {
            Console.WriteLine("LizardWizard casts levitate");
            return "LizardWizard flew";
        }
    }
}
