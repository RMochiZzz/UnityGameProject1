using Core.Other;
using Interface.Implementations;
using Interface.Interfaces;
using UnityEngine;

namespace Core.Character.Enemy.Normal
{
    public class EnemyInstanceNormal : MonoBehaviour, IEnemyFactory
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private float spawnPointOffsetX;
        [SerializeField] private float spawnPointOffsetY;
        [SerializeField] private float spawnInterval;

        private float lastInstaceTime;
        private Vector3 cameraPosition;
        private Vector3 spawnPosition;

        private EnemyInstanceAttribute enemyInstance;
        private IIncrement enemyDestroyCounterIncrement;

        private void Start()
        {
            Init();
            Reference();
        }

        private void Update()
        {
            if (Time.time - lastInstaceTime <= spawnInterval) return;
            GetPosition();
            Instantiate();
            CounterIncrement();
            Init();
        }

        private void GetPosition()
        {
            cameraPosition = Camera.main.transform.position;

            float spawnX;
            if (Random.value < 0.5f)
            {
                spawnX = Random.Range(cameraPosition.x - CameraAttribute.cameraWidth / 2f - spawnPointOffsetX, cameraPosition.x - CameraAttribute.cameraWidth / 2f);
            }
            else
            {
                spawnX = Random.Range(cameraPosition.x + CameraAttribute.cameraWidth / 2f + spawnPointOffsetX, cameraPosition.x + CameraAttribute.cameraWidth / 2f);
            }

            float spawnY;
            if (Random.value < 0.5f)
            {
                spawnY = Random.Range(cameraPosition.y - CameraAttribute.cameraHeight / 2f - spawnPointOffsetY, cameraPosition.y - CameraAttribute.cameraHeight / 2f);
            }
            else
            {
                spawnY = Random.Range(cameraPosition.y + CameraAttribute.cameraHeight / 2f + spawnPointOffsetY, cameraPosition.y + CameraAttribute.cameraHeight / 2f);
            }

            spawnPosition = new Vector3(spawnX, spawnY, 0f);
        }

        public void Instantiate()
        {
            Instantiate(prefab, spawnPosition, Quaternion.identity, enemyInstance.Container);
        }

        public void CounterIncrement()
        {
            enemyDestroyCounterIncrement.Increment();
        }

        private void Init()
        {
            lastInstaceTime = Time.time;
        }

        public void Reference()
        {
            enemyDestroyCounterIncrement = new EnemyInstanceCounterIncrement();
            
            enemyInstance = GetComponent<EnemyInstanceAttribute>();
        }
    }
}
