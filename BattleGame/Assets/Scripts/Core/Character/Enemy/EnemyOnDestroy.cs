using Core.Item;
using Interface.Clients;
using Interface.Implementations;
using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyOnDestroy : MonoBehaviour
    {
        [SerializeField] private GameObject dropPrefab;
        private GameObject scriptContainer;
        private EnemyInstanceCounterDecrement enemyCounterDecrement;
        private EnemyInstanceDecrementHandler enemyInstanceDecrementHandler;
        private DropCoinEventPublisher publisher;
        private DropCoinInstance subscriber;

        private void Start()
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

        }

        private void OnDestroy()
        {
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
