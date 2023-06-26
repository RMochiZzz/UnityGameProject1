using UnityEngine;
using System.Collections;
using Interface.Interfaces;

namespace Core.Weapon
{
    public class AttackThree : MonoBehaviour, IBulletFactory
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private Transform container;
        [SerializeField] private float fireInterval;
        [SerializeField] private float angleOfRotation;

        private Vector3 spawnAngle;
        private Vector3 spawnPointPosition;
        private Quaternion spawnPointRotation;
        private bool execution;
        public bool Execution
        { get { return execution; } set {  execution = value; } }

        public void Starter()
        {
            Init();
            execution = true;
            StartCoroutine(BulletInstanceRoutine());
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
            spawnAngle.z += angleOfRotation;

            spawnPoint.rotation = Quaternion.Euler(spawnAngle);

            if (spawnAngle.z != 360) return;
            spawnAngle.z = 0;
        }

        private void Init()
        {
            spawnAngle = spawnPoint.rotation.eulerAngles;
            spawnAngle.z = 0f;
            spawnPoint.rotation = Quaternion.Euler(spawnAngle);
        }
    }
}