using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling
{
    class Worm : Animal
    {
        public int IsPoisonous { get; set; }

        public Worm(int ispoisonous = 2,string name = "DefaultName", int weight = 12, int age = 10) : base(name,weight,age)
        {
            IsPoisonous = ispoisonous;
        }
        public override void DoSound()
        {
            Console.WriteLine("ssssss");            
        }
        public override string Stats()
        {
            return base.Stats() + $"on graden av giftihet är {IsPoisonous} ";
        }
    }
}
