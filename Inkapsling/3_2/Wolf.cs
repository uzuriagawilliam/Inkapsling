using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling
{
    class Wolf : Animal
    {
        public int NumberOfTeeth { get; set; }

        public Wolf(int numberofteeth = 42, string name = "DefaultName", int weight = 12, int age = 10) : base(name,weight,age)
        {
            NumberOfTeeth = numberofteeth;
        }
        public override void DoSound()
        {
            Console.WriteLine("ooouuuuuuuuu");
        }
        public override string Stats()
        {
            return base.Stats() + $" och har {NumberOfTeeth} tänder";
        }
    }
}
