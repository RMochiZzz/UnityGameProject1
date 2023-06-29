namespace SceneManagement.Result
{
    public class ResultAttribute
    {
        private float time;
        private int killCount;
        private int playerHealth;

        public float RemainingTimeAtEnd { get => time; set => time = value; }
        public int KillCountAtEnd { get => killCount; set => killCount = value; }

        public int PlayerStaminaAtEnd { get => playerHealth; set => playerHealth = value; }

    }
}
