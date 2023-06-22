using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyStatus : MonoBehaviour
    {
        [SerializeField] private float enemySpeed;
        [SerializeField] private int enemyStamina;
        private int hitCounter;
        private int destoroyCounter;


        public float EnemySpeed { get => enemySpeed; set => enemySpeed = value; }
        public int EnemyStamina { get => enemyStamina; set => enemyStamina = value; }
        public int HitCounter { get => hitCounter; set => hitCounter = value; }
        public int DestoroyCounter { get => destoroyCounter; set => destoroyCounter = value; }

    }
}
