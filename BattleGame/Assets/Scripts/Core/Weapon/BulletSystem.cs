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

            if (Time.time - lastFireTime >= Core.Weapon.BulletAttribute.fireInterval && Core.Weapon.BulletAttribute.fireCount < 3)
            {

                Vector2 spawnPosition = BulletSpawnPoint.position;
                Quaternion spawnRotation = BulletSpawnPoint.rotation;

                Rigidbody2D bulletInstance = Instantiate(Bullet, spawnPosition, spawnRotation);

                bulletInstance.velocity = bulletInstance.transform.right * Core.Weapon.BulletAttribute.bulletSpeed;

                lastFireTime = Time.time;

                Core.Weapon.BulletAttribute.fireCount += 1;

            }
            else if (Time.time - lastFireTime >= Core.Weapon.BulletAttribute.fireIntervalLong)
            {

                lastFireTime = Time.time;
                Core.Weapon.BulletAttribute.fireCount = 0;
            }
        }


    }
}
