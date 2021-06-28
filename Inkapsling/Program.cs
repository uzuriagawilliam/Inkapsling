using Inkapsling._3_1;
using System;
using System.Collections.Generic;


namespace Inkapsling
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersHandler();
            AnimalList();
            //HundLista();
            //AllAnimalsStats();
            // DogsFromAnimalsStats();
            //ErrorsList();
        }

        private static void ErrorsList()
        {
            List<UserError> usererrors = new List <UserError>();

            NumericInputError numericInputError = new();           
            TextInputError textInputError = new();
            NullInputError nullInputError = new();
            DataInputError dataInputError = new();
            ImageInputError imageInputError = new();

            usererrors.Add(numericInputError);
            usererrors.Add(textInputError);
            usererrors.Add(nullInputError);
            usererrors.Add(dataInputError);
            usererrors.Add(imageInputError);

            foreach (UserError userError in usererrors)
            {
                if (userError is NumericInputError)
                {
                    NumericInputError tmp = (NumericInputError)userError;

                    Console.WriteLine(tmp.UEMessage());
                }
                if (userError is TextInputError)
                {
                    TextInputError tmp = (TextInputError)userError;
                    Console.WriteLine(tmp.UEMessage());
                }
                if (userError is NullInputError)
                {
                    NullInputError tmp = (NullInputError)userError;
                    Console.WriteLine(tmp.UEMessage());
                }
                if (userError is DataInputError)
                {
                    DataInputError tmp = (DataInputError)userError;
                    Console.WriteLine(tmp.UEMessage());
                }
                if (userError is ImageInputError)
                {
                    ImageInputError tmp = (ImageInputError)userError;
                    Console.WriteLine(tmp.UEMessage());
                }
            }
        }

        private static void AllAnimalsStats()
        {
            List<Animal> animals = new List<Animal>();
            Horse horse = new Horse();
            horse.Name = "Siver";

            Bird bird = new();
            bird.Name = "Pio pio";

            Wolf wolf = new();
            wolf.Name = "Lobo";

            Hedgehog hedgehog = new();
            hedgehog.Name = "Taggig";

            Dog hund = new Dog();
            hund.Name = "Lassy";
            
            Worm worm = new();
            worm.Name = "Flip";

            Pelican pelican = new();
            pelican.Weight = 5;

            animals.Add(horse);
            animals.Add(bird);
            animals.Add(wolf);
            animals.Add(hedgehog);
            animals.Add(hund);
            animals.Add(worm);
            animals.Add(pelican);

            foreach (var a in animals)
            {
                Console.WriteLine(a.Stats()); //Anroopar varge object eget Stats-metod
            }
        }
        private static void DogsFromAnimalsStats()
        {
            List<Animal> animals = new List<Animal>();
            Horse horse = new Horse("white", "Siver", 380);            

            Bird bird = new(1,"Pio pio", 1, 2);            

            Wolf wolf = new(43,"Lobo", 35, 12);            

            Hedgehog hedgehog = new(1500, "Taggig", 1, 3);
            hedgehog.Name = "Taggig";

            Dog hund = new Dog(2, "Lassy", 4, 3);            
            Dog hund2 = new Dog( 1, "Perro", 8, 9);          
            Dog hund3 = new Dog(2, "Chande", 4,7);

            Worm worm = new(3, "Gusss", 1, 1);            
            
            Pelican pelican = new();
            pelican.Weight = 5;

            animals.Add(horse);
            animals.Add(bird);
            animals.Add(wolf);
            animals.Add(hedgehog);
            animals.Add(hund);
            animals.Add(hund2);
            animals.Add(hund3);
            animals.Add(worm);
            animals.Add(pelican);

            foreach (var a in animals)
            {
                if(a is Dog)
                {
                    Console.WriteLine(a.Stats()); //Anroopar varge object eget Stats-metod
                }                
            }
        }

        private static void HundLista()
        {
            Horse horse = new Horse();

            List<Dog> hund = new List<Dog>();
            //hund.Add(horse);//Funkar inte därför att horse är inte ett object av classen Dog.

        }

        static void PersHandler()
        {
            PersonHandler pernshandler = new PersonHandler();
            Person per = new Person();
            Person per2 = new Person();
            Person per3 = new Person();
            //Horse horse = new Horse();

            per = pernshandler.CreatePerson(20, "Nadja", "omoro", 175, 68); //Create a person and save it in "per"
            pernshandler.AddPerson(per);
            per2 = pernshandler.CreatePerson(55, "Niklas", "Kross", 190, 100);
            pernshandler.AddPerson(per2);
            per3 = pernshandler.CreatePerson(20, "Loui", "Grueso", 173, 80);
            pernshandler.AddPerson(per3.Age, per3.Lname, per3.Fname, per3.Hight, per3.Weight);

            pernshandler.Print(per); // Printar en person
            pernshandler.Print(per2);
            pernshandler.Print(per3);

            pernshandler.Print(); //Printar alla personer i listan

            pernshandler.SetAge(per, 25);
        }
        static void AnimalList()
        {
            List<Animal> animals = new List<Animal>();
            Horse horse = new Horse();
            horse.Weight = 250;
            horse.Name = "Pinto";
            horse.Age = 5;
            horse.Color = "Black";            

            Wolf wolf = new();
            wolf.Age = 6;
            wolf.Name = "Lobo";
            wolf.Weight = 40;
            wolf.NumberOfTeeth = 42;

            Bird bird = new();
            bird.Name = "pipi";
            bird.Weight = 1;
            bird.Age = 2;
            bird.Weight = 3;            
            
            var wolfMan = new Wolfman();
            wolfMan.Name = "Anibal";
            wolfMan.Weight = 90;
            wolfMan.Age = 79;
            wolfMan.NumberOfTeeth = 32;

            animals.Add(horse);
            animals.Add(bird);
            animals.Add(wolf);
            animals.Add(wolfMan);

            foreach (var a in animals)
            {
                if (a is IPerson pers) 
                {
                    var wm = (Wolfman)a; //Type cast
                    wm.Talk();                    
                }
                else
                {
                    a.DoSound();
                    Console.WriteLine(a.Stats()); //Anroopar varge object eget Stats-metod
                }
            }
        }
    }
}
