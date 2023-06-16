using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyInstanceGroupRush : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform container;
        [SerializeField] private float spawnPointOffsetX;
        [SerializeField] private float spawnPointoffsetY;
        [SerializeField] private int instanceMax;
        [SerializeField] private int instanceNum;
        [SerializeField] private float spawnInterval;
        private float lastInstaceTime;
        private float spawnDistance = 5f;


        void Start()
        {
            lastInstaceTime = Time.time;
        }

        void Update()
        {
            if (EnemyAttribute.enemyInstanceCounter >= instanceMax) return;
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
                spawnY = Random.Range(cameraPosition.y - cameraHeight / 2f - spawnPointOffsetX, cameraPosition.y - cameraHeight / 2f);
            }
            else
            {
                spawnY = Random.Range(cameraPosition.y + cameraHeight / 2f + spawnPointOffsetX, cameraPosition.y + cameraHeight / 2f);
            }

            Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);

            GameObject obj = Instantiate(prefab, spawnPosition, Quaternion.identity, container);
            EnemyAttribute.enemyInstanceCounter++;

            for (int i = 0; i <= instanceNum; i++)
            {
                spawnPosition = obj.transform.position + Random.insideUnitSphere * spawnDistance;

                Instantiate(prefab, spawnPosition, Quaternion.identity, container);

                EnemyAttribute.enemyInstanceCounter++;
            }

            lastInstaceTime = Time.time;

            
        }         
    }
}
