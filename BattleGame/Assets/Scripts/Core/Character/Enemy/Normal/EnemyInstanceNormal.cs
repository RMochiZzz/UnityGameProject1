using Interface.Clients;
using Interface.Implementations;
using Interface.Interfaces;
using UnityEngine;

namespace Core.Character.Enemy.Normal
{
    public class EnemyInstanceNormal : MonoBehaviour, IEnemy
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private float spawnPointOffsetX;
        [SerializeField] private float spawnPointOffsetY;
        [SerializeField] private float spawnInterval;

        private float lastInstaceTime;
        private Vector3 cameraPosition;
        private float cameraHeight;
        private float cameraWidth;
        private Vector3 spawnPosition;

        private EnemyInstanceAttribute enemyInstance;
        private IIncrement increment;
        private EnemyInstanceIncrementHandler instanceIncrementHandler;


        void Start()
        {
            Init();
            Reference();
        }

        void Update()
        {
            if (Time.time - lastInstaceTime <= spawnInterval) return;
            GetPosition();
            Instantiate();
            CounterIncrement();
            Init();
        }

        private void GetPosition()
        {
            float spawnX;
            if (Random.value < 0.5f)
            {
                spawnX = Random.Range(cameraPosition.x - cameraWidth / 2f - spawnPointOffsetX, cameraPosition.x - cameraWidth / 2f);
            }
            else
            {
                spawnX = Random.Range(cameraPosition.x + cameraWidth / 2f + spawnPointOffsetX, cameraPosition.x + cameraWidth / 2f);
            }

            float spawnY;
            if (Random.value < 0.5f)
            {
                spawnY = Random.Range(cameraPosition.y - cameraHeight / 2f - spawnPointOffsetY, cameraPosition.y - cameraHeight / 2f);
            }
            else
            {
                spawnY = Random.Range(cameraPosition.y + cameraHeight / 2f + spawnPointOffsetY, cameraPosition.y + cameraHeight / 2f);
            }

            spawnPosition = new Vector3(spawnX, spawnY, 0f);
        }

        private void Instantiate()
        {
            Instantiate(prefab, spawnPosition, Quaternion.identity, enemyInstance.Container);
        }

        public void CounterIncrement()
        {
            instanceIncrementHandler.InstanceIncrement(increment);
        }

        private void Init()
        {
            lastInstaceTime = Time.time;

            cameraPosition = Camera.main.transform.position;
            cameraHeight = 2f * Camera.main.orthographicSize;
            cameraWidth = cameraHeight * Camera.main.aspect;
        }

        public void Reference()
        {
            increment = new EnemyInstanceCounterIncrement();
            instanceIncrementHandler = new EnemyInstanceIncrementHandler();

            enemyInstance = GetComponent<EnemyInstanceAttribute>();
        }
    }
}
