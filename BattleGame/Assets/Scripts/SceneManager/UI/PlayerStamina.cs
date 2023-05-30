using UnityEngine;
using TMPro;
using Core.Character.Player;

namespace SceneManager.UI
{
    public class PlayerStamina : MonoBehaviour
    {
        private TextMeshProUGUI staminaText;

        private void Start()
        {
            staminaText = GetComponent<TextMeshProUGUI>();
        }

        void Update()
        {
            staminaText.text = PlayerAttribute.playerStamina.ToString();
        }


    }
}
