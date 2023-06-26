using Core.Item;
using Interface.Implementations;
using Interface.Interfaces;
using UnityEngine;

namespace Core.Character.Enemy.Battle
{
    public class EnemyDestroy : MonoBehaviour
    {
        [SerializeField] private GameObject dropPrefab;
        private GameObject scriptContainer;
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
            dropCoinInstance = FindObjectOfType<DropCoinInstance>();
            if (dropCoinInstance == null)
            {
                GameObject subscriberObj = new GameObject("DropCoinInstance");
                dropCoinInstance = subscriberObj.AddComponent<DropCoinInstance>();
            }

            enemyDestroyCounterIncrement = new EnemyDestroyCounterIncrement();
        }
    }
}
