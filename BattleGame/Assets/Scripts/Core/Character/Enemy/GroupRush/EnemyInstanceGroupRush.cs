using Core.Other;
using Core.Character.Enemy.ValueManipulator;
using Interface.Interfaces;
using UnityEngine;

namespace Core.Character.Enemy.GroupRush
{
    public class EnemyInstanceGroupRush : MonoBehaviour, IEnemyFactory
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private float spawnPointOffsetX;
        [SerializeField] private float spawnPointOffsetY;
        [SerializeField] private int instanceNum;
        [SerializeField] private float spawnInterval;

        private float lastInstaceTime;
        private float spawnDistance = 5f;
        private Vector3 cameraPosition;
        private Vector3 spawnPosition;

        private EnemyInstanceAttribute enemyInstance;
        private IIncrement enemyDestroyCounterIncrement;


        private void Start()
        {
            Init();
            Reference();
        }

        private void OnEnable()
        {
            Init();
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
                spawnY = Random.Range(cameraPosition.y - CameraAttribute.cameraHeight / 2f - spawnPointOffsetX, cameraPosition.y - CameraAttribute.cameraHeight / 2f);
            }
            else
            {
                spawnY = Random.Range(cameraPosition.y + CameraAttribute.cameraHeight / 2f + spawnPointOffsetX, cameraPosition.y + CameraAttribute.cameraHeight / 2f);
            }

            spawnPosition = new Vector3(spawnX, spawnY, 0f);
        }

        public void Instantiate()
        {
            GameObject obj = Instantiate(prefab, spawnPosition, Quaternion.identity, enemyInstance.Container);
            CounterIncrement();

            for (int i = 0; i <= instanceNum; i++)
            {
                spawnPosition = obj.transform.position + Random.insideUnitSphere * spawnDistance;

                Instantiate(prefab, spawnPosition, Quaternion.identity, enemyInstance.Container);

                CounterIncrement();
            }
        }

        public void CounterIncrement()
        {
            enemyDestroyCounterIncrement.Increment();
        }

        public void Init()
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
