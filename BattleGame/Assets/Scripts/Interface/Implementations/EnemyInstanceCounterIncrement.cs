using Core.Character.Enemy;
using Interface.Interfaces;

namespace Interface.Implementations
{
    public class EnemyInstanceCounterIncrement : IIncrement
    {

        private EnemyAttribute enemyAttribute;

        public void Increment()
        {
            enemyAttribute = new EnemyAttribute();
            enemyAttribute.InstanceCounter++;
        }
    }
}
