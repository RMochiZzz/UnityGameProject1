using Core.Item;
using Interface.Clients;
using Interface.Implementations;
using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyDestroy : MonoBehaviour
    {
        [SerializeField] private GameObject dropPrefab;
        private GameObject scriptContainer;
        private EnemyDestroyIncrementHandler enemyDestroyIncrementHandler;
        private EnemyDestroyCounterIncrement enemyDestroyCounterIncrement;
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
            enemyDestroyIncrementHandler.DestroyIncrement(enemyDestroyCounterIncrement);
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

            enemyDestroyIncrementHandler = new EnemyDestroyIncrementHandler();
            enemyDestroyCounterIncrement = new EnemyDestroyCounterIncrement();
        }
    }
}
