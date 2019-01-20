using System;
using Xunit;
using Zoo_Lab05.Classes;
using Zoo_Lab05.Interfaces;


namespace ZooTests
{
    public class UnitTest1
    {

        Monkey monkey = new Monkey();
        Monkey monkey2 = new Monkey();
        LizardWizard lizWiz = new LizardWizard();
        Human thatGuy = new Human();
        Human hisKid = new Human();
        MegaHamster squeakums = new MegaHamster();
        Crocilligator croc = new Crocilligator();
        RattleSnek snek = new RattleSnek();


        // Test set for Lab05
        [Fact]
        public void MonkeyInheritsAnimal()
        {
            Assert.True(monkey.IsAnimal);
        }

        [Fact]
        public void MonkeyInheritsMammal()
        {
            Assert.Equal("Wow, look how they've grown!", monkey.RearYoung(new Mammal[] { monkey2 }, 20));
        }

        [Fact]
        public void HumanInheritsAnimal()
        {
            Assert.True(snek.IsAnimal);
        }

        [Fact]
        public void HumanInheritsMammal()
        {
            Assert.Equal("Wow, look how they've grown!", thatGuy.RearYoung(new Mammal[] { hisKid }, 20));
        }

        [Fact]
        public void HamsterIsAnimal()
        {
            Assert.True(squeakums.IsAnimal);
        }

        [Fact]
        public void HamsterInheritsMammal()
        {
            Assert.Equal("Mammalia", squeakums.GetClass());
        }



        [Fact]
        public void LizWizInheritsAnimal()
        {
            Assert.True(lizWiz.IsAnimal);
        }

        [Fact]
        public void LizWizCanIntoEgg()
        {
            bool startedAsEgg = lizWiz.IsEgg;
            lizWiz.Hatch();
            bool isEggNow = lizWiz.IsEgg;
            Assert.True(startedAsEgg != isEggNow);
        }

        [Fact]
        public void SnekInheritsAnimal()
        {
            Assert.True(snek.IsAnimal);
        }

        [Fact]
        public void SnekCanIntoEgg()
        {
            bool startedAsEgg = snek.IsEgg;
            snek.Hatch();
            bool isEggNow = snek.IsEgg;
            Assert.True(startedAsEgg != isEggNow);
        }

        [Fact]
        public void CrocInheritsAnimal()
        {
            Assert.True(croc.IsAnimal);
        }

        [Fact]
        public void CrocCanIntoEgg()
        {
            bool startedAsEgg = croc.IsEgg;
            croc.Hatch();
            bool isEggNow = croc.IsEgg;
            Assert.True(startedAsEgg != isEggNow);
        }



        [Fact]
        public void IsOfBaseClassAnimal()
        {
            Assert.True(monkey is Animal);
        }

        [Fact]
        public void RearYoungOverriden()
        {
            MegaHamster squeakumsDad = new MegaHamster(2000);
            MegaHamster squeakumsBrother = new MegaHamster();
            MegaHamster squeakumsSis = new MegaHamster();
            Mammal[] squeakers = { squeakums, squeakumsBrother, squeakumsSis };

            Assert.Equal("Hamsters raised. Or eaten.", squeakumsDad.RearYoung(squeakers, 100));
        }

        [Fact]
        public void HumanCanFly()
        {
            IFly pilot = new Human();
            Assert.Equal("Humans can fly!", pilot.Fly());
        }

        [Fact]
        public void MonkeyCanFly()
        {
            IFly wickedWitchesMinion = new Monkey();
            Assert.Equal("Monkey flew", wickedWitchesMinion.Fly());
        }

        [Fact]
        public void LizWizCanFly()
        {
            IFly levitatingLizard = new LizardWizard();
            Assert.Equal("LizardWizard flew", levitatingLizard.Fly());
        }

        [Fact]
        public void HumanCanSwim()
        {
            Assert.Equal("Splish splash!", thatGuy.Swim());
        }

        [Fact]
        public void CrocCanSwim()
        {
            Assert.Equal("Splish splash!", croc.Swim());
        }



    }



}
