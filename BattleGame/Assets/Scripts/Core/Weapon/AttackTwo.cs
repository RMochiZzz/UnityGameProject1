using UnityEngine;
using System.Collections;

namespace Core.Weapon
{
    public class AttackTwo : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private Transform container;
        [SerializeField] private int rapidFireNum;
        [SerializeField] private float fireInterval;
        [SerializeField] private float fireIntervalLong;
        private int fireCount;

        public void Manager()
        {
            StartCoroutine(BulletInstanceRoutine());
        }

        private IEnumerator BulletInstanceRoutine()
        {
            while (true)
            {
                if (fireCount == rapidFireNum)
                {
                    Rotation();
                }

                

                for (int i = 0; i < rapidFireNum; i++)
                {
                    Vector3 spawnPointPosition = spawnPoint.position;
                    Quaternion spawnPointRotation = spawnPoint.rotation;

                    Instantiate(prefab, spawnPointPosition, spawnPointRotation, container);

                    yield return new WaitForSeconds(fireInterval);

                    fireCount++;
                }

                yield return new WaitForSeconds(fireIntervalLong);
            }
        }

        private void Rotation()
        {
            
             Vector2 spawnAngle = spawnPoint.rotation.eulerAngles;
             spawnAngle.y = spawnAngle.y == 0f ? 180f : 0f;

             spawnPoint.rotation = Quaternion.Euler(spawnAngle);

             fireCount = 0;
        }
    }
}