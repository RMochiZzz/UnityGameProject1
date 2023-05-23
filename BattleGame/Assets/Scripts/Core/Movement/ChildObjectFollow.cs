using UnityEngine;


namespace Core.Movement
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
