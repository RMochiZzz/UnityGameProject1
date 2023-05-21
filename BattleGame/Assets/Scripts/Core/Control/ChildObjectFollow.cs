using UnityEngine;


namespace Core.Control
{
    public class ChildObjectFollow : MonoBehaviour
    {
        public Transform childPosition;

        private void FixedUpdate()
        {

            transform.position = childPosition.position;
        }
    }

}
