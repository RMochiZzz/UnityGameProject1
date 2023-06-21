using Core.Character.Enemy;
using UnityEngine;

namespace Core.Item
{
    public class DropCoinInstance : MonoBehaviour
    {
        private EnemyInstanceStatus enemyInstanceStatus;
        private GameObject container;
        public void Drop(GameObject dropPrefab, Transform dropPoint)
        {
            enemyInstanceStatus = GameObject.Find("EnemyManager").GetComponent<EnemyInstanceStatus>();
            container = GameObject.Find("Coins");

            Instantiate(dropPrefab, dropPoint.position, dropPoint.rotation, container.transform);
            enemyInstanceStatus.DropCoinInstanceCounter++;
        }
    }
}
