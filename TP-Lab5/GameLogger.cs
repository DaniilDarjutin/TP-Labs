public class GameLogger : IGameEventListener
    {
        public void OnGameEvent(GameEvent gameEvent)
        {
            Console.WriteLine($"Event occurred: {gameEvent}");
        }
    }