using UnityEngine;

namespace Core.Movement
{
    public class KnockBack : MonoBehaviour
    {
        public float knockBackAmount = 0.3f;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Bullet"))
            {
                Vector2 knockBackDerection = -transform.up;
                Vector2 knockBackMove = knockBackDerection * knockBackAmount;

                transform.position += new Vector3(knockBackMove.x, knockBackMove.y, 0);
            }
        }
    }

}
