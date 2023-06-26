using Interface.Clients;
using Interface.Implementations;
using Interface.Interfaces;
using UnityEngine;

namespace Core.Character.Enemy.Parasitoid
{
    public class EnemyInstanceParasitoid : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private GameObject rupturePrefab;
        [SerializeField] private int instanceNum;
        [SerializeField] private float spawnInterval;
        private float lastInstaceTime;
        private float spawnDistance = 5f;
        private GameObject[] existingEnemys;
        private EnemyRupture enemyRupture;
        private EnemyInstanceAttribute enemyInstance;
        private IIncrement increment;
        private EnemyInstanceIncrementHandler instanceIncrementHandler;

        private void Start()
        {
            increment = new EnemyInstanceCounterIncrement();
            instanceIncrementHandler = new EnemyInstanceIncrementHandler();

            enemyInstance = GetComponent<EnemyInstanceAttribute>();

            lastInstaceTime = Time.time;

            GameObject container = GameObject.Find("Scripts");
            enemyRupture = container.GetComponentInChildren<EnemyRupture>();
            if (enemyRupture == null)
            {
                enemyRupture = container.AddComponent<EnemyRupture>();
            }
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

                Instantiate(prefab, spawnPosition, Quaternion.identity, enemyInstance.Container);

                CounterIncrement();
            }

            enemyRupture.Rupture(rupturePrefab, randomEnemy, enemyInstance.Container);

            Destroy(randomEnemy);

            lastInstaceTime = Time.time;
        }

        private void CounterIncrement()
        {
            instanceIncrementHandler.InstanceIncrement(increment);
        }
    }
}
