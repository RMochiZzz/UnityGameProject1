using UnityEngine;

namespace SceneManagement.Battle
{
    public class BattleSceneStatus : MonoBehaviour
    {
        [SerializeField] private float battleTime;
        public float BattleTime { get => battleTime; }
    }
}
