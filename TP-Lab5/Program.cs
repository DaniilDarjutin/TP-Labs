class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Strategy");
            Console.WriteLine(" ");
            Companion companion = new(new MeleeAttackStrategy());
            companion.Attack();
            companion.SetAttackStrategy(new MagicAttackStrategy());
            companion.Attack();
            Console.WriteLine(" ");

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine(" ");
            Console.WriteLine("Observer");
            Console.WriteLine(" ");
            GameEventPublisher publisher = new();
            GameLogger logger = new();
            publisher.Subscribe(GameEvent.GameStart, logger);
            publisher.Notify(GameEvent.GameStart);
            Console.WriteLine(" ");

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine(" ");
            Console.WriteLine("Chain of Responsibility");
            Console.WriteLine(" ");
            DamageHandler baseHandler = new BaseDamageHandler();
            DamageHandler criticalHandler = new CriticalDamageHandler();
            baseHandler.SetNext(criticalHandler);

            baseHandler.Handle(5);
            baseHandler.Handle(15);
            Console.WriteLine(" ");
        }
    }