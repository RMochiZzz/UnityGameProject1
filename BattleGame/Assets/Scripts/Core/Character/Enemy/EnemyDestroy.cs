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
        private EnemyInstanceCounterDecrement enemyCounterDecrement;
        private EnemyInstanceDecrementHandler enemyInstanceDecrementHandler;
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

            enemyInstanceDecrementHandler = new EnemyInstanceDecrementHandler();
            enemyCounterDecrement = new EnemyInstanceCounterDecrement();
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
            enemyInstanceDecrementHandler.PerformDecrement(enemyCounterDecrement);
        }

        private void CoinDrop()
        {
            publisher.MyEvent += subscriber.HandleEvent;

            publisher.PublishEvent(dropPrefab, transform.position);

            publisher.MyEvent -= subscriber.HandleEvent;
        }
    }
}
