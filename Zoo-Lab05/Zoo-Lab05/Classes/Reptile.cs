using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Lab05.Classes
{
    public abstract class Reptile : Animal
    {
        public override bool IsWarmBlooded
        {
            get { return false; }
        }

        public bool IsEgg { get; set; }

        public void Hatch()
        {
            IsEgg = false;
        }
    }
}
