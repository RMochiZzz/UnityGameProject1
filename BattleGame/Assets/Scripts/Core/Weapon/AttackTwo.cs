using UnityEngine;
using System.Collections;

namespace Core.Weapon
{
    public class AttackTwo : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private Transform container;
        [SerializeField] private float fireInterval;
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

                Rotation();

                spawnPointPosition = spawnPoint.position;
                spawnPointRotation = spawnPoint.rotation;

                Instantiate(prefab, spawnPointPosition, spawnPointRotation, container);

                yield return new WaitForSeconds(fireInterval);

            }
        }

        private void Rotation()
        {

            spawnAngle = spawnPoint.rotation.eulerAngles;
            spawnAngle.z = spawnAngle.z == 90f ? -90f : 90f;

            spawnPoint.rotation = Quaternion.Euler(spawnAngle);

        }

        private void Init()
        {
            spawnAngle = spawnPoint.rotation.eulerAngles;
            spawnAngle.z = 90f;
            spawnPoint.rotation = Quaternion.Euler(spawnAngle);
        }
    }
}