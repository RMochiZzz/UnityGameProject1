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

        private void HandleEvent(Vector3 playerPositionBefore, Vector3 playerPositionAfter)
        {
            offset = transform.position - playerPositionBefore;
            Vector3 newPosition = playerPositionAfter + offset;
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
