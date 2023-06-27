using UnityEngine;

namespace Core.Item
{
    public class DropCoinInstance : MonoBehaviour
    {
        [SerializeField] private Transform container;
        public void Starter(GameObject dropPrefab, Vector3 dropPoint)
        {
            Drop(dropPrefab, dropPoint);
        }
        public void Drop(GameObject dropPrefab, Vector3 dropPoint)
        {

            Instantiate(dropPrefab, dropPoint, Quaternion.identity, container);
            
        }
    }
}
