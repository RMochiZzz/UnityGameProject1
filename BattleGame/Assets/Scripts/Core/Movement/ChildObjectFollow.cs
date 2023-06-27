using UnityEngine;


namespace Core.Movement
{
    public class ChildObjectFollow : MonoBehaviour
    {
        [SerializeField] private Transform childPosition;

        private void Update()
        {

            transform.position = childPosition.position;
        }
    }

}
