using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyInstance2 : MonoBehaviour
    {
        [SerializeField] GameObject prefab;
        [SerializeField] GameObject rupturePrefab;
        [SerializeField] Transform container;
        [SerializeField] int instanceNum;
        [SerializeField] float spawnInterval;
        private float lastInstaceTime;
        private float spawnDistance = 5f;
        private GameObject[] existingEnemys;
        private EnemyRupture enemyRupture;

        private void Start()
        {
            lastInstaceTime = Time.time;

            GameObject enemyRuptureeobj = new GameObject("EnemyRupture");
            enemyRupture = enemyRuptureeobj.AddComponent<EnemyRupture>();

        }

        private void Update()
        {
            if (Time.time - lastInstaceTime <= spawnInterval) return;

            existingEnemys = GameObject.FindGameObjectsWithTag("Enemy");

            if (existingEnemys == null) return;
            GameObject randomEnemy = existingEnemys[Random.Range(0, existingEnemys.Length)];

            for ( int i = 0 ; i <= instanceNum ; i++ ) 
            {
                Vector3 spawnPosition = randomEnemy.transform.position + Random.insideUnitSphere * spawnDistance;

                GameObject obj = Instantiate(prefab, spawnPosition, Quaternion.identity, container);

                EnemyAttribute.enemyInstanceCounter++;
            }

            enemyRupture.Rupture(rupturePrefab, randomEnemy, container);

            Destroy(randomEnemy);

            lastInstaceTime = Time.time;
        }         
    }
}
