using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling
{
    class Dog : Animal
    {
        public int HairLength { get; set; }


        public Dog(int hairlength = 5, string name = "Tarzan", int weight = 4, int age = 3) : base(name, weight, age)
        {
            HairLength = hairlength;
        }
        public override void DoSound()
        {
            Console.WriteLine("guao guao");
        }
        public override string Stats()
        {            
            return base.Stats() + $" och håret är {HairLength} cm lång ";
        }

    }
}
