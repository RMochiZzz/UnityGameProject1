using UnityEngine;


namespace Core.Movement
{
    public class LookAtTarget : MonoBehaviour
    {   
        
        private GameObject targetObject;
        private Transform targetObjectTransform;

        void Start()
        {
            targetObject = GameObject.Find("Player");
            targetObjectTransform = targetObject.transform;
        }

        void FixedUpdate()
        {
            Vector2 targetDirection = targetObjectTransform.position - transform.position;
            transform.up = targetDirection.normalized;

        }
    }
}
