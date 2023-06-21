using UnityEngine;

namespace Core.Character.Player
{
    public class PlayerDamage : MonoBehaviour
    {
        private PlayerAttribute playerAttribute;

        void Start () 
        {
            playerAttribute = GetComponent<PlayerAttribute>();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (playerAttribute.PlayerStamina == 0 ||
                !collision.gameObject.CompareTag("Enemy") &&
                !collision.gameObject.CompareTag("Rupture"))
            {
                return;
            }

            playerAttribute.PlayerStamina--;
        }
    }
}
