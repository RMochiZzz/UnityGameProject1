using UnityEngine;

namespace Core.Character.Enemy.Normal
{
    public class NormalAttribute : MonoBehaviour
    {
        [SerializeField] private float enemySpeed;
        [SerializeField] private int enemyStamina;
        [SerializeField] private float spawnInterbal;

        public float EnemySpeed { get => enemySpeed; set => enemySpeed = value; }
        public int EnemyStamina { get => enemyStamina; set => enemyStamina = value; }
        public float SpawnInterbal { get => spawnInterbal; set => spawnInterbal = value; }
    }
}
