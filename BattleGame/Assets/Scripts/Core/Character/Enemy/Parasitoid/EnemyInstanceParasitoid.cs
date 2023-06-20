using UnityEngine;

namespace Core.Character.Enemy.Parasitoid
{
    public class EnemyInstanceParasitoid : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private GameObject rupturePrefab;
        [SerializeField] private Transform container;
        [SerializeField] private int instanceNum;
        [SerializeField] private float spawnInterval;
        private float lastInstaceTime;
        private float spawnDistance = 5f;
        private GameObject[] existingEnemys;
        private EnemyRupture enemyRupture;

        private void Start()
        {
            lastInstaceTime = Time.time;

            GameObject enemyRuptureobj = new GameObject("EnemyRupture");
            enemyRupture = enemyRuptureobj.AddComponent<EnemyRupture>();
        }

        private void Update()
        {
            if (Time.time - lastInstaceTime <= spawnInterval) return;

            existingEnemys = GameObject.FindGameObjectsWithTag("Enemy");

            if (existingEnemys == null) return;
            if (existingEnemys.Length == 0) return;
            GameObject randomEnemy = existingEnemys[Random.Range(0, existingEnemys.Length)];

            for ( int i = 0 ; i < instanceNum ; i++ ) 
            {
                Vector3 spawnPosition = randomEnemy.transform.position + Random.insideUnitSphere * spawnDistance;

                Instantiate(prefab, spawnPosition, Quaternion.identity, container);

                EnemyAttribute.enemyInstanceCounter++;
            }

            enemyRupture.Rupture(rupturePrefab, randomEnemy, container);

            Destroy(randomEnemy);

            lastInstaceTime = Time.time;
        }         
    }
}
