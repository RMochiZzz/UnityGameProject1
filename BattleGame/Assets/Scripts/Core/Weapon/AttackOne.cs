using UnityEngine;

namespace Core.Weapon
{
    public class AttackOne : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private Transform container;
        [SerializeField] private float instaceRepeatTime;
        [SerializeField] private int rapidFiringNum;
        [SerializeField] private int fireIntervalLong;
        private float lastInstantiateTime;
        private int fireCount;

        public void Manager()
        {
            InvokeRepeating(nameof(BulletInstace), instaceRepeatTime, instaceRepeatTime);
        }

        private void BulletInstace()
        {
            if (Time.time - lastInstantiateTime >= fireIntervalLong)
            {
                Rotation();
            }

            Vector3 spawnPointPosition = spawnPoint.position;
            Quaternion spawnPointRotation = spawnPoint.rotation;

            Instantiate(prefab, spawnPointPosition, spawnPointRotation, container);

            lastInstantiateTime = Time.time;

            fireCount++;
            
        }

        private void Rotation()
        {
            
             Vector2 spawnAngle = spawnPoint.rotation.eulerAngles;
             spawnAngle.y = spawnAngle.y == 0f ? 180f : 0f;

             spawnPoint.rotation = Quaternion.Euler(spawnAngle);

             lastInstantiateTime = Time.time;

             fireCount = 0;
            
        }
    }
}