using System;
using Zoo_Lab05.Classes;
using Zoo_Lab05.Interfaces;

namespace Zoo_Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            LizardWizard lizard = new LizardWizard();
            Human human = new Human();
            Crocilligator croc = new Crocilligator();
            MegaHamster hamster = new MegaHamster(600);
            Monkey monkey = new Monkey();
            RattleSnek snake = new RattleSnek();

            Animal[] animals = { lizard, human, croc, hamster, monkey, snake };

            foreach(Animal animal in animals)
            {
                Console.WriteLine($"{animal.GetType().ToString()} is an Animal: {animal.IsAnimal}");
                animal.Move();
            }

            human.Swim();
            croc.Swim();
            monkey.Fly();
            lizard.Fly();
            human.Fly();
        }
    }
}
