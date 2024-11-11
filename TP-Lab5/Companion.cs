public class Companion
    {
        private IAttackStrategy _attackStrategy;

        public Companion(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        public void SetAttackStrategy(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        public void Attack()
        {
            _attackStrategy.Attack();
        }
    }