using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }

        public abstract void DoSound();
        public Animal(string name, int weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;         
        }
        //F: Här tror jag att man skulle kunna lägga atribut till alla djur
        public virtual string Stats()
        {            
            return $"Name: {Name}, weight {Weight}, age {Age}";
        }
    }
}
