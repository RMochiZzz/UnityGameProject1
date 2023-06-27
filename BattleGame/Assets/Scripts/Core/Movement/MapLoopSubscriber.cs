using UnityEngine;

namespace Core.Movement
{
    public class MapLoopSubscriber : MonoBehaviour
    {
        private MapLoopPublisher publisher;

        private void Start()
        {
            GetReference();
            SubscribeToEvent();
        }

        private void SubscribeToEvent()
        {
            publisher.MyEvent += HandleEvent;
        }

        private void HandleEvent(Vector3 playerPositionBefore, Vector3 playerPositionAfter)
        {
            Vector3 offset = transform.position - playerPositionBefore;
            Vector3 newPosition = playerPositionAfter + offset;

            transform.position = newPosition;
        }

        private void OnDestroy()
        {
            if (publisher != null)
            {
                publisher.MyEvent -= HandleEvent;
            }
        }

        private void GetReference()
        {
            publisher = FindObjectOfType<MapLoopPublisher>();
            if (publisher == null)
            {
                GameObject notifierObj = new GameObject("MapLoopNotifier");
                publisher = notifierObj.AddComponent<MapLoopPublisher>();
            }
        }
    }
}
