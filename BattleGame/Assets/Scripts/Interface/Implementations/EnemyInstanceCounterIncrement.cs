using Core.Character.Enemy;
using UnityEngine;

namespace Interface.Implementations
{
    public class EnemyInstanceCounterIncrement : Iincrement
    {

        private EnemyInstanceStatus enemyInstance;

        public void Increment()
        {
            enemyInstance = GameObject.Find("EnemyManager").GetComponent<EnemyInstanceStatus>();

            enemyInstance.InstanceCounter++;
        }
    }
}
