using UnityEngine;
using Core.Character.Player;

namespace Core.Movement
{
    public class MapLoopReceptor : MonoBehaviour
    {
        private Vector3 vec;

        private void Start()
        {
            MapLoopNotifier.MyEvent += HandleEvent;
        }
        private void FixedUpdate()
        {
            vec = transform.position - PlayerAttribute.playerPosition;
        }
        private void HandleEvent(Vector3 vector3)
        {
            transform.position = vector3 + vec;
        }
        private void OnDestroy()
        {
            MapLoopNotifier.MyEvent -= HandleEvent;
        }
    }
}
