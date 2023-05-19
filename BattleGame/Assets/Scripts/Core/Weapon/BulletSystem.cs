using UnityEngine;
using Core.Weapon;


namespace Core.Weapon
{
    public class BulletSystem : MonoBehaviour
    {
        public Rigidbody2D Bullet;
        public Transform BulletSpawnPoint;
        private float lastFireTime = 0;

        void Update()
        {

            if (Time.time - lastFireTime >= BulletAttribute.fireInterval && BulletAttribute.fireCount < 3)
            {

                Vector2 spawnPosition = BulletSpawnPoint.position;
                Quaternion spawnRotation = BulletSpawnPoint.rotation;

                Rigidbody2D bulletInstance = Instantiate(Bullet, spawnPosition, spawnRotation);

                bulletInstance.velocity = bulletInstance.transform.right * BulletAttribute.bulletSpeed;

                lastFireTime = Time.time;

                BulletAttribute.fireCount++;

            }
            else if (Time.time - lastFireTime >= BulletAttribute.fireIntervalLong)
            {
                Vector2 bulletAngle = BulletSpawnPoint.rotation.eulerAngles;
                bulletAngle.y = bulletAngle.y == 0f ? 180f : 0f;
                BulletSpawnPoint.rotation = Quaternion.Euler(bulletAngle);
                lastFireTime = Time.time;
                BulletAttribute.fireCount = 0;
            }
        }


    }
}