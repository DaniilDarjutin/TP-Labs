using NUnit.Framework;

namespace GameTests
{
    [TestFixture]
    public class DamageHandlerTests
    {
        [Test]
        public void TestDamageHandling_ChainOfResponsibility()
        {
            var handler1 = new Handler1();
            var handler2 = new Handler2();
            var handler3 = new Handler3();

            handler1.SetNext(handler2);
            handler2.SetNext(handler3);

            var remainingDamage = handler1.Handle(100);

            Assert.That(remainingDamage, Is.EqualTo(0), "Остаток не 0");

            TestContext.Progress.WriteLine("-----------------------------------------------------------------------------------");
            TestContext.Progress.WriteLine($"Оставшийся урон: {remainingDamage}");
            TestContext.Progress.WriteLine("Тест прошел успешно!");
            TestContext.Progress.WriteLine("-----------------------------------------------------------------------------------");
        }
    }
}
