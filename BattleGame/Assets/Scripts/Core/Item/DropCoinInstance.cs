using Core.Character.Enemy;
using UnityEngine;

namespace Core.Item
{
    public class DropCoinInstance : MonoBehaviour
    {
        private EnemyInstanceStatus enemyInstanceStatus;
        public void Drop(GameObject dropPrefab, Transform dropPoint)
        {
            enemyInstanceStatus = GameObject.Find("EnemyManager").GetComponent<EnemyInstanceStatus>();

            Instantiate(dropPrefab, dropPoint.position, dropPoint.rotation);
            enemyInstanceStatus.DropCoinInstanceCounter++;
        }
    }
}
