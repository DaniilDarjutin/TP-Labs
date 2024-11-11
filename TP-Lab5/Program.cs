class Program
    {
        static void Main(string[] args)
        {
            // Демонстрация паттерна Strategy
            Companion companion = new(new MeleeAttackStrategy());
            companion.Attack();
            companion.SetAttackStrategy(new MagicAttackStrategy());
            companion.Attack();

            // Демонстрация паттерна Observer
            GameEventPublisher publisher = new();
            GameLogger logger = new();
            publisher.Subscribe(GameEvent.GameStart, logger);
            publisher.Notify(GameEvent.GameStart);

            // Демонстрация паттерна Chain of Responsibility
            DamageHandler baseHandler = new BaseDamageHandler();
            DamageHandler criticalHandler = new CriticalDamageHandler();
            baseHandler.SetNext(criticalHandler);

            baseHandler.Handle(5);
            baseHandler.Handle(15);
        }
    }