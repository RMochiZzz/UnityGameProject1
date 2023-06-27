using Core.Item;
using Core.Character.Enemy.ValueManipulator;
using Interface.Interfaces;
using UnityEngine;

namespace Core.Character.Enemy.Battle
{
    public class EnemyDestroy : MonoBehaviour
    {
        [SerializeField] private GameObject dropPrefab;
        private IIncrement enemyDestroyCounterIncrement;
        private DropCoinInstance dropCoinInstance;

        public void Starter()
        {

            Reference();

            DestroyEnemy();

            IncrementEnemyCounter();
            CoinDrop();

        }

        private void DestroyEnemy()
        {
            Destroy(gameObject);
        }

        private void IncrementEnemyCounter()
        {
            enemyDestroyCounterIncrement.Increment();
        }

        private void CoinDrop()
        {
            dropCoinInstance.Starter(dropPrefab, transform.position);
        }

        private void Reference()
        {
            dropCoinInstance = GetComponent<DropCoinInstance>();

            enemyDestroyCounterIncrement = new EnemyDestroyCounterIncrement();
        }
    }
}
