using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Lab05.Classes
{
    public class LizardWizard : Reptile
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
    }
}
