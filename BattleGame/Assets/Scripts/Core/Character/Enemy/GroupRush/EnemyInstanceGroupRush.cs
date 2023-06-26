using UnityEngine;

namespace Core.Character.Enemy.GroupRush
{
    public class EnemyInstanceGroupRush : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private float spawnPointOffsetX;
        [SerializeField] private float spawnPointOffsetY;
        [SerializeField] private int instanceNum;
        [SerializeField] private float spawnInterval;
        private float lastInstaceTime;
        private float spawnDistance = 5f;
        private EnemyInstanceStatus enemyInstanceStatus;
        private EnemyAttribute enemyAttribute;

        void Start()
        {
            enemyInstanceStatus = GetComponent<EnemyInstanceStatus>();
            enemyAttribute = new EnemyAttribute();
            lastInstaceTime = Time.time;
        }

        void Update()
        {
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

            GameObject obj = Instantiate(prefab, spawnPosition, Quaternion.identity, enemyInstanceStatus.Container);
            enemyAttribute.InstanceCounter++;

            for (int i = 0; i <= instanceNum; i++)
            {
                spawnPosition = obj.transform.position + Random.insideUnitSphere * spawnDistance;

                Instantiate(prefab, spawnPosition, Quaternion.identity, enemyInstanceStatus.Container);

                enemyAttribute.InstanceCounter++;
            }

            lastInstaceTime = Time.time;
 
        }         
    }
}
