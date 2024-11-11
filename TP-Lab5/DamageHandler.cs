public abstract class DamageHandler
    {
        protected DamageHandler _next;

        public void SetNext(DamageHandler next)
        {
            _next = next;
        }

        public abstract void Handle(int damage);
    }

public class BaseDamageHandler : DamageHandler
    {
        public override void Handle(int damage)
        {
            if (damage <= 10)
            {
                Console.WriteLine("Base handler processes damage.");
            }
            else
            {
                _next.Handle(damage);
            }
        }
    }

public class CriticalDamageHandler : DamageHandler
    {
        public override void Handle(int damage)
        {
            Console.WriteLine("Critical damage handler processes damage!");
        }
    }