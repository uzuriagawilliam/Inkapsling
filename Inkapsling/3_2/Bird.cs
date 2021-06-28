using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling
{
    class Bird : Animal
    {
        public int WingSpan { get; set; }

        public Bird(int wingspan =10,string name = "DefaultName", int weight = 12, int age=10) : base(name, weight, age)
        {
            WingSpan = wingspan;
        }

        public Bird(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("viriririrr iriri");
        }
        //F: Här tror jag att man skulle kunna lägga atribut till alla fåglar
        public override string Stats()
        {
            return base.Stats() + $", wingspan { WingSpan } meter";
        }
    }
    class Pelican : Bird
    {
        public int BeakLength { get; set; }
        public int Wingspan { get; set; }

        public Pelican(int wingspan = 7, string name = "Pilicano", int weight = 6, int age = 15) : base(name, weight, age)
        {
            BeakLength = 45;
            Wingspan = wingspan;
        }
        public override string Stats()
        {
            return base.Stats() + $", beak length { BeakLength } centimeter";
        }
    }


    class Flamingo : Bird
    {
        public int Height { get; set; }
        public Flamingo()
        {
            Height = (int)1.5;
        }
        public override string Stats()
        {
            return base.Stats() + $", height { Height } centimeter";
        }
    }
    class Swan : Bird
    {
        public new int Weight { get; set; }

        public Swan()
        {
            Weight = 2; 
        }

        public override string Stats()
        {
            return base.Stats();
        }
    }
}
