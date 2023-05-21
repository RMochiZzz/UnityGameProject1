using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyInstance : MonoBehaviour
    {
        public Camera mainCamera;
        public GameObject prefab;
        public float offsetX = 1f;
        public float offsetY = 1f;
        private float lastInstaceTime;

        void Start()
        {
            lastInstaceTime = Time.time;
            
        }

        void Update()
        {
            if (EnemyAttribute.enemyInstanceCounter <= EnemyAttribute.enemyMaxInstantiate)
            {
                if (Time.time - lastInstaceTime >= EnemyAttribute.spawnInterbal)
                {
                    Vector3 cameraPosition = mainCamera.transform.position;
                    float cameraHeight = 2f * mainCamera.orthographicSize;
                    float cameraWidth = cameraHeight * mainCamera.aspect;

                    float spawnX;
                    if (Random.value < 0.5f)
                    {
                        spawnX = Random.Range(cameraPosition.x - cameraWidth / 2f - offsetX, cameraPosition.x - cameraWidth / 2f);
                    }
                    else
                    {
                        spawnX = Random.Range(cameraPosition.x + cameraWidth / 2f + offsetX, cameraPosition.x + cameraWidth / 2f);
                    }

                    float spawnY;
                    if (Random.value < 0.5f)
                    {
                        spawnY = Random.Range(cameraPosition.y - cameraHeight / 2f - offsetX, cameraPosition.y - cameraHeight / 2f);
                    }
                    else
                    {
                        spawnY = Random.Range(cameraPosition.y + cameraHeight / 2f + offsetX, cameraPosition.y + cameraHeight / 2f);
                    }

                    Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);

                    Instantiate(prefab, spawnPosition, Quaternion.identity);

                    lastInstaceTime = Time.time;
                    EnemyAttribute.enemyInstanceCounter++;
                }
            }
        }
    }
}
