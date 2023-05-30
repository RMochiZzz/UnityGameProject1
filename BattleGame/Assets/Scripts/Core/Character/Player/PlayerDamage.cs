using UnityEngine;
using SceneManager;

namespace Core.Character.Player
{
    public class PlayerDamage : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {

            if (!collision.gameObject.CompareTag("Enemy")) return;
           
            PlayerAttribute.playerStamina--;

            if (PlayerAttribute.playerStamina > 0) return;

            EndOfPlayback.QuitGame();
        }
    }
}
