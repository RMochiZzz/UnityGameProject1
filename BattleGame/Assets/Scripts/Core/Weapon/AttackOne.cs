using UnityEngine;
using System.Collections;

namespace Core.Weapon
{
    public class AttackOne : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private Transform container;
        [SerializeField] private int rapidFireNum;
        [SerializeField] private float fireInterval;
        [SerializeField] private float fireIntervalLong;
        private int fireCount;
        private Vector3 spawnAngle;
        private Vector3 spawnPointPosition;
        private Quaternion spawnPointRotation;

        public void Manager()
        {
            Init();
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
                    spawnPointPosition = spawnPoint.position;
                    spawnPointRotation = spawnPoint.rotation;

                    Instantiate(prefab, spawnPointPosition, spawnPointRotation, container);

                    yield return new WaitForSeconds(fireInterval);

                    fireCount++;
                }

                yield return new WaitForSeconds(fireIntervalLong);
            }
        }

        private void Rotation()
        {
            
             spawnAngle = spawnPoint.rotation.eulerAngles;
             spawnAngle.z = spawnAngle.z == 90f ? -90f : 90f;

             spawnPoint.rotation = Quaternion.Euler(spawnAngle);

             fireCount = 0;
        }

        private void Init()
        {
            spawnAngle = spawnPoint.rotation.eulerAngles;
            spawnAngle.z = 90f;
            spawnPoint.rotation = Quaternion.Euler(spawnAngle);
        }
    }
}