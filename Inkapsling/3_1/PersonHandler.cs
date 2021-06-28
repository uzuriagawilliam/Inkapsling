using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling
{
    class PersonHandler
    {
        private List<Person> persons = new List<Person>();
        public PersonHandler()
        {
            persons = new List<Person>();
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        internal void CreatePerson()
        {
            throw new NotImplementedException();
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person per = new Person(age, fname, lname, height, weight);

            return per;

        }
        public void Print(Person per)
        {            
             Console.WriteLine($"{per.Lname} {per.Fname} är {per.Age} år gamal. Väger {per.Weight} kilo och är {per.Hight} cm lång");         
        }
        public void Print()  
        {
            foreach (Person p in persons)
            {
                Console.WriteLine($"{p.Lname} {p.Fname} är {p.Age} år gamal. Väger {p.Weight} kilo och är {p.Hight} cm lång");
            }

        }
        public void AddPerson(int age, string fname, string lname, double height, double weight)
        {
            persons.Add(new Person(age, fname, lname, height, weight));
        }

        public void AddPerson(Person per)
        {
            persons.Add(new Person(per.Age, per.Fname, per.Lname, per.Hight, per.Weight));
        }

    }
}
