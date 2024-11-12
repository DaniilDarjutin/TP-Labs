public class GameLogger : IGameEventListener
    {
        public void OnGameEvent(GameEvent gameEvent)
        {
            Console.WriteLine($"Событие на данный момент: {gameEvent}");
        }
    }