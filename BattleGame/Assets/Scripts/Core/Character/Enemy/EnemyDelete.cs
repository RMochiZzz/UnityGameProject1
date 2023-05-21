using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyDelete : MonoBehaviour
    {
        public GameObject enemyController;
        public GameObject bullet;
        private int hitCounter;

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Bullet")
            { 
                hitCounter++;

                Destroy(collision.gameObject);

                if (hitCounter == EnemyAttribute.eraseValue)
                {

                    Destroy(gameObject);
                    Destroy(enemyController);
                    EnemyAttribute.enemyInstanceCounter--;


                }
            }
            

        }
    }

}
