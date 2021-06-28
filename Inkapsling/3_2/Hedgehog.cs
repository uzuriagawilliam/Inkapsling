using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling
{
    class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }
        public Hedgehog(int nrofspikes = 1000, string name = "DefaultName", int weight = 1 , int age = 2) : base(name, weight, age)
        {
            NrOfSpikes = nrofspikes;
        }
        public override void DoSound()
        {
            Console.WriteLine("spspspspspsp");
        }
        public override string Stats()
        {
            return base.Stats() + $"och har {NrOfSpikes} taggar.";
        }
    }
}
