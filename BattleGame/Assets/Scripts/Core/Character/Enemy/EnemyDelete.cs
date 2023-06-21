using Core.Item;
using SceneManagement.Result;
using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyDelete : MonoBehaviour
    {
        [SerializeField] GameObject enemyController;
        [SerializeField] GameObject dropPrefab;
        [SerializeField] float ruptureDamegeTime ;
        private float incrementTimer;
        private DropCoinInstance dropCoinInstance;
        private EnemyStatus enemyStatus;
        private EnemyInstanceStatus enemyInstance;
        private ResultData resultData;
        private GameObject container;

        private void Start()
        {
            enemyStatus = GetComponent<EnemyStatus>();
            enemyInstance = GameObject.Find("EnemyManager").GetComponent<EnemyInstanceStatus>();
            container = GameObject.Find("Scripts");
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.gameObject.CompareTag("Bullet")) return;

            enemyStatus.HitCounter++;

            if (enemyStatus.HitCounter < enemyStatus.EnemyStamina) return;

            DestroyEnemy();
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (!collision.gameObject.CompareTag("Rupture")) return;

            incrementTimer += Time.deltaTime;

            if (incrementTimer >= ruptureDamegeTime)
            {
                enemyStatus.HitCounter++;
                incrementTimer = 0f;
            }

            if (enemyStatus.HitCounter > enemyStatus.EnemyStamina)
            {
                DestroyEnemy();
            }
        }

        private void DestroyEnemy()
        {
            Destroy(gameObject);
            enemyInstance.InstanceCounter--;

            DropItem();
        }

        private void DropItem()
        {
            
            dropCoinInstance = container.GetComponentInChildren<DropCoinInstance>();
            if (dropCoinInstance == null)
            {
                dropCoinInstance = container.AddComponent<DropCoinInstance>();
            }

            dropCoinInstance.Drop(dropPrefab, transform);
        }
    }
}
