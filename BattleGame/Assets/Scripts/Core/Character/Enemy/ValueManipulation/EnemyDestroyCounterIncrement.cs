using Core.Character.Enemy;
using Interface.Interfaces;

namespace Interface.Implementations
{
    public class EnemyDestroyCounterIncrement : IIncrement
    {

        private EnemyAttribute enemyAttribute;

        public void Increment()
        {
            enemyAttribute = new EnemyAttribute();

            enemyAttribute.DestroyCounter++;
        }
    }
}