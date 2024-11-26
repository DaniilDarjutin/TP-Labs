
// Singleton

public class GameLogger
{
    private static GameLogger _instance;

    private GameLogger() { }

    public static GameLogger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GameLogger();
        }
        return _instance;
    }
}
