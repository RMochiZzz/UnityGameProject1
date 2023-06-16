using UnityEngine;
using SceneManagement;

namespace Core.Character.Player
{
    public class PlayerDamage : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {

            if (!collision.gameObject.CompareTag("Enemy"))
            if (!collision.gameObject.CompareTag("Rupture")) return;


            PlayerAttribute.playerStamina--;

            if (PlayerAttribute.playerStamina > 0) return;

            EndOfPlayback.QuitGame();
        }
    }
}
