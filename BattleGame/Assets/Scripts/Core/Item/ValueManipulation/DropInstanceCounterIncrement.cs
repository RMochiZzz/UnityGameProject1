using Core.Character.Enemy;
using Interface.Interfaces;
using UnityEngine;

namespace Core.Character.Item.ValueManipulator
{
    public class DropInstanceCounterIncrement : IIncrement
    {

        private EnemyAttribute enemyAttribute;

        public void Increment()
        {
            enemyAttribute = GameObject.Find("EnemyManager").GetComponent<EnemyAttribute>();
            enemyAttribute.DropCoinInstanceCounter++;
        }
    }
}
