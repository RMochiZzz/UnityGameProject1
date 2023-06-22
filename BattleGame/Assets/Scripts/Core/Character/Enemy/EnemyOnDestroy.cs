using Core.Item;
using Interface.Clients;
using Interface.Implementations;
using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyOnDestroy : MonoBehaviour
    {
        [SerializeField] private GameObject dropPrefab;
        [SerializeField] private DropCoinInstance dropCoinInstance;
        private GameObject scriptContainer;
        private EnemyInstanceCounterDecrement enemyCounterDecrement;
        private EnemyInstanceDecrementHandler enemyInstanceDecrementHandler;

        private void Start()
        {
            enemyInstanceDecrementHandler = new EnemyInstanceDecrementHandler();
            enemyCounterDecrement = new EnemyInstanceCounterDecrement();

            dropCoinInstance = scriptContainer.GetComponentInChildren<DropCoinInstance>();
            if (dropCoinInstance == null)
            {
                dropCoinInstance = scriptContainer.AddComponent<DropCoinInstance>();
            }
        }

        private void OnDestroy()
        {
            IncrementEnemyCounter();
            CoinDrop();
        }

        private void IncrementEnemyCounter()
        {
            enemyInstanceDecrementHandler.PerformDecrement(enemyCounterDecrement);
        }

        private void CoinDrop()
        {
            dropCoinInstance.Drop(dropPrefab, transform);
        }
    }
}
