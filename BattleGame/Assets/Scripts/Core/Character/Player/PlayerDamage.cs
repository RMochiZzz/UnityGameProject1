using UnityEngine;
using SceneManagement;

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

            if (!collision.gameObject.CompareTag("Enemy"))
            if (!collision.gameObject.CompareTag("Rupture")) return;


            playerAttribute.PlayerStamina--;

            if (playerAttribute.PlayerStamina > 0) return;

            EndOfPlayback.QuitGame();
        }
    }
}
