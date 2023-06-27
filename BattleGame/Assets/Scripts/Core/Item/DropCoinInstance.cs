using UnityEngine;

namespace Core.Item
{
    public class DropCoinInstance : MonoBehaviour
    {
        public void Starter(GameObject dropPrefab, Vector3 dropPoint, GameObject container)
        {
            Drop(dropPrefab, dropPoint, container);
        }
        public void Drop(GameObject dropPrefab, Vector3 dropPoint, GameObject container)
        {

            Instantiate(dropPrefab, dropPoint, Quaternion.identity, container.transform);
            
        }
    }
}
