using UnityEngine;

namespace Core.Movement
{
    public class MapLoopReceptor : MonoBehaviour
    {
        private Vector3 offset;
        private MapLoopNotifier notifier;

        private void Start()
        {
            notifier = FindObjectOfType<MapLoopNotifier>();
            if (notifier == null)
            {
                GameObject notifierObj = new GameObject("MapLoopNotifier");
                notifier = notifierObj.AddComponent<MapLoopNotifier>();
            }

            notifier.MyEvent += HandleEvent;
        }

        private void HandleEvent(Vector3 playerPosition)
        {
            Vector3 newPosition = playerPosition + offset;
            transform.position = newPosition;
        }

        private void OnDestroy()
        {
            if (notifier != null)
            {
                notifier.MyEvent -= HandleEvent;
            }
        }
    }
}
