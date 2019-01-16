using System;
using System.Collections.Generic;
using System.Text;
using Zoo_Lab05.Interfaces;

namespace Zoo_Lab05.Classes
{
    public class Monkey : Primate, IFly
    {
        public override bool IsPredator { get; set; }
        public override bool CanCode 
        {
            get => true;
            set => Console.WriteLine("You can take the monkey out of the code...");
        }

        public Monkey()
        {
            IsPredator = false;
            WorthCalories = 1000;
        }

        public override string Move()
        {
            Console.WriteLine("Swingin thru sum trees n stuff");
            return "Monkey moved";
        }

        public string Fly()
        {
            Console.WriteLine("Wee, monkey flying");
            return "Monkey flew";
        }
    }
}
