using Core.Character.Enemy;
using UnityEngine;

namespace Core.Item
{
    public class DropCoinInstance : MonoBehaviour
    {
        public void Drop(GameObject dropPrefab)
        {
            Instantiate(dropPrefab, this.gameObject.transform.position, this.gameObject.transform.rotation);
            EnemyAttribute.dropCoinInstanceCounter++;
        }
    }
}
