using Core.Character.Enemy;
using Interface.Interfaces;

namespace Interface.Implementations
{
    public class EnemyInstanceCounterDecrement : IDecrement
    {

        private EnemyAttribute enemyAttribute;

        public void Decrement()
        {
            enemyAttribute = new EnemyAttribute();

            enemyAttribute.InstanceCounter--;
        }
    }
}
