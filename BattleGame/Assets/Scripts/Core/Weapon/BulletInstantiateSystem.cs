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

            //if(!BulletAttribute.levelOneIsActive) return;


            if (Time.time - lastInstantiateTime >= BulletAttribute.fireIntervalLong)
            {
                Rotation();
            }


            if (Time.time - lastInstantiateTime <= BulletAttribute.fireInterval) return;
            if (BulletAttribute.fireCount > BulletAttribute.rapidFiringCount) return;

            Vector3 spawnPointPosition = spawnPoint.position;
            Quaternion spawnPointRotation = spawnPoint.rotation;

            Instantiate(prefab, spawnPointPosition, spawnPointRotation);

            lastInstantiateTime = Time.time;

            BulletAttribute.fireCount++;
            
        }

        public void Rotation()
        {
            
             Vector2 spawnAngle = spawnPoint.rotation.eulerAngles;
             spawnAngle.y = spawnAngle.y == 0f ? 180f : 0f;

             spawnPoint.rotation = Quaternion.Euler(spawnAngle);

             lastInstantiateTime = Time.time;

             BulletAttribute.fireCount = 0;
            
        }
    }
}