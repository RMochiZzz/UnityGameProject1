using UnityEngine;

namespace SceneManagement.Battle
{
    public class BattleSceneStatus : MonoBehaviour
    {
        [SerializeField] private float battleTime;
        public float BattleTime { get => battleTime; }

        private float elapsedTime;
        public float ElapsedTime { get => elapsedTime; set => elapsedTime = value; }

    }
}
