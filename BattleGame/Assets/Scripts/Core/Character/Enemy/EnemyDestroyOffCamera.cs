using Interface.Clients;
using Interface.Implementations;
using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyDestroyOffCamera : MonoBehaviour
    {
        private EnemyDestroyIncrementHandler enemyDestroyIncrementHandler;
        private EnemyDestroyCounterIncrement enemyDestroyCounterIncrement;

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
            enemyDestroyIncrementHandler.DestroyIncrement(enemyDestroyCounterIncrement);
        }

        private void Reference()
        {
            enemyDestroyIncrementHandler = new EnemyDestroyIncrementHandler();
            enemyDestroyCounterIncrement = new EnemyDestroyCounterIncrement();
        }
    }
}
