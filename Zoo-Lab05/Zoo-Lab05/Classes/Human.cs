using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Lab05.Classes
{
    public class Human : Primate
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
    }
}