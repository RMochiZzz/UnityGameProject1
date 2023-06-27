using UnityEngine;

namespace Core.Character.Player
{
    public class PlayerAttribute : MonoBehaviour
    {
        [SerializeField] private float playerSpeed;
        [SerializeField] private int playerStamina;
        private int playerDamage;

        public float PlayerSpeed { get => playerSpeed;}
        public int PlayerStamina { get => playerStamina;}
        public int PlayerDamage { get => playerDamage; set => playerDamage = value; }
        public int CurrentPlayerStamina
        { 
            get => playerStamina - playerDamage;
        }
    }
}
