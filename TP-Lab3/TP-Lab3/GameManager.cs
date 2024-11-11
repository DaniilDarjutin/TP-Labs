using System;

public class GameManager
{
    private static GameManager _instance;

    private GameManager()
    {
        Console.WriteLine("GameManager создан.");
    }

    public static GameManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GameManager();
        }
        else
        {
            Console.WriteLine("Нельзя создать второй экземпляр GameManager.");
        }
        return _instance;
    }
}
