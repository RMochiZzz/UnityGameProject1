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
            playerAttribute = GameObject.Find("Player").GetComponent<PlayerAttribute>();
        }

        void Update()
        {
            staminaText.text = playerAttribute.CurrentPlayerStamina.ToString();
        }
    }
}
