using System;

namespace CompanionApp
{
    public class Cat : Alive
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public Cat(string name, int age)
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
            Random random = new Random();
            if (random.Next(2) == 0)
            {
                return "Meow";
            }
            else
            {
                return "Silent";
            }
        }
    }
}