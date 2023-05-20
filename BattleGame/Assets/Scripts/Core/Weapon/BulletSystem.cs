using UnityEngine;
using Core.Weapon;


namespace Core.Weapon
{
    public class BulletSystem : MonoBehaviour
    {
        public GameObject bullet;
        public Transform bulletSpawnPoint;
        private float lastFireTime = 0;

        void Update()
        {

            if (Time.time - lastFireTime >= BulletAttribute.fireInterval && BulletAttribute.fireCount < 3)
            {

                Vector3 spawnPosition = bulletSpawnPoint.position;
                Quaternion spawnRotation = bulletSpawnPoint.rotation;

                //Rigidbody2D bulletInstance = 
                GameObject bulletInstance = Instantiate(bullet, spawnPosition, spawnRotation);

                //bulletInstance.velocity = bulletInstance.transform.right * BulletAttribute.bulletSpeed * Time.deltaTime;


                lastFireTime = Time.time;

                BulletAttribute.fireCount++;

            }
            else if (Time.time - lastFireTime >= BulletAttribute.fireIntervalLong)
            {
                Vector2 playerAngle = bulletSpawnPoint.rotation.eulerAngles;
                playerAngle.y = playerAngle.y == 0f ? 180f : 0f;

                bulletSpawnPoint.rotation = Quaternion.Euler(playerAngle);

                lastFireTime = Time.time;

                BulletAttribute.fireCount = 0;
            }
        }


    }
}