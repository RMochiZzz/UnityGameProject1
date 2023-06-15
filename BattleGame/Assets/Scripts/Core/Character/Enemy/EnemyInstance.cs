using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyInstance : MonoBehaviour
    {
        [SerializeField] GameObject prefab;
        [SerializeField] Transform container;
        [SerializeField] float offsetX;
        [SerializeField] float offsetY;
        [SerializeField] int instanceMax;
        private float lastInstaceTime;

        void Start()
        {
            lastInstaceTime = Time.time;
        }

        void Update()
        {
            if (EnemyAttribute.enemyInstanceCounter >= instanceMax) return;
            if (Time.time - lastInstaceTime <= EnemyAttribute.spawnInterbal) return;
            
            Vector3 cameraPosition = Camera.main.transform.position;
            float cameraHeight = 2f * Camera.main.orthographicSize;
            float cameraWidth = cameraHeight * Camera.main.aspect;

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

            GameObject obj = Instantiate(prefab, spawnPosition, Quaternion.identity);
            obj.transform.parent = container;

            lastInstaceTime = Time.time;
            EnemyAttribute.enemyInstanceCounter++;
            
        }         
    }
}
