using UnityEngine;

namespace SceneManagement.Battle
{
    public class BattleSceneStatus : MonoBehaviour
    {
        [SerializeField] private float battleTime;
        public float BattleTime { get => battleTime; }


        private float elapsedTime;
        public float CurrentElapsedTime
        { 
            get => elapsedTime; 
            set => elapsedTime = value; 
        }


        public float RemainingTime
        { 
            get => battleTime - elapsedTime;
        }

    }
}
