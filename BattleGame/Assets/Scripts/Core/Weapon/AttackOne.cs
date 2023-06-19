using UnityEngine;
using System.Collections;
using static UnityEditor.Sprites.Packer;

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
        private bool execution;
        public bool Execution
        { get { return execution; } set { execution = value; } }

        public void starter()
        {
            Init();
            execution = true;
            StartCoroutine(BulletInstanceRoutine());
        }

        private IEnumerator BulletInstanceRoutine()
        {

            while (execution)
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