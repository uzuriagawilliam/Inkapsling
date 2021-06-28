using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling
{
    public class Person : IPerson
    {
        private int age;
        private string fName;
        private string lName;
        private double hight;
        private double weight;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Age must be grater than 0");
                    }
                    if (value > 0)
                        age = value;
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string Fname
        {
            get
            {
                return fName;
            }
            set
            {
                if ((!string.IsNullOrEmpty(value) && (value.Length >= 2) && value.Length <= 10))
                {
                    fName = value;
                }
            }
        }
        public string Lname
        {
            get
            {
                return lName;
            }
            set
            {
                try
                {
                    if ((string.IsNullOrEmpty(value) && (value.Length < 3) && value.Length > 15))
                    {
                        throw new ArgumentException("Name can not be empty, less than 3 or grater than 15 charater");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if ((!string.IsNullOrEmpty(value) && (value.Length >= 3) && value.Length <= 15))
                {
                    lName = value;
                }
            }
        }
        public double Hight
        {
            get
            {
                return hight;
            }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Hight must be grater than 0");
                    }
                    if (value > 0)
                        hight = value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Weight must be grater than 0");
                else
                    weight = value;
            }
        }

          public Person()
        {
                
        }

        public Person(int v1, string v2, string v3, double v4, double v5)
        {
            Age = v1;
            Fname = v2;
            Lname = v3;
            Hight = v4;
            Weight = v5;
        }

        public void Talk()
        {
            throw new NotImplementedException();
        }
    }
}
