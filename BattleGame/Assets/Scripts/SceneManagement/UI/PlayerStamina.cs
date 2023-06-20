using UnityEngine;
using TMPro;
using Core.Character.Player;

namespace SceneManagement.UI
{
    public class PlayerStamina : MonoBehaviour
    {
        private TextMeshProUGUI staminaText;
        private PlayerAttribute playerAttribute;

        private void Start()
        {
            staminaText = GetComponent<TextMeshProUGUI>();
            playerAttribute = GetComponent<PlayerAttribute>();
        }

        void Update()
        {
            staminaText.text = playerAttribute.PlayerStamina.ToString();
        }


    }
}
