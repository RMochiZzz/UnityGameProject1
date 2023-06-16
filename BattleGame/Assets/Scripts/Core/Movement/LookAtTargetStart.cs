using UnityEngine;

namespace Core.Movement
{
    public class LookAtTargetStart : MonoBehaviour
    {   
        
        private GameObject targetObject;
        private Transform targetObjectTransform;

        void Start()
        {
            targetObject = GameObject.Find("Player");
            targetObjectTransform = targetObject.transform;
            Vector2 targetDirection = targetObjectTransform.position - transform.position;
            transform.up = targetDirection.normalized;
        }
    }
}
