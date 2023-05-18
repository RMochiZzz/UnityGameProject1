using UnityEngine;

namespace Core.Control
{
    public class Follow : MonoBehaviour
    {
        public Transform target;
        void Update()
        {
            if (target != null)
            {
                Vector3 newPosition = target.position;
                newPosition.z = transform.position.z;
                transform.position = newPosition;
            }
        }
    }
}