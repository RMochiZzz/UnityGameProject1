using UnityEngine;

namespace Core.Character.Player
{
    public class PlayerAttribute : MonoBehaviour
    {
        [SerializeField] private float playerSpeed;
        [SerializeField] private int playerStamina;

        public float PlayerSpeed { get => playerSpeed; set => playerSpeed = value; }
        public int PlayerStamina { get => playerStamina; set => playerStamina = value; }
    }
}
