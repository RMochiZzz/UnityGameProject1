using Interface.Interfaces;

namespace Core.Character.Enemy.ValueManipulator
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
