using Interface.Interfaces;
using UnityEngine;

namespace Interface.Implementations
{
    public class DropCoinEventPublisher : IEventPublisher<GameObject, Vector3>
    {
        public delegate void DropCoinEventHandler(GameObject dropPrefab, Vector3 dropPoint);
        public event DropCoinEventHandler MyEvent;

        public void PublishEvent(GameObject dropPrefab, Vector3 dropPoint)
        {
            OnMyEvent(dropPrefab, dropPoint);
        }

        private void OnMyEvent(GameObject dropPrefab, Vector3 dropPoint)
        {
            MyEvent?.Invoke(dropPrefab, dropPoint);
        }
    }
}
