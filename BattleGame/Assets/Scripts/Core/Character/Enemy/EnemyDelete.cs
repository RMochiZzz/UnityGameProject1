using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyDelete : MonoBehaviour
    {

        public GameObject Enemy;
        public GameObject Bullet;
        public int hitCounter;
        public int eraseValue = 3;

        private void OnCollisionEnter2D(Collision2D collision)
        {

            GameObject Bullet = collision.gameObject;

            hitCounter += 1;

            Destroy(Bullet);

            if (hitCounter == eraseValue)
            {

                Destroy(Enemy);

            }

        }
    }

}
