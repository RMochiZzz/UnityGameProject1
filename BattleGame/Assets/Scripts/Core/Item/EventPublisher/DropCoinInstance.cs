using UnityEngine;

namespace Core.Item.EventPublisher
{
    public class DropCoinInstance : MonoBehaviour
    {
        private GameObject container;

        public void HandleEvent(GameObject dropPrefab, Vector3 dropPoint)
        {

            Instantiate(dropPrefab, dropPoint, Quaternion.identity, container.transform);
            
        }
    }
}
