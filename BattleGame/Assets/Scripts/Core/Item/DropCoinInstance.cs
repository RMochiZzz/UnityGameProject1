using UnityEngine;

namespace Core.Item
{
    public class DropCoinInstance : MonoBehaviour
    {
        private GameObject container;
        public void Starter(GameObject dropPrefab, Vector3 dropPoint)
        {
            GetReference();
            Drop(dropPrefab, dropPoint);
        }
        private void Drop(GameObject dropPrefab, Vector3 dropPoint)
        {

            Instantiate(dropPrefab, dropPoint, Quaternion.identity, container.transform);
            
        }

        private void GetReference() 
        {
            container = GameObject.Find("Coins");
        }
        
    }
}
