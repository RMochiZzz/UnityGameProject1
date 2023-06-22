using UnityEngine;

namespace Core.Character.Enemy
{
    public class EnemyStatus : MonoBehaviour
    {
        [SerializeField] private float enemySpeed;
        [SerializeField] private int enemyStamina;
        private int hitCounter;
        private int destroyCounter;


        public float EnemySpeed { get => enemySpeed; set => enemySpeed = value; }
        public int EnemyStamina { get => enemyStamina; set => enemyStamina = value; }
        public int HitCounter { get => hitCounter; set => hitCounter = value; }
        public int DestroyCounter { get => destroyCounter; set => destroyCounter = value; }

    }
}
