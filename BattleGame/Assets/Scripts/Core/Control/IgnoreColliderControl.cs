using UnityEngine;

namespace Core.Control
{
    public class IgnoreColliderControl : MonoBehaviour
    {
        private Collider2D myCollider;
        public Collider2D otherCollider;

        void Start()
        {
            myCollider = gameObject.GetComponent<Collider2D>();

            Physics2D.IgnoreCollision(myCollider, otherCollider);
        }
    }
}
