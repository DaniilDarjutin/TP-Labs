using System;

namespace CompanionApp
{
    public class Person
    {
        private string Name { get; set; }
        private Alive Companion { get; set; }

        public Person(string name, Alive companion)
        {
            Name = name;
            Companion = companion;
        }

        public string GetName()
        {
            return Name;
        }

        public Alive GetCompanion()
        {
            return Companion;
        }

        public void GetCompanionInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Companion Name: {Companion.GetName()}");
            Console.WriteLine($"Companion Age: {Companion.GetAge()}");
            Console.WriteLine($"Companion Sound: {Companion.MakeSound()}");
            Console.WriteLine();
        }
    }
}