using Core.Character.Enemy;
using UnityEngine;

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
