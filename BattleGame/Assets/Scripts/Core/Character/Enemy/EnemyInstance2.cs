using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyInstance2 : MonoBehaviour
    {
        [SerializeField] GameObject prefab;
        [SerializeField] GameObject rupturePrefab;
        [SerializeField] Transform container;
        [SerializeField] int instanceNum;
        [SerializeField] float spawnInterbal;
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
            if (Time.time - lastInstaceTime <= spawnInterbal) return;

            existingEnemys = GameObject.FindGameObjectsWithTag("Enemy");

            GameObject randomEnemy = existingEnemys[Random.Range(0, existingEnemys.Length)];

            for ( int i = 0 ; i <= instanceNum ; i++ ) 
            {
                Vector3 spawnPosition = randomEnemy.transform.position + Random.insideUnitSphere * spawnDistance;

                GameObject obj = Instantiate(prefab, spawnPosition, Quaternion.identity);
                obj.transform.parent = container;

                EnemyAttribute.enemyInstanceCounter++;
            }

            EnemyRupture.Rupture(rupturePrefab);

            lastInstaceTime = Time.time;

            
        }         
    }
}
