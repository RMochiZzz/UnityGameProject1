using UnityEngine;

namespace Core.Item.EventPublisher
{
    public class DropCoinInstance : MonoBehaviour
    {

        public void HandleEvent(GameObject dropPrefab, Vector3 dropPoint)
        {

            Instantiate(dropPrefab, dropPoint, Quaternion.identity);
            
        }
    }
}
