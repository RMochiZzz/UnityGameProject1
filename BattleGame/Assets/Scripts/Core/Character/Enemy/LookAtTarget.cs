using UnityEngine;


namespace Core.Character.Enemy
{

    public class LookAtTarget : MonoBehaviour
    {   
        
        public Transform targetObject;

        void FixedUpdate()
        {
            Vector2 targetDirection = targetObject.position - transform.position;
            transform.up = targetDirection.normalized;

        }
    }


}
