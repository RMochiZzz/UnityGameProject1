using Interface.Interfaces;

namespace Core.Character.Enemy.ValueManipulator
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
