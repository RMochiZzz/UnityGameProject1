using UnityEngine;
using Core.Character.Enemy;

namespace Core.Movement
{
    public class KnockBack : MonoBehaviour
    {
        [SerializeField] private float knockBackAmount;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.gameObject.CompareTag("Bullet")) return;

            GameObject player = GameObject.Find("Player");

            Vector2 knockBackDerection = -(player.transform.position - transform.position);
            Vector2 knockBackMove = knockBackDerection * knockBackAmount;

            transform.position += new Vector3(knockBackMove.x, knockBackMove.y, 0);
            
        }
    }
}
