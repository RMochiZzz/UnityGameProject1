using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyDelete : MonoBehaviour
    {
        [SerializeField] GameObject enemyController;
        [SerializeField] GameObject dropPrefab;
        [SerializeField] int eraseValue;
        [SerializeField] float ruptureDamegeTime ;
        private int hitCounter;
        private bool canIncrement;
        private float incrementTimer;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.gameObject.CompareTag("Bullet")) return;

            hitCounter++;

            if (hitCounter < eraseValue) return;

            DestroyEnemy();
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

            if (hitCounter > eraseValue)
            {
                DestroyEnemy();
            }
        }

        private void DestroyEnemy()
        {
            Destroy(gameObject);
            Destroy(enemyController);
            EnemyAttribute.enemyInstanceCounter--;

            Instantiate(dropPrefab, this.gameObject.transform.position, this.gameObject.transform.rotation);
            EnemyAttribute.dropCoinInstanceCounter++;
        }
    }
}
