using System;

namespace CompanionApp
{
    public class Dog : Alive
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public string MakeSound()
        {
            return "Woof";
        }
    }
}