using UnityEngine;

namespace Core.Item.EventSubscriber
{
    public class DropCoinInstance : MonoBehaviour
    {
        public void Starter(GameObject dropPrefab, Vector3 dropPoint)
        {
            Drop(dropPrefab, dropPoint);
        }
        public void Drop(GameObject dropPrefab, Vector3 dropPoint)
        {

            Instantiate(dropPrefab, dropPoint, Quaternion.identity);
            
        }
    }
}
