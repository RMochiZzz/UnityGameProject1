using Core.Character.Enemy;
using Interface.Interfaces;

namespace Core.Character.Item.ValueManipulator
{
    public class DropInstanceCounterIncrement : IIncrement
    {

        private EnemyAttribute enemyAttribute;

        public void Increment()
        {
            enemyAttribute = new EnemyAttribute();
            enemyAttribute.DropCoinInstanceCounter++;
        }
    }
}
