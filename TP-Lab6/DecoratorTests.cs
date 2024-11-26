using NUnit.Framework;
using System.IO;

namespace GameTests
{
    [TestFixture]
    public class GameServiceDecoratorTests
    {
        [Test]
        public void GameServiceDecoratorTest()
        {
            var gameService = new GameService();
            var decoratedService = new GameServiceDecorator(gameService);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                decoratedService.PlayGame();

                var result = sw.ToString();

                Console.WriteLine(result);

                Assert.That(result, Does.Contain("Игра вот вот начнётся"));
                Assert.That(result, Does.Contain("Игра начинается"));

                TestContext.Progress.WriteLine("-----------------------------------------------------------------------------------");
                TestContext.Progress.WriteLine(result);
                TestContext.Progress.WriteLine("Тест пройден");
                TestContext.Progress.WriteLine("-----------------------------------------------------------------------------------");
            }
        }   
    }
}
