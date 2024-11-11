using System;

namespace CompanionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Whiskers", 3);
            Dog dog = new Dog("Buddy", 5);

            Person person1 = new Person("Alice", cat);
            Person person2 = new Person("Bob", dog);

            person1.GetCompanionInfo();
            person2.GetCompanionInfo();
        }
    }
}