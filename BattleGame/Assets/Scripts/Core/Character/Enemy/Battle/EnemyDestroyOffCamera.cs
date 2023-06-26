using Interface.Implementations;
using Interface.Interfaces;
using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyDestroyOffCamera : MonoBehaviour
    {
        private IIncrement enemyDestroyCounterIncrement;

        public void Starter()
        {

            Reference();

            DestroyEnemy();

            IncrementEnemyCounter();

        }

        private void DestroyEnemy()
        {
            Destroy(gameObject);
        }

        private void IncrementEnemyCounter()
        {
            enemyDestroyCounterIncrement.Increment();
        }

        private void Reference()
        {
            enemyDestroyCounterIncrement = new EnemyDestroyCounterIncrement();
        }
    }
}
