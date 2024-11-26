// Интерфейс IGameService
public interface IGameService
{
    void PlayGame();
}

// Реализация основного сервиса игры
public class GameService : IGameService
{
    public void PlayGame()
    {
        Console.WriteLine("Игра начинается");
    }
}

// Декоратор, который добавляет дополнительное сообщение
public class GameServiceDecorator : IGameService
{
    private readonly IGameService _gameService;

    public GameServiceDecorator(IGameService gameService)
    {
        _gameService = gameService;
    }

    public void PlayGame()
    {
        Console.WriteLine("Игра вот вот начнётся");
        _gameService.PlayGame();
    }
}
