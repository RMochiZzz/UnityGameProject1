using UnityEngine;


namespace Core.Movement
{
    public class ChildObjectFollow : MonoBehaviour
    {
        public Transform childPosition;

        private void Update()
        {

            transform.position = childPosition.position;
        }
    }

}
