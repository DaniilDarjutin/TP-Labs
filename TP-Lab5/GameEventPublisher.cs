public class GameEventPublisher
    {
        private readonly Dictionary<GameEvent, List<IGameEventListener>> _listeners = new();

        public void Subscribe(GameEvent gameEvent, IGameEventListener listener)
        {
            if (!_listeners.ContainsKey(gameEvent))
            {
                _listeners[gameEvent] = new List<IGameEventListener>();
            }

            _listeners[gameEvent].Add(listener);
        }

        public void Notify(GameEvent gameEvent)
        {
            if (_listeners.ContainsKey(gameEvent))
            {
                foreach (var listener in _listeners[gameEvent])
                {
                    listener.OnGameEvent(gameEvent);
                }
            }
        }
    }