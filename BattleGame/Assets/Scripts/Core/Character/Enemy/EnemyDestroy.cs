using Core.Item;
using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyDestroy : MonoBehaviour
    {
        [SerializeField] float ruptureDamegeTime ;
        private float incrementTimer;
        private EnemyStatus enemyStatus;

        private void Start()
        {
            enemyStatus = GetComponent<EnemyStatus>();

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
        }
    }
}
