using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyDamage : MonoBehaviour
    {
        [SerializeField] float ruptureDamegeTime ;

        private float incrementTimer;
        private int hitCounter;

        private EnemyStatus enemyStatus;
        private EnemyDestroy enemyDestroy;

        private void Start()
        {
            Reference();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.gameObject.CompareTag("Bullet")) return;

            hitCounter++;

            if (hitCounter < enemyStatus.EnemyStamina) return;

            enemyDestroy.Starter();
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (!collision.gameObject.CompareTag("Rupture")) return;

            incrementTimer += Time.deltaTime;

            if (incrementTimer >= ruptureDamegeTime)
            {
                hitCounter++;
                incrementTimer = 0f;
            }

            if (hitCounter > enemyStatus.EnemyStamina)
            {
                enemyDestroy.Starter();
            }
        }

        private void Reference()
        {
            enemyStatus = GetComponent<EnemyStatus>();
            enemyDestroy = GetComponent<EnemyDestroy>();
        }
    }
}
