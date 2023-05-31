using UnityEngine;

namespace Core.Weapon
{
    public class BulletDelete : MonoBehaviour
    {
        
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Wall"))
            {
                BulletDestroy();
            }
            else if (collision.gameObject.CompareTag("Enemy"))
            {
                BulletDestroy();
            }

        }

        private void BulletDestroy()
        {
            Destroy(this.gameObject);
        }
    }
}