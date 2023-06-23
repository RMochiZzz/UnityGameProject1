using Core.Character.Enemy;
using Interface.Interfaces;
using UnityEngine;

namespace Interface.Implementations
{
    public class EnemyInstanceCounterIncrement : IIncrement
    {

        private EnemyInstanceStatus enemyInstance;

        public void Increment()
        {
            enemyInstance = GameObject.Find("EnemyManager").GetComponent<EnemyInstanceStatus>();

            enemyInstance.InstanceCounter++;
        }
    }
}
