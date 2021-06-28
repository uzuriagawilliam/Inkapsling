using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling
{
    class Horse : Animal
    {
        public string Color { get; set; }
        public Horse(string color = "Brown", string name = "DefaultName", int weight = 200, int age = 8) : base(name, weight, age)
        {
            Color = color;
        }
        public override void DoSound()
        {
            Console.WriteLine("njeeeee jeeeeee");
        }
        public override string Stats()
        {
            return base.Stats() + $" och är {Color}.";
        }

    }
}
