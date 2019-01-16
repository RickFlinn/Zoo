using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Lab05.Classes
{
    public abstract class Primate : Mammal
    {
        public virtual bool CanCode { get; set; }

        public void MonkeyAround()
        {
            Console.WriteLine("\"OOOOOO OOOOO AAAAAAAHHH AAHHHHHHHH\" *jumps around*");
        }

    }
}
