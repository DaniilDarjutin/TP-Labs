using NUnit.Framework;
using System;

namespace GameLoggerTests
{
    [TestFixture]
    public class GameLoggerTests
    {
        [Test]
        public void GameLoggerTest()
        {

            var instance1 = GameLogger.GetInstance();
            var instance2 = GameLogger.GetInstance();

            Assert.That(instance1, Is.SameAs(instance2), "Метод GetInstance должен возвращать один и тот же экземпляр");

            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Тест прошел успешно: Singleton возвращает один и тот же экземпляр.");
            Console.WriteLine("-----------------------------------------------------------------------------------");
        }
    }
}
