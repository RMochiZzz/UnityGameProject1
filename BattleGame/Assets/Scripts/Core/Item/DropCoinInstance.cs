using Core.Character.Item.ValueManipulator;
using Interface.Interfaces;
using UnityEngine;

namespace Core.Item
{
    public class DropCoinInstance : MonoBehaviour
    {
        private GameObject container;

        private IIncrement dropInstanceCounterIncrement;
        public void Starter(GameObject dropPrefab, Vector3 dropPoint)
        {
            GetReference();
            Drop(dropPrefab, dropPoint);
            CounterIncrement();
        }
        private void Drop(GameObject dropPrefab, Vector3 dropPoint)
        {

            Instantiate(dropPrefab, dropPoint, Quaternion.identity, container.transform);
            
        }

        private void CounterIncrement()
        {
            dropInstanceCounterIncrement.Increment();
        }

        private void GetReference() 
        {
            container = GameObject.Find("Coins");
            dropInstanceCounterIncrement = new DropInstanceCounterIncrement();
        }
        
    }
}
