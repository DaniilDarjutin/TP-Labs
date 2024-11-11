public class GoblinFactory : EnemyFactory
{
    public override Enemy CreateEnemy()
    {
        return new Goblin();
    }
}