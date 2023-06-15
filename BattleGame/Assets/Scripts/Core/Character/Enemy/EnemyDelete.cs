using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyDelete : MonoBehaviour
    {
        [SerializeField] GameObject enemyController;
        [SerializeField] GameObject dropPrefab;
        private int hitCounter;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.gameObject.CompareTag("Bullet")) return;
            
            hitCounter++;

            if (hitCounter < EnemyAttribute.eraseValue) return;
               
            Destroy(gameObject);
            Destroy(enemyController);
            EnemyAttribute.enemyInstanceCounter--;

            Instantiate(dropPrefab, this.gameObject.transform.position, this.gameObject.transform.rotation);
            EnemyAttribute.dropCoinInstanceCounter++;    
            
        }
    }
}
