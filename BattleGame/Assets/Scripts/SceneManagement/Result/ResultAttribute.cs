using UnityEngine;

namespace SceneManagement.Result
{
    public class ResultAttribute : MonoBehaviour
    {
        private float time;
        private int killCount;
        private int playerHealth;

        public float Time { get => time; set => time = value; }
        public int KillCount { get => killCount; set => killCount = value; }

        public int PlayerHealth { get => playerHealth; set => playerHealth = value; }

    }
}
