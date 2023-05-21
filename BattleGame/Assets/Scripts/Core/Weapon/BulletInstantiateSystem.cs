using UnityEngine;

namespace Core.Weapon
{
    public class BulletInstantiateSystem : MonoBehaviour
    {
        public GameObject prefab;
        public Transform spawnPoint;
        private float lastInstantiateTime = 0;

        void Update()
        {

            if (Time.time - lastInstantiateTime >= BulletAttribute.fireInterval && BulletAttribute.fireCount < BulletAttribute.rapidFiringCount)
            {

                Vector3 spawnPointPosition = spawnPoint.position;
                Quaternion spawnPointRotation = spawnPoint.rotation;

                Instantiate(prefab, spawnPointPosition, spawnPointRotation);

                lastInstantiateTime = Time.time;

                BulletAttribute.fireCount++;

            }
            else if (Time.time - lastInstantiateTime >= BulletAttribute.fireIntervalLong)
            {
                Vector2 sapawnAngle = spawnPoint.rotation.eulerAngles;
                sapawnAngle.y = sapawnAngle.y == 0f ? 180f : 0f;

                spawnPoint.rotation = Quaternion.Euler(sapawnAngle);

                lastInstantiateTime = Time.time;

                BulletAttribute.fireCount = 0;
            }
        }
    }
}