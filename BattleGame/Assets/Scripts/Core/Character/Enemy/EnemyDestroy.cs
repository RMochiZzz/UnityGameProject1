using Core.Item.EventSubscriber;
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
        private DropCoinInstance subscriber;

        public void Starter()
        {

            subscriber = FindObjectOfType<DropCoinInstance>();
            if (subscriber == null)
            {
                GameObject subscriberObj = new GameObject("DropCoinInstance");
                subscriber = subscriberObj.AddComponent<DropCoinInstance>();
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
            subscriber.Starter(dropPrefab, transform.position);
        }
    }
}
