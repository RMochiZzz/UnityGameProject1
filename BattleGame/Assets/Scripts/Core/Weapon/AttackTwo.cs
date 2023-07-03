using UnityEngine;
using System.Collections;
using Interface.Interfaces;

namespace Core.Weapon
{
    public class AttackTwo : MonoBehaviour, IBulletFactory
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private Transform container;
        [SerializeField] private float fireInterval;

        private Vector3 spawnAngle;
        private Vector3 spawnPointPosition;
        private Quaternion spawnPointRotation;
        private bool execution;
        public bool Execution
        { get { return execution; } set { execution = value; } }

        public void Starter()
        {
            Init();
            execution = true;
            StartCoroutine(BulletInstanceRoutine());
        }

        private void OnEnable()
        {
            Init();
        }

        private IEnumerator BulletInstanceRoutine()
        {
            while (execution)
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