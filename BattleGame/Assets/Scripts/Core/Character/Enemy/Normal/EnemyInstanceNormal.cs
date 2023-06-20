using UnityEngine;

namespace Core.Character.Enemy.Normal
{
    public class EnemyInstanceNormal : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private float spawnPointOffsetX;
        [SerializeField] private float spawnPointOffsetY;
        [SerializeField] private float spawnInterval;
        private float lastInstaceTime;
        private EnemyInstanceStatus enemyInstanceStatus;

        void Start()
        {
            enemyInstanceStatus = GetComponent<EnemyInstanceStatus>();
            lastInstaceTime = Time.time;
        }

        void Update()
        {
            if (enemyInstanceStatus.InstanceCounter >= enemyInstanceStatus.InstanceMax) return;
            if (Time.time - lastInstaceTime <= spawnInterval) return;
            
            Vector3 cameraPosition = Camera.main.transform.position;
            float cameraHeight = 2f * Camera.main.orthographicSize;
            float cameraWidth = cameraHeight * Camera.main.aspect;

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

            Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);

            Instantiate(prefab, spawnPosition, Quaternion.identity, enemyInstanceStatus.Container);

            lastInstaceTime = Time.time;
            enemyInstanceStatus.InstanceCounter++;
            
        }         
    }
}
