using Interface.Interfaces;
using UnityEngine;

namespace Core.Character.Enemy.ValueManipulator
{
    public class EnemyInstanceCounterIncrement : IIncrement
    {

        private EnemyAttribute enemyAttribute;

        public void Increment()
        {
            enemyAttribute = GameObject.Find("EnemyManager").GetComponent<EnemyAttribute>();
            enemyAttribute.InstanceCounter++;
        }
    }
}
