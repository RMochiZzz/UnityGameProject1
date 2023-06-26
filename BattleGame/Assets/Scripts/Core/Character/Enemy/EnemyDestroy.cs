using Core.Item.EventPublisher;
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
        private DropCoinEventPublisher publisher;
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
            publisher = new DropCoinEventPublisher();


            DestroyEnemy();

        }
        private void DestroyEnemy()
        {
            Destroy(gameObject);
            DecrementEnemyCounter();
            CoinDrop();
        }

        private void DecrementEnemyCounter()
        {
            enemyDestroyIncrementHandler.PerformDecrement(enemyDestroyCounterIncrement);
        }

        private void CoinDrop()
        {
            publisher.MyEvent += subscriber.HandleEvent;

            publisher.PublishEvent(dropPrefab, transform.position);

            publisher.MyEvent -= subscriber.HandleEvent;
        }
    }
}
