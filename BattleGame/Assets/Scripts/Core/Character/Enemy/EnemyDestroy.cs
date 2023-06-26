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

            dropCoinInstance = FindObjectOfType<DropCoinInstance>();
            if (dropCoinInstance == null)
            {
                GameObject subscriberObj = new GameObject("DropCoinInstance");
                dropCoinInstance = subscriberObj.AddComponent<DropCoinInstance>();
            }

            enemyDestroyIncrementHandler = new EnemyDestroyIncrementHandler();
            enemyDestroyCounterIncrement = new EnemyDestroyCounterIncrement();

            DestroyEnemy();

        }
        private void DestroyEnemy()
        {
            Destroy(gameObject);
            IncrementEnemyCounter();
            CoinDrop();
        }

        private void IncrementEnemyCounter()
        {
            enemyDestroyIncrementHandler.DestroyIncrement(enemyDestroyCounterIncrement);
        }

        private void CoinDrop()
        {
            dropCoinInstance.Starter(dropPrefab, transform.position);
        }
    }
}
