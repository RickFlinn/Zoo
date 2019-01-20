using System;
using System.Collections.Generic;
using System.Text;
using Zoo_Lab05.Interfaces;

namespace Zoo_Lab05.Classes
{
    public class Human : Primate, ISwim, IFly
    {
        public override bool IsPredator { get; set; }

        public Human()
        {
            CanCode = false;
            IsPredator = true;

        }

        public override string Move()
        {
            Console.WriteLine("Walkin. Yup. Two legs.");
            return "Human moved";
        }

        public void Study(int hours)
        {
            if (hours > 1000)
            {
                CanCode = true;
            }
        }

        public string Swim()
        {
            Console.WriteLine("Human can swim");
            return "Splish splash!";
        }

        public string Fly()
        {
            Console.WriteLine("Weeee, I'm in a helicopter!");
            return "Humans can fly!";
        }

        public override void MonkeyAround()
        {
            Console.WriteLine("*Unwittingly makes self star of viral Youtube video*");
        }


    }
}