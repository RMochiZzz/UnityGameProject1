using UnityEngine;

namespace Core.Movement
{
    public class MapLoopSubscriber : MonoBehaviour
    {
        private Vector3 offset;
        private MapLoopPublisher publisher;

        private void Start()
        {
            publisher = FindObjectOfType<MapLoopPublisher>();
            if (publisher == null)
            {
                GameObject notifierObj = new GameObject("MapLoopNotifier");
                publisher = notifierObj.AddComponent<MapLoopPublisher>();
            }

            publisher.MyEvent += HandleEvent;
        }

        private void HandleEvent(Vector3 playerPositionBefore, Vector3 playerPositionAfter)
        {
            offset = transform.position - playerPositionBefore;
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
    }
}
