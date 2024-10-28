using System.Collections.Generic;

public interface IPlayerProfileRepository
{
    PlayerProfile GetProfile(string name);
    void UpdateHighScore(string name, int score);
}

public class PlayerProfile
{
    public string Name { get; set; }
    public int Score { get; set; }
}

public class PlayerProfileDBRepository : IPlayerProfileRepository
{
    private Dictionary<string, PlayerProfile> profiles = new Dictionary<string, PlayerProfile>();

    public PlayerProfile GetProfile(string name)
    {
        if (!profiles.ContainsKey(name))
        {
            profiles[name] = new PlayerProfile { Name = name, Score = 0 };
        }
        return profiles[name];
    }

    public void UpdateHighScore(string name, int score)
    {
        if (profiles.ContainsKey(name))
        {
            profiles[name].Score = score;
        }
    }
}

public class PlayerProfileCacheRepository : IPlayerProfileRepository
{
    private readonly PlayerProfileDBRepository _dbRepository = new PlayerProfileDBRepository();
    private readonly Dictionary<string, PlayerProfile> _cache = new Dictionary<string, PlayerProfile>();

    public PlayerProfile GetProfile(string name)
    {
        if (!_cache.ContainsKey(name))
        {
            Console.WriteLine("Загрузка профиля из БД...");
            _cache[name] = _dbRepository.GetProfile(name);
        }
        return _cache[name];
    }

    public void UpdateHighScore(string name, int score)
    {
        if (_cache.ContainsKey(name))
        {
            _cache[name].Score = score;
        }
        _dbRepository.UpdateHighScore(name, score);
    }
}
